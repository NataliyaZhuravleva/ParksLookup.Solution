using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {

    }
    public DbSet<Park> Parks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, ParkName = "Mount Rainier", ParkType = "National", ParkAddress = "55210 238th Avenue East Ashford, WA 98304", ParkPetsAllowed = false, ParkStore = true },
              new Park { ParkId = 2, ParkName = "Olympic", ParkType = "National", ParkAddress = "3002 Mount Angeles Road Port Angeles , WA 98362", ParkPetsAllowed = true, ParkStore = true },
              new Park { ParkId = 3, ParkName = "North Cascades", ParkType = "National", ParkAddress = "810 State Route 20 Sedro-Woolley, WA 98284", ParkPetsAllowed = true, ParkStore = true },
              new Park { ParkId = 4, ParkName = "Lake Wenatchee", ParkType = "State", ParkAddress = "21588 State Route 207 Leavenworth, WA 98826", ParkPetsAllowed = true, ParkStore = true },
              new Park { ParkId = 5, ParkName = "Lake Sammamish", ParkType = "State", ParkAddress = "2000 N.W. Sammamish Road Issaqua, WA 98027", ParkPetsAllowed = false, ParkStore = false }
          );
    }
  }
}