using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Validations
{
    public class CamposValidacion
    {
        // Método para validar el nombre de usuario
        public bool ValidarNombreUsuario(string txtNusuario)
        {
            if (string.IsNullOrWhiteSpace(txtNusuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return false;
            }

            if (txtNusuario.Length > 60)
            {
                MessageBox.Show("El nombre de usuario no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtNusuario, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras.");
                return false;
            }

            return true;
        }

        // Método para validar la cédula
        public bool ValidarCedula(string txtCedula)
        {
            if (string.IsNullOrWhiteSpace(txtCedula))
            {
                MessageBox.Show("La cédula no puede estar vacía.");
                return false;
            }

            if (!Regex.IsMatch(txtCedula, @"^\d{8}$"))
            {
                MessageBox.Show("La cédula debe contener exactamente 8 dígitos.");
                return false;
            }

            int cedula = int.Parse(txtCedula);
            if (cedula < 5338458)
            {
                MessageBox.Show("La cédula debe ser mayor o igual a 5338458.");
                return false;
            }

            return true;
        }

        // Método para validar el teléfono
        public bool ValidarTelefono(string comboxTlf)
        {
            if (string.IsNullOrWhiteSpace(comboxTlf))
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                return false;
            }

            if (!Regex.IsMatch(comboxTlf, @"^\d{11}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 11 dígitos.");
                return false;
            }

            return true;
        }
        public bool ValidarContrasena(string txtContrasena)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            if (txtContrasena.Length < 4 || txtContrasena.Length > 8)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 8 caracteres.");
                return false;
            }

            return true;
        }
        // Método para validar el rol
        public bool ValidarRol(string comboxRol)
        {
            if (string.IsNullOrWhiteSpace(comboxRol))
            {
                MessageBox.Show("El rol no puede estar vacío.");
                return false;
            }

            if (comboxRol.Length > 8)
            {
                MessageBox.Show("El rol no puede tener más de 8 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(comboxRol, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El rol solo puede contener letras.");
                return false;
            }
            return true;
        }
        public bool ValidarUsuario(string txtuser)
        {
            if (string.IsNullOrWhiteSpace(txtuser))
            {
                MessageBox.Show("El campo usuario no puede estar vacío.");
                return false;
            }

            if (txtuser.Length > 60)
            {
                MessageBox.Show("El campo usuario no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtuser, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El campo usuario solo puede contener letras.");
                return false;
            }

            return true;
        }
        public bool ValidarPass(string txtpass)
        {
            if (string.IsNullOrWhiteSpace(txtpass))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            if (txtpass.Length < 4 || txtpass.Length > 8)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 8 caracteres.");
                return false;
            }

            return true;
        }

        public bool ValidarNombrePaciente(string txtNombreP)
        {
            if (string.IsNullOrWhiteSpace(txtNombreP))
            {
                MessageBox.Show("El nombre del paciente no puede estar vacío.");
                return false;
            }

            if (txtNombreP.Length > 60)
            {
                MessageBox.Show("El nombre del paciente no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtNombreP, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre del paciente solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarApellidoPaciente(string txtApeliidoP)
        {
            if (string.IsNullOrWhiteSpace(txtApeliidoP))
            {
                MessageBox.Show("El apellido del paciente no puede estar vacío.");
                return false;
            }

            if (txtApeliidoP.Length > 60)
            {
                MessageBox.Show("El apellido del paciente no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtApeliidoP, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El apellido del paciente solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarSeveridadDiagnostico(string txtSeveridadDiagnostico)
        {
            if (string.IsNullOrWhiteSpace(txtSeveridadDiagnostico))
            {
                MessageBox.Show("El campo de severidad del diagnostico NO puede estar vacío.");
                return false;
            }

            if (txtSeveridadDiagnostico.Length > 60)
            {
                MessageBox.Show("El campo de severidad del diagnostico NO puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtSeveridadDiagnostico, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El apellido del paciente solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarFechaDiagnostico(string txtFechaDiagnostico)
        {
            if (string.IsNullOrEmpty(txtFechaDiagnostico))
            {
                MessageBox.Show("El campo fecha no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtFechaDiagnostico, @"^\d{2}/\d{2}/\d{4}$"))
            {
                MessageBox.Show("El campo fecha debe tener el formato dd/MM/yyyy y solo puede contener números y barras diagonales (/).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParseExact(txtFechaDiagnostico, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("La fecha ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool ValidarDescripcionD(string txtDescripcionDiagnostico)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionDiagnostico))
            {
                MessageBox.Show("El campo descripcion no puede estar vacío.");
                return false;
            }
            foreach (char c in txtDescripcionDiagnostico)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != ',' && c != '.' && c != ';' && c != ':')
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidarNombrePacienteT(string txtNombrePT)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePT))
            {
                MessageBox.Show("El nombre del paciente no puede estar vacío.");
                return false;
            }

            if (txtNombrePT.Length > 60)
            {
                MessageBox.Show("El nombre del paciente no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtNombrePT, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre del paciente solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarApellidoPacienteT(string txtApellidoPT)
        {
            if (string.IsNullOrWhiteSpace(txtApellidoPT))
            {
                MessageBox.Show("El apellido del paciente no puede estar vacío.");
                return false;
            }

            if (txtApellidoPT.Length > 60)
            {
                MessageBox.Show("El apellido del paciente no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtApellidoPT, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El apellido del paciente solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarNtratamiento(string txtNTratamiento)
        {
            if (string.IsNullOrWhiteSpace(txtNTratamiento))
            {
                MessageBox.Show("El nombre del Tratamiento a realizar NO puede estar vacío.");
                return false;
            }

            if (txtNTratamiento.Length > 30)
            {
                MessageBox.Show("El Tratamiento a realizar NO puede tener más de 30 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtNTratamiento, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El tratamiento solo puede contener letras.");
                return false;
            }

            return true;
        }

        public bool ValidarFechaInicio(string txtFechaInicio)
        {
            // Validar el formato de la fecha
            if (!ValidarFechaInicio(txtFechaInicio))
            {
                return false; // Si el formato no es válido, retornar false
            }

            // Convertir la fecha de inicio a DateTime
            DateTime fechaInicio = DateTime.ParseExact(txtFechaInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Verificar que la fecha de inicio no sea menor que la fecha actual
            if (fechaInicio < DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio no puede ser menor que la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool ValidarFechaFinalizacion(string txtFechaFinalizacion, string txtFechaInicio)
        {
            // Validar el formato de la fecha de finalización
            if (!ValidarFechaInicio(txtFechaFinalizacion))
            {
                return false; // Si el formato no es válido, retornar false
            }

            // Convertir las fechas a DateTime
            DateTime fechaInicio = DateTime.ParseExact(txtFechaInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime fechaFinalizacion = DateTime.ParseExact(txtFechaFinalizacion, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Verificar que la fecha de finalización no sea menor que la fecha de inicio
            if (fechaFinalizacion < fechaInicio)
            {
                MessageBox.Show("La fecha de finalización no puede ser menor que la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool ValidarPrecio(string txtPrecioT)
        {
            if (string.IsNullOrEmpty(txtPrecioT))
            {
                MessageBox.Show("El campo precio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que no haya letras
            if (Regex.IsMatch(txtPrecioT, "[a-zA-Z]"))
            {
                MessageBox.Show("El campo precio no puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el símbolo de dólar y los números
            if (txtPrecioT.Contains("$") && txtPrecioT.IndexOf("$") != 0)
            {
                MessageBox.Show("El símbolo de dólar ($) solo puede estar al inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato correcto (números con $ opcional al inicio)
            if (!Regex.IsMatch(txtPrecioT, @"^\$?\d+$"))
            {
                MessageBox.Show("El campo precio solo puede contener números y un símbolo de dólar ($) opcional al inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}