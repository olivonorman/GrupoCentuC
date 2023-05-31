﻿namespace ProyectoNomina
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSlide = new Panel();
            panelReports = new Panel();
            btnEmployeeUpper50K = new Button();
            btnEmployeesWomen = new Button();
            btnEmployeesLisence = new Button();
            btnReport = new Button();
            panelEmployees = new Panel();
            btnCreateEmployee = new Button();
            btnEmployees = new Button();
            panelMain = new Panel();
            panelTitle = new Panel();
            lblTitle = new Label();
            panelSlide.SuspendLayout();
            panelReports.SuspendLayout();
            panelEmployees.SuspendLayout();
            panelMain.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.AutoScroll = true;
            panelSlide.BackColor = Color.FromArgb(0, 70, 160);
            panelSlide.Controls.Add(panelReports);
            panelSlide.Controls.Add(btnReport);
            panelSlide.Controls.Add(panelEmployees);
            panelSlide.Controls.Add(btnEmployees);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(194, 436);
            panelSlide.TabIndex = 0;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.FromArgb(0, 70, 200);
            panelReports.Controls.Add(btnEmployeeUpper50K);
            panelReports.Controls.Add(btnEmployeesWomen);
            panelReports.Controls.Add(btnEmployeesLisence);
            panelReports.Dock = DockStyle.Top;
            panelReports.Location = new Point(0, 115);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(194, 152);
            panelReports.TabIndex = 4;
            // 
            // btnEmployeeUpper50K
            // 
            btnEmployeeUpper50K.BackColor = Color.FromArgb(0, 70, 200);
            btnEmployeeUpper50K.Dock = DockStyle.Top;
            btnEmployeeUpper50K.FlatAppearance.BorderSize = 0;
            btnEmployeeUpper50K.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpper50K.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeUpper50K.ForeColor = Color.White;
            btnEmployeeUpper50K.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.Location = new Point(0, 90);
            btnEmployeeUpper50K.Name = "btnEmployeeUpper50K";
            btnEmployeeUpper50K.Size = new Size(194, 59);
            btnEmployeeUpper50K.TabIndex = 7;
            btnEmployeeUpper50K.Text = "Empleados que ganan mas de $50,000";
            btnEmployeeUpper50K.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeeUpper50K.UseVisualStyleBackColor = false;
            btnEmployeeUpper50K.Click += btnEmployeeUpper50K_Click;
            // 
            // btnEmployeesWomen
            // 
            btnEmployeesWomen.BackColor = Color.FromArgb(0, 70, 200);
            btnEmployeesWomen.Dock = DockStyle.Top;
            btnEmployeesWomen.FlatAppearance.BorderSize = 0;
            btnEmployeesWomen.FlatStyle = FlatStyle.Flat;
            btnEmployeesWomen.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeesWomen.ForeColor = Color.White;
            btnEmployeesWomen.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.Location = new Point(0, 45);
            btnEmployeesWomen.Name = "btnEmployeesWomen";
            btnEmployeesWomen.Size = new Size(194, 45);
            btnEmployeesWomen.TabIndex = 5;
            btnEmployeesWomen.Text = "Empleados que son mujeres";
            btnEmployeesWomen.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesWomen.UseVisualStyleBackColor = false;
            // 
            // btnEmployeesLisence
            // 
            btnEmployeesLisence.BackColor = Color.FromArgb(0, 70, 200);
            btnEmployeesLisence.Dock = DockStyle.Top;
            btnEmployeesLisence.FlatAppearance.BorderSize = 0;
            btnEmployeesLisence.FlatStyle = FlatStyle.Flat;
            btnEmployeesLisence.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeesLisence.ForeColor = Color.White;
            btnEmployeesLisence.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.Location = new Point(0, 0);
            btnEmployeesLisence.Name = "btnEmployeesLisence";
            btnEmployeesLisence.Size = new Size(194, 45);
            btnEmployeesLisence.TabIndex = 6;
            btnEmployeesLisence.Text = "Empleados que poseen licencia";
            btnEmployeesLisence.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesLisence.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 78);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(194, 37);
            btnReport.TabIndex = 4;
            btnReport.Text = "Reportes";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // panelEmployees
            // 
            panelEmployees.BackColor = Color.FromArgb(0, 70, 200);
            panelEmployees.Controls.Add(btnCreateEmployee);
            panelEmployees.Dock = DockStyle.Top;
            panelEmployees.Location = new Point(0, 37);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(194, 41);
            panelEmployees.TabIndex = 2;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.FromArgb(0, 70, 200);
            btnCreateEmployee.Dock = DockStyle.Top;
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.White;
            btnCreateEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.Location = new Point(0, 0);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(194, 37);
            btnCreateEmployee.TabIndex = 3;
            btnCreateEmployee.Text = "Crear Empleados";
            btnCreateEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(5, 0, 0, 0);
            btnEmployees.Size = new Size(194, 37);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelMain.Location = new Point(194, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(723, 436);
            panelMain.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 70, 160);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(723, 50);
            panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(723, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Nomina";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 436);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Name = "MainForm";
            Text = "FormPrincipal";
            panelSlide.ResumeLayout(false);
            panelReports.ResumeLayout(false);
            panelEmployees.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlide;
        private Panel panelMain;
        private Panel panelTitle;
        private Label lblTitle;
        private Button btnEmployees;
        private Panel panel1;
        private Button btnCreateEmployee;
        private Panel panelEmployees;
        private Button btnEliminar;
        private Panel panelReports;
        private Button btnEmployeesLisence;
        private Button btnEmployeesWomen;
        private Button btnReport;
        private Button btnEmployeeUpper50K;
    }
}