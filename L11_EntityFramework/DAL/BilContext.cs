using L11_EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace L11_EntityFramework.DAL;

public class BilContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var server = "localhost,1433";
        var database = "master";
        var user = "SA";
        var password = "Ph!l!p1234";
        var connectionString = $"Server={server};Database={database};User Id={user};" +
                               $"Password={password};Encrypt=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Bil> Biler { get; set; }
}