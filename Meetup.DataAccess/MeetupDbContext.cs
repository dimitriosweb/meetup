using Meetup.Model;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Meetup.DataAccess
{
    public class MeetupDbContext : DbContext
    {
        public MeetupDbContext() : base("MeetupDb")
        {

        }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
