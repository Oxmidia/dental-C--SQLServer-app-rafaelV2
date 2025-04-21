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
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Habits : Form
    {

        private string selectedPatientID; // Variable para almacenar el ID del paciente seleccionado
        private string _selectedID; // Variable para almacenar el ID seleccionado
        private string antecedentsID; // Declaración de la variable


        public Habits()
        {
            InitializeComponent();
            textBoxBuscar1.TextChanged += new EventHandler(textBoxBuscar1_TextChanged);
        }

        private void Habits_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CHabits
            CHabits cHabits = new CHabits();

            // Llamar al método Habits() y asignar el resultado al DataGridView
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
            dataGridView3.DataSource = cHabits.patients();


        }

        private bool Validarcampos()
        {
            bool validado = true;



            if (textBoxHabito.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxHabito, "Ingresar hábito");
            }

            if (textBoxCepillado.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxCepillado, "Ingresar cepillado");
            }

            if (textBoxHemorragicos.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxHemorragicos, "Ingresar ingresar antecedentes hemorrágicos");
            }

            if (textBoxPersonales.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxPersonales, "Ingresar antecedentes personales");
            }

            if (textBoxFamiliares.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxFamiliares, "Ingresar antecedentes familiares");
            }



            return validado;
        }

        private void MensajeBorrar()
        {

            errorProvider1.SetError(textBoxHabito, "");
            errorProvider1.SetError(textBoxCepillado, "");
            errorProvider1.SetError(textBoxHemorragicos, "");
            errorProvider1.SetError(textBoxPersonales, "");
            errorProvider1.SetError(textBoxFamiliares, "");

        }

        private void reset()
        {

            textBoxHabito.Text = "";
            textBoxCepillado.Text = "";
            textBoxHemorragicos.Text = "";
            textBoxPersonales.Text = "";
            textBoxFamiliares.Text = "";


        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPatientID))
            {
                MessageBox.Show("Por favor, seleccione un paciente.");
                return;
            }

            // Borrar mensajes
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CHabits cHabits = new CHabits();

            // Verificar si ya existe un registro de hábitos o antecedentes para este paciente
            if (cHabits.ExistePatientIDEnHabits(selectedPatientID))
            {
                MessageBox.Show("Ya existe un registro de hábitos y antecedentes para este paciente.");
                return;
            }

            if (cHabits.ExistePatientIDEnAntecedents(selectedPatientID))
            {
                MessageBox.Show("Ya existe un registro de hábitos y antecedentes para este paciente.");
                return;
            }

            // Guardar los hábitos
            GuardarHabits(selectedPatientID);

            // Guardar los antecedentes
            GuardarAntecedents(selectedPatientID);

            MessageBox.Show("Datos guardados correctamente.");

            // Actualizar los DataGridView y aplicar el filtro
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
            FiltrarPorPatientID(selectedPatientID);

            reset();
        }

        private void GuardarHabits(string PatientID)
        {
            // Aquí debes obtener los valores de los campos del formulario de hábitos
            string NombreH = textBoxHabito.Text;
            string Cepillado = textBoxCepillado.Text;

            // Validar si el registro ya existe
            CHabits cHabits = new CHabits();
            if (cHabits.ExisteHabit(NombreH, Cepillado, PatientID))
            {
                MessageBox.Show("El hábito ya existe para este paciente.");
                return;
            }

            // Llamar al método GuardarHabits de la clase CHabits
            cHabits.GuardarHabits(Guid.NewGuid().ToString("N"), NombreH, Cepillado, PatientID);
        }

        private void GuardarAntecedents(string PatientID)
        {
            // Aquí debes obtener los valores de los campos del formulario de antecedentes
            string Hemorrágicos = textBoxHemorragicos.Text;
            string Personales = textBoxPersonales.Text;
            string Familiares = textBoxFamiliares.Text;

            // Validar si el registro ya existe
            CHabits cHabits = new CHabits();
            if (cHabits.ExisteAntecedent(Hemorrágicos, Personales, Familiares, PatientID))
            {
                MessageBox.Show("El antecedente ya existe para este paciente.");
                return;
            }

            // Llamar al método GuardarAntecedents de la clase CHabits
            cHabits.GuardarAntecedents(Guid.NewGuid().ToString("N"), Hemorrágicos, Personales, Familiares, PatientID);
        }

        private void textBoxHemorragicos_TextChanged(object sender, EventArgs e)
        {

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
                _selectedID = row.Cells["HabitsID"].Value.ToString();
                selectedPatientID = row.Cells["PatientID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxHabito.Text = row.Cells["NombreH"].Value.ToString();
                textBoxCepillado.Text = row.Cells["Cepillado"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Llenar los TextBox con los datos de la fila seleccionada
                antecedentsID = row.Cells["AntecedentsID"].Value.ToString();
                textBoxHemorragicos.Text = row.Cells["Hemorrágicos"].Value.ToString();
                textBoxPersonales.Text = row.Cells["Personales"].Value.ToString();
                textBoxFamiliares.Text = row.Cells["Familiares"].Value.ToString();

               
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            CHabits cHabits = new CHabits();
            bool habitosModificados = false;
            bool antecedentesModificados = false;

            // Guardar el filtro actual del DataGridView1
            string filtroActualDataGridView1 = "";
            if (dataGridView1.DataSource is DataTable dt1 && dt1.DefaultView.RowFilter != "")
            {
                filtroActualDataGridView1 = dt1.DefaultView.RowFilter;
            }

            // Verificar si se ha seleccionado un registro de hábitos
            if (!string.IsNullOrEmpty(_selectedID))
            {
                // Validar campos de hábitos
                string NombreH = textBoxHabito.Text;
                string Cepillado = textBoxCepillado.Text;

                if (string.IsNullOrEmpty(NombreH) || string.IsNullOrEmpty(Cepillado))
                {
                    MessageBox.Show("Por favor, complete todos los campos de hábitos.");
                    return;
                }

                // Modificar hábitos
                try
                {
                    cHabits.ModificarHabits(_selectedID, NombreH, Cepillado);
                    habitosModificados = true;
                    MessageBox.Show("Hábito modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar los hábitos: " + ex.Message);
                    return;
                }
            }

            // Verificar si se ha seleccionado un registro de antecedentes
            if (!string.IsNullOrEmpty(antecedentsID))
            {
                // Validar campos de antecedentes
                string Hemorrágicos = textBoxHemorragicos.Text;
                string Personales = textBoxPersonales.Text;
                string Familiares = textBoxFamiliares.Text;

                if (string.IsNullOrEmpty(Hemorrágicos) || string.IsNullOrEmpty(Personales) || string.IsNullOrEmpty(Familiares))
                {
                    MessageBox.Show("Por favor, complete todos los campos de antecedentes.");
                    return;
                }

                // Modificar antecedentes
                try
                {
                    cHabits.ModificarAntecedents(antecedentsID, Hemorrágicos, Personales, Familiares);
                    antecedentesModificados = true;
                    MessageBox.Show("Antecedente modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar los antecedentes: " + ex.Message);
                    return;
                }
            }

            // Actualizar los DataGridView
            DataTable dtHabits = cHabits.Habits();
            DataTable dtAntecedents = cHabits.Antecedents();

            // Asignar los DataTable a los DataGridView
            dataGridView1.DataSource = dtHabits;
            dataGridView2.DataSource = dtAntecedents;

            // Restaurar el filtro original del DataGridView1 si no estamos modificando hábitos
            if (!habitosModificados && !string.IsNullOrEmpty(filtroActualDataGridView1))
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = filtroActualDataGridView1;
            }

            // Aplicar el filtro por PatientID si está seleccionado
            if (!string.IsNullOrEmpty(selectedPatientID))
            {
                FiltrarPorPatientID(selectedPatientID);
            }

            // Aplicar el filtro para mostrar solo el registro modificado en el DataGridView1 (Hábitos)
            if (habitosModificados && !string.IsNullOrEmpty(_selectedID))
            {
                FiltrarPorHabitsID(_selectedID);
            }

            // Aplicar el filtro para mostrar solo el registro modificado en el DataGridView2 (Antecedentes)
            if (antecedentesModificados && !string.IsNullOrEmpty(antecedentsID))
            {
                FiltrarPorAntecedentsID(antecedentsID);
            }

            // Mostrar mensaje si no se realizaron modificaciones
            if (!habitosModificados && !antecedentesModificados)
            {
                MessageBox.Show("No se seleccionaron registros para modificar.");
            }

            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedID) && string.IsNullOrEmpty(antecedentsID))
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            // Eliminar hábitos y antecedentes
            CHabits cHabits = new CHabits();

            if (!string.IsNullOrEmpty(_selectedID))
            {
                cHabits.EliminarHabits(_selectedID);
            }

            if (!string.IsNullOrEmpty(antecedentsID))
            {
                cHabits.EliminarAntecedents(antecedentsID);
            }

            MessageBox.Show("Registros eliminados correctamente.");

            // Actualizar los DataGridView
            DataTable dtHabits = cHabits.Habits();
            DataTable dtAntecedents = cHabits.Antecedents();

            // Asignar los DataTable a los DataGridView
            dataGridView1.DataSource = dtHabits;
            dataGridView2.DataSource = dtAntecedents;

            // Aplicar el filtro por PatientID si está seleccionado
            if (!string.IsNullOrEmpty(selectedPatientID))
            {
                FiltrarPorPatientID(selectedPatientID);
            }

            // Aplicar el filtro para mostrar solo el registro eliminado en el DataGridView1 (Hábitos)
            if (!string.IsNullOrEmpty(_selectedID))
            {
                FiltrarPorHabitsID(_selectedID);
            }

            // Aplicar el filtro para mostrar solo el registro eliminado en el DataGridView2 (Antecedentes)
            if (!string.IsNullOrEmpty(antecedentsID))
            {
                FiltrarPorAntecedentsID(antecedentsID);
            }

            reset();
        }



        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                // Almacenar el ID del paciente seleccionado
                selectedPatientID = row.Cells["PatientID"].Value.ToString();

                // Opcional: Mostrar el ID seleccionado en un MessageBox para verificar
                MessageBox.Show("Paciente seleccionado: " + selectedPatientID);

                // Aplicar el filtro por PatientID
                FiltrarPorPatientID(selectedPatientID);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar1_TextChanged(object sender, EventArgs e)
        {
            string Buscar1 = textBoxBuscar1.Text;
            BuscarPacientes1(Buscar1);
        }

        private void BuscarPacientes1(string Buscar1)
        {
            DataTable dt3 = (DataTable)dataGridView3.DataSource;

            if (dt3 != null)
            {
                string filterExpression = "";
                foreach (DataColumn column in dt3.Columns)
                {
                    if (filterExpression != "")
                        filterExpression += " OR ";

                    // Verifica el tipo de la columna
                    if (column.DataType == typeof(string))
                    {
                        // Si es una cadena, aplica LIKE
                        filterExpression += $"{column.ColumnName} LIKE '%{Buscar1}%'";
                    }
                    else
                    {
                        // Si no es una cadena, convierte a cadena y usa LIKE
                        filterExpression += $"CONVERT({column.ColumnName}, System.String) LIKE '%{Buscar1}%'";
                    }
                }

                dt3.DefaultView.RowFilter = filterExpression;
            }

            if (dataGridView3.SelectedRows.Count > 0)
            {
                selectedPatientID = dataGridView3.SelectedRows[0].Cells["PatientID"].Value.ToString();
                FiltrarPorPatientID(selectedPatientID);
            }

        }

        private void FiltrarPorPatientID(string patientID)
        {
            if (string.IsNullOrEmpty(patientID))
            {
                return;
            }

            // Aplicar filtro a dataGridView1 (Hábitos)
            DataTable dt1 = (DataTable)dataGridView1.DataSource;
            if (dt1 != null)
            {
                dt1.DefaultView.RowFilter = $"PatientID = '{patientID}'";
            }

            // Aplicar filtro a dataGridView2 (Antecedentes)
            DataTable dt2 = (DataTable)dataGridView2.DataSource;
            if (dt2 != null)
            {
                dt2.DefaultView.RowFilter = $"PatientID = '{patientID}'";
            }
        }


        private void FiltrarPorHabitsID(string habitsID)
        {
            // Aplicar filtro a dataGridView1 (Hábitos)
            DataTable dt1 = (DataTable)dataGridView1.DataSource;
            if (dt1 != null)
            {
                dt1.DefaultView.RowFilter = $"HabitsID = '{habitsID}'";
            }
        }

        private void FiltrarPorAntecedentsID(string antecedentsID)
        {
            // Aplicar filtro a dataGridView2 (Antecedentes)
            DataTable dt2 = (DataTable)dataGridView2.DataSource;
            if (dt2 != null)
            {
                dt2.DefaultView.RowFilter = $"AntecedentsID = '{antecedentsID}'";
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                selectedPatientID = dataGridView3.SelectedRows[0].Cells["PatientID"].Value.ToString();
                FiltrarPorPatientID(selectedPatientID);
            }
        }
    }
}
