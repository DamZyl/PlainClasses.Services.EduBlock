using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Application.Rules
{
    public class EduBlockDoesNotExistRule : IBusinessRule
    {
        private readonly Domain.Models.EduBlock _eduBlock;

        public EduBlockDoesNotExistRule(Domain.Models.EduBlock eduBlock)
        {
            _eduBlock = eduBlock;
        }

        public bool IsBroken() => _eduBlock == null;

        public string Message => $"Edu block with id: {_eduBlock.Id} does not exist.";
    }
}