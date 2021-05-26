using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class Room
    {
        [Key]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ScheduleRoom> ScheduleRooms { get; set; }
    }
}