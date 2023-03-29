using Business.Abstract;
using Business.Cosntants;
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
    public class VictimManager : IVictimService
    {
        IVictimDal _victimDal;
        public VictimManager(IVictimDal victimDal)
        {
            _victimDal = victimDal;
        }

        public IResult Add(Victim victim)
        {
            _victimDal.Add(victim);
            return new SuccessResult(Messages.VictimAdded);
        }

        public IResult Delete(Victim victim)
        {
            _victimDal.Delete(victim);
            return new SuccessResult(Messages.VictimDeleted);
        }

        public IDataResult<List<Victim>> GetAll()
        {
            return new SuccessDataResult<List<Victim>>(Messages.VictimsListed, _victimDal.GetAll());
        }

        public IDataResult<Victim> GetById(int victimId)
        {
            return new SuccessDataResult<Victim>(Messages.TheVictimListed, _victimDal.Get(v => v.Id == victimId));
        }

        public IResult Update(Victim victim)
        {
            _victimDal.Update(victim);
            return new SuccessResult(Messages.VictimUpdated);
        }
    }
}
