
Console.WriteLine();

var now = DateTime.Now;

// DateTime.Now
Console.WriteLine($"DateTime.Now = {now}");

// Microseconds
Console.WriteLine($"DateTime.Now.Microsecond = {now.Microsecond}");

// Nanoseconds
Console.WriteLine($"DateTime.Now.Nanosecond = {now.Nanosecond}");

// AddMicroSeconds
Console.WriteLine($"DateTime.Now.AddMicroSeconds = {now.AddMicroseconds(100)}");

Console.WriteLine();