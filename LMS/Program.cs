using Data.LMSManager;
using Roles.Students;
using Roles.Instructors;
using Courses.Course;
using Interface.INotificationService;
using Singleton.LMSConfigurationManager;
using Service.SmsNotificationService;
using Service.EmailNotificationService;


LMSManager manager = new LMSManager();

while (true)
{
    Console.WriteLine("\n========= LMS MAIN MENU =========");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Instructor");
    Console.WriteLine("3. Add Course");
    Console.WriteLine("4. Enroll Student in Course");
    Console.WriteLine("5. Assign Instructor to Course");
    Console.WriteLine("6. View All Students");
    Console.WriteLine("7. View All Instructors");
    Console.WriteLine("8. View All Courses");
    Console.WriteLine("9. Send Notification");
    Console.WriteLine("10. Show System Configuration");
    Console.WriteLine("11. Exit");
    Console.WriteLine("=================================");

    Console.Write("Enter Choice: ");

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid Input!");
        continue;
    }

    switch (choice)
    {
        case 1:
        {
            Console.Write("Student Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            Student student = new Student
            {
                id = id,
                name = name
            };

            manager.Students.Add(student);
            manager.People.Add(student);

            Console.WriteLine("Student Added Successfully.");
            break;
        }

        case 2:
        {
            Console.Write("Instructor Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Instructor Name: ");
            string name = Console.ReadLine();

            Instructor instructor = new Instructor
            {
                id = id,
                name = name
            };

            manager.Instructors.Add(instructor);
            manager.People.Add(instructor);

            Console.WriteLine("Instructor Added Successfully.");
            break;
        }

        case 3:
        {
            Console.Write("Course Id: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();

            Console.Write("Duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            Course course = new Course
            {
                CourseId = courseId,
                CourseName = courseName,
                Duration = duration
            };

            manager.Courses.Add(course);

            Console.WriteLine("Course Added Successfully.");
            break;
        }

        case 4:
        {
            Console.Write("Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();

            Student student =
                manager.Students.FirstOrDefault(s => s.name == studentName);

            Course course =
                manager.Courses.FirstOrDefault(c => c.CourseName == courseName);

            if (student != null && course != null)
            {
                student.EnrollCourse(course);
                Console.WriteLine("Enrollment Successful.");
            }
            else
            {
                Console.WriteLine("Student or Course Not Found.");
            }

            break;
        }

        case 5:
        {
            Console.Write("Instructor Name: ");
            string instructorName = Console.ReadLine();

            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();

            Instructor instructor =
                manager.Instructors.FirstOrDefault(i => i.name == instructorName);

            Course course =
                manager.Courses.FirstOrDefault(c => c.CourseName == courseName);

            if (instructor != null && course != null)
            {
                instructor.AssignCourse(course);
                course.AssignedInstructor = instructor;

                Console.WriteLine("Instructor Assigned.");
            }
            else
            {
                Console.WriteLine("Instructor or Course Not Found.");
            }

            break;
        }

        case 6:
        {
            Console.WriteLine("\n----- STUDENTS -----");

            foreach (Student student in manager.Students)
            {
                student.DisplayInfo();
            }

            break;
        }

        case 7:
        {
            Console.WriteLine("\n----- INSTRUCTORS -----");

            foreach (Instructor instructor in manager.Instructors)
            {
                instructor.DisplayInfo();
            }

            break;
        }

        case 8:
        {
            Console.WriteLine("\n----- COURSES -----");

            foreach (Course course in manager.Courses)
            {
                Console.WriteLine(
                    $"Id: {course.CourseId} | Name: {course.CourseName} | Duration: {course.Duration}");
            }

            break;
        }

        case 9:
        {
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");

            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Message: ");
            string message = Console.ReadLine();

            INotificationService service;

            if (type == 1)
            {
                service = new EmailNotificationService();
            }
            else
            {
                service = new SmsNotificationService();
            }

            service.SendNotification(message);

            break;
        }

        case 10:
        {
            LMSConfigurationManager config = LMSConfigurationManager.GetInstance();

            Console.WriteLine("\n----- CONFIGURATION -----");
            Console.WriteLine($"Institute : {config.InstituteName}");
            Console.WriteLine($"Version   : {config.Version}");
            Console.WriteLine($"Contact   : {config.AdminContact}");

            break;
        }

        case 11:
        {
            Console.WriteLine("Thank You!");
            return;
        }

        default:
        {
            Console.WriteLine("Invalid Choice.");
            break;
        }
    }
}