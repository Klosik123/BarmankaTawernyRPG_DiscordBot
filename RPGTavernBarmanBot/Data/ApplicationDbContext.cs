using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGTavernBarmanBot.Models;
using Microsoft.EntityFrameworkCore;

namespace RPGTavernBarmanBot.Data
{
    internal class ApplicationDbContext : DbContext
    {
        private string _connectionString = "Server=localhost;User=root;Password=Klosik;Database=taverna;";
        public DbSet<Game> Game { get; set; } = null!;
        public DbSet<Players> Players { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
