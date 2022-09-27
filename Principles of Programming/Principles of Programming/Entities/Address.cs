namespace Principles_of_Programming
{
    public class Address
    {
        public Address(string openAddress, string street, string city, string country)
        {
            OpenAddress = openAddress;
            Street = street;
            City = city;
            Country = country;
        }
        public string OpenAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
