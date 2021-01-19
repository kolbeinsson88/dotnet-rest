using System.Collections.Generic;
using AuctionBarbie.WebApi.InputModels;
using AuctionBarbie.WebApi.Models;
using AuctionBarbie.WebApi.Repository;

namespace AuctionBarbie.WebApi.Services {
    public class BarbieService {

        private BarbieRepository _barbieRepository;
        public BarbieService(BarbieRepository barbieRepository)
        {
            _barbieRepository = barbieRepository;
        }
        public List<Barbie> FetchAllBarbies() 
        {
            var barbies = _barbieRepository.GetAllBarbies();
            barbies.ForEach(b => b._links.TryAdd("self", $"https://localhost:5001/api/barbies/{b.Id}" ));

            return barbies;
        }
        public Barbie FetchBarbieById(int id) => _barbieRepository.GetById(id);
        public Barbie DeleteBarbie(int id) => _barbieRepository.DeleteBarbie(id);
        public void PostBarbie(BarbieInputModel barbieInputModel) => _barbieRepository.PostBarbie(barbieInputModel);
        public Barbie PutBarbie(BarbieInputModel barbieInputModel, int id) => _barbieRepository.UpdateBarbie(barbieInputModel, id); 
    }
}