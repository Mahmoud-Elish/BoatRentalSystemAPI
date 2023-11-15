using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class UserRepo : GenericRepo<User>, IUserRepo
{
    private readonly BoatRentalContext _context;
    public UserRepo(BoatRentalContext context) : base(context)
    {
        _context = context;
    }
}
