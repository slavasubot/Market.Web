using Market.Domain.Entities;
using Market.Services.Purchases;
using System.Web.Http;


namespace Market.Web.Api.Controllers
{
    public class PurchaseController : ApiController
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        public IHttpActionResult Get()
        {
            return Ok(_purchaseService.Get());
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_purchaseService.Get(id));
        }

        public IHttpActionResult Post(Purchase purchase)
        {
            return Ok(_purchaseService.Create(purchase));
        }

        public IHttpActionResult Put(Purchase purchase)
        {
            return Ok(_purchaseService.Update(purchase));
        }

        public IHttpActionResult Delete(int id)
        {
            _purchaseService.Delete(id);
            return Ok();
        }
    }
}
