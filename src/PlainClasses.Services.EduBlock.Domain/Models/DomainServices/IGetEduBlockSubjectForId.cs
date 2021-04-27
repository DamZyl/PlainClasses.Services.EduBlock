using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.DomainServices
{
    public interface IGetEduBlockSubjectForId : IDomainService
    {
        EduBlockSubject Get(Guid eduBlockSubjectId);
    }
}