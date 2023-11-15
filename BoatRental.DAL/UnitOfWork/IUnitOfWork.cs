using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public interface IUnitOfWork
{
    IUserRepo UserRepo { get; }
    IBoatRepo BoatRepo { get; }
    IBookingRepo BookingRepo { get; }

    Task<int> SaveChange();
}
