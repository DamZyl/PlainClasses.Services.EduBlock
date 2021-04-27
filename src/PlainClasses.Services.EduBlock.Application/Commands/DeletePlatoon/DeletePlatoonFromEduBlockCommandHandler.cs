using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using PlainClasses.Services.EduBlock.Application.Rules;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeletePlatoon
{
    public class DeletePlatoonFromEduBlockCommandHandler : ICommandHandler<DeletePlatoonFromEduBlockCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGetPlatoonInEduBlockForId _getPlatoonInEduBlockForId;

        public DeletePlatoonFromEduBlockCommandHandler(IUnitOfWork unitOfWork, IGetPlatoonInEduBlockForId getPlatoonInEduBlockForId)
        {
            _unitOfWork = unitOfWork;
            _getPlatoonInEduBlockForId = getPlatoonInEduBlockForId;
        }
        
        public async Task<Unit> Handle(DeletePlatoonFromEduBlockCommand request, CancellationToken cancellationToken)
        {
            var eduBlock = await _unitOfWork.Repository<Domain.Models.EduBlock>()
                .FindByWithIncludesAsync(x => x.Id == request.EduBlockId,
                    includes: i => i.Include(x => x.Platoons));
            ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));
            
            eduBlock.DeletePlatoonFromEduBlock(request.PlatoonId, _getPlatoonInEduBlockForId);

            await _unitOfWork.CommitAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}