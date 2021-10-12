using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Bu Alan boş geçilemez");
          
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Konu Boş Geçilemez !!! ");
          
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Yazar Adını boş geçemezsiniz");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.UserMail).MinimumLength(3).WithMessage("Lütfen en az 10 karakter girişi yapın");
            RuleFor(x => x.UserName).MaximumLength(60).WithMessage("Lütfen en fazla 50 karakter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(60).WithMessage("Lütfen en fazla 60 karakter girişi yapın");
          
        }
    }
}
