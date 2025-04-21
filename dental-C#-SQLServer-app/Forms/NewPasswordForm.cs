using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_C__SQLServer_app.Forms
{
    public partial class NewPasswordForm : Form
    {
        private readonly string _username;

        public NewPasswordForm(string username)
        {
            InitializeComponent();
            _username = username;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                string query = "UPDATE Users SET Pass = @Password WHERE Username = @Username";
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, Program.connection))
                {
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Username", _username);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            if (!ValidatePassword(txtNewPassword.Text))
            {
                MessageBox.Show("La contraseña debe tener:\n- Mínimo 8 caracteres\n- Al menos 1 mayúscula\n- Al menos 1 número",
                              "Requisitos no cumplidos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            if (UpdatePasswordInDatabase(txtNewPassword.Text))
            {
                MessageBox.Show("Contraseña actualizada exitosamente",
                              "Éxito",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !btnShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !btnShowPassword.Checked;
        }
    }
}
