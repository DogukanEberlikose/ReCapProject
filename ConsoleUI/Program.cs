using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal()); 
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "/" + car.ModelYear + "/" + car.Description + "/" + car.DailyPrice );
            }
            
        }
    }
}
