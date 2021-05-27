using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDemo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string,
        IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>,
        IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<ScheduleClassroom> TimeTableClassrooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ScheduleRoom> ScheduleRooms { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ScheduleClassroom>().HasKey(a => new {a.ClassroomId, TimeTableId = a.ScheduleId});
            builder.Entity<ScheduleRoom>().HasKey(a => new {a.RoomId, a.ScheduleId});
        }
    }
}