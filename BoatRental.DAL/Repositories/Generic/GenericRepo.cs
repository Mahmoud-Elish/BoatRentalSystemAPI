using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly BoatRentalContext _context;

    public GenericRepo(BoatRentalContext context)
    {
        _context = context;
    }
    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking();    //??? & //.Tolist()??
    }
    public T? GetById(Guid id)
    {
        return _context.Set<T>().Find(id);
    }
    public async Task AddAsync(T item)
    {
        await _context.Set<T>().AddAsync(item);
    }
    public void Update(T item)
    {
        //Empty
    }
    public void Delete(T item)
    {
        _context.Set<T>().Remove(item);
    }
}
