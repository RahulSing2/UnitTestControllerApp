using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestControllerApp.Models;
using UnitTestControllerApp.Api;
using Microsoft.EntityFrameworkCore;
using UnitTestControllerApp;
namespace UnitTestControllerApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<BrainstormSession> BrainstormSessions { get; set; }
    }
}
