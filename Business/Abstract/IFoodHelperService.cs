using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFoodHelperService
    {
        IResult Add(FoodHelper foodHelper);
        IResult Update(FoodHelper foodHelper);
        IResult Delete(FoodHelper foodHelper);
        IDataResult<List<FoodHelper>> GetAll();
        IDataResult<FoodHelper> GetById(int foodHelperId);
    }
}
