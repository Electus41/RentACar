using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ModelYearValidator : AbstractValidator<ModelYear>
    {
        public ModelYearValidator()
        {
            RuleFor(m => m.ModelYearId).NotEmpty();
            RuleFor(m => m.ModelYearName).NotEmpty();

        }
    }
}
