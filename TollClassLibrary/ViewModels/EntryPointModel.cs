using System.ComponentModel.DataAnnotations;

namespace TollClassLibrary.ViewModels
{
    public class EntryPointModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int KMFromZeroPoint { get; set; }
    }
}
