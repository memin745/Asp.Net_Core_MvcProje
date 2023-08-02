﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Bu alan boş bırakılmaz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girin.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girin.");
        }
    }
}
