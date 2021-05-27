using System;
using System.Linq;
using JwtAuthDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public IActionResult GetSchema()
        {
            var listSchedules = _context.Schedules
                .Include(s => s.Faculty)
                .Include(s => s.T0)
                .Include(s => s.T2)
                .Include(s => s.T3)
                .Include(s => s.T4)
                .Include(s => s.T5)
                .Include(s => s.T6)
                .Include(s => s.T7)
                .ToList();
            return Ok(listSchedules);
        }

        [HttpPost]
        public IActionResult CreateSchema([FromBody] CreateSchemaForm createSchemaForm)
        {
            var faculty = _context.Faculties.FirstOrDefault(f => f.Id == createSchemaForm.FacultyId);
            var schedule = new Schedule
            {
                Description = createSchemaForm.Classroom + " / " + createSchemaForm.Room,
                StartTime = createSchemaForm.StartTime,
                EndTime = createSchemaForm.EndTime,
                Faculty = faculty
            };

            _context.Add(schedule);
            _context.SaveChanges();
            return Ok(true);
        }

        [HttpPost("set-timetable")]
        public IActionResult SetTimetable([FromBody] SetTimetableForm setTimetableForm)
        {
            var schedule = _context.Schedules.FirstOrDefault(f => f.Id == setTimetableForm.ScheduleId);
            var teacher = _context.ApplicationUsers.FirstOrDefault(u => u.Id == setTimetableForm.teacherId);
            var subject = _context.Subjects.FirstOrDefault(s => s.Id == setTimetableForm.subjectId);

            var timetable = new TimeTable
            {
                Stack = setTimetableForm.Stack,
                Teacher = teacher,
                Subject = subject,
                TeacherName = teacher?.Name,
                SubjectName = subject?.Name
            };

            _context.Add(timetable);
            _context.SaveChanges();

            switch (setTimetableForm.dayIndex)
            {
                case 0:
                    schedule.T0 = timetable;
                    break;
                case 2:
                    schedule.T2 = timetable;
                    break;
                case 3:
                    schedule.T3 = timetable;
                    break;
                case 4:
                    schedule.T4 = timetable;
                    break;
                case 5:
                    schedule.T5 = timetable;
                    break;
                case 6:
                    schedule.T6 = timetable;
                    break;
                case 7:
                    schedule.T7 = timetable;
                    break;
            }

            _context.Update(schedule);
            _context.SaveChanges();

            return Ok(true);
        }
    }

    public class CreateSchemaForm
    {
        public string Classroom { get; set; }
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int FacultyId { get; set; }
    }

    public class SetTimetableForm
    {
        public int dayIndex { get; set; }
        public int ScheduleId { get; set; }
        public string Stack { get; set; }
        public string teacherId { get; set; }
        public int subjectId { get; set; }
    }
}