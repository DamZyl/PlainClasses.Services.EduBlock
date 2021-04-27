using FluentValidation;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteFunction
{
    public class DeleteFunctionCommandValidator : AbstractValidator<DeleteFunctionCommand>
    {
        public DeleteFunctionCommandValidator()
        {
            RuleFor(x => x.EduBlockId)
                .NotEmpty()
                .WithMessage("EduBlockId is empty.");
            
            RuleFor(x => x.FunctionId)
                .NotEmpty()
                .WithMessage("FunctionId is empty.");
        }
    }
}