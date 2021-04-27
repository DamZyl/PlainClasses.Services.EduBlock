using MicroserviceLibrary.Domain.SharedKernels;
using PlainClasses.Services.EduBlock.Application.Queries.GetEduBlock;

namespace PlainClasses.Services.EduBlock.Application.Rules
{
    public class EduBlockExistRule : IBusinessRule
    {
        private readonly EduBlockDetailViewModel _eduBlock;

        public EduBlockExistRule(EduBlockDetailViewModel eduBlock)
        {
            _eduBlock = eduBlock;
        }

        public bool IsBroken() => _eduBlock == null;

        public string Message => $"Edu block with id: {_eduBlock.Id} does not exist.";
    }
}