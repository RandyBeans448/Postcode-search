using Microsoft.EntityFrameworkCore;

  public class DatabaseContext : DbContext
  {
    public DbSet<DeliveryOption> DeliveryOptions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=database.db");
    }
}