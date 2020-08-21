namespace MovieCustomerMvcAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolDobandGenre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
