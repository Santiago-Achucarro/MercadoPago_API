<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmMLConfig.aspx.cs" Inherits="SummaWeb.webfrmMLConfig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summa Advanced></title>
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
    <link href="css/qbasico.css?v=3.34.00" rel="stylesheet" />

    <script src="Script/Recursos/infragistics-es.js?v=2"></script>
    <script src="Script/infragistics.core.js?v=2"></script>
    <script src="Script/infragistics.lob.js?v=2"></script>
    <script type="text/javascript" src="Script/qcomunes.min.js?v=2.10.34"></script>
    <script type="text/javascript" src="Script/qalertas.min.js?v=2.10.34"></script>
    <script type="text/javascript" src="Script/qpopup.min.js?v=2.10.34"></script>
    <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js"></script>
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
            background: black;
        }

        h1 {
            font-size: 30px;
            font-weight: 600;
            color: white;
            text-shadow: 3px 3px #337ab7;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divPrincipal" class="container-fluid">
            <div id="divAlertas" class="container-fluid">
            </div>
            <div id="divMensajeExito">
            </div>
            <div class="container-fluid">
                <div class="row">
                <div class="panel-heading" style="padding-bottom: 0px">
                    <div class="panel-title text-center">
                        <asp:Image ImageUrl="Imagenes/qsummaadv.jpg" runat="server" style="opacity:0.6" Height="94px" Width="300px"/>
                    </div>
                </div>
                </div>


                <div class="row">
                    <div id="divctrTitulo" class="form-group col-sm-12 quasar-box text-center">
                        <label></label><br />
                        <h1 id='lblctrTitulo'>Configuración de Aplicación en Mercado Libre</h1><br />
                        <label></label><br />
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divctrURL" class="form-group col-sm-4 quasar-box">
                        <label for='ctrURL' id='lblctrURL'>Redirect URL</label><br />
                        <input id='ctrURL' value='' disabled="disabled" />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>

                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divctrApp_Id" class="form-group col-sm-4 quasar-box">
                        <label for='ctrApp_Id' id='lblctrApp_Id'>Aplicación Id</label><br />
                        <input id='ctrApp_Id' value='' />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divctrSecretKey" class="form-group col-sm-4 quasar-box">
                        <label for='ctrSecretKey' id='lblctrSecretKey'>Secret Key</label><br />
                        <input id='ctrSecretKey' value='' />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>

                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divctrToken" class="form-group col-sm-4 quasar-box">
                        <label for='ctrToken' id='lblctrToken'>Token</label><br />
                        <input id='ctrToken' value='' />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>

                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divctrRefreshToken" class="form-group col-sm-4 quasar-box">
                        <label for='ctrRefreshToken' id='lblctrRefreshToken'>RefreshToken</label><br />
                        <input id='ctrRefreshToken' value='' />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>


                <div class="row">
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                    <div id="divDisenioBoton5" class="form-group col-sm-4 quasar-box text-center">
                        <label for='DisenioBoton5' id='lblDisenioBoton5'></label>
                        <br />
                        <button type='button' id="DisenioBoton5" class='btn quasar-btn' style="height: 23px; width: 120px;">Registrar Datos Aplic</button>
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                    </div>
                </div>
                <div class="row">
                    <div id="divctrMensaje" class="form-group col-sm-12 quasar-box" style="display:none">
                        <label for='ctrMensaje' id='lblctrMensaje'>Mensaje</label><br />
                        <input id='ctrMensaje' value='' />
                    </div>
                </div>
                <div class="row">
                    <div id="divctrLink" class="form-group col-sm-12 quasar-box" style="display:none">
                        <label for='ctrLink' id='lblctrLink'>Link</label><br />
                        <input id='ctrLink' value='' />
                    </div>
                </div>

            </div>
        </div>
        <script type='text/javascript'>
            $(function () {

                var mMensaje = "<%=qMensaje%>";
                var mAppId = "<%=qappid%>";
                var mSecretKey = "<%=qsecretkey%>";
                var mToken = "<%=qtoken%>";
                var mRefreshToken = "<%=qrefreshtoken%>";
                var mLink = "<%=qlink%>";
                var mURL = "<%=qURL%>";
                var mMLSes = "<%=qMLSes%>";

                $("#ctrURL").igTextEditor(
                    {
                        width: "99%",
                        height: 21,
                        disabled: true,
                        maxLength: 32767,
                        buttonType: "clear",
                        textMode: 'text',
                        placeHolder: '',
                        value: mURL,
                    });

                $("#ctrApp_Id").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                        placeHolder: '',
                        value: mAppId,
                });
                $("#ctrSecretKey").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                        placeHolder: '',
                        value: mSecretKey,
                    });
                $("#ctrToken").igTextEditor(
                    {
                        width: "99%",
                        height: 21,
                        disabled: true,
                        maxLength: 32767,
                        buttonType: "clear",
                        textMode: 'text',
                        placeHolder: '',
                        value: mToken,
                    });
                $("#ctrRefreshToken").igTextEditor(
                    {
                        width: "99%",
                        height: 21,
                        disabled: true,
                        maxLength: 32767,
                        buttonType: "clear",
                        textMode: 'text',
                        placeHolder: '',
                        value: mRefreshToken,
                    });

                $("#ctrLink").igTextEditor(
                    {
                        width: "99%",
                        height: 21,
                        disabled: true,
                        maxLength: 32767,
                        buttonType: "clear",
                        textMode: 'text',
                        placeHolder: '',
                        value: mLink,
                    });

                $("#ctrMensaje").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: true,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                        placeHolder: '',
                        value: mMensaje,
                    });

                $(document).delegate("#DisenioBoton5", "click", function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    var lSecretKey = $("#ctrSecretKey").igTextEditor()[0].value;
                    var lAppId = $("#ctrApp_Id").igTextEditor()[0].value;
                    if ((lSecretKey == "") || (lAppId == ""))
                        qcom_Alerta('Debe ingresar Aplicación Id y Secret Key', 'danger', null);
                    else {
                        var lData = JSON.stringify({ 'pIdApp': lAppId, 'pSecret': lSecretKey});
                        $.ajax({
                            type: "POST",
                            url: "webfrmMLConfig.aspx/GuardarDatos",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            data: lData,
                        })
                        .done(function (data) {
                            var lValor = "https://auth.mercadolibre.com.ar/authorization?response_type=code&client_id=" + lAppId + "&redirect_uri=" + mURL;
                            $("#ctrLink").igTextEditor("value", lValor);
                            window.open(lValor, "_self")
                        })
                        .fail(function (xhr, ajaxOptions, thrownError) {
                            qcom_Alerta(xhr.responseText, 'danger', null);
                        });
                    }
                });
                var lIdSes = sessionStorage.getItem("idses");
                if (mMLSes != lIdSes) {
                    $("#DisenioBoton5").hide();
                    qcom_Alerta("No se ha invocado al formulario en forma correcta", 'danger', null);
                }
                if ($("#ctrLink").igTextEditor()[0].value != "")
                    window.open($("#ctrLink").igTextEditor()[0].value, "_self");
                else if ($("#ctrMensaje").igTextEditor()[0].value != "")
                //qcom_MensajeInformacion($("#ctrMensaje").igTextEditor()[0].value);      
                {
                    qcom_AlertaCompleto($("#ctrMensaje").igTextEditor()[0].value, 'info', false, 0, null);
                    $("#DisenioBoton5").hide();
                }

            })
        </script>
    </form>
</body>
</html>
