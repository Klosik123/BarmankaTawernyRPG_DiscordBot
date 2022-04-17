using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPGTavernBarman.Modules;
using System.ComponentModel.DataAnnotations;
namespace RPGTavernBarmanBot.Models
{
    internal class Game
    {
        [Key]
        public Guid Guid { get; set; } 
        public string Name { get; set; } = null!;
        public string System { get; set; } = null!;
        public string GameColor { get; set; } = null!;
        public string GameMaster { get; set; } = null!;
        public ICollection<Players> Players = null!;
        public string ServerDiscordId { get; set; } = null!;

    }
}
