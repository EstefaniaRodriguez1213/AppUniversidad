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
    public partial class Usuario : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel7.Visible = false;
            Panel9.Visible = false;
            Panel11.Visible = false;
            Panel10.Visible = false;
         
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Panel7.Visible = true;
            Panel9.Visible = false;
            Panel11.Visible = false;
            Panel10.Visible = false;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Panel9.Visible = true;
            Panel10.Visible = false;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand C2 = new SqlCommand("insert into Usuario (Usuario, Contraseña, TipoUsuario) values (@valor1, @valor2, @valor3)", conexion);
            C2.Parameters.AddWithValue("@valor1", TextBox16.Text);
            C2.Parameters.AddWithValue("@valor2", TextBox17.Text);
            C2.Parameters.AddWithValue("@valor3", DropDownList4.SelectedItem.Text);
            C2.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Usuario dado de alta.");

            TextBox16.Text = "";
            TextBox17.Text = "";
            conexion.Close();
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Panel10.Visible = true;
            conexion.Open();
            SqlCommand c2 = new SqlCommand("select 1 from Usuario where Usuario=@valor and Contraseña=@valor1", conexion);
            c2.Parameters.AddWithValue("@valor", TextBox18.Text);
            c2.Parameters.AddWithValue("@valor1", TextBox19.Text);
            c2.ExecuteNonQuery();
            int valores = Convert.ToInt32((c2.ExecuteScalar()));
            if (valores == 1)
            {
                SqlCommand u2 = new SqlCommand("delete Usuario where Usuario=@valor and Contraseña=@valor1", conexion);
                u2.Parameters.AddWithValue("@valor", TextBox18.Text);
                u2.Parameters.AddWithValue("@valor1", TextBox19.Text);
                u2.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("El usuario fue dado de baja.");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El usuario no existe.");
            }
            conexion.Close();
        }

        protected void DropDownList5_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand c2 = new SqlCommand("select Usuario, Contraseña, TipoUsuario from Usuario", conexion);
            c2.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = c2;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            GridView1.DataSource = tabla;
            GridView1.DataBind();
            Panel9.Visible = true;
          
            Panel11.Visible = false;
            Panel10.Visible = false;
            conexion.Close();
        }

     
         

        protected void Button17_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Panel9.Visible = true;
            SqlCommand comando = new SqlCommand("Select Usuario 'Nombre de Usuario', Contraseña, TipoUsuario 'Rol de Usuario' from usuario",conexion);
            comando.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            GridView1.DataSource = tabla;
            GridView1.DataBind();
            GridView2.DataSource = tabla;
            GridView2.DataBind();

            if (DropDownList5.SelectedValue == "Dar de baja")
            {
                Panel10.Visible = true;
                Panel9.Visible = false;
            }
            if (DropDownList5.SelectedValue == "Modificar")
            {
                Panel9.Visible = true;
                Panel10.Visible = false;
            }
            conexion.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel11.Visible = true;
            TextBox18.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox19.Text = GridView1.SelectedRow.Cells[2].Text;
           


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand c1 = new SqlCommand("delete from Usuario where Usuario=@valor1 and Contraseña=@valor2", conexion);
            c1.Parameters.AddWithValue("@valor1", GridView2.SelectedRow.Cells[1].Text);
            c1.Parameters.AddWithValue("@valor2", GridView2.SelectedRow.Cells[2].Text);
            c1.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Usuario dado de baja");
            conexion.Close();
        }

        protected void Button18_Click1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand c1 = new SqlCommand("update Usuario set Usuario=@valor1, Contraseña=@valor2 where Usuario=@valant and Contraseña=@valoant1", conexion);
            c1.Parameters.AddWithValue("@valor1", TextBox18.Text);
            c1.Parameters.AddWithValue("@valor2", TextBox19.Text);
            c1.Parameters.AddWithValue("@valant", GridView1.SelectedRow.Cells[1].Text);
            c1.Parameters.AddWithValue("@valoant1", GridView1.SelectedRow.Cells[2].Text);
            c1.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Usuario modificado");
            TextBox18.Text = "";
            TextBox19.Text = "";
            conexion.Close();
        }
    }
    
}