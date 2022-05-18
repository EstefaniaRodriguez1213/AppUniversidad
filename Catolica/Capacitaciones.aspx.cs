using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Catolica
{

    public partial class Capacitaciones : System.Web.UI.Page
    {

        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = false;
            Panel3.Visible = false;
        }
  
        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Panel2.Visible = true;
            SqlCommand cmd = new SqlCommand("select Actividad_Titulo from Capacitacion", conexion);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "Actividad_Titulo";
            DropDownList2.DataValueField = "Actividad_Titulo";
            DropDownList2.DataBind();
            conexion.Close();
        }

      
        protected void Button15_Click(object sender, EventArgs e)
        {           
        
        }



        protected void Button16_Click1(object sender, EventArgs e)
        {
           

        }

        protected void Button14_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string valorSeleccionado = RadioButtonList1.SelectedValue;

            //T-T
            if (CheckBox1.Checked == true && CheckBox2.Checked == true)
            {
                if (valorSeleccionado == "Todo")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Cantidad de docentes', Part_ALmunos 'Cantidad de alumnos', Part_Egresados 'Cantidad de egresados', Part_Otros 'Otros participantes', Otra_Info 'Otra informacion' from Capacitacion", conexion);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Alumnos")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_ALmunos 'Cantidad de alumnos participantes', Otra_Info 'Otra informacion' from Capacitacion ", conexion);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Docente")
                {

                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance',Part_Docentes 'Cantidad de Docentes particpantes', Otra_Info 'Otra informacion' from Capacitacion ", conexion);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Egresados")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance',Part_Egresados 'Cantidad de egresados participantes', Otra_Info 'Otra informacion' from Capacitacion ", conexion);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Otros")
                {
                
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance',Part_Otros 'Otros Participantes', Otra_Info 'Otra informacion' from Capacitacion ", conexion);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }

            //T-F
            if (CheckBox1.Checked == true && CheckBox2.Checked == false)
            {
                if (valorSeleccionado == "Todo")
                {

                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Participantes Docentes', Part_ALmunos 'Participantes Alumnos', Part_Egresados 'Participantes Egresados', Part_Otros 'Otros Participantes', Otra_Info 'Otra informacion' from Capacitacion where Actividad_Titulo = @valor ", conexion);
                    comando.Parameters.AddWithValue("@capacitacion", DropDownList2.SelectedValue);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Alumnos")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_ALmunos 'Alumnos Participantes', Otra_Info 'Otra informacion' from Capacitacion where Actividad_Titulo = @valor ", conexion);
                    comando.Parameters.AddWithValue("@valor", DropDownList2.SelectedValue);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Docente")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Participantes docentes', Otra_Info 'Otra informacion'  from Capacitacion where Actividad_Titulo = @valor ", conexion);
                    comando.Parameters.AddWithValue("@valor", DropDownList2.SelectedValue);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Egresados")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Egresados 'Participantes docentes', Otra_Info 'Otra informacion'  from Capacitacion where Actividad_Titulo = @valor ", conexion);
                    comando.Parameters.AddWithValue("@valor", DropDownList2.SelectedValue);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Otros")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance',Part_Otros 'Otros participantes', Otra_Info 'Otra informacion'  from Capacitacion where Actividad_Titulo = @capacitacion ", conexion);
                    comando.Parameters.AddWithValue("@capacitacion", DropDownList2.SelectedValue);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            //F-T
            if (CheckBox1.Checked == false && CheckBox2.Checked == true)
            {
                char[] vectorDisertante1 = TextBox15.Text.ToCharArray();
                char[] vectorDisertante2 = TextBox9.Text.ToCharArray();

                string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();

                string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;
                if (valorSeleccionado == "Todo")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes Docentes participantes, Part_ALmunos 'Alumnos participantes', Part_Egresados 'Egresados participantes', Part_Otros 'Otros participantes', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) ", conexion);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta );
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Alumnos")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_ALmunos 'Participantes alumnos', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) ", conexion);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2",fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Docente")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Docentes participantes', Otra_Info  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) ", conexion);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Egresados")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Egresados 'Participantes egresados', Otra_Info 'Otra informacion' from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) ", conexion);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Otros")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Otros 'Otros participantes', Otra_Info 'Otra informacion' from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) ", conexion);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            //F-F
        if (CheckBox1.Checked == false && CheckBox2.Checked == false)
            {
                char[] vectorDisertante1 = TextBox15.Text.ToCharArray();
                char[] vectorDisertante2 = TextBox9.Text.ToCharArray();

                string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();



                string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;

                if (valorSeleccionado == "Todo")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Docentes participantes', Part_ALmunos 'Alumnos participantes', Part_Egresados 'Egresados participantes', Part_Otros 'Otros participantes', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) and Actividad_Titulo=@capac ", conexion);
                    comando.Parameters.AddWithValue("@capac", DropDownList2.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Alumnos")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_ALmunos 'Alumnos participantes', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) and Actividad_Titulo=@capac ", conexion);
                    comando.Parameters.AddWithValue("@capac", DropDownList2.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Docente")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Docentes 'Participantes Docentes', Otra_Info 'Otra informacion' from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) and Actividad_Titulo=@capac ", conexion);
                    comando.Parameters.AddWithValue("@capac", DropDownList2.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Egresados")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Egresados 'Participantes Egresados ', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) and Actividad_Titulo=@capac ", conexion);
                    comando.Parameters.AddWithValue("@capac", DropDownList2.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2",fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valorSeleccionado == "Otros")
                {
                    SqlCommand comando = new SqlCommand("select Actividad_Titulo 'Nombre de la actividad', Objetivos, Fecha_Incio 'Fecha de Inicio', Fecha_Fin 'Fecha de Fin', Actividades_Prev 'Actividades previstas', Estado_Avance 'Estado de avance', Part_Otros 'Otros particpantes', Otra_Info 'Otra informacion'  from Capacitacion where (Fecha_Incio between  @fecha1 and @fecha2) and (Fecha_Fin between @fecha1 and @fecha2) and Actividad_Titulo=@capac ", conexion);
                    comando.Parameters.AddWithValue("@capac", DropDownList2.SelectedValue);
                    comando.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    comando.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    comando.ExecuteNonQuery();
                    string valor = Convert.ToString((comando.ExecuteScalar()));
                    if (valor != "")
                    {
                        Label56.Text = "Datos encontrados:";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        Panel3.Visible = true;
                    }
                    else
                    {
                        Panel3.Visible = true;
                        Label56.Text = "No se encontraron datos concidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            TextBox15.Text = "";
            TextBox9.Text = "";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false; 
            Label63.Text = this.GridView2.Rows.Count.ToString();
            conexion.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Label18.Text = TextBox8.Text + ";" + Label18.Text;
            TextBox8.Text = "";
        }

        protected void Button15_Click1(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand C1 = new SqlCommand("begin insert into Capacitacion ([Actividad_Titulo],[Objetivos],[Fecha_Incio],[Fecha_Fin],[Actividades_Prev],[Estado_Avance],[Part_Docentes],[Part_ALmunos],[Part_Egresados],[Part_Otros],[Otra_Info], Carrera_Vincula) values (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7, @valor8, @valor9, @valor10,  @valor11 , @valor12) end", conexion);
            C1.Parameters.AddWithValue("@valor1", TextBox1.Text);
            C1.Parameters.AddWithValue("@valor2", TextBox2.Text);
            C1.Parameters.AddWithValue("@valor3", TextBox3.Text);
            C1.Parameters.AddWithValue("@valor4", TextBox4.Text);
            C1.Parameters.AddWithValue("@valor5", TextBox5.Text);
            C1.Parameters.AddWithValue("@valor6", TextBox6.Text);
            C1.Parameters.AddWithValue("@valor12", DropDownList1.SelectedValue);
            C1.Parameters.AddWithValue("@valor7", TextBox12.Text);
            C1.Parameters.AddWithValue("@valor8", TextBox13.Text);
            C1.Parameters.AddWithValue("@valor9", TextBox14.Text);
            C1.Parameters.AddWithValue("@valor10", TextBox7.Text);
            C1.Parameters.AddWithValue("@valor11", TextBox11.Text);
            C1.ExecuteNonQuery();

            SqlCommand C2 = new SqlCommand("select max(Id_Capacitacion) from Capacitacion", conexion);
            int valor = Convert.ToInt32((C2.ExecuteScalar()));

            string disertantes = Label18.Text;
            char[] vectorDisertante = disertantes.ToCharArray();
            string nombreDisertante = "";

            foreach (char letra in vectorDisertante)
            {

                if (letra != ';')
                {
                    nombreDisertante = nombreDisertante + letra;
                }
                else
                {

                    SqlCommand Disertante = new SqlCommand("insert into Disertante (Disertante, Id_Capacitacion) values (@disertante, @Id)", conexion);
                    Disertante.Parameters.AddWithValue("@disertante", nombreDisertante);
                    Disertante.Parameters.AddWithValue("@Id", valor);
                    Disertante.ExecuteNonQuery();
                    nombreDisertante = "";

                }
            }

            System.Windows.Forms.MessageBox.Show("Datos cargados correctamente.");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox7.Text = "";
            TextBox11.Text = "";
            Label18.Text = "";
            conexion.Close();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            MetodoReporte pdf = new MetodoReporte();
            pdf.generarExcel(GridView2);
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MetodoReporte pdf = new MetodoReporte();
            pdf.GenerarPDF(GridView2);
        }
    }
    }
