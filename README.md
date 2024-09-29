# Virtual-Class-Manager
Company's Task

Program.cs
    Purpose: The entry point of the application.
    Functionality: Prompts the user for input through commands (e.g., add_classroom, add_student, schedule_assignment, etc.).
    Delegates tasks to the ClassroomService for managing classrooms, students, assignments, and more.
Continuously listens for user input until the exit command is given.
2. Classroom.cs
    Purpose: Represents a classroom in the virtual environment.
    Key Attributes:
    Name: The name of the classroom.
    Students: A list of students enrolled in the classroom.
    Assignments: A list of assignments for the classroom.
    Functionality: Provides the ability to enroll students and add assignments.
    Manages the list of students and assignments.
3. Student.cs
    Purpose: Represents a student.
    Key Attributes:
    ID: The unique identifier for the student.
    Name: The student's name.
    Functionality: Holds basic information about each student.
4. Assignment.cs
    Purpose: Represents an assignment in the virtual classroom.
    Key Attributes:
    Details: Stores the details or description of the assignment.
    Functionality: Holds the assignment details to schedule and submit assignments for students.
5. ClassroomService.cs
    Purpose: Provides services to manage classrooms, students, and assignments.
    Functionality:
    AddClassroom: Creates and adds a new classroom.
    RemoveClassroom: Removes a classroom based on its name.
    ListClassrooms: Lists all the created classrooms.
    AddStudent: Adds a student to a specified classroom.
    ListStudents: Displays the list of students in a specific classroom.
    ScheduleAssignment: Schedules assignments for a classroom.
    SubmitAssignment: Marks an assignment as submitted for a student.
6. Logger.cs
    Purpose: Handles logging of system messages.
    Functionality: Logs actions such as classroom creation, student enrollment, assignment scheduling, and submissions.
