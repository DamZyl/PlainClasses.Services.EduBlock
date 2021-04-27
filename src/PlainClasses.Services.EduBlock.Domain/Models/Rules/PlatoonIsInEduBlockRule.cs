using System.Collections.Generic;
using System.Linq;
using MicroserviceLibrary.Domain.SharedKernels;
using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class PlatoonIsInEduBlockRule : IBusinessRule
    {
        // private readonly IEnumerable<PlatoonInEduBlock> _platoons;
        // private readonly Platoon _platoon;
        //
        // public PlatoonIsInEduBlockRule(IEnumerable<PlatoonInEduBlock> platoons, Platoon platoon)
        // {
        //     _platoons = platoons;
        //     _platoon = platoon;
        // } 

        public bool IsBroken() => true; // => _platoons.Any(x => x.PlatoonId == _platoon.Id);

        public string Message => ""; // => $"Platoon with id: {_platoon.Id} already is in edu block.";
    }
}