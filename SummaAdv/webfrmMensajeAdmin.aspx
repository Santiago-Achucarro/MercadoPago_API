<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmMensajeAdmin.aspx.cs" Inherits="SummaWeb.webfrmMensajeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>SummAdvance</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
  <script src="Script/modernizr-2.6.2.js"></script>
  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
  <script src="Script/bootstrap.min.js"></script>

  <link rel="stylesheet" href="css/fontawesome/css/all.min.css?v=2.10.82" />
  <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />      
  <link href="css/themes/infragistics/infragistics.theme.css?v=2.10.82" rel="stylesheet" />
  <link href="css/structure/infragistics.css?v=2.10.82" rel="stylesheet" />
  <link href="css/qbasico.css?v=3.34.00" rel="stylesheet"/>
  
    <script src="Script/Recursos/infragistics-<%=qcultura%>.js?v=2"></script>
  <%--<script src="Script/Recursos/datepicker-<%=qcultura%>.js"></script>--%>
  <script src="Script/infragistics.core.js?v=2"></script>
  <script src="Script/infragistics.lob.js?v=2"></script>

    <%-- Estos son los includes para desarrollo versionado--%>
  <script type="text/javascript" src="<%=qtipoversion%>/qvariables<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qalertas<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qbasico<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qeventos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="<%=qtipoversion%>/qpopup<%=qextensionversion%>.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>
 
</head>

