using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace C971app.Models
{
    [Table("Course")]
    public class Course
    {   [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int TermId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstructorName { get; set; }
        public string InstructorPhone { get; set; }
        public string InstructorEmail { get; set; }
        public string Note { get; set; }
    }
}
