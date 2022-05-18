<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina Principal.aspx.cs" Inherits="Catolica.Pagina_Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel ="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" /> 
    <link href="Estilos/Estilos.css" rel="stylesheet" />
</head>
<body>

  <nav class="navbar navbar-dark bg-dark"">
                      <a class="navbar-brand" href="#">
                        <img src="Imagen/UBagxEL3_400x400.jpg" width="35" class="d-inline-block align-top" alt=""/>
                        <strong>
                            Departamento de extension y graduados- UCASAL.
                        </strong> 
                      </a>
</nav>
    <hr />
      <div class="container contenedor " >
          <div class="contenedor">
                <div class =" row">
                   
                      <div class="col-md-12 contenedor1" style="position: absolute; width: 440px; height: 362px; top: 31px; right: 186px; bottom: -148px; left: 170px">
                          <div class="container">
         <div class="row">
           <div class="col-md-12 ">
               <h1>Iniciar sesion</h1>
           </div>          
    
         <form id="form1" runat="server"  style="width:111%">
             <div class="form-group " style="width:100%">
                   <asp:Label ID="Label3" runat="server" Text="Usuario" ></asp:Label>
               
                 <div class="col-sm-12">
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>                             
                 </div>
                 </div>
              <div class="form-group" style="width:100%">
                   <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
                    <div class="col-sm-12">
                      <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                 </div>
            </div>
             <br />
                 <div class="form-group ">
                       <asp:Button ID="Button1" runat="server" Text="Iniciar sesion" CssClass="form-control btn btn-primary" OnClick="Button1_Click" style="width:100%"/>
                 </div>         
        </form>
    </div>
        </div>
  
             </div>
       
            <hr />
            
 
            </div>
        </div>
          </div>
 
</body>
</html>
