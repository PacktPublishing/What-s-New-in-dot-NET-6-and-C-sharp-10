using System.Text;

Console.WriteLine();

// UTF8 string literal
ReadOnlySpan<byte> courseDetails = "Course details"u8;

Console.WriteLine(Encoding.UTF8.GetString(courseDetails));

// UTF8 literal can not include string interpolation
var courseId = 101;
ReadOnlySpan<byte> tempCourseDetails = $"Course details: {courseId}"u8;

Console.WriteLine();