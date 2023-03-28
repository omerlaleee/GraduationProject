using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OperatorHelper : User
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string InfoAboutHelp { get; set; }
    }
}