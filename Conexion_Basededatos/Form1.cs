using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_Basededatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min = 70, max = 135;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(panleft.Width ==max && pblogo.Width==max)
                {
                leftresize(min);
            }
            else
            {
                leftresize(max);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openinpanel(new frmPresentacion());
        }

        

        private void pbNotas_Click(object sender, EventArgs e)
        {

        }

        private void pbMateria_Click(object sender, EventArgs e)
        {
            
        }
        
        private void pbEstudiante_Click(object sender, EventArgs e)
        {
            openinpanel(new frmEstudiantes());
        }
        //metodo openinpanel
        #region
        /// <summary>
        ///     abre los formularios en el panel central  del sistema
        /// </summary>
        /// <param name="formulario" > 
        /// </param>
        private void openinpanel (Form formulario)
        {
            if (this.pncontainer.Controls.Count > 0)
                this.pncontainer.Controls.RemoveAt(0);
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.pncontainer.Controls.Add(formulario);
            this.pncontainer.Tag = formulario;
            formulario.Show();
        }
        #endregion
        private void pblogo_Click(object sender, EventArgs e)
        {
            openinpanel(new frmPresentacion());
        }

        private void leftresize (int n1)
        {
            panleft.Width = n1;
            pblogo.Width = n1;
            pbEstudiante.Width = n1;
            //gpbEstudiante.Width = n1;
            pbMateria.Width = n1;
            //gpbMateria.Width = n1;
            pbNotas.Width = n1;
           // gpbNotas.Width = n1;
        }
    }
}
