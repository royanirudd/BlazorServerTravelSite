using System.ComponentModel.DataAnnotations;

namespace TravelSite.Models;

public class Testimonial
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter occupation")]
    public string Occupation { get; set; }

    [Required(ErrorMessage = "Please enter message")]
    public string Message { get; set; }

    [Required(ErrorMessage = "Please enter rating")]
    [Range(1, 5)]
    public int Rating { get; set; }
}
