using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Forms.habits_methods;
using dental_C__SQLServer_app.Validations.Dating_methods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dental_C__SQLServer_app.Forms
{
    public partial class General_exam : Form
    {
        private string _nombre;
        private string _apellido;
        private string _appointmentID;
        private string _OExamID;
        private string _GExamID;
        private General_exam_methods _generalExamMethods;


        public General_exam(string nombre, string apellido, string appointmentID)
        {
            InitializeComponent();
            _nombre = nombre;
            _apellido = apellido;
            _appointmentID = appointmentID;
            _generalExamMethods = new General_exam_methods();

            // Mostrar el nombre y apellido en los controles del formulario
            labelNombre.Text = _nombre;
            labelApellido.Text = _apellido;
        }

        public General_exam()
        {
            InitializeComponent();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void General_exam_Load(object sender, EventArgs e)
        {
            General_exam_methods general_Exam_Methods = new General_exam_methods();
            // Llamar al método GeneralExam y OralExam para asignar el resultado al DataGridView
            dataGridView1.DataSource = general_Exam_Methods.GeneralExam();
            dataGridView2.DataSource = general_Exam_Methods.OralExam();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_OExamID))
            {
                MessageBox.Show("Por favor, seleccione un registro de OralExam antes de abrir el formulario Denture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form Dentadura = new Denture(_OExamID);
            Dentadura.Show();



        }

        private bool Validarcampos()
        {
            bool validado = true;



            if (textBoxObservaciones.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxObservaciones, "Ingresar observaciones");
            }

            if (textBoxEstadodeEncias.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxEstadodeEncias, "Ingresar Estado de Encias");
            }

            if (textBoxPlaca.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxPlaca, "Ingresar Placa");
            }

            if (textBoxSangrado.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxSangrado, "Ingresar Sangrado");
            }

            if (textBoxObserva.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxObserva, "Ingresar Observaciones");
            }



            return validado;
        }

        private void MensajeBorrar()
        {

            errorProvider1.SetError(textBoxObservaciones, "");
            errorProvider1.SetError(textBoxEstadodeEncias, "");
            errorProvider1.SetError(textBoxPlaca, "");
            errorProvider1.SetError(textBoxSangrado, "");
            errorProvider1.SetError(textBoxObserva, "");

        }

        private void reset()
        {

            textBoxObservaciones.Text = "";
            textBoxEstadodeEncias.Text = "";
            textBoxPlaca.Text = "";
            textBoxSangrado.Text = "";
            textBoxObserva.Text = "";


        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Borrar mensajes
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
               {
                 MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
             }

            // Verificar si ya existe un registro de GeneralExam y OralExam para esta cita
            if (_generalExamMethods.ExisteGeneralExam(_appointmentID))
            {
                MessageBox.Show("Ya existe un registro de GeneralExam para esta cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_generalExamMethods.ExisteOralExam(_appointmentID))
            {
                MessageBox.Show("Ya existe un registro de OralExam para esta cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar IDs aleatorios
            string gExamID = Guid.NewGuid().ToString("N");
            string oExamID = Guid.NewGuid().ToString("N");

            // Guardar los datos y obtener los IDs generados
            string ultimoGExamID = _generalExamMethods.GuardarGeneralexam(gExamID, textBoxObservaciones.Text, _appointmentID);
            string ultimoOExamID = _generalExamMethods.GuardarOralexam(oExamID, textBoxEstadodeEncias.Text, textBoxPlaca.Text, textBoxSangrado.Text, textBoxObserva.Text, _appointmentID);

            MessageBox.Show("Datos guardados correctamente.");

            // Obtener los registros recién insertados
            DataTable ultimoGeneralExam = _generalExamMethods.ObtenerGeneralExamPorID(ultimoGExamID);
            DataTable ultimoOralExam = _generalExamMethods.ObtenerOralExamPorID(ultimoOExamID);

            // Asignar el DataTable al DataSource de cada DataGridView
            dataGridView1.DataSource = ultimoGeneralExam;
            dataGridView2.DataSource = ultimoOralExam;
            reset();

        }

        private void GuardarGeneral(string appointmentID)
        {

            string observaciones = textBoxObservaciones.Text;
            _generalExamMethods.GuardarGeneralexam(Guid.NewGuid().ToString("N"), observaciones, appointmentID);

        }

        private void GuardarOral(string appointmentID)
        {
            string EstadoEncías = textBoxEstadodeEncias.Text;
            string placa = textBoxPlaca.Text;
            string sangrado = textBoxSangrado.Text;
            string ObservacionesB = textBoxObserva.Text;

            _generalExamMethods.GuardarOralexam(Guid.NewGuid().ToString("N"), EstadoEncías, placa, sangrado, ObservacionesB, appointmentID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Almacenar el ID deL Generalexam y el ID de la appointment
                _GExamID = row.Cells["GExamID"].Value.ToString();
                _appointmentID = row.Cells["AppointmentID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxObservaciones.Text = row.Cells["Observaciones"].Value.ToString();

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Almacenar el ID deL Oralexam y el ID de la appointment
                _OExamID = row.Cells["OExamID"].Value.ToString();
                _appointmentID = row.Cells["AppointmentID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxEstadodeEncias.Text = row.Cells["EstadoEncías"].Value.ToString();
                textBoxPlaca.Text = row.Cells["Placa"].Value.ToString();
                textBoxSangrado.Text = row.Cells["Sangrado"].Value.ToString();
                textBoxObserva.Text = row.Cells["ObservacionesB"].Value.ToString();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool modificargeneral = false;
            bool modificaroral = false;

           

            // Validar campos de GeneralExam
            string Observaciones = textBoxObservaciones.Text;

            if (!string.IsNullOrEmpty(Observaciones))
            {
                if (string.IsNullOrEmpty(_GExamID))
                {
                    MessageBox.Show("Seleccione un registro de GeneralExam para modificar.");
                    return;
                }
                modificargeneral = true;
            }

            // Validar campos de OralExam
            string EstadoEncias = textBoxEstadodeEncias.Text;
            string placa = textBoxPlaca.Text;
            string sangrado = textBoxSangrado.Text;
            string ObservacionesB = textBoxObserva.Text;

            if (!string.IsNullOrEmpty(EstadoEncias) || !string.IsNullOrEmpty(placa) || !string.IsNullOrEmpty(sangrado) || !string.IsNullOrEmpty(ObservacionesB))
            {
                if (string.IsNullOrEmpty(_OExamID))
                {
                    MessageBox.Show("Seleccione un registro de OralExam para modificar.");
                    return;
                }
                modificaroral = true;
            }

            // Validar que al menos un campo esté lleno antes de proceder
            if (!modificargeneral && !modificaroral)
            {
                MessageBox.Show("Por favor, ingrese datos en al menos uno de los campos para modificar.");
                return;
            }

            // Modificar GeneralExam si es necesario
            if (modificargeneral)
            {
                try
                {
                    // Modificar y obtener el registro actualizado
                    DataTable ultimoGeneralExam = _generalExamMethods.ModificarGeneralexam(_GExamID, Observaciones);
                    MessageBox.Show("GeneralExam modificado correctamente.");

                    // Mostrar solo el registro modificado en el DataGridView
                    dataGridView1.DataSource = ultimoGeneralExam;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar GeneralExam: " + ex.Message);
                }
            }

            // Modificar OralExam si es necesario
            if (modificaroral)
            {
                try
                {
                    // Modificar y obtener el registro actualizado
                    DataTable ultimoOralExam = _generalExamMethods.ModificarOralexam(_OExamID, EstadoEncias, placa, sangrado, ObservacionesB);
                    MessageBox.Show("OralExam modificado correctamente.");

                    // Mostrar solo el registro modificado en el DataGridView
                    dataGridView2.DataSource = ultimoOralExam;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar OralExam: " + ex.Message);
                }
            }

            // Mostrar mensaje solo si no se realizaron modificaciones
            if (!modificargeneral && !modificaroral)
            {
                MessageBox.Show("No se realizaron modificaciones.");
            }
            reset();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar que _GExamID no esté vacío o sea nulo
            if (string.IsNullOrEmpty(_GExamID))
            {
                MessageBox.Show(
                    "Por favor, seleccione un registro de examen general para eliminar.",
                    "Campo vacío o inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Salir del método si no hay un ID válido
            }


            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este examen general?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, eliminar la cita
            if (resultado == DialogResult.Yes)
            {
                // Crear una instancia de la clase que contiene el método EliminarCita
                General_exam_methods general_Exam_Methods = new General_exam_methods();

                // Llamar al método EliminarCita
                general_Exam_Methods.EliminarGeneraExam(_GExamID);

                // Actualizar el DataGridView (opcional)
                dataGridView1.DataSource = general_Exam_Methods.GeneralExam();
                reset();
            }
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Validar que _GExamID no esté vacío o sea nulo
            if (string.IsNullOrEmpty(_OExamID))
            {
                MessageBox.Show(
                    "Por favor, seleccione un registro de examen oral para eliminar.",
                    "Campo vacío o inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Salir del método si no hay un ID válido
            }


            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este examen oral?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, eliminar la cita
            if (resultado == DialogResult.Yes)
            {
                // Crear una instancia de la clase que contiene el método EliminarCita
                General_exam_methods general_Exam_Methods = new General_exam_methods();

                // Llamar al método EliminarCita
                general_Exam_Methods.EliminarOralExam(_OExamID);

                // Actualizar el DataGridView (opcional)
                dataGridView2.DataSource = general_Exam_Methods.OralExam();
                reset();
            }
        }
    }
}
