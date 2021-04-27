using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlainClasses.Services.EduBlock.Domain.Models;

namespace PlainClasses.Services.EduBlock.Infrastructure.Sql.Configurations
{
    public class EduBlockSubjectConfiguration : IEntityTypeConfiguration<EduBlockSubject>
    {
        public void Configure(EntityTypeBuilder<EduBlockSubject> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}