namespace AutoDefaultStructs;

public struct Address
{
    public Address(string street, string city, string country, int zipCode)
    {
        Street = street;
        City = city;
        Country = country;
        ZipCode = zipCode;
    }

    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; } = "US";
    public int ZipCode { get; set; }
}