namespace SEP.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigureInsuranceRisk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RiskItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Coefficient = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.InsuranceRisks", "Insurance_ID", c => c.Int(nullable: false));
            AddColumn("dbo.InsuranceRisks", "RiskItem_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.InsuranceRisks", "Insurance_ID");
            CreateIndex("dbo.InsuranceRisks", "RiskItem_ID");
            AddForeignKey("dbo.InsuranceRisks", "Insurance_ID", "dbo.Insurances", "ID", cascadeDelete: true);
            AddForeignKey("dbo.InsuranceRisks", "RiskItem_ID", "dbo.RiskItems", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InsuranceRisks", "RiskItem_ID", "dbo.RiskItems");
            DropForeignKey("dbo.InsuranceRisks", "Insurance_ID", "dbo.Insurances");
            DropIndex("dbo.InsuranceRisks", new[] { "RiskItem_ID" });
            DropIndex("dbo.InsuranceRisks", new[] { "Insurance_ID" });
            DropColumn("dbo.InsuranceRisks", "RiskItem_ID");
            DropColumn("dbo.InsuranceRisks", "Insurance_ID");
            DropTable("dbo.RiskItems");
            DropTable("dbo.Insurances");
        }
    }
}
