using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5 {
    internal class Program {
        static void Main(string[] args)
        {
            Product product1 = new Product("Товар1", 156);
            Product product2 = new Product("Товар2", 520);
            Product product3 = new Product("Товар3", 1207);
            Cart сart = new Cart();
            сart.AddProduct(product1);
            сart.AddProduct(product2);
            сart.AddProduct(product3);
            сart.ShowCart();
            int total = сart.GetTotal();
            Console.WriteLine(total);
        }
    }

    public class Product {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Cart {
        private List<Product> products = new List<Product>();


        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.Name} добавлен в корзину");
        }

        public int GetTotal()
        {
            int total = 0;

            for (int i = 0; i < products.Count; i++)

            {
                total += products[i].Price;
            }
            return total;
        }
        public void ShowCart()
        {
            Console.WriteLine("Корзина:");
            for (int i = 0; i < products.Count; i++) 
            {
                Console.WriteLine($"{products[i].Name} - {products[i].Price} рублей");
            }
        }
    }




}
