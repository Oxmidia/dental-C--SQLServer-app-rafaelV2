using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Microsoft.Data.SqlClient;
using dental_C__SQLServer_app.Validations;
using dental_C__SQLServer_app.Classes;
using static dental_C__SQLServer_app.Classes.Encriptacion; //Para usar la BD sin crear conflicto.

namespace dental_C__SQLServer_app
{
    public partial class Register : Form
    {
        //private string query;

        public Register()
        {
            InitializeComponent();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM Register";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void reset()
        {
            txtNusuario.Text = "";
            txtCedula.Text = "";
            comboxTlf.Text = "";
            txtContrasena.Text = "";
            txtConfirmar.Text = "";
            comboxRol.Text = "";
        }
        private void txtNusuario_Enter(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "Nombre de Usuario")
            {
                txtNusuario.Clear();
                txtNusuario.ForeColor = Color.Black;
            }
        }

        private void txtNusuario_Leave(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "")
            {
                txtNusuario.Text = "Nombre de Usuario";
                txtNusuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
            }
            txtContrasena.UseSystemPasswordChar = true; //Ocultar contraseña
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirmar Contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Confirmar Contraseña";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula de Identidad")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula de Identidad";
                txtCedula.ForeColor = Color.Black;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            UserPanel re = new UserPanel();
            re.Show();
            this.Close();
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método de validación de campos
                if (!ValidarCampos())
                {
                    return; // Si las validaciones fallan, detener el proceso de registro
                }

                // Verificar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtNusuario.Text) || string.IsNullOrEmpty(txtCedula.Text) ||
                    string.IsNullOrEmpty(comboxTlf.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                    string.IsNullOrEmpty(comboxRol.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Verificar que las contraseñas coincidan
                if (txtContrasena.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Hashear la contraseña
                string hashedPassword = HashPassword(txtContrasena.Text);

                // Definir la consulta SQL
                string query = "INSERT INTO Users (Username, Cedula, Tlf, Pass, Rol) VALUES (@Username, @Cedula, @Tlf, @Pass, @Rol)";

                // Abrir la conexión
                if (Program.connection.State != System.Data.ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ejecutar la consulta
                using (var cmd = new SqlCommand(query, Program.connection))
                {
                    cmd.Parameters.AddWithValue("@Username", txtNusuario.Text);
                    cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@Tlf", comboxTlf.Text);
                    cmd.Parameters.AddWithValue("@Pass", hashedPassword); // Usar el hash
                    cmd.Parameters.AddWithValue("@Rol", comboxRol.Text);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario registrado correctamente.");
                reset(); // Limpiar los campos del formulario
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally
                //if (Program.connection.State == System.Data.ConnectionState.Open)
                //{
                //    Program.connection.Close();
                //}
            }
        }

        // Método para validar los campos
        public bool ValidarCampos()
        {
            CamposValidacion validaciones = new CamposValidacion();

            if (!validaciones.ValidarNombreUsuario(txtNusuario.Text))
            {
                MessageBox.Show("Error en el nombre de usuario.");
                return false;
            }

            if (!validaciones.ValidarCedula(txtCedula.Text))
            {
                MessageBox.Show("Error en la cédula.");
                return false;
            }

            if (!validaciones.ValidarTelefono(comboxTlf.Text))
            {
                MessageBox.Show("Error en el teléfono.");
                return false;
            }

            if (!validaciones.ValidarRol(comboxRol.Text))
            {
                MessageBox.Show("Error en el rol.");
                return false;
            }

            if (!validaciones.ValidarContrasena(txtContrasena.Text))
            {
                MessageBox.Show("Error en la Contraseña.");
                return false;
            }
            return true; // Todas las validaciones pasaron
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login re = new Login();
            re.Show();
            this.Close();
        }

    }
}