using RequiredModifier;

Console.WriteLine();

// Uses constructor with parameters.
var computerCourse = new Course
{
    CourseId = 101,
    CourseName = "Computer Science",
    CourseDuration = 4
};

Console.WriteLine($"Computer course details: {computerCourse.CourseId}, {computerCourse.CourseName}, {computerCourse.CourseDuration}");

// // Uses constructor with [SetsRequiredMembers] attribute.
var mechanicalCourse = new Course
(
    courseId: 102,
    courseName: "Mechnical"
);

Console.WriteLine($"Mechanical course details: {mechanicalCourse.CourseId}, {mechanicalCourse.CourseName}, {mechanicalCourse.CourseDuration}");

Console.WriteLine();