<body>
    <form id="form1" runat="server">
        <div id="divCargando"></div>
        <div id="divPrincipal" class="container-fluid divPrincipalOculto">

            <div id="divMenu" style="border-bottom-style: solid; border-bottom-color: #428bca; border-bottom-width: thin; padding-right: 10px">
                <div class="btn-group btn-group-md" style="padding: 5px">
                    <button type="button" id="btnNuevo" class="btn btn-primary" data-toggle="tooltip" data-placement="top" title="Nuevo"><span class="glyphicon glyphicon-file"></span></button>
                    <button type="button" id="btnGuardar" class="btn btn-primary" data-toggle="tooltip" data-placement="top" title="Guardar"><span class="glyphicon glyphicon-floppy-disk"></span></button>
                    <button type="button" id="btnPostear" class="btn btn-primary" data-toggle="tooltip" data-placement="top" title="Postear"><span class="glyphicon glyphicon-floppy-saved"></span></button>
                    <button type="button" id="btnEliminar" class="btn btn-primary" data-toggle="tooltip" data-placement="top" title="Eliminar"><span class="glyphicon glyphicon-floppy-remove"></span></button>
                    <button type="button" id="btnImprimir" class="btn btn-primary" data-toggle="tooltip" data-placement="top" title="Imprimir"><span class="glyphicon glyphicon-print"></span></button>
                </div>

                <div class="btn-group">
                </div>

            </div>
            <div id="divAlertas" class="container-fluid">
            </div>
            <div id="divMensajeExito">
            </div>
            <div class="container-fluid">
                <div class="row">
                    <div id="divctrFechaDesde" class="form-group col-sm-3 quasar-box">
                        <label for='ctrFechaDesde' id='lblctrFechaDesde'>Fecha desde</label>
                        <input id='ctrFechaDesde' value='' />
                    </div>
                    <div id="divctrFechaHasta" class="form-group col-sm-3 quasar-box">
                        <label for='ctrFechaHasta' id='lblctrFechaHasta'>Fecha Hasta</label>
                        <input id='ctrFechaHasta' value='' />
                    </div>
                    <div id="" class="hidden-xs col-sm-3 quasar-box"></div>
                    <div id="" class="hidden-xs col-sm-3 quasar-box"></div>
                </div>
                <div class="row">
                    <div id="divctrMensaje" class="form-group col-sm-12 quasar-box">
                        <label for='ctrMensaje' id='lblctrMensaje'>Mensaje</label>
                        <textarea id='ctrMensaje' value=''></textarea>
                    </div>
               </div>
               <div class="row"></div>
            </div>
            <br/>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <script type='text/javascript'>$('#divCargando').addClass('show');</script>
        <script type='text/javascript'>
            var gFechaBlur = false;
            var gCampoCodigoNuevo = "";
            $(function () {
                $(window).resize(function () { var laltoPopup = document.body.clientHeight - 43; $('.popupbody').css('max-height', laltoPopup); });
                document.onkeydown = qbas_keydown;
                $('#btnNuevo').addClass('hidden');
                $('#btnGuardar').addClass('hidden');
                $('#btnPostear').click(function () {
                    EnviarMensaje();
                });
                $('#btnEliminar').addClass('hidden');
                $('#btnImprimir').addClass('hidden');

                $("#ctrFechaDesde").igDatePicker(
                {
                    width: "99%",
                    height: 21,
                    dateInputFormat: "dd/MM/yyyy HH:mm",
                    dateDisplayFormat: "dd/MM/yyyy HH:mm",
                    locale: "es",
                    disabled: false,
                    value: new Date(),
                    dataMode: "dateTime",
                    buttonType: "dropdown, clear",
                    textChanged: function (evt, ui) {
                        if (!gFechaBlur)
                            qcom_DeshabilitoGuardar();
                        gFechaBlur = false;
                    },
                    focus: function (evt) {
                        gFechaBlur = false;
                    },
                    itemSelected: function (ui) {
                        qcom_DeshabilitoGuardar();
                    },
                    blur: function (evt) {
                        qcom_HabilitoGuardar();
                        gFechaBlur = true;
                    },
                    datepickerOptions: {
                        minDate: null,
                        maxDate: null,
                    },
                });
                $("#ctrFechaHasta").igDatePicker(
                {
                    width: "99%",
                    height: 21,
                    dateInputFormat: "dd/MM/yyyy HH:mm",
                    dateDisplayFormat: "dd/MM/yyyy HH:mm",
                    locale: "es",
                    disabled: false,
                    value: new Date(),
                    dataMode: "dateTime",
                    buttonType: "dropdown, clear",
                    textChanged: function (evt, ui) {
                        if (!gFechaBlur)
                            qcom_DeshabilitoGuardar();
                        gFechaBlur = false;
                    },
                    focus: function (evt) {
                        gFechaBlur = false;
                    },
                    itemSelected: function (ui) {
                        qcom_DeshabilitoGuardar();
                    },
                    blur: function (evt) {
                        qcom_HabilitoGuardar();
                        gFechaBlur = true;
                    },
                    datepickerOptions: {
                        minDate: null,
                        maxDate: null,
                    },
                });
                $("#ctrMensaje").igTextEditor(
                {
                    width: "99%",
                    height: 120,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'multiline',
                    placeHolder: '',
                    value: '',
                    textChanged: function (evt, ui) {
                        qcom_DeshabilitoGuardarxInputs();
                    },
                    valueChanged: function (evt, ui) {
                        gTieneSinGuardar = true;
                    },
                    blur: function (evt) {
                        qcom_HabilitoGuardar();
                    },
                });

                function EnviarMensaje() {
                    var lIdSes = sessionStorage.getItem("idses");
                    //(string pIdSes, string Mensaje_Id, DateTime pFechaDesde, DateTime pFechaHasta)
                    var lFechaD = $("#ctrFechaDesde").igDatePicker("value");
                    var lFechaH = $("#ctrFechaHasta").igDatePicker("value");
                    //var lFechaDUTC = new Date(lFechaD.getUTCFullYear(), lFechaD.getUTCMonth(), lFechaD.getUTCDate(),
                    //    lFechaD.getUTCHours(), lFechaD.getUTCMinutes(), lFechaD.getUTCSeconds()); 
                    //var lFechaHUTC = new Date(lFechaH.getUTCFullYear(), lFechaH.getUTCMonth(), lFechaH.getUTCDate(),
                    //    lFechaH.getUTCHours(), lFechaH.getUTCMinutes(), lFechaH.getUTCSeconds()); 

                    var lMensaje = $("#ctrMensaje").igTextEditor()[0].value;
                    var lData = JSON.stringify({ 'pIdSes': lIdSes,  'pMensaje': lMensaje, 'pFechaDesde': lFechaD, 'pFechaHasta': lFechaH});
                    $.ajax({
                        type: "POST",                       
                        url: "webfrmMensajeAdmin.aspx/RegistrarMensajeAdmin",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        data: lData,
                    })
                    .done(function (data) {
                        if (!data.d.startsWith("error:")) {
                            qcom_MensajeExito('Operacion Exitosa');
                            qcom_Alerta(data.d, 'success', null);
                            $("#ctrFechaDesde").igDatePicker("value", new Date());
                            $("#ctrFechaHasta").igDatePicker("value", new Date());
                            $("#ctrMensaje").igTextEditor()[0].value = "";
                        }
                        else
                            qcom_TratarError(data.d);
                    })
                    .fail(function (xhr, ajaxOptions, thrownError) {
                        qcom_Alerta(xhr.responseText, 'danger', null);
                    });
                }


                $('#divCargando').removeClass('show');
                $('#divPrincipal').removeClass('divPrincipalOculto');


                $(window)[0].parent.qprin_AbrirSigForm();
            });</script>
    </form>
</body>
</html>
