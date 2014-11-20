namespace DesertStorm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        MakeID = c.Int(nullable: false, identity: true),
                        MakeTitle = c.String(),
                    })
                .PrimaryKey(t => t.MakeID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelTitle = c.String(),
                        Make_MakeID = c.Int(),
                    })
                .PrimaryKey(t => t.ModelID)
                .ForeignKey("dbo.Makes", t => t.Make_MakeID)
                .Index(t => t.Make_MakeID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        Model_ModelID = c.Int(),
                    })
                .PrimaryKey(t => t.VehicleID)
                .ForeignKey("dbo.Models", t => t.Model_ModelID)
                .Index(t => t.Model_ModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Model_ModelID", "dbo.Models");
            DropForeignKey("dbo.Models", "Make_MakeID", "dbo.Makes");
            DropIndex("dbo.Vehicles", new[] { "Model_ModelID" });
            DropIndex("dbo.Models", new[] { "Make_MakeID" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
        }
    }
}
