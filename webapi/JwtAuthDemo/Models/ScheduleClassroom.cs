namespace JwtAuthDemo.Models
{
    public class ScheduleClassroom
    {
        public Classroom Classroom { get; set; }
        public Schedule Schedule { get; set; }
        public int ClassroomId { get; set; }
        public int ScheduleId { get; set; }
    }
}