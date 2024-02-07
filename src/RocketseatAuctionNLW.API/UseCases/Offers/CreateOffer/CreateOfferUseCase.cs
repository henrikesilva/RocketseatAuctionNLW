using RocketseatAuctionNLW.API.Communication.Requests;
using RocketseatAuctionNLW.API.Contracts;
using RocketseatAuctionNLW.API.Entities;
using RocketseatAuctionNLW.API.Services;

namespace RocketseatAuctionNLW.API.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    private readonly IOfferRepository _repository;
    public CreateOfferUseCase(LoggedUser loggedUser, IOfferRepository repository)
    { 
        _loggedUser = loggedUser;
        _repository = repository;
    }

    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        _repository.Add(offer);

        return offer.Id;
    }
}
