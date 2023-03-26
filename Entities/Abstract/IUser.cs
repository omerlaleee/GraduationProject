using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IUser : IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}