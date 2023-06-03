using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOperatorHelperDal : EfEntityRepositoryBase<OperatorHelper, EarthquakeContext>, IOperatorHelperDal
    {
        public List<OperatorHelperDetailDto> GetOperatorHelperDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from operatorHelper in context.OperatorHelpers
                             join user in context.Users
                             on operatorHelper.UserId equals user.Id
                             select new OperatorHelperDetailDto()
                             {
                                 Id = operatorHelper.Id,
                                 UserId = operatorHelper.UserId,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = operatorHelper.InfoAboutHelp,
                                 Address=operatorHelper.Address,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }

        public List<OperatorHelperDetailDto> GetOperatorHelperDetailsByEmail(string email)
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from operatorHelper in context.OperatorHelpers
                             join user in context.Users
                             on operatorHelper.UserId equals user.Id
                             where user.Email == email
                             select new OperatorHelperDetailDto()
                             {
                                 Id = operatorHelper.Id,
                                 UserId = operatorHelper.UserId,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = operatorHelper.InfoAboutHelp,
                                 Address = operatorHelper.Address,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }
    }
}