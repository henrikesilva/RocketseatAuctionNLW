using Microsoft.EntityFrameworkCore;
using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\rique\Documents\Temp\Desenvolvimento\rocket\NLW-Expert\RocketseatAuctionNLW\leilaoDbNLW.db");
    }
}
