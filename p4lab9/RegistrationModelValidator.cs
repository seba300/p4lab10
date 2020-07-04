using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace p4lab9
{
    class RegistrationModelValidator:AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinLength(6);

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinLength(6)
                .Must(x => x != x.ToUpper())
                .WithMessage("Name must contain lowercase letters")
                .Must(x => x != x.ToLower())
                .WithMessage("Name must contain upper letters")
                .Matches(@".*[(\d!@#$%^&*().,/+=.*)+]");

            RuleFor(x=>x.Accept)
                .
        }
    }
}
