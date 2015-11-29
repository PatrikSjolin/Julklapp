namespace SecretSanta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Receiver", c => c.Guid());
            DropColumn("dbo.Members", "HasGivenPresent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "HasGivenPresent", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "Receiver");
        }
    }
}
