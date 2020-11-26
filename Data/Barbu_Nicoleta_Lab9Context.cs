using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_Lab9.Models;

namespace Barbu_Nicoleta_Lab9.Data
{
    public class Barbu_Nicoleta_Lab9Context : DbContext
    {
        public Barbu_Nicoleta_Lab9Context (DbContextOptions<Barbu_Nicoleta_Lab9Context> options)
            : base(options)
        {
        }

        public DbSet<Barbu_Nicoleta_Lab9.Models.Book> Book { get; set; }

        public DbSet<Barbu_Nicoleta_Lab9.Models.Publisher> Publisher { get; set; }

        public DbSet<Barbu_Nicoleta_Lab9.Models.BookCategory> BookCategory { get; set; }
    }
}
