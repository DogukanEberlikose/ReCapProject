using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IResult Delete(User user);
        IResult Update(User user);
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        User GetByMail(string email);
    }
}
