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
    public class FoodHelperManager : IFoodHelperService
    {
        public IResult Add(FoodHelper foodHelper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(FoodHelper foodHelper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<FoodHelper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<FoodHelper> GetById(int foodHelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(FoodHelper foodHelper)
        {
            throw new NotImplementedException();
        }
    }
}
