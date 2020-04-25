using System;
using System.Collections.Generic;

namespace iitu_db.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Position { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
