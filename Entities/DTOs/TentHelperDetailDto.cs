using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TentHelperDetailDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string InfoAboutHelp { get; set; }
        public int NumberOfPeople { get; set; }
        public string MapsAddress { get; set; }
    }
}