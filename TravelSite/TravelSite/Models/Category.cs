
using System.ComponentModel.DataAnnotations;

namespace TravelSite.Models;

public class Category
{

    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the Category Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the Description")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Please enter the Country")]
    public string Country { get; set; }

    public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
