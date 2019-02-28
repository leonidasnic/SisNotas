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

       
        public DataTable dt;
        public string NombreProc;
        Alumnos alumnos;
        
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            alumnos = new Alumnos();
            dgvBuscar.DataSource= alumnos.get_Alumno("buscar_alumno", txtBuscar.Text);
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
        #region
        /* private void button4_Click(object sender, EventArgs e)
         {
             dgvBuscar.DataSource = null;
         }*/
        #endregion



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
        #region
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtPrimerNombre.Enabled == true && txtResNombre.Enabled == true)
            { 

            }
            else
            {
              
            }
        }
        #endregion
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
            dtpFechaEntrada.Enabled = enable;
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
            #region
            
                LimpiarGB(gbDatosAlumno);
                LimpiarGB(gbResponsable);
              
                txtCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtPrimerNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtSegundoNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtPrimerApellido.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtSegundoApellido.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtEspecialidad.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[5].Value.ToString();
                dtpFechaNac.Value = DateTime.Parse(dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[6].Value.ToString());
                txtDireccion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[7].Value.ToString();
                txtResCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[8].Value.ToString();
                dtpFechaEntrada.Value = DateTime.Parse(dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[9].Value.ToString());
                txtResNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[11].Value.ToString();
                txtResTelefono.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[12].Value.ToString();
                txtResOcupacion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[13].Value.ToString();
                


            #endregion

            //else
            //{

            //    #region

            //    txtResCodigo.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //    txtResNombre.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //    txtResTelefono.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //    txtResOcupacion.Text = dgvBuscar.Rows[dgvBuscar.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //    #endregion
            //}

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

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            

        }
    }


}

