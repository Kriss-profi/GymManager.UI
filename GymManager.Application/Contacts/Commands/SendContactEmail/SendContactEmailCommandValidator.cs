using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Application.Contacts.Commands.SendContactEmail
{
    public class SendContactEmailCommandValidator : AbstractValidator<SendContactEmailCommand>
    {
        //public SendContactEmailCommandValidator()
        //{
        //    RuleFor(x => x.Name)
        //        .NotEmpty().WithMessage("Pole 'Imię i Nazwisko' jest wymagane");
        //    RuleFor(x => x.Email)
        //        .NotEmpty().WithMessage("Pole E-Mail jest wymagane");

        //    RuleFor(x => x.Title)
        //        .NotEmpty().WithMessage("Wypadało by podać jakiś temat");

        //    RuleFor(x => x.Message)
        //        .MinimumLength(20).WithMessage("Wiadomość powinna zawierać conajmniej 20 znaków.");
        //}
    }
}