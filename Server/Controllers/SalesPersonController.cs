using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Shared;
using CarDealership.Client.Services.DealershipService;

namespace CarDealership.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesPersonController : ControllerBase
    {
        private readonly DataContext _context;

        public SalesPersonController(DataContext context)
        {
            _context = context;
        }

        [Route("GetAllSalesPersons")]
        [HttpGet]
        public async Task<ActionResult<List<SalesPerson>>> GetAllSalesPersons()
        {
            var salesPersons = await _context.SalesPerson.ToListAsync();
            //Insert manager to do db logic
            return Ok(salesPersons);
        }

    }
}
