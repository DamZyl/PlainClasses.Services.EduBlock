using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using PlainClasses.Services.EduBlock.Application.Rules;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteEduBlock
{
    public class DeleteEduBlockCommandHandler : ICommandHandler<DeleteEduBlockCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGetEduBlockForId _getEduBlockForId;

        public DeleteEduBlockCommandHandler(IUnitOfWork unitOfWork, IGetEduBlockForId getEduBlockForId)
        {
            _unitOfWork = unitOfWork;
            _getEduBlockForId = getEduBlockForId;
        }
        
        public async Task<Unit> Handle(DeleteEduBlockCommand request, CancellationToken cancellationToken)
        {
            var eduBlock = await _getEduBlockForId.GetAsync(request.EduBlockId);
            ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));
            
            await _unitOfWork.Repository<Domain.Models.EduBlock>().DeleteAsync(eduBlock);
            await _unitOfWork.CommitAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}