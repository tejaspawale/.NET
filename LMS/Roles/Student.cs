namespace Roles.Students;
using Roles.persons;
using Courses.Course;


public class Student : Person
{
    public List<Course> EnrolledCourses { get; set; } = new List<Course>();

    public void EnrollCourse(Course course)
    {
        EnrolledCourses.Add(course);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Id: {id}");
        Console.WriteLine($"Student Name: {name}");

        foreach(var c in EnrolledCourses)
        {
            Console.WriteLine($"Course : {c.CourseName}");
        }
    }
}