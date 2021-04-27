using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Commands.DeleteFunction
{
    public class DeleteFunctionCommand : CommandBase
    {
        public Guid EduBlockId { get; }
        public Guid FunctionId { get; }

        public DeleteFunctionCommand(Guid eduBlockId, Guid functionId)
        {
            EduBlockId = eduBlockId;
            FunctionId = functionId;
        }
    }
}