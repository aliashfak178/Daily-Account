using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class DBCofiguration
    {
       // private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["Daily_Account"].ConnectionString;
            }
        }
    }
}
