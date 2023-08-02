using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmı boş bırakılmaz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmı boş bırakılmaz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En az 2 karakter girin.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En fazla 50 karakter girin.");
        }

    }
}
