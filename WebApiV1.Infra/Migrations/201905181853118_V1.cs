namespace WebApiV1.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsComplete = c.Boolean(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoItems", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.TodoItems", new[] { "Customer_Id" });
            DropTable("dbo.TodoItems");
            DropTable("dbo.Customers");
        }
    }
}
