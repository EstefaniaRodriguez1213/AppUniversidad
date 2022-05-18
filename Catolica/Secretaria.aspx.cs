using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



namespace Catolica
{
    public partial class Secretaria : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            Panel2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand C1 = new SqlCommand("select Nombre from Alumno where DNI=@dni", conexion);
            C1.Parameters.AddWithValue("@dni", TextBox1.Text);
            string nombre = Convert.ToString((C1.ExecuteScalar()));

            if (nombre != "")
            {
                Label2.Text = "Datos encontrados:";
                Label2.Font.Size = 22;
                Label2.ForeColor = System.Drawing.Color.Black;
                Label3.Text = nombre;
                SqlCommand C2 = new SqlCommand("select Carrera from Alumno where DNI=@dni", conexion);
                C2.Parameters.AddWithValue("@dni", TextBox1.Text);
                string carrera = Convert.ToString((C2.ExecuteScalar()));
                Label4.Text = carrera;
                Label5.Text = TextBox1.Text;

                SqlCommand C3 = new SqlCommand("select a.Nombre 'Nombre del alumno', a.DNI, a.Carrera,p.TipoPPS 'Tipo de PPS', p.Condicion, p.Empresa 'Emppresa', p.Estado,p.Fec_Inicio 'Fecha de Inicio', p.Fec_Finalizacion 'Fecha de finalizacion', p.Inf_Av_Alumno_Empresa 'Inf. de Avance-Alumno', p.Inf_Av_Docente 'Inf. de Avance-Docente', p.Inf_Fial_Alumno 'Inf.Final Alumno', Inf_Fial_Docente 'Inf.Final Docente', p.Inf_Final_Empresa 'Inf.Final Empresa' from PPS p inner join alumno a on p.Id_Alumno= a.Id_Alumno where a.DNI=@dni", conexion);
                C3.Parameters.AddWithValue("@dni", TextBox1.Text);
                C3.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = C3;
                System.Data.DataTable tabla = new System.Data.DataTable();
                adaptador.Fill(tabla);
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;

                Panel2.Visible = true;
            }
            else
            {
                Panel2.Visible = true;
                Label2.Text = "El alumno no existe.";
                Label2.Font.Size = 25;
                Label2.ForeColor = System.Drawing.Color.Red;
                Label3.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
            }
            TextBox1.Text = "";
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conexion.Open();



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Label13.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {

                if (CheckBox2.Checked)
                {
                    SqlCommand C2 = new SqlCommand("update PPS set Inf_Av_Alumno_Empresa='Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C2.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C2.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand C2 = new SqlCommand("update PPS set Inf_Av_Alumno_Empresa=' No presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C2.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C2.ExecuteNonQuery();
                }

                if (CheckBox3.Checked)
                {
                    SqlCommand C3 = new SqlCommand("update PPS set [Inf_Av_Docente]='Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C3.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C3.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand C3 = new SqlCommand("update PPS set [Inf_Av_Docente]=' No presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C3.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C3.ExecuteNonQuery();
                }

                if (CheckBox4.Checked)
                {
                    SqlCommand C4 = new SqlCommand("update PPS set [Inf_Fial_Alumno]='Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C4.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C4.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand C4 = new SqlCommand("update PPS set [Inf_Fial_Alumno]=' No Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C4.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C4.ExecuteNonQuery();
                }
                if (CheckBox5.Checked)
                {
                    SqlCommand C5 = new SqlCommand("update PPS set [Inf_Final_Empresa]='Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C5.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C5.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand C5 = new SqlCommand("update PPS set [Inf_Final_Empresa]='No Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C5.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C5.ExecuteNonQuery();
                }
                if (CheckBox6.Checked)
                {
                    SqlCommand C6 = new SqlCommand("update PPS set [Inf_Fial_Docente]='Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C6.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C6.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand C6 = new SqlCommand("update PPS set [Inf_Fial_Docente]='No Presentado' where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C6.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C6.ExecuteNonQuery();
                }

                if (TextBox2.Text != string.Empty)
                {
                    SqlCommand C6 = new SqlCommand("update PPS set  [Nro_Resolucion] = @nroderes where Id_Alumno = (select a.Id_Alumno from alumno a inner join pps p on a.Id_Alumno=p.Id_Alumno where a.DNI = @dni)", conexion);
                    C6.Parameters.AddWithValue("@nroderes", TextBox2.Text);
                    C6.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
                    C6.ExecuteNonQuery();

                }

                System.Windows.Forms.MessageBox.Show("Datos cargados");
            }
            catch (Exception)
            {

            }
            conexion.Close();
        }
    }
}