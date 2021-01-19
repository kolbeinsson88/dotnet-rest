using System;
using AuctionBarbie.WebApi.Hypermedia;

namespace AuctionBarbie.WebApi.Models 
{
    public class Barbie : HyperMedia
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BarbieAlias { get; set; }

        // Metadata
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string CreatedBy { get; set; }
    }
}





