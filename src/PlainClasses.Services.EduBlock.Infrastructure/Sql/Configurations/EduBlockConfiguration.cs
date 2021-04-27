using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PlainClasses.Services.EduBlock.Infrastructure.Sql.Configurations
{
    public class EduBlockConfiguration : IEntityTypeConfiguration<Domain.Models.EduBlock>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.EduBlock> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.HasOne(x => x.EduBlockSubject)
                .WithMany(x => x.EduBlocks)
                .HasForeignKey(x => x.EduBlockSubjectId);
            
            builder.Property(x => x.Place)
                .HasConversion<string>();
        }
    }
}