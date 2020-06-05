using System;
using Microsoft.EntityFrameworkCore;
using POO3.Models;

namespace POO3.database
{
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {

        }
        public DbSet<POO3.Models.Serie> Serie { get; set; }
        public DbSet<POO3.Models.Episodio> Episodio { get; set; }

    }
}
