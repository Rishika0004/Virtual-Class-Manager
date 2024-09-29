using VirtualClassroomManager.Services;
using System;

namespace VirtualClassroomManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var classroomService = new ClassroomService();

            while (true)
            {
                Console.WriteLine("Enter command (add_classroom, remove_classroom, add_student, list_students, schedule_assignment, submit_assignment, list_classrooms, exit):");
                var command = Console.ReadLine();

                if (command == "exit")
                    break;

                switch (command)
                {
                    case "add_classroom":
                        Console.Write("Enter classroom name: ");
                        string className = Console.ReadLine();
                        classroomService.AddClassroom(className);
                        break;

                    case "remove_classroom":
                        Console.Write("Enter classroom name to remove: ");
                        string classToRemove = Console.ReadLine();
                        classroomService.RemoveClassroom(classToRemove);
                        break;

                    case "add_student":
                        Console.Write("Enter student ID: ");
                        string studentId = Console.ReadLine();
                        Console.Write("Enter classroom name: ");
                        string classForStudent = Console.ReadLine();
                        classroomService.AddStudent(studentId, classForStudent);
                        break;

                    case "list_students":
                        Console.Write("Enter classroom name: ");
                        string classToListStudents = Console.ReadLine();
                        classroomService.ListStudentsInClass(classToListStudents);
                        break;

                    case "schedule_assignment":
                        Console.Write("Enter classroom name: ");
                        string classForAssignment = Console.ReadLine();
                        Console.Write("Enter assignment details: ");
                        string assignmentDetails = Console.ReadLine();
                        classroomService.ScheduleAssignment(classForAssignment, assignmentDetails);
                        break;

                    case "submit_assignment":
                        Console.Write("Enter student ID: ");
                        string studentForSubmission = Console.ReadLine();
                        Console.Write("Enter classroom name: ");
                        string classForSubmission = Console.ReadLine();
                        Console.Write("Enter assignment details: ");
                        string assignmentToSubmit = Console.ReadLine();
                        classroomService.SubmitAssignment(studentForSubmission, classForSubmission, assignmentToSubmit);
                        break;

                    case "list_classrooms":
                        classroomService.ListClassrooms();
                        break;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}
