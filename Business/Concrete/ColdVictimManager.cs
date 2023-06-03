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
    public class ColdVictimManager : IColdVictimService
    {
        IColdVictimDal _coldVictimDal;
        IVictimService _victimService;

        public ColdVictimManager(IColdVictimDal coldVictimDal, IVictimService victimService)
        {
            _coldVictimDal = coldVictimDal;
            _victimService = victimService;
        }

        public IResult Add(ColdVictim coldVictim)
        {
            _coldVictimDal.Add(coldVictim);
            return new SuccessResult(Messages.ColdVictimAdded);
        }

        public IResult Delete(ColdVictim coldVictim)
        {
            _coldVictimDal.Delete(coldVictim);
            return new SuccessResult(Messages.ColdVictimDeleted);
        }

        public IDataResult<List<ColdVictim>> GetAll()
        {
            return new SuccessDataResult<List<ColdVictim>>(Messages.ColdVictimsListed, _coldVictimDal.GetAll());
        }

        public IDataResult<ColdVictim> GetById(int coldVictimId)
        {
            return new SuccessDataResult<ColdVictim>(Messages.TheColdVictimListed, _coldVictimDal.Get(c => c.Id == coldVictimId));
        }

        public IResult Update(ColdVictim coldVictim)
        {
            _coldVictimDal.Update(coldVictim);
            return new SuccessResult(Messages.ColdVictimUpdated);
        }
    }
}