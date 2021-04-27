using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;
using PlainClasses.Services.EduBlock.Application.Commands.CreateEduBlock;

namespace PlainClasses.Services.EduBlock.Application.Commands.AddFunction
{
    public class AddFunctionCommand : CommandBase<ReturnEduBlockViewModel>
    {
        public Guid EduBlockId { get; }
        public Guid PersonId { get; }
        public string Function { get; }

        public AddFunctionCommand(Guid eduBlockId, Guid personId, string function)
        {
            EduBlockId = eduBlockId;
            PersonId = personId;
            Function = function;
        }
    }
}