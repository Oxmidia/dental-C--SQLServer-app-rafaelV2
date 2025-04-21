namespace dental_C__SQLServer_app
{
    partial class Patients
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnReporte = new Button();
            comboBoxSexo = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textTelefono = new TextBox();
            textFechaDeNacimiento = new TextBox();
            textDirección = new TextBox();
            textCédula = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            dtGridViewpatients = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            textBoxBuscar = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 137);
            label1.Name = "label1";
            label1.Size = new Size(365, 36);
            label1.TabIndex = 0;
            label1.Text = "Registro De Pacientes";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnReporte);
            groupBox1.Controls.Add(comboBoxSexo);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textFechaDeNacimiento);
            groupBox1.Controls.Add(textDirección);
            groupBox1.Controls.Add(textCédula);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 414);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(4, 93, 142);
            btnReporte.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = SystemColors.ControlLightLight;
            btnReporte.Location = new Point(392, 368);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(81, 23);
            btnReporte.TabIndex = 20;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Anchor = AnchorStyles.None;
            comboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Items.AddRange(new object[] { "Femenino ", "Maculino" });
            comboBoxSexo.Location = new Point(109, 281);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(159, 29);
            comboBoxSexo.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(4, 93, 142);
            button3.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(284, 368);
            button3.Name = "button3";
            button3.Size = new Size(81, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(4, 93, 142);
            button2.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(179, 368);
            button2.Name = "button2";
            button2.Size = new Size(81, 23);
            button2.TabIndex = 17;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 93, 142);
            button1.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(83, 368);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textTelefono
            // 
            textTelefono.Anchor = AnchorStyles.None;
            textTelefono.Location = new Point(370, 213);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(140, 29);
            textTelefono.TabIndex = 16;
            textTelefono.Validating += textTelefono_Validating;
            // 
            // textFechaDeNacimiento
            // 
            textFechaDeNacimiento.Anchor = AnchorStyles.None;
            textFechaDeNacimiento.Location = new Point(370, 143);
            textFechaDeNacimiento.Name = "textFechaDeNacimiento";
            textFechaDeNacimiento.Size = new Size(140, 29);
            textFechaDeNacimiento.TabIndex = 13;
            textFechaDeNacimiento.TextChanged += textFechaDeNacimiento_TextChanged;
            textFechaDeNacimiento.Validating += textFechaDeNacimiento_Validating;
            // 
            // textDirección
            // 
            textDirección.Location = new Point(111, 213);
            textDirección.Name = "textDirección";
            textDirección.Size = new Size(159, 29);
            textDirección.TabIndex = 12;
            // 
            // textCédula
            // 
            textCédula.Anchor = AnchorStyles.None;
            textCédula.Location = new Point(109, 143);
            textCédula.Name = "textCédula";
            textCédula.Size = new Size(159, 29);
            textCédula.TabIndex = 9;
            textCédula.TextChanged += textBox1_TextChanged;
            textCédula.Validating += textCédula_Validating;
            // 
            // textApellido
            // 
            textApellido.Anchor = AnchorStyles.None;
            textApellido.Location = new Point(370, 69);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 29);
            textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Anchor = AnchorStyles.None;
            textNombre.Location = new Point(109, 69);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(159, 29);
            textNombre.TabIndex = 11;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 289);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 7;
            label9.Text = "Sexo";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(289, 221);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 6;
            label8.Text = "Teléfono";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 227);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 4;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 151);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 3;
            label5.Text = "Cédula";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(289, 151);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 2;
            label4.Text = "F. De Nac.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(835, 84);
            label10.Name = "label10";
            label10.Size = new Size(301, 36);
            label10.TabIndex = 8;
            label10.Text = "Lista de Pacientes";
            // 
            // dtGridViewpatients
            // 
            dtGridViewpatients.Anchor = AnchorStyles.None;
            dtGridViewpatients.BackgroundColor = Color.White;
            dtGridViewpatients.BorderStyle = BorderStyle.None;
            dtGridViewpatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtGridViewpatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtGridViewpatients.ColumnHeadersHeight = 30;
            dtGridViewpatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGridViewpatients.EnableHeadersVisualStyles = false;
            dtGridViewpatients.Location = new Point(610, 183);
            dtGridViewpatients.Name = "dtGridViewpatients";
            dtGridViewpatients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtGridViewpatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtGridViewpatients.Size = new Size(683, 414);
            dtGridViewpatients.TabIndex = 9;
            dtGridViewpatients.CellClick += Datagr;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(724, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Anchor = AnchorStyles.None;
            textBoxBuscar.Location = new Point(860, 145);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(289, 23);
            textBoxBuscar.TabIndex = 12;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(762, 143);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 13;
            label7.Text = "Buscar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1305, 35);
            panel1.TabIndex = 21;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 616);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(textBoxBuscar);
            Controls.Add(dtGridViewpatients);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patients";
            Text = "Patients";
            Load += Patients_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textTelefono;
        private TextBox textFechaDeNacimiento;
        private TextBox textDirección;
        private TextBox textCédula;
        private TextBox textApellido;
        private TextBox textNombre;
        private DataGridView dtGridViewpatients;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
        private ComboBox comboBoxSexo;
        private Label label7;
        private TextBox textBoxBuscar;
        private Button btnReporte;
        private Panel panel1;
    }
}