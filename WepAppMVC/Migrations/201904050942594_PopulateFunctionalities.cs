using System;

namespace WepAppMVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateFunctionalities : DbMigration
    {
        public override void Up()
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�򥻸�ƺ޲z', '#', 'fa fa-lg fa-fw fa-cubes txt-color-blue', 0, 1, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�t�Ӹ�ƺ��@', '/infomation/vendors', 'fa fa-fw fa-briefcase', 1, 1, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'���~��ƺ��@', '/infomation/products', 'fa fa-fw fa-cub', 1, 2, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�]��������ƺ��@', '/infomation/stuffcategories', 'fa fa-fw fa-th-list', 1, 3, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�]����ƺ��@', '/infomation/stuff', 'fa fa-fw fa-puzzle-piece', 1, 4, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�~�P������ƺ��@', '/infomation/brands', 'fa fa-fw fa-building-o ', 1, 5, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�N�X��ƺ��@', '/infomation/codes', 'fa fa-fw fa-braille', 1, 6, '{now}', 'LongoriaYu' )");

            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�b���v���޲z', '#', 'fa fa-lg fa-fw fa-users', 0, 2, '{now}', 'LongoriaYu' )");
            Sql($@"Insert Into Functionalities ( Name, Url, Decoration, ParentId, Priority, CreateTime, CreateUser )
                  Values ( N'�H���v���޲z', '/system/users', 'fa fa-fw fa-user-secret', 8, 1, '{now}', 'LongoriaYu' )");
        }

        public override void Down()
        {
            Sql("Truncate Table Functionalities");
        }
    }
}
