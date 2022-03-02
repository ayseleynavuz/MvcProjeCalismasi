using EntityLayer.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını adını boş geçemezsiniz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazarın hakkımda kısmını boş geçemezsiniz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapınız.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen elli karakterden fazla değer girişi yapmayınız.");
        }
    }
}
