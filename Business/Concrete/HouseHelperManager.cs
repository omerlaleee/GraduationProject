using Business.Abstract;
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
    public class HouseHelperManager : IHouseHelperService
    {
        IHouseHelperDal _houseHelperDal;

        public HouseHelperManager(IHouseHelperDal houseHelperDal)
        {
            _houseHelperDal = houseHelperDal;
        }

        public IResult Add(HouseHelper houseHelper)
        {
            _houseHelperDal.Add(houseHelper);
            return new SuccessResult();
        }

        public IResult Delete(HouseHelper houseHelper)
        {
            _houseHelperDal.Delete(houseHelper);
            return new SuccessResult();
        }

        public IDataResult<List<HouseHelper>> GetAll()
        {
            return new SuccessDataResult<List<HouseHelper>>(_houseHelperDal.GetAll());
        }

        public IDataResult<HouseHelper> GetById(int houseHelperId)
        {
            return new SuccessDataResult<HouseHelper>(_houseHelperDal.Get(h => h.Id == houseHelperId));
        }

        public IResult Update(HouseHelper houseHelper)
        {
            _houseHelperDal.Update(houseHelper);
            return new SuccessResult();
        }
    }
}
