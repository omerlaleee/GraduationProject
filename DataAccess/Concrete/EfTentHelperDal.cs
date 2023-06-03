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
    public class EfTentHelperDal:EfEntityRepositoryBase<TentHelper, EarthquakeContext>, ITentHelperDal
    {
        public List<TentHelperDetailDto> GetTentHelperDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from tentHelper in context.TentHelpers
                             join user in context.Users
                             on tentHelper.UserId equals user.Id
                             select new TentHelperDetailDto()
                             {
                                 Id = tentHelper.Id,
                                 UserId = tentHelper.UserId,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = tentHelper.InfoAboutHelp,
                                 MapsAddress = tentHelper.MapsAddress,
                                 NumberOfPeople = tentHelper.NumberOfPeople,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }
    }
}