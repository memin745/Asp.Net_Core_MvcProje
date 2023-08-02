using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girin.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En fazla 50 karakter girin.");
        }

    }
}
