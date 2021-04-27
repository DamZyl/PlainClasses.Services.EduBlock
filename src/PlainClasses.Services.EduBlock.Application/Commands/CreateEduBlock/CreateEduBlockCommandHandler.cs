using System.Threading;
using System.Threading.Tasks;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Domain.Repositories;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock
{
    public class CreateEduBlockCommandHandler : ICommandHandler<CreateEduBlockCommand, ReturnEduBlockViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGetEduBlockSubjectForId _getEduBlockSubjectForId;
        private readonly IGetPlatoonsForIds _getPlatoonsForIds;

        public CreateEduBlockCommandHandler(IUnitOfWork unitOfWork, IGetEduBlockSubjectForId getEduBlockSubjectForId, 
            IGetPlatoonsForIds getPlatoonsForIds)
        {
            _unitOfWork = unitOfWork;
            _getEduBlockSubjectForId = getEduBlockSubjectForId;
            _getPlatoonsForIds = getPlatoonsForIds;
        }
        
        public async Task<ReturnEduBlockViewModel> Handle(CreateEduBlockCommand request, CancellationToken cancellationToken)
        {
            var eduBlock = Domain.Models.EduBlock.CreateEduBlock(request.EduBlockSubjectId, request.StartEduBlock, request.EndEduBlock, 
                request.Remarks, request.Place, request.PlatoonIds, _getEduBlockSubjectForId, _getPlatoonsForIds);

            await _unitOfWork.Repository<Domain.Models.EduBlock>().AddAsync(eduBlock);
            await _unitOfWork.CommitAsync(cancellationToken);

            return new ReturnEduBlockViewModel { Id = eduBlock.Id };
        }
    }
}