namespace ProyectoNomina.Vistas.Login
{
    partial class FrmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            panel1 = new Panel();
            picClose = new PictureBox();
            label1 = new Label();
            lblId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            picGuardar = new PictureBox();
            picCancelar = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(picClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 63);
            panel1.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.BackColor = Color.DeepSkyBlue;
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(510, 7);
            picClose.Name = "picClose";
            picClose.Size = new Size(39, 37);
            picClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(95, 635);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 25);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            lblId.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(95, 287);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(95, 400);
            label3.Name = "label3";
            label3.Size = new Size(92, 29);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(98, 510);
            label4.Name = "label4";
            label4.Size = new Size(67, 29);
            label4.TabIndex = 4;
            label4.Text = "Clave";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.WindowFrame;
            txtName.Location = new Point(104, 318);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 22);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.WindowFrame;
            txtUserName.Location = new Point(101, 432);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(357, 22);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(101, 541);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(354, 22);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // picGuardar
            // 
            picGuardar.BackColor = Color.White;
            picGuardar.Image = (Image)resources.GetObject("picGuardar.Image");
            picGuardar.Location = new Point(334, 602);
            picGuardar.Margin = new Padding(4, 5, 4, 5);
            picGuardar.Name = "picGuardar";
            picGuardar.Size = new Size(56, 39);
            picGuardar.SizeMode = PictureBoxSizeMode.Zoom;
            picGuardar.TabIndex = 22;
            picGuardar.TabStop = false;
            picGuardar.Click += picGuardar_Click;
            // 
            // picCancelar
            // 
            picCancelar.BackColor = Color.White;
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(398, 602);
            picCancelar.Margin = new Padding(4, 5, 4, 5);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(52, 39);
            picCancelar.SizeMode = PictureBoxSizeMode.Zoom;
            picCancelar.TabIndex = 23;
            picCancelar.TabStop = false;
            picCancelar.Click += picCancelar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 160);
            panel2.Controls.Add(panel3);
            panel2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(98, 346);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 2);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 70, 160);
            panel3.Controls.Add(panel4);
            panel3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 2);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 70, 160);
            panel4.Controls.Add(panel5);
            panel4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 2);
            panel4.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 70, 160);
            panel5.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 2);
            panel5.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 70, 160);
            panel6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(98, 459);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 2);
            panel6.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 70, 160);
            panel7.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(98, 569);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(354, 2);
            panel7.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(328, 641);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 28;
            label5.Text = "Guardar";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(391, 641);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 29;
            label6.Text = "Cancelar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(85, 198);
            label7.Name = "label7";
            label7.Size = new Size(390, 49);
            label7.TabIndex = 30;
            label7.Text = " ¡Crea tu usuario aqui!";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 93);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // FrmRegistrar
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 709);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(picCancelar);
            Controls.Add(picGuardar);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblId);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            Load += FrmRegistrar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public Label lblId;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtName;
        private PictureBox picClose;
        public TextBox txtUserName;
        public TextBox txtPassword;
        private PictureBox picGuardar;
        private PictureBox picCancelar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}