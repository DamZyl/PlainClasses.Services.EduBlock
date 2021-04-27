using FluentValidation;

namespace PlainClasses.Services.EduBlock.Application.Commands.AddPlatoon
{
    public class AddPlatoonCommandValidator : AbstractValidator<AddPlatoonCommand>
    {
        public AddPlatoonCommandValidator()
        {
            RuleFor(x => x.EduBlockId)
                .NotEmpty()
                .WithMessage("EduBlockId is empty.");
           
            RuleFor(x => x.PlatoonId)
                .NotEmpty()
                .WithMessage("PlatoonId is empty.");
        }
    }
}