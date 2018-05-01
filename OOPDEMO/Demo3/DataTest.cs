using OOPDEMO.Model;
using OOPDEMO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPDEMO.Demo3
{
    public class DataTest
    {
        AddressService _addressService = new AddressService();

        public void TestReadAll()
        {
            List<Address> list = _addressService.ReadAll();
            foreach(Address adr in list)
            {
                Console.WriteLine($"{adr.StreetAddress} {adr.City} {adr.StateProvinceId} {adr.PostalCode}");
            }
        }
        public void TestReadOne()
        {
            Address adr = _addressService.ReadById(12);
            Console.WriteLine($"{adr.StreetAddress} {adr.City} {adr.StateProvinceId} {adr.PostalCode}");
        }
    }
}
