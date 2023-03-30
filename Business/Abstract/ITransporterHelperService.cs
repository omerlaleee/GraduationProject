using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransporterHelperService
    {
        IResult Add(TransporterHelper transporterHelper);
        IResult Update(TransporterHelper transporterHelper);
        IResult Delete(TransporterHelper transporterHelper);
        IDataResult<List<TransporterHelper>> GetAll();
        IDataResult<TransporterHelper> GetById(int transporterHelperId);
    }
}
