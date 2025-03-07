<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmActivador.aspx.cs" Inherits="SummaWeb.webfrmActivador" %>

<%@ OutputCache Location="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summa Advanced (Ver <%=qversion%>)</title>
    <link id="favicon" rel="shortcut icon" type="image/png" href="imagenes/qiconnav.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />--%>
    <link href="css/font-awesome.min.css?v=2.10.16" rel="stylesheet" />
    <link href="css/bootstrap.min.css?v=2.10.16" rel="stylesheet" />


    <script src="Script/modernizr-2.6.2.js"></script>
    <script src="Script/jquery-1.10.2.min.js"></script>
    <script src="Script/jquery-ui-1.12.0.min.js"></script>
    <%--<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>
    <script src="Script/bootstrap.min.js"></script>

    <link href="css/themes/infragistics/infragistics.theme.css?v=2.10.16" rel="stylesheet" />
    <link href="css/structure/infragistics.css?v=2.10.16" rel="stylesheet" />

    <script src="Script/Recursos/infragistics-es.js?v=2"></script>
    <script src="Script/infragistics.core.js?v=2"></script>
    <script src="Script/infragistics.lob.js?v=2"></script>
    <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>
    <%--<script type="text/javascript" src="Script/qcomunes.min.js?v=<%=qversion %>"></script>--%>
    <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <style>
        /*body {
            background-color: #424242;
            font-family: "Segoe UI";
            font-size: small;
            font-weight: lighter;
            margin: 0;
            background-image: url("Imagenes/fondoazul.jpg");
            background-repeat: no-repeat;
            color: darkslategray;
            height:100%;
            width:100%;
        }*/
        body, html {
            height: 100%;
            background-repeat: no-repeat;
            background-color: #424242;
            font-family: "Segoe UI";
            font-size: small;
            font-weight: 500
        }

        body {
            background: black; /* #2E2E2E; /* For browsers that do not support gradients */
            /*
            background: -webkit-radial-gradient(black, #2E2E2E); /* For Safari 5.1 to 6.0 */
            /*
            background: -o-radial-gradient(black, #2E2E2E); /* For Opera 11.1 to 12.0 */
            /*
            background: -moz-radial-gradient(black, #2E2E2E); /* For Firefox 3.6 to 15 */
            /*
            background: radial-gradient(black, #2E2E2E); /* Standard syntax (must be last) */
        }

        .main {
            margin-top: 10px;
        }

        h1.title {
            font-size: 30px;
            font-weight: 600;
            color: white;
            text-shadow: 3px 3px #337ab7;
        }

        h2.title {
            font-size: 20px;
            font-weight: 400;
            color: white;
            text-shadow: 3px 3px #337ab7;
        }

        .title {
            font-size: 20px;
            font-weight: 500;
            color: white;
            text-shadow: 3px 3px #337ab7;
            vertical-align: bottom;
        }

        .form-group {
            margin-bottom: 5px;
        }

        label {
            margin-bottom: 15px;
        }

        input,
        input::-webkit-input-placeholder {
            font-size: 11px;
            padding-top: 3px;
        }

        .main-login {
            background-color: transparent; /*#2E2E2E;*/
            color: gainsboro;
            /* shadows and rounded borders */
            -moz-border-radius: 4px;
            -webkit-border-radius: 4px;
            border-radius: 4px;
            border-color: gainsboro;
            border-style: double;
            border-width: thin;
        }

        .main-center {
            margin-top: 30px;
            margin: 0 auto;
            max-width: 330px;
            padding: 40px 40px;
        }

        .login-button {
            margin-top: 5px;
        }

        .login-register {
            font-size: 11px;
            text-align: center;
        }

        .input-group-addon {
            background-color: #2E2E2E; /*#428bca;*/
            color: gainsboro; /*#337ab7;*/
        }

        .btn-ingreso {
            border-radius: 8px;
        }

        .ui-igtrialwatermark {
            width: 0px;
            height: 0px;
            background-image: none;
            opacity: .25;
            filter: alpha(opacity=25);
            -ms-filter: "alpha(opacity=25)";
            -khtml-opacity: .25;
            -moz-opacity: .25
        }

        /*.ui-qMR {
            width: 50px;
            height: 50px;
            background-image: url(Imagenes/qlogo.png);
            opacity: .25;
            filter: alpha(opacity=25);
            -ms-filter: "alpha(opacity=25)";
            -khtml-opacity: .25;
            -moz-opacity: .25
        }*/
    </style>
</head>
<body>
    <div class="container">
        <div class="row main">

            <div class="panel-heading" style="padding-bottom: 0px">
                <div class="panel-title text-center">
                    <%--                    <asp:Image ImageUrl="Imagenes/qlogo.png" runat="server" Height="25px" Width="25px"/>
                    <span class="title">Quasar Global</span>                    --%>
                    <asp:Image ImageUrl="Imagenes/qsummaadv.jpg" runat="server" Style="opacity: 0.6" Height="94px" Width="300px" />
                </div>

                <%--                <div class="panel-title text-center">
                    <h1 class="title">Summa Advanced</h1>
                </div>--%>
            </div>
            <div class="main-login main-center">
                <form id="form1" runat="server" class="form-horizontal">
                    <div id="divLogin">
                        <%-- <input type="text" id="sesstrg" name="sesstrg" runat="server" hidden="hidden" />
                        <input type="text" id="instalacion" name="instalacion" runat="server" hidden="hidden" />
                        <input type="text" id="empfija" name="empfija" runat="server" hidden="hidden" />
                        <input type="text" id="confirmacion" name="confirmacion" runat="server" hidden="hidden" />
                        <input type="text" id="sitio" name="sitio" runat="server" hidden="hidden" />
                        <input type="checkbox" id="cambiarclave" name="cambiarclave" runat="server" hidden="hidden" />--%>
                        <div class="form-group">
                            <div>
                                <asp:Label id="LblMensaje" CssClass="cols-sm-2 control-label" runat="server">Contacte_a_Su_Implementador_Para_Recibir_su_Serial</asp:Label>
                            </div>
                            
                            <label for="TxtLicencia" id="lLicencia" class="cols-sm-2 control-label">Licencia</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-user"></span></span>
                                    <asp:TextBox ID="TxtLicencia" CssClass="form-control" ForeColor="Black" runat="server" Width="100%" Enabled="false"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="TxtClave" id="lClave" class="cols-sm-2 control-label">Serial</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                    <asp:TextBox ID="TxtClave" CssClass="form-control" runat="server" ForeColor="Black" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                            
                        </div>
                        <div class="form-group ">
                            <div style="border-top-color: white; border-top-width: thin; border-top-style: solid; padding-top: 7px">
                                
                                <span style="float: right; text-align: center; display: block">
                                    <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Guardar" OnClick="btnGuardar_Click"></asp:Button>
                                </span>
                            </div>
                        </div>
                </form>
            </div>
            <div class="panel-heading" style="padding-top: 0px; margin-top=-10px">
                <div class="panel-title text-center">
                    <%--                    <asp:Image ImageUrl="Imagenes/qlogo.png" runat="server" Height="25px" Width="25px"/>
                    <span class="title">Quasar Global</span>                    --%>
                    <asp:Image ImageUrl="Imagenes/qlogocomp.jpg" runat="server" Style="opacity: 0.4" Height="104px" Width="150px" />
                </div>
            </div>
        </div>
    </div>

</body>
</html>
