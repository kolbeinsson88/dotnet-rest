using System;
using System.Collections.Generic;
using System.Linq;
using AuctionBarbie.WebApi.InputModels;
using AuctionBarbie.WebApi.Models;
using AuctionBarbie.WebApi.Repository.Data;


namespace AuctionBarbie.WebApi.Repository 
{
    public class BarbieRepository 
    {
  

        public BarbieRepository()
        {
        }
        public List<Barbie> GetAllBarbies() => BarbieStore.Barbies.ToList();
        public void PostBarbie(BarbieInputModel barbieModel) 
        {
            var id = BarbieStore.Barbies.Count() - 1;
            var barbie = new Barbie() {
                Id = BarbieStore.Barbies.ElementAt(id).Id + 1,
                FirstName = barbieModel.FirstName,
                LastName = barbieModel.LastName,
                BarbieAlias = barbieModel.BarbieAlias
            };
            BarbieStore.Barbies.Add(barbie);
        }
        public Barbie GetById(int id) 
        {
            var barbie = BarbieStore.Barbies.Where(b => b.Id == id).SingleOrDefault();

            return barbie == null ? null : barbie; 
        }
        public Barbie UpdateBarbie(BarbieInputModel barbieModel, int id) 
        {

            var response = BarbieStore.Barbies.SingleOrDefault(wb => wb.Id == id);
            response.FirstName = barbieModel.FirstName;
            response.LastName = barbieModel.LastName;
            response.BarbieAlias = barbieModel.BarbieAlias;
            response.Updated = DateTime.Now;

            return response;
        }
        public Barbie DeleteBarbie(int id)
        {
            var model = GetById(id);
            if (model == null) { return model; };

            BarbieStore.Barbies.Remove(model);
            
            return model;
        }
    }
}