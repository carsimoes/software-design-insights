using System;

namespace ValueObject
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public Address Address { get; set; }
    }

    public record Address(string Street, string City, string State, string Country, string PostalCode);
}
