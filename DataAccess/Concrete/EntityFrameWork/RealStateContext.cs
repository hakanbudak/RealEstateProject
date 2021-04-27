using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class RealStateContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RealState;Trusted_Connection=true");
        }
        public DbSet<House> House { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Region> Region { get; set; }
    }
}
