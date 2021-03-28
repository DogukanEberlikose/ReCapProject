using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(200).When(c => c.BrandId == 2); //TC kimlik no zorunludur, ne zaman tc işareti seçildiğinde
           // RuleFor(c => c.Description).Must(StartsWithA).WithMessage("Ürünler A Harfi ile başlamalı");
        }

        //private bool StartsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
