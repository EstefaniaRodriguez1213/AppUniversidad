<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Capacitaciones.aspx.cs" EnableEventValidation = "false" Inherits="Catolica.Capacitaciones" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Estilos/Estilos.css" rel="stylesheet" /> 
     <link rel ="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
      <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
     <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
 <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    
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
        .auto-style3 {
            font-size: medium;
        }
        .auto-style4 {
            font-weight: bold;
            font-size: large;
        }
        </style>
    <script >
        function fnAceptar() {
        alert('El Contenido del TextBox es: ' + document.getElementById("TextBox8").value);
        document.getElementById("TextBox8").value = '';
        }
    </script>
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
    <hr/>
    
          <form id="form1" runat="server">
          <div>
               <div class="container">
                  <nav class="navbar navbar-light" style="background-color: #e3f2fd; top: 0px; left: -30px; width: 1153px;">
                       
                      <div class="btn-group" role="group" aria-label="Basic example"/>
                      <a class="navbar-brand" href="#">Menu Capacitaciones:</a>&nbsp;&nbsp; 
                        <asp:Button ID="Button1" runat="server" Text="Cargar" Height="40px" Width="95px" class="btn btn-info" OnClick="Button1_Click" />
                      &nbsp;&nbsp;
                      <asp:Button ID="Button2" runat="server" Text="Buscar" Height="40px" Width="95px" class="btn btn-info" OnClick="Button2_Click"/>
                           </nav>&nbsp;
                   <asp:Panel ID="Panel1" runat="server" BackColor="#e3f2fd" BorderStyle="Solid" Height="1390px" HorizontalAlign="Left" Width="1114px" CssClass="margen">
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" style="font-size: xx-large; font-weight: 700" Text="Carga de capacitaciones"></asp:Label>
                       <br />
                       <br />
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Actividad/Titulo de actividad:" CssClass="auto-style4"></asp:Label>
                       <br />
                       &nbsp;<asp:TextBox ID="TextBox1" runat="server" CssClass="textos" Width="500px" ></asp:TextBox>
                       <br />
                       <br /><br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Objetivos:" CssClass="auto-style4"></asp:Label>
                       &nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="textos" Height="70px" Width="500px"></asp:TextBox>
                       <br />
                       <br />
                       <br />
                    
                      
                       
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label4" runat="server" CssClass="auto-style4" Text="Fecha de inicio:"></asp:Label>
                       &nbsp;
                       <br /><asp:TextBox ID="TextBox3" runat="server" CssClass="textos" Width="500px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label20" runat="server" style="font-weight: 700; color: #FF0000; font-size: small;" Text="Formato: dd-mm-yyyy"></asp:Label>
                       <br />
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label5" runat="server" Text="Fecha de finalizacion:" CssClass="auto-style4" ></asp:Label>
                       <br />
                       &nbsp;<asp:TextBox ID="TextBox4" runat="server" CssClass="textos" Width="500px" ></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label21" runat="server" style="font-weight: 700; color: #FF0000; font-size: small;" Text="Formato: dd-mm-yyyy"></asp:Label><br />
                       <br />
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label6" runat="server" Text="Actividades previstas " CssClass="auto-style4"  ></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label17" runat="server" Text="para la actividad:" CssClass="auto-style4"></asp:Label>
                       &nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="90px" Width="500px" CssClass="textos"></asp:TextBox>
                       <br />
                       <br />
                       <br />
                       <br />
                       <br />
                      
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Estado de avance/" CssClass="auto-style4"></asp:Label>
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" Text="Principales resultados:" CssClass="auto-style4"></asp:Label>
                       &nbsp;<asp:TextBox ID="TextBox6" runat="server" Height="90px" Width="500px" CssClass=" textos"></asp:TextBox>
                       <br />
                       <br />
                       <br />
                       <br />
                       <br />
                       
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Carreras de grado y posgrado" CssClass="auto-style4"></asp:Label>
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label14" runat="server" Text="con las que se vincula:" CssClass="auto-style4"></asp:Label>
                       
                       &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" height="38px" Width="500px" CssClass="textos">
                           <asp:ListItem>Ing. Informatica</asp:ListItem>
                           <asp:ListItem>Ing. Civil</asp:ListItem>
                           <asp:ListItem>Ing. Telecomunicaciones</asp:ListItem>
                           <asp:ListItem>Ing. Indistrial</asp:ListItem>
                           <asp:ListItem>Todas</asp:ListItem>
                       </asp:DropDownList>
                       <br />
                       <br />
                       <br />
                       <br />
                       
                    
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label15" runat="server" CssClass="auto-style4" Text="Disertantes:"></asp:Label>
                       <br />
                       <asp:Panel ID="Panel14" runat="server" CssClass="textos" Width="456px">
                           &nbsp;

                           <%--<script>
                               $("#Button15").click(function (event) {
                                   event.preventDefault();
                               });
                           </script>    --%>
                           <asp:TextBox ID="TextBox8" runat="server" Height="30px" Width="300px"></asp:TextBox>
                           <asp:Button ID="Button4" runat="server" Text="Agregar" OnClick="Button4_Click" Class="btn btn-info"/>
                           &nbsp;<br />
                           <asp:Label ID="Label19" runat="server" Text="Disertantes agregados: "></asp:Label>
                           <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
                           
                           <br />
                       </asp:Panel>
                       <br />
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;<br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label10" runat="server" Text="Participantes:" CssClass="auto-style4"></asp:Label>
                       
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                       <asp:Panel ID="Panel9" runat="server" CssClass="textos">
                           <asp:Label ID="Label70" runat="server" Text="Alumnos:"></asp:Label>
                           &nbsp;<asp:TextBox ID="TextBox12" runat="server" Width="61px"></asp:TextBox>
                           <asp:Label ID="Label71" runat="server" Text="Docentes:"></asp:Label>
                          
                           <asp:TextBox ID="TextBox13" runat="server" Width="61px"></asp:TextBox>
                        
                           <asp:Label ID="Label72" runat="server" Text="Egresados:"></asp:Label>
                           <asp:TextBox ID="TextBox14" runat="server" Width="61px"></asp:TextBox>
                           &nbsp;<asp:Label ID="Label16" runat="server" Text="Otros:"></asp:Label>
                           <asp:TextBox ID="TextBox7" runat="server" Width="61px"></asp:TextBox>
                       </asp:Panel>
                       <br />
                       <br />
                       <br />
                       &nbsp;&nbsp;&nbsp;
                    
                       &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label11" runat="server"   Text="Otra informacion:" CssClass="auto-style4"></asp:Label>
                    
                       &nbsp;<asp:TextBox ID="TextBox11" runat="server" Height="90px" Width="500px" CssClass="textos"></asp:TextBox>
                       <br />
                       <br />
                        <br />
                        <br />
                        <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Button15" runat="server" Text="Cargar" Height="47px" Width="186px" Class="btn btn-info" OnClick="Button15_Click1"/>
                       
                   </asp:Panel>
                   <br />

                   <asp:Panel ID="Panel2" runat="server" BackColor="White" BorderStyle="Solid" Height="665px" CssClass="margen" Width="1100px">
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Label ID="Label13" runat="server" Text="Busqueda de capacitaciones." style="font-size: x-large; font-weight: 700"></asp:Label>
                       <br />
                       <br />
                       <asp:Panel ID="Panel10" runat="server" BorderStyle="Ridge" BackColor="#e3f2fd">
                           <asp:Label ID="Label73" runat="server" Text="Buscar por:" style="font-weight: 700; font-size: large"></asp:Label>
                           &nbsp;
                           <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"  CssClass="radioButtonList" Width="666px">
                               <asp:ListItem>Alumnos</asp:ListItem>
                               <asp:ListItem>Docente</asp:ListItem>
                               <asp:ListItem>Egresados</asp:ListItem>
                               <asp:ListItem>Otros</asp:ListItem>
                               <asp:ListItem>Todo</asp:ListItem>
                           </asp:RadioButtonList>
                       </asp:Panel>
                       <br />
                       <asp:Panel ID="Panel13" runat="server" BorderStyle="Ridge" CssClass="botonaladerecha" Height="281px" HorizontalAlign="Center" Width="410px" BackColor="#e3f2fd">
                           <asp:Label ID="Label74" runat="server" CssClass="auto-style3" Font-Bold="True" Text="Fecha"></asp:Label>
                           <br class="auto-style3" />
                           <span class="auto-style3">Por favor, seleccione el rango de fechas:</span><br />
                           <asp:ScriptManager ID="ScriptManager1" runat="server">
                           </asp:ScriptManager>
                           &nbsp;&nbsp;&nbsp;<asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                               <ContentTemplate>
                                   &nbsp;<asp:Label ID="Label75" runat="server" Text="Desde:"></asp:Label>
                                   &nbsp;&nbsp;<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                 
                                   <script>
                                     
                                           $('#TextBox15').datepicker(
                                             {
                                                 
                                                 uiLibray: 'bootstrap4'
                                               
                                                
                                       });
                                        </script>
                                   &nbsp;<br />
                                   <asp:Label ID="Label76" runat="server" Text="Hasta:"></asp:Label>
                                   &nbsp;<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                   <script>
                                       $('#TextBox9').datepicker
                                           ({
                                              
                                               uiLibray: 'bootstrap4'
                                              

                                           })
                                        </script>
                                   &nbsp;&nbsp;&nbsp;
                               </ContentTemplate>
                           </asp:UpdatePanel>
                           <asp:CheckBox ID="CheckBox1" runat="server" Text="Todas las fechas." />
                       <br />                
                           <br />
                           <br />
                           
                       </asp:Panel>
                       <br />
                        <asp:Panel ID="Panel4" runat="server" backcolor="#e3f2fd" BorderStyle="Ridge" HorizontalAlign="Center" style="margin-left: 30%" Width="493px">
                               <asp:Label ID="Label9" runat="server" Text="Nombre de capacitacion: "></asp:Label> <asp:DropDownList ID="DropDownList2" runat="server" Height="26px" Width="200px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                               <hr />
                               <asp:CheckBox ID="CheckBox2" runat="server" Text="Todas las capacitaciones" />
                           </asp:Panel>
                       <br/>
                       <asp:Button ID="Button14" runat="server" Text="Buscar" class="btn btn-info" Height="55px" Width="226px" style="margin-left: 470px" OnClick="Button14_Click" />
                   </asp:Panel>

                
            <br />
                   <asp:Panel ID="Panel3" runat="server" CssClass="margen" BackColor="White" BorderStyle="Solid" HorizontalAlign="Center" Height="496px" ScrollBars="Horizontal">
                       <asp:Label ID="Label56" runat="server" Text="Datos encontrados." style="font-weight: 700; font-size: x-large"></asp:Label><br />
                      <br />
                        <asp:GridView ID="GridView2" runat="server" Height="197px" HorizontalAlign="Center" Width="401px">
                       </asp:GridView>
                       <br />
                       <br />
                       <asp:Label ID="Label58" runat="server" CssClass="auto-style1" Text="Cantidad total de registros:"></asp:Label>
                       &nbsp;
                       <asp:Label ID="Label63" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
                       <br />
                       <br />
                       &nbsp;<br />&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" class="btn btn-danger" Text="Reporte PDF" OnClick="Button5_Click" />
                       &nbsp;<asp:Button ID="Button8" runat="server" Text="Reporte Excel" class="btn btn-danger" OnClick="Button8_Click"/>


                   </asp:Panel>
               </div>   
          </div>
              
          </form>

    
  
   

</body>
</html>
