using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public record Boat
{
    public required Guid Id { get; set; }
    public string Name { get; set; }
    public required string BoatNumber { get; set; }
    [Range(0, 5)]
    public int Rate { get; set; }
    public string Specifications { get; set; }
    public string Services { get; set; }

    public decimal HourlyPrice { get; set; }
    [Range(0, 1)]
    public float Discount { get; set; }

    //[ForeignKey(nameof(Customer))]
    public Guid OwnerId { get; set; }
    public Owner Owner { get; set; }

    public IEnumerable<Booking> Bookings { get; set; }
}
