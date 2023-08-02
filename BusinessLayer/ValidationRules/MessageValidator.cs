using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            //RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            //RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girin.");
            //RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En fazla 50 karakter girin.");
        }
    }
}
