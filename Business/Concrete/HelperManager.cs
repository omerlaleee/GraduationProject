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
    public class HelperManager : IHelperService
    {
        public IResult Add(Helper Helper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Helper Helper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Helper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Helper> GetById(int HelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Helper Helper)
        {
            throw new NotImplementedException();
        }
    }
}
