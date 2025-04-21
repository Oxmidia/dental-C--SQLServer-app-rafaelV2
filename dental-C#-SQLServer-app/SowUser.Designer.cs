namespace dental_C__SQLServer_app
{
    partial class SowUser
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
            dataUser = new DataGridView();
            btmDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataUser).BeginInit();
            SuspendLayout();
            // 
            // dataUser
            // 
            dataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUser.Location = new Point(52, 85);
            dataUser.Name = "dataUser";
            dataUser.Size = new Size(685, 302);
            dataUser.TabIndex = 0;
            // 
            // btmDelete
            // 
            btmDelete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmDelete.Location = new Point(639, 412);
            btmDelete.Name = "btmDelete";
            btmDelete.Size = new Size(81, 26);
            btmDelete.TabIndex = 1;
            btmDelete.Text = "Eliminar";
            btmDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(519, 412);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 2;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SowUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btmDelete);
            Controls.Add(dataUser);
            Name = "SowUser";
            Text = "SowUser";
            Load += SowUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataUser;
        private Button btmDelete;
        private Button button1;
    }
}