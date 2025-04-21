using dental_C__SQLServer_app.Forms;
using dental_C__SQLServer_app.Database; // Usar Database donde est� la conexi�n

namespace dental_C__SQLServer_app
{
    internal static class Program
    {
        public static DatabaseHelper database = new();
        public static User user = new();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verificar si existe admin (la funci�n ahora est� en DatabaseHelper)
            if (!DatabaseHelper.AdminExists())
            {
                Application.Run(new CreateAdminForm());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}