<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" EnableEventValidation = "false" Inherits="Catolica.Items" %>

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
       ul li a{
           float: right;
           margin-top: 0px;
           color:white;
           padding:10px;
       }
         ul li {
            display: inline-block;
        }
         .col-xs-12 {
            margin-bottom: 18px;
        }
        .auto-style1 {
            font-size: large;
        }
        .auto-style5 {
            font-weight: bold;
            font-size: large;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            font-weight: bold;
            font-size: x-large;
        }
        .auto-style8 {
            color: #FF0000;
        }
        .auto-style9 {
            font-size: small;
        }
        .fondo {}
    </style>
</head>
<body>
        <nav class="navbar navbar-dark bg-dark ">
                      <a class="navbar-brand" href="Menu.aspx">
                        <img src="Imagen/UBagxEL3_400x400.jpg" width="35" class="d-inline-block align-top" alt="LogoUcasal"/>
                     
                         
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
   
       <div class="container centro">
           <form id="form1" runat="server" >
               <div class="container centro">
                  <nav class="navbar navbar-light" style="background-color: #e3f2fd; top: 0px; left: -30px; width: 1153px;">
                       
                      <div class="btn-group" role="group" aria-label="Basic example"/>
                      <a class="navbar-brand" href="#">Menu:</a>&nbsp;&nbsp; 
                      <asp:Button ID="Button2" runat="server" Text="PPS" class="btn btn-info" OnClick="Button2_Click" /> 
                      &nbsp;<asp:Button ID="Button1" runat="server" Text="Convenios" class="btn btn-info" OnClick="Button1_Click1"/>
                      &nbsp;<asp:Button ID="Button3" runat="server" Text="Capacitaciones" class="btn btn-info" OnClick="Button3_Click"/>
                      &nbsp;<asp:Button ID="Button4" runat="server" Text="Usuarios" class="btn btn-info" OnClick="Button4_Click"/>
                           </nav>
                      </div>
             
                </div>
                <div class="container margen">
                    <hr />
                    <asp:Panel ID="Panel3" runat="server" BorderStyle="Solid" Height="78px" CssClass="fondo" BackColor="#e3f2fd" HorizontalAlign="Center" Width="1023px">
                        <strong><span class="auto-style1">Menu Pasantias:</span></strong><br />
                        
                        <asp:Label ID="Label21" runat="server" Text="Seleccionar:" CssClass="auto-style5"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button11" runat="server" Text="Menu Secretaria" class="btn btn-info" OnClick="Button11_Click"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button7" runat="server" class="btn btn-info" OnClick="Button7_Click" Text="Cargar datos " Width="146px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label51" runat="server" Text="Buscar por: " CssClass="auto-style5"></asp:Label>
                        &nbsp;<asp:DropDownList ID="DropDownList4" runat="server" class="btn btn-info" Width="120px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                            <asp:ListItem>Empresa</asp:ListItem>
                            <asp:ListItem>Alumno</asp:ListItem>
                            <asp:ListItem>Otro</asp:ListItem>
                            <asp:ListItem>D.N.I</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;

                         <asp:Button ID="Button12" runat="server" Text="Ir" Width="36px" class="btn btn-info" OnClick="Button12_Click"/>
                        </div>
                      
                         </asp:Panel>
                                     <br/>
                    <asp:Panel ID="Panel2" runat="server" Height="1242px" BorderStyle="Solid" CssClass="fondo" BackColor="White" HorizontalAlign="Center">
                        <asp:Label ID="Label24" runat="server" Text="Buscar:" CssClass="auto-style7"></asp:Label>
                        <br class="auto-style1" />
                        <br class="auto-style1" />
                <asp:Label ID="Label10" runat="server" Text="Seleccione los filtros para buscar:" CssClass="auto-style7"></asp:Label>
                <br class="auto-style1" />
                        <br />
                <br class="auto-style1" />
                        <asp:Panel ID="Panel9" runat="server" BorderStyle="Ridge" HorizontalAlign="Justify" CssClass="fondo">
                            <asp:Label ID="Label11" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Tipo de PPS:"></asp:Label>
                           
                            <asp:RadioButtonList ID="RadioButtonList9" runat="server" CssClass="radioButtonList" Height="33px" RepeatDirection="Horizontal" Width="484px">
                                <asp:ListItem>Tecnico</asp:ListItem>
                                <asp:ListItem>Ingeniero</asp:ListItem>
                                <asp:ListItem>Todo</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel10" runat="server" BorderStyle="Ridge" HorizontalAlign="Justify" CssClass="fondo">
                            <asp:Label ID="Label12" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Condicion:"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" CssClass="radioButtonList" Height="33px" RepeatDirection="Horizontal" Width="484px">
                                <asp:ListItem>Convenio/Protocolo</asp:ListItem>
                                <asp:ListItem>Convalidacion</asp:ListItem>
                                <asp:ListItem>Todo</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel11" runat="server" BorderStyle="Ridge" HorizontalAlign="Justify" CssClass="fondo">
                            <asp:Label ID="Label70" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Estado:"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" CssClass="radioButtonList" Height="16px" RepeatDirection="Horizontal" Width="574px">
                                <asp:ListItem>Vencida</asp:ListItem>
                                <asp:ListItem>En curso</asp:ListItem>
                                <asp:ListItem>Finalizada</asp:ListItem>
                                <asp:ListItem>Baja</asp:ListItem>
                                <asp:ListItem>Todo</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel12" runat="server" BorderStyle="Ridge" HorizontalAlign="Justify" CssClass="fondo">
                            <asp:Label ID="Label13" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Carrera:"></asp:Label>
                            <label class="form-check-label">
                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" CssClass="radioButtonList" Height="25px" RepeatDirection="Horizontal" Width="823px">
                                <asp:ListItem>Ing. Civil</asp:ListItem>
                                <asp:ListItem>Ing. Informatica</asp:ListItem>
                                <asp:ListItem>Ing. Industrial</asp:ListItem>
                                <asp:ListItem>Ing. Telecomunicaciones</asp:ListItem>
                                <asp:ListItem>Todo</asp:ListItem>
                            </asp:RadioButtonList>
                            </label>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel13" runat="server" BorderStyle="Ridge" Height="401px" Width="414px" CssClass="botonaladerecha" BackColor="#e3f2fd">
                            <br class="auto-style1" />
                        <asp:Label ID="Label14" runat="server" CssClass="auto-style1" Font-Bold="True" Text="Fecha"></asp:Label>
                        <br class="auto-style1" />
                        <span class="auto-style1">Por favor, seleccione el rango de fechas:</span><br />&nbsp;
                            
                                        &nbsp;<asp:Label ID="Label2" runat="server" Text="Desde:"></asp:Label>
                                        &nbsp;&nbsp;
                            <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
                                  
                                        <script>
                                        $('#TextBox6').datepicker    
                                           ({ uiLibrary: 'bootstrap4' })
                                        </script>
                                        &nbsp;<br />
                                        <asp:Label ID="Label3" runat="server" Text="Hasta:"></asp:Label>
                                        &nbsp;<asp:TextBox ID="TextBox9" runat="server" ></asp:TextBox>
                                        <script>
                                        $('#TextBox9').datepicker    
                                           ({ uiLibrary: 'bootstrap4' })
                                        </script>
                                        <br />&nbsp;&nbsp;
                                        <hr/>

                                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Todas las fechas." />
                                        <br /><br />&nbsp;&nbsp;
                                <br />
                        
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel14" runat="server" Height="127px" style="margin-top: 13px" CssClass="fondo">
                            <br />
                            <asp:Label ID="Label17" runat="server" Text="Empresa:" Font-Bold="True" CssClass="auto-style1"></asp:Label>
                            &nbsp;&nbsp;<asp:DropDownList ID="DropDownList6" runat="server" Height="50px" Width="282px">
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Todas las empresas." />
                            <br /><br />
                        </asp:Panel>
                <br class="auto-style1" />
                        <div class="form-check-inline">
                        </div>
                        <br class="auto-style1" />
        <asp:Button ID="Button6" runat="server" Text="Buscar"  OnClick="Button6_Click" class="btn btn-info" Height="55px" Width="226px"/>
                    </asp:Panel>
                     <br/>
                     <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" Height="912px" HorizontalAlign="Center" CssClass="fondo">
                         &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label25" runat="server" Text="Cargar datos:" style="font-size: x-large; font-weight: 700"></asp:Label>
                         <br />
                         <asp:Panel ID="Panel6" runat="server"   Height="731px" style="margin-top: 0px;" HorizontalAlign="Center" Width="621px">
                            
                            <br/> <asp:Label ID="Label39" runat="server" Text="Nombre completo:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                             
                            <br /> <asp:TextBox ID="TextBox4" runat="server" CssClass="textos" Width="223px"></asp:TextBox><br />
                             
                             
                             <asp:Label ID="Label40" runat="server" Text="D.N.I: " CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                             
                            <br /> <asp:TextBox ID="TextBox5" runat="server" CssClass="textos" Width="223px"></asp:TextBox><asp:Label ID="Label4" runat="server" Text="(Sin punto)" style="font-weight: 700; font-size: small; color: #FF0000"></asp:Label><br />
                             
                             <br /><asp:Label ID="Label41" runat="server" Text="Carrera:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                             
                            <br /> <asp:DropDownList ID="DropDownList1" runat="server"  CssClass=" textos" Width="223px">
                                 <asp:ListItem>Ing. Informatica</asp:ListItem>
                                 <asp:ListItem>Ing. Civil</asp:ListItem>
                                 <asp:ListItem>Ing. Industrial</asp:ListItem>
                                 <asp:ListItem>Ing. Telecomunicaciones</asp:ListItem>
                             </asp:DropDownList><br />

                             
                             <asp:Label ID="Label42" runat="server" CssClass="auto-style2" Text="E-mail:" style="font-weight: bold; font-size: large"></asp:Label>
                            
                           <br />  <asp:TextBox ID="TextBox7" runat="server" CssClass="textos" Width="223px"></asp:TextBox>
                             <br/>
                             <asp:Label ID="Label43" runat="server" Text="Telefono:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                            
                            <br /> <asp:TextBox ID="TextBox8" runat="server" CssClass="textos" Width="223px"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label44" runat="server" Text="Tipo de PPS:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                           <br/>
                             <asp:DropDownList ID="DropDownList2" runat="server" CssClass=" textos" Width="223px">
                                 <asp:ListItem>Tecnico</asp:ListItem>
                                 <asp:ListItem>Ingeniero</asp:ListItem>
                             </asp:DropDownList>
                            <br />
                           
                             <asp:Label ID="Label45" runat="server" CssClass="auto-style2" Text="Condicion:" style="font-weight: bold; font-size: large"></asp:Label>
                           
                             <br /><asp:DropDownList ID="DropDownList3" runat="server" CssClass=" textos" Width="223px">
                                 <asp:ListItem>Convenio/Protocolo</asp:ListItem>
                                 <asp:ListItem>Convalidacion</asp:ListItem>
                             </asp:DropDownList>
                    
                             <br /><asp:Label ID="Label46" runat="server" CssClass="auto-style2" Text="Empresa:" style="font-weight: bold; font-size: large"></asp:Label>
                           
                            <br /> <asp:TextBox ID="TextBox11" runat="server" CssClass=" textos" Width="223px"></asp:TextBox><br />
                             
                             <asp:Label ID="Label47" runat="server" Text="Supervisor de parte de la empresa:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                             
                           <br />  <asp:TextBox ID="TextBox12" runat="server" CssClass=" textos" Width="223px"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label48" runat="server" Text="Tareas:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                           
                            <br /> <asp:TextBox ID="TextBox13" runat="server" CssClass="textos" Width="223px"></asp:TextBox>
                             <br />
                             <asp:Label ID="Label49" runat="server" Text="Fecha de inicio:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                           <br />
                             <asp:TextBox ID="TextBox14" runat="server" CssClass=" textos" Width="223px"></asp:TextBox><asp:Label ID="Label5" runat="server" Text="Formato: dd-mm-yyyy" style="font-weight: 700; color: #FF0000; font-size: small;"></asp:Label>
                            <br />
                            <br /> <asp:Label ID="Label50" runat="server" Text="Fecha de finalizacion:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                             <br />
                             <asp:TextBox ID="TextBox15" runat="server" CssClass="textos" Width="223px"></asp:TextBox><span class="auto-style8"><strong><span class="auto-style9">Formato: dd-mm-yyyy</span> </strong></span>
                             <br />
                            <br /> <asp:Label ID="Label1" runat="server" Text="Horario de trabajo:" CssClass="auto-style2" style="font-weight: bold; font-size: large"></asp:Label>
                           <br />
                             <asp:TextBox ID="TextBox1" runat="server" CssClass=" textos" Width="223px"></asp:TextBox>
                             <br />
                         </asp:Panel>
                        <br />
                         <asp:Button ID="Button10" runat="server" class="btn btn-info" OnClick="Button10_Click" Text="Cargar" Width="188px" Height="37px" />
                         <br />

                    </asp:Panel>
                    <br/>
                    <asp:Panel ID="Panel5" runat="server" CssClass="fondo" Height="121px" BorderStyle="Solid">
                        <br />
                        <asp:Label ID="Label26" runat="server" Font-Bold="True" style="font-size: large"></asp:Label>
                        &nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox>
                        &nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Height="45px" Width="262px">
                        </asp:DropDownList>
                        &nbsp;<asp:Button ID="Button9" runat="server" Class="btn btn-info" Height="50px" OnClick="Button9_Click" Text="Buscar" Width="100px" />

                        <br />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />

                    </asp:Panel>
                   

                    
                    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" CssClass="fondo" Height="796px" ScrollBars="Horizontal" HorizontalAlign="Center" >
                   <br />
                   <asp:Label ID="Label19" runat="server" Text="Datos encontrados:" style="font-size: x-large; font-weight: 700"></asp:Label>
                        <br />
                   <br />
                   <asp:GridView ID="GridView1" runat="server" Height="16px" Width="347px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" HorizontalAlign="Center" style="font-size: medium">
                       <Columns>
                           <asp:ButtonField CommandName="Select" HeaderText="Ver Info" Text="Seleccionar" />
                       </Columns>
                   </asp:GridView>
                        <br />
                        <br />
                        <asp:Label ID="Label57" runat="server" style="font-size: x-large; font-weight: 700" Text="Resultados:"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label58" runat="server" Text="Cantidad total de registros:" CssClass="auto-style1"></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label63" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label59" runat="server" Text="Nº de PPS vencidas:" CssClass="auto-style1"></asp:Label>
                        &nbsp;<asp:Label ID="Label64" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label60" runat="server" Text="Nº de PPS finalizadas:" CssClass="auto-style1"></asp:Label>
                        &nbsp;<asp:Label ID="Label65" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label61" runat="server" Text="Nº de PPS de baja:" CssClass="auto-style1"></asp:Label>
                        &nbsp;<asp:Label ID="Label66" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
                        <br />
                        <br />
                        <asp:Label ID="Label62" runat="server" Text="Nº de PPS en curso:" CssClass="auto-style1"></asp:Label>
                        &nbsp;<asp:Label ID="Label67" runat="server" Text="Label" CssClass="auto-style1"></asp:Label>
                        <br />
                        <br />
                        <hr />
                        <asp:Panel ID="Panel8" runat="server" CssClass="fondo">

                            <asp:Button ID="Button5" runat="server" Text="Reporte PDF" class="btn btn-danger" OnClick="Button5_Click1" />
                        &nbsp;<asp:Button ID="Button8" runat="server" Text="Reporte Excel" class="btn btn-danger" OnClick="Button8_Click1"/>
                        <br />
                        </asp:Panel>
                        
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
               </asp:Panel>
                     <asp:Panel ID="Panel7" runat="server" CssClass="fondo" BorderStyle="Solid" ScrollBars="Horizontal" HorizontalAlign="Center">
                         &nbsp;<span class="auto-style6"><strong>Informacion de:</strong></span>&nbsp;
                         <asp:Label ID="Label68" runat="server" Text="Label" style="text-align: center; font-weight: 700; font-size: x-large"></asp:Label>
                         <br />
                         <br />
                         <asp:GridView ID="GridView3" runat="server" HorizontalAlign="Center">
                             <Columns>
                                 <asp:ButtonField HeaderText="Cambiar" Text="Cambiar a &quot;Finalizada&quot;" />
                             </Columns>
                         </asp:GridView>
                         <br />
                         <hr />
                         <asp:Label ID="Label71" runat="server" style="font-weight: 700; font-size: large;" Text="Dar de baja"></asp:Label>
                         <br />
                         <br />
                         <asp:Label ID="Label72" runat="server" style="font-weight: 700; font-size: large" Text="Observaciones:"></asp:Label>
                         &nbsp;
                         <asp:TextBox ID="TextBox16" runat="server" Height="53px" Width="286px"></asp:TextBox>
                         &nbsp;<asp:Button ID="Button13" runat="server" Text="Dar de baja" Width="155px" Class="btn btn-info" OnClick="Button13_Click" Height="41px" />
                         <br />
                         <br />
                    </asp:Panel>
                    <br />
                     <br />
                     <br/>

  </div>
               
             </form>
       </div>
       
              
                      <%-- <a><asp:Button ID="Button3" runat="server" Text="PPS" cssclass="form-control btn btn-info" /></a>                 
                       <a> <asp:Button ID="Button2" runat="server" Text="Convenios" cssclass="form-control btn btn-info"/> </a> 
                       <asp:Button ID="Button1" runat="server" Text="Capacitaciones" cssclass="form-control btn btn-info" OnClick="Button1_Click"/>
                        --%>
                             
           

        
    
       <%--  </div>  
              </div>  
          
          </div> 
  


    </div>  --%> 
  <%--<div class="container margen">

  
    <asp:Panel ID="Panel1" runat="server" Height="1318px" BorderStyle="Solid">
        <asp:Label ID="Label1" runat="server" Text="Seleccione lo que desee:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Tipo de PPS:"></asp:Label>
        &nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Tecnico</asp:ListItem>
            <asp:ListItem>Ingeniero</asp:ListItem>
            <asp:ListItem>Todo</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Condicion"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>Convenio/Protocolo</asp:ListItem>
            <asp:ListItem>Convalidacion</asp:ListItem>
            <asp:ListItem>Todo</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Carrera"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>Ing. Civil</asp:ListItem>
            <asp:ListItem>Ing. Informatica</asp:ListItem>
            <asp:ListItem>Ing. Industrial</asp:ListItem>
            <asp:ListItem>Ing. Telecomunicaciones</asp:ListItem>
            <asp:ListItem>Todo</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Desde:"></asp:Label>
        &nbsp;<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Hasta:"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Empresa:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button4" runat="server" Text="Agregar" />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </asp:Panel>
  </div>--%>
</body>
</html>
