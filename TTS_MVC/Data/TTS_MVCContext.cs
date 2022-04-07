using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TTS_MVC.Models;

namespace TTS_MVC.Data
{
    public class TTS_MVCContext : DbContext
    {
        public TTS_MVCContext (DbContextOptions<TTS_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<TTS_MVC.Models.Ticket> Ticket { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasNoKey();
                
        }
        public DbSet<TTS_MVC.Models.Employee> Employee { get; set; }

        

    }
}
