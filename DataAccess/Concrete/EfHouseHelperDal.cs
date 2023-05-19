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
    public class EfHouseHelperDal:EfEntityRepositoryBase<HouseHelper, EarthquakeContext>, IHouseHelperDal
    {
        public List<HouseHelperDetailDto> GetHouseHelperDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from houseHelper in context.HouseHelpers
                             join user in context.Users
                             on houseHelper.UserId equals user.Id
                             select new HouseHelperDetailDto()
                             {
                                 Id = houseHelper.Id,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = houseHelper.InfoAboutHelp,
                                 MapsAddress = houseHelper.MapsAddress,
                                 NumberOfPeople = houseHelper.NumberOfPeople,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }
    }
}