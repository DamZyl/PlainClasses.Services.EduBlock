using System;
using System.Threading.Tasks;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.DomainServices
{
    public interface IGetEduBlockForId : IDomainService
    {
        EduBlock Get(Guid eduBlockId);
        Task<EduBlock> GetAsync(Guid eduBlockId);
        Task<EduBlock> GetDetailAsync(Guid eduBlockId);
    }
}