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
    public class TransporterHelperManager : ITransporterHelperService
    {
        public IResult Add(TransporterHelper transporterHelper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TransporterHelper transporterHelper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TransporterHelper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<TransporterHelper> GetById(int transporterHelperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TransporterHelper transporterHelper)
        {
            throw new NotImplementedException();
        }
    }
}
