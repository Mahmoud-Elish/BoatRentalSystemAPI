using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly BoatRentalContext _context;
    public IUserRepo UserRepo { get; }

    public IBoatRepo BoatRepo { get; }

    public IBookingRepo BookingRepo { get; }

    public UnitOfWork(BoatRentalContext context, IUserRepo userRepo, IBoatRepo boatRepo, IBookingRepo bookingRepo)
    {
        _context = context;
        UserRepo = userRepo;
        BoatRepo = boatRepo;
        BookingRepo = bookingRepo;
    }

    public async Task<int> SaveChange()
    {
        return await _context.SaveChangesAsync();
    }
}
