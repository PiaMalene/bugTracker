using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bTracker.Models;

namespace bTracker.Data
{
    public class bTrackerContext : DbContext
    {
        public bTrackerContext (DbContextOptions<bTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<bTracker.Models.Issue> Issue { get; set; } = default!;
    }
}
