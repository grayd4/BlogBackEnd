namespace BlogAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BlogPost_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPost_Id)
                .Index(t => t.BlogPost_Id);
            
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        Created = c.DateTime(),
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
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "BlogPost_Id", "dbo.BlogPosts");
            DropForeignKey("dbo.BlogPosts", "Author_Id", "dbo.Users");
            DropIndex("dbo.BlogPosts", new[] { "Author_Id" });
            DropIndex("dbo.Photos", new[] { "BlogPost_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.BlogPosts");
            DropTable("dbo.Photos");
        }
    }
}
