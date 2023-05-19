using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
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
    public class EfFoodHelperDal : EfEntityRepositoryBase<FoodHelper, EarthquakeContext>, IFoodHelperDal
    {
        public List<FoodHelperDetailDto> GetFoodHelperDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from foodHelper in context.FoodHelpers
                             join user in context.Users
                             on foodHelper.UserId equals user.Id
                             select new FoodHelperDetailDto()
                             {
                                 Id = foodHelper.Id,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = foodHelper.InfoAboutHelp,
                                 MapsAddress = foodHelper.MapsAddress,
                                 NumberOfPeople = foodHelper.NumberOfPeople,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }
    }


}