using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVictimService
    {
        IResult Add(Victim victim);
        IResult Update(Victim victim);
        IResult Delete(Victim victim);
        IDataResult<List<Victim>> GetAll();
        IDataResult<Victim> GetById(int victimId);
        IDataResult<Victim> GetByEmail(string email);
    }
}
