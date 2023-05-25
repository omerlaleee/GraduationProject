using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
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

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(BuildReporterValidator))]
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

        //[SecuredOperation("admin")]
        public IDataResult<List<BuildReporter>> GetAll()
        {
            return new SuccessDataResult<List<BuildReporter>>(_buildReporterDal.GetAll());
        }

        public IDataResult<List<BuildReporterDetailDto>> GetBuildReporterDetails()
        {
            return new SuccessDataResult<List<BuildReporterDetailDto>>(_buildReporterDal.GetBuildReporterDetails());
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
