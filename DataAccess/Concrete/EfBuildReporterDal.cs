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
    public class EfBuildReporterDal : EfEntityRepositoryBase<BuildReporter, EarthquakeContext>, IBuildReporterDal
    {
        public List<BuildReporterDetailDto> GetBuildReporterDetails()
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from buildReporter in context.BuildReporters
                             join user in context.Users
                             on buildReporter.UserId equals user.Id
                             select new BuildReporterDetailDto()
                             {
                                 Id = buildReporter.Id,
                                 UserId = buildReporter.UserId,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 PhoneNumber = user.PhoneNumber,
                                 Address = buildReporter.Address,
                                 DetailedAddress = buildReporter.DetailedAddress,
                                 MapsAddress = buildReporter.MapsAddress,
                                 Urgency = buildReporter.Urgency
                             };

                return result.ToList();
            }
        }

        public List<BuildReporterDetailDto> GetBuildReporterDetailsByEmail(string email)
        {
            using (EarthquakeContext context = new EarthquakeContext())
            {
                var result = from buildReporter in context.BuildReporters
                             join user in context.Users
                             on buildReporter.UserId equals user.Id
                             where user.Email == email
                             select new BuildReporterDetailDto()
                             {
                                 Id = buildReporter.Id,
                                 UserId = buildReporter.UserId,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 PhoneNumber = user.PhoneNumber,
                                 Address = buildReporter.Address,
                                 DetailedAddress = buildReporter.DetailedAddress,
                                 MapsAddress = buildReporter.MapsAddress,
                                 Urgency = buildReporter.Urgency
                             };

                return result.ToList();
            }
        }
    }
}