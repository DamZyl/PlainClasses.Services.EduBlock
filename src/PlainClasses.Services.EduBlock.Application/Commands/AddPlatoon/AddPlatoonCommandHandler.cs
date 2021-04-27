using System.Threading;
using System.Threading.Tasks;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using MicroserviceLibrary.Application.Utils;
using MicroserviceLibrary.Domain.Repositories;
using PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock;
using PlainClasses.Services.EduBlock.Application.Rules;

namespace PlainClasses.Services.EduBlock.Application.Commands.AddPlatoon
{
    public class AddPlatoonCommandHandler : ICommandHandler<AddPlatoonCommand, ReturnEduBlockViewModel>
    {
        // private readonly IUnitOfWork _unitOfWork;
        // private readonly IGetPlatoonForId _getPlatoonForId;
        //
        // public AddPlatoonCommandHandler(IUnitOfWork unitOfWork, IGetPlatoonForId getPlatoonForId)
        // {
        //     _unitOfWork = unitOfWork;
        //     _getPlatoonForId = getPlatoonForId;
        // }
        //
        // public async Task<ReturnEduBlockViewModel> Handle(AddPlatoonCommand request, CancellationToken cancellationToken)
        // {
        //     var eduBlock = await _unitOfWork.Repository<EduBlock>()
        //         .FindByWithIncludesAsync(x => x.Id == request.EduBlockId,
        //         includes: i => i.Include(x => x.Platoons));
        //     ExceptionHelper.CheckRule(new EduBlockDoesNotExistRule(eduBlock));
        //     
        //     eduBlock.AddPlatoonToEduBlock(request.PlatoonId, _getPlatoonForId);
        //
        //     await _unitOfWork.CommitAsync(cancellationToken);
        //
        //     return new ReturnEduBlockViewModel { Id = eduBlock.Id };
        // }
        public Task<ReturnEduBlockViewModel> Handle(AddPlatoonCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}