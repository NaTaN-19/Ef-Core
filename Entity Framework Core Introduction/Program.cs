using System.Xml.Linq;
using System.Linq;
using Microsoft.EntityFrameworkCore;

//Install-Package Microsoft.EntityFrameworkCore
//Install-Package Microsoft.EntityFrameworkCore.SqlServer
//Install-Package Microsoft.EntityFrameworkCore.Tools
//in SQL Server
//CREATE DATABASE OnlineStore
//Tools → NuGet Package Manager → Package Manager Console
//Add-Migration InitialCreate
//Update-Database

AppDbContext context = new AppDbContext();
var products = context.Products.ToList();

SeedProducts();
RunMenu();

//Fill DB
//Add at least 10 products with different category
void SeedProducts()
{
    if (context.Products.Any())
        return;

    context.Products.AddRange(
        new Product
        {
            Name = "Keyboard",
            Category = "Electronics",
            Price = 30.5m,
            Quantity = 10,
            CreatedAt = new DateTime(2026, 1, 1),
            IsAvailable = true
        },

        new Product
        {
            Name = "Mouse",
            Category = "Electronics",
            Price = 15.9m,
            Quantity = 25,
            CreatedAt = new DateTime(2026, 1, 2),
            IsAvailable = true
        },

        new Product
        {
            Name = "Monitor",
            Category = "Electronics",
            Price = 220.16m,
            Quantity = 8,
            CreatedAt = new DateTime(2026, 1, 3),
            IsAvailable = true
        },

        new Product
        {
            Name = "Laptop",
            Category = "Electronics",
            Price = 950.12m,
            Quantity = 5,
            CreatedAt = new DateTime(2026, 1, 4),
            IsAvailable = true
        },

        new Product
        {
            Name = "Headphones",
            Category = "Electronics",
            Price = 75.11m,
            Quantity = 12,
            CreatedAt = new DateTime(2026, 1, 5),
            IsAvailable = true
        },

        new Product
        {
            Name = "Desk",
            Category = "Furniture",
            Price = 180.5m,
            Quantity = 6,
            CreatedAt = new DateTime(2026, 1, 6),
            IsAvailable = true
        },

        new Product
        {
            Name = "Chair",
            Category = "Furniture",
            Price = 120.1m,
            Quantity = 10,
            CreatedAt = new DateTime(2026, 1, 7),
            IsAvailable = true
        },

        new Product
        {
            Name = "Bookshelf",
            Category = "Furniture",
            Price = 150.3m,
            Quantity = 4,
            CreatedAt = new DateTime(2026, 1, 8),
            IsAvailable = true
        },

        new Product
        {
            Name = "Notebook",
            Category = "Stationery",
            Price = 5.5m,
            Quantity = 50,
            CreatedAt = new DateTime(2026, 1, 9),
            IsAvailable = true
        },

        new Product
        {
            Name = "Pen",
            Category = "Stationery",
            Price = 2.5m,
            Quantity = 100,
            CreatedAt = new DateTime(2026, 1, 10),
            IsAvailable = true
        },

        new Product
        {
            Name = "Backpack",
            Category = "Accessories",
            Price = 45.8m,
            Quantity = 15,
            CreatedAt = new DateTime(2026, 1, 11),
            IsAvailable = true
        },

        new Product
        {
            Name = "Wallet",
            Category = "Accessories",
            Price = 35.6m,
            Quantity = 20,
            CreatedAt = new DateTime(2026, 1, 12),
            IsAvailable = true
        },

        new Product
        {
            Name = "T-Shirt",
            Category = "Clothing",
            Price = 25.1m,
            Quantity = 30,
            CreatedAt = new DateTime(2026, 1, 13),
            IsAvailable = true
        },

        new Product
        {
            Name = "Jeans",
            Category = "Clothing",
            Price = 60.7m,
            Quantity = 18,
            CreatedAt = new DateTime(2026, 1, 14),
            IsAvailable = true
        },

        new Product
        {
            Name = "Jacket",
            Category = "Clothing",
            Price = 110.47m,
            Quantity = 7,
            CreatedAt = new DateTime(2026, 1, 15),
            IsAvailable = true
        },

        new Product
        {
            Name = "Coffee",
            Category = "Food",
            Price = 12.4m,
            Quantity = 40,
            CreatedAt = new DateTime(2026, 1, 16),
            IsAvailable = true
        },

        new Product
        {
            Name = "Tea",
            Category = "Food",
            Price = 8.2m,
            Quantity = 35,
            CreatedAt = new DateTime(2026, 1, 17),
            IsAvailable = true
        },

        new Product
        {
            Name = "Chocolate",
            Category = "Food",
            Price = 6.5m,
            Quantity = 60,
            CreatedAt = new DateTime(2026, 1, 18),
            IsAvailable = true
        },

        new Product
        {
            Name = "Lamp",
            Category = "Home",
            Price = 40.7m,
            Quantity = 9,
            CreatedAt = new DateTime(2026, 1, 19),
            IsAvailable = true
        },

        new Product
        {
            Name = "Clock",
            Category = "Home",
            Price = 30.4m,
            Quantity = 11,
            CreatedAt = new DateTime(2026, 1, 20),
            IsAvailable = true
        }
    );

    context.SaveChanges();

    Console.WriteLine("Products seeded!");
}

