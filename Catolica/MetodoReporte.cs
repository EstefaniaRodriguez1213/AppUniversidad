using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web;

namespace Catolica
{
    public class MetodoReporte
    {
        public void GenerarPDF(GridView gv)
        {

            DateTime fecha = DateTime.Now;
            string nombreArchivo = fecha.ToString("ss");
            string ruta = @"C:\Reportes\";
            string extension = ".pdf";

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta + "ReportePPS" + nombreArchivo + extension, FileMode.CreateNew));
            doc.AddTitle("PDF");
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            doc.Add(new Paragraph("UCASAL"));
            doc.Add(new Paragraph("Departamento de Extension y Graduados."));
            doc.Add(new Paragraph("Reporte:"));
            doc.Add(Chunk.NEWLINE);

            int CC = gv.HeaderRow.Cells.Count;
            PdfPTable table = new PdfPTable(CC);

            foreach (TableCell tc in gv.HeaderRow.Cells)
            {
                table.AddCell(new Paragraph(tc.Text));
            }

            foreach (GridViewRow gvv in gv.Rows)
            {
                foreach (TableCell cell in gvv.Cells)
                {
                    table.AddCell(cell.Text);

                }

            }

            doc.Add(table);
            doc.Close();
            writer.Close();
            System.Windows.Forms.MessageBox.Show("PDF generado correctamente.");

        }


        public void generarExcel(GridView gv)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=Rep_PPS.xls");
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter tw = new HtmlTextWriter(sw);
                gv.AllowPaging = false;
                gv.HeaderRow.BackColor = System.Drawing.Color.White;

                foreach (TableCell tc in gv.HeaderRow.Cells)
                {
                    tc.BackColor = System.Drawing.Color.White;

                }
                foreach (GridViewRow gdr in gv.Rows)
                {
                    gdr.BackColor = System.Drawing.Color.White;
                    foreach (TableCell cell in gdr.Cells)
                    {
                        if (gdr.RowIndex % 2 == 0)
                        {
                            cell.BackColor = gv.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = gv.RowStyle.BackColor;
                        }
                        cell.CssClass = "textmode";
                    }

                }
                gv.RenderControl(tw);

                string style = @"<style> .textmode { } </style>";
                HttpContext.Current.Response.Write(style);
                HttpContext.Current.Response.Output.Write(sw.ToString());
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
        }

    }
    }