using System.Xml.Linq;
using System.Linq;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new AppDbContext();
var products = context.Products.ToList();


Product Product1 = new Product
{
    Name = "Keyboard",
    Category = "Electronics",
    Price = 30.5m,
    Quantity = 10,
    CreatedAt = new DateTime(2026, 1, 1),
    IsAvailable = true
};

Product Product2 = new Product
{
    Name = "Mouse",
    Category = "Electronics",
    Price = 15.9m,
    Quantity = 25,
    CreatedAt = new DateTime(2026, 1, 2),
    IsAvailable = true
};

Product Product3 = new Product
{
    Name = "Monitor",
    Category = "Electronics",
    Price = 220.16m,
    Quantity = 8,
    CreatedAt = new DateTime(2026, 1, 3),
    IsAvailable = true
};

Product Product4 = new Product
{
    Name = "Laptop",
    Category = "Electronics",
    Price = 950.12m,
    Quantity = 5,
    CreatedAt = new DateTime(2026, 1, 4),
    IsAvailable = true
};

Product Product5 = new Product
{
    Name = "Headphones",
    Category = "Electronics",
    Price = 75.11m,
    Quantity = 12,
    CreatedAt = new DateTime(2026, 1, 5),
    IsAvailable = true
};

Product Product6 = new Product
{
    Name = "Desk",
    Category = "Furniture",
    Price = 180.5m,
    Quantity = 6,
    CreatedAt = new DateTime(2026, 1, 6),
    IsAvailable = true
};

Product Product7 = new Product
{
    Name = "Chair",
    Category = "Furniture",
    Price = 120.1m,
    Quantity = 10,
    CreatedAt = new DateTime(2026, 1, 7),
    IsAvailable = true
};

Product Product8 = new Product
{
    Name = "Bookshelf",
    Category = "Furniture",
    Price = 150.3m,
    Quantity = 4,
    CreatedAt = new DateTime(2026, 1, 8),
    IsAvailable = true
};

Product Product9 = new Product
{
    Name = "Notebook",
    Category = "Stationery",
    Price = 5.5m,
    Quantity = 50,
    CreatedAt = new DateTime(2026, 1, 9),
    IsAvailable = true
};

Product Product10 = new Product
{
    Name = "Pen",
    Category = "Stationery",
    Price = 2.5m,
    Quantity = 100,
    CreatedAt = new DateTime(2026, 1, 10),
    IsAvailable = true
};

Product Product11 = new Product
{
    Name = "Backpack",
    Category = "Accessories",
    Price = 45.8m,
    Quantity = 15,
    CreatedAt = new DateTime(2026, 1, 11),
    IsAvailable = true
};

Product Product12 = new Product
{
    Name = "Wallet",
    Category = "Accessories",
    Price = 35.6m,
    Quantity = 20,
    CreatedAt = new DateTime(2026, 1, 12),
    IsAvailable = true
};

Product Product13 = new Product
{
    Name = "T-Shirt",
    Category = "Clothing",
    Price = 25.1m,
    Quantity = 30,
    CreatedAt = new DateTime(2026, 1, 13),
    IsAvailable = true
};

Product Product14 = new Product
{
    Name = "Jeans",
    Category = "Clothing",
    Price = 60.7m,
    Quantity = 18,
    CreatedAt = new DateTime(2026, 1, 14),
    IsAvailable = true
};

Product Product15 = new Product
{
    Name = "Jacket",
    Category = "Clothing",
    Price = 110.47m,
    Quantity = 7,
    CreatedAt = new DateTime(2026, 1, 15),
    IsAvailable = true
};

Product Product16 = new Product
{
    Name = "Coffee",
    Category = "Food",
    Price = 12.4m,
    Quantity = 40,
    CreatedAt = new DateTime(2026, 1, 16),
    IsAvailable = true
};

Product Product17 = new Product
{
    Name = "Tea",
    Category = "Food",
    Price = 8.2m,
    Quantity = 35,
    CreatedAt = new DateTime(2026, 1, 17),
    IsAvailable = true
};

Product Product18 = new Product
{
    Name = "Chocolate",
    Category = "Food",
    Price = 6.5m,
    Quantity = 60,
    CreatedAt = new DateTime(2026, 1, 18),
    IsAvailable = true
};

Product Product19 = new Product
{
    Name = "Lamp",
    Category = "Home",
    Price = 40.7m,
    Quantity = 9,
    CreatedAt = new DateTime(2026, 1, 19),
    IsAvailable = true
};

Product Product20 = new Product
{
    Name = "Clock",
    Category = "Home",
    Price = 30.4m,
    Quantity = 11,
    CreatedAt = new DateTime(2026, 1, 20),
    IsAvailable = true
};


context.Products.AddRange(
    Product1,
    Product2,
    Product3,
    Product4,
    Product5,
    Product6,
    Product7,
    Product8,
    Product9,
    Product10,
    Product11,
    Product12,
    Product13,
    Product14,
    Product15,
    Product16,
    Product17,
    Product18,
    Product19,
    Product20
);

context.SaveChanges();






Console.WriteLine("========================\nONLINE STORE\n========================");

Console.WriteLine("1. Show all products");
Console.WriteLine("2. Add product");
Console.WriteLine("3. Update product");
Console.WriteLine("4. Delete product");
Console.WriteLine();

Console.WriteLine("5. Find product by name");
Console.WriteLine("6. Show products by category");
Console.WriteLine("7. Show available products");
Console.WriteLine("8. Show expensive products");
Console.WriteLine("9. Show products sorted by price");
Console.WriteLine();

Console.WriteLine("10. Show total products");
Console.WriteLine("11. Show total inventory value");
Console.WriteLine("...");
Console.WriteLine();

Console.WriteLine("0. Exit");
Console.Write("Choose: ");

switch (Console.ReadLine())
{
    case "1":
        // Show all products
        break;

    case "2":
        // Add product
        break;

    case "3":
        // Update product
        break;

    case "4":
        // Delete product
        break;

    case "5":
        // Find product by name
        break;

    case "6":
        // Show products by category
        break;

    case "7":
        // Show available products
        break;

    case "8":
        // Show expensive products
        break;

    case "9":
        // Show products sorted by price
        break;

    case "10":
        // Show total products
        break;

    case "11":
        // Show total inventory value
        break;

    case "0":
        // Exit
        break;
}
