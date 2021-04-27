using System;
using System.Collections.Generic;

namespace PlainClasses.Services.EduBlock.Api.Controllers.Requests
{
    public class CreateEduBlockRequest
    {
        public Guid EduBlockSubjectId { get; set; }
        public DateTime StartEduBlock { get; set; }
        public DateTime EndEduBlock { get; set; }
        public string Remarks { get; set; }
        public string Place { get; set; }
        public IEnumerable<Guid> PlatoonIds { get; set; }
    }
}