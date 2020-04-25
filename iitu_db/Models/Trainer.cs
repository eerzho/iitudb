using System;
namespace iitu_db.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int WorkExperience { get; set; }

        public Team Team { get; set; }
    }
}
