namespace ProyectoNomina.Vistas.Reportes
{
    partial class FrmEmployeesWoman
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvEmployeesWoman = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesWoman).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 119);
            panel1.TabIndex = 0;
            // 
            // dgvEmployeesWoman
            // 
            dgvEmployeesWoman.AllowUserToAddRows = false;
            dgvEmployeesWoman.BackgroundColor = Color.White;
            dgvEmployeesWoman.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployeesWoman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeesWoman.ColumnHeadersHeight = 34;
            dgvEmployeesWoman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmployeesWoman.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Edad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployeesWoman.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployeesWoman.Dock = DockStyle.Fill;
            dgvEmployeesWoman.EnableHeadersVisualStyles = false;
            dgvEmployeesWoman.GridColor = SystemColors.ControlDark;
            dgvEmployeesWoman.Location = new Point(0, 0);
            dgvEmployeesWoman.Name = "dgvEmployeesWoman";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployeesWoman.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployeesWoman.RowHeadersVisible = false;
            dgvEmployeesWoman.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dgvEmployeesWoman.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployeesWoman.RowTemplate.Height = 25;
            dgvEmployeesWoman.Size = new Size(840, 521);
            dgvEmployeesWoman.TabIndex = 1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 59;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            // 
            // Edad
            // 
            Edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 8;
            Edad.Name = "Edad";
            // 
            // FrmEmployeesWoman
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 640);
            Controls.Add(dgvEmployeesWoman);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEmployeesWoman";
            Text = "Empleadas";
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesWoman).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvEmployeesWoman;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
    }
}