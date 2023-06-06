using AutoDefaultStructs;

Console.WriteLine();

Address address = new Address
{
    Street = "500 Fidler Drive",
    Country = "US"
};

// Address = 500 Fidler Drive, , US, 0
Console.WriteLine($"Address = {address.Street}, {address.City}, {address.Country}, {address.ZipCode}");

Console.WriteLine();