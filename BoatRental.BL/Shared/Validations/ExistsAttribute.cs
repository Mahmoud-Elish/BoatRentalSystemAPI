using BoatRental.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.BL;

public class ExistsAttribute : ValidationAttribute
{
    private readonly string _propertyName;
    private readonly Type _entityType;
    private readonly IGenericRepo<object> _genericRepo;

    public ExistsAttribute(string propertyName, Type entityType, IGenericRepo<object> genericRepo)
    {
        _propertyName = propertyName;
        _entityType = entityType;
        _genericRepo = genericRepo;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var property = validationContext.ObjectType.GetProperty(_propertyName);
        var propertyValue = property.GetValue(validationContext.ObjectInstance, null);

        var entity = _genericRepo.GetById((Guid)propertyValue);

        if (entity == null)
        {
            return new ValidationResult($"{_propertyName} does not exist.");
        }

        return ValidationResult.Success;
    }
}



