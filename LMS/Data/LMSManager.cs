using Roles.Students;
using Roles.persons;
using Courses.Course;
using Roles.Instructors;

namespace Data.LMSManager;

public class LMSManager
{
    public List<Student> Students = new();

    public List<Instructor> Instructors = new();

    public List<Course> Courses = new();

    public List<Person> People = new();
}