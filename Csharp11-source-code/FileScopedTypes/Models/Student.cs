namespace FileScopedTypes;

public class Student
{
    public int StudentId { get; set; }  
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public Course Course { get; set; }
}

file enum COURSE_TYPE
{
    NONE,
    ENGINEERING,
    MEDICAL,
    MANAGEMENT
}