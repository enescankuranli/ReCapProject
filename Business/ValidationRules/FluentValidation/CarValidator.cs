using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c=>c.CarId).NotEmpty();
            RuleFor(c => c.CarId).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.BrandId).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10);
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ColorId).GreaterThan(0);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
        }
    }
}
