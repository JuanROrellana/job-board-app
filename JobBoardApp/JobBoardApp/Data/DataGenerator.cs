using System;
using JobBoardApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;


namespace JobBoardApp.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.BoardGames.Any())
                    return;
                context.AddRange(
                    new JobBoard
                    {
                        Job = "ASP Programmer",
                        JobTitle = "System Engineer",
                        CreatedAt = DateTime.Now
                    },
                    new JobBoard
                    {
                        Job = "PHP Programmer",
                        JobTitle = "System Engineer",
                        CreatedAt = DateTime.Now
                    },
                    new JobBoard
                    {
                        Job = "Python Programmer",
                        JobTitle = "System Engineer",
                        CreatedAt = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}