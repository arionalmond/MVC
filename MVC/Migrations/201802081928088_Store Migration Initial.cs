namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoreMigrationInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                        Address = c.String(),
                        BusinessHours = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stores");
            DropTable("dbo.Cards");
        }
    }
}
