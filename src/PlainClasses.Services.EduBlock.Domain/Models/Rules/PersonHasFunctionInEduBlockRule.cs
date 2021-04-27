using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class PersonHasFunctionInEduBlockRule : IBusinessRule
    {
        // private readonly IEnumerable<PersonFunction> _personFunctions;
        // private readonly Person _person;
        //
        // public PersonHasFunctionInEduBlockRule(IEnumerable<PersonFunction> personFunctions, Person person)
        // {
        //     _personFunctions = personFunctions;
        //     _person = person;
        // } 

        public bool IsBroken() => true; // => _personFunctions.Any(x => x.PersonId == _person.Id);

        public string Message => ""; // => $"Person with id: {_person.Id} already has function in edu block.";
    }
}