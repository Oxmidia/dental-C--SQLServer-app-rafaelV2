using dental_C__SQLServer_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Data.SqlClient;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace dental_C__SQLServer_app
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            textBoxBuscar.TextChanged += new EventHandler(textBoxBuscar_TextChanged);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            dtGridViewpatients.DataSource = Index();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM patients";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textCédula.Text = "";
            textFechaDeNacimiento.Text = "";
            textDirección.Text = "";
            textTelefono.Text = "";
            comboBoxSexo.Text = "";
        }

        public string Query;
        public Microsoft.Data.SqlClient.SqlCommand Operation;


        private bool PacienteYaRegistrado(string cedula, string nombre, string apellido)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM patients WHERE Cédula = @Cedula OR (Nombre = @Nombre AND Apellido = @Apellido)";
                using (SqlCommand cmd = new SqlCommand(query, Program.connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void button1_Click(object sender, EventArgs e)
        {

            MensajeBorrar();

            if (PacienteYaRegistrado(textCédula.Text, textNombre.Text, textApellido.Text))
            {
                // Mostrar mensaje de error
                MessageBox.Show("Este paciente ya está registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (validarcampos())
            {
                Guid guid = Guid.NewGuid();
                string hexValue = guid.ToString("N");

                Query = "INSERT INTO patients (PatientID,Nombre,Apellido,Cédula,FechaDeNacimiento,Edad,Dirección,Telefono,Sexo) VALUES (@PatientID,@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Edad,@Dirección,@Telefono,@Sexo)";
                Operation = new Microsoft.Data.SqlClient.SqlCommand(Query, Program.connection);

                Operation.Parameters.AddWithValue("@PatientID", hexValue);
                Operation.Parameters.AddWithValue("@Nombre", textNombre.Text);
                Operation.Parameters.AddWithValue("@Apellido", textApellido.Text);
                Operation.Parameters.AddWithValue("@Cédula", textCédula.Text);
                Operation.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
                Operation.Parameters.AddWithValue("@Dirección", textDirección.Text);
                Operation.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                Operation.Parameters.AddWithValue("@Sexo", value: comboBoxSexo.Text);
                Operation.Parameters.AddWithValue("@Edad", Age);

                Operation.ExecuteNonQuery();
                MessageBox.Show("Los Datos Fueron Guardados Correctamente");

                dtGridViewpatients.DataSource = Index();
                reset();
            }
        }
        public int Age;
        private bool validarcampos()
        {
            bool validado = true;

            if (textNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textNombre, "Ingresar Nombre");
            }

            if (textApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textApellido, "Ingresar Apellido");
            }

            if (textCédula.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textCédula, "Ingresar Cédula");
            }

            if (textFechaDeNacimiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textFechaDeNacimiento, "Ingresar Fecha De Nacimiento");
   
            }

      

            if (textDirección.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textDirección, "Ingresar Dirección");
            }

            if (textTelefono.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textTelefono, "Ingresar Teléfono");
            }

            if (comboBoxSexo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(comboBoxSexo, "Ingresar Sexo");
            }

            return validado;
        }

        private void MensajeBorrar()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textCédula, "");
            errorProvider1.SetError(textFechaDeNacimiento, "");
            errorProvider1.SetError(textDirección, "");
            errorProvider1.SetError(textTelefono, "");
            errorProvider1.SetError(comboBoxSexo, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datagr(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("CURRENT ROW:", dtGridViewpatients.CurrentRow);
                Text = dtGridViewpatients.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dtGridViewpatients.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = dtGridViewpatients.CurrentRow.Cells[2].Value.ToString();
                textCédula.Text = dtGridViewpatients.CurrentRow.Cells[3].Value.ToString();
                textFechaDeNacimiento.Text = dtGridViewpatients.CurrentRow.Cells[4].Value.ToString().Split(" ")[0].Trim();
                textDirección.Text = dtGridViewpatients.CurrentRow.Cells[6].Value.ToString();
                textTelefono.Text = dtGridViewpatients.CurrentRow.Cells[7].Value.ToString();
                comboBoxSexo.Text = dtGridViewpatients.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception Error)
            {
                System.Diagnostics.Debug.WriteLine(Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Validar si los campos están vacíos
            if (string.IsNullOrEmpty(textNombre.Text) ||
                string.IsNullOrEmpty(textApellido.Text) ||
                string.IsNullOrEmpty(textCédula.Text) ||
                string.IsNullOrEmpty(textFechaDeNacimiento.Text) ||
                string.IsNullOrEmpty(textDirección.Text) ||
                string.IsNullOrEmpty(textTelefono.Text) ||
                string.IsNullOrEmpty(comboBoxSexo.Text))
            {
                MessageBox.Show("Seleccione un paciente de la lista para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin ejecutar la modificación
            }

            try
            {
                Query = "UPDATE patients SET Nombre=@Nombre,Apellido=@Apellido,Cédula=@Cédula,FechaDeNacimiento=@FechaDeNacimiento,Edad=@Edad,Dirección=@Dirección,Telefono=@Telefono,Sexo=@Sexo WHERE PatientId=@PatientId";
                Operation = new Microsoft.Data.SqlClient.SqlCommand(Query, Program.connection);

                Operation.Parameters.AddWithValue("@PatientId", Text);
                Operation.Parameters.AddWithValue("@Nombre", textNombre.Text);
                Operation.Parameters.AddWithValue("@Apellido", textApellido.Text);
                Operation.Parameters.AddWithValue("@Cédula", textCédula.Text);
                Operation.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
                Operation.Parameters.AddWithValue("@Dirección", textDirección.Text);
                Operation.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                Operation.Parameters.AddWithValue("@Edad", Age);
                Operation.Parameters.AddWithValue("@Sexo", comboBoxSexo.Text);

                Operation.ExecuteNonQuery();

                MessageBox.Show("Los Datos Se Modificaron Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dtGridViewpatients.DataSource = Index();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar si no hay un paciente seleccionado (campos vacíos)
            if (string.IsNullOrEmpty(Text) ||
                string.IsNullOrEmpty(textNombre.Text) ||
                string.IsNullOrEmpty(textApellido.Text))
            {
                MessageBox.Show("Seleccione un paciente de la lista para eliminar",
                               "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar al paciente {textNombre.Text} {textApellido.Text}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return; // Si el usuario cancela, no hacer nada
            }

            try
            {
                string Eliminar = "DELETE FROM patients WHERE PatientId=@PatientId";
                Microsoft.Data.SqlClient.SqlCommand Borrar = new Microsoft.Data.SqlClient.SqlCommand(Eliminar, Program.connection);

                Borrar.Parameters.AddWithValue("@PatientId", Text);

                int filasAfectadas = Borrar.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Paciente eliminado correctamente",
                                  "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el paciente a eliminar",
                                  "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dtGridViewpatients.DataSource = Index();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar paciente: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textCédula_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío 
            if (string.IsNullOrWhiteSpace(textCédula.Text))
            {
                errorProvider1.SetError(textCédula, ""); // Limpia el mensaje de error si está vacío
                return; // Sale de la validación sin hacer más comprobaciones
            }

            // Verifica si el texto es un número entero válido (solo si el campo no está vacío)
            if (!int.TryParse(textCédula.Text, out int num))
            {
                errorProvider1.SetError(textCédula, "Ingrese un valor numérico entero."); // Muestra el error

            }
            else
            {
                errorProvider1.SetError(textCédula, ""); // Limpia el mensaje de error si es válido
            }
        }

        private void textTelefono_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío
            if (string.IsNullOrWhiteSpace(textTelefono.Text))
            {
                errorProvider1.SetError(textTelefono, ""); // Limpia el mensaje de error si está vacío
                return; // Sale de la validación sin hacer más comprobaciones
            }

            // Verifica si el texto es un número entero válido (BIGINT)
            if (!long.TryParse(textTelefono.Text, out long num))
            {
                errorProvider1.SetError(textTelefono, "Ingrese un valor numérico"); // Muestra el error
            }
            else
            {
                errorProvider1.SetError(textTelefono, ""); // Limpia el mensaje de error si es válido
            }
        }

        private void textFechaDeNacimiento_Validating(object sender, CancelEventArgs e)
        {
            // Limpiar error previo
            errorProvider1.SetError(textFechaDeNacimiento, "");

            // Si el campo está vacío, no validar
            if (string.IsNullOrWhiteSpace(textFechaDeNacimiento.Text))
            {
                return;
            }

            // Validar formato de fecha
            if (!DateTime.TryParse(textFechaDeNacimiento.Text, out DateTime fechaNacimiento))
            {
                errorProvider1.SetError(textFechaDeNacimiento, "Formato incorrecto. Use dd/MM/yyyy");
                return;
            }

            try
            {
                DateTime today = DateTime.Today;
                DateTime limitDate = today.AddYears(-110);

                // Validar que no sea una fecha muy antigua
                if (fechaNacimiento < limitDate)
                {
                    errorProvider1.SetError(textFechaDeNacimiento,
                        $"La fecha de nacimiento no puede ser anterior a {limitDate:15/03/1915}");
                    return;
                }

                // Validar que no sea una fecha futura
                if (fechaNacimiento > today)
                {
                    errorProvider1.SetError(textFechaDeNacimiento,
                        "La fecha de nacimiento no puede ser futura");
                    return;
                }

                // Calcular la edad
                Age = CalcularEdad(fechaNacimiento);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textFechaDeNacimiento, "Error al procesar la fecha: " + ex.Message);
            }
        }

        // Método separado para calcular la edad
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha pasado el cumpleaños este año
            if (fechaNacimiento.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string Buscar = textBoxBuscar.Text;

            // Filtrar los datos del DataGridView
            BuscarPacientes(Buscar);
        }

        private void BuscarPacientes(string Buscar)
        {
            // Obtener el DataSource del DataGridView
            DataTable dt = (DataTable)dtGridViewpatients.DataSource;

            // Aplicar el filtro
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", Buscar);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // Obtener los datos de la tabla
            DataTable dataTable = Index();

            // Especificar la ruta del archivo PDF
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pacientes.pdf");

            // Generar el PDF
            PDFGenerator pdfGenerator = new PDFGenerator();
            pdfGenerator.GeneratePdfFromDataTable(dataTable, filePath);

            // Mostrar mensaje de éxito
            MessageBox.Show("Reporte PDF generado exitosamente en: " + filePath);
        }
    }
}
