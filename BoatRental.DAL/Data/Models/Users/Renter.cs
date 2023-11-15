using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class Renter : User
{
    public IEnumerable<Booking> Bookings { get; set; }

}
