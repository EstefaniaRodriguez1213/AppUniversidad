<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Catolica.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
     <link href="Estilos/Estilos.css" rel="stylesheet" /> 
    <style type="text/css">
        ul li {
            display: inline-block;
        }

        ul li a{
           float: right;
           margin-top: 0px;
           color:white;
           padding: 10px;
         
       }
        .col-xs-12 {
            margin-bottom: 18px;
        }
        .auto-style1 {
            position: absolute;
            left: 643px;
            margin-top: -20px;
            width: 147px;
            height: 27px;
            font-size: x-large;
        }
        .auto-style4 {
            position: absolute;
            left: 353px;
            font-size: large;
            font-weight: bold;
            width: 159px;
        }
        .auto-style5 {
            font-weight: bold;
            font-size: x-large;
        }
    </style>
</head>
<body>
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
    <form id="form1" runat="server">
    <div>
     <hr />
        <div class="container centro">
                  <nav class="navbar navbar-light" style="background-color: #e3f2fd; top: 0px; left: -30px; width: 1153px;">
                       
                      <div class="btn-group" role="group" aria-label="Basic example"/>
                      <a class="navbar-brand" href="#">Menu Usuarios:</a>&nbsp;&nbsp; 
                          <asp:Button ID="Button12" runat="server" Text="Nuevo usuario" Width="154px"  Height="36px" class="btn btn-info" OnClick="Button12_Click"/>
                      &nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Class="btn btn-info" Width="154px"  Height="36px">
                              <asp:ListItem>Modificar</asp:ListItem>
                              <asp:ListItem>Dar de baja</asp:ListItem>
                          </asp:DropDownList>
                          &nbsp;<asp:Button ID="Button17" runat="server" Text="Ir" Width="44px" OnClick="Button17_Click" class="btn btn-info" Height="36px"/>
                          &nbsp;&nbsp;&nbsp;
                      
                           </nav>
                      </div>   
        <hr/>

                     <asp:Panel ID="Panel7" runat="server" BorderStyle="Solid" Height="346px" HorizontalAlign="Center" CssClass="margen, usuario" BackColor=" #e3f2fd" Width="827px">
                        <asp:Label ID="Label51" runat="server" Text="Nuevo Usuario:" style="font-size: x-large; font-weight: 700"></asp:Label>
                         <br /> <br />
                         <asp:Label ID="Label52" runat="server" Text="Nombre Usuario:" CssClass="auto-style4"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox16" runat="server" CssClass="auto-style1" Width="250px"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label53" runat="server" Text="Contraseña:" CssClass="auto-style4"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox17" runat="server" CssClass="auto-style1" Width="250px"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label54" runat="server" Text="Tipo de Usuario:" CssClass="auto-style4"></asp:Label>
                             <br />
                             <asp:DropDownList ID="DropDownList4" runat="server"  CssClass="auto-style1" Width="250px">
                                 <asp:ListItem>Administrador</asp:ListItem>
                                 <asp:ListItem>Secretaria</asp:ListItem>
                             </asp:DropDownList>
                             <br />
                             <br />
                             <asp:Button ID="Button14" runat="server" Text="Dar de alta" class="btn btn-info" OnClick="Button14_Click" style="font-size: x-large" />
                             <br />

                    </asp:Panel>
                    <br />

        <asp:Panel ID="Panel9" runat="server" BorderStyle="Solid" Height="270px" CssClass="margen, usuario" backcolor= "#e3f2fd" HorizontalAlign="Center" Width="826px">
            <asp:Label ID="Label55" runat="server" Text="Modificar usuario:" style="font-size: x-large; font-weight: 700"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
             <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" Height="182px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="391px">
                    <Columns>
                        <asp:ButtonField CommandName="Select" HeaderText="Modificar" Text="Seleccionar" />
                    </Columns>
                </asp:GridView>
            <br />        
            <br />
            <br />
            <br />
            <br />
            
            <br />
            <br />
            
        </asp:Panel>
        <asp:Panel ID="Panel11" runat="server" BackColor=" #e3f2fd" BorderStyle="Solid" CssClass="margen, usuario" HorizontalAlign="Center" Width="757px">
                <asp:Label ID="Label60" runat="server" Text="Modificando:" CssClass="auto-style5"></asp:Label>
                <br />
                &nbsp;<br />&nbsp;<asp:Label ID="Label62" runat="server" Text="Usuario:" CssClass="auto-style5"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label63" runat="server" Text="Contraseña:" CssClass="auto-style5"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button18" runat="server" Text="Guardar" Class="btn btn-info" OnClick="Button18_Click1" />
                <br />
                <br />
            </asp:Panel>
        <asp:Panel ID="Panel10" runat="server" Height="293px" HorizontalAlign="Center" cssclass="margen, usuario" BorderStyle="Solid" BackColor=" #e3f2fd" Width="752px">
                <asp:Label ID="Label59" runat="server" Text="Baja de usuario" Font-Bold="True" style="font-size: x-large"></asp:Label>
                 <br />
                <br />
                <asp:GridView ID="GridView2" runat="server" Height="170px" HorizontalAlign="Center" Width="372px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:ButtonField HeaderText="Dar de baja" Text="Dar de Baja" CommandName="Select" />
                    </Columns>
                </asp:GridView>
                <br />
            </asp:Panel>
    </div>
    </form>
</body>
</html>
