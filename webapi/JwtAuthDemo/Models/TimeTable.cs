using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class TimeTable
    {
        [Key]
        
        public int Id { get; set; }
        public string Stack { get; set; }
        public List<TimeTableSubject> TimeTableSubject { get; set; }
        public Faculty Faculty { get; set; }
        public ApplicationUser Teacher { get; set; }
    }
}