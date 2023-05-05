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
    public class BuildReporterValidator : AbstractValidator<BuildReporter>
    {
        public BuildReporterValidator()
        {
            //public int Id { get; set; }
            //public int UserId { get; set; }
            //public string Address { get; set; }
            //public string DetailedAddress { get; set; }
            //public string Urgency { get; set; }
            //public string MapsAddress { get; set; }

            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Address).MinimumLength(3).NotEmpty();
            RuleFor(x => x.DetailedAddress).NotEmpty();
            RuleFor(x => x.Urgency).NotEmpty();
            RuleFor(x => x.MapsAddress).NotEmpty();
        }
    }
}
