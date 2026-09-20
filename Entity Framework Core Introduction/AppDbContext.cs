public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=****;Database=OnlineStore;Trusted_Connection=True;TrustServerCertificate=True;")
        );
    }
}

//in SQL Server
//CREATE DATABASE OnlineStore
//Tools → NuGet Package Manager → Package Manager Console
//Add-Migration InitialCreate
//Update-Database
