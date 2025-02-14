using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollPlazaWebApi.Models;

namespace TollPlazaWebApi.Models
{
    public class SpecialDiscountDay
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Month_Day { get; set; }
    }
}
