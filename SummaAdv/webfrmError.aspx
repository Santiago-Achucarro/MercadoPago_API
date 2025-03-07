<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmError.aspx.cs" Inherits="SummaWeb.webfrmError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Summa Advanced Error</title>
  <link id="favicon" rel="shortcut icon" type="image/png" href="imagenes/qiconnav.png" />
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <script src="Script/modernizr-2.6.2.js"></script>
  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
  <script src="Script/bootstrap.min.js"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion%>"></script>
  <link rel="stylesheet" href="css/fontawesome/css/all.min.css?v=2.10.82" />
  <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />      

<style>

    html {
        height: 100%;
    }
    body {
        height: 100%;
        background-color: black;
    }
    h3, h4 {
        color:white;
    }
   .jumbotron {
      background-color:#2E2E2E;
      color:lightslategray;
      text-align:center;
    }

</style>

</head>
<body>
    <form id="form1" runat="server">
<%--    <div class="container">
      <div class="jumbotron">
        <h1>Summa Advanced</h1>      
      </div>
    </div>--%>
    <br/>
    <div class="container">
        <div class="row">
            <div class="col-sm-12 text-center">
                  <asp:Image ImageUrl="Imagenes/qsummaadv.jpg" runat="server" style="opacity:0.7" Height="94px" Width="300px"/>
            </div>
    </div>
    <br/>
        <div class="row" style="border-top-color:#909091; border-top-style:solid; background-color:#1a1a1a">
             <div class="col-sm-12"><h3 id="lError" class="text-center" runat="server">Se Ha Producido un Error</h3></div>
        </div>
        <div class="row" style="border-bottom-color:#909091; border-bottom-style:solid; background-color:#1a1a1a">
             <div class="col-sm-12"><h4 id="lDescError" class="text-center" runat="server">Error No Especificado</h4></div>
        </div>
        <br/>        
        <div class="row">
             <div class="col-sm-12"><h4 id="H2" class="text-center" runat="server"><a href="javascript:qcom_SetearEnServerSesStrg(false, true);"><i class="fa fa-sign-in"></i>  Iniciar Sesíón</a></h4></div>
        </div>
        <br/>        
        <br/>        
        <br/>        
        <br/>        
        <div class="row">
            <div class="col-sm-12 text-center">
                  <asp:Image ImageUrl="Imagenes/qlogocomp.jpg" runat="server" style="opacity:0.4" Height="104px" Width="150px"/>
            </div>
        </div>
    </div>
    </form>

</body>
</html>
