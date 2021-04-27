using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Events
{
    public class EduBlockCreatedEvent : DomainEventBase
    {
        public Guid EduBlockId { get; private set; }

        public EduBlockCreatedEvent(Guid eduBlockId)
        {
            EduBlockId = eduBlockId;
        }
    }
}