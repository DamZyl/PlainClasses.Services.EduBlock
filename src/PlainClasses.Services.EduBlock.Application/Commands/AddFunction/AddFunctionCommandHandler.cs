using System.Threading;
using System.Threading.Tasks;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock;
using PlainClasses.Services.EduBlock.Application.Rules;

namespace PlainClasses.Services.EduBlock.Application.Commands.AddFunction
{
    public class AddFunctionCommandHandler : ICommandHandler<AddFunctionCommand, ReturnEduBlockViewModel>
    {
        // private readonly IUnitOfWork _unitOfWork;
        // private readonly IGetPersonForId _getPersonForId;
        //
        // public AddFunctionCommandHandler(IUnitOfWork unitOfWork, IGetPersonForId getPersonForId)
        // {
        //     _unitOfWork = unitOfWork;
        //     _getPersonForId = getPersonForId;
        // }
        //
        // public async Task<ReturnEduBlockViewModel> Handle(AddFunctionCommand request, CancellationToken cancellationToken)
        // {
        //     var eduBlock = await _unitOfWork.Repository<EduBlock>()
        //         .FindByWithIncludesAsync(x => x.Id == request.EduBlockId,
        //             includes: i => i.Include(x => x.PersonFunctions));
        //     ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));
        //     
        //     eduBlock.AddFunctionForPerson(request.PersonId, request.Function, _getPersonForId);
        //
        //     await _unitOfWork.CommitAsync(cancellationToken);
        //
        //     return new ReturnEduBlockViewModel { Id = eduBlock.Id };
        // }
        public Task<ReturnEduBlockViewModel> Handle(AddFunctionCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}