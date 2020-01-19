namespace Ginz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Amount = c.Int(nullable: false),
                        Gin_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gin", t => t.Gin_Id)
                .Index(t => t.Gin_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredient", "Gin_Id", "dbo.Gin");
            DropIndex("dbo.Ingredient", new[] { "Gin_Id" });
            DropTable("dbo.Ingredient");
            DropTable("dbo.Gin");
        }
    }
}
