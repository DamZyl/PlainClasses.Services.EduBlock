using System;
using System.Collections.Generic;
using System.Linq;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class FunctionPersonExistsInEduBlockRule : IBusinessRule
    {
        private readonly IEnumerable<PersonFunction> _functionPersons;
        private readonly Guid _functionId;

        public FunctionPersonExistsInEduBlockRule(IEnumerable<PersonFunction> functionPersons, Guid functionId)
        {
            _functionPersons = functionPersons;
            _functionId = functionId;
        } 
        
        public bool IsBroken() => _functionPersons.All(x => x.Id != _functionId);

        public string Message => $"Function person with id: {_functionId} is not in edu block.";
    }
}