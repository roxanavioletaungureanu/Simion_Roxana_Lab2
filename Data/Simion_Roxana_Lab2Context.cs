using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simion_Roxana_Lab2.Models;

namespace Simion_Roxana_Lab2.Data
{
    public class Simion_Roxana_Lab2Context : DbContext
    {
        public Simion_Roxana_Lab2Context (DbContextOptions<Simion_Roxana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Simion_Roxana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Simion_Roxana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Simion_Roxana_Lab2.Models.Category> Category { get; set; }
    }
}
