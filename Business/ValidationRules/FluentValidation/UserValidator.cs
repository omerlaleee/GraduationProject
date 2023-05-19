using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            //public string FirstName { get; set; }
            //public string LastName { get; set; }
            //public string Email { get; set; }
            //public string PhoneNumber { get; set; }
            //public string Password { get; set; }

            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).MinimumLength(1).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}