using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlainClasses.Services.EduBlock.Domain.Models;

namespace PlainClasses.Services.EduBlock.Infrastructure.Sql.Configurations
{
    public class PlatoonInEduBlockConfiguration : IEntityTypeConfiguration<PlatoonInEduBlock>
    {
        public void Configure(EntityTypeBuilder<PlatoonInEduBlock> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedNever();
            
            builder.HasOne(x => x.EduBlock)
                .WithMany(x => x.Platoons)
                .HasForeignKey(x => x.EduBlockId);
        }
    }
}