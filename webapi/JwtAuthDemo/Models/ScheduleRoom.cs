namespace JwtAuthDemo.Models
{
    public class ScheduleRoom
    {
        public Room Room { get; set; }
        public Schedule Schedule { get; set; }
        public int RoomId { get; set; }
        public int ScheduleId { get; set; }
    }
}