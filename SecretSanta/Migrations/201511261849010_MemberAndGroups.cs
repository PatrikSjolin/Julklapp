namespace SecretSanta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberAndGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        HasGotPresent = c.Boolean(nullable: false),
                        HasGivenPresent = c.Boolean(nullable: false),
                        Group_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Members", new[] { "Group_Id" });
            DropTable("dbo.Members");
            DropTable("dbo.Groups");
        }
    }
}
