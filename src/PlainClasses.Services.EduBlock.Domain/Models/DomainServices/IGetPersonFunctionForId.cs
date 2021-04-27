using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.DomainServices
{
    public interface IGetPersonFunctionForId : IDomainService
    {
        PersonFunction Get(Guid functionId);
    }
}