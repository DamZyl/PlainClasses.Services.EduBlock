using MicroserviceLibrary.Domain.SharedKernels;

namespace PlainClasses.Services.EduBlock.Domain.Models.Rules
{
    public class EduBlockSubjectExistRule : IBusinessRule
    {
        private readonly EduBlockSubject _eduBlockSubject;

        public EduBlockSubjectExistRule(EduBlockSubject eduBlockSubject)
        {
            _eduBlockSubject = eduBlockSubject;
        }

        public bool IsBroken() => _eduBlockSubject == null;

        public string Message => $"Edu block subject with id: {_eduBlockSubject.Id} does not exist.";
    }
}