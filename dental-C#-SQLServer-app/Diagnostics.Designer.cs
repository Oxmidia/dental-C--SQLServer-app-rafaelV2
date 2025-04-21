namespace dental_C__SQLServer_app
{
    partial class Diagnostics
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
            panel1 = new Panel();
            label1 = new Label();
            txtFechaDiagnostico = new TextBox();
            txtSeveridadD = new TextBox();
            txtDescripcionDiagnostico = new TextBox();
            lblNombrePaciente = new Label();
            lblApellidoPaciente = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGuardarDiagnostico = new Button();
            btnModificarD = new Button();
            btnEliminarD = new Button();
            dataDiagnostico = new DataGridView();
            dataGridView1 = new DataGridView();
            textBoxFiltro = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataDiagnostico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(410, 57);
            label1.Name = "label1";
            label1.Size = new Size(470, 42);
            label1.TabIndex = 2;
            label1.Text = "Diagnostico del Paciente";
            // 
            // txtFechaDiagnostico
            // 
            txtFechaDiagnostico.Anchor = AnchorStyles.None;
            txtFechaDiagnostico.Font = new Font("Century Gothic", 12F);
            txtFechaDiagnostico.Location = new Point(631, 177);
            txtFechaDiagnostico.Name = "txtFechaDiagnostico";
            txtFechaDiagnostico.Size = new Size(187, 27);
            txtFechaDiagnostico.TabIndex = 4;
            // 
            // txtSeveridadD
            // 
            txtSeveridadD.Anchor = AnchorStyles.None;
            txtSeveridadD.Font = new Font("Century Gothic", 12F);
            txtSeveridadD.Location = new Point(631, 237);
            txtSeveridadD.Name = "txtSeveridadD";
            txtSeveridadD.Size = new Size(187, 27);
            txtSeveridadD.TabIndex = 6;
            // 
            // txtDescripcionDiagnostico
            // 
            txtDescripcionDiagnostico.Anchor = AnchorStyles.None;
            txtDescripcionDiagnostico.Font = new Font("Century Gothic", 12F);
            txtDescripcionDiagnostico.Location = new Point(854, 177);
            txtDescripcionDiagnostico.Multiline = true;
            txtDescripcionDiagnostico.Name = "txtDescripcionDiagnostico";
            txtDescripcionDiagnostico.Size = new Size(370, 141);
            txtDescripcionDiagnostico.TabIndex = 8;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.Anchor = AnchorStyles.None;
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePaciente.Location = new Point(686, 108);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(77, 21);
            lblNombrePaciente.TabIndex = 9;
            lblNombrePaciente.Text = "Nombre:";
            // 
            // lblApellidoPaciente
            // 
            lblApellidoPaciente.Anchor = AnchorStyles.None;
            lblApellidoPaciente.AutoSize = true;
            lblApellidoPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaciente.Location = new Point(946, 108);
            lblApellidoPaciente.Name = "lblApellidoPaciente";
            lblApellidoPaciente.Size = new Size(78, 21);
            lblApellidoPaciente.TabIndex = 10;
            lblApellidoPaciente.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(522, 243);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 11;
            label4.Text = "Severidad:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(538, 177);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 12;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(854, 153);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 13;
            label6.Text = "Descripcion:";
            // 
            // btnGuardarDiagnostico
            // 
            btnGuardarDiagnostico.Anchor = AnchorStyles.None;
            btnGuardarDiagnostico.BackColor = Color.FromArgb(14, 93, 142);
            btnGuardarDiagnostico.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarDiagnostico.ForeColor = Color.White;
            btnGuardarDiagnostico.Location = new Point(602, 359);
            btnGuardarDiagnostico.Name = "btnGuardarDiagnostico";
            btnGuardarDiagnostico.Size = new Size(115, 31);
            btnGuardarDiagnostico.TabIndex = 14;
            btnGuardarDiagnostico.Text = "GUARDAR";
            btnGuardarDiagnostico.UseVisualStyleBackColor = false;
            // 
            // btnModificarD
            // 
            btnModificarD.Anchor = AnchorStyles.None;
            btnModificarD.BackColor = Color.FromArgb(14, 93, 142);
            btnModificarD.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificarD.ForeColor = Color.White;
            btnModificarD.Location = new Point(779, 358);
            btnModificarD.Name = "btnModificarD";
            btnModificarD.Size = new Size(127, 31);
            btnModificarD.TabIndex = 15;
            btnModificarD.Text = "MODIFICAR";
            btnModificarD.UseVisualStyleBackColor = false;
            // 
            // btnEliminarD
            // 
            btnEliminarD.Anchor = AnchorStyles.None;
            btnEliminarD.BackColor = Color.FromArgb(14, 93, 142);
            btnEliminarD.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarD.ForeColor = Color.White;
            btnEliminarD.Location = new Point(963, 361);
            btnEliminarD.Name = "btnEliminarD";
            btnEliminarD.Size = new Size(115, 29);
            btnEliminarD.TabIndex = 16;
            btnEliminarD.Text = "ELIMINAR";
            btnEliminarD.UseVisualStyleBackColor = false;
            // 
            // dataDiagnostico
            // 
            dataDiagnostico.Anchor = AnchorStyles.None;
            dataDiagnostico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDiagnostico.Location = new Point(602, 459);
            dataDiagnostico.Name = "dataDiagnostico";
            dataDiagnostico.Size = new Size(686, 145);
            dataDiagnostico.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(417, 394);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Anchor = AnchorStyles.None;
            textBoxFiltro.Location = new Point(244, 175);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(215, 23);
            textBoxFiltro.TabIndex = 19;
            textBoxFiltro.TextChanged += textBoxFiltro_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(920, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 175);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 21;
            label2.Text = "Buscar Paciente";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(731, 430);
            label3.Name = "label3";
            label3.Size = new Size(166, 19);
            label3.TabIndex = 22;
            label3.Text = "Buscar Diagnostico";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(14, 93, 142);
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1115, 360);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 23;
            button1.Text = "TRATAMIENTO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Diagnostics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 616);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBoxFiltro);
            Controls.Add(dataGridView1);
            Controls.Add(dataDiagnostico);
            Controls.Add(btnEliminarD);
            Controls.Add(btnModificarD);
            Controls.Add(btnGuardarDiagnostico);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblApellidoPaciente);
            Controls.Add(lblNombrePaciente);
            Controls.Add(txtDescripcionDiagnostico);
            Controls.Add(txtSeveridadD);
            Controls.Add(txtFechaDiagnostico);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diagnostics";
            Text = "Diagnostics";
            Load += Diagnostics_Load;
            ((System.ComponentModel.ISupportInitialize)dataDiagnostico).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtFechaDiagnostico;
        private TextBox txtSeveridadD;
        private TextBox txtDescripcionDiagnostico;
        private Label lblNombrePaciente;
        private Label lblApellidoPaciente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGuardarDiagnostico;
        private Button btnModificarD;
        private Button btnEliminarD;
        private DataGridView dataDiagnostico;
        private DataGridView dataGridView1;
        private TextBox textBoxFiltro;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}