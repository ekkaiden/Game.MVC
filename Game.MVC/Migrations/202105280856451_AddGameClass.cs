namespace Game.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGameClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListGameDetails",
                c => new
                    {
                        Number = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                        Genre = c.String(),
                        Rating = c.Int(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Number);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListGameDetails");
        }
    }
}
