using FutsalScheduleManagementWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FutsalScheduleManagementWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }
        public DbSet<Schedule>Schedules { get; set; }
    }
}
