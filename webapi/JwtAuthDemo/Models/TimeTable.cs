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
        public Subject Subject { get; set; }
        public string SubjectName { get; set; }
        public ApplicationUser Teacher { get; set; }
        public string TeacherName { get; set; }
    }
}