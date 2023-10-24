using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bTracker.Data;
using System;
using System.Linq;
using bTracker.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new bTrackerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<bTrackerContext>>()))
        {
            // Look for any movies.
            if (context.Issue.Any())
            {
                return;   // DB has been seeded
            }
            context.Issue.AddRange(
                new Issue
                {
                    Title = "Lack of comments",
                    Date = DateTime.Parse("2023-2-12"),
                    Category = "Documentation",
                    Severity = 7

                },
                new Issue
                {
                    Title = "No css",
                    Date = DateTime.Parse("2023-3-13"),
                    Category = "UX",
                    Severity = 5
                },
                new Issue
                {
                    Title = "write notes for setup",
                    Date = DateTime.Parse("2023-2-23"),
                    Category = "Documentation",
                    Severity = 3
                },
                new Issue
                {
                    Title = "Link doesn't work",
                    Date = DateTime.Parse("2023-4-15"),
                    Category = "bug",
                    Severity = 5
                }
            );
            context.SaveChanges();
        }
    }
}