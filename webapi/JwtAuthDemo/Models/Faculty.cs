using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class Faculty
    {
        [Key]
        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Classroom> Classrooms { get; set; }
    }
}