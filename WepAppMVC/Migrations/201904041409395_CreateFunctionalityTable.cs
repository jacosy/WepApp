namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateFunctionalityTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Functionalities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 20),
                    Url = c.String(maxLength: 256),
                    Decoration = c.String(maxLength: 256),
                    ParentId = c.Int(nullable: false),
                    Priority = c.Short(storeType: "tinyint"),
                    CreateTime = c.DateTime(nullable: false),
                    CreateUser = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ParentId);


        }

        public override void Down()
        {
            DropTable("dbo.Functionalities");
        }
    }
}
