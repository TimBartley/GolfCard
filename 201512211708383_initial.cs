namespace GolfCardReader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Score1 = c.Int(),
                        Score2 = c.Int(),
                        Score3 = c.Int(),
                        Score4 = c.Int(),
                        Score5 = c.Int(),
                        Score6 = c.Int(),
                        Score7 = c.Int(),
                        Score8 = c.Int(),
                        Score9 = c.Int(),
                        teeOff = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cards");
        }
    }
}
