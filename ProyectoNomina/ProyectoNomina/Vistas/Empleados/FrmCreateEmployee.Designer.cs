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
            lblNombre = new Label();
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
            btnSave = new Button();
            btnCancel = new Button();
            cbxSexo = new ComboBox();
            chkLicencia = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
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
            panel1.Size = new Size(572, 60);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(539, 0);
            picClose.Margin = new Padding(2);
            picClose.Name = "picClose";
            picClose.Size = new Size(33, 29);
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(2, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modulo de Empleado";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.White;
            lblId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(26, 76);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 20);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(26, 113);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.White;
            lblApellido.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(295, 113);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(382, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 20);
            txtApellido.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.White;
            lblEdad.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(26, 178);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(51, 20);
            lblEdad.TabIndex = 7;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(113, 178);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(98, 20);
            txtEdad.TabIndex = 6;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.White;
            lblSexo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.Location = new Point(295, 178);
            lblSexo.Margin = new Padding(2, 0, 2, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(47, 20);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo:";
            // 
            // lblPoseeLicencia
            // 
            lblPoseeLicencia.AutoSize = true;
            lblPoseeLicencia.BackColor = Color.White;
            lblPoseeLicencia.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoseeLicencia.Location = new Point(295, 245);
            lblPoseeLicencia.Margin = new Padding(2, 0, 2, 0);
            lblPoseeLicencia.Name = "lblPoseeLicencia";
            lblPoseeLicencia.Size = new Size(124, 20);
            lblPoseeLicencia.TabIndex = 12;
            lblPoseeLicencia.Text = "Posee Licencia:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.BackColor = Color.White;
            lblFechaNac.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(26, 245);
            lblFechaNac.Margin = new Padding(2, 0, 2, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(147, 20);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // dtFechaNac
            // 
            dtFechaNac.Format = DateTimePickerFormat.Short;
            dtFechaNac.Location = new Point(26, 278);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(202, 20);
            dtFechaNac.TabIndex = 14;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.White;
            lblSueldo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldo.Location = new Point(26, 333);
            lblSueldo.Margin = new Padding(2, 0, 2, 0);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(62, 20);
            lblSueldo.TabIndex = 15;
            lblSueldo.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(113, 333);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(98, 20);
            txtSueldo.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(362, 390);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 32);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(461, 390);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 32);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "M", "F" });
            cbxSexo.Location = new Point(382, 180);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(98, 21);
            cbxSexo.TabIndex = 19;
            // 
            // chkLicencia
            // 
            chkLicencia.AutoSize = true;
            chkLicencia.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkLicencia.Location = new Point(435, 251);
            chkLicencia.Name = "chkLicencia";
            chkLicencia.Size = new Size(15, 14);
            chkLicencia.TabIndex = 20;
            chkLicencia.UseVisualStyleBackColor = true;
            // 
            // FrmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 434);
            Controls.Add(chkLicencia);
            Controls.Add(cbxSexo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblId);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private PictureBox picClose;
        public Label lblId;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblSexo;
        private Label lblPoseeLicencia;
        private Label lblFechaNac;
        private DateTimePicker dtFechaNac;
        private Label lblSueldo;
        private TextBox txtSueldo;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbxSexo;
        private CheckBox chkLicencia;
    }
}