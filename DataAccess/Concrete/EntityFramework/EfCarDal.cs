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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                IQueryable<CarDetailDto> result = from car in filter is null ? context.Cars : context.Cars.Where(filter)
                                                               join brand in context.Brands
                                                                   on car.BrandId equals brand.BrandId
                                                               join color in context.Colors
                                                                   on car.ColorId equals color.ColorId
                                                               select new CarDetailDto
                                                               {
                                                                   CarId = car.Id,
                                                                   BrandName = brand.BrandName,
                                                                   ColorName = color.ColorName,
                                                                   ModelYear=car.ModelYear,
                                                                   Description=car.Description,
                                                                   DailyPrice=car.DailyPrice
                                                               };
                return result.ToList();
            }
        }
    }
}