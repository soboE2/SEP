namespace SEP.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRiskForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RiskItems", "Risk_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.RiskItems", "Risk_ID");
            AddForeignKey("dbo.RiskItems", "Risk_ID", "dbo.Risks", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RiskItems", "Risk_ID", "dbo.Risks");
            DropIndex("dbo.RiskItems", new[] { "Risk_ID" });
            DropColumn("dbo.RiskItems", "Risk_ID");
        }
    }
}
