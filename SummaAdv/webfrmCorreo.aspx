<%@ Page validateRequest="false" Language="C#" AutoEventWireup="true" CodeBehind="webfrmCorreo.aspx.cs" Inherits="SummaWeb.webfrmCorreo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <link href="css/structure/infragistics.ui.chart.css?v=2.10.82" rel="stylesheet" />
    <link href="css/qbasico.css?v=3.34.00" rel="stylesheet" />

    <script src="Script/infragistics.core.js?v=2"></script>
    <script src="Script/infragistics.lob.js?v=2"></script>
    <script src="Script/infragistics.dv.js?v=2"></script>
    <script src="Script/download.min.js?v=2"></script>

    <script src="Script/Recursos/infragistics-<%=qcultura%>.js?v=2"></script>
    <script src="Script/Recursos/qinfragistics.ui.regional-<%=qcultura%>.js?v=2"></script>

    <%-- Estos son los includes para desarrollo versionado--%>
    <script type="text/javascript" src="<%=qtipoversion%>/qvariables<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qdatos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qlupaadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qlupasegadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/quploadadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qalertas<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qeventos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qpopup<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qgrillas<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qatributosgenerales<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qgraficos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qlistaadjuntos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qbasico<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qgrillaspivot<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qindicadores<%=qextensionversion%>.js?v=<%=qversion %>"></script>

    <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>


