using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina_tio_bill_CSharp
{
    internal class Conn
    {
        private static string server = "ASUS-JL";
        private static string dataBase = "cantina_tio_bill_backup";
        private static string user = "sa";
        private static string password = "root";

        public static string StrCon
        { 
            get { return $"Data Source={server}; Integrated Security=false; Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }
    }
}
