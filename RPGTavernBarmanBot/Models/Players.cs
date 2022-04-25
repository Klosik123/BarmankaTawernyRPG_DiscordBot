using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPGTavernBarman.Modules;
using System.ComponentModel.DataAnnotations;
namespace RPGTavernBarman.Models
{
    public class Players
    {
        [Key]
        public Guid Guid { get; set; }
        public string Name { get; set; } = null!;
        public string ServerID { get; set; } = null!;
    }
}
