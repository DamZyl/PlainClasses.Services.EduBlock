using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using PlainClasses.Services.EduBlock.Application.Rules;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.Commands.UpdateEduBlock
{
    public class UpdateEduBlockCommandHandler : ICommandHandler<UpdateEduBlockCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGetEduBlockForId _getEduBlockForId;

        public UpdateEduBlockCommandHandler(IUnitOfWork unitOfWork, IGetEduBlockForId getEduBlockForId)
        {
            _unitOfWork = unitOfWork;
            _getEduBlockForId = getEduBlockForId;
        }
        
        public async Task<Unit> Handle(UpdateEduBlockCommand request, CancellationToken cancellationToken)
        {
            var eduBlock = await _getEduBlockForId.GetDetailAsync(request.EduBlockId);
            ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));

            eduBlock.UpdateEduBlockData(request.Remarks, request.Place, request.StartEduBlock, request.EndEduBlock);

            await _unitOfWork.Repository<Domain.Models.EduBlock>().EditAsync(eduBlock);
            await _unitOfWork.CommitAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}