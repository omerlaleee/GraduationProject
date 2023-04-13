using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BuildReporter : IEntity
    {
        // public string Photo { get; set; } !!!!!!!!!!!!!!!!!!!!!!
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DetailedAddress { get; set; }
        public string Urgency { get; set; }
        public string MapsAddress { get; set; }
    }
}
