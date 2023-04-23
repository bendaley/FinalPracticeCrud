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
        public DbSet<Major> Majors { get; set; }

        // seed data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Major>().HasData(
                new Major { MajorId = 1, MajorName = "Information Systems" },
                new Major { MajorId = 2, MajorName = "Mechanical Engineering" },
                new Major { MajorId = 3, MajorName = "Elementary Education" },
                new Major { MajorId = 4, MajorName = "Actuarial Science" },
                new Major { MajorId = 5, MajorName = "Neuroscience" },
                new Major { MajorId = 6, MajorName = "Undeclared" }
            );
              


            mb.Entity<GetBryce>().HasData(
                new GetBryce
                {
                    ApplicationId = 1,
                    FirstName = "Ben",
                    LastName = "Daley",
                    Age = 22,
                    Phone = "385-867-5309",
                    MajorId = 1,
                    TommyJohn = true
                },

                new GetBryce
                {
                    ApplicationId = 2,
                    FirstName = "Jessica",
                    LastName = "Daley",
                    Age = 22,
                    Phone = "435-435-4354",
                    MajorId = 1,
                    TommyJohn = false
                },

                new GetBryce
                {
                ApplicationId = 3,
                    FirstName = "Collin",
                    LastName = "Klomp",
                    Age = 23,
                    Phone = "801-801-8018",
                    MajorId = 2,
                    TommyJohn = true
                });
        }
    }
}
