namespace Finalv1DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeliveryType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliverymanTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Deliverymen", "dtId", c => c.Int(nullable: false));
            CreateIndex("dbo.Deliverymen", "dtId");
            AddForeignKey("dbo.Deliverymen", "dtId", "dbo.DeliverymanTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliverymen", "dtId", "dbo.DeliverymanTypes");
            DropIndex("dbo.Deliverymen", new[] { "dtId" });
            DropColumn("dbo.Deliverymen", "dtId");
            DropTable("dbo.DeliverymanTypes");
        }
    }
}
