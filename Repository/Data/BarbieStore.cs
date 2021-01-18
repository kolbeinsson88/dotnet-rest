using System;
using System.Collections.Generic;
using AuctionBarbie.WebApi.Models;

namespace AuctionBarbie.WebApi.Repository.Data {
    public static class BarbieStore {
        public static List<Barbie> Barbies = new List<Barbie> () {
            new Barbie() {
                Id = 1,
                FirstName = "Lisa",
                LastName = "Jackson",
                BarbieAlias = "Sweet69",
                Created = DateTime.Now,
                CreatedBy = "Anonymous"                
            },
            new Barbie() {
                Id = 2,
                FirstName = "Nancy",
                LastName = "Simons",
                BarbieAlias = "FullyInjectable",
                Created = DateTime.Now,
                CreatedBy = "Anonymous"                
            },
            new Barbie() {
                Id = 3,
                FirstName = "Clair",
                LastName = "Simons",
                BarbieAlias = "Piglet",
                Created = DateTime.Now,
                CreatedBy = "Anonymous"                
            },
            new Barbie() {
                Id = 4,
                FirstName = "Joan",
                LastName = "Divian",
                BarbieAlias = "BlackMamba",
                Created = DateTime.Now,
                CreatedBy = "Anonymous"                
            },
            new Barbie() {
                Id = 5,
                FirstName = "Robin",
                LastName = "Donagan",
                BarbieAlias = "Black thunder",
                Created = DateTime.Now,
                CreatedBy = "Anonymous"                
            }
        };
    }
}

