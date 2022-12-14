using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Shared
{
    public class Address
    {
        public int Id { get; set; }
        public string? HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? Town { get; set; }
        public int? ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
