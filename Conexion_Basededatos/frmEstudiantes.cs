using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Conexion_Basededatos
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        public SqlConnection conexion;
        public DataTable dt;
        public SqlCommand cmd;
        public string cadenaconexion = "Data Source=DESKTOP-M3MJNT8;" + "Initial Catalog=Notas_Prueva;" + "Integrated Security=SSPI;";
        public string NombreProc;
        


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            //dgvBuscar.DataSource = dt;
            // dgvBuscar.Rows.Clear();

            using (conexion = new SqlConnection(cadenaconexion))
            {
                if (txtBuscar.Text != string.Empty)
                {
                   //  rellenar el dgvbuscar
                    #region
                    try
                    {
                        //codicion para los radiobutons
                        if (rdbAlumnos.Checked == true)
                        {
                            NombreProc = "buscar_alumno";
                        }
                        else
                        { 
                            NombreProc = "BuscarResponsable";
                        }

                        conexion.Open();
                        cmd = new SqlCommand(NombreProc, conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", txtBuscar.Text);
                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        adaptador.Fill(dt);
                        dgvBuscar.DataSource = dt;
                        ////// dgvBuscar.Columns[0].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("INGRESE TEXTO A BUSCAR");
                }
            }
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.AbrirEnTexbox(NombreProc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       /* private void button4_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = null;
        }*/
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPrimerNombre.Enabled==false && txtResNombre.Enabled ==false)
                this.Enable_edit(true);
            else
                this.Enable_edit(false);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(NombreProc=="BuscarResponsable")
            {
                using (conexion = new SqlConnection(cadenaconexion))
                {
                    try
                    { 
                    conexion.Open();
                    cmd = new SqlCommand("InsertarAlumno", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                    cmd.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                    cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                    cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                    cmd.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);
                    cmd.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@CodResponsable", txtResCodigo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado Exitosamente", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                this.Enable_edit(false);
            }
        }
        //metodos Enableedit  y AbrirEnTexbox
        #region
            

        /// <summary>
        /// Abilita los texbox y datetimepickers Para la edicion
        /// </summary>
        /// <param name="enable"> Ture para habilitar false para desabilitar</param>
        public void Enable_edit(Boolean enable)
        {


            txtPrimerNombre.Enabled = enable;
            txtSegundoNombre.Enabled = enable;
            txtPrimerApellido.Enabled = enable;
            txtSegundoApellido.Enabled = enable;
            dtpFechaNac.Enabled = enable;
            cbGrado.Enabled = enable;
            txtDireccion.Enabled = enable;
            txtResNombre.Enabled = enable;
            txtResTelefono.Enabled = enable;
            txtResOcupacion.Enabled = enable;
            txtEspecialidad.Enabled = enable;
        }

        /// <summary>
        /// metodo para rellenar los texbos segun busqueda
        /// </summary>
        /// <param name="TipoBusqueda"> si se busca a alumno o a un Responsable</param>
        public void AbrirEnTexbox (string TipoBusqueda)
        {
            if (TipoBusqueda == "buscar_alumno")
            {
            
                #region
                txtCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtPrimerNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtSegundoNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtPrimerApellido.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtSegundoApellido.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtEspecialidad.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[5].Value.ToString();
                dtpFechaNac.Value = DateTime.Parse(dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[6].Value.ToString());
                txtDireccion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[7].Value.ToString();
                txtResCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[8].Value.ToString();
                txtResNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[10].Value.ToString();
                txtResTelefono.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[11].Value.ToString();
                txtResOcupacion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[12].Value.ToString();
                #endregion
            }
            else
            {

                #region
                LimpiarGB(gbDatosAlumno);
                LimpiarGB(gbResponsable);
                txtResCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtResNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtResTelefono.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtResOcupacion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[3].Value.ToString();
                #endregion
            }

        }
        #endregion
        public  void LimpiarGB(Control controles)
        {
            foreach (Control c in controles.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if(c.HasChildren)
                {
                    LimpiarGB(c);
                }
            }
            
        }

     
    }


}

