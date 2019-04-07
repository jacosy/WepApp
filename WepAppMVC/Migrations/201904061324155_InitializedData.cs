namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitializedData : DbMigration
    {
        public override void Up()
        {
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'���x�D��' )");
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'�t�κ޲z��' )");
            Sql(@"Insert into AspNetRoles ( Id, Name ) values ( NewId(), N'�]�����ʥD��' )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int

                  Select @roleId = Id from AspNetRoles where Name = N'���x�D��'
                  Select @functionalityId = Id from Functionalities where Name = N'�򥻸�ƺ޲z'

                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int
                  
                  Select @roleId = Id from AspNetRoles where Name = N'�t�κ޲z��'

                  Select @functionalityId = Id from Functionalities where Name = N'�򥻸�ƺ޲z'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )
                  
                  Select @functionalityId = Id from Functionalities where Name = N'�b���v���޲z'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )");

            Sql(@"Declare @roleId nvarchar(128)
                  Declare @functionalityId int

                  Select @roleId = Id from AspNetRoles where Name = N'�]�����ʥD��'
                   
                  Select @functionalityId = Id from Functionalities where Name = N'�]��������ƺ��@'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )

                  Select @functionalityId = Id from Functionalities where Name = N'�]����ƺ��@'
                  Insert into RoleFunctionMappings ( RoleId, FunctionalityId )
                  Values ( @roleId, @functionalityId )

                  Select @functionalityId = Id from Functionalities where Name = N'�t�Ӹ�ƺ��@'
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
