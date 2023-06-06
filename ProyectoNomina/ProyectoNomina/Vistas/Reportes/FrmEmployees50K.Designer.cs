namespace ProyectoNomina.Vistas
{
    partial class FrmEmployees50K
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvReport50K = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            SueldoBruto = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReport50K).BeginInit();
            SuspendLayout();
            // 
            // dgvReport50K
            // 
            dgvReport50K.AllowUserToAddRows = false;
            dgvReport50K.BackgroundColor = Color.White;
            dgvReport50K.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReport50K.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport50K.ColumnHeadersHeight = 30;
            dgvReport50K.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport50K.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Edad, Sexo, FechaNacimiento, SueldoBruto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReport50K.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReport50K.Dock = DockStyle.Fill;
            dgvReport50K.EnableHeadersVisualStyles = false;
            dgvReport50K.Location = new Point(0, 0);
            dgvReport50K.Margin = new Padding(4);
            dgvReport50K.Name = "dgvReport50K";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReport50K.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReport50K.RowHeadersVisible = false;
            dgvReport50K.RowHeadersWidth = 62;
            dgvReport50K.RowTemplate.Height = 25;
            dgvReport50K.Size = new Size(840, 640);
            dgvReport50K.TabIndex = 0;
            dgvReport50K.CellFormatting += dgvReport50K_CellFormatting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            Edad.Width = 50;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 8;
            Sexo.Name = "Sexo";
            Sexo.Width = 50;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.MinimumWidth = 8;
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // SueldoBruto
            // 
            SueldoBruto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SueldoBruto.HeaderText = "SueldoBruto";
            SueldoBruto.MinimumWidth = 8;
            SueldoBruto.Name = "SueldoBruto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 521);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 119);
            panel1.TabIndex = 1;
            // 
            // FrmEmployees50K
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 640);
            Controls.Add(panel1);
            Controls.Add(dgvReport50K);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEmployees50K";
            Text = "Salario mayor a $50,000";
            ((System.ComponentModel.ISupportInitialize)dgvReport50K).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReport50K;
        private Panel panel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn SueldoBruto;
    }
}