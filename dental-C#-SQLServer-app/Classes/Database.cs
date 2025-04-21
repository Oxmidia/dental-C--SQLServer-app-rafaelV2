using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Diagnostics;


namespace dental_C__SQLServer_app.Classes
{
    internal class Database
    {
        private readonly SqlConnection DB = new();

        private static readonly string database = "histodent";
        private static readonly string user = "root3";
        private static readonly string password = "root3";
       
        private static readonly string connectionString = "Server=" + Environment.MachineName + ";Database=" + database + ";User Id=" + user +";Password=" + password + ";" + "Integrated Security=True;" + "TrustServerCertificate=True;";
        public SqlConnection Connection()
        {
            try
            {
                DB.ConnectionString = connectionString;
                DB.Open();
                //MessageBox.Show("Se conecto correctamente a la Base de Datos");
            }

            catch (Exception error)
            {
                MessageBox.Show("No se conecto correctamente a la Base de Datos, error: " + error.ToString());
                Debug.WriteLine(error);
            }
            return DB;
        }

        public void Detach()
        {
            try
            {
                DB.Close();
            } 
            catch (Exception error) 
            {
                MessageBox.Show("No se conecto correctamente a la Base de Datos, error: " + error.ToString());
                Debug.WriteLine(error);
            }
        }

    }
}