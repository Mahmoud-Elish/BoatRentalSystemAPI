using BoatRental.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.BL;

public record BoatAddDto
{

    public string Name { get; set; }
    [Required(ErrorMessage = "Boat number is required")]
    //[Unique(nameof(BoatNumber), typeof(YourEntity), _genericRepo)]
    [Unique(nameof(BoatNumber))]
    public required string BoatNumber { get; set; }
    public string Specifications { get; set; }
    public string Services { get; set; }

    public decimal HourlyPrice { get; set; }
    [Range(0,1, ErrorMessage = "Hourly price must be between 0 and 1")]
    public float Discount { get; set; }
    // must be exist (ErrorMessage = "owner not found")
    public Guid OwnerId { get; set; }
}
