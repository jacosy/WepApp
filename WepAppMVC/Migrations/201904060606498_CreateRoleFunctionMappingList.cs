namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateRoleFunctionMappingList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoleFunctionMappings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    RoleId = c.String(nullable: false, maxLength: 128),
                    FunctionalityId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.FunctionalityId, t.RoleId }, unique: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Functionalities", t => t.FunctionalityId, cascadeDelete: true);
        }

        public override void Down()
        {
            DropTable("dbo.RoleFunctionMappings");
        }
    }
}
