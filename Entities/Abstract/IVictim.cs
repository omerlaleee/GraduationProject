using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IVictim : IUser
    {
        int NumberOfPeople { get; set; }
        string Address { get; set; }
        string DetailedAddress { get; set; }
        string Urgency { get; set; }
        string StatusInformation { get; set; }
        string MapsAddress { get; set; }
    }
}
