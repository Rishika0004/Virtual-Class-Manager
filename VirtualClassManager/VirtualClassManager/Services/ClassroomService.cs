using VirtualClassroomManager.Models;
using VirtualClassroomManager.Logging;
using System;
using System.Collections.Generic;

namespace VirtualClassroomManager.Services
{
    public class ClassroomService
    {
        private List<Classroom> classrooms = new List<Classroom>();
        private Logger logger = new Logger();

        public void AddClassroom(string name)
        {
            if (!ClassroomExists(name))
            {
                classrooms.Add(new Classroom { Name = name });
                logger.Log($"Classroom {name} has been created.");
            }
            else
            {
                Console.WriteLine($"Classroom {name} already exists.");
            }
        }

        public void RemoveClassroom(string name)
        {
            var classroom = classrooms.Find(c => c.Name == name);
            if (classroom != null)
            {
                classrooms.Remove(classroom);
                logger.Log($"Classroom {name} has been removed.");
            }
            else
            {
                Console.WriteLine($"Classroom {name} does not exist.");
            }
        }

        public void AddStudent(string studentId, string className)
        {
            var classroom = classrooms.Find(c => c.Name == className);
            if (classroom != null)
            {
                classroom.Students.Add(new Student { ID = studentId });
                logger.Log($"Student {studentId} has been enrolled in {className}.");
            }
            else
            {
                Console.WriteLine($"Classroom {className} does not exist.");
            }
        }

        public void ListStudentsInClass(string className)
        {
            var classroom = classrooms.Find(c => c.Name == className);
            if (classroom != null)
            {
                if (classroom.Students.Count > 0)
                {
                    Console.WriteLine($"Students in {className}:");
                    foreach (var student in classroom.Students)
                    {
                        Console.WriteLine($"- {student.ID}");
                    }
                }
                else
                {
                    Console.WriteLine($"No students in {className}.");
                }
            }
            else
            {
                Console.WriteLine($"Classroom {className} does not exist.");
            }
        }

        public void ScheduleAssignment(string className, string details)
        {
            var classroom = classrooms.Find(c => c.Name == className);
            if (classroom != null)
            {
                classroom.Assignments.Add(new Assignment { Details = details });
                logger.Log($"Assignment for {className} has been scheduled.");
            }
            else
            {
                Console.WriteLine($"Classroom {className} does not exist.");
            }
        }

        public void SubmitAssignment(string studentId, string className, string details)
        {
            var classroom = classrooms.Find(c => c.Name == className);
            if (classroom != null)
            {
                var assignment = classroom.Assignments.Find(a => a.Details == details);
                if (assignment != null)
                {
                    assignment.IsSubmitted = true;
                    logger.Log($"Assignment submitted by Student {studentId} in {className}.");
                }
                else
                {
                    Console.WriteLine($"Assignment not found in {className}.");
                }
            }
            else
            {
                Console.WriteLine($"Classroom {className} does not exist.");
            }
        }

        public void ListClassrooms()
        {
            if (classrooms.Count > 0)
            {
                foreach (var classroom in classrooms)
                {
                    Console.WriteLine($"Classroom: {classroom.Name}");
                }
            }
            else
            {
                Console.WriteLine("No classrooms available.");
            }
        }

        private bool ClassroomExists(string name)
        {
            return classrooms.Exists(c => c.Name == name);
        }
    }
}
