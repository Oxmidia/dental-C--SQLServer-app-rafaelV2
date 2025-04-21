using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Classes
{
    class CTreatments
    {
        public DataTable tratamiento(string diagnosticsID = null)
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM treatments";

            // Si se proporciona un diagnosticsID, filtrar por él
            if (!string.IsNullOrEmpty(diagnosticsID))
            {
                Sql += " WHERE DiagnosticsID = @DiagnosticsID";
            }

            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);

            // Si hay un diagnosticsID, agregar el parámetro
            if (!string.IsNullOrEmpty(diagnosticsID))
            {
                CMD.Parameters.AddWithValue("@DiagnosticsID", diagnosticsID);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(CMD);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void InsertarTratamiento(string TreatmentID, string NombreTratamiento, string PlanTratamiento, string FechaInicio, string FechaFinal, string Precio, string DiagnosticsID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO treatments (TreatmentID,NombreTratamiento , PlanTratamiento,FechaInicio,FechaFinal,Precio,DiagnosticsID) VALUES (@TreatmentID,@NombreTratamiento , @PlanTratamiento,@FechaInicio,@FechaFinal,@Precio,@DiagnosticsID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@TreatmentID", hexValue);
                CMD.Parameters.AddWithValue("@NombreTratamiento", NombreTratamiento);
                CMD.Parameters.AddWithValue("@PlanTratamiento", PlanTratamiento);
                CMD.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                CMD.Parameters.AddWithValue("@FechaFinal", FechaFinal);
                CMD.Parameters.AddWithValue("@Precio", Precio);

                CMD.Parameters.AddWithValue("@DiagnosticsID", DiagnosticsID);


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

        public void Modificar(string TreatmentID, TextBox txtNTratamiento, TextBox txtPlanTratamiento, TextBox txtFechaInicio, TextBox txtFechaFinalizacion, TextBox txtPrecioT)
        {
            try
            {
                // Validar que el AppointmentID no esté vacío
                if (string.IsNullOrEmpty(TreatmentID))
                {
                    MessageBox.Show("El ID de la cita no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Definir la consulta SQL para actualizar Motivo, Fecha y Hora
                string query = @"
            UPDATE treatments
            SET 
                NombreTratamiento = @NombreTratamiento, 
                PlanTratamiento = @PlanTratamiento, 
                FechaInicio = @FechaInicio,
                 FechaFinal= @FechaFinal,
                 Precio = @Precio
            WHERE 
                TreatmentID = @TreatmentID"; // Asegúrate de actualizar solo el registro correcto

                // Crear y configurar el comando SQL
                using (SqlCommand cmd = new SqlCommand(query, Program.connection))
                {
                    // Asignar los valores de los TextBox a los parámetros del comando
                    cmd.Parameters.AddWithValue("@NombreTratamiento", txtNTratamiento.Text.Trim());
                    cmd.Parameters.AddWithValue("@PlanTratamiento", txtPlanTratamiento.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaInicio", txtFechaInicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaFinal", txtFechaFinalizacion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Precio", txtPrecioT.Text.Trim());
                    cmd.Parameters.AddWithValue("@TreatmentID", TreatmentID);

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

        public void Eliminar(string TreatmentID)
        {
            try
            {
                // Definir la consulta SQL para eliminar la cita
                string sql = "DELETE FROM treatments WHERE TreatmentID = @TreatmentID";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
                {
                    // Asignar el valor del parámetro @ID
                    cmd.Parameters.AddWithValue("@TreatmentID", TreatmentID);

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
                        MessageBox.Show("el tratamiento se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el tratamiento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar el tratamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool ExisteTratamientoConMismoDiagnostico(string diagnosticsID)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM treatments WHERE DiagnosticsID = @DiagnosticsID";

                using (SqlCommand command = new SqlCommand(query, Program.connection))
                {
                    command.Parameters.AddWithValue("@DiagnosticsID", diagnosticsID);

                    // Abrir la conexión si no está abierta
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
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

    }
}
