using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class Schedule
    {
        [Key]
        
        public int Id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeTable T2 { get; set; }
        public TimeTable T3 { get; set; }
        public TimeTable T4 { get; set; }
        public TimeTable T5 { get; set; }
        public TimeTable T6 { get; set; }
        public TimeTable T7 { get; set; }
        public TimeTable T0 { get; set; }
        public Faculty Faculty { get; set; }
        public string Description { get; set; }
        public List<ScheduleRoom> ScheduleRooms { get; set; }
        public List<ScheduleClassroom> ScheduleClassrooms { get; set; }
    }
}