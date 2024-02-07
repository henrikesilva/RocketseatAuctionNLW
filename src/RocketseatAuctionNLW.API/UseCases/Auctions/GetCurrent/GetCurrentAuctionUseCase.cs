using RocketseatAuctionNLW.API.Contracts;
using RocketseatAuctionNLW.API.Entities;

namespace RocketseatAuctionNLW.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _auctionRepository;
    public GetCurrentAuctionUseCase(IAuctionRepository auctionRepository) => _auctionRepository = auctionRepository;

    public Auction? Execute()
    {
        return _auctionRepository.GetCurrent();
    }
}
