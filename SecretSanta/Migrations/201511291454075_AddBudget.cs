namespace SecretSanta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBudget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Budget", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Budget");
        }
    }
}
