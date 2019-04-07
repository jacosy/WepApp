using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using WepAppMVC.Models;

namespace WepAppMVC.DB
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        private DbSet<Functionality> Functionalities { get; set; }
        private DbSet<RoleFunctionMappings> RoleFunctionMappingList { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}