using Business.Abstract;
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
    public class TransporterHelperManager : ITransporterHelperService
    {
        ITransporterHelperDal _transporterHelperDal;

        public TransporterHelperManager(ITransporterHelperDal transporterHelperDal)
        {
            _transporterHelperDal = transporterHelperDal;
        }

        public IResult Add(TransporterHelper transporterHelper)
        {
            _transporterHelperDal.Add(transporterHelper);
            return new SuccessResult();
        }

        public IResult Delete(TransporterHelper transporterHelper)
        {
            _transporterHelperDal.Delete(transporterHelper);
            return new SuccessResult();
        }

        public IDataResult<List<TransporterHelper>> GetAll()
        {
            return new SuccessDataResult<List<TransporterHelper>>(_transporterHelperDal.GetAll());
        }

        public IDataResult<TransporterHelper> GetById(int transporterHelperId)
        {
            return new SuccessDataResult<TransporterHelper>(_transporterHelperDal.Get(t => t.Id == transporterHelperId));
        }

        public IDataResult<List<TransporterHelperDetailDto>> GetTransporterHelperDetails()
        {
            return new SuccessDataResult<List<TransporterHelperDetailDto>>(_transporterHelperDal.GetTransporterHelperDetails());
        }

        public IDataResult<List<TransporterHelperDetailDto>> GetTransporterHelperDetailsByEmail(string email)
        {
            return new SuccessDataResult<List<TransporterHelperDetailDto>>(_transporterHelperDal.GetTransporterHelperDetailsByEmail(email));
        }

        public IResult Update(TransporterHelper transporterHelper)
        {
            _transporterHelperDal.Update(transporterHelper);
            return new SuccessResult();
        }
    }
}
