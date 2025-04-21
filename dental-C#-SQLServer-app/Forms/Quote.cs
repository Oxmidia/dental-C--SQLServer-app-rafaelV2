using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using dental_C__SQLServer_app.Validations.Dating_methods;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Globalization;
using dental_C__SQLServer_app.Classes;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Quote : Form
    {
        public Quote(string id, string nombre, string apellido)
        {
            InitializeComponent();
            _selectedPatientID = id;
            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
        }
        private string _selectedPatientID; // Variable para almacenar el ID del paciente seleccionado
        private string _selectedID; // Variable para almacenar el ID seleccionado

        public Quote()
        {
            InitializeComponent();
            textBoxFiltro.TextChanged += new EventHandler(textBoxFiltro_TextChanged);
            textBoxBuscar.TextChanged += new EventHandler(textBoxBuscar_TextChanged);
        }

        private void Quote_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CQuote
            CQuote cQuote = new CQuote();

            // Llamar al método Cita() y asignar el resultado al DataGridView
            dataGridView1.DataSource = cQuote.Cita();
            dataGridView2.DataSource = cQuote.pacientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label1 (puedes agregar lógica si es necesario)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label2 (puedes agregar lógica si es necesario)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label3 (puedes agregar lógica si es necesario)
        }

        private void reset()
        {

            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxMotivo.Text = "";
            textBoxFecha.Text = "";
            textBoxHora.Text = "";


        }

        private bool Validarcampos()
        {
            bool validado = true;



            if (textBoxNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxNombre, "Ingresar Nombre Del paciente");
            }

            if (textBoxApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxApellido, "Ingresar Apellido Del Paciente");
            }

            if (textBoxMotivo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxMotivo, "Ingresar Motivo");
            }

            if (textBoxFecha.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxFecha, "Ingresar Fecha");
            }

            if (textBoxHora.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxHora, "Ingresar Hora");
            }



            return validado;
        }

        private void MensajeBorrar()
        {

            errorProvider1.SetError(textBoxNombre, "");
            errorProvider1.SetError(textBoxApellido, "");
            errorProvider1.SetError(textBoxMotivo, "");
            errorProvider1.SetError(textBoxFecha, "");
            errorProvider1.SetError(textBoxHora, "");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los TextBox
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string motivo = textBoxMotivo.Text;
            string fecha = textBoxFecha.Text;
            string hora = textBoxHora.Text;
            string patientID = _selectedPatientID; // ID del paciente seleccionado

            // Verificar si el registro ya existe
            CQuote cQuote = new CQuote();
            if (cQuote.ExisteRegistro(patientID, fecha, hora))
            {
                errorProvider1.SetError(textBoxFecha, "Ya existe una cita para este paciente en la fecha y hora seleccionadas.");
                errorProvider1.SetError(textBoxHora, "Modifique la fecha o la hora para guardar una nueva cita.");
                return; // Detener la ejecución si el registro ya existe
            }

            // Insertar la cita en la base de datos
            try
            {
                cQuote.InsertarCita(_selectedID, nombre, apellido, motivo, fecha, hora, patientID);
                MessageBox.Show("Cita guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los nuevos datos
                dataGridView1.DataSource = cQuote.Cita();

                // Limpiar los TextBox después de la inserción
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Almacenar el ID de la cita y el ID del paciente
                _selectedID = row.Cells["AppointmentID"].Value.ToString();
                _selectedPatientID = row.Cells["PatientID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxNombre.Text = row.Cells["Nombre"].Value.ToString();
                textBoxApellido.Text = row.Cells["Apellido"].Value.ToString();
                textBoxMotivo.Text = row.Cells["Motivo"].Value.ToString();
                textBoxFecha.Text = row.Cells["Fecha"].Value.ToString().Split(" ")[0].Trim();
                textBoxHora.Text = row.Cells["Hora"].Value.ToString().Split(" ")[0].Trim();

                // Deshabilitar o hacer de solo lectura los TextBox de nombre y apellido
                textBoxNombre.Enabled = false;
                textBoxApellido.Enabled = false;

                // O hacerlos de solo lectura
                textBoxNombre.ReadOnly = true;
                textBoxApellido.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Seleccione un Paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear una instancia de la clase que contiene el método Seleccionar
            CQuote cQuote = new CQuote();
            cQuote.Modificar(_selectedID, textBoxMotivo, textBoxFecha, textBoxHora);
            // Actualizar el DataGridView con los nuevos datos
            dataGridView1.DataSource = cQuote.Cita();

            // para que los textbox queden vacios
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Debe seleccionar una cita para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta cita?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, eliminar la cita
            if (resultado == DialogResult.Yes)
            {
                // Crear una instancia de la clase que contiene el método EliminarCita
                CQuote cQuote = new CQuote();

                // Llamar al método EliminarCita
                cQuote.EliminarCita(_selectedID);

                // Actualizar el DataGridView (opcional)
                dataGridView1.DataSource = cQuote.Cita(); // Suponiendo que tienes un método Cita() que devuelve un DataTable
                // para que los texbox queden vacios
                reset();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Verificar si se ha seleccionado una cita
            if (string.IsNullOrEmpty(_selectedID))
            {
                MessageBox.Show("Por favor, seleccione una cita primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de nombre, apellido y AppointmentID
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string appointmentID = _selectedID;

            // Crear una instancia del formulario General_exam y pasar los datos
            Form ExamenGeneral = new General_exam(nombre, apellido, appointmentID);
            ExamenGeneral.Show();


        }

        private void textBoxFecha_Validating(object sender, CancelEventArgs e)
        {
            // Obtener el texto del TextBox
            string fechaIngresada = textBoxFecha.Text;

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(fechaIngresada))
            {
                errorProvider1.SetError(textBoxFecha, "La fecha es requerida.");
                e.Cancel = true; // Evita que el foco salga del TextBox
                return;
            }

            // Intentar convertir la fecha ingresada a un objeto DateTime
            if (DateTime.TryParse(fechaIngresada, out DateTime fecha))
            {
                // Obtener el año actual
                int añoActual = DateTime.Now.Year;

                // Comparar el año de la fecha ingresada con el año actual
                if (fecha.Year != añoActual)
                {
                    errorProvider1.SetError(textBoxFecha, "La fecha debe ser del año actual.");
                    e.Cancel = true; // Evita que el foco salga del TextBox
                }
                else
                {
                    // La fecha es válida, limpiar el mensaje de error
                    errorProvider1.SetError(textBoxFecha, "");
                }
            }
            else
            {
                // Si la fecha no tiene un formato válido
                errorProvider1.SetError(textBoxFecha, "Formato de fecha inválido. Use el formato dd/MM/yyyy.");
                e.Cancel = true; // Evita que el foco salga del TextBox
            }
        }

        private void textBoxHora_Validating(object sender, CancelEventArgs e)
        {
            // Obtener el texto del TextBox
            string horaIngresada = textBoxHora.Text;

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(horaIngresada))
            {
                errorProvider1.SetError(textBoxHora, "La hora es requerida.");
                e.Cancel = true; // Evita que el foco salga del TextBox
                return;
            }

            // Intentar convertir la hora ingresada a un objeto DateTime
            if (DateTime.TryParseExact(horaIngresada, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime hora))
            {
                // Validar que la hora esté dentro del rango permitido (00:00 a 23:59)
                if (hora.TimeOfDay < TimeSpan.FromHours(0) || hora.TimeOfDay >= TimeSpan.FromHours(24))
                {
                    errorProvider1.SetError(textBoxHora, "La hora debe estar entre 00:00 y 23:59.");
                    e.Cancel = true; // Evita que el foco salga del TextBox
                }
                else
                {
                    // La hora es válida, limpiar el mensaje de error
                    errorProvider1.SetError(textBoxHora, "");
                }
            }
            else
            {
                // Si la hora no tiene un formato válido
                errorProvider1.SetError(textBoxHora, "Formato de hora inválido. Use el formato HH:mm.");
                e.Cancel = true; // Evita que el foco salga del TextBox
            }
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string filtro = textBoxFiltro.Text;

            // Filtrar los datos del DataGridView
            FiltrarDatos(filtro);
        }

        private void FiltrarDatos(string filtro)
        {
            // Obtener el DataSource del DataGridView
            DataTable dt = (DataTable)dataGridView1.DataSource;

            // Aplicar el filtro
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", filtro);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Almacenar el ID de la cita y el ID del paciente

                _selectedPatientID = row.Cells["PatientID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxNombre.Text = row.Cells["Nombre"].Value.ToString();
                textBoxApellido.Text = row.Cells["Apellido"].Value.ToString();


                // Deshabilitar o hacer de solo lectura los TextBox de nombre y apellido
                textBoxNombre.Enabled = false;
                textBoxApellido.Enabled = false;

                // O hacerlos de solo lectura
                textBoxNombre.ReadOnly = true;
                textBoxApellido.ReadOnly = true;
            }
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
            DataTable dt = (DataTable)dataGridView2.DataSource;

            // Aplicar el filtro
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", Buscar);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}