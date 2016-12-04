namespace SEP.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InsuranceRisks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InsuranceTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Risks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        InsuranceType_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InsuranceTypes", t => t.InsuranceType_ID, cascadeDelete: true)
                .Index(t => t.InsuranceType_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Risks", "InsuranceType_ID", "dbo.InsuranceTypes");
            DropIndex("dbo.Risks", new[] { "InsuranceType_ID" });
            DropTable("dbo.Risks");
            DropTable("dbo.InsuranceTypes");
            DropTable("dbo.InsuranceRisks");
        }
    }
}
