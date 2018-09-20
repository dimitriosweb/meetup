namespace Meetup.DataAccess.Migrations
{
    using Meetup.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Meetup.DataAccess.MeetupDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Meetup.DataAccess.MeetupDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Galini", LastName = "Vogiatzi", Email = "galini.vogiatzi@gmail.com" },
                new Friend { FirstName = "Dimitrios", LastName = "Metozis", Email = "dimitrios.metozis@gmail.com" },
                new Friend { FirstName = "Vasileios", LastName = "Katsimalis", Email = "vasileios.katsimalis@gmail.com" },
                new Friend { FirstName = "Konstantinos", LastName = "Kontogiorgos", Email = "Konstantinos.Kontogiorgos@gmail.com" }
                );
        }
    }
}
