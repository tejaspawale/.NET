using Roles;
namespace Courses;

public class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public int Duration { get; set; }

    public Instructor AssignedInstructor { get; set; }

    public Course()
    {
    }

    public Course(string name)
    {
        CourseName = name;
    }

    public Course(string name, int duration)
    {
        CourseName = name;
        Duration = duration;
    }
}