using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             // join r in context.Colors
                             on c.Id equals b.BrandId // r.colorId olmaz mı?
                             select new CarDetailDto { CarId = c.Id, BrandName = b.BrandName, ModelYear = c.ModelYear, Description = c.Description, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}