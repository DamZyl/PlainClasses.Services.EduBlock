using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteEduBlock
{
    public class DeleteEduBlockCommand : CommandBase
    {
        public Guid EduBlockId { get; set; }

        public DeleteEduBlockCommand(Guid eduBlockId)
        {
            EduBlockId = eduBlockId;
        }
    }
}