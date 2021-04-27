using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock;

namespace PlainClasses.Services.EduBlock.Application.Commands.AddPlatoon
{
    public class AddPlatoonCommand : CommandBase<ReturnEduBlockViewModel>
    {
        public Guid EduBlockId { get; }
        public Guid PlatoonId { get; }

        public AddPlatoonCommand(Guid eduBlockId, Guid platoonId)
        {
            EduBlockId = eduBlockId;
            PlatoonId = platoonId;
        }
    }
}