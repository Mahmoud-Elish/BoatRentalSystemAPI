using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public interface IGenericRepo<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(Guid id);
    Task AddAsync(T item);
    void Update(T item);
    void Delete(T item);
}
