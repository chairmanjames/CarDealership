using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Shared
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? JobTitle { get; set; }
        public int AddressId { get; set; }
        //public decimal? Salaray { get; set; }

    }
}
