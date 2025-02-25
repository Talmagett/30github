using System;
using System.Collections.Generic;
using System.Linq;

namespace GamedevClub.TeacherPlans
{
    public class Lesson18
    {
        public void LinqExample()
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 1200),
                new Product("Mouse", 25),
                new Product("Keyboard", 75),
                new Product("Monitor", 300),
                new Product("USB Cable", 10)
            };

            var expensiveProducts = products.Where(p => p.Price > 50);

            Console.WriteLine("Expensive products:");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }

    public class Product
    {
        public string Name { get; }
        public double Price { get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}