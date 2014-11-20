namespace DesertStorm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        VehicleID = c.Int(nullable: false),
                        ImageUrl = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.VehicleID, t.ImageUrl })
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.VehicleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "VehicleID", "dbo.Vehicles");
            DropIndex("dbo.Images", new[] { "VehicleID" });
            DropTable("dbo.Images");
        }
    }
}
