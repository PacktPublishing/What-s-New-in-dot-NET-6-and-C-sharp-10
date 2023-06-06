using System.Diagnostics.CodeAnalysis;

namespace RequiredModifier;

public class Course
{
    required public int CourseId { get; set; }
    public string CourseName { get; set; } = string.Empty;
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