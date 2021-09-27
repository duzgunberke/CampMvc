using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez !!! ");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Başlık Boş Geçilemez !!! ");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar açıklamasını boş geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(60).WithMessage("Lütfen en fazla 60 karakter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(60).WithMessage("Lütfen en fazla 60 karakter girişi yapın");
            RuleFor(x => x.WriterTitle).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapın");
            RuleFor(x => x.WriterAbout).MaximumLength(250).WithMessage("Lütfen en fazla 250 karakter girişi yapın");
        }
    }
}
