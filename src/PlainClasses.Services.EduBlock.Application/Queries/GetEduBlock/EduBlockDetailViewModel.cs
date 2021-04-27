using System.Collections.Generic;
using PlainClasses.Services.EduBlock.Application.Queries.GetEduBlocks;

namespace PlainClasses.Services.EduBlock.Application.Queries.GetEduBlock
{
    public class EduBlockDetailViewModel : EduBlockViewModel
    {
        public string Remarks { get; set; }
        public List<PersonFunctionViewModel> PersonFunctions { get; set; }
        public List<PlatoonInEduBlockViewModel> PlatoonsInEduBlock { get; set; }
    }
}