using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using dental_C__SQLServer_app.Classes;//Para conectar con la database lol
using System.Diagnostics;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using dental_C__SQLServer_app.Forms;

namespace dental_C__SQLServer_app
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        public bool AuthenticateUser(string txtuser, string txtpass)
        {
            bool isAuthenticated = false;
            string sql = "SELECT * FROM Users WHERE Username = @Username"; // Obtener el hash almacenado

            using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, Program.connection))
            {

                cmd.Parameters.AddWithValue("@Username", txtuser);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        try
                        {
                            string? hashedPasswordFromDB = (string?)reader["pass"];

                            if (hashedPasswordFromDB != null)
                            {
                                // Verificar si la contraseña coincide con el hash
                                isAuthenticated = BCrypt.Net.BCrypt.Verify(txtpass, hashedPasswordFromDB);
                                if (isAuthenticated)
                                {
                                    Program.user.Set(reader["UserId"], reader["Username"], reader["Cedula"], reader["Tlf"], reader["Rol"]);
                                }
                                Debug.WriteLine("Bienvenido " + Program.user.Username); //EJEMPLO DE USO DEL USER DE FORMA GLOBAL
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: ???aa " + ex.Message);
                        }

                    }

                    return isAuthenticated;
                    // Acceder a los datos de la consulta
                    //Console.WriteLine(reader["ColumnName"]);
                }
            }
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de usuario, para ingresar un nombre
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto:Usuario
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de contraseña, e ingresar una contraseña
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //Mostrar y ocultar la contraseña que se ha ingresado
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            try
            {
                // Verificar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Llamar al método de autenticación
                bool isAuthenticated = AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Acceso concedido. Bienvenido!");
                    // Aquí puedes redirigir al usuario a la siguiente pantalla o formulario
                    Dashboard re = new Dashboard();
                    re.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ???" + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            // Implementar la validación de campos si es necesario
            return true; // Por ahora, siempre retorna true
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SowUser re = new SowUser();
            re.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            UserPanel re = new UserPanel();
            re.Show();
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text) || txtuser.Text == "USUARIO")
            {
                MessageBox.Show("Ingresa tu nombre de usuario primero");
                return;
            }

            new RecoveryForm(txtuser.Text).Show(); // Pasa el nombre de usuario
        }
    }
}