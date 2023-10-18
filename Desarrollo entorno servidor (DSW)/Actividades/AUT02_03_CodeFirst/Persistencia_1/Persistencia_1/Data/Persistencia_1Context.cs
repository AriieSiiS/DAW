using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Persistencia_1.Models;

namespace Persistencia_1.Data
{
    public class Persistencia_1Context : DbContext
    {
        public Persistencia_1Context (DbContextOptions<Persistencia_1Context> options)
            : base(options)
        {

        }

        public DbSet<Persistencia_1.Models.Characters> Characters { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters>().HasData(
                new Characters
                {
                    ID = 1,
                    Name = "Hinata Shoyo",
                    Age = 16,
                    Height = (decimal?)1.64,
                    Team = "Karasuno High School",
                    Position = "Wing Spiker",
                    Retired = false
                },
                new Characters
                {
                    ID = 2,
                    Name = "Kageyama Tobio",
                    Age = 17,
                    Height = (decimal?)1.84,
                    Team = "Karasuno High School",
                    Position = "Setter",
                    Retired = false
                },
                new Characters
                {
                    ID = 3,
                    Name = "Oikawa Tooru",
                    Age = 18,
                    Height = (decimal?)1.87,
                    Team = "Aoba Johsai High School",
                    Position = "Setter",
                    Retired = true
                },
                new Characters
                {
                    ID = 4,
                    Name = "Tsukishima Kei",
                    Age = 17,
                    Height = (decimal?)1.96,
                    Team = "Karasuno High School",
                    Position = "Blocker",
                    Retired = false
                },
                new Characters
                {
                    ID = 5,
                    Name = "Bokuto Koutarou",
                    Age = 18,
                    Height = (decimal?)1.88,
                    Team = "Fukurodani Academy",
                    Position = "Ace",
                    Retired = false
                }
            );
        }

    }

}
