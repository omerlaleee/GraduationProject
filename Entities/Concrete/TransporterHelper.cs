using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TransporterHelper : User
    {
        public int Id { get; set; }
        public string InfoAboutHelp { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
    }
}