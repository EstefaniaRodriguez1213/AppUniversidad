using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;


namespace Catolica
{
    public partial class Items : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel1.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel7.Visible = false;

            //ScriptManager scriptManager1 = ScriptManager.GetCurrent(this.Page); scriptManager1.RegisterPostBackControl(this.Button14);
            //ScriptManager scriptManager2 = ScriptManager.GetCurrent(this.Page); scriptManager2.RegisterPostBackControl(this.Button15);



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Panel3.Visible = true;
            Panel1.Visible = false;
            Panel4.Visible = false;
        }



        protected void Button6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            bool chequeado = false;
            bool chequeado1 = false;
            bool chequeado2 = false;
            bool chequeado3 = false;
            Label58.Visible = false;
            Label59.Visible = false;
            Label60.Visible = false;
            Label61.Visible = false;
            Label62.Visible = false;
            Label63.Visible = false;
            Label64.Visible = false;
            Label65.Visible = false;
            Label66.Visible = false;
            Label67.Visible = false;
            GridView1.DataSource = null;
            GridView1.DataBind();

            //Verifico si selecciono los radiobuttons de busqueda antes de buscar
            for (int i = 0; i <= RadioButtonList9.Items.Count - 1; i++)
            {
                if (RadioButtonList9.Items[i].Selected == true)
                {
                    chequeado = true;
                }
            }

            for (int j = 0; j <= RadioButtonList5.Items.Count - 1; j++)
            {
                if (RadioButtonList5.Items[j].Selected == true)
                {
                    chequeado1 = true;
                }
            }


            for (int k = 0; k <= RadioButtonList8.Items.Count - 1; k++)
            {
                if (RadioButtonList8.Items[k].Selected == true)
                {
                    chequeado2 = true;

                }
            }

            for (int l = 0; l <= RadioButtonList6.Items.Count - 1; l++)
            {
                if (RadioButtonList6.Items[l].Selected == true)
                {
                    chequeado3 = true;
                }
            }

            if (chequeado == true && chequeado1 == true && chequeado2 == true && chequeado3 == true)
            {
                string tipodepps = RadioButtonList9.SelectedValue;
                string condicion = RadioButtonList5.SelectedValue;
                string estado = RadioButtonList8.SelectedValue;
                string carrera = RadioButtonList6.SelectedValue;



                //T-T
                if (CheckBox1.Checked == true && CheckBox2.Checked == true)
                {
                    //NUEVO DESDE AQUI
                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.Carrera=@valor1", conexion);
                        C1.Parameters.AddWithValue("@valor1", carrera);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }

                    else if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado =@valor1", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion=@valor1", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        Label19.Text = "Datos encontrados";
                        Label19.ForeColor = System.Drawing.Color.Black;
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS=@valor1", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    //HASTA AQUI
                    else if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno ", conexion);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }

                    else if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {

                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor and p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3", conexion);
                        C1.Parameters.AddWithValue("@valor", tipodepps);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    else if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.Estado from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.TipoPPS=@valor3", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", tipodepps);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    else if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.TipoPPS=@valor2 and p.Estado=@valor3 ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", tipodepps);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    else if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado = @valor1 and a.Carrera=@valor2 ", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and p.Condicion=@valor2", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", condicion);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    else if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    else if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.Estado=@valor2 ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", estado);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    else if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }


                //F-F
                if (CheckBox1.Checked == false && CheckBox2.Checked == false)
                {
                    char[] vectorDisertante1 = TextBox6.Text.ToCharArray();
                    char[] vectorDisertante2 = TextBox9.Text.ToCharArray();

                    string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                    string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                    string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                    string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                    string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                    string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();



                    string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                    string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;

                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.Carrera=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }
                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado =@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);

                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {

                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor and p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor", tipodepps);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.TipoPPS=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", tipodepps);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.TipoPPS=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", tipodepps);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and p.Condicion=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", condicion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.Estado=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }


                //F-T           
                if (CheckBox1.Checked == false && CheckBox2.Checked == true)
                {
                    char[] vectorDisertante1 = TextBox6.Text.ToCharArray();
                    char[] vectorDisertante2 = TextBox9.Text.ToCharArray();

                    string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                    string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                    string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                    string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                    string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                    string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();



                    string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                    string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;

                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.Carrera=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }
                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado =@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);

                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS=@valor1 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) ", conexion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {

                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor and p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) ", conexion);
                        C1.Parameters.AddWithValue("@valor", tipodepps);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.TipoPPS=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", tipodepps);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.TipoPPS=@valor2 and p.Estado=@valor3 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", tipodepps);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) ", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and p.Condicion=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", condicion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2) ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.Estado=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", estado);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and (p.Fec_Inicio between  @fecha1 and @fecha2) and (p.Fec_Finalizacion between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }


                // T-F

                if (CheckBox1.Checked == true && CheckBox2.Checked == false)
                {
                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.Carrera=@valor1 and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", carrera);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }
                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado =@valor1 and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion=@valor1 and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);

                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS=@valor1 and p.Empresa=@empresa", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps == "Todo" && condicion == "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }

                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {

                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor and p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor", tipodepps);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Estado=@valor3 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.TipoPPS=@valor3 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@valor3", tipodepps);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }



                    if (tipodepps != "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.TipoPPS=@valor2 and p.Estado=@valor3 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", tipodepps);
                        C1.Parameters.AddWithValue("@valor3", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps == "Todo" && condicion == "Todo" && estado != "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Estado = @valor1 and a.Carrera=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", estado);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps != "Todo" && condicion != "Todo" && estado == "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and p.Condicion=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", condicion);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps == "Todo" && condicion != "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and a.Carrera=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    if (tipodepps != "Todo" && condicion == "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }

                    if (tipodepps == "Todo" && condicion != "Todo" && estado != "Todo" && carrera == "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Condicion = @valor1 and p.Estado=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", condicion);
                        C1.Parameters.AddWithValue("@valor2", estado);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }


                    if (tipodepps != "Todo" && condicion == "Todo" && estado == "Todo" && carrera != "Todo")
                    {
                        SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Estado] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.TipoPPS = @valor1 and a.Carrera=@valor2 and p.Empresa=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", tipodepps);
                        C1.Parameters.AddWithValue("@valor2", carrera);
                        C1.Parameters.AddWithValue("@empresa", DropDownList6.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor = Convert.ToString((C1.ExecuteScalar()));
                        if (valor != "")
                        {
                            Label19.Text = "Datos encontrados";
                            Label19.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView1.DataSource = tabla;
                            GridView1.DataBind();
                            GridView1.Visible = true;
                            Panel1.Visible = true;
                            Label58.Visible = true;
                        }
                        else
                        {
                            Panel1.Visible = true;
                            Label19.Visible = true;
                            Label19.Text = "No se encontraron registros coincidentes";
                            Label19.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            else { System.Windows.Forms.MessageBox.Show("Parece que olvido seleccionar algun parametro. Verificar"); }
            TextBox6.Text = "";
            TextBox9.Text = "";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
           

            int finalizada = 0;
            int encurso = 0;
            int baja = 0;
            int vencida = 0;
            int fil = 0;
            int fila = 0;

            foreach (GridViewRow row in GridView1.Rows)
            {
                string valorCelda = Convert.ToString(GridView1.Rows[fil].Cells[7].Text);
                if (Convert.ToString(GridView1.Rows[fil].Cells[7].Text) == "&nbsp;")

                {

                        SqlCommand fecha = new SqlCommand("select 1 from pps p inner join Alumno a on p.Id_Alumno= a.Id_Alumno where (GETDATE() between p.[Fec_Inicio] and p.[Fec_Finalizacion]) and a.DNI=@valor", conexion);
                        fecha.Parameters.AddWithValue("@valor", GridView1.Rows[fil].Cells[2].Text);
                        fecha.ExecuteNonQuery();
                        int va = Convert.ToInt32((fecha.ExecuteScalar()));

                        if (va == 1)
                        {
                            GridView1.Rows[fil].Cells[7].Text = "En curso";
                            SqlCommand modif = new SqlCommand("UPDATE pps SET Estado = 'En curso' FROM pps p INNER JOIN alumno a ON p.Id_alumno = a.Id_alumno  where a.DNI = @valor ", conexion);
                            modif.Parameters.AddWithValue("@valor", GridView1.Rows[fil].Cells[2].Text);
                            modif.ExecuteNonQuery();

                        }
                        else
                        {
                            GridView1.Rows[fil].Cells[7].Text = "Vencida";
                            SqlCommand modif = new SqlCommand("UPDATE pps SET Estado = 'Vencida' FROM pps p INNER JOIN alumno a ON p.Id_alumno = a.Id_alumno  where a.DNI = @valor", conexion);
                            modif.Parameters.AddWithValue("@valor", GridView1.Rows[fil].Cells[2].Text);
                            modif.ExecuteNonQuery();

                        }

                    }
                fil = fil + 1;
                
            }
               
            

            

            conexion.Close();

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (GridView1.Rows[fila].Cells[7].Text == "Vencida")
                {
                    vencida++;
                }
                else if (GridView1.Rows[fila].Cells[7].Text == "Baja")
                {
                    baja++;
                }
                else if (GridView1.Rows[fila].Cells[7].Text == "Finalizada")
                {
                    finalizada++;
                }
                else if (GridView1.Rows[fila].Cells[7].Text == "En curso")
                {
                    encurso++;
                }
                fila++;
            }
            Label58.Visible = true;
            Label59.Visible = true;
            Label60.Visible = true;
            Label61.Visible = true;
            Label62.Visible = true;
            Label63.Visible = true;
            Label63.Text = this.GridView1.Rows.Count.ToString();

            Label64.Visible = true;
            Label64.Text = Convert.ToString(vencida);

            Label65.Visible = true;
            Label65.Text = Convert.ToString(finalizada);

            Label66.Visible = true;
            Label66.Text = Convert.ToString(baja);

            Label67.Visible = true;
            Label67.Text = Convert.ToString(encurso);

           

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Convenio.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel4.Visible = true;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel4.Visible = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand C1 = new SqlCommand("insert into Alumno (Nombre, DNI, Carrera, Mail, Telefono) values (@valor1, @valor2, @valor3, @valor4, @valor5)", conexion);
            C1.Parameters.AddWithValue("@valor1", TextBox4.Text);
            C1.Parameters.AddWithValue("@valor2", TextBox5.Text);
            C1.Parameters.AddWithValue("@valor3", DropDownList1.SelectedItem.Text);
            C1.Parameters.AddWithValue("@valor4", TextBox7.Text);
            C1.Parameters.AddWithValue("@valor5", TextBox8.Text);
            C1.ExecuteNonQuery();

            SqlCommand C2 = new SqlCommand("insert into PPS ([Id_Alumno], [TipoPPS],[Condicion], [Empresa],[Supervisor_Empresa], [Tareas],  [Fec_Inicio],[Fec_Finalizacion],  [Horario_de_Trabajo]) values ((select Id_Alumno from Alumno where DNI=@valor), @valor6, @valor7, @valor8, @valor9, @valor10, @valor11, @valor12, @valor15)", conexion);
            C2.Parameters.AddWithValue("@valor", TextBox5.Text);
            C2.Parameters.AddWithValue("@valor6", DropDownList2.SelectedItem.Text);
            C2.Parameters.AddWithValue("@valor7", DropDownList3.SelectedItem.Text);
            C2.Parameters.AddWithValue("@valor8", TextBox11.Text);
            C2.Parameters.AddWithValue("@valor9", TextBox12.Text);
            C2.Parameters.AddWithValue("@valor10", TextBox13.Text);
            C2.Parameters.AddWithValue("@valor11", TextBox14.Text);
            C2.Parameters.AddWithValue("@valor12", TextBox15.Text);
            C2.Parameters.AddWithValue("@valor15", TextBox1.Text);
            C2.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Datos cargados.");
            conexion.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {


        }



        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuario.aspx");
        }




        protected void Calendar2_SelectionChanged1(object sender, EventArgs e)
        {

            //Label52.Text = Calendar2.SelectedDate.ToString("dd/MM/yyyy");
            //Label52.Visible = true;
            //Panel2.Visible = true;
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            //Label54.Text = Calendar3.SelectedDate.ToString("dd/MM/yyyy");
            //Label54.Visible = true;
            //Panel2.Visible = true;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Calendar2.Visible = true;
            //Panel2.Visible = true;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //Calendar3.Visible = true;
            //Panel2.Visible = true;
        }





        protected void Button9_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            conexion.Open();
            Label57.Visible = false;
            Label58.Visible = false;
            Label59.Visible = false;
            Label60.Visible = false;
            Label61.Visible = false;
            Label62.Visible = false;
            Label63.Visible = false;
            Label64.Visible = false;
            Label65.Visible = false;
            Label66.Visible = false;
            Label67.Visible = false;
            if (DropDownList4.SelectedValue == "Alumno")
            {
                SqlCommand C1 = new SqlCommand("select a.[Nombre], a.DNI from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.Nombre LIKE '%' + @nombre + '%'", conexion);
                //a.[DNI], a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Supervisor_Empresa], p.[Fec_Inicio], p.[Fec_Finalizacion], p.[Estado], p.[Horario_de_Trabajo]
                C1.Parameters.AddWithValue("@nombre", TextBox3.Text);
                C1.ExecuteNonQuery();
                string valor = Convert.ToString((C1.ExecuteScalar()));
                if (valor != "")
                {

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = C1;
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    adaptador.Fill(tabla);
                    GridView1.DataSource = tabla;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    Panel1.Visible = true;
                    Panel8.Visible = true;

                }
                else
                {
                    Panel1.Visible = true;
                    Label19.Text = "No se encontraron registros coincidentes";
                    Label19.ForeColor = System.Drawing.Color.Red;
                }
            }
            else if (DropDownList4.SelectedValue == "Empresa")
            {
                SqlCommand C1 = new SqlCommand("select p.[Empresa], a.[DNI], a.[Nombre],  a.[Carrera], p.[TipoPPS] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where p.Empresa LIKE '%' + @Empresa + '%'", conexion);
                C1.Parameters.AddWithValue("@Empresa", DropDownList5.SelectedValue);
                C1.ExecuteNonQuery();
                string valor = Convert.ToString((C1.ExecuteScalar()));
                if (valor != "")
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = C1;
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    adaptador.Fill(tabla);
                    GridView1.DataSource = tabla;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    Panel1.Visible = true;
                    Label63.Visible = true;
                    Label57.Visible = true;
                    Label58.Visible = true;
                    Label63.Text = this.GridView1.Rows.Count.ToString();
                    Panel8.Visible = true;
                }
                else
                {
                    Panel1.Visible = true;
                    Label19.Text = "No se encontraron registros coincidentes";
                    Label19.ForeColor = System.Drawing.Color.Red;
                }
            }


            else if (DropDownList4.SelectedValue == "D.N.I")
            {
                SqlCommand C1 = new SqlCommand("select a.[Nombre],  a.[DNI] from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.DNI=  @dni", conexion);
                //a.[Carrera], p.[TipoPPS], p.[Condicion], p.[Empresa], p.[Supervisor_Empresa], p.[Fec_Inicio], p.[Fec_Finalizacion], p.[Estado], p.[Horario_de_Trabajo]
                C1.Parameters.AddWithValue("@dni", TextBox3.Text);
                C1.ExecuteNonQuery();
                string valor = Convert.ToString((C1.ExecuteScalar()));
                if (valor != "")
                {

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = C1;
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    adaptador.Fill(tabla);
                    GridView1.DataSource = tabla;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                    Panel1.Visible = true;
                    Panel8.Visible = true;

                }
                else
                {
                    Panel1.Visible = true;
                    Label19.Text = "No se encontraron registros coincidentes";
                    Label19.ForeColor = System.Drawing.Color.Red;
                }
            }
            TextBox3.Text = "";
            conexion.Close();
        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            Panel7.Visible = true;
            Label68.Text = GridView1.SelectedRow.Cells[1].Text;
            SqlCommand C1 = new SqlCommand("select a.[Nombre] 'Nombre del alumno',  a.[DNI], a.[Carrera], p.[TipoPPS] 'Tipo de PPS', p.[Condicion], p.[Empresa], p.[Supervisor_Empresa] 'Supervisor', p.[Fec_Inicio] 'Fecha de inicio', p.[Fec_Finalizacion] 'Fecha de finalizacion', p.[Estado], p.[Horario_de_Trabajo] 'Horario de trabajo', p.[Inf_Av_Alumno_Empresa] 'Informe de avance-alumno', p.[Inf_Av_Docente] 'Informe de avance-docente', p.[Inf_Fial_Alumno] 'Informe final-alumno', p.[Inf_Final_Empresa] 'Informe final-empresa', p.[Inf_Fial_Docente] 'Informe final-docente', p.[Nro_Resolucion] 'Nro de resolucion'  from pps p inner join alumno a on p.Id_Alumno = a.Id_Alumno where a.DNI=  @dni", conexion);
            C1.Parameters.AddWithValue("@dni", GridView1.SelectedRow.Cells[2].Text);
            C1.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = C1;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            GridView3.DataSource = tabla;
            GridView3.DataBind();
            GridView3.Visible = true;

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Secretaria.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Capacitaciones.aspx");
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            conexion.Open();
            GridView3.DataSource = null;
            GridView3.DataBind();
            TextBox3.Text = "";
            if (DropDownList4.SelectedValue == "Otro")
            {
                Panel2.Visible = true;
                SqlCommand cmd = new SqlCommand("select Empresa from PPS", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DropDownList6.DataSource = ds;
                DropDownList6.DataTextField = "Empresa";
                DropDownList6.DataValueField = "Empresa";
                DropDownList6.DataBind();
                DropDownList6.Visible = true;

            }
            else if (DropDownList4.SelectedValue == "Empresa")
            {
                Panel5.Visible = true;
                TextBox3.Visible = false;
                Label26.Text = "Nombre de la empresa";
                SqlCommand cmd = new SqlCommand("select Empresa from PPS", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DropDownList5.DataSource = ds;
                DropDownList5.DataTextField = "Empresa";
                DropDownList5.DataValueField = "Empresa";
                DropDownList5.DataBind();
                DropDownList5.Visible = true;


            }
            else if (DropDownList4.SelectedValue == "Alumno")
            {
                Panel5.Visible = true;
                Label26.Text = "Nombre del alumno";
                TextBox3.Visible = true;
                DropDownList5.Visible = false;

            }
            else if (DropDownList4.SelectedValue == "D.N.I")
            {
                Panel5.Visible = true;
                Label26.Text = "D.N.I del alumno";
                TextBox3.Visible = true;
                DropDownList5.Visible = false;
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand modif = new SqlCommand("UPDATE pps SET Estado = 'Finalizada' FROM pps p INNER JOIN alumno a ON p.Id_alumno = a.Id_alumno  where a.DNI = @valor", conexion);
            modif.Parameters.AddWithValue("@valor", GridView3.SelectedRow.Cells[2].Text);
            modif.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("PPS finalizada.");
            conexion.Close();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand modif = new SqlCommand("UPDATE pps SET Estado = 'Baja', Observaciones=@text FROM pps p INNER JOIN alumno a ON p.Id_alumno = a.Id_alumno  where a.DNI = @valor", conexion);
            modif.Parameters.AddWithValue("@valor", GridView3.Rows[0].Cells[2].Text);
            modif.Parameters.AddWithValue("@text", TextBox16.Text);
            modif.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("PPS dada de baja.");
            conexion.Close();
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {

            MetodoReporte pdf = new MetodoReporte();
            pdf.GenerarPDF(GridView1);

        }
 
        protected void Button8_Click1(object sender, EventArgs e)
        {
            MetodoReporte pdf = new MetodoReporte();
            pdf.generarExcel(GridView1);
          
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
    }
}