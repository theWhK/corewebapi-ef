namespace WebApiV1.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 70, fixedLength: true));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 50, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
