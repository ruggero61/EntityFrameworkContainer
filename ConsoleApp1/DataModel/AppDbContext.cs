using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.DataModel;

public class AppDbContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(GlobalVars.ConnectionToDataBase);
  }
  public DbSet<Author> Authors { get; set; } = default!;
  public DbSet<Book> Books { get; set; } = default!;
}
