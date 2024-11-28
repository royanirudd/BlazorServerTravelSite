
using System.ComponentModel.DataAnnotations;

namespace TravelSite.Models;

public class Hotel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the Hotel Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the star rating")]
    [Range(1, 5)]
    public int StarRating { get; set; }

    [Required(ErrorMessage = "Please enter the nightly cost")]
    public decimal NightlyCost { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
