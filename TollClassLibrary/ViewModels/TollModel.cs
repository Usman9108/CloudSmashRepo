using System.ComponentModel.DataAnnotations;

namespace TollClassLibrary.ViewModels
{
    public class TollModel
    {
        [Required]
        public string InterchangeName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [RegularExpression("[A-Za-z]{3}-[0-9]{3}")]
        public string VehicleNumber { get; set; }
    }
}
