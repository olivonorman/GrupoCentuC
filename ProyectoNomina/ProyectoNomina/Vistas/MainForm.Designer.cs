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
            btnLogout = new Button();
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
            lblName = new Label();
            lblId = new Label();
            pbxLogo = new PictureBox();
            panelMain = new Panel();
            panelTitle = new Panel();
            lblUserName = new Label();
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
            panelSlide.BorderStyle = BorderStyle.FixedSingle;
            panelSlide.Controls.Add(btnLogout);
            panelSlide.Controls.Add(panelReports);
            panelSlide.Controls.Add(btnReport);
            panelSlide.Controls.Add(panelEmployees);
            panelSlide.Controls.Add(btnEmployees);
            panelSlide.Controls.Add(panelLogo);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Margin = new Padding(4, 5, 4, 5);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(343, 933);
            panelSlide.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 844);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(7, 0, 0, 0);
            btnLogout.Size = new Size(341, 87);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.FromArgb(0, 70, 200);
            panelReports.Controls.Add(btnEmployeeUpper50K);
            panelReports.Controls.Add(btnEmployeesWomen);
            panelReports.Controls.Add(btnEmployeesLisence);
            panelReports.Dock = DockStyle.Top;
            panelReports.Location = new Point(0, 597);
            panelReports.Margin = new Padding(4, 5, 4, 5);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(341, 221);
            panelReports.TabIndex = 8;
            // 
            // btnEmployeeUpper50K
            // 
            btnEmployeeUpper50K.BackColor = Color.DeepSkyBlue;
            btnEmployeeUpper50K.Dock = DockStyle.Top;
            btnEmployeeUpper50K.FlatAppearance.BorderSize = 0;
            btnEmployeeUpper50K.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpper50K.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeUpper50K.ForeColor = Color.White;
            btnEmployeeUpper50K.Image = (Image)resources.GetObject("btnEmployeeUpper50K.Image");
            btnEmployeeUpper50K.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.Location = new Point(0, 150);
            btnEmployeeUpper50K.Margin = new Padding(4, 5, 4, 5);
            btnEmployeeUpper50K.Name = "btnEmployeeUpper50K";
            btnEmployeeUpper50K.Padding = new Padding(29, 0, 0, 0);
            btnEmployeeUpper50K.Size = new Size(341, 75);
            btnEmployeeUpper50K.TabIndex = 7;
            btnEmployeeUpper50K.Text = "Empleados que ganan mas de $50,000";
            btnEmployeeUpper50K.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeUpper50K.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeeUpper50K.UseVisualStyleBackColor = false;
            btnEmployeeUpper50K.Click += btnEmployeeUpper50K_Click;
            // 
            // btnEmployeesWomen
            // 
            btnEmployeesWomen.BackColor = Color.DeepSkyBlue;
            btnEmployeesWomen.Dock = DockStyle.Top;
            btnEmployeesWomen.FlatAppearance.BorderSize = 0;
            btnEmployeesWomen.FlatStyle = FlatStyle.Flat;
            btnEmployeesWomen.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeesWomen.ForeColor = Color.White;
            btnEmployeesWomen.Image = (Image)resources.GetObject("btnEmployeesWomen.Image");
            btnEmployeesWomen.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.Location = new Point(0, 75);
            btnEmployeesWomen.Margin = new Padding(4, 5, 4, 5);
            btnEmployeesWomen.Name = "btnEmployeesWomen";
            btnEmployeesWomen.Padding = new Padding(29, 0, 0, 0);
            btnEmployeesWomen.Size = new Size(341, 75);
            btnEmployeesWomen.TabIndex = 5;
            btnEmployeesWomen.Text = "Empleadas";
            btnEmployeesWomen.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesWomen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesWomen.UseVisualStyleBackColor = false;
            btnEmployeesWomen.Click += btnEmployeesWomen_Click;
            // 
            // btnEmployeesLisence
            // 
            btnEmployeesLisence.BackColor = Color.DeepSkyBlue;
            btnEmployeesLisence.Dock = DockStyle.Top;
            btnEmployeesLisence.FlatAppearance.BorderSize = 0;
            btnEmployeesLisence.FlatStyle = FlatStyle.Flat;
            btnEmployeesLisence.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeesLisence.ForeColor = Color.White;
            btnEmployeesLisence.Image = (Image)resources.GetObject("btnEmployeesLisence.Image");
            btnEmployeesLisence.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.Location = new Point(0, 0);
            btnEmployeesLisence.Margin = new Padding(4, 5, 4, 5);
            btnEmployeesLisence.Name = "btnEmployeesLisence";
            btnEmployeesLisence.Padding = new Padding(29, 0, 0, 0);
            btnEmployeesLisence.Size = new Size(341, 75);
            btnEmployeesLisence.TabIndex = 6;
            btnEmployeesLisence.Text = "Empleados con licencia";
            btnEmployeesLisence.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeesLisence.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeesLisence.UseVisualStyleBackColor = false;
            btnEmployeesLisence.Click += btnEmployeesLisence_Click;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 510);
            btnReport.Margin = new Padding(4, 5, 4, 5);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(7, 0, 0, 0);
            btnReport.Size = new Size(341, 87);
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
            panelEmployees.Location = new Point(0, 360);
            panelEmployees.Margin = new Padding(4, 5, 4, 5);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(341, 150);
            panelEmployees.TabIndex = 5;
            // 
            // btnCalcularNomina
            // 
            btnCalcularNomina.BackColor = Color.DeepSkyBlue;
            btnCalcularNomina.Dock = DockStyle.Top;
            btnCalcularNomina.FlatAppearance.BorderSize = 0;
            btnCalcularNomina.FlatStyle = FlatStyle.Flat;
            btnCalcularNomina.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularNomina.ForeColor = Color.White;
            btnCalcularNomina.Image = (Image)resources.GetObject("btnCalcularNomina.Image");
            btnCalcularNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcularNomina.Location = new Point(0, 75);
            btnCalcularNomina.Margin = new Padding(4, 5, 4, 5);
            btnCalcularNomina.Name = "btnCalcularNomina";
            btnCalcularNomina.Padding = new Padding(29, 0, 0, 0);
            btnCalcularNomina.Size = new Size(341, 75);
            btnCalcularNomina.TabIndex = 4;
            btnCalcularNomina.Text = "Calcular Nomina";
            btnCalcularNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnCalcularNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcularNomina.UseVisualStyleBackColor = false;
            btnCalcularNomina.Click += btnCalcularNomina_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.DeepSkyBlue;
            btnCreateEmployee.Dock = DockStyle.Top;
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.White;
            btnCreateEmployee.Image = (Image)resources.GetObject("btnCreateEmployee.Image");
            btnCreateEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.Location = new Point(0, 0);
            btnCreateEmployee.Margin = new Padding(4, 5, 4, 5);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Padding = new Padding(29, 0, 0, 0);
            btnCreateEmployee.Size = new Size(341, 75);
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
            btnEmployees.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Image = (Image)resources.GetObject("btnEmployees.Image");
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 273);
            btnEmployees.Margin = new Padding(4, 5, 4, 5);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(7, 0, 0, 0);
            btnEmployees.Size = new Size(341, 87);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 70, 160);
            panelLogo.Controls.Add(lblName);
            panelLogo.Controls.Add(lblId);
            panelLogo.Controls.Add(pbxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 5, 4, 5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(341, 273);
            panelLogo.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(0, 70, 160);
            lblName.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.DeepSkyBlue;
            lblName.Location = new Point(10, 179);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 35);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(17, 120);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 25);
            lblId.TabIndex = 4;
            lblId.Visible = false;
            // 
            // pbxLogo
            // 
            pbxLogo.Anchor = AnchorStyles.Top;
            pbxLogo.BackColor = Color.FromArgb(0, 70, 160);
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(34, 20);
            pbxLogo.Margin = new Padding(4, 5, 4, 5);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(254, 142);
            pbxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            pbxLogo.Click += pbxLogo_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panelMain.ForeColor = SystemColors.ControlDarkDark;
            panelMain.Location = new Point(343, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1368, 933);
            panelMain.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 70, 160);
            panelTitle.Controls.Add(lblUserName);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(4, 5, 4, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1368, 83);
            panelTitle.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(1242, 29);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 24);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "UserName";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(482, 18);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(521, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "PAYCASH";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 933);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panelSlide.ResumeLayout(false);
            panelReports.ResumeLayout(false);
            panelEmployees.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
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
        private Button btnCalcularNomina;
        private Button btnCreateEmployee;
        private Button btnReport;
        private Panel panelReports;
        private Button btnEmployeesWomen;
        private Button btnEmployeesLisence;
        private PictureBox pbxLogo;
        public Label lblId;
        private Button btnLogout;
        public Label lblName;
        public Label lblUserName;
    }
}