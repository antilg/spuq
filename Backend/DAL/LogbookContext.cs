
using EinzelaufageB.Model;
using Microsoft.EntityFrameworkCore;

namespace EinzelaufageB.DAL
// data Access Layer 
{
    public class LogbookContext : DbContext
    {
        public virtual DbSet<Logbook> Journeys { get; set; } = null!;

        public LogbookContext(DbContextOptions<LogbookContext> options) : base(options)
        {

        }
    }
}