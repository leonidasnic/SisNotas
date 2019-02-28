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
      DataTable dt;
        SqlDataAdapter adaptador;
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
                        adaptador = new SqlDataAdapter(cmd);
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
                adaptador = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adaptador.Fill(dt);
                comboBox.DataSource = dt;
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
        public DataTable insert_Alumno ( out int CodAlumno,string Primernombre,  string Segundonombre,  string PrimerApellido,
             string SegundoApellido,  string Especialidad,  string Fecha_nac,  string Direccion, out int CodResponsable, string Fecha_entrada,  string Nombre_R,
             string Telefono_r,  string Ocupacion)
        {
            using (connection = new SqlConnection(conexcionString))
            {
                connection.Open();
                cmd = new SqlCommand("InsertarAlumno", connection);
                cmd.Parameters.AddWithValue("@PrimerNombre", Primernombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", Segundonombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                cmd.Parameters.AddWithValue("@especialidad", Especialidad);
                cmd.Parameters.AddWithValue("@FechaNac", Fecha_nac);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Fecha_entrada", Fecha_entrada);
                cmd.Parameters.AddWithValue("@Nombre_R", Nombre_R);
                cmd.Parameters.AddWithValue("@Telefono_R", Telefono_r);
                cmd.Parameters.AddWithValue("@Ocupacion", Ocupacion);
                cmd.Parameters.Add("@CodAlumno", SqlDbType.Int);
                cmd.Parameters["@CodAlumno"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CodResponsable", SqlDbType.Int).Direction = ParameterDirection.Output;
                adaptador = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adaptador.Fill(dt);
                CodAlumno = Convert.ToInt32(cmd.Parameters["@CodAlumno"].Value);
                CodResponsable = Convert.ToInt32(cmd.Parameters["@CodResponsable"].Value);
                return (dt);
                connection.Close();
            }
            
        }
        
    }
}
