<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convenio.aspx.cs" EnableEventValidation = "false" Inherits="Catolica.Convenio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Estilos/Estilos.css" rel="stylesheet" /> 
     <link rel ="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
      <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
     <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
    
    <script src="https://unpkg.com/gijgo@1.9.13/js/gijgo.min.js" type="text/javascript"></script>
    <link href="https://unpkg.com/gijgo@1.9.13/css/gijgo.min.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
         ul li {
            display: inline-block;
        }
        
        ul li a{
           float: right;
           margin-top: 0px;
           color:white;
           padding:10px;
       }
        .col-xs-12 {
            margin-bottom: 18px;
        }
        .btn-info {}
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-weight: 700;
            font-size: large;
        }
        </style>
</head>
<body class="body">

    <nav class="navbar navbar-dark bg-dark ">
                      <a class="navbar-brand" href="Menu.aspx">
                        <img src="Imagen/UBagxEL3_400x400.jpg" width="35" class="d-inline-block align-top" alt=""/>
                        <strong>
                            Departamento de extension y graduados- UCASAL.
                        </strong> 
                      </a>
        <ul>
             <li><a href="Menu.aspx">Volver al menu</a></li>
                  <li><a href="Pagina Principal.aspx">Cerrar Sesion</a></li>
            </ul>
        </nav>
    <hr/>
    <form id="form1" runat="server">
    <div>
    
        <div class="container centro">
                  <nav class="navbar navbar-light" style="background-color: #e3f2fd; top: 0px; left: -30px; width: 1153px;">
                       
                      <div class="btn-group" role="group" aria-label="Basic example"/>
                      <a class="navbar-brand" href="#">Menu Convenios:</a>&nbsp;&nbsp; 
                          <asp:Button ID="Button12" runat="server" Text="Cargar convenio marco"  class="btn btn-info" OnClick="Button12_Click"/>
                     
 &nbsp;
                     
 &nbsp;<asp:Button ID="Button13" runat="server" Text="Buscar convenios"  class="btn btn-info" OnClick="Button13_Click" />
                          &nbsp;&nbsp;
                      <asp:Button ID="Button1" runat="server" Text="Agregar protocolo adicional"  class="btn btn-info" OnClick="Button1_Click"/>
                           </nav>
                      </div>   
        <hr/>
                     <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" Height="635px" Width="1193px" HorizontalAlign="Justify" CssClass="margen, convenio" BackColor="#e3f2fd">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label25" runat="server" Text="Cargar datos de convenios:"  style="font-size: x-large; font-weight: 700"></asp:Label>
                         <br />
                          <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label39" runat="server" Text="Empresa/Institucion:" cssclass="auto-style2"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox4" runat="server" CssClass="textos"></asp:TextBox>
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label40" runat="server" Text="Fecha de inicio:" cssclass="auto-style2"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox5" runat="server" CssClass="textos"></asp:TextBox>                           
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label46" runat="server"  Text="Renovacion automatica:" cssclass="auto-style2"></asp:Label>
                                     <br />
                                     <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" CssClass="textos" OnCheckedChanged="CheckBox1_CheckedChanged" Text="SI" />
                               

                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label41" runat="server" Text="Fecha de finalizacion:" cssclass="auto-style2"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox1" runat="server" CssClass="textos"></asp:TextBox>
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label44" runat="server" cssclass="auto-style2" Text="Opciones:"></asp:Label>
                             <br />
                             <asp:DropDownList ID="DropDownList2" runat="server" CssClass="textos">
                                 <asp:ListItem>Convenio marco</asp:ListItem>
                                 <asp:ListItem>Convenio especifico de PPS</asp:ListItem>
                             </asp:DropDownList>
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label43" runat="server" cssclass="auto-style2" Text="Objetivo general:"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox8" runat="server" CssClass="textos" Height="100px"></asp:TextBox>
                             <br />
                             <br />
                             <br />
                             <br />
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="Button19" runat="server" cssclass="btn btn-info" Height="66px" OnClick="Button19_Click" Text="Cargar" Width="188px" />
                             <br />
                             <br />
                         <br />
                         <br />
                         <br />

                    </asp:Panel>
         <br />
         <asp:Panel ID="Panel2" runat="server" CssClass="margen, convenio" BackColor="White" BorderStyle="Solid" HorizontalAlign="Center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Convenios marco registrados." style="font-weight: 700; font-size: x-large"></asp:Label>

             <br />

            <br />
            <asp:GridView ID="GridView3" CssClass="Gridview3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" HorizontalAlign="Center">
                <Columns>
                    <asp:ButtonField CommandName="Select" HeaderText="Agregar/Modificar" Text="Agregar/Explorar" />
                </Columns>
            </asp:GridView>
            <br />
            <br />

        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" CssClass="margen, convenio" BackColor="#e3f2fd" BorderStyle="Solid" HorizontalAlign="Justify" Height="465px" Width="1213px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label48" runat="server" style="font-size: x-large; font-weight: 700" Text="Agregar protocolo adicional para "></asp:Label>
            &nbsp;<asp:Label ID="Label49" runat="server" style="font-size: x-large; font-weight: 700" Text="Label"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label50" runat="server" Text="Fecha de inicio:" cssclass="auto-style2"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="textos"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label51" runat="server" Text="Fecha fin:" cssclass="auto-style2"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="textos"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label52" runat="server" Text="Objetivos:" cssclass="auto-style2"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" CssClass="textos" Height="100px" Width="400px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button14" runat="server" cssclass="btn btn-info" Height="50px" Text="Agregar" Width="165px" OnClick="Button14_Click" />

        </asp:Panel>
         <br />
       
        <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderStyle="Solid" CssClass="margen, busqueda" HorizontalAlign="Center" Height="750px" Width="80%">
            <asp:Label ID="Label45" runat="server" Text="Busqueda:" style="font-size: x-large; font-weight: 700"></asp:Label>
            &nbsp;
            <br />
            <br />
            <asp:Panel ID="Panel9" runat="server" BorderStyle="Ridge" HorizontalAlign="Center" BackColor="#e3f2fd" style="margin-left: 42px" Width="825px">
                &nbsp;
                <asp:Label ID="Label55" runat="server" style="font-weight: 700; font-size: large" Text="Opciones:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <label class="form-check-label">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="18px" RepeatDirection="Horizontal" Width="618px">
                    <asp:ListItem>Convenio marco</asp:ListItem>
                    <asp:ListItem>Convenio especifico de PPS</asp:ListItem>
                    <asp:ListItem>Todo</asp:ListItem>
                </asp:RadioButtonList>
                </label>
            </asp:Panel>
            <br />
            &nbsp;<br /> &nbsp;<br />
            <asp:Label ID="Label54" runat="server" Text="Empresa: "></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Height="23px" Width="211px">
            </asp:DropDownList>
            
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Todas las empresas" />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel7" runat="server" backcolor="#e3f2fd" BorderStyle="Ridge"  Width="461px" CssClass="fecha">
                <asp:Label ID="Label53" runat="server" style="font-weight: 700; font-size: large" Text="Fecha:"></asp:Label>
                &nbsp;<br /> <span class="auto-style1">Por favor, seleccione el rango de fechas:<br /> </span>
                <br />
                 &nbsp;<asp:Label ID="Label2" runat="server" Text="Desde:"></asp:Label>
                        &nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                       
                        <script>

                                        $('#TextBox10').datepicker    
                                           ({ uiLibrary: 'bootstrap4' })
                                        </script>
                        &nbsp;<br />
                        <asp:Label ID="Label3" runat="server" Text="Hasta:"></asp:Label>
                        &nbsp;<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        <script>

                           $('#TextBox11').datepicker    
                                           ({ uiLibrary: 'bootstrap4' })
                                        </script>
                        <br />
                        &nbsp;<br />
                        <hr />
                        &nbsp;&nbsp;<br />&nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Cualquier fecha." />
                        <br />
            </asp:Panel>
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:Button ID="Button16" runat="server" Height="52px" Text="Buscar" Width="150px" CssClass="btn btn-info" OnClick="Button16_Click" />
            <br />
            <br />
           
            <br />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel5" runat="server" CssClass="margen" BackColor="White" BorderStyle="Solid" HorizontalAlign="Center" ScrollBars="Horizontal">
            <asp:Label ID="Label56" runat="server" Text="Datos encontrados." style="font-weight: 700; font-size: x-large"></asp:Label>
            <br />
          
            <asp:GridView ID="GridView2" runat="server" Height="197px" HorizontalAlign="Center" Width="401px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" HeaderText="Seleccionar" Text="Agregar PA" />
                </Columns>
            </asp:GridView>
               
            <br />
            <asp:Button ID="Button20" runat="server" class="btn btn-danger" Text="Agregar" OnClick="Button20_Click" />
            <br />
            <asp:Label ID="Label58" runat="server" CssClass="auto-style1" Text="Cantidad de convenios marco:"></asp:Label>
            &nbsp;
            <asp:Label ID="Label63" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" CssClass="auto-style1" Text="Cantidad de protocolos adicionales:"></asp:Label>
            &nbsp;
            <asp:Label ID="Label5" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            <br />
            <br />
            &nbsp;<br />
            <br />
            <br />
             <asp:Panel ID="Panel8" runat="server" BackColor="White">

                            <asp:Button ID="Button5" runat="server" Text="Reporte PDF" class="btn btn-danger" OnClick="Button5_Click" />
                        &nbsp;<asp:Button ID="Button8" runat="server" Text="Reporte Excel" class="btn btn-danger" OnClick="Button8_Click"/>
                        <br />
                        </asp:Panel>
            <br />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
