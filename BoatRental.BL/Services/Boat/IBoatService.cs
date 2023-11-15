using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.BL;

public interface IBoatService
{
    Task AddAsync(BoatAddDto boat);
}
