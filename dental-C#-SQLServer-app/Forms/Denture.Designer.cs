namespace dental_C__SQLServer_app.Forms
{
    partial class Denture
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Denture));
            groupBox1 = new GroupBox();
            textBoxCaradeDiente = new TextBox();
            textBoxNombredeDiente = new TextBox();
            textBoxCuadrante = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxNumerodeaDiente = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCaradeDiente);
            groupBox1.Controls.Add(textBoxNombredeDiente);
            groupBox1.Controls.Add(textBoxCuadrante);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNumerodeaDiente);
            groupBox1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(75, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dentadura";
            // 
            // textBoxCaradeDiente
            // 
            textBoxCaradeDiente.Location = new Point(228, 220);
            textBoxCaradeDiente.Name = "textBoxCaradeDiente";
            textBoxCaradeDiente.Size = new Size(242, 29);
            textBoxCaradeDiente.TabIndex = 7;
            // 
            // textBoxNombredeDiente
            // 
            textBoxNombredeDiente.Location = new Point(228, 165);
            textBoxNombredeDiente.Name = "textBoxNombredeDiente";
            textBoxNombredeDiente.Size = new Size(242, 29);
            textBoxNombredeDiente.TabIndex = 6;
            // 
            // textBoxCuadrante
            // 
            textBoxCuadrante.Location = new Point(228, 112);
            textBoxCuadrante.Name = "textBoxCuadrante";
            textBoxCuadrante.Size = new Size(242, 29);
            textBoxCuadrante.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 173);
            label4.Name = "label4";
            label4.Size = new Size(183, 21);
            label4.TabIndex = 4;
            label4.Text = "Nombre de Diente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 66);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 3;
            label3.Text = "Número de Diente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 120);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Cuadrante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 228);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 1;
            label1.Text = "Cara de Diente";
            // 
            // textBoxNumerodeaDiente
            // 
            textBoxNumerodeaDiente.Location = new Point(228, 58);
            textBoxNumerodeaDiente.Name = "textBoxNumerodeaDiente";
            textBoxNumerodeaDiente.Size = new Size(242, 29);
            textBoxNumerodeaDiente.TabIndex = 0;
            // 
            // dataGridView1
            // 
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
            dataGridView1.Location = new Point(616, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(533, 272);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 93, 142);
            button1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(109, 433);
            button1.Name = "button1";
            button1.Size = new Size(117, 28);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(4, 93, 142);
            button2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(270, 433);
            button2.Name = "button2";
            button2.Size = new Size(117, 28);
            button2.TabIndex = 3;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(4, 93, 142);
            button3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(428, 433);
            button3.Name = "button3";
            button3.Size = new Size(117, 28);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 35);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(551, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Denture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1161, 490);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Denture";
            Text = "Denture";
            Load += Denture_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxNumerodeaDiente;
        private TextBox textBoxCaradeDiente;
        private TextBox textBoxNombredeDiente;
        private TextBox textBoxCuadrante;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}