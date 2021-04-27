using System;

namespace PlainClasses.Services.EduBlock.Application.Queries.GetEduBlocks
{
    public class EduBlockViewModel
    {
        public Guid Id { get; set; }
        public string EduBlockSubjectName { get; set; }
        public DateTime StartEduBlock { get; set; }
        public DateTime EndEduBlock { get; set; }
        public string Place { get; set; }
    }
}