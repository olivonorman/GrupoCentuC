namespace ProyectoNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelSlide = new Panel();
            panelReports = new Panel();
            btnEmployeeUpper50K = new Button();
            btnEmployeesWomen = new Button();
            btnEmployeesLisence = new Button();
            btnReport = new Button();
            panelEmployees = new Panel();
            btnCalcularNomina = new Button();
            btnCreateEmployee = new Button();
            btnEmployees = new Button();
            panelLogo = new Panel();
            lblUserName = new Label();
            lblName = new Label();
            pbxLogo = new PictureBox();
            panelMain = new Panel();
            panelTitle = new Panel();
            lblTitle = new Label();
            panelSlide.SuspendLayout();
            panelReports.SuspendLayout();
            panelEmployees.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
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
            panelSlide.Controls.Add(panelLogo);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(240, 503);
            panelSlide.TabIndex = 0;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.FromArgb(0, 70, 200);
            panelReports.Controls.Add(btnEmployeeUpper50K);
            panelReports.Controls.Add(btnEmployeesWomen);
            panelReports.Controls.Add(btnEmployeesLisence);
            panelReports.Dock = DockStyle.Top;
            panelReports.Location = new Point(0, 358);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(240, 143);
            panelReports.TabIndex = 8;
            // 
            // btnEmployeeUpper50K
            // 
            btnEmployeeUpper50K.BackColor = Color.FromArgb(0, 70, 200);
            btnEmployeeUpper50K.Dock = DockStyle.Top;
            btnEmployeeUpper50K.FlatAppearance.BorderSize = 0;
            btnEmployeeUpper50K.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpper50K.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeUpper50K.ForeColor = Color.White;
            btnEmployeeUpper50K.Image = (Image)resources.GetObject("btnEmployeeUpper50K.Image");
            btnEmployeeUpper50K.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.Location = new Point(0, 90);
            btnEmployeeUpper50K.Name = "btnEmployeeUpper50K";
            btnEmployeeUpper50K.Padding = new Padding(20, 0, 0, 0);
            btnEmployeeUpper50K.Size = new Size(240, 45);
            btnEmployeeUpper50K.TabIndex = 7;
            btnEmployeeUpper50K.Text = "Empleados que ganan mas de $50,000";
            btnEmployeeUpper50K.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeeUpper50K.UseVisualStyleBackColor = true;
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
            btnEmployeesWomen.Image = (Image)resources.GetObject("btnEmployeesWomen.Image");
            btnEmployeesWomen.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.Location = new Point(0, 45);
            btnEmployeesWomen.Name = "btnEmployeesWomen";
            btnEmployeesWomen.Padding = new Padding(20, 0, 0, 0);
            btnEmployeesWomen.Size = new Size(240, 45);
            btnEmployeesWomen.TabIndex = 5;
            btnEmployeesWomen.Text = "Empleados que son mujeres";
            btnEmployeesWomen.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesWomen.UseVisualStyleBackColor = true;
            btnEmployeesWomen.Click += btnEmployeesWomen_Click;
            // 
            // btnEmployeesLisence
            // 
            btnEmployeesLisence.BackColor = Color.FromArgb(0, 70, 200);
            btnEmployeesLisence.Dock = DockStyle.Top;
            btnEmployeesLisence.FlatAppearance.BorderSize = 0;
            btnEmployeesLisence.FlatStyle = FlatStyle.Flat;
            btnEmployeesLisence.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeesLisence.ForeColor = Color.White;
            btnEmployeesLisence.Image = (Image)resources.GetObject("btnEmployeesLisence.Image");
            btnEmployeesLisence.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.Location = new Point(0, 0);
            btnEmployeesLisence.Name = "btnEmployeesLisence";
            btnEmployeesLisence.Padding = new Padding(20, 0, 0, 0);
            btnEmployeesLisence.Size = new Size(240, 45);
            btnEmployeesLisence.TabIndex = 6;
            btnEmployeesLisence.Text = "Empleados que poseen licencia";
            btnEmployeesLisence.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesLisence.UseVisualStyleBackColor = true;
            btnEmployeesLisence.Click += btnEmployeesLisence_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 306);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(5, 0, 0, 0);
            btnReport.Size = new Size(240, 52);
            btnReport.TabIndex = 6;
            btnReport.Text = "Reportes";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // panelEmployees
            // 
            panelEmployees.BackColor = Color.FromArgb(0, 70, 200);
            panelEmployees.Controls.Add(btnCalcularNomina);
            panelEmployees.Controls.Add(btnCreateEmployee);
            panelEmployees.Dock = DockStyle.Top;
            panelEmployees.Location = new Point(0, 216);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(240, 90);
            panelEmployees.TabIndex = 5;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.BackColor = Color.FromArgb(0, 70, 200);
            btnCalcularNomina.Dock = DockStyle.Top;
            btnCalcularNomina.FlatAppearance.BorderSize = 0;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcularNomina.ForeColor = Color.White;
            btnCalcularNomina.Image = (Image)resources.GetObject("btnCalcularNomina.Image");
            btnCalcularNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcularNomina.Location = new Point(0, 45);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Padding = new Padding(20, 0, 0, 0);
            btnCalcularNomina.Size = new Size(240, 45);
            btnCalcularNomina.TabIndex = 4;
            btnCalcularNomina.Text = "Calcular Nomina";
            btnCalcularNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnCalcularNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcularNomina.UseVisualStyleBackColor = true;
            btnCalcularNomina.Click += btnCalcularNomina_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.FromArgb(0, 70, 200);
            btnCreateEmployee.Dock = DockStyle.Top;
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.White;
            btnCreateEmployee.Image = (Image)resources.GetObject("btnCreateEmployee.Image");
            btnCreateEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.Location = new Point(0, 0);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Padding = new Padding(20, 0, 0, 0);
            btnCreateEmployee.Size = new Size(240, 45);
            btnCreateEmployee.TabIndex = 3;
            btnCreateEmployee.Text = "Crear Empleados";
            btnCreateEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 164);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(5, 0, 0, 0);
            btnEmployees.Size = new Size(240, 52);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblUserName);
            panelLogo.Controls.Add(lblName);
            panelLogo.Controls.Add(pbxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(240, 164);
            panelLogo.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(89, 129);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(73, 16);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "UserName";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(44, 16);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // pbxLogo
            // 
            pbxLogo.Anchor = AnchorStyles.Top;
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(89, 12);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(73, 75);
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelMain.Location = new Point(240, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(958, 503);
            panelMain.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 70, 160);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(958, 50);
            panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(958, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Nomina";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 503);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            Name = "MainForm";
            Text = "FormPrincipal";
            panelSlide.ResumeLayout(false);
            panelReports.ResumeLayout(false);
            panelEmployees.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlide;
        private Panel panelMain;
        private Panel panelTitle;
        private Label lblTitle;
        private Panel panelLogo;
        private Button btnCreateEmployee1;
        private Panel panelEmployees;
        private Button btnEliminar;
        private Button btnEmployeeUpper50K;
        private Button btnEmployees;
        private Panel panel2;
        private Button btnCalcularNomina;
        private Button btnCreateEmployee;
        private Button btnReport;
        private Panel panelReports;
        private Button btnEmployeesWomen;
        private Button btnEmployeesLisence;
        private PictureBox pbxLogo;
        public Label lblUserName;
        public Label lblName;
    }
}