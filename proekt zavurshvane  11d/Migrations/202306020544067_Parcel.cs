namespace proekt_zavurshvane__11d.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Parcel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Weight = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        ProductTypesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypesId, cascadeDelete: true)
                .Index(t => t.ProductTypesId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "ProductTypesId", "dbo.ProductTypes");
            DropIndex("dbo.Parcels", new[] { "ProductTypesId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Parcels");
        }
    }
}
