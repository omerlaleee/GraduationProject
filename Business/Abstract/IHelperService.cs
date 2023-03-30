using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHelperService
    {
        IResult Add(Helper Helper);
        IResult Update(Helper Helper);
        IResult Delete(Helper Helper);
        IDataResult<List<Helper>> GetAll();
        IDataResult<Helper> GetById(int HelperId);
    }
}
