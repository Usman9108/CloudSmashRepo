using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollPlazaWebApi.Models
{
    public class TollEntry
    {
        [Key]   
        public int Id { get; set; }
        public string VehicleNumber { get; set; } 
        public DateTime EntryDate { get; set; }
        public string EntryPoint { get; set; }

        public bool isActive { get; set; }
    }

    
}
