using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Events
{
    public class EduBlockDataUpdatedEvent : DomainEventBase
    {
        public Guid EduBlockId { get; private set; }

        public EduBlockDataUpdatedEvent(Guid eduBlockId)
        {
            EduBlockId = eduBlockId;
        }
    }
}