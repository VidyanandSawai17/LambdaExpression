using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 2000 },
                new Product { Id = 2, Name = "Product B", Price = 5000 },
                new Product { Id = 3, Name = "Product C", Price = 4000 },
                new Product { Id = 4, Name = "Product D", Price = 3000 },
                new Product { Id = 5, Name = "Product E", Price = 1000 },
                new Product { Id = 6, Name = "Product F", Price = 6000 },
                new Product { Id = 7, Name = "Product G", Price = 8000 },
                new Product { Id = 8, Name = "Product H", Price = 7000 },
                new Product { Id = 9, Name = "Product I", Price = 9000 },
                new Product { Id = 10, Name = "Product J", Price = 1500 }
            };

            // Display all products in descending order by their price
            Console.WriteLine("All products in descending order by price:");
            List<Product> sortedProducts = products.OrderByDescending(p => p.Price).ToList();
            foreach (Product product in sortedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine();

            // Display product whose Id is 5
            Console.WriteLine("Product with Id 5:");
            Product productWithId5 = products.FirstOrDefault(p => p.Id == 5);
            if (productWithId5 != null)
            {
                Console.WriteLine($"Id: {productWithId5.Id}, Name: {productWithId5.Name}, Price: {productWithId5.Price}");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
            Console.WriteLine();

            // Display all products whose price is less than 5000
            Console.WriteLine("Products with price less than 5000:");
            List<Product> productsLessThan5000 = products.Where(p => p.Price < 5000).ToList();
            foreach (Product product in productsLessThan5000)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine();

            // Display 3 products with maximum price
            Console.WriteLine("3 products with maximum price:");
            List<Product> productsWithMaxPrice = products.OrderByDescending(p => p.Price).Take(3).ToList();
            foreach (Product product in productsWithMaxPrice)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine();

            // Display 5 products with minimum price
            Console.WriteLine("5 products with minimum price:");
            List<Product> productsWithMinPrice = products.OrderBy(p => p.Price).Take(5).ToList();
            foreach (Product product in productsWithMinPrice)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}