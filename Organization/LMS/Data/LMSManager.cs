using Roles;
using Courses.Course;
using Roles.Instructors;

namespace Data;

public class LMSManager
{
    public List<Student> Students = new List<Student>();

    public List<Instructor> Instructors = new List<Instructor>();

    public List<Course> Courses = new List<Course>();

    public List<Person> People = new List<Person>();
}