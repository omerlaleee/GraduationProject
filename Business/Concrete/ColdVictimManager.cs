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
    public class ColdVictimManager : IColdVictimService
    {
        public IResult Add(ColdVictim coldVictim)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ColdVictim coldVictim)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ColdVictim>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ColdVictim> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ColdVictim> GetById(int coldVictimId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ColdVictim coldVictim)
        {
            throw new NotImplementedException();
        }
    }
}