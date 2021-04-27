using FluentValidation;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeletePlatoon
{
    public class DeletePlatoonFromEduBlockCommandValidator : AbstractValidator<DeletePlatoonFromEduBlockCommand>
    {
        public DeletePlatoonFromEduBlockCommandValidator()
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