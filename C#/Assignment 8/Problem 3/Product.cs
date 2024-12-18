using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Implementing the CompareTo method to compare products by Price
        public int CompareTo(Product other)
        {
            if (other == null) return 1; // Handle null case
            return Price.CompareTo(other.Price);
        }

        // Override ToString for easy display
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price:C}";
        }
    }
}
