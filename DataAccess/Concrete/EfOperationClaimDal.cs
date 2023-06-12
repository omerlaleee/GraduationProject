﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, EarthquakeContext>, IOperationClaimDal
    {
    }
}
