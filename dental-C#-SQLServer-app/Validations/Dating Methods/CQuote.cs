using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TextBox = System.Windows.Forms.TextBox;

namespace dental_C__SQLServer_app.Validations.Dating_methods
{
    internal class CQuote
    {
        public DataTable Cita()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM Appointments";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable pacientes()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM patients";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public void InsertarCita(string AppointmentID, string nombre, string apellido, string Motivo, string Fecha, string Hora, string PatientID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO Appointments (AppointmentID, Nombre, Apellido,Motivo,Fecha,Hora,PatientID) VALUES (@AppointmentID, @Nombre, @Apellido,@Motivo,@Fecha,@Hora,@PatientID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@AppointmentID", hexValue);
                CMD.Parameters.AddWithValue("@Nombre", nombre);
                CMD.Parameters.AddWithValue("@Apellido", apellido);
                CMD.Parameters.AddWithValue("@Motivo", Motivo);
                CMD.Parameters.AddWithValue("@Fecha", Fecha);
                CMD.Parameters.AddWithValue("@Hora", Hora);
                CMD.Parameters.AddWithValue("@PatientID", PatientID);


                // Abrir la conexión si no está abierta
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ejecutar la consulta
                CMD.ExecuteNonQuery();

                // Cerrar la conexión
                Program.connection.Close();
            }
        }
        public string Seleccionar(DataGridView dataGridView1, TextBox textBoxNombre, TextBox textBoxApellido, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora)
        {
            try
            {
                // Validar que se haya seleccionado una fila válida
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                {
                    // Asignar los valores de las celdas a los TextBox

                    textBoxNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    textBoxApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                    textBoxMotivo.Text = dataGridView1.CurrentRow.Cells["Motivo"].Value?.ToString() ?? string.Empty;
                    textBoxFecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value?.ToString() ?? string.Empty;
                    textBoxHora.Text = dataGridView1.CurrentRow.Cells["Hora"].Value?.ToString() ?? string.Empty;


                    // Devolver el ID seleccionado
                    return dataGridView1.CurrentRow.Cells["AppointmentID"].Value?.ToString() ?? string.Empty;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No se ha seleccionado una fila válida.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al seleccionar la fila: {ex.Message}");
                MessageBox.Show($"Error al seleccionar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public void Modificar(string appointmentID, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora)
        {
            try
            {
                // Validar que el AppointmentID no esté vacío
                if (string.IsNullOrEmpty(appointmentID))
                {
                    MessageBox.Show("El ID de la cita no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Definir la consulta SQL para actualizar Motivo, Fecha y Hora
                string query = @"
            UPDATE Appointments
            SET 
                Motivo = @Motivo, 
                Fecha = @Fecha, 
                Hora = @Hora 
            WHERE 
                AppointmentID = @AppointmentID"; // Asegúrate de actualizar solo el registro correcto

                // Crear y configurar el comando SQL
                using (SqlCommand cmd = new SqlCommand(query, Program.connection))
                {
                    // Asignar los valores de los TextBox a los parámetros del comando
                    cmd.Parameters.AddWithValue("@Motivo", textBoxMotivo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fecha", textBoxFecha.Text.Trim());
                    cmd.Parameters.AddWithValue("@Hora", textBoxHora.Text.Trim());
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    // Abrir la conexión si no está abierta
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    // Ejecutar la consulta y obtener el número de filas afectadas
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Verificar si se realizó la actualización correctamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Los datos se modificaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al modificar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

        public void EliminarCita(string AppointmentID)
        {
            try
            {
                // Definir la consulta SQL para eliminar la cita
                string sql = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
                {
                    // Asignar el valor del parámetro @ID
                    cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    // Abrir la conexión si no está abierta
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Verificar si se eliminó la cita correctamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La cita se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la cita para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

        public bool ExisteRegistro(string patientID, string fecha, string hora)
        {
            string query = @"
        SELECT COUNT(*) 
        FROM Appointments 
        WHERE PatientID = @PatientID 
          AND Fecha = @Fecha 
          AND Hora = @Hora";

            using (SqlCommand cmd = new SqlCommand(query, Program.connection))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientID);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Hora", hora);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();
                Program.connection.Close();

                return count > 0; // Si count > 0, el registro ya existe
            }
        }
    }
}