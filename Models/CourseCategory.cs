using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaxkendEterna.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Team> Courses { get; set; }

    }
}
