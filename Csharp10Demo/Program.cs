
#region Const interpolated strings

const string MONDAY = "Monday";
const string TUESDAY = "Tuesday";
const string WEEKDAYS = $"{MONDAY} {TUESDAY}";
Console.WriteLine(WEEKDAYS);

#endregion Const interpolated strings

#region Struct enhancements

//StudentDto student = new StudentDto();
//StudentDto student = default;
StudentDto student = new();
Console.WriteLine($"Student details: {student.StudentId} {student.FirstName}");

#endregion Struct enhancements

#region DateOnly and TimeOnly

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateOnly dateOnly = DateOnly.FromDateTime(now);
Console.WriteLine(dateOnly);
DateOnly newYear = new DateOnly(2022, 1, 1);
Console.WriteLine(newYear);

TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine(timeOnly);
TimeOnly wakeupTime = new TimeOnly(7, 0);
Console.WriteLine(wakeupTime);

#endregion DateOnly and TimeOnly


