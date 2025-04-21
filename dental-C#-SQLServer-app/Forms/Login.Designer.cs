namespace dental_C__SQLServer_app
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnAcceder = new Button();
            panel2 = new Panel();
            txtpass = new TextBox();
            txtuser = new TextBox();
            linkRecovery = new LinkLabel();
            label6 = new Label();
            btnmostrar = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(487, 247);
            label3.Name = "label3";
            label3.Size = new Size(237, 15);
            label3.TabIndex = 2;
            label3.Text = "______________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(487, 172);
            label4.Name = "label4";
            label4.Size = new Size(237, 15);
            label4.TabIndex = 3;
            label4.Text = "______________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(81, 18);
            label5.Name = "label5";
            label5.Size = new Size(120, 39);
            label5.TabIndex = 6;
            label5.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.DarkSlateGray;
            btnAcceder.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(20, 278);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(237, 34);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(txtuser);
            panel2.Controls.Add(btnAcceder);
            panel2.Controls.Add(linkRecovery);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnmostrar);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(467, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 381);
            panel2.TabIndex = 8;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.MediumTurquoise;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.FromArgb(0, 0, 64);
            txtpass.Location = new Point(20, 177);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(237, 20);
            txtpass.TabIndex = 12;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.MediumTurquoise;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.FromArgb(0, 0, 64);
            txtuser.Location = new Point(20, 102);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(237, 20);
            txtuser.TabIndex = 11;
            txtuser.Text = "USUARIO";
            txtuser.TextChanged += txtuser_TextChanged;
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // linkRecovery
            // 
            linkRecovery.AutoSize = true;
            linkRecovery.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkRecovery.LinkColor = Color.Black;
            linkRecovery.Location = new Point(49, 326);
            linkRecovery.Name = "linkRecovery";
            linkRecovery.Size = new Size(178, 16);
            linkRecovery.TabIndex = 9;
            linkRecovery.TabStop = true;
            linkRecovery.Text = "¿Ha olvidado su contraseña?";
            linkRecovery.TextAlign = ContentAlignment.TopCenter;
            linkRecovery.LinkClicked += linkRecovery_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(112, 225);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 8;
            label6.Text = "Mostrar Contraseña";
            // 
            // btnmostrar
            // 
            btnmostrar.AutoSize = true;
            btnmostrar.Location = new Point(243, 227);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(14, 13);
            btnmostrar.TabIndex = 7;
            btnmostrar.TabStop = true;
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.CheckedChanged += btnmostrar_CheckedChanged;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Name = "Login";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnAcceder;
        private Panel panel2;
        private RadioButton btnmostrar;
        private Label label6;
        protected LinkLabel linkRecovery;
        private TextBox txtuser;
        private TextBox txtpass;
        public Panel panel1;
    }
}