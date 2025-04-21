namespace dental_C__SQLServer_app
{
    partial class Treatments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treatments));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtPlanTratamiento = new TextBox();
            txtFechaFinalizacion = new TextBox();
            txtFechaInicio = new TextBox();
            txtPrecioT = new TextBox();
            txtNTratamiento = new TextBox();
            dataTratamiento = new DataGridView();
            lblNombrePaciente = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblApellidoPaciente = new Label();
            label7 = new Label();
            label8 = new Label();
            btnGuardarTratamiento = new Button();
            btnModificarTratamiento = new Button();
            btnEliminarTratamiento = new Button();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataTratamiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Location = new Point(373, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 93, 142);
            panel2.Location = new Point(40, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 10);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(217, 37);
            label1.Name = "label1";
            label1.Size = new Size(488, 42);
            label1.TabIndex = 3;
            label1.Text = "Tratamiento del Paciente";
            // 
            // txtPlanTratamiento
            // 
            txtPlanTratamiento.Font = new Font("Century Gothic", 12F);
            txtPlanTratamiento.Location = new Point(51, 288);
            txtPlanTratamiento.Multiline = true;
            txtPlanTratamiento.Name = "txtPlanTratamiento";
            txtPlanTratamiento.Size = new Size(463, 88);
            txtPlanTratamiento.TabIndex = 5;
            // 
            // txtFechaFinalizacion
            // 
            txtFechaFinalizacion.Font = new Font("Century Gothic", 12F);
            txtFechaFinalizacion.Location = new Point(632, 349);
            txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            txtFechaFinalizacion.Size = new Size(187, 27);
            txtFechaFinalizacion.TabIndex = 6;
            txtFechaFinalizacion.Validating += txtFechaFinalizacion_Validating;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Font = new Font("Century Gothic", 12F);
            txtFechaInicio.Location = new Point(632, 278);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(187, 27);
            txtFechaInicio.TabIndex = 7;
            txtFechaInicio.Validating += txtFechaInicio_Validating;
            // 
            // txtPrecioT
            // 
            txtPrecioT.Font = new Font("Century Gothic", 12F);
            txtPrecioT.Location = new Point(728, 195);
            txtPrecioT.Name = "txtPrecioT";
            txtPrecioT.Size = new Size(111, 27);
            txtPrecioT.TabIndex = 8;
            // 
            // txtNTratamiento
            // 
            txtNTratamiento.Font = new Font("Century Gothic", 12F);
            txtNTratamiento.Location = new Point(263, 195);
            txtNTratamiento.Name = "txtNTratamiento";
            txtNTratamiento.Size = new Size(336, 27);
            txtNTratamiento.TabIndex = 9;
            // 
            // dataTratamiento
            // 
            dataTratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTratamiento.Location = new Point(51, 473);
            dataTratamiento.Name = "dataTratamiento";
            dataTratamiento.Size = new Size(807, 114);
            dataTratamiento.TabIndex = 18;
            dataTratamiento.CellClick += dataTratamiento_CellClick;
            dataTratamiento.CellContentClick += dataTratamiento_CellContentClick;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePaciente.Location = new Point(147, 140);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(77, 21);
            lblNombrePaciente.TabIndex = 19;
            lblNombrePaciente.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 264);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 20;
            label3.Text = "Plan de Tratamiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 198);
            label4.Name = "label4";
            label4.Size = new Size(206, 21);
            label4.TabIndex = 21;
            label4.Text = "Nombre del Tratamiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(661, 198);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 22;
            label5.Text = "Precio:";
            // 
            // lblApellidoPaciente
            // 
            lblApellidoPaciente.AutoSize = true;
            lblApellidoPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaciente.Location = new Point(436, 140);
            lblApellidoPaciente.Name = "lblApellidoPaciente";
            lblApellidoPaciente.Size = new Size(78, 21);
            lblApellidoPaciente.TabIndex = 23;
            lblApellidoPaciente.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(632, 254);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 24;
            label7.Text = "Fecha de Inicio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(638, 325);
            label8.Name = "label8";
            label8.Size = new Size(181, 21);
            label8.TabIndex = 25;
            label8.Text = "Fecha de Finalizacion:";
            // 
            // btnGuardarTratamiento
            // 
            btnGuardarTratamiento.BackColor = Color.Navy;
            btnGuardarTratamiento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTratamiento.ForeColor = Color.White;
            btnGuardarTratamiento.Location = new Point(57, 427);
            btnGuardarTratamiento.Name = "btnGuardarTratamiento";
            btnGuardarTratamiento.Size = new Size(115, 31);
            btnGuardarTratamiento.TabIndex = 26;
            btnGuardarTratamiento.Text = "GUARDAR";
            btnGuardarTratamiento.UseVisualStyleBackColor = false;
            btnGuardarTratamiento.Click += btnGuardarTratamiento_Click;
            // 
            // btnModificarTratamiento
            // 
            btnModificarTratamiento.BackColor = Color.Navy;
            btnModificarTratamiento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarTratamiento.ForeColor = Color.White;
            btnModificarTratamiento.Location = new Point(217, 427);
            btnModificarTratamiento.Name = "btnModificarTratamiento";
            btnModificarTratamiento.Size = new Size(115, 31);
            btnModificarTratamiento.TabIndex = 27;
            btnModificarTratamiento.Text = "MODIFICAR";
            btnModificarTratamiento.UseVisualStyleBackColor = false;
            btnModificarTratamiento.Click += btnModificarTratamiento_Click;
            // 
            // btnEliminarTratamiento
            // 
            btnEliminarTratamiento.BackColor = Color.Navy;
            btnEliminarTratamiento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarTratamiento.ForeColor = Color.White;
            btnEliminarTratamiento.Location = new Point(373, 427);
            btnEliminarTratamiento.Name = "btnEliminarTratamiento";
            btnEliminarTratamiento.Size = new Size(115, 31);
            btnEliminarTratamiento.TabIndex = 28;
            btnEliminarTratamiento.Text = "ELIMINAR";
            btnEliminarTratamiento.UseVisualStyleBackColor = false;
            btnEliminarTratamiento.Click += btnEliminarTratamiento_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Treatments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 616);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminarTratamiento);
            Controls.Add(btnModificarTratamiento);
            Controls.Add(btnGuardarTratamiento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblApellidoPaciente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombrePaciente);
            Controls.Add(dataTratamiento);
            Controls.Add(txtNTratamiento);
            Controls.Add(txtPrecioT);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtFechaFinalizacion);
            Controls.Add(txtPlanTratamiento);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Treatments";
            Text = "Treatments";
            Load += Treatments_Load;
            ((System.ComponentModel.ISupportInitialize)dataTratamiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtPlanTratamiento;
        private TextBox txtFechaFinalizacion;
        private TextBox txtFechaInicio;
        private TextBox txtPrecioT;
        private TextBox txtNTratamiento;
        private DataGridView dataTratamiento;
        private Label lblNombrePaciente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblApellidoPaciente;
        private Label label7;
        private Label label8;
        private Button btnGuardarTratamiento;
        private Button btnModificarTratamiento;
        private Button btnEliminarTratamiento;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}