using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Classes;
using dental_C__SQLServer_app.Validations.Dating_methods;

namespace dental_C__SQLServer_app
{
    public partial class Treatments : Form
    {
        private string _nombre;
        private string _apellido;
        private string _diagnosticsID;
        private string _treatementId;

        // ModificaR el constructor para recibir los parámetros
        public Treatments(string nombre, string apellido, string diagnosticsID)
        {
            InitializeComponent();
            _nombre = nombre;
            _apellido = apellido;
            _diagnosticsID = diagnosticsID;
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            // Mostrar los datos en los labels
            lblNombrePaciente.Text = _nombre;
            lblApellidoPaciente.Text = _apellido;

            // Crear una instancia de la clase c Treatments
            CTreatments ctreatments = new CTreatments();

            // Llamar al método tratamiento() y pasar el diagnosticsID para filtrar
            dataTratamiento.DataSource = ctreatments.tratamiento(_diagnosticsID);
        }


        private void reset()
        {
            
            txtNTratamiento.Text = "";
            txtPlanTratamiento.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFinalizacion.Text = "";
            txtPrecioT.Text = "";


        }

        private bool Validarcampos()
        {
            bool validado = true;



            if (txtNTratamiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtNTratamiento, "Ingresar Nombre Del tratamiento");
            }

            if (txtPlanTratamiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtPlanTratamiento, "Ingresar plan de tratamiento");
            }

            if (txtFechaInicio.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtFechaInicio, "Ingresar fecha de inicio");
            }

            if (txtFechaFinalizacion.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtFechaFinalizacion, "Ingresar Fecha de finalizacion");
            }

            if (txtPrecioT.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtPrecioT, "Ingresar Hora");
            }



            return validado;
        }

        private void MensajeBorrar()
        {

            errorProvider1.SetError(txtNTratamiento, "");
            errorProvider1.SetError(txtPlanTratamiento, "");
            errorProvider1.SetError(txtFechaInicio, "");
            errorProvider1.SetError(txtFechaFinalizacion, "");
            errorProvider1.SetError(txtPrecioT, "");

        }


        private void btnGuardarTratamiento_Click(object sender, EventArgs e)
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
            string nombreTratamiento = txtNTratamiento.Text;
            string planTratamiento = txtPlanTratamiento.Text;
            string fechaInicio = txtFechaInicio.Text;
            string fechaFinalizacion = txtFechaFinalizacion.Text;
            string precio = txtPrecioT.Text;
            string diagnosticsID = _diagnosticsID; // ID del diagnóstico seleccionado

            // Crear una instancia de la clase c Treatments
            CTreatments ctreatments = new CTreatments();

            if (ctreatments.ExisteTratamientoConMismoDiagnostico(diagnosticsID))
            {
                MessageBox.Show("Ya existe un tratamiento para este diagnóstico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                // Llamar al método con los parámetros correctos
                ctreatments.InsertarTratamiento(
                    "",
                    nombreTratamiento,
                    planTratamiento,
                    fechaInicio,
                    fechaFinalizacion,
                    precio,
                    diagnosticsID);

                MessageBox.Show("Tratamiento guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los nuevos datos
          
                dataTratamiento.DataSource = ctreatments.tratamiento(_diagnosticsID);

                // Limpiar los TextBox después de la inserción
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el tratamiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataTratamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataTratamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataTratamiento.Rows[e.RowIndex];

                // Almacenar el ID de la cita y el ID del paciente
                _diagnosticsID = row.Cells["DiagnosticsID"].Value.ToString();
                _treatementId = row.Cells["TreatmentID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                
                txtNTratamiento.Text = row.Cells["NombreTratamiento"].Value.ToString();
                txtPlanTratamiento.Text = row.Cells["PlanTratamiento"].Value.ToString();
                txtFechaInicio.Text = row.Cells["FechaInicio"].Value.ToString().Split(" ")[0].Trim();
                txtFechaFinalizacion.Text = row.Cells["FechaFinal"].Value.ToString().Split(" ")[0].Trim();
                txtPrecioT.Text = row.Cells["Precio"].Value.ToString();


            }
        }

        private void btnModificarTratamiento_Click(object sender, EventArgs e)
        {
            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Seleccione un tratamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia de la clase c Treatments
            CTreatments ctreatments = new CTreatments();
            ctreatments.Modificar(_treatementId, txtNTratamiento, txtPlanTratamiento, txtFechaInicio, txtFechaFinalizacion, txtPrecioT);

            // Actualizar el DataGridView con los nuevos datos
            dataTratamiento.DataSource = ctreatments.tratamiento(_diagnosticsID);
            // para que los textbox queden vacios
            reset();
        }

        private void btnEliminarTratamiento_Click(object sender, EventArgs e)
        {
            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Debe seleccionar un tratamiento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este tratamiento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, eliminar la cita
            if (resultado == DialogResult.Yes)
            {
                CTreatments ctreatments = new CTreatments();

                // Llamar al método EliminarCita
                ctreatments.Eliminar(_treatementId);

                // Actualizar el DataGridView con los nuevos datos
                dataTratamiento.DataSource = ctreatments.tratamiento(_diagnosticsID);
                // para que los texbox queden vacios
                reset();
            }
        }

        private void txtFechaInicio_Validating(object sender, CancelEventArgs e)
        {
            // Obtener el texto del TextBox
            string fechaIngresada = txtFechaInicio.Text;

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(fechaIngresada))
            {
                errorProvider1.SetError(txtFechaInicio, "La fecha es requerida.");
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
                    errorProvider1.SetError(txtFechaInicio, "La fecha debe ser del año actual.");
                    e.Cancel = true; // Evita que el foco salga del TextBox
                }
                else
                {
                    // La fecha es válida, limpiar el mensaje de error
                    errorProvider1.SetError(txtFechaInicio, "");
                }
            }
            else
            {
                // Si la fecha no tiene un formato válido
                errorProvider1.SetError(txtFechaInicio, "Formato de fecha inválido. Use el formato dd/MM/yyyy.");
                e.Cancel = true; // Evita que el foco salga del TextBox
            }
        }

        private void txtFechaFinalizacion_Validating(object sender, CancelEventArgs e)
        {

            // Obtener el texto del TextBox
            string fechaIngresada = txtFechaFinalizacion.Text;

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(fechaIngresada))
            {
                errorProvider1.SetError(txtFechaFinalizacion, "La fecha es requerida.");
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
                    errorProvider1.SetError(txtFechaFinalizacion, "La fecha debe ser del año actual.");
                    e.Cancel = true; // Evita que el foco salga del TextBox
                }
                else
                {
                    // La fecha es válida, limpiar el mensaje de error
                    errorProvider1.SetError(txtFechaFinalizacion, "");
                }
            }
            else
            {
                // Si la fecha no tiene un formato válido
                errorProvider1.SetError(txtFechaFinalizacion, "Formato de fecha inválido. Use el formato dd/MM/yyyy.");
                e.Cancel = true; // Evita que el foco salga del TextBox
            }
        }
    }
}
