using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGTavernBarman.Models;
using RPGTavernBarman.Modules;
using Microsoft.EntityFrameworkCore;

namespace RPGTavernBarman.Data
{
    public class ApplicationDbContext : DbContext
    {
        private string _connectionString = "Server=localhost;User=root;Password=Klosik;Database=taverna;";
        public DbSet<Games> Game { get; set; } = null!;
        public DbSet<Players> Players { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
