namespace BlogAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "Created", c => c.DateTime());
            AddColumn("dbo.Users", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreatedDate");
            DropColumn("dbo.BlogPosts", "Created");
        }
    }
}
