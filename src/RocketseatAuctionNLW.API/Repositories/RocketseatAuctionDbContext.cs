using Microsoft.EntityFrameworkCore;
using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=D:\Projetos\Desenvolvimento\rocket\RocketseatAuctionNLW\leilaoDbNLW.db");
        //optionsBuilder.UseSqlite(@"Data Source=C:\Users\rique\Documents\Temp\Desenvolvimento\rocket\NLW-Expert\RocketseatAuctionNLW\leilaoDbNLW.db");
    }
}
