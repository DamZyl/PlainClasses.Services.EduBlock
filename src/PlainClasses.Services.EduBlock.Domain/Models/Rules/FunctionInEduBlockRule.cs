using System;
using MicroserviceLibrary.Domain.SharedKernels;
using PlainClasses.Services.EduBlock.Domain.Models.Enums;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class FunctionInEduBlockRule : IBusinessRule
    {
        private readonly string _function;

        public FunctionInEduBlockRule(string function)
        {
            _function = function;
        }

        public bool IsBroken() => !Enum.IsDefined(typeof(Function), _function);

        public string Message => $"Function: {_function} doesn't exist.";
    }
}