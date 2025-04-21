using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app
{
    public static class RecoveryService
    {
        public static (string code, DateTime expiration) GenerateRecoveryCode()
        {
            var random = new Random();
            return (random.Next(1000, 9999).ToString(), DateTime.Now.AddMinutes(10));
        }

        public static void SaveRecoveryCode(string username, string code, DateTime expiration)
        {
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                $"{username}_recovery.tmp");

            File.WriteAllText(filePath, $"{code}|{expiration:o}");
        }

        public static bool VerifyAndConsumeCode(string username, string userCode)
        {
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                $"{username}_recovery.tmp");

            if (!File.Exists(filePath)) return false;

            string[] content = File.ReadAllText(filePath).Split('|');
            bool isValid = content[0] == userCode && DateTime.Now <= DateTime.Parse(content[1]);

            File.Delete(filePath); // Eliminar siempre después de verificar
            return isValid;
        }
    }
}