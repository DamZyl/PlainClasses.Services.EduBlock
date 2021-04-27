using System;

namespace PlainClasses.Services.EduBlock.Api.Controllers.Requests
{
    public class AddFunctionRequest
    {
        public Guid PersonId { get; set; }
        public string Function { get; set; }
    }
}