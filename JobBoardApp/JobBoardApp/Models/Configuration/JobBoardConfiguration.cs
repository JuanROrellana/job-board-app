using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardApp.Models.Configuration
{
    public class JobBoardConfiguration : IEntityTypeConfiguration<JobBoard>
    {
        public void Configure(EntityTypeBuilder<JobBoard> builder)
        {
            builder.HasData
            (
                new JobBoard
                {
                    Id = Guid.NewGuid(),
                    Job = "ASP Programmer",
                    JobTitle = "System Engineer",
                    Description = "Asp C# programming and JavaScript",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(7)
                },
                new JobBoard
                {
                    Id = Guid.NewGuid(),
                    Job = "PHP Programmer",
                    JobTitle = "System Engineer",
                    Description = "Laravel programming expert",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(7)
                },
                new JobBoard
                {
                    Id = Guid.NewGuid(),
                    Job = "Python Programmer",
                    JobTitle = "System Engineer",
                    Description = "Django Programming",
                    CreatedAt = DateTime.Now,
                    ExpiresAt = DateTime.Now.AddDays(7)
                }
            );
        }
    }
}