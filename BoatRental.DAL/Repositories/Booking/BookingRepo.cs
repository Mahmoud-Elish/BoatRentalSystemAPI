using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class BookingRepo : GenericRepo<Booking>, IBookingRepo
{
    private readonly BoatRentalContext _context;
    public BookingRepo(BoatRentalContext context) : base(context)
    {
        _context = context;
    }
}
