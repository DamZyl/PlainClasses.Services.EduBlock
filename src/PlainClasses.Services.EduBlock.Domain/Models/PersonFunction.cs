using System;
using MicroserviceLibrary.Domain.SharedKernels;
using PlainClasses.Services.EduBlock.Domain.Models.Enums;
using PlainClasses.Services.EduBlock.Domain.Models.Rules;
using PlainClasses.Services.EduBlock.Domain.Utils.Extensions;

namespace PlainClasses.Services.EduBlock.Domain.Models
{
    public class PersonFunction : Entity
    {
        public Guid Id { get; private set; }
        public Guid PersonId { get; private set; }
        public Guid EduBlockId { get; private set; }
        public Function Function { get; private set; }

        #region Ef_Config
        
        public EduBlock EduBlock { get; set; }
        
        #endregion

        private PersonFunction() { }
        
        private PersonFunction(Guid personId, Guid eduBlockId, string function)
        {
            Id = Guid.NewGuid();
            PersonId = personId;
            EduBlockId = eduBlockId;
            Function = Enum.Parse<Function>(function.ToUppercaseFirstInvariant());
        }

        public static PersonFunction CreateFunctionForPersonInEduBlock(Guid personId, Guid eduBlockId, string function)
        {
            CheckRule(new FunctionInEduBlockRule(function));

            return new PersonFunction(personId, eduBlockId, function);
        }
    }
}