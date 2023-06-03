using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBuildReporterService
    {
        IResult Add(BuildReporter buildReporter);
        IResult Update(BuildReporter buildReporter);
        IResult Delete(BuildReporter buildReporter);
        IDataResult<List<BuildReporter>> GetAll();
        IDataResult<BuildReporter> GetById(int buildReporterId);
        IDataResult<List<BuildReporterDetailDto>> GetBuildReporterDetails();
        IDataResult<List<BuildReporterDetailDto>> GetBuildReporterDetailsByEmail(string email);
    }
}