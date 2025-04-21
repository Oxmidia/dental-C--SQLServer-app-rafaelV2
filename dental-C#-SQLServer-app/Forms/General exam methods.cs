using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using dental_C__SQLServer_app.Validations.cs;
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Forms
{
    class General_exam_methods
    {
        public DataTable GeneralExam()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM generalexam";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable OralExam()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM oralexam";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public string GuardarGeneralexam(string gExamID, string observaciones, string appointmentID)
        {
            string sql = "INSERT INTO generalexam (GExamID, Observaciones, AppointmentID) VALUES (@GExamID, @Observaciones, @AppointmentID)";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@GExamID", gExamID);
                cmd.Parameters.AddWithValue("@Observaciones", observaciones);
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                ExecuteNonQuery(cmd);
            }

            return gExamID; // Devolver el ID generado
        }

        public string GuardarOralexam(string oExamID, string estadoEncias, string placa, string sangrado, string observaciones, string appointmentID)
        {
            string sql = "INSERT INTO oralexam (OExamID, EstadoEncías, Placa, Sangrado, ObservacionesB, AppointmentID) VALUES (@OExamID, @EstadoEncías, @Placa, @Sangrado, @ObservacionesB, @AppointmentID)";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@OExamID", oExamID);
                cmd.Parameters.AddWithValue("@EstadoEncías", estadoEncias);
                cmd.Parameters.AddWithValue("@Placa", placa);
                cmd.Parameters.AddWithValue("@Sangrado", sangrado);
                cmd.Parameters.AddWithValue("@ObservacionesB", observaciones);
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                ExecuteNonQuery(cmd);
            }

            return oExamID; // Devolver el ID generado
        }

        public DataTable ObtenerGeneralExamPorID(string gExamID)
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM generalexam WHERE GExamID = @GExamID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@GExamID", gExamID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable; // Devuelve un DataTable con un solo registro
        }

        public DataTable ObtenerOralExamPorID(string oExamID)
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM oralexam WHERE OExamID = @OExamID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@OExamID", oExamID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable; // Devuelve un DataTable con un solo registro
        }

        public DataTable ModificarGeneralexam(string GExamID, string Observaciones)
        {
            string Sql = "UPDATE generalexam SET observaciones = @observaciones WHERE GExamID = @GExamID";
            using (SqlCommand cmd = new SqlCommand(Sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@observaciones", Observaciones);
                cmd.Parameters.AddWithValue("@GExamID", GExamID);

                // Ejecutar la actualización
                ExecuteNonQuery(cmd);
            }

            // Obtener el registro modificado
            return ObtenerGeneralExamPorID(GExamID);
        }

        public DataTable ModificarOralexam(string oExamID, string EstadoEncías, string placa, string sangrado, string ObservacionesB)
        {
            string Sql = "UPDATE oralexam SET EstadoEncías = @EstadoEncías, placa = @placa, sangrado = @sangrado, ObservacionesB = @ObservacionesB WHERE oExamID = @oExamID";
            using (SqlCommand cmd = new SqlCommand(Sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@EstadoEncías", EstadoEncías);
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.Parameters.AddWithValue("@sangrado", sangrado);
                cmd.Parameters.AddWithValue("@ObservacionesB", ObservacionesB);
                cmd.Parameters.AddWithValue("@oExamID", oExamID);

                // Ejecutar la actualización
                ExecuteNonQuery(cmd);
            }

            // Obtener el registro modificado
            return ObtenerOralExamPorID(oExamID);
        }

        private void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                // Abrir la conexión si no está abierta
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ejecutar el comando
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar errores
                throw new Exception("Error al ejecutar el comando SQL: " + ex.Message);
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

        public void EliminarGeneraExam(string GExamID)
        {
            try
            {
                // Definir la consulta SQL para eliminar el examen
                string sql = "DELETE FROM generalexam WHERE GExamID = @GExamID";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
                {
                    // Asignar el valor del parámetro @ID
                    cmd.Parameters.AddWithValue("@GExamID", GExamID);

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
                        MessageBox.Show("El Examen General se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró El Examen General para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar El Examen General: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EliminarOralExam(string OExamID)
        {
            try
            {
                // Abrir la conexión si no está abierta
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Eliminar registros relacionados en denture
                string sqlDeleteDenture = "DELETE FROM denture WHERE OExamID = @OExamID";
                using (SqlCommand cmdDenture = new SqlCommand(sqlDeleteDenture, Program.connection))
                {
                    cmdDenture.Parameters.AddWithValue("@OExamID", OExamID);
                    cmdDenture.ExecuteNonQuery();
                }

                // Eliminar el registro en oralexam
                string sqlDeleteOralExam = "DELETE FROM oralexam WHERE OExamID = @OExamID";
                using (SqlCommand cmdOralExam = new SqlCommand(sqlDeleteOralExam, Program.connection))
                {
                    cmdOralExam.Parameters.AddWithValue("@OExamID", OExamID);
                    int filasAfectadas = cmdOralExam.ExecuteNonQuery();

                    // Verificar si se eliminó el examen correctamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Examen Oral y los registros relacionados en Denture se eliminaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró El Examen oral para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar El Examen Oral: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool ExisteGeneralExam(string appointmentID)
        {
            string query = "SELECT COUNT(*) FROM generalexam WHERE AppointmentID = @AppointmentID";
            using (SqlCommand cmd = new SqlCommand(query, Program.connection))
            {
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();
                Program.connection.Close();

                return count > 0; // Si count > 0, el registro ya existe
            }
        }

        public bool ExisteOralExam(string appointmentID)
        {
            string query = "SELECT COUNT(*) FROM oralexam WHERE AppointmentID = @AppointmentID";
            using (SqlCommand cmd = new SqlCommand(query, Program.connection))
            {
                cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

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