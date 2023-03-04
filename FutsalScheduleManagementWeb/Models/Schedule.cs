using System.ComponentModel.DataAnnotations;

namespace FutsalScheduleManagementWeb.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "Not Set";
    }
}
