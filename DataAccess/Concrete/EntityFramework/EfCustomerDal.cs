using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on  u.Id equals c.UserId
                             select new CustomerDetailDto { UserId = u.Id, FirstName = u.FirstName, CompanyName = c.CompanyName, Email = u.Email, LastName = u.LastName};
                return result.ToList();
            }
        }
    }
}
