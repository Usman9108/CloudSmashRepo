using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Models
{
    public class EntryPoint
    {
        [Key]
        public int Id { get; set; }
        public string PointName { get; set; }
        public int KMFromZeroPoint { get; set; }
    }
}
