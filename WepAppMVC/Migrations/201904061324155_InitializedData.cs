namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitializedData : DbMigration
    {
        public override void Up()
        {
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'倉儲主管' )");
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'系統管理者' )");
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'包材採購主管' )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int

                  Select @roleId = Id from AspNetRoles where Name = N'倉儲主管'
                  Select @functionalityId = Id from Functionalities where Name = N'基本資料管理'

                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int
                  
                  Select @roleId = Id from AspNetRoles where Name = N'系統管理者'

                  Select @functionalityId = Id from Functionalities where Name = N'基本資料管理'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )
                  
                  Select @functionalityId = Id from Functionalities where Name = N'帳號權限管理'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int

                  Select @roleId = Id from AspNetRoles where Name = N'包材採購主管'
                   
                  Select @functionalityId = Id from Functionalities where Name = N'包材種類資料維護'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )

                  Select @functionalityId = Id from Functionalities where Name = N'包材資料維護'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )

                  Select @functionalityId = Id from Functionalities where Name = N'廠商資料維護'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )");
        }

        public override void Down()
        {
            Sql("Delete dbo.RoleFunctionMappings");
            Sql("Delete dbo.AspNetRoles");
        }
    }
}
