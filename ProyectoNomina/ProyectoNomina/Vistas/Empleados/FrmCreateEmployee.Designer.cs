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
            panel1.Size = new Size(647, 60);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Dock = DockStyle.Right;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(597, 0);
            picClose.Margin = new Padding(2);
            picClose.Name = "picClose";
            picClose.Size = new Size(50, 60);
            picClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(264, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modulo de Empleado";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.White;
            lblId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(38, 86);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(40, 27);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 26);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(38, 149);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 27);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.White;
            lblApellido.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(340, 149);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(115, 27);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(461, 149);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 26);
            txtApellido.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.White;
            lblEdad.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(38, 214);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(78, 27);
            lblEdad.TabIndex = 7;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(154, 215);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(98, 26);
            txtEdad.TabIndex = 3;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.White;
            lblSexo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.Location = new Point(340, 214);
            lblSexo.Margin = new Padding(2, 0, 2, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(70, 27);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo:";
            // 
            // lblPoseeLicencia
            // 
            lblPoseeLicencia.AutoSize = true;
            lblPoseeLicencia.BackColor = Color.White;
            lblPoseeLicencia.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoseeLicencia.Location = new Point(340, 281);
            lblPoseeLicencia.Margin = new Padding(2, 0, 2, 0);
            lblPoseeLicencia.Name = "lblPoseeLicencia";
            lblPoseeLicencia.Size = new Size(190, 27);
            lblPoseeLicencia.TabIndex = 12;
            lblPoseeLicencia.Text = "Posee Licencia:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.BackColor = Color.White;
            lblFechaNac.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(38, 281);
            lblFechaNac.Margin = new Padding(2, 0, 2, 0);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(229, 27);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // dtFechaNac
            // 
            dtFechaNac.Format = DateTimePickerFormat.Short;
            dtFechaNac.Location = new Point(38, 323);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(202, 26);
            dtFechaNac.TabIndex = 5;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.White;
            lblSueldo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldo.Location = new Point(38, 369);
            lblSueldo.Margin = new Padding(2, 0, 2, 0);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(95, 27);
            lblSueldo.TabIndex = 15;
            lblSueldo.Text = "Sueldo:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(154, 369);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(98, 26);
            txtSueldo.TabIndex = 7;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 70, 160);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(354, 471);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 38);
            btnSave.TabIndex = 8;
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
            btnCancel.Location = new Point(508, 471);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 38);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "M", "F" });
            cbxSexo.Location = new Point(461, 214);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(98, 28);
            cbxSexo.TabIndex = 4;
            // 
            // chkLicencia
            // 
            chkLicencia.AutoSize = true;
            chkLicencia.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkLicencia.Location = new Point(551, 285);
            chkLicencia.Name = "chkLicencia";
            chkLicencia.Size = new Size(22, 21);
            chkLicencia.TabIndex = 6;
            chkLicencia.UseVisualStyleBackColor = true;
            // 
            // FrmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 520);
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
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblSexo;
        private Label lblPoseeLicencia;
        private Label lblFechaNac;
        private Label lblSueldo;
        private Button btnSave;
        private Button btnCancel;
        public TextBox txtNombre;
        public TextBox txtApellido;
        public TextBox txtEdad;
        public DateTimePicker dtFechaNac;
        public TextBox txtSueldo;
        public ComboBox cbxSexo;
        public CheckBox chkLicencia;
    }
}