using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_Basededatos
{
    class Alumnos : DbConection
    {
        Configuration configuration;
        DataTable dt;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proc"> procedimiento </param>
        /// <param name="texto"> texto a buscar </param>
        /// <returns></returns>
        public DataTable get_Alumno(string proc, string texto)
        {
               //  rellenar el dgvbuscar
               using(connection = new SqlConnection(conexcionString))
                #region
                    try
                    {
                        connection.Open();
                        cmd = new SqlCommand(proc, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", texto);
                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adaptador.Fill(dt);
                        ////// dgvBuscar.Columns[0].Visible = false;
                    }
                    catch (System.ArgumentException ex)
                    {
                    throw new System.ArgumentException(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return (dt);
                
            #endregion
        }
        public List
    }
}
