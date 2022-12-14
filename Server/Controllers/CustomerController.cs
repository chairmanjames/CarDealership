using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Shared;
using CarDealership.Client.Services.DealershipService;

namespace CarDealership.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }
        [Route("GetAllCustomers")]
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var customers = await _context.Customer.ToListAsync();
            //Insert manager to do db logic
            return Ok(customers);
        }

        [Route("GetCustomersByName/{name}")]
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomersWithSpecificName(string name)
        {
            var customers = await _context.Customer.ToListAsync();
            var specificNameList = customers.FindAll(x => x.Name == name);
            //Insert manager to do db logic
            return Ok(specificNameList);
        }

        
        [Route("GetAllAdresses")]
        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAllAdresses()
        {
            var addresses = await _context.Address.ToListAsync();
            
            //Insert manager to do db logic
            return Ok(addresses);
        }
    }
}
