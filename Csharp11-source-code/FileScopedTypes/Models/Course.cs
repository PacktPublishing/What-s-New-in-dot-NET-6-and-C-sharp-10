using System.Diagnostics.CodeAnalysis;

namespace FileScopedTypes;

public class Course
{
    required public int CourseId { get; set; }
    public string CourseName { get; set; }
    required public int CourseDuration { get; set; }

    public Course() { }

    [SetsRequiredMembers]
    public Course(int courseId, string courseName)
    {
        CourseId = courseId;
        CourseName = courseName;
        CourseDuration = 4;
    }
}

file enum COURSE_TYPE
{
    NONE,
    ENGINEERING,
    MEDICAL,
    MANAGEMENT
}