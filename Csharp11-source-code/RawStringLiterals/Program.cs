
Console.WriteLine();

// Traditional JSON representation
var computerCourseJson = "{ \"CourseId\": \"101\", \"CourseName\": \"Computer Science\", \"CourseDuration\": \"4\" }";
Console.WriteLine($"computerCourseJson: \n {computerCourseJson} \n");

// JSON representation using Raw String Literal
var computerCourseRaw = """{ "CourseId": "101", "CourseName": "Computer Science", "CourseDuration": "4" }""";
Console.WriteLine($"computerCourseRaw: \n {computerCourseRaw} \n");

// Multi-line Raw String Literal
var coursesRaw = """
    [
        {
            "CourseId": "101",
            "CourseName": "Computer Science",
            "CourseDuration": "4",
        },
        {
            "CourseId": "102",
            "CourseName": "Mechanical",
            "CourseDuration": "4",
        }
    ]
    """;
Console.WriteLine($"coursesRaw: \n {coursesRaw} \n");

int courseId = 101;
string courseName = "Computer Science";

// Simple string interpolation
string courseInterpolation = $"Interpolation: {courseId} {courseName}";
Console.WriteLine(courseInterpolation);

// Raw String Literal including interpolation
string courseInterpolationRaw = $$"""Raw String Literal Interpolation: {{{courseId}}} {{{courseName}}}""";
Console.WriteLine(courseInterpolationRaw);

Console.WriteLine();