<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secretaria.aspx.cs" Inherits="Catolica.Secretaria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />         <link href="Estilos/Estilos.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        ul li a{
           float: right;
           margin-top: 0px;
           color:white;
       }
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            position: absolute;
            left: 707px;
            margin-top: -20px;
            width: 147px;
            height: 27px;
            font-size: x-large;
        }
        .auto-style3 {
            font-size: x-large;
            font-weight: bold;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            position: absolute;
            margin-left: 156px;
            font-size: large;
            width: 495px;
            font-weight: bold;
        }
        .auto-style6 {
            font-weight: bold;
            font-size: large;
        }
        .auto-style7 {
            position: absolute;
            left: 707px;
            margin-top: -20px;
            width: 147px;
            height: 27px;
            font-size: large;
            font-weight: bold;
        }
    </style>
    </head>
<body>
     <nav class="navbar navbar-dark bg-dark ">
                      <a class="navbar-brand" href="">
                        <img src="Imagen/UBagxEL3_400x400.jpg" width="35" class="d-inline-block align-top" alt=""/>
                        <strong>
                            Departamento de extension y graduados- UCASAL.
                        </strong> 
                      </a>
         <ul>
             <li><a href="Secretaria.aspx">Atras</a></li>
                  <li><a href="Pagina Principal.aspx">Cerrar Sesion</a></li>
            </ul>
        </nav>
    <hr />
    <br />
    <form id="form1" runat="server">
        <div class="container margen">

        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Height="69px" width="1023px" CssClass="margen, secretaria" HorizontalAlign="Center" BackColor=" #e3f2fd">
            <asp:Label ID="Label1" runat="server" Text="Ingrese el D.N.I del alumno:" style="font-size: x-large; font-weight: 700;"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="215px"></asp:TextBox>
            &nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Height="41px" Text="Buscar." class="btn btn-info" Width="115px" OnClick="Button1_Click1" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" Height="354px" Width="1023px" CssClass="margen, secretaria" HorizontalAlign="Center" BackColor=" #e3f2fd" ScrollBars="Horizontal">
            <asp:Label ID="Label2" runat="server" Text="Nombre completo:" CssClass="auto-style3"></asp:Label>
            &nbsp;<asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp; 
            <asp:Label ID="Label14" runat="server" CssClass="auto-style3" Text="Carrera:"></asp:Label>
            &nbsp;</span><asp:Label ID="Label4" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <span class="auto-style4"><strong>
            <asp:Label ID="Label15" runat="server" CssClass="auto-style3" Text="D.N.I:"></asp:Label>
&nbsp;</strong></span><asp:Label ID="Label5" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <br class="auto-style1" />
            <br />
            <hr />
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField HeaderText="Modificar" Text="Seleccionar" CommandName="Select" />
                </Columns>
            </asp:GridView>
            <hr />
            <br />
        </asp:Panel>
            
            <asp:Panel ID="Panel3" runat="server" BackColor=" #e3f2fd" BorderStyle="Solid" HorizontalAlign="Left" CssClass="margen, secretaria" Height="604px" Width="1023px">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Agregar informacion para:" style="font-size: x-large; font-weight: 700"></asp:Label>
                &nbsp;<asp:Label ID="Label13" runat="server" Text="Label" CssClass="auto-style6"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" CssClass="auto-style5" Text="Informe de avance Alumno/Empresa:"></asp:Label>
                &nbsp;
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" CssClass="auto-style7" Text="SI"/>
                <br />
                &nbsp;<br />&nbsp;<asp:Label ID="Label8" runat="server" CssClass="auto-style5" Text="Informe de avance Docente:"></asp:Label>
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" CssClass="auto-style7" Text="SI"/>
                <br />
                &nbsp;<br />&nbsp;<asp:Label ID="Label9" runat="server" CssClass="auto-style5" Text="Informe final alumno:"></asp:Label>
                <br />
                <asp:CheckBox ID="CheckBox4" runat="server" CssClass="auto-style7" Text="SI"/><br />
                &nbsp;<br />
                <asp:Label ID="Label10" runat="server" CssClass="auto-style5" Text="Informe Final Empresa:"></asp:Label>
                <br />
                <asp:CheckBox ID="CheckBox5" runat="server" CssClass="auto-style7" Text="SI" /><br />
                &nbsp;<br />&nbsp;<asp:Label ID="Label11" runat="server" CssClass="auto-style5" Text="Informe final Docente:"></asp:Label>
                <br />
                <asp:CheckBox ID="CheckBox6" runat="server" CssClass="auto-style7" Text="SI"/><br />
                &nbsp;<br />
                <asp:Label ID="Label12" runat="server" CssClass="auto-style5" Text="Numero de resolucion:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" cssclass="auto-style2"></asp:TextBox><br />
                &nbsp;<br />
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:Button ID="Button2" runat="server" Text="Cargar" CssClass="btn btn-info" Height="55px" Width="106px" OnClick="Button2_Click1" />
                </asp:Panel>
        
        </div>


    </form>
   
</body>
</html>
