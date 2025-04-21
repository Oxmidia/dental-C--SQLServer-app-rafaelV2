namespace dental_C__SQLServer_app.Forms
{
    partial class CreateAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            // ... otros controles
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(100, 200);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            // ... configuración de otros controles
            this.Controls.Add(this.btnCreate);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        // ... otros controles declarados
    }
}