<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmEspecial.aspx.cs" Inherits="SummaWeb.webfrmEspecial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>SummAdvance</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
  <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />      
<link rel="stylesheet" href="css/qprincipal.css?v=2.10.82" />
   <style>


    html {
        height: 100%;
    }
    body {
        height: 100%;
    }

    .bodygradiente {
        background: black;/*#2E2E2E;*/ /* For browsers that do not support gradients */
    }
  </style>

</head>
<body class="bodygradiente">
    <form id="form1" runat="server">
        
        <div id="divPrincipal" class="container-fluid" style="height:100%" >
            <iframe id="inlineFrameExample" runat="server" class="quasar-iframe" style="overflow: hidden; height: 100%; width: 100%;" runat="server"/>
        </div>
        <script type='text/javascript'>
            $(function () {
                var laltoPopup = document.body.clientHeight - 10;
                $('#divPrincipal').css('height', laltoPopup);
                $("#inlineFrameExample")[0].src = "<%=qurl%>";
                $(window).resize(function () {
                    var laltoPopup = document.body.clientHeight - 10;
                    $('#divPrincipal').css('height', laltoPopup);
                });


            })
        </script>
    </form>
</body>
</html>
