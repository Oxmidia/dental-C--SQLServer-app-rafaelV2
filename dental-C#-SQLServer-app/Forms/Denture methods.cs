using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Forms
{
    class Denture_methods
    {
        public DataTable Denture(string OExamID)
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM denture WHERE OExamID = @OExamID";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@OExamID", OExamID);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public void GuardarDenture(string NumFDI, string CuadranteD, string NombreD, string caraD, string OExamID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO denture (DentureID,NumFDI,CuadranteD,NombreD,caraD, OExamID) VALUES (@DentureID,@NumFDI,@CuadranteD,@NombreD,@caraD, @OExamID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("DentureID", hexValue);
                CMD.Parameters.AddWithValue("@NumFDI", NumFDI);
                CMD.Parameters.AddWithValue("@CuadranteD", CuadranteD);
                CMD.Parameters.AddWithValue("@NombreD", NombreD);
                CMD.Parameters.AddWithValue("@caraD", caraD);
                CMD.Parameters.AddWithValue("@OExamID", OExamID);


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

        public void Modificar(string DentureID, TextBox textBoxNumerodeaDiente, TextBox textBoxCuadrante,
                     TextBox textBoxNombredeDiente, TextBox textBoxCaradeDiente,
                     string OExamID)
        {
            try
            {
                if (string.IsNullOrEmpty(DentureID) || string.IsNullOrEmpty(OExamID))
                {
                    MessageBox.Show("Se requieren tanto el ID de examen como el ID de Dentadura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
            UPDATE denture
            SET 
                NumFDI = @NumFDI,
                CuadranteD = @CuadranteD, 
                NombreD = @NombreD, 
                caraD = @caraD
            WHERE 
                OExamID = @OExamID AND DentureID = @DentureID";

                using (SqlCommand CMD = new SqlCommand(query, Program.connection))
                {
                    CMD.Parameters.AddWithValue("@DentureID", DentureID);
                    CMD.Parameters.AddWithValue("@NumFDI", textBoxNumerodeaDiente.Text.Trim());
                    CMD.Parameters.AddWithValue("@CuadranteD", textBoxCuadrante.Text.Trim());
                    CMD.Parameters.AddWithValue("@NombreD", textBoxNombredeDiente.Text.Trim());
                    CMD.Parameters.AddWithValue("@caraD", textBoxCaradeDiente.Text.Trim());
                    CMD.Parameters.AddWithValue("@OExamID", OExamID);

                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    int filasAfectadas = CMD.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Diente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el diente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

        public void Eliminar(string OExamID, string DentureID)
        {
            try
            {
                string sql = "DELETE FROM denture WHERE OExamID = @OExamID AND DentureID = @DentureID";

                using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
                {
                    cmd.Parameters.AddWithValue("@OExamID", OExamID);
                    cmd.Parameters.AddWithValue("@DentureID", DentureID);

                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Diente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el diente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

    }
}