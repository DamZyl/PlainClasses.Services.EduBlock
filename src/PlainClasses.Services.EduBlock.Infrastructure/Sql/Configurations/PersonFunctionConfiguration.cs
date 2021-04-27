﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlainClasses.Services.EduBlock.Domain.Models;

namespace PlainClasses.Services.EduBlock.Infrastructure.Sql.Configurations
{
    public class PersonFunctionConfiguration : IEntityTypeConfiguration<PersonFunction>
    {
        public void Configure(EntityTypeBuilder<PersonFunction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.HasOne(x => x.EduBlock)
                .WithMany(x => x.PersonFunctions)
                .HasForeignKey(x => x.EduBlockId);
            
            builder.Property(x => x.Function)
                .HasConversion<string>();
        }
    }
}