using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Model
{
    public class Address
    {
        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public string StreetAddress { get; set; }
        public string City{ get; set; }
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
    }
}
