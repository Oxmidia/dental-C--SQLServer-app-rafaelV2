namespace dental_C__SQLServer_app.Forms
{
    partial class RecoveryForm
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
            btnVerify = new Button();
            txtUsername = new TextBox();
            txtCode = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.DarkSlateGray;
            btnVerify.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerify.ForeColor = Color.White;
            btnVerify.Location = new Point(61, 261);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(237, 34);
            btnVerify.TabIndex = 8;
            btnVerify.Text = "VERIFICAR";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(134, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 22);
            txtUsername.TabIndex = 9;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(134, 181);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(164, 22);
            txtCode.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtCode);
            panel2.Controls.Add(btnVerify);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 319);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(44, 183);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 13;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(44, 99);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 12;
            label1.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(44, 27);
            label5.Name = "label5";
            label5.Size = new Size(264, 39);
            label5.TabIndex = 11;
            label5.Text = "RECUPERACIÓN";
            // 
            // RecoveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(371, 343);
            Controls.Add(panel2);
            Name = "RecoveryForm";
            Text = "RecoveryForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerify;
        private TextBox txtUsername;
        private TextBox txtCode;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label2;
    }
}