using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFoodVictimService
    {
        IResult Add(FoodVictim foodVictim);
        IResult Update(FoodVictim foodVictim);
        IResult Delete(FoodVictim foodVictim);
        IDataResult<List<FoodVictim>> GetAll();
        IDataResult<FoodVictim> GetById(int foodVictimId);
    }
}
