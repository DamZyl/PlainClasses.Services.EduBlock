using System;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Queries.GetEduBlock
{
    public class GetEduBlockQuery : IQuery<EduBlockDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}