namespace p00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCommittees : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CommHeeMembers", "CommHeeid", "dbo.CommHees");
            DropIndex("dbo.CommHeeMembers", new[] { "CommHeeid" });
            RenameColumn(table: "dbo.CommHeeMembers", name: "CommHeeid", newName: "CommHee_id");
            AddColumn("dbo.CommHeeMembers", "CommitHeesid", c => c.Int(nullable: false));
            AlterColumn("dbo.CommHeeMembers", "CommHee_id", c => c.Int());
            CreateIndex("dbo.CommHeeMembers", "CommitHeesid");
            CreateIndex("dbo.CommHeeMembers", "CommHee_id");
            AddForeignKey("dbo.CommHeeMembers", "CommitHeesid", "dbo.CommitHees", "id", cascadeDelete: true);
            AddForeignKey("dbo.CommHeeMembers", "CommHee_id", "dbo.CommHees", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CommHeeMembers", "CommHee_id", "dbo.CommHees");
            DropForeignKey("dbo.CommHeeMembers", "CommitHeesid", "dbo.CommitHees");
            DropIndex("dbo.CommHeeMembers", new[] { "CommHee_id" });
            DropIndex("dbo.CommHeeMembers", new[] { "CommitHeesid" });
            AlterColumn("dbo.CommHeeMembers", "CommHee_id", c => c.Int(nullable: false));
            DropColumn("dbo.CommHeeMembers", "CommitHeesid");
            RenameColumn(table: "dbo.CommHeeMembers", name: "CommHee_id", newName: "CommHeeid");
            CreateIndex("dbo.CommHeeMembers", "CommHeeid");
            AddForeignKey("dbo.CommHeeMembers", "CommHeeid", "dbo.CommHees", "id", cascadeDelete: true);
        }
    }
}
