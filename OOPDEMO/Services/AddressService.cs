using DbAccess1.Tools;
using OOPDEMO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDEMO.Services
{
    public class AddressService : BaseService
    {
        public List<Address> ReadAll()
        {
            return Adapter.LoadObject<Address>(
                "Address_Address_SelectAll");
        }

        public Address ReadById(int id)
        {
            return Adapter.LoadObject<Address>(
               "Address_Address_SelectById",
               new[] { SqlDbParameter.Instance.BuildParameter("@id", id, System.Data.SqlDbType.Int) }
               ).FirstOrDefault();

        }
    }
}
