using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class BoatRepo : GenericRepo<Boat> , IBoatRepo
{
    private readonly BoatRentalContext _context;
    public BoatRepo(BoatRentalContext context) : base(context)
    {
        _context = context;
    }
}
