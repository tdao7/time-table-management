using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JwtAuthDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public List<TimeTable> TimeTables { get; set; }
    }
}