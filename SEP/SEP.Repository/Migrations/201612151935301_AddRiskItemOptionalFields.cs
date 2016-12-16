namespace SEP.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRiskItemOptionalFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RiskItems", "Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.RiskItems", "Coefficient", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RiskItems", "Coefficient", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RiskItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