void RunMenu()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("========================");
        Console.WriteLine("      ONLINE STORE");
        Console.WriteLine("========================");

        Console.WriteLine("1. Show all products");
        Console.WriteLine("2. Add product");
        Console.WriteLine("3. Update product");
        Console.WriteLine("4. Delete product");
        Console.WriteLine();

        Console.WriteLine("5. Find product by name");
        Console.WriteLine("6. Show products by category");
        Console.WriteLine("7. Show available products");
        Console.WriteLine("8. Show expensive products");
        Console.WriteLine("9. Sort products ascending by price");
        Console.WriteLine("10. Sort products descending by price");
        Console.WriteLine();

        Console.WriteLine("11. Show total products");
        Console.WriteLine("12. Show total inventory value");
        Console.WriteLine("13. Show the most expensive product");
        Console.WriteLine("14. Show the cheapest product");
        Console.WriteLine("15. Show average price");
        Console.WriteLine("16. Show out-of-stock products");
        Console.WriteLine("17. Show top 3 most expensive products");
        Console.WriteLine();

        Console.WriteLine("0. Exit");
        Console.Write("Choose: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ShowAllProducts();
                break;

            case "2":
                AddProduct();
                break;

            case "3":
                UpdateProduct();
                break;

            case "4":
                DeleteProduct();
                break;

            case "5":
                FindProductByName();
                break;

            case "6":
                ShowProductsByCategory();
                break;

            case "7":
                ShowAvailableProducts();
                break;

            case "8":
                ShowExpensiveProducts();
                break;

            case "9":
                SortProductsAscending();
                break;

            case "10":
                SortProductsDescending();
                break;

            case "11":
                ShowTotalProducts();
                break;

            case "12":
                ShowTotalInventoryValue();
                break;
            case "13":
                ShowTheMostExpensiveProduct();
                break;
            case "14":
                ShowTheMostCheapProduct();
                break;
            case "15":
                ShowAveragePrice();
                break;
            case "16":
                ShowOutOfStockProducts();
                break;
            case "17":
                ShowTop3MostExpensiveProducts();
                break;
            case "0":
                return;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
//Show all products
void ShowAllProducts()
{
    var productsFromOnlineStore = context.Products.ToList();

    foreach (var product in productsFromOnlineStore)
    {
        Console.WriteLine($"Id: {product.Id}");
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Category: {product.Category}");
        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine($"Quantity: {product.Quantity}");
        Console.WriteLine($"CreatedAt: {product.CreatedAt}");
        Console.WriteLine($"IsAvailable: {product.IsAvailable}");
        Console.WriteLine("----------------------------------");
    }
}
//Add product
void AddProduct()
{
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Category: ");
    string category = Console.ReadLine();

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Console.Write("CreatedAt: ");
    DateTime createdAt = DateTime.Parse(Console.ReadLine());

    Console.Write("IsAvailable: ");
    bool isAvailable = bool.Parse(Console.ReadLine());

    Product product = new Product
    {
        Name = name,
        Category = category,
        Price = price,
        Quantity = quantity,
        CreatedAt = createdAt,
        IsAvailable = isAvailable
    };

    context.Products.Add(product);
    context.SaveChanges();

    Console.WriteLine("Product added!");
}
//Update product
void UpdateProduct()
{
    Console.Write("Enter product Id: ");
    int id = int.Parse(Console.ReadLine());

    var product = context.Products.Find(id);

    if (product == null)
    {
        Console.WriteLine("Product not found.");
        return;
    }

    Console.Write("New price: ");
    product.Price = decimal.Parse(Console.ReadLine());

    Console.Write("New quantity: ");
    product.Quantity = int.Parse(Console.ReadLine());

    context.SaveChanges();

    Console.WriteLine("Product updated!");
}
//Delete product
void DeleteProduct()
{
    Console.Write("Enter product Id: ");
    int id = int.Parse(Console.ReadLine());

    var product = context.Products.Find(id);

    if (product == null)
    {
        Console.WriteLine("Product not found.");
        return;
    }

    context.Products.Remove(product);
    context.SaveChanges();

    Console.WriteLine("Product deleted!");
}
//Find product by name
void FindProductByName()
{
    Console.Write("Search: ");
    string search = Console.ReadLine();

    var products = context.Products
        .Where(p => p.Name.Contains(search))
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine(
            $"{product.Id} | {product.Name} | {product.Price}"
        );
    }
}
//Show products by category
void ShowProductsByCategory()
{
    Console.Write("Category: ");
    string category = Console.ReadLine();

    var products = context.Products
        .Where(p => p.Category == category)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
//Show available products
void ShowAvailableProducts()
{
    Console.Write("Is Available: ");
    var products = context.Products
        .Where(p => p.IsAvailable)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
//Show expensive products
void ShowExpensiveProducts()
{
    Console.Write("Enter minimum price: ");
    decimal minPrice = decimal.Parse(Console.ReadLine());

    var products = context.Products
        .Where(p => p.Price > minPrice)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Price}");
    }
}
//Sort products by price(.OrderBy(),.OrderByDescending())
void SortProductsAscending()
{
    var products = context.Products
        .OrderBy(p => p.Price)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
void SortProductsDescending()
{
    var products = context.Products
        .OrderByDescending(p => p.Price)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
//Show total products
void ShowTotalProducts()
{
    int totalProducts = context.Products.Count();

    Console.WriteLine($"Total products: {totalProducts}");
}
//Show total inventory value
void ShowTotalInventoryValue()
{
    decimal totalValue = context.Products
        .Sum(p => p.Price * p.Quantity);

    Console.WriteLine($"Total inventory value: {totalValue}");
}
//The most expensive product
void ShowTheMostExpensiveProduct()
{
    var product = context.Products
        .OrderByDescending(p => p.Price)
        .FirstOrDefault();
    Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
}
//The most cheap product
void ShowTheMostCheapProduct()
{
    var product = context.Products
        .OrderBy(p => p.Price)
        .FirstOrDefault();
    Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
}
//14.Average proice
void ShowAveragePrice()
{
    decimal averagePrice = context.Products
        .Average(p => p.Price);

    Console.WriteLine($"Average price: {averagePrice}");
}
//Out of stock products
void ShowOutOfStockProducts()
{
    var products = context.Products
        .Where(p => p.Quantity == 0)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
//Top - 3 most expensive products
void ShowTop3MostExpensiveProducts()
{
    var products = context.Products
        .OrderByDescending(p => p.Price)
        .Take(3)
        .ToList();

    foreach (var product in products)
    {
        Console.WriteLine($"{product.Id} | {product.Name} | {product.Category} | {product.Price}");
    }
}
