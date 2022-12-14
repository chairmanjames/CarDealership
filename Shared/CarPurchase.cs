using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Shared
{
    public class CarPurchase
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal PricePaid { get; set; }
        public int salesPersonId { get; set; }
    }
}
