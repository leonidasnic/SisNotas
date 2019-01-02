namespace Conexion_Basededatos
{
    partial class frmEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbEstudiante = new System.Windows.Forms.Button();
            this.pnbuscar = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbResponsable = new System.Windows.Forms.RadioButton();
            this.rdbAlumnos = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pncontainer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Responsable = new System.Windows.Forms.GroupBox();
            this.txtResCodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResOcupacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResTelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnbuscar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.pncontainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Responsable.SuspendLayout();
            this.gbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pbEstudiante);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 37);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(823, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbEstudiante
            // 
            this.pbEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pbEstudiante.FlatAppearance.BorderSize = 0;
            this.pbEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbEstudiante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbEstudiante.Image = global::Conexion_Basededatos.Properties.Resources.clipboard_with_pencil_1;
            this.pbEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pbEstudiante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbEstudiante.Name = "pbEstudiante";
            this.pbEstudiante.Size = new System.Drawing.Size(80, 37);
            this.pbEstudiante.TabIndex = 9;
            this.pbEstudiante.Text = "Estudiantes";
            this.pbEstudiante.UseVisualStyleBackColor = false;
            // 
            // pnbuscar
            // 
            this.pnbuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnbuscar.Controls.Add(this.groupBox3);
            this.pnbuscar.Controls.Add(this.btnbuscar);
            this.pnbuscar.Controls.Add(this.dgvBuscar);
            this.pnbuscar.Controls.Add(this.txtBuscar);
            this.pnbuscar.Controls.Add(this.label5);
            this.pnbuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnbuscar.Location = new System.Drawing.Point(0, 37);
            this.pnbuscar.Name = "pnbuscar";
            this.pnbuscar.Size = new System.Drawing.Size(346, 566);
            this.pnbuscar.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbResponsable);
            this.groupBox3.Controls.Add(this.rdbAlumnos);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(163, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 80);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Busqueda";
            // 
            // rdbResponsable
            // 
            this.rdbResponsable.AutoSize = true;
            this.rdbResponsable.Location = new System.Drawing.Point(22, 47);
            this.rdbResponsable.Name = "rdbResponsable";
            this.rdbResponsable.Size = new System.Drawing.Size(115, 20);
            this.rdbResponsable.TabIndex = 1;
            this.rdbResponsable.Text = "Responsables";
            this.rdbResponsable.UseVisualStyleBackColor = true;
            // 
            // rdbAlumnos
            // 
            this.rdbAlumnos.AutoSize = true;
            this.rdbAlumnos.Checked = true;
            this.rdbAlumnos.Location = new System.Drawing.Point(22, 21);
            this.rdbAlumnos.Name = "rdbAlumnos";
            this.rdbAlumnos.Size = new System.Drawing.Size(78, 20);
            this.rdbAlumnos.TabIndex = 0;
            this.rdbAlumnos.TabStop = true;
            this.rdbAlumnos.Text = "Alumnos";
            this.rdbAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = global::Conexion_Basededatos.Properties.Resources.search__1_;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.Location = new System.Drawing.Point(12, 68);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(145, 80);
            this.btnbuscar.TabIndex = 37;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToAddRows = false;
            this.dgvBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBuscar.Location = new System.Drawing.Point(0, 164);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(346, 402);
            this.dgvBuscar.TabIndex = 36;
            this.dgvBuscar.SelectionChanged += new System.EventHandler(this.dgvBuscar_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(85, 24);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 17);
            this.txtBuscar.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Buscar";
            // 
            // pncontainer
            // 
            this.pncontainer.BackColor = System.Drawing.Color.White;
            this.pncontainer.Controls.Add(this.groupBox2);
            this.pncontainer.Controls.Add(this.Responsable);
            this.pncontainer.Controls.Add(this.gbDatosAlumno);
            this.pncontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncontainer.Location = new System.Drawing.Point(346, 37);
            this.pncontainer.Name = "pncontainer";
            this.pncontainer.Size = new System.Drawing.Size(512, 566);
            this.pncontainer.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 131);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Image = global::Conexion_Basededatos.Properties.Resources.save;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(336, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 89);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Image = global::Conexion_Basededatos.Properties.Resources.pencil;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(82, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 89);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = global::Conexion_Basededatos.Properties.Resources.new_user;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(209, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Responsable
            // 
            this.Responsable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Responsable.Controls.Add(this.txtResCodigo);
            this.Responsable.Controls.Add(this.label14);
            this.Responsable.Controls.Add(this.txtResOcupacion);
            this.Responsable.Controls.Add(this.label13);
            this.Responsable.Controls.Add(this.txtResTelefono);
            this.Responsable.Controls.Add(this.label12);
            this.Responsable.Controls.Add(this.txtResNombre);
            this.Responsable.Controls.Add(this.label11);
            this.Responsable.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsable.Location = new System.Drawing.Point(2, 278);
            this.Responsable.Name = "Responsable";
            this.Responsable.Size = new System.Drawing.Size(507, 131);
            this.Responsable.TabIndex = 1;
            this.Responsable.TabStop = false;
            this.Responsable.Text = "Responsable";
            // 
            // txtResCodigo
            // 
            this.txtResCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtResCodigo.Enabled = false;
            this.txtResCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResCodigo.Location = new System.Drawing.Point(129, 16);
            this.txtResCodigo.Name = "txtResCodigo";
            this.txtResCodigo.ReadOnly = true;
            this.txtResCodigo.Size = new System.Drawing.Size(75, 22);
            this.txtResCodigo.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Codigo";
            // 
            // txtResOcupacion
            // 
            this.txtResOcupacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtResOcupacion.Enabled = false;
            this.txtResOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResOcupacion.Location = new System.Drawing.Point(129, 99);
            this.txtResOcupacion.Name = "txtResOcupacion";
            this.txtResOcupacion.Size = new System.Drawing.Size(120, 22);
            this.txtResOcupacion.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ocupacion";
            // 
            // txtResTelefono
            // 
            this.txtResTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtResTelefono.Enabled = false;
            this.txtResTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResTelefono.Location = new System.Drawing.Point(129, 70);
            this.txtResTelefono.Name = "txtResTelefono";
            this.txtResTelefono.Size = new System.Drawing.Size(120, 22);
            this.txtResTelefono.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefono";
            // 
            // txtResNombre
            // 
            this.txtResNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtResNombre.Enabled = false;
            this.txtResNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResNombre.Location = new System.Drawing.Point(128, 44);
            this.txtResNombre.Name = "txtResNombre";
            this.txtResNombre.Size = new System.Drawing.Size(376, 22);
            this.txtResNombre.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Primer Nombre";
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDatosAlumno.Controls.Add(this.txtCodigo);
            this.gbDatosAlumno.Controls.Add(this.txtEspecialidad);
            this.gbDatosAlumno.Controls.Add(this.label8);
            this.gbDatosAlumno.Controls.Add(this.txtDireccion);
            this.gbDatosAlumno.Controls.Add(this.label10);
            this.gbDatosAlumno.Controls.Add(this.cbGrado);
            this.gbDatosAlumno.Controls.Add(this.label9);
            this.gbDatosAlumno.Controls.Add(this.label7);
            this.gbDatosAlumno.Controls.Add(this.dtpFechaNac);
            this.gbDatosAlumno.Controls.Add(this.label6);
            this.gbDatosAlumno.Controls.Add(this.txtSegundoApellido);
            this.gbDatosAlumno.Controls.Add(this.label4);
            this.gbDatosAlumno.Controls.Add(this.txtPrimerApellido);
            this.gbDatosAlumno.Controls.Add(this.label3);
            this.gbDatosAlumno.Controls.Add(this.txtSegundoNombre);
            this.gbDatosAlumno.Controls.Add(this.label2);
            this.gbDatosAlumno.Controls.Add(this.txtPrimerNombre);
            this.gbDatosAlumno.Controls.Add(this.label1);
            this.gbDatosAlumno.Location = new System.Drawing.Point(3, 7);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Size = new System.Drawing.Size(509, 255);
            this.gbDatosAlumno.TabIndex = 0;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Datos alumno";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(124, 175);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(120, 22);
            this.txtEspecialidad.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Especialidad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(124, 203);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(313, 46);
            this.txtDireccion.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Direccion";
            // 
            // cbGrado
            // 
            this.cbGrado.Enabled = false;
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(406, 145);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(73, 23);
            this.cbGrado.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Grado ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Codigo:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Enabled = false;
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(145, 145);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNac.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(382, 101);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(120, 22);
            this.txtSegundoApellido.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(124, 101);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(120, 22);
            this.txtPrimerApellido.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Primer Apellido";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(381, 61);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(120, 22);
            this.txtSegundoNombre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Segundo Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(124, 61);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(120, 22);
            this.txtPrimerNombre.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Primer Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(68, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 32;
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(858, 603);
            this.Controls.Add(this.pncontainer);
            this.Controls.Add(this.pnbuscar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstudiantes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnbuscar.ResumeLayout(false);
            this.pnbuscar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.pncontainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Responsable.ResumeLayout(false);
            this.Responsable.PerformLayout();
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pbEstudiante;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnbuscar;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pncontainer;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Responsable;
        private System.Windows.Forms.TextBox txtResOcupacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtResNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResCodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbResponsable;
        private System.Windows.Forms.RadioButton rdbAlumnos;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}