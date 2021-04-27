using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using PlainClasses.Services.EduBlock.Application.Rules;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteFunction
{
    public class DeleteFunctionCommandHandler : ICommandHandler<DeleteFunctionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGetPersonFunctionForId _getPersonFunctionForId;

        public DeleteFunctionCommandHandler(IUnitOfWork unitOfWork, IGetPersonFunctionForId getPersonFunctionForId)
        {
            _unitOfWork = unitOfWork;
            _getPersonFunctionForId = getPersonFunctionForId;
        }
        
        public async Task<Unit> Handle(DeleteFunctionCommand request, CancellationToken cancellationToken)
        {
            var eduBlock = await _unitOfWork.Repository<Domain.Models.EduBlock>()
                .FindByWithIncludesAsync(x => x.Id == request.EduBlockId,
                    includes: i => i.Include(x => x.PersonFunctions));
            ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));
            
            eduBlock.DeleteFunctionPerson(request.FunctionId, _getPersonFunctionForId);

            await _unitOfWork.CommitAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}