using System.Dynamic;

namespace AuctionBarbie.WebApi.Hypermedia 
{
    public class HyperMedia 
    {
        public HyperMedia()
        {
            _links = new ExpandoObject();
        }

        /*
            Should be able to modify object during run time using ExtendoObject. 
            Essentially you are creating dynamic objects that can take in any kind 
            of variables running at runtime, this can be objects, strings, arrays 
            or some other random variable. Works much like var keyword in Javascript. 
        */
        public ExpandoObject _links { get; set; }
        
    }
};