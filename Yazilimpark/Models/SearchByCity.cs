using System.ComponentModel.DataAnnotations;

namespace Yazilimpark.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is empty!")]
        [Display(Name = "City Name")]
        public string? CityName { get; set; }
    }
}