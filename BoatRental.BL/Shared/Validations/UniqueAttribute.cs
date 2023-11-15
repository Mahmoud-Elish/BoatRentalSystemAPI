using BoatRental.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.BL;

public class UniqueAttribute : ValidationAttribute
{
    private readonly string _propertyName;
    //private readonly Type _entityType;
    private readonly IGenericRepo<object> _genericRepo;

    public UniqueAttribute(string propertyName /*, Type entityType*/)
    {
        _propertyName = propertyName;
        //_entityType = entityType;
        _genericRepo = new GenericRepo<object>(new BoatRentalContext(new DbContextOptions<BoatRentalContext>()));
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_propertyName);
        var propertyValue = property.GetValue(validationContext.ObjectInstance, null);

        var isUnique = !_genericRepo.GetAll()
            .Any(e => EF.Property<object>(e, _propertyName).Equals(propertyValue));

        return isUnique
            ? ValidationResult.Success
            : new ValidationResult($"{_propertyName} must be unique.");
    }
}




