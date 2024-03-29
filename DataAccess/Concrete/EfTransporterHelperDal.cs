﻿using Core.DataAccess.EntityFramework;
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
    public class EfTransporterHelperDal:EfEntityRepositoryBase<TransporterHelper, EarthquakeContext>, ITransporterHelperDal
    {
        public List<TransporterHelperDetailDto> GetTransporterHelperDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from transporterHelper in context.TransporterHelpers
                             join user in context.Users
                             on transporterHelper.UserId equals user.Id
                             select new TransporterHelperDetailDto()
                             {
                                 Id = transporterHelper.Id,
                                 UserId = transporterHelper.UserId,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = transporterHelper.InfoAboutHelp,
                                 AddressFrom= transporterHelper.AddressFrom,
                                 AddressTo= transporterHelper.AddressTo,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }

        public List<TransporterHelperDetailDto> GetTransporterHelperDetailsByEmail(string email)
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from transporterHelper in context.TransporterHelpers
                             join user in context.Users
                             on transporterHelper.UserId equals user.Id
                             where user.Email == email
                             select new TransporterHelperDetailDto()
                             {
                                 Id = transporterHelper.Id,
                                 UserId = transporterHelper.UserId,
                                 Email = user.Email,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 InfoAboutHelp = transporterHelper.InfoAboutHelp,
                                 AddressFrom = transporterHelper.AddressFrom,
                                 AddressTo = transporterHelper.AddressTo,
                                 PhoneNumber = user.PhoneNumber,
                             };

                return result.ToList();
            }
        }
    }
}