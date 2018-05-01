using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbAccess1.DbAdapter;

namespace OOPDEMO.Services
{
    public class BaseService
    {
        public DbAdapter Adapter
        {
            get
            {
                return new DbAdapter(new SqlCommand(),
                    new SqlConnection("Server = 13.64.246.7;Database=C51_Prospects;User Id=C51_User;Password=Sabiopass51!"));
            }
        }
    }
}
