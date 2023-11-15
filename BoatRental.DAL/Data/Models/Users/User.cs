using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.DAL;

public class User : IdentityUser<Guid>
{
    public UserRole Role { get; set; }
}
public enum UserRole
{
    Admin, Renter, Owner
}