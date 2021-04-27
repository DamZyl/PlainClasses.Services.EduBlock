using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Events
{
    public class PlatoonToEduBlockAddedEvent : DomainEventBase
    {
        public Guid EduBlockId { get; private set; }
        public Guid PlatoonId { get; private set; }

        public PlatoonToEduBlockAddedEvent(Guid eduBlockId, Guid platoonId)
        {
            EduBlockId = eduBlockId;
            PlatoonId = platoonId;
        }
    }
}