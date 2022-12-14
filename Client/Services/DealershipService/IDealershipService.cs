namespace CarDealership.Client.Services.DealershipService
{
    public interface IDealershipService
    {
        List<Customer> Customers { get; set; }
        Task GetAllCustomers();
        Task<List<Customer>> GetAllCustomersWithSpecificName(string name);
        Task<Customer> GetFirstCustomer();

        Task<List<SalesPerson>> GetAllSalesPersons();

        Task<List<Customer>> GetAllCustomersByStreet(string street);

        Task<List<Address>> GetAllAddresses();
    }
}
