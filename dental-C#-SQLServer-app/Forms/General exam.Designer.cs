namespace dental_C__SQLServer_app.Forms
{
    partial class General_exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General_exam));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxObservaciones = new TextBox();
            button3 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            textBoxObserva = new TextBox();
            textBoxSangrado = new TextBox();
            textBoxPlaca = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxEstadodeEncias = new TextBox();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            labelNombre = new Label();
            labelApellido = new Label();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxObservaciones);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(120, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Examen General";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 1;
            label1.Text = "Observaciones";
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.Location = new Point(6, 93);
            textBoxObservaciones.Multiline = true;
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(473, 90);
            textBoxObservaciones.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(6, 201);
            button3.Name = "button3";
            button3.Size = new Size(53, 42);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBoxObserva);
            groupBox2.Controls.Add(textBoxSangrado);
            groupBox2.Controls.Add(textBoxPlaca);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxEstadodeEncias);
            groupBox2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(696, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 257);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Examen Bucal";
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(6, 201);
            button5.Name = "button5";
            button5.Size = new Size(52, 42);
            button5.TabIndex = 12;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBoxObserva
            // 
            textBoxObserva.Location = new Point(177, 173);
            textBoxObserva.Multiline = true;
            textBoxObserva.Name = "textBoxObserva";
            textBoxObserva.Size = new Size(315, 70);
            textBoxObserva.TabIndex = 7;
            // 
            // textBoxSangrado
            // 
            textBoxSangrado.Location = new Point(177, 127);
            textBoxSangrado.Name = "textBoxSangrado";
            textBoxSangrado.Size = new Size(315, 29);
            textBoxSangrado.TabIndex = 6;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(177, 80);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(315, 29);
            textBoxPlaca.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 173);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 4;
            label5.Text = "Observaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(170, 21);
            label4.TabIndex = 3;
            label4.Text = "Estado de Encias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 127);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Sangrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Placa";
            // 
            // textBoxEstadodeEncias
            // 
            textBoxEstadodeEncias.Location = new Point(177, 35);
            textBoxEstadodeEncias.Name = "textBoxEstadodeEncias";
            textBoxEstadodeEncias.Size = new Size(315, 29);
            textBoxEstadodeEncias.TabIndex = 0;
            textBoxEstadodeEncias.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle3.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(696, 341);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(515, 192);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 93, 142);
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(396, 539);
            button1.Name = "button1";
            button1.Size = new Size(122, 31);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 93, 142);
            button2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(598, 540);
            button2.Name = "button2";
            button2.Size = new Size(122, 31);
            button2.TabIndex = 5;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(14, 93, 142);
            button4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(794, 540);
            button4.Name = "button4";
            button4.Size = new Size(122, 31);
            button4.TabIndex = 7;
            button4.Text = "Siguiente";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(154, 44);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(87, 21);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(308, 44);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(93, 21);
            labelApellido.TabIndex = 11;
            labelApellido.Text = "Apellido";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle4.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(120, 341);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(494, 192);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 35);
            panel1.TabIndex = 12;
            // 
            // General_exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1289, 577);
            Controls.Add(panel1);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "General_exam";
            Text = "General_exam";
            Load += General_exam_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxObservaciones;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBoxEstadodeEncias;
        private Label label3;
        private TextBox textBoxObserva;
        private TextBox textBoxSangrado;
        private TextBox textBoxPlaca;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label labelNombre;
        private Label labelApellido;
        private Button button5;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}