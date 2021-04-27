using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.DomainServices
{
    public interface IGetPlatoonInEduBlockForId : IDomainService
    {
        PlatoonInEduBlock Get(Guid platoonId, Guid eduBlockId);
    }
}