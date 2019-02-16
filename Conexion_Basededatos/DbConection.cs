using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Conexion_Basededatos
{
    class DbConection
    {
        public static SqlConnection conexion;
        public DataTable dt;
        public SqlCommand cmd;
        public string cadenaconexion = "Data Source=DESKTOP-M3MJNT8;" + "Initial Catalog=Notas_Prueva;" + "Integrated Security=SSPI;";
        public string NombreProc;
    }
}
