
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FishBuddy.Models
{ 
 
    public class FishLog
    {
        public int ID { get; set; }

        [Display(Name = "Date")]
        public string? Date { get; set; }

        [Required]
        [Display(Name = "Fish Name")]
        [StringLength(30, ErrorMessage = "Please enter a fish name 30 characters or less.")]
        public string? FishName { get; set; }

        [Display(Name = "Location")]
        public string? Location { get; set; }

        [Display(Name = "Length")]
        public string? MaxLength { get; set; }

        [Display(Name = "Weight")]
        public string? MaxWeight { get; set; }

       


    }
}
