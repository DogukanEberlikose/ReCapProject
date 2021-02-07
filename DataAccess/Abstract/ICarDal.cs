using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add();
        void Delete();
        void Update();

        List<Car> GetById(int id);


    }
}
