using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id=1, BrandId=12, ColorId=19, ModelYear=2020, DailyPrice=700, Description="Gıcır BMW" },
                new Car{ Id=2, BrandId=23, ColorId=5, ModelYear=2010, DailyPrice=200, Description="İş gören Toyota" },
                new Car{ Id=3, BrandId=20, ColorId=14, ModelYear=2014, DailyPrice=300, Description="Tosbik Volkswagen",},
                new Car{ Id=4, BrandId=10, ColorId=9, ModelYear=2019, DailyPrice=500, Description="Asi Jeep" },
                new Car{ Id=5, BrandId=15, ColorId=11, ModelYear=2009, DailyPrice=100, Description="Gıcır Değil ama Audi" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int id)  
        {
            return _cars.Where(c=> c.Id == id).ToList();

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
