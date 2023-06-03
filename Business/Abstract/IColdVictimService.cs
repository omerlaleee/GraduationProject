using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColdVictimService
    {
        IResult Add(ColdVictim coldVictim);
        IResult Update(ColdVictim coldVictim);
        IResult Delete(ColdVictim coldVictim);
        IDataResult<List<ColdVictim>> GetAll();
        IDataResult<ColdVictim> GetById(int coldVictimId);
    }
}