<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmInicio.aspx.cs" Inherits="SummaWeb.webfrmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>--%>
    <link href="css/bootstrap.min.css?v=2.10.16" rel="stylesheet" />      
<%--    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
    <script src="Script/modernizr-2.6.2.js"></script>
    <script src="Script/jquery-1.10.2.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
  

  <style>


    html {
        height: 100%;
    }
    body {
        height: 100%;
    }

    .bodygradiente {
    /*background-repeat: no-repeat;
    background-attachment: fixed;*/
    background: black;/*#2E2E2E;*/ /* For browsers that do not support gradients */
    /*background: -webkit-radial-gradient(black, darkgrey); /* For Safari 5.1 to 6.0 */
    /*background: -o-radial-gradient(black, darkgrey); /* For Opera 11.1 to 12.0 */
    /*background: -moz-radial-gradient(black, darkgrey); /* For Firefox 3.6 to 15 */
    /*background: radial-gradient(black, darkgrey); /* Standard syntax (must be last) */
}

  .jumbotron {
      background-color:black;/*#2E2E2E;*/
      color:lightslategray;
      text-align:center;
  }

  </style>

</head>
<body class="bodygradiente">
    <form id="form1" runat="server">
    <div class="container">
      <div class="jumbotron" style="padding-top: 10px;padding-bottom: 1px; margin: 10px;">
        <%--<h1>Summa Advanced</h1> --%>
        <asp:Image ImageUrl="Imagenes/qsummaadv.jpg" runat="server" style="opacity:0.8" Height="94px" Width="300px"/>
        <p style="margin-top: 25px; border-top-color:#2E2E2E; border-top-style:solid; border-top-width:thin">
            La solución para la gestión y administración de la mediana y gran empresa. Accesible desde cualquier dispositivo
        </p>
      </div>
    </div>
    <br/>
    <div class="container">
        <div class="row" style="border-bottom-color:#2E2E2E; border-bottom-style:solid; border-bottom-width:thin">
                <div class="col-sm-4"><h4 class="text-center">Permite a las empresas concretar su potencial, operando de manera más rápida y productiva, al ser una estrategia robusta, integral y dinámica, pero sobre todo, amigable y fácil de usar.</h4></div>
                <div class="col-sm-4"><h4 class="text-center">Integra, coordina y automatiza todas las áreas y los procesos de negocio</h4></div>
                <div class="col-sm-4"><h4 class="text-center">Cuenta con herramientas que permiten llevar las regulaciones adecuadas en cada proceso operativo, con lo que obtienen la seguridad de que sus colaboradores desempeñan su trabajo con orden, disciplina y sin omitir los controles de seguridad.</h4></div>
        </div>
    </div>
    <br/>
    <div class="container" style="text-align:center;">
           <asp:Image ImageUrl="Imagenes/qlogocomp.jpg" runat="server" style="opacity:0.8" Height="104px" Width="150px"/>
    </div>
    </form>
</body>
</html>
