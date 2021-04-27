using FluentValidation;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteEduBlock
{
    public class DeleteEduBlockCommandValidator : AbstractValidator<DeleteEduBlockCommand>
    {
        public DeleteEduBlockCommandValidator()
        {
            RuleFor(x => x.EduBlockId)
                .NotEmpty()
                .WithMessage("Id is empty.");
        }
    }
}