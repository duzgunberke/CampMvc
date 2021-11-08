using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Bu Alan boş geçilemez");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş Geçilemez !!! ");

            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.MessageContent).MinimumLength(30).WithMessage("Lütfen en az 30 karakter girişi yapın");
           
        }
    }
}
