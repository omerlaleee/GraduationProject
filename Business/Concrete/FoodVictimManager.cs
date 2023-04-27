using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FoodVictimManager : IFoodVictimService
    {
        IFoodVictimDal _foodVictimDal;

        public FoodVictimManager(IFoodVictimDal foodVictimDal)
        {
            _foodVictimDal = foodVictimDal;
        }

        public IResult Add(FoodVictim foodVictim)
        {
            _foodVictimDal.Add(foodVictim);
            return new SuccessResult();
        }

        public IResult Delete(FoodVictim foodVictim)
        {
            _foodVictimDal.Delete(foodVictim);
            return new SuccessResult();
        }

        public IDataResult<List<FoodVictim>> GetAll()
        {
            return new SuccessDataResult<List<FoodVictim>>(_foodVictimDal.GetAll());
        }

        public IDataResult<FoodVictim> GetById(int foodVictimId)
        {
            return new SuccessDataResult<FoodVictim>(_foodVictimDal.Get(f => f.Id == foodVictimId));
        }

        public IResult Update(FoodVictim foodVictim)
        {
            _foodVictimDal.Update(foodVictim);
            return new SuccessResult();
        }
    }
}
