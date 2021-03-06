using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace C971app.Models
{
    [Table("Term")]
    public class Term
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
