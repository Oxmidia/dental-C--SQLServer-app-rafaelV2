namespace dental_C__SQLServer_app.Forms
{
    partial class NewPasswordForm
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
            panel2 = new Panel();
            label6 = new Label();
            btnShowPassword = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnVerify = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnShowPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNewPassword);
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(btnVerify);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 319);
            panel2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(183, 221);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 15;
            label6.Text = "Mostrar Contraseña";
            // 
            // btnShowPassword
            // 
            btnShowPassword.AutoSize = true;
            btnShowPassword.Location = new Point(314, 223);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(14, 13);
            btnShowPassword.TabIndex = 14;
            btnShowPassword.TabStop = true;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.CheckedChanged += btnShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(20, 183);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 13;
            label2.Text = "C. Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(20, 96);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 12;
            label1.Text = "N. Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(20, 27);
            label5.Name = "label5";
            label5.Size = new Size(308, 39);
            label5.TabIndex = 11;
            label5.Text = "RESTABLECIMIENTO";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(169, 95);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(159, 22);
            txtNewPassword.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(169, 182);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(159, 22);
            txtConfirmPassword.TabIndex = 10;
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
            btnVerify.Text = "GUARDAR";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnSave_Click;
            // 
            // NewPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 343);
            Controls.Add(panel2);
            Name = "NewPasswordForm";
            Text = "NewPasswordForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnVerify;
        private Label label6;
        private RadioButton btnShowPassword;
    }
}