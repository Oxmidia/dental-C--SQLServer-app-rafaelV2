using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_C__SQLServer_app
{
    public partial class SowUser : Form
    {
        public SowUser()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SowUser_Load(object sender, EventArgs e)
        {
            try
            {
                // Definir la consulta SQL para seleccionar datos de la tabla newUser
                string query = "SELECT userName, Cedula, tlf, Contrasena, rol FROM newUser";

                // Crear un adaptador de datos
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.connection))
                {
                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    adapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataUser.DataSource = dataTable;

                    // Personalizar el DataGridView
                    dataUser.Columns["userName"].HeaderText = "Nombre de Usuario";
                    dataUser.Columns["Cedula"].HeaderText = "Cédula";
                    dataUser.Columns["tlf"].HeaderText = "Teléfono";
                    dataUser.Columns["Contrasena"].HeaderText = "Contraseña";
                    dataUser.Columns["rol"].HeaderText = "Rol";

                    dataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataUser.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
                // También puedes registrar el error en un archivo de log o en la consola
                Console.WriteLine(ex.ToString());
            }
        }
    }
}