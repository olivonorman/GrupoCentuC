namespace ProyectoNomina.Vistas.Reportes
{
    partial class FrmEmployeesLicense
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
            panel1 = new Panel();
            DgvEmployeesLicense = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvEmployeesLicense).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 81);
            panel1.TabIndex = 0;
            // 
            // DgvEmployeesLicense
            // 
            DgvEmployeesLicense.AllowUserToAddRows = false;
            DgvEmployeesLicense.BackgroundColor = Color.White;
            DgvEmployeesLicense.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvEmployeesLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvEmployeesLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvEmployeesLicense.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Edad, Sexo, FechaNacimiento });
            DgvEmployeesLicense.Dock = DockStyle.Fill;
            DgvEmployeesLicense.EnableHeadersVisualStyles = false;
            DgvEmployeesLicense.GridColor = SystemColors.ControlDark;
            DgvEmployeesLicense.Location = new Point(0, 0);
            DgvEmployeesLicense.Margin = new Padding(2);
            DgvEmployeesLicense.Name = "DgvEmployeesLicense";
            DgvEmployeesLicense.RowHeadersVisible = false;
            DgvEmployeesLicense.RowTemplate.Height = 25;
            DgvEmployeesLicense.Size = new Size(653, 355);
            DgvEmployeesLicense.TabIndex = 1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.Width = 47;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 50;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 50;
            Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            Edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edad.FillWeight = 35F;
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 10;
            Edad.Name = "Edad";
            // 
            // Sexo
            // 
            Sexo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sexo.FillWeight = 40F;
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 15;
            Sexo.Name = "Sexo";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaNacimiento.FillWeight = 165F;
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 50;
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // FrmEmployeesLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 436);
            Controls.Add(DgvEmployeesLicense);
            Controls.Add(panel1);
            Name = "FrmEmployeesLicense";
            Text = "Reporte de empleados que poseen licencia";
            ((System.ComponentModel.ISupportInitialize)DgvEmployeesLicense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DgvEmployeesLicense;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn FechaNacimiento;
    }
}