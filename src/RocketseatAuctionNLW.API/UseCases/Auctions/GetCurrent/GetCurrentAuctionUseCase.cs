using Microsoft.EntityFrameworkCore;
using RocketseatAuctionNLW.API.Entities;
using RocketseatAuctionNLW.API.Repositories;

namespace RocketseatAuctionNLW.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();
        
        var today = DateTime.UtcNow;

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
