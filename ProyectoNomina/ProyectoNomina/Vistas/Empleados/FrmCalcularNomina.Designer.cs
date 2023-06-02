namespace ProyectoNomina.Vistas.Empleados
{
    partial class FrmCalcularNomina
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
            panel1 = new Panel();
            dgvCalculoNomina = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            SueldoBruto = new DataGridViewTextBoxColumn();
            TSS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            SueldoNeto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 0;
            // 
            // dgvCalculoNomina
            // 
            dgvCalculoNomina.AllowUserToAddRows = false;
            dgvCalculoNomina.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCalculoNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCalculoNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalculoNomina.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, SueldoBruto, TSS, ISR, SueldoNeto });
            dgvCalculoNomina.Dock = DockStyle.Fill;
            dgvCalculoNomina.EnableHeadersVisualStyles = false;
            dgvCalculoNomina.GridColor = SystemColors.ControlDark;
            dgvCalculoNomina.Location = new Point(0, 0);
            dgvCalculoNomina.Margin = new Padding(2);
            dgvCalculoNomina.Name = "dgvCalculoNomina";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCalculoNomina.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCalculoNomina.RowHeadersVisible = false;
            dgvCalculoNomina.RowTemplate.Height = 25;
            dgvCalculoNomina.Size = new Size(800, 368);
            dgvCalculoNomina.TabIndex = 1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 49;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // SueldoBruto
            // 
            SueldoBruto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SueldoBruto.HeaderText = "Sueldo Bruto";
            SueldoBruto.Name = "SueldoBruto";
            // 
            // TSS
            // 
            TSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TSS.HeaderText = "TSS";
            TSS.Name = "TSS";
            // 
            // ISR
            // 
            ISR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ISR.HeaderText = "ISR";
            ISR.Name = "ISR";
            // 
            // SueldoNeto
            // 
            SueldoNeto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SueldoNeto.HeaderText = "Sueldo Neto";
            SueldoNeto.Name = "SueldoNeto";
            // 
            // FrmCalcularNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCalculoNomina);
            Controls.Add(panel1);
            Name = "FrmCalcularNomina";
            Text = "FrmCalcularNomina";
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCalculoNomina;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn SueldoBruto;
        private DataGridViewTextBoxColumn TSS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn SueldoNeto;
    }
}