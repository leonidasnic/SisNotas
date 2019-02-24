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
        List<string> grados;
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
        public void Load_grado( ComboBox comboBox)
        {
           
            using (connection = new SqlConnection(conexcionString))
            {
                cmd = new SqlCommand("LoadGrado", connection);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dataTable;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = "Grado";
                comboBox.ValueMember = "Grado";
                /*
                comboBox.DataSource = (BindingSource)dataTable;
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader[0].ToString());
                        }*/
            }
         
            
        }
        
    }
}
