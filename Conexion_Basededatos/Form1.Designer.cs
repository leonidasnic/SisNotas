namespace Conexion_Basededatos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panleft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pncontainer = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pblogo = new System.Windows.Forms.Button();
            this.pbNotas = new System.Windows.Forms.Button();
            this.pbMateria = new System.Windows.Forms.Button();
            this.pbEstudiante = new System.Windows.Forms.Button();
            this.panleft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panleft
            // 
            this.panleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panleft.Controls.Add(this.pblogo);
            this.panleft.Controls.Add(this.pbNotas);
            this.panleft.Controls.Add(this.pbMateria);
            this.panleft.Controls.Add(this.pbEstudiante);
            this.panleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panleft.Location = new System.Drawing.Point(0, 0);
            this.panleft.Name = "panleft";
            this.panleft.Size = new System.Drawing.Size(135, 637);
            this.panleft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de notas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 34);
            this.panel2.TabIndex = 1;
            // 
            // pncontainer
            // 
            this.pncontainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pncontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncontainer.Location = new System.Drawing.Point(135, 34);
            this.pncontainer.Name = "pncontainer";
            this.pncontainer.Size = new System.Drawing.Size(858, 603);
            this.pncontainer.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(822, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(781, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(740, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pblogo.FlatAppearance.BorderSize = 0;
            this.pblogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.pblogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pblogo.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pblogo.Image = global::Conexion_Basededatos.Properties.Resources.school1;
            this.pblogo.Location = new System.Drawing.Point(0, 0);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(135, 80);
            this.pblogo.TabIndex = 10;
            this.pblogo.UseVisualStyleBackColor = false;
            this.pblogo.Click += new System.EventHandler(this.pblogo_Click);
            // 
            // pbNotas
            // 
            this.pbNotas.BackColor = System.Drawing.Color.Transparent;
            this.pbNotas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pbNotas.FlatAppearance.BorderSize = 0;
            this.pbNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.pbNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbNotas.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbNotas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbNotas.Image = global::Conexion_Basededatos.Properties.Resources.books1;
            this.pbNotas.Location = new System.Drawing.Point(0, 229);
            this.pbNotas.Name = "pbNotas";
            this.pbNotas.Size = new System.Drawing.Size(135, 80);
            this.pbNotas.TabIndex = 9;
            this.pbNotas.Text = "Notas";
            this.pbNotas.UseVisualStyleBackColor = false;
            this.pbNotas.Click += new System.EventHandler(this.pbNotas_Click);
            // 
            // pbMateria
            // 
            this.pbMateria.BackColor = System.Drawing.Color.Transparent;
            this.pbMateria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pbMateria.FlatAppearance.BorderSize = 0;
            this.pbMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.pbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMateria.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbMateria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbMateria.Image = global::Conexion_Basededatos.Properties.Resources.books_stack_of_three1;
            this.pbMateria.Location = new System.Drawing.Point(0, 151);
            this.pbMateria.Name = "pbMateria";
            this.pbMateria.Size = new System.Drawing.Size(135, 80);
            this.pbMateria.TabIndex = 8;
            this.pbMateria.Text = "Materias";
            this.pbMateria.UseVisualStyleBackColor = false;
            this.pbMateria.Click += new System.EventHandler(this.pbMateria_Click);
            // 
            // pbEstudiante
            // 
            this.pbEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.pbEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pbEstudiante.FlatAppearance.BorderSize = 0;
            this.pbEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.pbEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbEstudiante.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbEstudiante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbEstudiante.Image = global::Conexion_Basededatos.Properties.Resources.clipboard_with_pencil_1;
            this.pbEstudiante.Location = new System.Drawing.Point(0, 73);
            this.pbEstudiante.Name = "pbEstudiante";
            this.pbEstudiante.Size = new System.Drawing.Size(135, 80);
            this.pbEstudiante.TabIndex = 7;
            this.pbEstudiante.Text = "Estudiantes";
            this.pbEstudiante.UseVisualStyleBackColor = false;
            this.pbEstudiante.Click += new System.EventHandler(this.pbEstudiante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 637);
            this.Controls.Add(this.pncontainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panleft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panleft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pncontainer;
        private System.Windows.Forms.Button pbEstudiante;
        private System.Windows.Forms.Button pbMateria;
        private System.Windows.Forms.Button pbNotas;
        private System.Windows.Forms.Button pblogo;
    }
}

