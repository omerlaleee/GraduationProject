using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        
    }
}