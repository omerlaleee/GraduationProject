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
            var user = _userDal.Get(u => u.Email == email);
            if (user != null)
            {
                return new SuccessDataResult<User>("Messages.TheUserListed", user);
            }
            return new ErrorDataResult<User>("Messages.TheUserNotExist", user);

        }

        public IDataResult<List<OperationClaim>> GetClaims(int userId)
        {
            if (DoesExist(userId).Success)
            {
                if (_userDal.GetClaims(userId).Count != 0)
                {
                    return new SuccessDataResult<List<OperationClaim>>("Messages.UserClaimsListed", _userDal.GetClaims(userId));
                }
                return new ErrorDataResult<List<OperationClaim>>("Messages.UserDoesNotHaveAnyClaim", _userDal.GetClaims(userId));
            }
            return new ErrorDataResult<List<OperationClaim>>("Messages.UserDoesNotExist");
        }

        public IResult IsAdmin(int userId)
        {
            if (DoesExist(userId).Success)
            {
                List<OperationClaim> claimsOfUser = new List<OperationClaim>();
                claimsOfUser = GetClaims(userId).Data;
                if (claimsOfUser != null)
                {
                    foreach (var item in claimsOfUser)
                    {
                        if (item.Name == "admin")
                        {
                            return new SuccessResult("Messages.TheUserIsAdmin");
                        }
                    }
                    return new ErrorResult("Messages.TheUserIsNotAdmin");
                }
                return new ErrorResult("Messages.TheUserIsNotAdmin");
            }
            return new ErrorResult("Messages.TheUserDoesNotExist");
        }

        public IResult DoesExist(int userId)
        {
            if (GetById(userId).Data != null)
            {
                return new SuccessResult("Messages.TheUserExists");
            }
            return new ErrorResult("Messages.TheUserDoesNotExist");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Messages.UserUpdated");
        }
    }
}
