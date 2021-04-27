using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Commands.UpdateEduBlock
{
    public class UpdateEduBlockCommand : CommandBase
    {
        public Guid EduBlockId { get; }
        public string Remarks { get; }
        public string Place { get; }
        public DateTime StartEduBlock { get; }
        public DateTime EndEduBlock { get; }

        public UpdateEduBlockCommand(Guid eduBlockId, string remarks, string place, DateTime startEduBlock, DateTime endEduBlock)
        {
            EduBlockId = eduBlockId;
            Remarks = remarks;
            Place = place;
            StartEduBlock = startEduBlock;
            EndEduBlock = endEduBlock;
        }
    }
}