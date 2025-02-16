﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductReview.Domain;

namespace ProductReview.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
new Make
{
    Id = 1,
    Name = "BMW",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new Make
{
    Id = 2,
    Name = "Toyata",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);
        }
    }
}
