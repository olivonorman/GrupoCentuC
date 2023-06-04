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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalcularNomina));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCalcularNomina = new Button();
            dgvCalculoNomina = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            SueldoBruto = new DataGridViewTextBoxColumn();
            TSS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            SueldoNeto = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(btnCalcularNomina);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 613);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 137);
            panel1.TabIndex = 0;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.Dock = DockStyle.Right;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.Image = (Image)resources.GetObject("btnCalcularNomina.Image");
            btnCalcularNomina.Location = new Point(1002, 0);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Size = new Size(141, 137);
            btnCalcularNomina.TabIndex = 0;
            btnCalcularNomina.UseVisualStyleBackColor = true;
            btnCalcularNomina.Click += btnCalcularNomina_Click;
            // 
            // dgvCalculoNomina
            // 
            dgvCalculoNomina.AllowUserToAddRows = false;
            dgvCalculoNomina.BackgroundColor = Color.White;
            dgvCalculoNomina.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCalculoNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCalculoNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalculoNomina.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, SueldoBruto, TSS, ISR, SueldoNeto });
            dgvCalculoNomina.Dock = DockStyle.Fill;
            dgvCalculoNomina.EnableHeadersVisualStyles = false;
            dgvCalculoNomina.GridColor = SystemColors.ControlDark;
            dgvCalculoNomina.Location = new Point(0, 0);
            dgvCalculoNomina.Margin = new Padding(3, 2, 3, 2);
            dgvCalculoNomina.Name = "dgvCalculoNomina";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvCalculoNomina.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvCalculoNomina.RowHeadersVisible = false;
            dgvCalculoNomina.RowHeadersWidth = 62;
            dgvCalculoNomina.RowTemplate.Height = 25;
            dgvCalculoNomina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalculoNomina.Size = new Size(1143, 613);
            dgvCalculoNomina.TabIndex = 1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 69;
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
            // SueldoBruto
            // 
            SueldoBruto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SueldoBruto.HeaderText = "Sueldo Bruto";
            SueldoBruto.MinimumWidth = 8;
            SueldoBruto.Name = "SueldoBruto";
            // 
            // TSS
            // 
            TSS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TSS.HeaderText = "TSS";
            TSS.MinimumWidth = 8;
            TSS.Name = "TSS";
            // 
            // ISR
            // 
            ISR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ISR.HeaderText = "ISR";
            ISR.MinimumWidth = 8;
            ISR.Name = "ISR";
            // 
            // SueldoNeto
            // 
            SueldoNeto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SueldoNeto.HeaderText = "Sueldo Neto";
            SueldoNeto.MinimumWidth = 8;
            SueldoNeto.Name = "SueldoNeto";
            // 
            // FrmCalcularNomina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dgvCalculoNomina);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCalcularNomina";
            Text = "Calcular Nomina";
            panel1.ResumeLayout(false);
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
        private Button btnCalcularNomina;
    }
}