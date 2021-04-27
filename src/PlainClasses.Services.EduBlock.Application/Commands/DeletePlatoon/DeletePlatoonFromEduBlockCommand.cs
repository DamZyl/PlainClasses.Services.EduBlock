using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeletePlatoon
{
    public class DeletePlatoonFromEduBlockCommand : CommandBase
    {
        public Guid EduBlockId { get; }
        public Guid PlatoonId { get; }

        public DeletePlatoonFromEduBlockCommand(Guid eduBlockId, Guid platoonId)
        {
            EduBlockId = eduBlockId;
            PlatoonId = platoonId;
        }
    }
}