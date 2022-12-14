using CarDealership.Shared;
using System.Net.Http.Json;

namespace CarDealership.Client.Services.DealershipService
{
    public class DealershipService : IDealershipService
    {
        private readonly HttpClient _http;
        public DealershipService(HttpClient http)
        {
            _http = http;
        }
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public async Task GetAllCustomers()
        {
            var result = await _http.GetFromJsonAsync<List<Customer>>("api/Customer/GetAllCustomers");
            if (result != null)
            {
                Customers = result;
            }
        }

        public async Task<List<Customer>> GetAllCustomersWithSpecificName(string name)
        {
            var result = await _http.GetFromJsonAsync<List<Customer>>($"api/Customer/GetCustomersByName/{name}");
            if (result != null)
            {
                return result;
                //Customers = result;
            }
            return new List<Customer>();
        }
        public async Task<Customer> GetFirstCustomer()
        {
            var result = await _http.GetFromJsonAsync<List<Customer>>($"api/Customer/GetAllCustomers");
            if (result != null)
            {
                return result.FirstOrDefault();
                //Customers = result;
            }
            return new Customer();
        }
        //public async Task<Customer> GetCustomerOnId()
        //{

        //}

        //public async Task<List<Customer>> GetAllCustomersByStreet(string street)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Customer>>("api/SalesPerson/GetAllSalesPersons");
        //    if (result != null)
        //    {
        //        return result;
        //    }
        //    return new List<SalesPerson>();
        //}

        public async Task<List<Address>> GetAllAddresses()
        {
            var result = await _http.GetFromJsonAsync<List<Address>>("api/Customer/GetAllAdresses");
            if (result != null)
            {
                return result;
            }
            return new List<Address>();
        }
        public async Task<List<Customer>> GetAllCustomersByStreet(string street)
        {
            var addresses = await _http.GetFromJsonAsync<List<Address>>("api/Customer/GetAllAdresses");
            var streets = addresses?.Where(a => a.Street == street).Select(a => a.Id).ToList();
            var customers = await _http.GetFromJsonAsync<List<Customer>>($"api/Customer/GetAllCustomers");

            return new List<Customer>();
        }

        public async Task<List<SalesPerson>> GetAllSalesPersons()
        {
            var result = await _http.GetFromJsonAsync<List<SalesPerson>>("api/SalesPerson/GetAllSalesPersons");
            if (result != null)
            {
                return result;
            }
            return new List<SalesPerson>();
        }
    }
}
