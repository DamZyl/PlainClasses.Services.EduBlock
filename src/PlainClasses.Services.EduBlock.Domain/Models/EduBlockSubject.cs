using System;
using System.Collections.Generic;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models
{
    public class EduBlockSubject : Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        private ISet<EduBlock> _eduBlocks = new HashSet<EduBlock>();
        public IEnumerable<EduBlock> EduBlocks => _eduBlocks;
    }
}