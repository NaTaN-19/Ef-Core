public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}



// #in SQL Server
// CREATE DATABASE OnlineStore
