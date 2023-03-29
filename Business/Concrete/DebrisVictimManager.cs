using Business.Abstract;
using Business.Cosntants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DebrisVictimManager : IDebrisVictimService
    {
        IDebrisVictimDal _debrisVictimDal;
        public DebrisVictimManager(IDebrisVictimDal debrisVictimDal)
        {
            _debrisVictimDal = debrisVictimDal;
        }

        public IResult Add(DebrisVictim debrisVictim)
        {
            _debrisVictimDal.Add(debrisVictim);
            return new SuccessResult(Messages.DebrisVictimAdded);
        }

        public IResult Delete(DebrisVictim debrisVictim)
        {
            _debrisVictimDal.Delete(debrisVictim);
            return new SuccessResult(Messages.DebrisVictimDeleted);
        }

        public IDataResult<List<DebrisVictim>> GetAll()
        {
            return new SuccessDataResult<List<DebrisVictim>>(Messages.DebrisVictimsListed, _debrisVictimDal.GetAll());
        }

        public IDataResult<DebrisVictim> GetById(int debrisVictimId)
        {
            return new SuccessDataResult<DebrisVictim>(Messages.TheDebrisVictimListed, _debrisVictimDal.Get(d => d.Id == debrisVictimId));
        }

        public IResult Update(DebrisVictim debrisVictim)
        {
            _debrisVictimDal.Update(debrisVictim);
            return new SuccessResult(Messages.DebrisVictimUpdated);
        }
    }
}
