using System.ComponentModel.DataAnnotations;

namespace FutsalScheduleManagementWeb.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; } 
        public DateTime StartTime{ get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);
    }
}
