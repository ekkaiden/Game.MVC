namespace Game.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameCreates",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 38),
                        Cost = c.Double(nullable: false),
                        Genre = c.String(nullable: false),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                        Genre = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
            DropTable("dbo.GameCreates");
        }
    }
}
