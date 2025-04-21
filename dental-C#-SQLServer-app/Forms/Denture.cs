using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Validations.Dating_methods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Denture : Form
    {
        private string _DentureID;
        private string _OExamID;
        private bool _isEditing = false;

        public Denture(string OExamID)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(OExamID))
            {
                MessageBox.Show("Debe proporcionar un ID de examen oral válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _OExamID = OExamID;
            LoadDentureData();
        }

        private void LoadDentureData()
        {
            Denture_methods denture_Methods = new Denture_methods();
            dataGridView1.DataSource = denture_Methods.Denture(_OExamID);
            ResetForm();
        }

        private void ResetForm()
        {
            _DentureID = "";
            textBoxNumerodeaDiente.Text = "";
            textBoxCuadrante.Text = "";
            textBoxNombredeDiente.Text = "";
            textBoxCaradeDiente.Text = "";
            _isEditing = false;
            textBoxNumerodeaDiente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                Denture_methods denture_Methods = new Denture_methods();

                if (_isEditing)
                {
                    // Modificar registro existente
                    denture_Methods.Modificar(
                        _DentureID,
                        textBoxNumerodeaDiente,
                        textBoxCuadrante,
                        textBoxNombredeDiente,
                        textBoxCaradeDiente,
                        _OExamID);
                }
                else
                {
                    // Crear nuevo registro
                    denture_Methods.GuardarDenture(
                        textBoxNumerodeaDiente.Text,
                        textBoxCuadrante.Text,
                        textBoxNombredeDiente.Text,
                        textBoxCaradeDiente.Text,
                        _OExamID);
                }

                LoadDentureData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(_OExamID))
            {
                MessageBox.Show("No se ha especificado un examen oral válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxNumerodeaDiente.Text))
            {
                MessageBox.Show("El número de diente es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _DentureID = row.Cells["DentureID"].Value.ToString();
                _isEditing = true;

                textBoxNumerodeaDiente.Text = row.Cells["NumFDI"].Value?.ToString();
                textBoxCuadrante.Text = row.Cells["CuadranteD"].Value?.ToString();
                textBoxNombredeDiente.Text = row.Cells["NombreD"].Value?.ToString();
                textBoxCaradeDiente.Text = row.Cells["caraD"].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_DentureID) || string.IsNullOrEmpty(_OExamID))
            {
                MessageBox.Show("Seleccione un diente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este diente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Denture_methods denture_Methods = new Denture_methods();
                    denture_Methods.Eliminar(_DentureID, _OExamID);
                    LoadDentureData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Denture_Load(object sender, EventArgs e)
        {

        }
    }
}
