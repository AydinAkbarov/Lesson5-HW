using Lesson5_asp_hw.Models;

namespace Lesson5_asp_hw.Helpers
{
    public static class ProductHelper
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Wireless Mouse", Price = 25, Description = "Ergonomic wireless mouse with smooth scrolling and long battery life." },
            new Product { Id = 2, Name = "Mechanical Keyboard", Price = 80, Description = "RGB backlit mechanical keyboard with blue switches for fast typing." },
            new Product { Id = 3, Name = "Gaming Headset", Price = 60, Description = "Surround sound headset with noise-canceling microphone." },
            new Product { Id = 4, Name = "Laptop Stand", Price = 30, Description = "Adjustable aluminum laptop stand for better posture and airflow." },
            new Product { Id = 5, Name = "USB-C Hub", Price = 45, Description = "Multi-port USB-C hub with HDMI, USB 3.0 and SD card support." },
            new Product { Id = 6, Name = "Smart Watch", Price = 120, Description = "Fitness tracking smart watch with heart rate and sleep monitor." },
            new Product { Id = 7, Name = "Bluetooth Speaker", Price = 55, Description = "Portable Bluetooth speaker with deep bass and waterproof design." },
            new Product { Id = 8, Name = "External SSD 1TB", Price = 150, Description = "High-speed external SSD for backups and large file transfers." },
            new Product { Id = 9, Name = "Webcam HD", Price = 40, Description = "Full HD webcam suitable for online meetings and streaming." },
            new Product { Id = 10, Name = "Wireless Charger", Price = 35, Description = "Fast wireless charging pad compatible with all Qi devices." }

        };
        public static List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
