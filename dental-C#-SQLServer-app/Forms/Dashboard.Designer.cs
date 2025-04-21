namespace dental_C__SQLServer_app
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnPacientes = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnMenu = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnConsultas = new Button();
            btnConfig = new Button();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar = new Panel();
            panel7 = new Panel();
            btnRegistrar = new Button();
            panel6 = new Panel();
            btnDiagnosticos = new Button();
            panel5 = new Panel();
            btnHabits = new Button();
            MainPanel = new Panel();
            PanelWelcome = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            sidebar.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            PanelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPacientes
            // 
            btnPacientes.Anchor = AnchorStyles.Left;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(-16, -12);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(20, 0, 0, 0);
            btnPacientes.Size = new Size(235, 74);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "   Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            btnPacientes.MouseLeave += btnPacientes_MouseLeave;
            btnPacientes.MouseMove += btnPacientes_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 6;
            label1.Text = "Menú";
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(9, 29);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 39);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 5;
            btnMenu.TabStop = false;
            btnMenu.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPacientes);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 55);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConsultas);
            panel3.Location = new Point(0, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 55);
            panel3.TabIndex = 2;
            // 
            // btnConsultas
            // 
            btnConsultas.Anchor = AnchorStyles.Left;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultas.ForeColor = SystemColors.ControlText;
            btnConsultas.Image = (Image)resources.GetObject("btnConsultas.Image");
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(-16, -12);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(20, 0, 0, 0);
            btnConsultas.Size = new Size(235, 74);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "   Citas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click_1;
            btnConsultas.MouseLeave += btnConsultas_MouseLeave;
            btnConsultas.MouseMove += btnConsultas_MouseMove;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = AnchorStyles.Left;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(-13, -10);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(20, 0, 0, 0);
            btnConfig.Size = new Size(232, 74);
            btnConfig.TabIndex = 1;
            btnConfig.Text = "   Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click_1;
            btnConfig.MouseLeave += btnConfig_MouseLeave;
            btnConfig.MouseMove += btnConfig_MouseMove;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 563);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(7, 0, 0, 0);
            btnLogout.Size = new Size(220, 53);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "  Cerrar Sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += Logout_Click;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            btnLogout.MouseMove += btnLogout_MouseMove;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(194, 231, 255);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 616);
            sidebar.TabIndex = 5;
            sidebar.Paint += sidebar_Paint_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnRegistrar);
            panel7.Controls.Add(btnConfig);
            panel7.Location = new Point(0, 304);
            panel7.Name = "panel7";
            panel7.Size = new Size(221, 90);
            panel7.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Left;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(0, 55);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Padding = new Padding(20, 0, 0, 0);
            btnRegistrar.Size = new Size(222, 35);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "             Crear Usuario";
            btnRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            btnRegistrar.MouseLeave += btnRegistrar_MouseLeave;
            btnRegistrar.MouseMove += btnRegistrar_MouseMove;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDiagnosticos);
            panel6.Location = new Point(0, 248);
            panel6.Name = "panel6";
            panel6.Size = new Size(221, 55);
            panel6.TabIndex = 4;
            // 
            // btnDiagnosticos
            // 
            btnDiagnosticos.Anchor = AnchorStyles.Left;
            btnDiagnosticos.FlatAppearance.BorderSize = 0;
            btnDiagnosticos.FlatStyle = FlatStyle.Flat;
            btnDiagnosticos.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiagnosticos.Image = (Image)resources.GetObject("btnDiagnosticos.Image");
            btnDiagnosticos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiagnosticos.Location = new Point(-16, -12);
            btnDiagnosticos.Name = "btnDiagnosticos";
            btnDiagnosticos.Padding = new Padding(20, 0, 0, 0);
            btnDiagnosticos.Size = new Size(235, 74);
            btnDiagnosticos.TabIndex = 1;
            btnDiagnosticos.Text = "   Diagnósticos";
            btnDiagnosticos.TextAlign = ContentAlignment.MiddleLeft;
            btnDiagnosticos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiagnosticos.UseVisualStyleBackColor = true;
            btnDiagnosticos.Click += btnDiagnosticos_Click;
            btnDiagnosticos.MouseLeave += btnDiagnosticos_MouseLeave;
            btnDiagnosticos.MouseMove += btnDiagnosticos_MouseMove;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHabits);
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(-1, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 90);
            panel5.TabIndex = 3;
            // 
            // btnHabits
            // 
            btnHabits.Anchor = AnchorStyles.Left;
            btnHabits.FlatAppearance.BorderSize = 0;
            btnHabits.FlatStyle = FlatStyle.Flat;
            btnHabits.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHabits.ImageAlign = ContentAlignment.MiddleLeft;
            btnHabits.Location = new Point(1, 55);
            btnHabits.Name = "btnHabits";
            btnHabits.Padding = new Padding(20, 0, 0, 0);
            btnHabits.Size = new Size(221, 35);
            btnHabits.TabIndex = 2;
            btnHabits.Text = "             Habitos y Antecedentes";
            btnHabits.TextAlign = ContentAlignment.MiddleLeft;
            btnHabits.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHabits.UseVisualStyleBackColor = true;
            btnHabits.Click += btnHabits_Click;
            btnHabits.MouseLeave += btnHabits_MouseLeave;
            btnHabits.MouseMove += btnHabits_MouseMove;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1305, 616);
            MainPanel.TabIndex = 6;
            MainPanel.Paint += MainPanel_Paint_1;
            // 
            // PanelWelcome
            // 
            PanelWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelWelcome.BackColor = Color.FromArgb(14, 93, 142);
            PanelWelcome.Controls.Add(pictureBox1);
            PanelWelcome.Controls.Add(label2);
            PanelWelcome.Location = new Point(3, 0);
            PanelWelcome.Name = "PanelWelcome";
            PanelWelcome.Size = new Size(1303, 48);
            PanelWelcome.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(424, 9);
            label2.Name = "label2";
            label2.Size = new Size(729, 19);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido al Sistema Histodent del Consultorio Odontológico Tatiana de los Angeles F.P\r\n";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1305, 616);
            Controls.Add(sidebar);
            Controls.Add(PanelWelcome);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histodent";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PanelWelcome.ResumeLayout(false);
            PanelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPacientes;
        private Button btnConsultas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnConfig;
        private PictureBox btnMenu;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button btnLogout;
        private Panel sidebar;
        private Panel MainPanel;
        private Panel PanelWelcome;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button btnHabits;
        private Panel panel6;
        private Button btnDiagnosticos;
        private Panel panel7;
        private Button btnRegistrar;
    }
}
