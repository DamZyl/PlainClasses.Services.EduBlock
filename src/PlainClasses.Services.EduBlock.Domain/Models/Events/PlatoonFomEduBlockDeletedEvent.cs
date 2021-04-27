using System;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Events
{
    public class PlatoonFomEduBlockDeletedEvent : DomainEventBase
    {
        public Guid EduBlockId { get; private set; }
        public Guid PlatoonId { get; private set; }

        public PlatoonFomEduBlockDeletedEvent(Guid eduBlockId, Guid platoonId)
        {
            EduBlockId = eduBlockId;
            PlatoonId = platoonId;
        }
    }
}