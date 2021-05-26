using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class Classroom
    {
        [Key]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ScheduleClassroom> TimeTableClassrooms { get; set; }
        public Faculty Faculty { get; set; }
    }
}