using Core.Domain.Administration;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Students>().HasData(new Students
            {
                Id = new Guid("06d5dc01-15bb-411f-8777-214984d65e70"),
                FirstName = "Alex",
                LastName = "Green",
                Email = "alex@gmail.com"
            });

            modelbuilder.Entity<Students>().HasData(new Students
            {
                Id = new Guid("ddce70b8-9bb9-47f2-a33c-f8d221dba83b"),
                FirstName = "Maria",
                LastName = "Green",
                Email = "mariya@gmail.com"
            });

        }
    }
}
