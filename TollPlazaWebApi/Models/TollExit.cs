using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Models
{
    public class TollExit
    {
        [Key]
        public int Id { get; set; }
        public int EntryId { get; set; }  // Foreign key to TollEntry
        public string ExitPoint { get; set; }
        public DateTime ExitDate { get; set; }
        public double DistanceTraveled { get; set; } // In KM
        public double TollAmount { get; set; }
        [ForeignKey("EntryId")]
        public virtual TollEntry TollEntry { get; set; }
    }
}
