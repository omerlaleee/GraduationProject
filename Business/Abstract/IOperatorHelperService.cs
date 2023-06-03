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
    public interface IOperatorHelperService
    {
        IResult Add(OperatorHelper operatorHelper);
        IResult Update(OperatorHelper operatorHelper);
        IResult Delete(OperatorHelper operatorHelper);
        IDataResult<List<OperatorHelper>> GetAll();
        IDataResult<OperatorHelper> GetById(int operatorHelperId);
        IDataResult<List<OperatorHelperDetailDto>> GetOperatorHelperDetails();
        IDataResult<List<OperatorHelperDetailDto>> GetOperatorHelperDetailsByEmail(string email);
    }
}
