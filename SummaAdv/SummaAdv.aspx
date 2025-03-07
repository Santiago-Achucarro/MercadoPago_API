<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaAdv.aspx.cs" Inherits="SummaWeb.SummaAdv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>SummAdvance</title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
      <meta property="og:title" content="Summa Advanced" />
      <meta property="og:type" content="website" />
  <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>--%>
    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>--%>
  <script src="Script/modernizr-2.6.2.js"></script>
  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
<%--  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
  <script src="Script/bootstrap.min.js"></script>

<%--  <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />      
  <link href="css/themes/infragistics/infragistics.theme.css?v=2.10.82" rel="stylesheet" />
  <link href="css/structure/infragistics.css?v=2.10.82" rel="stylesheet" />
  <link href="css/qbasico.css?v=3.00.64" rel="stylesheet" />

  <script src="Script/infragistics-es.js?v=2"></script>
  <script src="Script/infragistics.core.js?v=2"></script>
  <script src="Script/infragistics.lob.js?v=2"></script>
    

  <script type="text/javascript" src="Script/qvariables.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qdatos.min.js?v=<%=qversion %>"></script>
    <!-- Ignite UI Required Combined JavaScript Files -->
  <script type="text/javascript" src="Script/qalertas.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qcomunes.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qpopup.min.js?v=<%=qversion %>"></script>--%>
<style>
     body, html {
            height: 100%;
            background-repeat: no-repeat;
            background-color: #424242;
            font-family: "Segoe UI";
            font-size: small;
            font-weight: 500
        }

        body {
            background: #2E2E2E; /* For browsers that do not support gradients */
            background: -webkit-radial-gradient(black, #2E2E2E); /* For Safari 5.1 to 6.0 */
            background: -o-radial-gradient(black, #2E2E2E); /* For Opera 11.1 to 12.0 */
            background: -moz-radial-gradient(black, #2E2E2E); /* For Firefox 3.6 to 15 */
            background: radial-gradient(black, #2E2E2E); /* Standard syntax (must be last) */
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
      <div class="jumbotron">
        <h1>Summa Advanced</h1>      
        <p>No es posible inicio sesión</p>
      </div>
    </div>
    <div id="divAlertas" class="container-fluid">
    </div>
    </form>
</body>
</html>
