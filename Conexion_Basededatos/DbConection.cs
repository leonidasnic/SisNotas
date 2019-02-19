using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;

namespace Conexion_Basededatos
{
   public  class DbConection
    {
        public static string  conexcionString = "Data Source=DESKTOP-M3MJNT8;Initial Catalog=Notas_Prueva;Integrated Security=SSPI;";
        public static SqlCommand cmd;
        public static SqlConnection connection;
    }
}
