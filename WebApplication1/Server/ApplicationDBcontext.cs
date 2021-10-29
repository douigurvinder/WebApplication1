using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared;

namespace WebApplication1.Server
{
    public class ApplicationDBcontext :DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class1>().HasKey(x => new { x.ID });
            modelBuilder.Entity<Class2>().HasKey(x => new { x.ID });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Class1> Cass1Set { get; set; }
        public DbSet<Class2> Class2Set { get; set; }
    }
}
