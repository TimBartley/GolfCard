namespace GolfCardReader.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GolfCardReader.Models.GolfCardDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GolfCardReader.Models.GolfCardDBContext context)
        {

        }
    }
}