</head>
<body>
    <form id="form1" runat="server">
        <div id="divCargando"></div>
        <div id="divAlertas" class="container-fluid"></div>
        <div id="divMensajeExito"></div>
        <div class="container" style="width: 100%; padding: 0px">
            <div class="modal-content">
                <div class="modal-body btn-primary" style="background-color:#424242" id="divGrillaMail" tabindex="0">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="form-group col-sm-1 quasar-box">
                                <label for='ctrDestinatarios' id='lblctrDestinatarios'>Para</label><br>
                            </div>
                            <div id="divctrDestinatarios" class="form-group col-sm-11 quasar-box">
                                <input id='ctrDestinatarios' value='' />
                            </div>
                        </div>
                        <div class="row" style="display:none">
                            <div class="form-group col-sm-1 quasar-box">
                                <label for='ctrDestinatariosCopia' id='lblctrDestinatariosCopia'>CC</label><br>
                            </div>
                            <div id="divctrDestinatariosCopia" class="form-group col-sm-5 quasar-box">
                                <input id='ctrDestinatariosCopia' value='' />
                            </div>
                            <div class="form-group col-sm-1 quasar-box">
                                <label for='ctrDestinatariosCopiaOculta' id='lblctrDestinatariosCopiaOculta'>CCO</label><br>
                            </div>
                            <div id="divctrDestinatariosCopiaOculta" class="form-group col-sm-5 quasar-box">
                                <input id='ctrDestinatariosCopiaOculta' value='' />
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-sm-1 quasar-box">
                                <label for='ctrAsunto' id='lblctrAsunto'>Asunto</label><br>
                            </div>
                            <div id="divctrAsunto" class="form-group col-sm-11 quasar-box">
                                <input id='ctrAsunto' value='' />
                            </div>
                        </div>
                        <div class="row">
                            <div id="divctrCuerpo" class="form-group col-sm-12 quasar-box">
                                <div id="ctrCuerpo"></div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-sm-12 quasar-box" style="text-align: right">
                                <button id="btnCancelar" type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                                <button id="btnEnviar" type="button" class="btn btn-primary" data-dismiss="modal">Enviar</button>
                            </div>
                        </div>
                        <div class="row">
                            <div id="divlstadjAdjuntos" class="form-group col-sm-12 quasar-box">
                                <label for= 'lstadjAdjuntos' id='lbllstadjAdjuntos' class="labelGrilla">Adjuntos  <a href="Nada">[<i class="fa fa-paperclip"></i> Agregar Archivo]</a></label>
                                <input id='lstadjAdjuntos_F' type='file' class='upload' style='display: none' accept='.'/><br/>
                                <div id="lstadjAdjuntos" class="divListaAdjunto"></div>
                                <div class="modal fade" id="divlstadjAdjuntos_modal" role="dialog">
                                    <div class="modal-dialog modal-lg" style="max-height:100%">
                                        <div class="modal-content">
                                            <div id="lstadjAdjuntos_headerModal" class="modal-header btn-primary">
                                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                                                <h6 id="lstadjAdjuntos_tituloModal" class="modal-title">Imagen</h6>
                                            </div>
                                            <div class="modal-body divImagenAdjModal" id="lstadjAdjuntos_ModalImagen" style="text-align:center"></div>
                                        </div>
                                    </div>
                                </div> 
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    <script type='text/javascript'>$('#divCargando').addClass('show');</script>
    <script type='text/javascript'>

        var lfrmPadre = $(window)[0].parent;
        var gFormulario = new qcom_formulario("EnumCorreoAction", "MiscelaneosExchange.CorreoActionExchange", "MiscelaneosExchange", "MiscelaneosCommon.CorreoDS", "MiscelaneosCommon", "", "", "Enviar Correo", false, false, true, true, true, "", "", "", "", "", "", "", "");
        //var gConfiguracion = new qcom_configuracion(1, 1, "MX", "PES", "", "", 0, 0, "", "", "", "frmMiscEnviarCorreo", "CCG", "ConStrStandard");
        var gConfiguracion = lfrmPadre.gConfiguracion; 
        
        var gFechaBlur = false;
        $.ig.regional.defaults.dateTimePattern = "dd-MM-yyyy";
        $.ig.regional.defaults.numericDecimalSeparator = '.';
        $.ig.regional.defaults.numericGroupSeparator = ',';
        gVariables["var_Auxiliar1"] = "";
        gVariables["var_Auxiliar2"] = "";
        gVariables["var_Auxiliar3"] = "";
        gTablasPlanas["0"] = 'Principal';
        gPrimerCtr = "ctrDestinatarios";
        var gCampoCodigoNuevo = "";
        $(document).ready(function () {
            //$.ig.util.language = "es";

            $("#lblctrDestinatarios")[0].innerText = qrecMailPara;
            $("#lblctrDestinatariosCopia")[0].innerText = qrecMailCC;
            $("#lblctrDestinatariosCopiaOculta")[0].innerText = qrecMailCCO;
            $("#lblctrAsunto")[0].innerText = qrecMailAsunto;
            $("#lbllstadjAdjuntos")[0].innerHTML = qrecMailAdjunto + "<a href='Nada'> [<i class='fa fa-paperclip'></i> " + qrecMailAdjuntar + "]</a>";

            $("#btnEnviar")[0].innerText = qrecMailEnviar;
            $("#btnCancelar")[0].innerText = qrecCancelar;

            gEventos['btnEnviar_Click'] = new qevt_evento();
            gEventos['btnEnviar_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
            gEventos['btnEnviar_Click'].Acciones.push(new qevt_accion('1', 'A', btnEnviar_Click_10000, ''));
            gEventos['btnEnviar_Click'].Acciones.push(new qevt_accion('2', 'A', btnEnviar_Click_20000, ''));
            gEventos['btnEnviar_Click'].Acciones.push(new qevt_accion('3', 'A', btnEnviar_Click_30000, ''));

            $("#ctrDestinatarios").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                    placeHolder: '',
                    value: ''
                });

            $("#ctrDestinatariosCopia").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                    placeHolder: '',
                    value: ''
                });

            $("#ctrDestinatariosCopiaOculta").igTextEditor(
                {
                    width: "98%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                    placeHolder: '',
                    value: ''
                });

            $("#ctrAsunto").igTextEditor(
                {
                    width: "99%",
                    height: 21,
                    disabled: false,
                    maxLength: 32767,
                    buttonType: "clear",
                    textMode: 'text',
                    placeHolder: '',
                    value: ''
                });

            $("#ctrCuerpo").igHtmlEditor(
                {
                    height: 250,
                    width: "99%",
                    showCopyPasteToolbar: true,
                    showFormattingToolbar: true,
                    showInsertObjectToolbar: false,
                    showTextToolbar: true,
                    toolbarSettings: [
                        {
                            name: "textToolbar",
                            isExpanded: true
                        },
                        /*{
                            name: "insertObjectToolbar",
                            isExpanded: false
                        },*/
                        {
                            name: "formattingToolbar",
                            isExpanded: true
                        },
                        {
                            name: "copyPasteToolbar",
                            isExpanded: false
                        },

                    ]
                });
            //Oculto los controles de la barrita de abajo del HTML Editor
            $(".ui-igbutton-viewsource").hide();
            $("#ctrCuerpo_domPathToolbar").hide();

            gListasAdjuntosAux.push("lstadjAdjuntos");
            gListasAdjuntos["lstadjAdjuntos"] = { Tabla: "Adjuntos", NombreControl: "lstadjAdjuntos", Visible: true, VisibleXPais: true, BorraArchivos: true, MuestraDescripcion: true, PermiteDescargar: true, CantidadMaxima: 0, TamanioMaximo: 0, UltId: 0 };
            $('#lbllstadjAdjuntos').delegate("a", "click", function (e) {
                if (qlstadj_VerifCantPermitida('lstadjAdjuntos'))
                    $('#lstadjAdjuntos_F').click();
                e.stopPropagation();
                e.preventDefault();
            });
            $('#lstadjAdjuntos_F').on('change', function () {
                QUpLoadAdv_UpLoadArchivoLista("lstadjAdjuntos", null);
            });

            $(document).delegate("#btnEnviar", "click", function (evt) {
                evt.preventDefault();
                evt.stopPropagation();
                qevt_AgregarEventoaTmp('btnEnviar_Click', null, true);
            });

            $(document).delegate("#btnCancelar", "click", function (evt) {
                evt.preventDefault();
                evt.stopPropagation();
                window.parent.qevt_EjecutarSiguiente();
                window.parent.qpopup_CerrarFormCorreo();
                
            });

            

            function btnEnviar_Click_10000() {
                qcom_ControlesaTablasPlanas();
                gEntidad["Principal"][0]["Cuerpo"] = btoa(gEntidad["Principal"][0]["Cuerpo"]);
                qcom_EjecutarAccion('Enviar', false, false, '', null, null, '', '', '', false, false, false);

            }
            function btnEnviar_Click_20000() {
                
                qcom_Alerta(qrecMailEnviado, 'info', 1);
            }
            function btnEnviar_Click_30000() {

                window.parent.qpopup_CerrarFormCorreo();
            }

            

            function qcom_ObtenerEstructuraEntidad_CallBack() {
                //qatrib_PrepararEspec();
                gControles["Principal"][0]["Destinatarios"] = new qcom_control($("#ctrDestinatarios"), 1, 1, '', true, true, true, "ctrDestinatarios", false, "", true, 0, "", "");
                gControles["Principal"][0]["DestinatariosCopia"] = new qcom_control($("#ctrDestinatariosCopia"), 1, 1, '', true, true, true, "ctrDestinatariosCopia", false, "", true, 0, "", "");
                gControles["Principal"][0]["DestinatariosCopiaOculta"] = new qcom_control($("#ctrDestinatariosCopiaOculta"), 1, 1, '', true, true, true, "ctrDestinatariosCopiaOculta", false, "", true, 0, "", "");
                gControles["Principal"][0]["Asunto"] = new qcom_control($("#ctrAsunto"), 1, 1, '', true, true, true, "ctrAsunto", false, "", true, 0, "", "");
                gControles["Principal"][0]["Cuerpo"] = new qcom_control($("#ctrCuerpo"), 14, 1, '', true, true, true, "ctrCuerpo", false, "", true, 0, "", "");

                $.each(gListasAdjuntosAux, function (lClave, lValor) {
                    var lNombreTabla = gListasAdjuntos[lValor].Tabla;
                    gEntidad[lNombreTabla].shift();
                    gEntidadAux[lNombreTabla].shift();
                    gEntidadAyuda[lNombreTabla].shift();
                });
                qevt_InicializarForm(true, true, true);
                CompletarFrm(mfuncCliente, /*pNombreGrilla,*/ mfuncClteTablasaEnviar, mfuncClteEsEspec);
            }
            qcom_ObtenerEstructuraEntidad(qcom_ObtenerEstructuraEntidad_CallBack);
            function EsteError(msg) { alert(msg); }

            function CompletarFrm(pNombreAccion, /*pNombreGrilla,*/ pTablasAEnviar, pEsEspecializada) {
                $('#divCargando').addClass('show');
                var lfrmPadre = $(window)[0].parent;
                /*Cuando se invoque desde una grilla completar Nombre de tabla en parametros, y tomar cdófigo fuente desde Ejecutar Accion en grilla*/
                lfrmPadre.qcom_ControlesaTablasPlanas();
                var ldataset = lfrmPadre.qcom_CargarTablasAEnviar(pTablasAEnviar, lfrmPadre.gEntidad);
                var lIdSes = sessionStorage.getItem("idses");
                var lUrl = "AjaxHandler/AcCorreo.ashx?Tipo=O";
                var lData = {
                    pDsEntidad: ldataset, pDllEventos: lfrmPadre.gFormulario.getDLLEventos(), pClaseEventos: lfrmPadre.gFormulario.getClaseEventos(),
                    pDllCommon: lfrmPadre.gFormulario.getDLLCommon(), pClaseCommon: lfrmPadre.gFormulario.getClaseCommon(),
                    pDllEventosEsp: lfrmPadre.gFormulario.getDLLEventosEsp(), pClaseEventosEsp: lfrmPadre.gFormulario.getClaseEventosEsp(),
                    pDllCommonEsp: lfrmPadre.gFormulario.getDLLCommonEsp(), pClaseCommonEsp: lfrmPadre.gFormulario.getClaseCommonEsp(),
                    pTieneDSEsp: lfrmPadre.gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: lfrmPadre.gTieneGrillasAutoForm,
                    pNombreAccion: pNombreAccion, pFormulario: lfrmPadre.gConfiguracion.getFormulario(),
                    pIdSes: lIdSes, pCodigoConsulta: ''
                };
                $.ajax({
                    type: "POST",
                    url: lfrmPadre.gConfiguracion.getSitio() + lUrl,
                    data: lData,
                    dataType: "json"
                })
                    .done(function (msg) {
                        $('#divCargando').removeClass('show');
                        //Proceso el mensajes de consulta
                        var lEsMsgError = (msg.e != undefined);
                        if (!lEsMsgError) {
                            gEntidad = qcom_CargarTablasARefrescar('', msg, gEntidad);
                            qcom_CargarControlesFormulario('', false, true);
                            lfrmPadre.qevt_EjecutarSiguiente();
                        }
                        else
                            lfrmPadre.qcom_TratarError(msg.e);
                    })
                    .fail(function (xhr, ajaxOptions, thrownError) {
                        lfrmPadre.qevt_VaciarEventosTmp();
                        $('#divCargando').removeClass('show');
                        //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                        lfrmPadre.qcom_Alerta(thrownError, 'danger', null);
                    });
            }
        });

    </script>

</form>
</body>

</html>
