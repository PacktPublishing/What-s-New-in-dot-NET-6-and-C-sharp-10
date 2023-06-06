public struct StudentDto
{
    public StudentDto()
    {
        StudentId = 100;
        FirstName = "noname";
    }
    public int StudentId { get; set; } // = 0;

    public string FirstName { get; set; } // = string.Empty;
}