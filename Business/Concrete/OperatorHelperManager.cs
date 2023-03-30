using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OperatorHelperManager : IOperatorHelperService
    {
        public IResult Add(OperatorHelper operatorHelper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(OperatorHelper operatorHelper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperatorHelper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<OperatorHelper> GetById(int operatorHelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(OperatorHelper operatorHelper)
        {
            throw new NotImplementedException();
        }
    }
}
