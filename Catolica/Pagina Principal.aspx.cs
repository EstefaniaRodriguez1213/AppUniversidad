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
    public partial class Pagina_Principal : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty && TextBox2.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar datos");

            }
            else if (TextBox1.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar un usuario");
            }
            else if (TextBox2.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar una contraseña");
            }
            else
            {
                conexion.Open();
                SqlCommand validar = new SqlCommand("if exists (select 1 from Usuario u where u.Usuario=@valor1 and u.Contraseña=@valor2) begin select 1 from Usuario where Usuario = @valor1 and Contraseña=@valor2 end", conexion);
                validar.Parameters.AddWithValue("@valor1", TextBox1.Text);
                validar.Parameters.AddWithValue("@valor2", TextBox2.Text);
                int tipo = Convert.ToInt32((validar.ExecuteScalar()));

                if (tipo == 1)

                {

                    SqlCommand C1 = new SqlCommand("select TipoUsuario from Usuario where Usuario = @valor1 and Contraseña = @valor2", conexion);
                    C1.Parameters.AddWithValue("@valor1", TextBox1.Text);
                    C1.Parameters.AddWithValue("@valor2", TextBox2.Text);
                    string tipousuario = Convert.ToString((C1.ExecuteScalar()));

                    if (tipousuario == "Administrador")
                    {
                        Response.Redirect("Menu.aspx");
                    }
                    else
                    {
                        Response.Redirect("Secretaria.aspx");
                    }
                    conexion.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El usuario y/o contraseña no existe.");
                }
            }
            conexion.Close();
        }
    }
}