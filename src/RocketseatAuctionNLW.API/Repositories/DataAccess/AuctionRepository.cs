﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuctionNLW.API.Contracts;
using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
