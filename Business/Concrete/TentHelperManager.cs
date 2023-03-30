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
    public class TentHelperManager : ITentHelperService
    {
        public IResult Add(TentHelper tentHelper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TentHelper tentHelper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TentHelper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<TentHelper> GetById(int tentHelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TentHelper tentHelper)
        {
            throw new NotImplementedException();
        }
    }
}
