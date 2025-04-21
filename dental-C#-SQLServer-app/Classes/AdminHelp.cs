using System;
using System.Data.SqlClient;

namespace DentalApp.Classes
{
    public static class AdminHelper
    {
        // Usa la misma conexión que Database.cs
        private static string connectionString = Database.ConnectionString;

        public static bool AdminExists()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admin", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool CreateAdmin(
            string username,
            string password,
            string question1,
            string answer1,
            string question2,
            string answer2)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Admin 
                                   (Username, Password, SecurityQuestion1, SecurityAnswer1, 
                                    SecurityQuestion2, SecurityAnswer2) 
                                   VALUES 
                                   (@User, @Pass, @Q1, @A1, @Q2, @A2)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", username);
                        cmd.Parameters.AddWithValue("@Pass", PasswordHasher.Hash(password)); // ¡Usa el mismo hasher del proyecto!
                        cmd.Parameters.AddWithValue("@Q1", question1);
                        cmd.Parameters.AddWithValue("@A1", PasswordHasher.Hash(answer1)); // Hashear respuestas
                        cmd.Parameters.AddWithValue("@Q2", question2);
                        cmd.Parameters.AddWithValue("@A2", PasswordHasher.Hash(answer2));

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex); // Usa el logger existente del proyecto
                return false;
            }
        }
    }
}