using FutsalScheduleManagementWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FutsalScheduleManagementWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
