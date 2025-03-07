<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SummaWeb.Login" %>

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
                        <input type="text" id="sesstrg" name="sesstrg" runat="server" hidden="hidden" />
                        <input type="text" id="instalacion" name="instalacion" runat="server" hidden="hidden" />
                        <input type="text" id="grpinstalacion" name="grpinstalacion" runat="server" hidden="hidden" />
                        <input type="text" id="empfija" name="empfija" runat="server" hidden="hidden" />
                        <input type="text" id="confirmacion" name="confirmacion" runat="server" hidden="hidden" />
                        <input type="text" id="sitio" name="sitio" runat="server" hidden="hidden" />
                        <input type="checkbox" id="cambiarclave" name="cambiarclave" runat="server" hidden="hidden" />
                        <input type="checkbox" id="chktwofactor" name="twofactor" runat="server" hidden="hidden" />
                        <div class="form-group">
                            <label for="TxtUsuario" id="lUsuario" class="cols-sm-2 control-label">Usuario</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-user"></span></span>
                                    <asp:TextBox ID="TxtUsuario" CssClass="form-control" ForeColor="Black" runat="server" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="TxtClave" id="lClave" class="cols-sm-2 control-label">Clave</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                    <asp:TextBox ID="TxtClave" CssClass="form-control" runat="server" ForeColor="Black" TextMode="Password" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div id="divTwoFactor" style="display: none">
                            <div class="form-group" id="grpTwoFactor">
                                <asp:Label runat="server" for="txtTwoFactor" id="lblTwoFactor" class="cols-sm-2 control-label">Codigo</asp:Label>
                                <div class="cols-sm-10">
                                    <div class="input-group">
                                        <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                        <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                        <asp:TextBox ID="txtTwoFactor" CssClass="form-control" runat="server" ForeColor="Black" Width="100%"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="dpEmpresa" id="lEmpresa" class="cols-sm-2 control-label">Empresa</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-certificate"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-building-o"></span></span>
