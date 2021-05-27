using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtAuthDemo.Models
{
    public class Subject
    {
        [Key]
        
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<TimeTable>  TimeTables { get; set; }
    }
}