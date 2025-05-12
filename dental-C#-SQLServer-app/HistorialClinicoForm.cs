using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

public partial class HistorialClinicoForm : Form
{
    public HistorialClinicoForm()
    {
        InitializeComponent();
        // Configura ComboBox de pacientes
        cmbPacientes.DataSource = PacienteDAO.ObtenerTodos();
        cmbPacientes.DisplayMember = "Nombre";
    }

    private void btnGenerarPDF_Click(object sender, EventArgs e)
    {
        var paciente = (Paciente)cmbPacientes.SelectedItem;
        var datos = HistorialDAO.ObtenerDatos(paciente.Id);
        
        // Genera PDF en carpeta ./PDFs/
        string ruta = $"PDFs/Historial_{paciente.Id}_{DateTime.Now:yyyyMMdd}.pdf";
        PDFHelper.GenerarHistorial(datos, ruta);
        MessageBox.Show("PDF generado en: " + ruta);
    }
}
