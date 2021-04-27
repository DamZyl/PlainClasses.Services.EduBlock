using MicroserviceLibrary.Application.Configurations.Options;
using MicroserviceLibrary.Infrastructure.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PlainClasses.Services.EduBlock.Domain.Models;

namespace PlainClasses.Services.EduBlock.Infrastructure.Sql
{
    public class EduBlockContext : AbstractApplicationDbContext
    {
        #region DbSets
        
        public DbSet<Domain.Models.EduBlock> EduBlocks { get; set; }
        public DbSet<EduBlockSubject> EduBlockSubjects { get; set; }
        public DbSet<PersonFunction> PersonFunctions { get; set; }
        public DbSet<PlatoonInEduBlock> PlatoonInEduBlocks { get; set; }

        #endregion
        
        public EduBlockContext(IOptions<SqlOption> options) : base(options, "PlainClasses.Services.EduBlock.Api") { }
    }
}