using System.Collections.Generic;
using JwtAuthDemo.Models;
using JwtAuthDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JwtAuthDemo.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IUserService _userService;
        private readonly ApplicationDbContext _context;

        public ValuesController(ILogger<ValuesController> logger, IUserService userService, ApplicationDbContext context)
        {
            _logger = logger;
            _userService = userService;
            _context = context;
        }

        [HttpGet("reset-default-data")]
        public IActionResult Get()
        {
            //Create Role
            var roles = new List<IdentityRole>();
            roles.Add(new IdentityRole("Admin"));
            roles.Add(new IdentityRole("Giáo viên"));
            roles.Add(new IdentityRole("Phòng hành chính"));
            roles.Add(new IdentityRole("Phòng đào tạo"));
            roles.Add(new IdentityRole("Sinh viên"));
            roles.Add(new IdentityRole("Khoa"));
            
            _context.AddRange(roles);
            
            //Create User
            var users = new List<AddUserRequest>();
            string[] listRoleTeacher = {roles[1].Id};
            string[] listRoleStudent = {roles[4].Id};
            string[] listRolePDT = {roles[3].Id};
            string[] listRoleKhoa = {roles[5].Id};
            string[] listRolePHC = {roles[2].Id};
            
            _userService.AddUser(new AddUserRequest {UserName = "giaovien01", Name = "Thầy Nguyễn Văn A", Password = "123123aA!", RoleList = new List<string>(listRoleTeacher)});
            _userService.AddUser(new AddUserRequest {UserName = "phc01", Name = "Thầy Nguyễn Văn A", Password = "123123aA!", RoleList = new List<string>(listRolePHC)});
            _userService.AddUser(new AddUserRequest {UserName = "pdt01", Name = "Thầy Nguyễn Văn A", Password = "123123aA!", RoleList = new List<string>(listRolePDT)});
            _userService.AddUser(new AddUserRequest {UserName = "sinhvien01", Name = "Thầy Nguyễn Văn A", Password = "123123aA!", RoleList = new List<string>(listRoleStudent)});
            _userService.AddUser(new AddUserRequest {UserName = "khoa01", Name = "Thầy Nguyễn Văn A", Password = "123123aA!", RoleList = new List<string>(listRoleKhoa)});

            //Creat Subject 
            var subjects = new List<Subject>();
            subjects.Add(new Subject {Code = "S001", Name = "Thực hành hệ điều hành"});
            subjects.Add(new Subject {Code = "S002", Name = "Phát triển ứng dụng di động"});
            subjects.Add(new Subject {Code = "S003", Name = "Phân tích thiết kế hệ thống"});
            subjects.Add(new Subject {Code = "S004", Name = "Các hệ thống thông minh"});
            _context.AddRange(subjects);
            
            //Create Class
            var rooms = new List<Room>();
            rooms.Add(new Room {Name = "404-C3"});
            rooms.Add(new Room {Name = "404-C2"});
            rooms.Add(new Room {Name = "404-C1"});
            rooms.Add(new Room {Name = "402-C1"});
            rooms.Add(new Room {Name = "402-C2"});
            _context.AddRange(rooms);
            
            
            //Creat Faculty
            var faculties = new List<Faculty>();
            faculties.Add(new Faculty {Name = "CNTT"});
            faculties.Add(new Faculty {Name = "KTPM"});
            _context.AddRange(faculties);
            
            //Create Class
            var classes = new List<Classroom>();
            classes.Add(new Classroom {Name = "CNTT K18", Faculty = faculties[0]});
            classes.Add(new Classroom {Name = "CNTT K17", Faculty = faculties[0]});
            classes.Add(new Classroom {Name = "CNTT K16", Faculty = faculties[0]});
            classes.Add(new Classroom {Name = "KTPM K18", Faculty = faculties[1]});
            classes.Add(new Classroom {Name = "KTPM K17", Faculty = faculties[1]});
            _context.AddRange(classes);

            _context.SaveChanges();
            return Ok(true);
        }
    }
}
