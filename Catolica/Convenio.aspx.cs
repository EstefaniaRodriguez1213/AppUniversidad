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
    public partial class Convenio : System.Web.UI.Page
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-OPOV2BO\\SQLEXPRESS; database=DptodeExtension; integrated security=true ");
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel4.Visible = false;
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible = false;
            Panel5.Visible = false;
        }



        protected void Button12_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible = false;
            Panel5.Visible = false;
            //Button19.Enabled = false;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel4.Visible = false;
            Button20.Visible = false;
            SqlCommand cmd = new SqlCommand("select Empresa_Institucion from Convenio", conexion);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "Empresa_Institucion";
            DropDownList3.DataValueField = "Empresa_Institucion";
            DropDownList3.DataBind();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                TextBox1.Enabled = false;

            }
            else if (CheckBox2.Checked == false && TextBox1.Text == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Debe agregar una fecha de finalizacion.");

            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text != string.Empty && TextBox5.Text != string.Empty && TextBox8.Text != string.Empty)
            {
                conexion.Open();
                SqlCommand C1 = new SqlCommand("select * from Convenio", conexion);
                C1.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Datos cargados.");
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = C1;
                System.Data.DataTable tabla = new System.Data.DataTable();
                //adaptador.Fill(tabla);
                //GridView1.DataSource = tabla;
                //GridView1.DataBind();
             

                Panel4.Visible = false;

                //}
                //else
                //{


            }

        }
        

        protected void Button19_Click(object sender, EventArgs e)
        {
            Button19.Enabled = true;
            conexion.Open();
            string valor = "";
            if (TextBox4.Text != string.Empty && TextBox5.Text != string.Empty && TextBox8.Text != string.Empty)
            {
                Button19.Enabled = false;
                if (CheckBox2.Checked == true)
                {
                    valor = "SI";

                    SqlCommand C1 = new SqlCommand("insert into Convenio ([Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) values (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)", conexion);
                    C1.Parameters.AddWithValue("@valor1", TextBox4.Text);
                    C1.Parameters.AddWithValue("@valor2", TextBox5.Text);
                    C1.Parameters.AddWithValue("@valor3", valor);
                    C1.Parameters.AddWithValue("@valor4", TextBox1.Text);
                    C1.Parameters.AddWithValue("@valor5", TextBox8.Text);
                    C1.Parameters.AddWithValue("@valor6", DropDownList2.SelectedValue);

                    C1.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Datos cargados.");
                }
                else if (CheckBox2.Checked == false)
                {
                    valor = "NO";

                    SqlCommand C1 = new SqlCommand("insert into Convenio ([Empresa_Institucion], [Fecha_inicio], [Renovacion_automatica], [Fecha_fin], [Objetivo], [Opciones]) values (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6)", conexion);
                    C1.Parameters.AddWithValue("@valor1", TextBox4.Text);
                    C1.Parameters.AddWithValue("@valor2", TextBox5.Text);
                    C1.Parameters.AddWithValue("@valor3", valor);
                    C1.Parameters.AddWithValue("@valor4", TextBox1.Text);
                    C1.Parameters.AddWithValue("@valor5", TextBox8.Text);
                    C1.Parameters.AddWithValue("@valor6", DropDownList2.SelectedValue);

                    C1.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Datos cargados.");

                }
            }
            else
            {
                Button19.Enabled = true;
            }

            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox8.Text = "";
            TextBox1.Text = "";


            Panel2.Visible = true;
            SqlCommand C11 = new SqlCommand("select * from Convenio", conexion);
            C11.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = C11;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            GridView3.DataSource = tabla;
            GridView3.DataBind();
            GridView3.Visible = true;
            conexion.Close();
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string valor = RadioButtonList1.SelectedValue;
            //F-F
            if (CheckBox1.Checked == false && CheckBox3.Checked == false)
            {
                char[] vectorDisertante1 = TextBox10.Text.ToCharArray();
                char[] vectorDisertante2 = TextBox11.Text.ToCharArray();

                string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();



                string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;
                if (valor != "Todo")
                {
                    if (valor != "Convenio especifico de PPS")
                    {

                        SqlCommand C1 = new SqlCommand("select [Empresa_Institucion] 'Institucion',[Fecha_inicio] 'Fecha de inicio',[Fecha_fin] 'Fecha de fin',[Objetivo],[Opciones] 'Tipo de convenio' from Convenio c  where  (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) and c.Empresa_Institucion=@empresa and c.Opciones=@valor1 ", conexion);
                        C1.Parameters.AddWithValue("@valor1", valor);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        //convenio especfico de pps
                        SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', p.Objetivos 'Objetivo', p.Fecha_inicio 'Fecha de inicio',p.Fecha_fin 'Fecha fin' from Convenio c inner join PAdicional p on c.Id_Convenio = p.Id_Convenio  where  (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) and c.Empresa_Institucion=@empresa group by c.Empresa_Institucion, p.Objetivos, p.Fecha_fin, p.Fecha_inicio ", conexion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else if (valor == "Todo")
                {
                    SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio',c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', count(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio where  (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) and c.Empresa_Institucion=@empresa group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica, c.Id_Convenio", conexion);
                    C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                    C1.ExecuteNonQuery();
                    string valor1 = Convert.ToString((C1.ExecuteScalar()));
                    if (valor1 != "")
                    {
                        Label56.Text = "Datos encontrados";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = C1;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        GridView2.Visible = true;
                        Panel5.Visible = true;
                    }
                    else
                    {
                        Panel5.Visible = true;
                        Label56.Text = "No se encontraron datos coincidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else if (valor == "Convenio especifico de PPS")
                {
                    SqlCommand C1 = new SqlCommand("select * from Convenio c  where  (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) and c.Empresa_Institucion=@empresa ", conexion);
                    C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                    C1.ExecuteNonQuery();
                    string valor1 = Convert.ToString((C1.ExecuteScalar()));
                    if (valor1 != "")
                    {
                        Label56.Text = "Datos encontrados";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = C1;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        GridView2.Visible = true;
                        Panel5.Visible = true;
                    }
                    else
                    {
                        Panel5.Visible = true;
                        Label56.Text = "No se encontraron datos coincidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            //T-T
            if (CheckBox1.Checked == true && CheckBox3.Checked == true)
            {
                if (valor != "Todo")
                {
                    if (valor == "Convenio especifico de PPS")
                    {
                        SqlCommand c2 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Institucion', p.Objetivos 'Objetivos del protocolo adicional', p.Fecha_Inicio 'Fecha de Inicio del Protocolo adicional', p.Fecha_Fin 'Fecha fin del Protocolo adicional' from PAdicional p inner join Convenio c on p.Id_Convenio = c.Id_Convenio ", conexion);
                        c2.ExecuteNonQuery();
                        string valor111 = Convert.ToString((c2.ExecuteScalar()));
                        if (valor111 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = c2;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else if (valor == "Convenio marco")
                    {

                        SqlCommand C2 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio',c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', count(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio where c.Opciones=@valor1 group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica, c.Id_Convenio ", conexion);
                        C2.Parameters.AddWithValue("@valor1", valor);
                        C2.ExecuteNonQuery();
                        string valor11 = Convert.ToString((C2.ExecuteScalar()));
                        if (valor11 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;

                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C2;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else
                {
                    SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio', c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', COUNT(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica,c.Id_Convenio  ", conexion);
                    C1.ExecuteNonQuery();
                    string valor1 = Convert.ToString((C1.ExecuteScalar()));
                    if (valor1 != "")
                    {
                        Label56.Text = "Datos encontrados";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = C1;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        GridView2.Visible = true;
                        Panel5.Visible = true;
                    }
                    else
                    {
                        Panel5.Visible = true;
                        Label56.Text = "No se encontraron datos coincidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            //T-F
            if (CheckBox3.Checked == true && CheckBox1.Checked == false)
            {
                char[] vectorDisertante1 = TextBox10.Text.ToCharArray();
                char[] vectorDisertante2 = TextBox11.Text.ToCharArray();

                string mes1 = vectorDisertante1[0].ToString() + vectorDisertante1[1].ToString();
                string dia1 = vectorDisertante1[3].ToString() + vectorDisertante1[4].ToString();
                string año1 = vectorDisertante1[6].ToString() + vectorDisertante1[7].ToString() + vectorDisertante1[8].ToString() + vectorDisertante1[9].ToString();

                string mes2 = vectorDisertante2[0].ToString() + vectorDisertante2[1].ToString();
                string dia2 = vectorDisertante2[3].ToString() + vectorDisertante2[4].ToString();
                string año2 = vectorDisertante2[6].ToString() + vectorDisertante2[7].ToString() + vectorDisertante2[8].ToString() + vectorDisertante2[9].ToString();



                string fechaUnoCompleta = dia1 + "/" + mes1 + "/" + año1;
                string fechaDosCompleta = dia2 + "/" + mes2 + "/" + año2;
                if (valor != "Todo")
                {
                    if (valor != "Convenio especifico de PPS")
                    {
                        SqlCommand C1 = new SqlCommand("select * from Convenio c where c.Opciones=@valor1 and (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2)", conexion);
                        C1.Parameters.AddWithValue("@valor1", valor);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else //convenio especifico de PPS
                    {
                        SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', p.Objetivos 'Objetivo', p.Fecha_inicio 'Fecha de inicio', p.Fecha_fin 'Fecha fin' from Convenio c inner join PAdicional p on c.Id_Convenio = p.Id_Convenio where (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) group by c.Empresa_Institucion, p.Objetivos, p.Fecha_fin, p.Fecha_inicio", conexion);
                        C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                        C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;
                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else if (valor == "Todo")
                {
                    SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio', c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', COUNT(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio where (c.Fecha_Inicio between  @fecha1 and @fecha2) and (c.Fecha_Fin between @fecha1 and @fecha2) group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica, c.Id_Convenio", conexion);
                    C1.Parameters.AddWithValue("@fecha1", fechaUnoCompleta);
                    C1.Parameters.AddWithValue("@fecha2", fechaDosCompleta);
                    C1.ExecuteNonQuery();
                    string valor1 = Convert.ToString((C1.ExecuteScalar()));
                    if (valor1 != "")
                    {
                        Label56.Text = "Datos encontrados";
                        Label56.ForeColor = System.Drawing.Color.Black;

                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = C1;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        GridView2.Visible = true;
                        Panel5.Visible = true;
                    }
                    else
                    {
                        Panel5.Visible = true;
                        Label56.Text = "No se encontraron datos coincidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            //F-T
            if (CheckBox3.Checked == false && CheckBox1.Checked == true)
            {
                if (valor != "Todo")
                {
                    if (valor != "Convenio especifico de PPS")
                    {
                        SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio', c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica'  from Convenio c where c.Opciones=@valor1 and c.Empresa_Institucion=@empresa ", conexion);
                        C1.Parameters.AddWithValue("@valor1", valor);
                        C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;

                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    else //convenio especifico de pps
                    {
                        SqlCommand C1 = new SqlCommand(" select c.Empresa_Institucion 'Empresa/Intitucion', p.Objetivos 'Objetivo', p.Fecha_inicio 'Fecha de inicio', p.Fecha_fin 'Fecha fin' from Convenio c inner join PAdicional p on c.Id_Convenio = p.Id_Convenio where c.Empresa_Institucion=@empresa group by c.Empresa_Institucion, p.Objetivos, p.Fecha_fin, p.Fecha_inicio ", conexion);
                        C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                        C1.ExecuteNonQuery();
                        string valor1 = Convert.ToString((C1.ExecuteScalar()));
                        if (valor1 != "")
                        {
                            Label56.Text = "Datos encontrados";
                            Label56.ForeColor = System.Drawing.Color.Black;

                            SqlDataAdapter adaptador = new SqlDataAdapter();
                            adaptador.SelectCommand = C1;
                            System.Data.DataTable tabla = new System.Data.DataTable();
                            adaptador.Fill(tabla);
                            GridView2.DataSource = tabla;
                            GridView2.DataBind();
                            GridView2.Visible = true;
                            Panel5.Visible = true;
                        }
                        else
                        {
                            Panel5.Visible = true;
                            Label56.Text = "No se encontraron datos coincidentes";
                            Label56.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else if (valor == "Todo")
                {
                    SqlCommand C1 = new SqlCommand("select c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio', c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', COUNT(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio where c.Empresa_Institucion=@empresa group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica, c.Id_Convenio ", conexion);
                    C1.Parameters.AddWithValue("@empresa", DropDownList3.SelectedValue);
                    C1.ExecuteNonQuery();
                    string valor1 = Convert.ToString((C1.ExecuteScalar()));
                    if (valor1 != "")
                    {
                        Label56.Text = "Datos encontrados";
                        Label56.ForeColor = System.Drawing.Color.Black;
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = C1;
                        System.Data.DataTable tabla = new System.Data.DataTable();
                        adaptador.Fill(tabla);
                        GridView2.DataSource = tabla;
                        GridView2.DataBind();
                        GridView2.Visible = true;
                        Panel5.Visible = true;
                    }
                    else
                    {
                        Panel5.Visible = true;
                        Label56.Text = "No se encontraron datos coincidentes";
                        Label56.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            Label63.Text = this.GridView2.Rows.Count.ToString();
            Label4.Visible = true;
            Label5.Visible = true;

            SqlCommand cant = new SqlCommand("select count(*) from PAdicional", conexion);
            cant.ExecuteNonQuery();
            int val = Convert.ToInt32((cant.ExecuteScalar()));
            Label5.Text = Convert.ToString(val);

            TextBox10.Text = "";
            TextBox11.Text = "";
            CheckBox3.Checked = false;
            CheckBox1.Checked = false;
            conexion.Close();
        }
     
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button20.Visible = false;
            Panel5.Visible = true;
            string val = GridView3.SelectedRow.Cells[1].Text;
            conexion.Open();
            SqlCommand C1 = new SqlCommand("declare @var int set @var = (select count(*) from Convenio c inner  join PAdicional p on c.Id_Convenio = p.Id_Convenio) select c.Empresa_Institucion 'Convenio marco', p.Fecha_Inicio, p.Fecha_Fin, p.Objetivos, @var 'Cantidad de Protocolos Adicionales' from PAdicional p inner join Convenio c on c.Id_Convenio = p.Id_Convenio  where c.Id_Convenio=@val", conexion);
            C1.Parameters.AddWithValue("@val", val);
            C1.ExecuteNonQuery();
            string valor = Convert.ToString((C1.ExecuteScalar()));
            if (valor != "")
            { 
                Label56.Text = "Protocolos Adicionales correspondientes:";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = C1;
                System.Data.DataTable tabla = new System.Data.DataTable();
                adaptador.Fill(tabla);
                GridView2.DataSource = tabla;
                GridView2.DataBind();
                GridView2.Visible = true;
                conexion.Close();
            }
            else
            {
                Label56.Text = "No existen protocolos adicionales aun.";
                Button20.Visible = true;
            }
            Label63.Text = this.GridView2.Rows.Count.ToString();
            Label4.Visible = false;
            Label5.Visible = false;

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand C1 = new SqlCommand("insert into PAdicional ([Id_Convenio],[Fecha_Inicio],[Fecha_Fin],[Objetivos]) values ((select c.Id_Convenio from Convenio c where c.Id_Convenio=@valor ) , @valor1, @valor2, @valor3)  ", conexion);
            C1.Parameters.AddWithValue("@valor", GridView3.SelectedRow.Cells[1].Text);
            C1.Parameters.AddWithValue("@valor1", TextBox2.Text);
            C1.Parameters.AddWithValue("@valor2", TextBox3.Text);
            C1.Parameters.AddWithValue("@valor3", TextBox6.Text);
            C1.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Datos cargados.");
            conexion.Close();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button20.Visible = false;
            Panel3.Visible = true;
            Label49.Text = GridView2.SelectedRow.Cells[1].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            int width = 0;
            conexion.Open();
            Panel2.Visible = true;
            SqlCommand C1 = new SqlCommand("select c.Id_Convenio, c.Empresa_Institucion 'Empresa/Intitucion', c.Objetivo 'Objetivo', c.Fecha_inicio 'Fecha de inicio', c.Fecha_fin 'Fecha fin', c.Renovacion_automatica 'Renovacion automatica', COUNT(p.Id_Protocolo) 'Cantidad de protocolos adicionales' from Convenio c left join PAdicional p on c.Id_Convenio = p.Id_Convenio group by c.Empresa_Institucion, c.Objetivo, c.Fecha_fin, c.Fecha_inicio, c.Renovacion_automatica, c.Id_Convenio ", conexion);
            //declare @var int set @var = (select count(*) from Convenio c inner join PAdicional p on c.Id_Convenio = p.Id_Convenio) select *, @var 'Cantidad de Protocolos Adicionales' from Convenio c inner join PAdicional p on c.Id_Convenio = p.Id_Convenio        
            C1.ExecuteNonQuery();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = C1;
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            GridView3.DataSource = tabla;
            GridView3.DataBind();
            GridView3.Visible = true;

            GridView3.Columns[0].ItemStyle.Width = width;
            //for (int i = 0; i < GridView3.Rows.Count; i++)
            //{
            //    GridView3.Rows[i].Cells[0].ForeColor.Re;
            //}
            //GridView3.Columns[0].ItemStyle.Width = width;
            conexion.Close();
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Label49.Text = GridView3.SelectedRow.Cells[2].Text;
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