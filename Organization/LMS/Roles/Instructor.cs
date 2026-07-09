using Courses.Course;

namespace Roles;

public class Instructor : Person
{
    public List<Course> AssignedCourses { get; set; }= new List<Course>();

    public void AssignCourse(Course course)
    {
        AssignedCourses.Add(course);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor Id: {id}");
        Console.WriteLine($"Instructor Name: {name}");

        foreach(var c in AssignedCourses)
        {
            Console.WriteLine($"Course : {c.CourseName}");
        }
    }
}

