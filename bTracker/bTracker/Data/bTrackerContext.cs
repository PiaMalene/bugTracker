using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bTracker.Models;

//handles the task of connecting to the database and mapping issues objects to database records. 
//databased used: LocalDB (lightweight version of the SQL Server Express Database Engine, installed by default with Visual Studio)

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
