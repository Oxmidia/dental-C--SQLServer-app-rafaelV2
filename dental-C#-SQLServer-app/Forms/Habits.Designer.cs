namespace dental_C__SQLServer_app.Forms
{
    partial class Habits
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habits));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            textBoxHabito = new TextBox();
            textBoxHemorragicos = new TextBox();
            textBoxCepillado = new TextBox();
            textBoxPersonales = new TextBox();
            textBoxFamiliares = new TextBox();
            Hábito = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            label7 = new Label();
            textBoxBuscar1 = new TextBox();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 287);
            label1.Name = "label1";
            label1.Size = new Size(105, 27);
            label1.TabIndex = 0;
            label1.Text = "Hábitos";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(173, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(521, 172);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(957, 122);
            label2.Name = "label2";
            label2.Size = new Size(178, 27);
            label2.TabIndex = 2;
            label2.Text = "Antecedentes";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle2.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(738, 239);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(526, 312);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // textBoxHabito
            // 
            textBoxHabito.Anchor = AnchorStyles.None;
            textBoxHabito.Location = new Point(272, 313);
            textBoxHabito.Name = "textBoxHabito";
            textBoxHabito.Size = new Size(342, 23);
            textBoxHabito.TabIndex = 4;
            // 
            // textBoxHemorragicos
            // 
            textBoxHemorragicos.Anchor = AnchorStyles.None;
            textBoxHemorragicos.Location = new Point(891, 152);
            textBoxHemorragicos.Name = "textBoxHemorragicos";
            textBoxHemorragicos.Size = new Size(342, 23);
            textBoxHemorragicos.TabIndex = 5;
            textBoxHemorragicos.TextChanged += textBoxHemorragicos_TextChanged;
            // 
            // textBoxCepillado
            // 
            textBoxCepillado.Anchor = AnchorStyles.None;
            textBoxCepillado.Location = new Point(272, 346);
            textBoxCepillado.Name = "textBoxCepillado";
            textBoxCepillado.Size = new Size(342, 23);
            textBoxCepillado.TabIndex = 6;
            // 
            // textBoxPersonales
            // 
            textBoxPersonales.Anchor = AnchorStyles.None;
            textBoxPersonales.Location = new Point(891, 181);
            textBoxPersonales.Name = "textBoxPersonales";
            textBoxPersonales.Size = new Size(342, 23);
            textBoxPersonales.TabIndex = 7;
            // 
            // textBoxFamiliares
            // 
            textBoxFamiliares.Anchor = AnchorStyles.None;
            textBoxFamiliares.Location = new Point(891, 210);
            textBoxFamiliares.Name = "textBoxFamiliares";
            textBoxFamiliares.Size = new Size(342, 23);
            textBoxFamiliares.TabIndex = 8;
            // 
            // Hábito
            // 
            Hábito.Anchor = AnchorStyles.None;
            Hábito.AutoSize = true;
            Hábito.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hábito.Location = new Point(173, 317);
            Hábito.Name = "Hábito";
            Hábito.Size = new Size(64, 19);
            Hábito.TabIndex = 9;
            Hábito.Text = "Hábito";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 350);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 10;
            label3.Text = "Cepillado";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(763, 152);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 11;
            label4.Text = "Hemorrágicos";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(789, 181);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 12;
            label5.Text = "Personales";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(789, 210);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 13;
            label6.Text = "Familiares";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(14, 93, 142);
            button2.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(498, 565);
            button2.Name = "button2";
            button2.Size = new Size(116, 27);
            button2.TabIndex = 15;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(14, 93, 142);
            button1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(645, 565);
            button1.Name = "button1";
            button1.Size = new Size(116, 27);
            button1.TabIndex = 17;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(14, 93, 142);
            button3.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(789, 565);
            button3.Name = "button3";
            button3.Size = new Size(116, 27);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.None;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle3.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(124, 161);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(584, 114);
            dataGridView3.TabIndex = 19;
            dataGridView3.CellClick += dataGridView3_CellClick;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(204, 130);
            label7.Name = "label7";
            label7.Size = new Size(137, 19);
            label7.TabIndex = 20;
            label7.Text = "Buscar Paciente";
            // 
            // textBoxBuscar1
            // 
            textBoxBuscar1.Anchor = AnchorStyles.None;
            textBoxBuscar1.Location = new Point(374, 123);
            textBoxBuscar1.Name = "textBoxBuscar1";
            textBoxBuscar1.Size = new Size(266, 23);
            textBoxBuscar1.TabIndex = 21;
            textBoxBuscar1.TextChanged += textBoxBuscar1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
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
            panel1.TabIndex = 23;
            // 
            // Habits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1289, 616);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxBuscar1);
            Controls.Add(label7);
            Controls.Add(dataGridView3);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Hábito);
            Controls.Add(textBoxFamiliares);
            Controls.Add(textBoxPersonales);
            Controls.Add(textBoxCepillado);
            Controls.Add(textBoxHemorragicos);
            Controls.Add(textBoxHabito);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Habits";
            Text = "Habits";
            Load += Habits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private TextBox textBoxHabito;
        private TextBox textBoxHemorragicos;
        private TextBox textBoxCepillado;
        private TextBox textBoxPersonales;
        private TextBox textBoxFamiliares;
        private Label Hábito;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView3;
        private Label label7;
        private TextBox textBoxBuscar1;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}