<%--                                    <asp:DropDownList ID="dpEmpresa" CssClass="form-control" runat="server" ForeColor="Black" Width="100%" OnSelectedIndexChanged="dpEmpresa_SelectedIndexChanged" OnLoad="dpEmpresa_Load" OnTextChanged="dpEmpresa_TextChanged"></asp:DropDownList>--%>
                                        <asp:DropDownList ID="dpEmpresa" CssClass="form-control" runat="server" ForeColor="Black" Width="100%" ></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="cols-sm-12">
                                <div class="input-group">
                                    <asp:Label ID="lblmsg" runat="server" Style="padding-bottom: 5px; color: white; text-shadow: 1px 1px red;"></asp:Label>
                                    <br />

                                </div>
                            </div>
                        </div>
                        <div class="form-group ">
                            <div style="border-top-color: white; border-top-width: thin; border-top-style: solid; padding-top: 7px">
                                <span style="float: left; text-align: center; display: block">
                                    <asp:LinkButton ID="lnkCambioClave" runat="server" Text="Cambiar Clave" OnClick="lnkCambioClave_Click" Font-Underline="true" TabIndex="-1"></asp:LinkButton>
                                </span>
                                <span style="float: right; text-align: center; display: block">
                                    <asp:Button ID="btnIngreso" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Ingresar" OnClick="btnIngreso_Click"></asp:Button>
                                </span>
                                <br />
                                <span style="float: left; text-align: center; display: block">
                                    <asp:LinkButton ID="lnkOlvidoClave" runat="server" Text="Olvido su Clave?" OnClick="lnkOlvido_Click" Font-Underline="true" TabIndex="-1"></asp:LinkButton>
                                </span>
                                <br />
                                <span style="float: left; text-align: center; display: block">
                                    <asp:LinkButton ID="lnkFechaVenc" runat="server" Text="Vencimiento"  OnClick="lnkFechaVenc_Click" Font-Underline="true" TabIndex="-1"></asp:LinkButton>
                                </span>

                                <%--                                <div class="form-group ">
                                    <span style="text-align: center; display: block">
                                        <asp:Button ID="btnIngreso" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Ingresar" OnClick="btnIngreso_Click"></asp:Button>
                                    </span>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                    <div id="divCambioClave" style="display: none">
                        <div id="divTituloCC" class="form-group">
                            <asp:Label ID="lTituloCC" runat="server" Style="text-align: center; color: white; text-shadow: 1px 1px red;"></asp:Label>
                        </div>
                        <div class="form-group">
                            <label id="lUsuarioCC" class="cols-sm-2 control-label">Usuario</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-user"></span></span>
                                    <asp:TextBox ID="TxtUsuarioCC" CssClass="form-control" ForeColor="Black" runat="server" Width="100%" disabled="disabled"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="TxtClaveCC" id="lClaveCC" class="cols-sm-2 control-label">Clave Actual</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                    <asp:TextBox ID="TxtClaveCC" CssClass="form-control" runat="server" ForeColor="Black" TextMode="Password" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="TxtClaveNuevaCC" id="lClaveNuevaCC" class="cols-sm-2 control-label">Nueva Clave</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                    <asp:TextBox ID="TxtClaveNuevaCC" CssClass="form-control" runat="server" ForeColor="Black" TextMode="Password" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="TxtClaveNueva2CC" id="lClaveNueva2CC" class="cols-sm-2 control-label">Confirmar Nueva Clave</label>
                            <div class="cols-sm-10">
                                <div class="input-group">
                                    <%--<span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>--%>
                                    <span class="input-group-addon"><span class="fa fa-key"></span></span>
                                    <asp:TextBox ID="TxtClaveNueva2CC" CssClass="form-control" runat="server" ForeColor="Black" TextMode="Password" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="cols-sm-12">
                                <div class="input-group">
                                    <asp:Label ID="lblMensajeCC" runat="server" Style="padding-bottom: 5px; color: white; text-shadow: 1px 1px red;"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="form-group ">
                            <div style="border-top-color: white; border-top-width: thin; border-top-style: solid; padding-top: 7px">
                                <span style="float: left; text-align: center; display: block">
                                    <asp:LinkButton ID="lnkVolver" runat="server" Text="Volver" OnClick="lnkVolver_Click" Font-Underline="true"></asp:LinkButton>
                                </span>
                                <span style="float: right; text-align: center; display: block">
                                    <asp:Button ID="btnConfirmar" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Registrar" OnClick="btnRegistrar_Click"></asp:Button>
                                </span>
                                <%--                                <div class="form-group ">
                                    <span style="text-align: center; display: block">
                                        <asp:Button ID="btnIngreso" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Ingresar" OnClick="btnIngreso_Click"></asp:Button>
                                    </span>
                                </div>--%>
                            </div>
                        </div>
                    </div>

                    <div class="container">
                        <div id="myModal" class="modal fade">
                            <div class="modal-dialog modal-md">
                                <div class="modal-content popupbody">
                                    <div class="modal-header btn-primary">
                                        <%--<asp:Label ID="lblConfTitulo" runat="server" Style="color:white; ">Desea Hacer algo</asp:Label>--%>
                                    </div>
                                    <div class="container-fluid" style="background-color: #2E2E2E">
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <br />
                                                <asp:Label ID="lblConfMensaje" runat="server" Style="padding-bottom: 10px; padding-top: 10px; color: white;">Desea Hacer algo</asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <br />
                                            </div>
                                        </div>
                                    </div>
                                    <div id="footerConf" class="modal-footer" style="background-color: #2E2E2E">
                                        <asp:Button ID="btnAceptarConf" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Aceptar" OnClick="btnAceptarConf_Click"></asp:Button>
                                        <asp:Button ID="btnCancelarConf" runat="server" CssClass="btn btn-md btn-danger btn-ingreso" role="button" Text="Cancelar" OnClick="btnCancelarConf_Click"></asp:Button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="container">
                        <div id="ModalCCPendiente" class="modal fade">
                            <div class="modal-dialog modal-md">
                                <div class="modal-content popupbody">
                                    <div class="modal-header btn-primary">
                                        <%--<asp:Label ID="lblConfTitulo" runat="server" Style="color:white; ">Desea Hacer algo</asp:Label>--%>
                                    </div>
                                    <div class="container-fluid" style="background-color: #2E2E2E">
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <br />
                                                <asp:Label ID="lblCCPendiente" runat="server" Style="padding-bottom: 10px; padding-top: 10px; color: white;">Desea Hacer algo</asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <br />
                                            </div>
                                        </div>
                                    </div>
                                    <div id="footerCCPendiente" class="modal-footer" style="background-color: #2E2E2E">
                                        <asp:Button ID="btnAceptarCCPendiente" runat="server" CssClass="btn btn-md btn-primary btn-ingreso" role="button" Text="Si" OnClick="btnAceptarCCPendiente_Click"></asp:Button>
                                        <asp:Button ID="btnCancelarCCPendiente" runat="server" CssClass="btn btn-md btn-danger btn-ingreso" role="button" Text="No" OnClick="btnCancelarCCPendiente_Click"></asp:Button>
                                    </div>
                                </div>
                            </div>
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
    <script type='text/javascript'>
        $(function () {
            if (sessionStorage.getItem("cerrosession") != undefined) {
                qCerrarSesion();
                sessionStorage.removeItem("cerrosession");
            }
            var lValor = qcom_ObtenerSesStrg(true);
            $('#sesstrg').val(lValor);
            lValor = $('#instalacion').val();
            sessionStorage.setItem("idinst", lValor);
            var lValor1 = $('#grpinstalacion').val();
            sessionStorage.setItem("grpinst", lValor1);
            sessionStorage.setItem("empfija", $('#empfija').val());
            sessionStorage.setItem("sitio", $('#sitio').val());
            qcom_SetearEnServerSesStrg(false, false);
            $("#lUsuario")[0].innerText = qrecUsuario;
            $("#lEmpresa")[0].innerText = qrecEmpresa;
            $("#lClave")[0].innerText = qrecClave;
            $("#lUsuarioCC")[0].innerText = qrecUsuario;
            $("#lClaveCC")[0].innerText = qrecClave;
            $("#lClaveNuevaCC")[0].innerText = qrecClaveNueva;
            $("#lClaveNueva2CC")[0].innerText = qrecClaveNueva2;
            $("#lnkCambioClave")[0].innerText = qrecCambiarClave;
            $("#lnkVolver")[0].innerText = qrecCancelar;
            $("#btnIngreso")[0].value = qrecIngresar;
            $("#btnConfirmar")[0].value = qrecConfirmar;
            $("#btnAceptarConf")[0].value = qrecAceptar;
            $("#btnCancelarConf")[0].value = qrecCancelar;


            if ($("#cambiarclave")[0].checked) {
                $("#divLogin").hide();
                $("#divCambioClave").show();
                $("#lClaveCC").focus();
            }
            else {
                $("#divCambioClave").hide();
                $("#divLogin").show();
                $("#lUsuario").focus();
            }
            if ($("#chktwofactor")[0].checked) {
                $("#divTwoFactor").show();
            }
            else {
                $("#divTwoFactor").hide();
            }

            //Inicio Grupos de Instalaciones            
            $("#<%=dpEmpresa.ClientID %>").change(function () {
                var larrCompo = this.value.split('|');
                $('#instalacion').val(larrCompo[1]);
                sessionStorage.setItem("idinst", $('#instalacion').val());
                $("#lnkFechaVenc")[0].innerText = larrCompo[2];
                if (larrCompo[2] !== "")
                    $("#lnkFechaVenc").show();
                else
                    $("#lnkFechaVenc").hide();
            });

            //Fin Grupos de Instalaciones            
            //var wm2 = $("#qMR").length > 0 ? $("#qMR") : $("<div id='qMR'></div>").appendTo(document.body);
            //wm2.css({ position: "fixed", bottom: 0, right: 0, zIndex: 1e3 }).addClass("ui-qMR")
        });

        window.onbeforeunload = function (e) {
            qcom_SetearEnServerSesStrg(false, false);
        }

        //window.onunload = function (e) {
        //    //Inicio Grupos de Instalaciones
        //    var lValor = $('#instalacion').val();
        //    sessionStorage.setItem("idinst", lValor);
        //    sessionStorage.setItem($.now(), lValor );
        //    //Fin Grupos de Instalaciones
        //    //qcom_SetearEnServerSesStrg(false, false);
        //}    

    </script>
</body>
</html>
