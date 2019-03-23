using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WepAppMVC.Startup))]
namespace WepAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
