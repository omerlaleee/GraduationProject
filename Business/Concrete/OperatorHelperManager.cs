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
    public class OperatorHelperManager : IOperatorHelperService
    {
        IOperatorHelperDal _operatorHelperDal;

        public OperatorHelperManager(IOperatorHelperDal operatorHelperDal)
        {
            _operatorHelperDal = operatorHelperDal;
        }

        public IResult Add(OperatorHelper operatorHelper)
        {
            _operatorHelperDal.Add(operatorHelper);
            return new SuccessResult();
        }

        public IResult Delete(OperatorHelper operatorHelper)
        {
            _operatorHelperDal.Delete(operatorHelper);
            return new SuccessResult();
        }

        public IDataResult<List<OperatorHelper>> GetAll()
        {
            return new SuccessDataResult<List<OperatorHelper>>(_operatorHelperDal.GetAll());
        }

        public IDataResult<OperatorHelper> GetById(int operatorHelperId)
        {
            return new SuccessDataResult<OperatorHelper>(_operatorHelperDal.Get(o => o.Id == operatorHelperId));
        }

        public IDataResult<List<OperatorHelperDetailDto>> GetOperatorHelperDetails()
        {
            return new SuccessDataResult<List<OperatorHelperDetailDto>>(_operatorHelperDal.GetOperatorHelperDetails());
        }

        public IDataResult<List<OperatorHelperDetailDto>> GetOperatorHelperDetailsByEmail(string email)
        {
            return new SuccessDataResult<List<OperatorHelperDetailDto>>(_operatorHelperDal.GetOperatorHelperDetailsByEmail(email));
        }

        public IResult Update(OperatorHelper operatorHelper)
        {
            _operatorHelperDal.Update(operatorHelper);
            return new SuccessResult();
        }
    }
}
