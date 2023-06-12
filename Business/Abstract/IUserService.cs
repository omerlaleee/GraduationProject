using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAllWithoutAdmins();
        IDataResult<User> GetById(int userId);
        IDataResult<List<OperationClaim>> GetClaimsOfUser(int userId);
        IDataResult<User> GetByMail(string email);
        IResult IsAdmin(int userId);
        IResult DoesExist(int userId);
    }

}
