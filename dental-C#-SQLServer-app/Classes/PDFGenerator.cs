using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Classes
{
    internal class PDFGenerator
    {
        public void GeneratePdfFromDataTable(DataTable dataTable, string filePath)
        {
            // Configurar QuestPDF
            QuestPDF.Settings.License = LicenseType.Community; // Licencia gratuita para uso no comercial

            // Crear el documento PDF
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // Encabezado del PDF
                    page.Header()
                        .Text("Reporte de Pacientes")
                        .SemiBold().FontSize(18).AlignCenter();

                    // Contenido del PDF
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Table(table =>
                        {
                            // Definir las columnas de la tabla
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(); // ID
                                columns.RelativeColumn(); // Nombre
                                columns.RelativeColumn(); // Apellido
                                columns.RelativeColumn(); // Cédula
                                columns.RelativeColumn(); // Fecha de Nacimiento
                                columns.RelativeColumn(); // Edad
                                columns.RelativeColumn(); // Dirección
                                columns.RelativeColumn(); // Teléfono
                                columns.RelativeColumn(); // Sexo
                            });

                            // Encabezados de la tabla
                            table.Header(header =>
                            {
                                foreach (DataColumn column in dataTable.Columns)
                                {
                                    header.Cell().Text(column.ColumnName).Bold();
                                }
                            });

                            // Filas de la tabla
                            foreach (DataRow row in dataTable.Rows)
                            {
                                foreach (var item in row.ItemArray)
                                {
                                    table.Cell().Text(item.ToString());
                                }
                            }
                        });
                });
            })
            .GeneratePdf(filePath); // Guardar el PDF en la ruta especificada
        }
    }
}
