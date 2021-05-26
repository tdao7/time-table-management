namespace JwtAuthDemo.Models
{
    public class TimeTableSubject
    {
        public Subject Subject { get; set; }
        public TimeTable TimeTable { get; set; }
        public int SubjectId { get; set; }
        public int TimeTableId { get; set; }
    }
}