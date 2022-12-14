namespace CarDealership.Server.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "James" },
                new Customer { Id = 2, Name = "Børge" }
            );
          modelBuilder.Entity<Car>();
            modelBuilder.Entity<SalesPerson>().HasData(
                new SalesPerson { Id = 1, Name = "James", JobTitle = "Manager" },
                new SalesPerson { Id = 2, Name = "Børge", JobTitle = "Business Manager" }
            );
           modelBuilder.Entity<Address>();
           modelBuilder.Entity<CarPurchase>();
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<SalesPerson> SalesPerson { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarPurchase> CarPurchase { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
