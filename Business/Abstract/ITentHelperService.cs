using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITentHelperService
    {
        IResult Add(TentHelper tentHelper);
        IResult Update(TentHelper tentHelper);
        IResult Delete(TentHelper tentHelper);
        IDataResult<List<TentHelper>> GetAll();
        IDataResult<TentHelper> GetById(int tentHelperId);
        IDataResult<List<TentHelperDetailDto>> GetTentHelperDetails();
        IDataResult<List<TentHelperDetailDto>> GetTentHelperDetailsByEmail(string email);
    }
}