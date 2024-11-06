using Microsoft.EntityFrameworkCore;
using PetStoreApi.Entities;

namespace PetStoreApi;

public class PetStoreDbContext : DbContext
{
    public string DbPath { get; set; }
    
    public DbSet<Animal> Animals {get; set;}
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    private readonly IConfiguration _config;

    public PetStoreDbContext(IConfiguration config)
    {
        _config = config;
        DbPath = Path.Join(
            _config.GetConnectionString("DataBaseFolder"), 
            _config.GetConnectionString("DataBaseFile"));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source={DbPath}");

}
