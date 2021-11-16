using software_design_insights.ValueObject;
using System;

namespace software_design_insights
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Address = new Address("street 1", "gothan", "MI", "Rileh", "666");

            Console.WriteLine("Hello World!");
        }
    }
}
