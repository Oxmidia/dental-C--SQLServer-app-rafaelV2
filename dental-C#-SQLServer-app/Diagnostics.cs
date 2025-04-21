using dental_C__SQLServer_app.Forms;
using dental_C__SQLServer_app.Validations;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace dental_C__SQLServer_app
{
    public partial class Diagnostics : Form
    {
        private string connectionString = "Server=localhost; Database=histodent; Integrated Security=True; TrustServerCertificate=True; Encrypt=True;";
        private string selectedAppointmentID; // Variable para almacenar el ID de la cita seleccionada
        public Diagnostics()
        {
            InitializeComponent();
            this.Load += new EventHandler(dataDiagnostico_Load);
            dataDiagnostico.SelectionChanged += new EventHandler(dataDiagnostico_SelectionChanged);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            textBoxFiltro.TextChanged += new EventHandler(textBoxFiltro_TextChanged);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            // Asegúrate de que estos estén conectados
            btnGuardarDiagnostico.Click += new EventHandler(btnGuardarDiagnostico_Click);
            btnModificarD.Click += new EventHandler(btnModificarD_Click);
            btnEliminarD.Click += new EventHandler(btnEliminarD_Click);
        }

        private void dataDiagnostico_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataDiagnostico.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataDiagnostico.Rows[dataDiagnostico.SelectedCells[0].RowIndex];

                // Mostrar datos del diagnóstico seleccionado
                lblNombrePaciente.Text = selectedRow.Cells["Nombre"].Value?.ToString() ?? "";
                lblApellidoPaciente.Text = selectedRow.Cells["Apellido"].Value?.ToString() ?? "";
                txtFechaDiagnostico.Text = selectedRow.Cells["FechaDiagn"].Value.ToString().Split(" ")[0].Trim();
                txtDescripcionDiagnostico.Text = selectedRow.Cells["Descripción"].Value.ToString();
                txtSeveridadD.Text = selectedRow.Cells["Severidad"].Value.ToString();

                // Guardar el AppointmentID del diagnóstico seleccionado
                selectedAppointmentID = selectedRow.Cells["AppointmentID"].Value?.ToString();
            }
        }

        private void btnGuardarDiagnostico_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (string.IsNullOrEmpty(selectedAppointmentID))
            {
                MessageBox.Show("Por favor, seleccione una cita primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los controles del formulario
            string descripcion = txtDescripcionDiagnostico.Text;
            string severidad = txtSeveridadD.Text;
            string fechaDiagn = txtFechaDiagnostico.Text;

            // Validar campos
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(severidad) || string.IsNullOrEmpty(fechaDiagn))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaDiagnosticoDate;
            try
            {
                fechaDiagnosticoDate = DateTime.ParseExact(fechaDiagn, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Formato de fecha inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si ya existe un diagnóstico idéntico
            if (ExisteDiagnosticoDuplicado(selectedAppointmentID, descripcion, severidad, fechaDiagnosticoDate))
            {
                MessageBox.Show("Ya existe un diagnóstico con la misma fecha, severidad y descripción para este paciente.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar ID único para el diagnóstico
            Guid guid = Guid.NewGuid();
            string diagnosticsID = guid.ToString("N");

            // Resto del código para guardar el diagnóstico...
            string query = @"INSERT INTO Diagnostics 
                    (DiagnosticsID, AppointmentID, Descripción, Severidad, FechaDiagn) 
                    VALUES (@DiagnosticsID, @AppointmentID, @Descripción, @Severidad, @FechaDiagn)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DiagnosticsID", diagnosticsID);
                        command.Parameters.AddWithValue("@AppointmentID", selectedAppointmentID);
                        command.Parameters.AddWithValue("@Descripción", descripcion);
                        command.Parameters.AddWithValue("@Severidad", severidad);
                        command.Parameters.AddWithValue("@FechaDiagn", fechaDiagnosticoDate);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Diagnóstico guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataDiagnostico_Load(sender, e);
                            reset();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el diagnóstico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataDiagnostico_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Modificamos la consulta para incluir el nombre y apellido desde la tabla Appointments
                    string query = @"SELECT d.*, a.Nombre, a.Apellido 
                                   FROM diagnostics d
                                   LEFT JOIN Appointments a ON d.AppointmentID = a.AppointmentID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataDiagnostico.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar diagnósticos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtFechaDiagnostico.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSeveridadD.Text = "Leve";
            txtDescripcionDiagnostico.Text = "";
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            // Cambiar esta verificación para usar SelectedCells como en el resto del código
            if (dataDiagnostico.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataDiagnostico.Rows[dataDiagnostico.SelectedCells[0].RowIndex];

                // Obtener el ID del diagnóstico seleccionado (como cadena)
                string diagnosticsId = selectedRow.Cells["DiagnosticsID"].Value.ToString();

                // Confirmar con el usuario si realmente desea eliminar el registro
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este Diagnostico?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Crear la consulta SQL para eliminar el registro
                    string query = "DELETE FROM diagnostics WHERE DiagnosticsID = @DiagnosticsID";

                    // Usar una conexión a la base de datos
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open(); // Abrir la conexión

                            // Crear un comando SQL con la consulta y la conexión
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Agregar parámetros para evitar inyección SQL
                                command.Parameters.AddWithValue("@DiagnosticsID", diagnosticsId);

                                // Ejecutar la consulta
                                int resultDelete = command.ExecuteNonQuery();

                                // Verificar si se eliminó el registro correctamente
                                if (resultDelete > 0)
                                {
                                    MessageBox.Show("Diagnostico eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Recargar los datos en el DataGridView
                                    dataDiagnostico_Load(sender, e); // Llamar al método para actualizar el DataGridView

                                    reset();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el Diagnostico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el Diagnostico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Diagnostico para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarD_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || dataDiagnostico.SelectedCells.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un diagnóstico y complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID de la fila seleccionada
            DataGridViewRow selectedRow = dataDiagnostico.Rows[dataDiagnostico.SelectedCells[0].RowIndex];
            string diagnosticsId = selectedRow.Cells["DiagnosticsID"].Value.ToString();

            string descripcion = txtDescripcionDiagnostico.Text;
            string severidad = txtSeveridadD.Text;
            string fechaDiagn = txtFechaDiagnostico.Text;

            DateTime fechaDiagnosticoDate;
            try
            {
                fechaDiagnosticoDate = DateTime.ParseExact(fechaDiagn, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Formato de fecha inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si ya existe otro diagnóstico idéntico (excluyendo el actual)
            if (ExisteOtroDiagnosticoDuplicado(diagnosticsId, selectedAppointmentID, descripcion, severidad, fechaDiagnosticoDate))
            {
                MessageBox.Show("Ya existe otro diagnóstico con la misma fecha, severidad y descripción para este paciente.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de modificar este diagnóstico?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = @"UPDATE diagnostics SET 
                        Descripción = @Descripción, 
                        Severidad = @Severidad, 
                        FechaDiagn = @FechaDiagn 
                        WHERE DiagnosticsID = @DiagnosticsID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Eliminé la declaración duplicada de fechaDiagnosticoDate aquí
                            command.Parameters.AddWithValue("@Descripción", descripcion);
                            command.Parameters.AddWithValue("@Severidad", severidad);
                            command.Parameters.AddWithValue("@FechaDiagn", fechaDiagnosticoDate);
                            command.Parameters.AddWithValue("@DiagnosticsID", diagnosticsId);

                            int resultUpdate = command.ExecuteNonQuery();

                            if (resultUpdate > 0)
                            {
                                MessageBox.Show("Diagnóstico modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataDiagnostico_Load(sender, e);
                                reset();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el diagnóstico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool ExisteOtroDiagnosticoDuplicado(string currentDiagnosticsID, string appointmentID, string descripcion, string severidad, DateTime fechaDiagn)
        {
            string query = @"SELECT COUNT(*) FROM Diagnostics 
                    WHERE DiagnosticsID != @CurrentDiagnosticsID
                    AND AppointmentID = @AppointmentID 
                    AND Descripción = @Descripción 
                    AND Severidad = @Severidad 
                    AND CONVERT(date, FechaDiagn) = CONVERT(date, @FechaDiagn)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentDiagnosticsID", currentDiagnosticsID);
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        command.Parameters.AddWithValue("@Descripción", descripcion);
                        command.Parameters.AddWithValue("@Severidad", severidad);
                        command.Parameters.AddWithValue("@FechaDiagn", fechaDiagn);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar diagnóstico duplicado: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Por precaución, asumimos que existe para evitar duplicados
                }
            }
        }

        public bool ValidarCampos()
        {
            CamposValidacion validaciones = new CamposValidacion();

            if (!validaciones.ValidarFechaDiagnostico(txtFechaDiagnostico.Text))
            {
                MessageBox.Show("Error en la fecha del diagnostico.");
                return false;
            }

            if (!validaciones.ValidarSeveridadDiagnostico(txtSeveridadD.Text))
            {
                MessageBox.Show("Error en la severidad del diagnostico.");
                return false;
            }

            if (!validaciones.ValidarDescripcionD(txtDescripcionDiagnostico.Text))
            {
                MessageBox.Show("Error en la descripcion del diagnostico.");
                return false;
            }
            return true;
        }

        private void Diagnostics_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = quote();
        }

        public DataTable quote()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM Appointments";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells[0].RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];

                // Mostrar nombre y apellido en los labels
                lblNombrePaciente.Text = selectedRow.Cells["Nombre"].Value?.ToString() ?? "";
                lblApellidoPaciente.Text = selectedRow.Cells["Apellido"].Value?.ToString() ?? "";

                // Guardar el AppointmentID sin mostrarlo
                selectedAppointmentID = selectedRow.Cells["AppointmentID"].Value?.ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // Obtener el texto del TextBox
            string buscar = textBox1.Text;

            // Filtrar los datos del DataGridView
            Buscardiagnostico(buscar);
        }

        private void Buscardiagnostico(string buscar)
        {
            // Obtener el DataSource del DataGridView
            DataTable dt = (DataTable)dataDiagnostico.DataSource;

            // Aplicar el filtro
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%'", buscar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataDiagnostico.SelectedCells.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un diagnóstico primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dataDiagnostico.Rows[dataDiagnostico.SelectedCells[0].RowIndex];

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(lblNombrePaciente.Text) || string.IsNullOrEmpty(lblApellidoPaciente.Text) ||
                string.IsNullOrEmpty(txtDescripcionDiagnostico.Text) || string.IsNullOrEmpty(txtFechaDiagnostico.Text))
            {
                MessageBox.Show("Por favor, seleccione un diagnóstico primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el DiagnosticsID (validar que no esté vacío)
            string diagnosticsID = selectedRow.Cells["DiagnosticsID"].Value?.ToString();
            if (string.IsNullOrEmpty(diagnosticsID))
            {
                MessageBox.Show("No se pudo obtener el ID del diagnóstico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si pasó todas las validaciones, abrir el formulario de Treatments
            Treatments treatmentsForm = new Treatments(lblNombrePaciente.Text, lblApellidoPaciente.Text, diagnosticsID);
            treatmentsForm.Show();

        }

        private void reset()
        {

            lblNombrePaciente.Text = "";
            lblApellidoPaciente.Text = "";
            txtFechaDiagnostico.Text = "";
            txtSeveridadD.Text = "";
            txtDescripcionDiagnostico.Text = "";


        }


        private bool ExisteDiagnosticoDuplicado(string appointmentID, string descripcion, string severidad, DateTime fechaDiagn)
        {
            string query = @"SELECT COUNT(*) FROM Diagnostics 
                    WHERE AppointmentID = @AppointmentID 
                    AND Descripción = @Descripción 
                    AND Severidad = @Severidad 
                    AND CONVERT(date, FechaDiagn) = CONVERT(date, @FechaDiagn)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        command.Parameters.AddWithValue("@Descripción", descripcion);
                        command.Parameters.AddWithValue("@Severidad", severidad);
                        command.Parameters.AddWithValue("@FechaDiagn", fechaDiagn);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar diagnóstico duplicado: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Por precaución, asumimos que existe para evitar duplicados
                }
            }
        }

    }
}

