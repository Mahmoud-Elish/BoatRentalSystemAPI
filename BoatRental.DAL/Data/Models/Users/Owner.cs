using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class Owner : User
{
    public IEnumerable<Boat> Boats { get; set; }
}
