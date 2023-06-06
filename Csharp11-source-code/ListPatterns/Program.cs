
Console.WriteLine();

List<int> courseIDs = new() { 101, 102, 103, 104 };

Console.WriteLine($"courseIDs is [101, 102, 103, 104] = {courseIDs is [101, 102, 103, 104]}");

#region discard pattern
Console.WriteLine("\ndiscard pattern:");

Console.WriteLine($"courseIDs is [101, 102, _, 104] = {courseIDs is [101, 102, _, 104]}"); // True

Console.WriteLine($"courseIDs is [_, _, _, 104] = {courseIDs is [_, _, _, 104]}"); // True

Console.WriteLine($"courseIDs is [_, _, _, 104, 105] = {courseIDs is [_, _, _, 104, 105]}"); // False
#endregion

#region range pattern
// Console.WriteLine("\nrange pattern:");

// Console.WriteLine($"courseIDs is [101, 102, .., 105] = {courseIDs is [101, 102, .., 105]}"); // True

// Console.WriteLine($"courseIDs is [.., 104] = {courseIDs is [.., 104]}"); // True
#endregion

#region var pattern
Console.WriteLine("\nvar pattern:");

if (courseIDs is [_, _, var id, 104])
{
    Console.WriteLine($"Course ID = {id}"); 
}
#endregion

Console.WriteLine();