using AuctionBarbie.WebApi.InputModels;
using AuctionBarbie.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuctionBarbie.WebApi.Controller
{
    [ApiController]
    [Route("api/barbie/")]
    public class BarbieController : ControllerBase 
    {
        private BarbieService _barbieService;
        public BarbieController(BarbieService barbieService)
        {
            _barbieService = barbieService;
        }

        /*
            Return all data with status code 200
        */
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult FetchBarbies()
        {
            return StatusCode(200, _barbieService.FetchAllBarbies());
        }

      /*
            Successful GET /:id will return 200, unsuccessful will return 404(not found) or an exception
        */

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult FetchBarbieById (int id)
        {
            var barbie = _barbieService.FetchBarbieById(id);

            if (barbie == null) { return StatusCode(404); };

            return StatusCode(200, barbie);
        }

        /*
            Successful POST will return either 201 or 204(no content). Better to return no content since it
            is a smaller response.
        */

        [HttpPost]
        [Route("")]
        [ProducesResponseType(204)]
        public ActionResult PostBarbie(BarbieInputModel barbieInputModel)
        {
            _barbieService.PostBarbie(barbieInputModel);

            return StatusCode(204);
        }

        /*
            When working with success response for DELETE/PUT /:id you are allowed to return either 
            200 or 204(no content), unsuccessful will be an exception or 404(not found). It is better 
            to return 204 instead of 200 since that is no content and smaller response. 
        */

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]

        public ActionResult DeleteBarbie(int id)
        {
            var barbie = _barbieService.DeleteBarbie(id);

            if (barbie == null) { return StatusCode(404); };

            return StatusCode(204);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public ActionResult PutBarbie(BarbieInputModel barbieInputModel, int id)
        {
            var barbie = _barbieService.PutBarbie(barbieInputModel, id);
            
            if(barbie == null) { return StatusCode(404); };

            return StatusCode(204);
        }        
    }
}