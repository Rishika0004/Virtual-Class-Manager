using System.Collections.Generic;

namespace VirtualClassroomManager.Models
{
    public class Classroom
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
