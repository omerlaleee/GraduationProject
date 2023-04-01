using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BuildReporterManager : IBuildReporterService
    {
        IBuildReporterDal _buildReporterDal;
        public BuildReporterManager(IBuildReporterDal buildReporterDal)
        {
            _buildReporterDal = buildReporterDal;
        }

        public IResult Add(BuildReporter buildReporter)
        {
            _buildReporterDal.Add(buildReporter);
            return new SuccessResult();
        }

        public IResult Delete(BuildReporter buildReporter)
        {
            _buildReporterDal.Delete(buildReporter);
            return new SuccessResult();
        }

        public IDataResult<List<BuildReporter>> GetAll()
        {
            return new SuccessDataResult<List<BuildReporter>>(_buildReporterDal.GetAll());
        }

        public IDataResult<BuildReporter> GetById(int buildReporterId)
        {
            return new SuccessDataResult<BuildReporter>(_buildReporterDal.Get(b => b.Id == buildReporterId));
        }

        public IResult Update(BuildReporter buildReporter)
        {
            _buildReporterDal.Update(buildReporter);
            return new SuccessResult();
        }
    }
}
