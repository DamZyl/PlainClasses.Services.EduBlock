using System;
using System.Collections.Generic;
using System.Linq;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class PlatoonExistsInEduBlockRule : IBusinessRule
    {
        private readonly IEnumerable<PlatoonInEduBlock> _platoons;
        private readonly Guid _platoonId;

        public PlatoonExistsInEduBlockRule(IEnumerable<PlatoonInEduBlock> platoons, Guid platoonId)
        {
            _platoons = platoons;
            _platoonId = platoonId;
        } 
        
        public bool IsBroken() => _platoons.All(x => x.PlatoonId != _platoonId);

        public string Message => $"Platoon with id: {_platoonId} is not in edu block.";
    }
}