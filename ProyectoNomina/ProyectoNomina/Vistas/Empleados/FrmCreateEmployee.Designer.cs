namespace ProyectoNomina.Vistas.Empleados
{
    partial class FrmCreateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateEmployee));
            panel1 = new Panel();
            picClose = new PictureBox();
            lblTitulo = new Label();
            lblId = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblSexo = new Label();
            lblPoseeLicencia = new Label();
            lblFechaNac = new Label();
            dtFechaNac = new DateTimePicker();
            lblSueldo = new Label();
            txtSueldo = new TextBox();
            cbxSexo = new ComboBox();
            chkLicencia = new CheckBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel8 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            label6 = new Label();
            label5 = new Label();
            picCancelar = new PictureBox();
            picGuardar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuardar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 66);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Dock = DockStyle.Right;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(874, 0);
            picClose.Margin = new Padding(2);
            picClose.Name = "picClose";
            picClose.Size = new Size(45, 66);
            picClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(1, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modulo de Empleado";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.White;
            lblId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(10, 69);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(40, 27);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(125, 222);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 22);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.White;
            lblApellido.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(261, 460);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(0, 27);
            lblApellido.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.WhiteSmoke;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(497, 222);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(319, 22);
            txtApellido.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.WhiteSmoke;
            lblEdad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.ForeColor = Color.DeepSkyBlue;
            lblEdad.Location = new Point(125, 299);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(70, 29);
            lblEdad.TabIndex = 7;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.WhiteSmoke;
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.Location = new Point(130, 339);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(49, 22);
            txtEdad.TabIndex = 3;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.WhiteSmoke;
            lblSexo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSexo.ForeColor = Color.DeepSkyBlue;
            lblSexo.Location = new Point(500, 299);
            lblSexo.Margin = new Padding(2, 0, 2, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(66, 29);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo:";
            // 
            // lblPoseeLicencia
            // 
            lblPoseeLicencia.AutoSize = true;
            lblPoseeLicencia.BackColor = Color.WhiteSmoke;
            lblPoseeLicencia.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoseeLicencia.ForeColor = Color.DeepSkyBlue;
            lblPoseeLicencia.Location = new Point(651, 299);
            lblPoseeLicencia.Margin = new Padding(2, 0, 2, 0);
            lblPoseeLicencia.Name = "lblPoseeLicencia";
            lblPoseeLicencia.Size = new Size(99, 29);
            lblPoseeLicencia.TabIndex = 12;
            lblPoseeLicencia.Text = "Licencia:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.BackColor = Color.WhiteSmoke;
            lblFechaNac.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNac.ForeColor = Color.DeepSkyBlue;
            lblFechaNac.Location = new Point(238, 299);
            lblFechaNac.Margin = new Padding(2, 0, 2, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(199, 29);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // dtFechaNac
            // 
            dtFechaNac.CalendarMonthBackground = Color.WhiteSmoke;
            dtFechaNac.Format = DateTimePickerFormat.Short;
            dtFechaNac.Location = new Point(246, 339);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(129, 29);
            dtFechaNac.TabIndex = 4;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.WhiteSmoke;
            lblSueldo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSueldo.ForeColor = Color.DeepSkyBlue;
            lblSueldo.Location = new Point(122, 431);
            lblSueldo.Margin = new Padding(2, 0, 2, 0);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(88, 29);
            lblSueldo.TabIndex = 15;
            lblSueldo.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = Color.WhiteSmoke;
            txtSueldo.BorderStyle = BorderStyle.None;
            txtSueldo.Location = new Point(124, 478);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(88, 22);
            txtSueldo.TabIndex = 7;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // cbxSexo
            // 
            cbxSexo.BackColor = Color.WhiteSmoke;
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "M", "F" });
            cbxSexo.Location = new Point(500, 337);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(63, 30);
            cbxSexo.TabIndex = 5;
            // 
            // chkLicencia
            // 
            chkLicencia.AutoSize = true;
            chkLicencia.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkLicencia.Location = new Point(696, 339);
            chkLicencia.Name = "chkLicencia";
            chkLicencia.Size = new Size(22, 21);
            chkLicencia.TabIndex = 6;
            chkLicencia.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 70, 160);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(125, 260);
            panel5.Margin = new Padding(4, 6, 4, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(319, 2);
            panel5.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 70, 160);
            panel4.Controls.Add(panel6);
            panel4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 6, 4, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 2);
            panel4.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 70, 160);
            panel6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 6, 4, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(319, 2);
            panel6.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 160);
            panel2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 6, 4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 2);
            panel2.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(122, 176);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 27;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(516, 176);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 29;
            label1.Text = "Apellido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 70, 160);
            panel3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(500, 260);
            panel3.Margin = new Padding(4, 6, 4, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 2);
            panel3.TabIndex = 30;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 70, 160);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(130, 368);
            panel7.Margin = new Padding(4, 6, 4, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(58, 2);
            panel7.TabIndex = 31;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 70, 160);
            panel9.Controls.Add(panel10);
            panel9.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(4, 6, 4, 6);
            panel9.Name = "panel9";
            panel9.Size = new Size(58, 2);
            panel9.TabIndex = 32;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 70, 160);
            panel10.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(4, 6, 4, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(319, 2);
            panel10.TabIndex = 29;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 70, 160);
            panel8.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 6, 4, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(319, 2);
            panel8.TabIndex = 29;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 70, 160);
            panel11.Controls.Add(panel12);
            panel11.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel11.Location = new Point(124, 508);
            panel11.Margin = new Padding(4, 6, 4, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(90, 2);
            panel11.TabIndex = 32;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(0, 70, 160);
            panel12.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(4, 6, 4, 6);
            panel12.Name = "panel12";
            panel12.Size = new Size(319, 2);
            panel12.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(762, 499);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 36;
            label6.Text = "Cancelar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(692, 499);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 35;
            label5.Text = "Guardar";
            // 
            // picCancelar
            // 
            picCancelar.BackColor = Color.WhiteSmoke;
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(769, 456);
            picCancelar.Margin = new Padding(4, 6, 4, 6);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(47, 43);
            picCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            picCancelar.TabIndex = 34;
            picCancelar.TabStop = false;
            picCancelar.Click += picCancelar_Click;
            // 
            // picGuardar
            // 
            picGuardar.BackColor = Color.WhiteSmoke;
            picGuardar.Image = (Image)resources.GetObject("picGuardar.Image");
            picGuardar.Location = new Point(697, 456);
            picGuardar.Margin = new Padding(4, 6, 4, 6);
            picGuardar.Name = "picGuardar";
            picGuardar.Size = new Size(50, 43);
            picGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            picGuardar.TabIndex = 33;
            picGuardar.TabStop = false;
            picGuardar.Click += picGuardar_Click;
            // 
            // FrmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(919, 686);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(picCancelar);
            Controls.Add(picGuardar);
            Controls.Add(panel11);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(label2);
            Controls.Add(chkLicencia);
            Controls.Add(cbxSexo);
            Controls.Add(txtSueldo);
            Controls.Add(lblSueldo);
            Controls.Add(dtFechaNac);
            Controls.Add(lblPoseeLicencia);
            Controls.Add(lblFechaNac);
            Controls.Add(lblSexo);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblId);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuardar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private PictureBox picClose;
        public Label lblId;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblSexo;
        private Label lblPoseeLicencia;
        private Label lblFechaNac;
        private Label lblSueldo;
        public TextBox txtNombre;
        public TextBox txtApellido;
        public TextBox txtEdad;
        public DateTimePicker dtFechaNac;
        public TextBox txtSueldo;
        public ComboBox cbxSexo;
        public CheckBox chkLicencia;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private Panel panel8;
        private Panel panel11;
        private Panel panel12;
        private Label label6;
        private Label label5;
        private PictureBox picCancelar;
        private PictureBox picGuardar;
    }
}