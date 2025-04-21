using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Forms.habits_methods
{
    class CHabits
    {
        public DataTable Habits()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM habits";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable Antecedents()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM antecedents";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable patients()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM patients";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }


        public bool ExistePatientIDEnHabits(string patientID)
        {
            string sql = "SELECT COUNT(*) FROM habits WHERE PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();

                // Cerrar la conexión
                Program.connection.Close();

                return count > 0; // Si count > 0, el PatientID ya existe en habits
            }
        }

        public bool ExistePatientIDEnAntecedents(string patientID)
        {
            string sql = "SELECT COUNT(*) FROM antecedents WHERE PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();

                // Cerrar la conexión
                Program.connection.Close();

                return count > 0; // Si count > 0, el PatientID ya existe en antecedents
            }
        }

        public void GuardarHabits(string HabitsID, string NombreH, string Cepillado, string PatientID)
        {
            if (ExistePatientIDEnHabits(PatientID))
            {
                MessageBox.Show("Ya existe un registro de hábitos para este paciente.");
                return;
            }

            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO habits (HabitsID, NombreH, Cepillado, PatientID) VALUES (@HabitsID, @NombreH, @Cepillado, @PatientID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@HabitsID", hexValue);
                CMD.Parameters.AddWithValue("@NombreH", NombreH);
                CMD.Parameters.AddWithValue("@Cepillado", Cepillado);
                CMD.Parameters.AddWithValue("@PatientID", PatientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                CMD.ExecuteNonQuery();

                // Cerrar la conexión
                Program.connection.Close();
            }
        }

        public void GuardarAntecedents(string AntecedentsID, string Hemorrágicos, string Personales, string Familiares, string PatientID)
        {
            if (ExistePatientIDEnAntecedents(PatientID))
            {
                MessageBox.Show("Ya existe un registro de antecedentes para este paciente.");
                return;
            }

            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO antecedents (AntecedentsID, Hemorrágicos, Personales, Familiares, PatientID) VALUES (@AntecedentsID, @Hemorrágicos, @Personales, @Familiares, @PatientID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@AntecedentsID", hexValue);
                CMD.Parameters.AddWithValue("@Hemorrágicos", Hemorrágicos);
                CMD.Parameters.AddWithValue("@Personales", Personales);
                CMD.Parameters.AddWithValue("@Familiares", Familiares);
                CMD.Parameters.AddWithValue("@PatientID", PatientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                CMD.ExecuteNonQuery();

                // Cerrar la conexión
                Program.connection.Close();
            }
        }




        public DataTable ModificarHabits(string habitsID, string nombreH, string cepillado)
        {
            string Sql = "UPDATE habits SET NombreH = @NombreH, Cepillado = @Cepillado WHERE HabitsID = @HabitsID";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@NombreH", nombreH);
                CMD.Parameters.AddWithValue("@Cepillado", cepillado);
                CMD.Parameters.AddWithValue("@HabitsID", habitsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                CMD.ExecuteNonQuery();
                Program.connection.Close();
            }

            // Devolver el registro actualizado
            return Habits();
        }

        public DataTable ModificarAntecedents(string antecedentsID, string hemorrágicos, string personales, string familiares)
        {
            string Sql = "UPDATE antecedents SET Hemorrágicos = @Hemorrágicos, Personales = @Personales, Familiares = @Familiares WHERE AntecedentsID = @AntecedentsID";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@Hemorrágicos", hemorrágicos);
                CMD.Parameters.AddWithValue("@Personales", personales);
                CMD.Parameters.AddWithValue("@Familiares", familiares);
                CMD.Parameters.AddWithValue("@AntecedentsID", antecedentsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                CMD.ExecuteNonQuery();
                Program.connection.Close();
            }

            // Devolver el registro actualizado
            return Antecedents();
        }




        public void EliminarHabits(string habitsID)
        {
            // Obtener el PatientID asociado al HabitsID
            string patientID = ObtenerPatientIDDesdeHabits(habitsID);

            if (string.IsNullOrEmpty(patientID))
            {
                MessageBox.Show("No se pudo obtener el PatientID asociado al HabitsID.");
                return;
            }

            // Eliminar el registro de Habits
            string sqlHabits = "DELETE FROM habits WHERE HabitsID = @HabitsID";
            using (SqlCommand cmd = new SqlCommand(sqlHabits, Program.connection))
            {
                cmd.Parameters.AddWithValue("@HabitsID", habitsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                cmd.ExecuteNonQuery();
            }

            // Eliminar el registro correspondiente en Antecedents
            string sqlAntecedents = "DELETE FROM antecedents WHERE PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sqlAntecedents, Program.connection))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAntecedents(string antecedentsID)
        {
            // Obtener el PatientID asociado al AntecedentsID
            string patientID = ObtenerPatientIDDesdeAntecedents(antecedentsID);

            if (string.IsNullOrEmpty(patientID))
            {
                MessageBox.Show("No se pudo obtener el PatientID asociado al AntecedentsID.");
                return;
            }

            // Eliminar el registro de Antecedents
            string sqlAntecedents = "DELETE FROM antecedents WHERE AntecedentsID = @AntecedentsID";
            using (SqlCommand cmd = new SqlCommand(sqlAntecedents, Program.connection))
            {
                cmd.Parameters.AddWithValue("@AntecedentsID", antecedentsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                cmd.ExecuteNonQuery();
            }

            // Eliminar el registro correspondiente en Habits
            string sqlHabits = "DELETE FROM habits WHERE PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sqlHabits, Program.connection))
            {
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                cmd.ExecuteNonQuery();
            }
        }

        private string ObtenerPatientIDDesdeHabits(string habitsID)
        {
            string patientID = null;
            string sql = "SELECT PatientID FROM habits WHERE HabitsID = @HabitsID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@HabitsID", habitsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patientID = reader["PatientID"].ToString();
                    }
                }
            }
            return patientID;
        }

        private string ObtenerPatientIDDesdeAntecedents(string antecedentsID)
        {
            string patientID = null;
            string sql = "SELECT PatientID FROM antecedents WHERE AntecedentsID = @AntecedentsID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@AntecedentsID", antecedentsID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patientID = reader["PatientID"].ToString();
                    }
                }
            }
            return patientID;
        }

        public bool ExisteHabit(string nombreH, string cepillado, string patientID)
        {
            string sql = "SELECT COUNT(*) FROM habits WHERE NombreH = @NombreH AND Cepillado = @Cepillado AND PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@NombreH", nombreH);
                cmd.Parameters.AddWithValue("@Cepillado", cepillado);
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();

                // Cerrar la conexión
                Program.connection.Close();

                return count > 0; // Si count > 0, el registro ya existe
            }
        }

        public bool ExisteAntecedent(string hemorrágicos, string personales, string familiares, string patientID)
        {
            string sql = "SELECT COUNT(*) FROM antecedents WHERE Hemorrágicos = @Hemorrágicos AND Personales = @Personales AND Familiares = @Familiares AND PatientID = @PatientID";
            using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
            {
                cmd.Parameters.AddWithValue("@Hemorrágicos", hemorrágicos);
                cmd.Parameters.AddWithValue("@Personales", personales);
                cmd.Parameters.AddWithValue("@Familiares", familiares);
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                int count = (int)cmd.ExecuteScalar();

                // Cerrar la conexión
                Program.connection.Close();

                return count > 0; // Si count > 0, el registro ya existe
            }
        }

    }
}