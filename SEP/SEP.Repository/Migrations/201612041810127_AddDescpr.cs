namespace SEP.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescpr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Insurances", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Insurances", "Description");
        }
    }
}
