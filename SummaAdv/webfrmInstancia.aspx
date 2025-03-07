<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmInstancia.aspx.cs" Inherits="SummaWeb.webfrmInstancia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>webfrmInstancia</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
  <script src="Script/modernizr-2.6.2.js"></script>
  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
  <script src="Script/bootstrap.min.js"></script>

  <link rel="stylesheet" href="css/fontawesome/css/all.min.css?v=2.10.82" />
  <link rel="stylesheet" href="css/basicContext.css?v=2.10.82" />
  <link rel="stylesheet" href="css/basicContext_dark.css?v=2.10.82" />
  <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />      
  <link href="css/themes/infragistics/infragistics.theme.css?v=2.10.82" rel="stylesheet" />
  <link href="css/structure/infragistics.css?v=2.10.82" rel="stylesheet" />
 <%--<link href="css/structure/infragistics.ui.chart.css?v=2.10.82" rel="stylesheet" />--%>
  <link href="css/qbasico.css?v=3.34.00" rel="stylesheet"/>
  
  <script src="Script/infragistics.core.js?v=2"></script>
  <script src="Script/infragistics.lob.js?v=2"></script>
  <script src="Script/infragistics.dv.js?v=2"></script>

  <script src="Script/Recursos/infragistics-<%=qcultura%>.js?v=2"></script>
  <script src="Script/Recursos/qinfragistics.ui.regional-<%=qcultura%>.js?v=2"></script>

  <script type="text/javascript" src="<%=qtipoversion%>/qalertas<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qpopup<%=qextensionversion%>.js?v=<%=qversion %>"></script>

  <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divCargando"></div>
        <div id="divPrincipal" class="container-fluid">
            <div id="divAlertas" class="container-fluid"></div>
            <div id="divMensajeExito"></div>
            <div class="container-fluid">
                <div id="primer_renglon" style="padding-top:10px">   
                    <div id="primer_renglon_row" class="container-fluid">   
                        <div class="row">
                            <label for="ctrDescripcion" id="lblctrDescripcion" class="quasar-label-info-large">Crear Nueva Instancia</label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div id="divctrInstancia" class="form-group col-sm-4 quasar-box">
                            <label for='ctrInstancia' id='lblctrInstancia'>Nombre Instancia *</label><br />
                            <input id='ctrInstancia' value='' />
                    </div>
                    <div id="" class="hidden-xs col-sm-8 quasar-box-en-panel"></div>
                </div>
                <div class="row">
                    <div id="divctrUsuario" class="form-group col-sm-4 quasar-box">
                            <label for='ctrUsuario' id='lblctrUsuario'>Usuario Administrador</label><br />
                            <input id='ctrUsuario' value='' />
                    </div>
                    <div id="divctrApellido" class="form-group col-sm-4 quasar-box">
                            <label for='ctrApellido' id='lblctrApellido'>Apellido </label><br />
                            <input id='ctrApellido' value='' />
                    </div>
                    <div id="divctrNombre" class="form-group col-sm-4 quasar-box">
                            <label for='ctrNombre' id='lblctrNombre'>Nombre</label><br />
                            <input id='ctrNombre' value='' />
                    </div>
                </div>
                <div class="row">
                    <div id="divctrClave" class="form-group col-sm-4 quasar-box">
                            <label for='ctrClave' id='lblctrClave'>Clave</label><br />
                            <input id='ctrClave' value='' />
                    </div>
                    <div id="divctrClave2" class="form-group col-sm-4 quasar-box">
                            <label for='ctrClave2' id='lblctrClave2'>Repetir Clave</label><br />
                            <input id='ctrClave2' value='' />
                    </div>
                    <div class="form-group col-sm-4 quasar-box">
                        <label for='' id='lblvacio'></label><br />
                        <button type="button" id="btnConfirmar" tabindex="-1" class="btn btn-primary quasar-btn-favorito">Confirmar</button>
                    </div>
                </div>
            </div>
        </div>
        <script type='text/javascript'>
            $(function () {
                $("#ctrInstancia").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 20,
                        placeHolder: '',
                        includeKeys: "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789_",
                    });
                $("#ctrUsuario").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 25,
                        placeHolder: '',
                        toUpper: true,
                    });
                $("#ctrApellido").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 50,
                        placeHolder: '',
                        toUpper: true,
                    });
                $("#ctrNombre").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 25,
                        placeHolder: '',
                        toUpper: true,
                    });

                $("#ctrClave").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 20,
                        placeHolder: '',
                        textMode: 'password'
                    });
                $("#ctrClave2").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 20,
                        placeHolder: '',
                        textMode: 'password'
                    });

                $('#btnConfirmar').click(function () {
                    GenerarInstancia();
                });


                function GenerarInstancia() {
                    var lNombreInstancia = $("#ctrInstancia").igTextEditor()[0].value.trim();
                    var lUsuario = $("#ctrUsuario").igTextEditor()[0].value.trim();
                    var lApellido = $("#ctrApellido").igTextEditor()[0].value.trim();
                    var lNombre = $("#ctrNombre").igTextEditor()[0].value.trim();
                    var lClave = $("#ctrClave").igTextEditor()[0].value;
                    var lClave2 = $("#ctrClave2").igTextEditor()[0].value;
                    var lIdSes = sessionStorage.getItem("idses");
                    if (lNombreInstancia == "")
                        qcom_TratarError("error:Debe_Ingresar_el_nombre_de_la_nueva_Instancia");
                    else if ((lUsuario != "") &&
                        ((lApellido.trim() == "") ||
                            (lNombre.trim() == "") ||
                            (lClave.trim() == ""))) {
                        qcom_TratarError("error:Si_ingresa_el_usuario_debe_completar_Nombre_Apellido_y_Clave");
                    }
                    else if ((lUsuario == "") &&
                        ((lApellido.trim() != "") ||
                            (lNombre.trim() != "") ||
                            (lClave.trim() != ""))) {
                        qcom_TratarError("error:Si_no_ingresa_el_usuario_no_debe_completar_Nombre_Apellido_y_Clave");
                    }
                    else if (lClave != lClave2)
                        qcom_TratarError("error:Las_claves_no_coinciden");
                    else {
                        $('#divCargando').addClass('show');

                        var dataValue = "{NombreInstancia:'" + lNombreInstancia +
                            "', pref: '" + lIdSes +
                            "', Apellido:'" + lApellido +
                            "', Nombre:'" + lNombre +
                            "', Usuario:'" + lUsuario +
                            "', Clave:'" + lClave + "'} ";

                        $.ajax({
                            type: "POST",
                            url: "webfrmInstancia.aspx/CrearNuevaInstancia",
                            data: dataValue,
                            contentType: 'application/json; charset=utf-8',
                            dataType: 'json',
                            error: function (XMLHttpRequest, textStatus, errorThrown) {
                                qcom_Alerta(errorThrown, 'danger', null);
                                $('#divCargando').removeClass('show');
                            },
                            success: function (result) {
                                //alert("We returned: " + result.d);
                                $('#divCargando').removeClass('show');
                                if (result.d == "OK") {
                                    qcom_MensajeExito("Instancia_Generada");
                                }
                                else {
                                    qcom_TratarError(result.d);
                                }
                            }

                        });
                    }
                }
            })
        </script>
    </form>
</body>
</html>
