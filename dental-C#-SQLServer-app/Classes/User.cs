using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Classes
{
    internal class User 
    {
        public object? UserID;
        public object? Username;
        public object? Cedula;
        public object? Tlf;
        public object? Rol;
        // y cualquier otra variable a la que necesiten acceder de forma global del usuario

        public void Set( object UserId, object Username, object Cedula, object Tlf, object Rol )
        {
            this.UserID = UserId;
            this.Username = Username;
            this.Cedula = Cedula;
            this.Tlf = Tlf;
            this.Rol = Rol;
        }
    }
}
