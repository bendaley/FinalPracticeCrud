using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeNormal.Models
{
    public class BryceApplicationContext : DbContext
    {
        // constructor
        public BryceApplicationContext (DbContextOptions<BryceApplicationContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<GetBryce> HopefulResponses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<GetBryce>().HasData(
                new GetBryce
                {
                    ApplicationId = 1,
                    FirstName = "Ben",
                    LastName = "Daley",
                    Age = 22,
                    Phone = "385-867-5309",
                    Major = "Information Systems",
                    TommyJohn = true
                },

                new GetBryce
                {
                    ApplicationId = 2,
                    FirstName = "Jessica",
                    LastName = "Daley",
                    Age = 22,
                    Phone = "435-435-4354",
                    Major = "Information Systems",
                    TommyJohn = false
                });
        }
    }
}
