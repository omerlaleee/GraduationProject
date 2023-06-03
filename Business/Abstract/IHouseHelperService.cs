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
    public interface IHouseHelperService
    {
        IResult Add(HouseHelper houseHelper);
        IResult Update(HouseHelper houseHelper);
        IResult Delete(HouseHelper houseHelper);
        IDataResult<List<HouseHelper>> GetAll();
        IDataResult<HouseHelper> GetById(int houseHelperId);
        IDataResult<List<HouseHelperDetailDto>> GetHouseHelperDetails();
        IDataResult<List<HouseHelperDetailDto>> GetHouseHelperDetailsByEmail(string email);
    }
}