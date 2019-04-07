namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateUserInfo : DbMigration
    {
        public override void Up()
        {
            Sql(@"Insert into AspNetUsers ( Id, UserName, UserStatus, ValidStartTime, ValidEndTime, Email
                    , EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount)
                  Values ( NewId(), N'LongoriaYu', 1, GetDate(), DateAdd(year, 1, getdate()), N'longoria.you@gmail.com'
                    , 1, 0, 1, 1, 0)");

            Sql(@"Insert into AspNetUsers ( Id, UserName, UserStatus, ValidStartTime, ValidEndTime, Email
                    , EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount)
                  Values ( NewId(), N'MarkLin', 1, GetDate(), DateAdd(year, 1, getdate()), N'marklinwen@seed.net.com'
                    , 1, 0, 1, 1, 0)");

            Sql(@"Declare @userId nvarchar(128)
                  Declare @roleId nvarchar(128)
                  
                  Select @roleId = Id from AspNetRoles where Name = N'系統管理者'

                  Select @userId = Id from AspNetUsers where UserName = N'LongoriaYu'                  
                  Insert into AspNetUserRoles ( UserId, RoleId ) Values ( @userId, @roleId )

                  Select @userId = Id from AspNetUsers where UserName = N'MarkLin'
                  Insert into AspNetUserRoles ( UserId, RoleId ) Values ( @userId, @roleId )");
        }

        public override void Down()
        {
            Sql("Delete AspNetUserRoles");
            Sql("Delete AspNetUsers");
        }
    }
}
