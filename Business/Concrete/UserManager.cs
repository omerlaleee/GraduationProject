using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        
        public IResult Add(User user)
        {
            // user.Status = true;
            _userDal.Add(user);
            return new SuccessResult("Messages.UserAdded");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Messages.UserDeleted");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>("Messages.UsersListed", _userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>("Messages.TheUserListed", _userDal.Get(u => u.Id == userId));
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>("Messages.TheUserListed", _userDal.Get(u => u.Email == email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(int userId)
        {
            return new SuccessDataResult<List<OperationClaim>>("Messages.UserClaimsListed", _userDal.GetClaims(userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Messages.UserUpdated");
        }
    }
}
