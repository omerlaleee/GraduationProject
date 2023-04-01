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
    public class HelperManager : IHelperService
    {
        IHelperDal _helperDal;

        public HelperManager(IHelperDal helperDal)
        {
            _helperDal = helperDal;
        }

        public IResult Add(Helper helper)
        {
            _helperDal.Add(helper);
            return new SuccessResult();
        }

        public IResult Delete(Helper helper)
        {
            _helperDal.Delete(helper);
            return new SuccessResult();
        }

        public IDataResult<List<Helper>> GetAll()
        {
            return new SuccessDataResult<List<Helper>>(_helperDal.GetAll());
        }

        public IDataResult<Helper> GetById(int helperId)
        {
            return new SuccessDataResult<Helper>(_helperDal.Get(h => h.Id == helperId));
        }

        public IResult Update(Helper helper)
        {
            _helperDal.Update(helper);
            return new SuccessResult();
        }
    }
}
