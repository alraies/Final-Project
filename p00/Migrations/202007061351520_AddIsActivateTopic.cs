namespace p00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActivateTopic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "isActivate", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Topics", "isActivate");
        }
    }
}
