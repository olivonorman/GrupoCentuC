namespace ProyectoNomina.Vistas.Empleados
{
    partial class FrmEmployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            dgvEmployees = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            PoseeLicencia = new DataGridViewTextBoxColumn();
            SueldoBruto = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panelEmployees1 = new Panel();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            panelEmployees1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeight = 30;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Edad, Sexo, FechaNacimiento, PoseeLicencia, SueldoBruto, Edit, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = SystemColors.ControlDark;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 62;
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1206, 727);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            dgvEmployees.CellFormatting += dgvEmployees_CellFormatting;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 64;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 50F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.FillWeight = 50F;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Edad
            // 
            Edad.FillWeight = 40F;
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.Width = 150;
            // 
            // Sexo
            // 
            Sexo.FillWeight = 40F;
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.Width = 150;
            // 
            // FechaNacimiento
            // 
            dataGridViewCellStyle2.NullValue = null;
            FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle2;
            FechaNacimiento.FillWeight = 190.803436F;
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.MinimumWidth = 8;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 150;
            // 
            // PoseeLicencia
            // 
            PoseeLicencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PoseeLicencia.FillWeight = 40F;
            PoseeLicencia.HeaderText = "Posee Licencia";
            PoseeLicencia.MinimumWidth = 8;
            PoseeLicencia.Name = "PoseeLicencia";
            PoseeLicencia.ReadOnly = true;
            PoseeLicencia.Resizable = DataGridViewTriState.True;
            // 
            // SueldoBruto
            // 
            SueldoBruto.FillWeight = 75.5012741F;
            SueldoBruto.HeaderText = "SueldoBruto";
            SueldoBruto.MinimumWidth = 8;
            SueldoBruto.Name = "SueldoBruto";
            SueldoBruto.Width = 150;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Width = 8;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Width = 8;
            // 
            // panelEmployees1
            // 
            panelEmployees1.BackColor = Color.FromArgb(0, 70, 160);
            panelEmployees1.Controls.Add(btnAgregar);
            panelEmployees1.Dock = DockStyle.Bottom;
            panelEmployees1.Location = new Point(0, 590);
            panelEmployees1.Margin = new Padding(4, 5, 4, 5);
            panelEmployees1.Name = "panelEmployees1";
            panelEmployees1.Size = new Size(1206, 137);
            panelEmployees1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DeepSkyBlue;
            btnAgregar.Dock = DockStyle.Right;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.BottomCenter;
            btnAgregar.Location = new Point(1066, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 137);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 727);
            Controls.Add(panelEmployees1);
            Controls.Add(dgvEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEmployee";
            Text = "Crear empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            panelEmployees1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private Panel panelEmployees1;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn PoseeLicencia;
        private DataGridViewTextBoxColumn SueldoBruto;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}