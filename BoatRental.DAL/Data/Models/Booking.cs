using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

[PrimaryKey(nameof(RenterId), nameof(BoatId), nameof(BookingDate))]
public record Booking
{
    public DateTime BookingDate { get; set; }
    public int PeriodPerHours { get; set; }
    public decimal TotalPrice { get; set; }

    public Guid RenterId { get; set; } 
    public Renter Renter { get; set; }
    public Guid BoatId { get; set; } 
    public Boat Boat { get; set; }
   
}
