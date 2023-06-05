﻿namespace ProyectoNomina.Vistas.Empleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel1.Location = new Point(0, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 0;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.Dock = DockStyle.Right;
            btnCalcularNomina.FlatAppearance.BorderSize = 0;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.Image = (Image)resources.GetObject("btnCalcularNomina.Image");
            btnCalcularNomina.Location = new Point(701, 0);
            btnCalcularNomina.Margin = new Padding(2);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Size = new Size(99, 82);
            btnCalcularNomina.TabIndex = 0;
            btnCalcularNomina.UseVisualStyleBackColor = true;
            btnCalcularNomina.Click += btnCalcularNomina_Click;
            // 
            // dgvCalculoNomina
            // 
            dgvCalculoNomina.AllowUserToAddRows = false;
            dgvCalculoNomina.BackgroundColor = Color.White;
            dgvCalculoNomina.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
            dgvCalculoNomina.Margin = new Padding(2, 1, 2, 1);
            dgvCalculoNomina.Name = "dgvCalculoNomina";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCalculoNomina.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCalculoNomina.RowHeadersVisible = false;
            dgvCalculoNomina.RowHeadersWidth = 62;
            dgvCalculoNomina.RowTemplate.Height = 25;
            dgvCalculoNomina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalculoNomina.Size = new Size(800, 367);
            dgvCalculoNomina.TabIndex = 1;
            dgvCalculoNomina.CellFormatting += dgvCalculoNomina_CellFormatting;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 47;
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
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            TSS.DefaultCellStyle = dataGridViewCellStyle2;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(dgvCalculoNomina);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalcularNomina";
            Text = "Calcular Nomina";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalculoNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCalculoNomina;
        private Button btnCalcularNomina;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn SueldoBruto;
        private DataGridViewTextBoxColumn TSS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn SueldoNeto;
    }
}