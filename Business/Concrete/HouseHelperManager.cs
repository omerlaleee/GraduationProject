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
    public class HouseHelperManager : IHouseHelperService
    {
        public IResult Add(HouseHelper houseHelper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(HouseHelper houseHelper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<HouseHelper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<HouseHelper> GetById(int houseHelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(HouseHelper houseHelper)
        {
            throw new NotImplementedException();
        }
    }
}
