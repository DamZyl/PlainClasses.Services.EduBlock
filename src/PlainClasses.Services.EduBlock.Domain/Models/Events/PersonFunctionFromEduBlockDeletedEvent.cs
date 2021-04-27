using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Events
{
    public class PersonFunctionFromEduBlockDeletedEvent : DomainEventBase
    {
        public Guid EduBlockId { get; private set; }
        public Guid FunctionId { get; private set; }

        public PersonFunctionFromEduBlockDeletedEvent(Guid eduBlockId, Guid functionId)
        {
            EduBlockId = eduBlockId;
            FunctionId = functionId;
        }
    }
}