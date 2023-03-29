using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDebrisVictimService
    {
        IResult Add(DebrisVictim debrisVictim);
        IResult Update(DebrisVictim debrisVictim);
        IResult Delete(DebrisVictim debrisVictim);
        IDataResult<List<DebrisVictim>> GetAll();
        IDataResult<DebrisVictim> GetById(int debrisVictimId);
    }
}
