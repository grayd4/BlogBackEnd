namespace BlogBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        Author_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogPosts", "Author_Id", "dbo.Users");
            DropIndex("dbo.BlogPosts", new[] { "Author_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.BlogPosts");
        }
    }
}
