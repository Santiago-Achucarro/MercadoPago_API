

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title>
	frmMiscEnviarCorreo
</title><meta charset="utf-8" /><meta name="viewport" content="width=device-width, initial-scale=1" />
  <script src="Script/modernizr-2.6.2.js"></script>
  <script src="Script/jquery-1.10.2.min.js"></script>
  <script src="Script/jquery-ui-1.12.0.min.js"></script>
  <script src="Script/bootstrap.min.js"></script>

  <link rel="stylesheet" href="css/fontawesome/css/all.min.css?v=2.10.82" /><link rel="stylesheet" href="css/basicContext.css?v=2.10.82" /><link rel="stylesheet" href="css/basicContext_dark.css?v=2.10.82" /><link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" /><link href="css/themes/infragistics/infragistics.theme.css?v=2.10.82" rel="stylesheet" /><link href="css/structure/infragistics.css?v=2.10.82" rel="stylesheet" /><link href="css/structure/infragistics.ui.chart.css?v=2.10.82" rel="stylesheet" /><link href="css/qbasico.css?v=2.10.82" rel="stylesheet" />
  
  <script src="Script/infragistics.core.js?v=2"></script>
  <script src="Script/infragistics.lob.js?v=2"></script>
  <script src="Script/infragistics.dv.js?v=2"></script>
  <script src="Script/download.min.js?v=2"></script>    

  <script src="Script/Recursos/infragistics-es.js?v=2"></script>
  <script src="Script/Recursos/qinfragistics.ui.regional-es.js?v=2"></script>

    
  <script type="text/javascript" src="ScriptDesa/qvariables.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qdatos.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qlupaadv.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qlupasegadv.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/quploadadv.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qalertas.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qcomunes.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qeventos.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qpopup.js?v=2.10.86"></script>
  <script type="text/javascript" src="ScriptDesa/qgrillas.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qatributosgenerales.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qgraficos.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qlistaadjuntos.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qbasico.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qgrillaspivot.js?v=2.10.86"></script>  
  <script type="text/javascript" src="ScriptDesa/qindicadores.js?v=2.10.86"></script>  
  <script type="text/javascript" src="Script/basicContext.min.js?v=2.10.86"></script>
  <script type="text/javascript" src="Script/html2canvas.min.js?v=2.10.86"></script>
    
    
  

    
  <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=2.10.86"></script>
 
    
    
</head>

<body>
    <form method="post" action="./webfrmBasico.aspx?frm=frmMiscEnviarCorreo&amp;pref=161134880" id="form1">
<div class="aspNetHidden">
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwUJNjMyNDQ0Mzk4ZGTNlPG1SNHLrqhtkAwMcyaT6q/bm95r/A6XzZiVsb9slw==" />
</div>

<script language='javascript' src='/Script/Recursos/qrecursos_es-MX.js' ></script>

<div class="aspNetHidden">

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="07B955B4" />
</div>
        <div id="divCargando"></div>
        <div id="divPrincipal" class="container-fluid divPrincipalOculto">

            <div id="divMenu" class="quasar-divMenu">
                <div class="btn-group btn-group-md" style="padding: 5px;">
                    <button type="button" id="btnNuevo" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-file"></span></button>
                    <button type="button" id="btnGuardar" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-disk"></span></button>
                    <button type="button" id="btnPostear" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-saved"></span></button>
                    <button type="button" id="btnEliminar" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-remove"></span></button>
                    
                </div>
                <div id="divbotonesrtp" class="btn-group btn-group-md" style="padding: 5px; display:none">
                    <button type="button" id="btnRptVer" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-desktop"></span></button>
                    <button type="button" id="btnRptImprimir" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-print"></span></button>
                    <button type="button" id="btnRptPdf" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-file-pdf"></span></button>
                    <button type="button" id="btnRptXls" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-file-excel"></span></button>
                </div>
                <div id="divbotonesrtp_xs" class="btn-group btn-group-md" style="padding-left: 0px; padding-right: 0px; display:none">
                      <button id="btnrptsel" type="button" class="btn btn-primary quasar-mobile" style="height:34px">
                      <span id="spanbtnrptsel" class="fas fa-file-pdf"></span><br/><span class="caret" style="display:initial"></span>
                      </button>
                      <button id="btnrptsel2" type="button" class="btn btn-primary quasar-mobile dropdown-toggle" data-toggle="dropdown" style="height:0px; width:0px; display:none"></button>                      
                      <ul id="ulbotonesrtp_xs" class="dropdown-menu" role="menu" style="min-width:30px; width:max-content; padding:2px; background-color: #424242;">
                      <li>
                          <div id="divlibotonesrtp_xs" class="btn-group">
                          </div>
                        </li>
                      </ul>
                </div>


                
                <div id="divMiscelaneos" class="btn-group btn-group-md" style="padding: 5px; float:right">
                    <button type="button" id="btnSolapas" tabindex="-1" class="btn quasar-btn-lstopciones" title="" onclick="qbas_MostrarSolapasMobile();" ><span class="fas fa-tasks"></span></button>
                    <button type="button" id="btnCopiar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-clipboard"></span></button>
                    <button type="button" id="btnPegar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom" style="display:none"><span class="fas fa-paste"></span></button>
                    <button type="button" id="btnFavorito" tabindex="-1" class="btn btn-primary quasar-btn-no-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-star"></span></button>
                    <button type="button" id="btnAyuda" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-question"></span></button>
                    <button id="btnMasOpciones" type="button" class="btn quasar-btn-lstopciones quasar-mobile dropdown-toggle"  data-toggle="dropdown"><span class="fas fa-ellipsis-h"></span></button>
                    <ul id="ulMasOpciones" class="dropdown-menu" role="menu" style="min-width: 30px; width: max-content; padding: 2px; background-color: #424242;">
                        <li>
                            <div id="divliMasOpciones" class="btn-group">
                            </div>
                        </li>
                    </ul>
                    <button type="button" id="btnCerrar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="far fa-times-circle"></span></button>
                </div>

                <div class="btn-group btn-group-md quasar-lupa-navegacion" style="padding: 5px; float:right">
                    <button type="button" id="btnLupaPrim" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-backward"></span></button>
                    <button type="button" id="btnLupaAnt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-backward"></span></button>
                    <button type="button" id="btnLupaSig" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-forward"></span></button>
                    <button type="button" id="btnLupaUlt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-forward"></span></button>
                </div>

              <div class="btn-group" style="left: 5px; top: -1px;">
                    
	          </div>	
                
            
            </div>    
            <div id="divAlertas" class="container-fluid">
                
            </div>
            <div id="divMensajeExito">
            </div>
            <div class="container-fluid" style="padding-top: 50px;" >
                <div class="row"><div id="divctrDestinatarios" class="form-group col-sm-12 quasar-box"><label for= 'ctrDestinatarios' id = 'lblctrDestinatarios'>Para</label>
<input id='ctrDestinatarios' value=''/></div>
</div>
<div class="row"><div id="divctrDestinatariosCopia" class="form-group col-sm-6 quasar-box"><label for= 'ctrDestinatariosCopia' id = 'lblctrDestinatariosCopia'>CC</label>
<input id='ctrDestinatariosCopia' value=''/></div>
<div id="divctrDestinatariosCopiaOculta" class="form-group col-sm-6 quasar-box"><label for= 'ctrDestinatariosCopiaOculta' id = 'lblctrDestinatariosCopiaOculta'>CCO</label>
<input id='ctrDestinatariosCopiaOculta' value=''/></div>
</div>
<div class="row"><div id="divctrAsunto" class="form-group col-sm-12 quasar-box"><label for= 'ctrAsunto' id = 'lblctrAsunto'>Asunto</label>
<input id='ctrAsunto' value=''/></div>
</div>
<div class="row"><div id="divctrCuerpo" class="form-group col-sm-12 quasar-box"><label for= 'ctrCuerpo' id = 'lblctrCuerpo'>Cuerpo</label>
<textarea id='ctrCuerpo' value=''></textarea></div>
</div>
<div class="row"><div id="divlstadjAdjuntos" class="form-group col-sm-12 quasar-box"><label for= 'lstadjAdjuntos'></label><br/>
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
<div class="row"><div id="" class="hidden-xs col-sm-2 quasar-box"></div>
<div id="" class="hidden-xs col-sm-2 quasar-box"></div>
<div id="" class="hidden-xs col-sm-2 quasar-box"></div>
<div id="" class="hidden-xs col-sm-2 quasar-box"></div>
<div id="" class="hidden-xs col-sm-2 quasar-box"></div>
<div id="divDisenioBoton1" class="form-group col-sm-2 quasar-box"><label for= 'DisenioBoton1' id = 'lblDisenioBoton1'></label><br/>
<button type='button' id="DisenioBoton1" class='btn quasar-btn' style="height:23px;width:75px;">DisenioBoton1</button>
</div>
</div>
<div class="row"></div>
<div class="row"></div>
<div class="row"></div>
<div class="row"></div>
<div class="row"></div>
<div class="row"></div>
</div>
            <br/>

    
        </div>
        
        
        <div class="container">            
          <div class="modal fade" id="divModalLupa" role="dialog">
            <div id="divModalLupaDlg" class="modal-dialog" style="max-width:80%; max-height:80%>
                  <!-- Modal content-->
              <div class="modal-content">
                <div id="headerModalLupa" class="modal-header btn-primary">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h6 id="tituloModalLupa" class="modal-title">Modal Header</h6>
        </div>
                        
                <div class="modal-body btn-primary" id="divGrillaLupa" tabindex="0">
        </div>
                        
        </div>    
            </div>
          </div>
        </div>
        <div class="container">            
          <div class="modal fade" id="divModalLupaSeg" role="dialog">
            <div id="divModalLupaSegDlg" class="modal-dialog" style="max-width:80%; max-height:80%">
                  <!-- Modal content-->
              <div class="modal-content">
                <div id="headerModalLupaSeg" class="modal-header btn-primary">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h6 id="tituloModalLupaSeg" class="modal-title">Modal Header</h6>
                </div>
                <div class="modal-body btn-primary" id="divGrillaLupaSeg">
                </div>
                        
              </div>      
            </div>
          </div>
        </div>
        <div class="container">            
          <div class="modal fade" id="divModalUpLoad" role="dialog">
            <div class="modal-dialog">
              <div class="modal-content">
                        
                <div class="modal-body btn-primary" id="divUpLoad">
                </div>
                <div id="footerModalUpLoad" class="modal-footer btn-primary">
                  <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                </div>
              </div>      
            </div>
          </div>
        </div>
        <div class="container quasar-divFrame-form">
            <div class="modal fade" id="divModalForm" role="dialog">
                <div class="modal-dialog modal-lg" style="width: 95%">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div id="headerModalForm" class="modal-header btn-primary quasar-iframe-form-modal">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h6 id="tituloModalForm" class="modal-title">Modal Header</h6>
                        </div>
                        <div id="divformmodalbody" class="modal-body quasar-iframe-form-modal">
                          
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">            
          <div class="modal fade" id="divModalDownload" role="dialog">
            <div class="modal-dialog modal-sm">
              <div class="modal-content">
                <div id="headerModalDownload" class="modal-header btn-primary">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h5 id="tituloModalDownload" class="modal-title">Descargar Archivos</h5>
                </div>

                <div class="modal-body quasar-content-descarga" id="divDownLoad"">
                </div>
                <!--div id="footerModalDownLoad" class="modal-footer btn-primary">
                  <button type="button" class="btn btn-danger" data-dismiss="modal">Aceptar</button>
                </div-->
              </div>      
            </div>
          </div>
        </div>
        <div class="container">
            <div class="modal" id="divModalMail" role="dialog">
                <div id="divModalMailDlg" class="modal-dialog" style="max-width: 80%; max-height: 80%">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div id="headerModalMail" class="modal-header btn-primary">
                            <h6 id="tituloModalMail" class="modal-title">Enviar Correo</h6>
                        </div>
                        <div class="modal-body btn-primary" id="divGrillaMail" tabindex="0">
                        </div>
                        <div class="modal-footer btn-primary">
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Enviar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
        <div class="modal fade" id="divOpciones" role="dialog">
            <div class="modal-dialog" style="width: fit-content; min-width: 200px;">
                <div class="modal-content">
                    <div class="modal-body btn-info" style="padding: 2px; background-color: #585858; min-width: 110px;">
                        <div id="lstOpciones" class="btn-group-vertical" style="width:100%">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer id="divFooterFrm" class="quasar-footer-mobile">
                <div class="btn-group btn-group-md" style="margin:auto;">
                    <button type="button" id="btnLupaPrimMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-backward"></span></button>
                    <button type="button" id="btnLupaAntMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-backward"></span></button>
                    <button type="button" id="btnLupaSigMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-forward"></span></button>
                    <button type="button" id="btnLupaUltMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-forward"></span></button>
                </div>

        </footer>


            
        
    
<script type='text/javascript'>$('#divCargando').addClass('show');</script>
<script type='text/javascript'>var gFormulario = new qcom_formulario("EnumCorreoAction", "MiscelaneosExchange.CorreoActionExchange", "MiscelaneosExchange", "MiscelaneosCommon.CorreoDS", "MiscelaneosCommon", "ActivoFijoFeEventos.ActivoFijoOtros", "", "Enviar Correo", false, false, true, true, true, "", "", "", "", "", "", "", "");
    var gConfiguracion = new qcom_configuracion(1, 1, "MX", "PES", "", "", 0, 0, "", "", "", "frmMiscEnviarCorreo", "CCG", "ConStrStandard");
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
    $(function () {
        $.ig.util.language = "es";
        qbas_InicializarToolTips(document.body.clientWidth);
        qbas_InicializarTextosGrillas();

        $('#divModalLupa').on('shown.bs.modal', function (event) {
            $('#divModalLupa').attr("Abierto", "true");
        });
        $('#divModalLupa').on('hidden.bs.modal', function (event) {
            var lattr = $('#divModalLupa').attr("Abierto");
            if (lattr == "true") {
                qevt_VaciarEventosTmp();
            }
            var lControlFoco = gControles[QLupaAdv_TablaFE][0][QLupaAdv_CampoCodigo].getControl();
            lControlFoco.focus();
        });
        $('#divModalLupaSeg').on('shown.bs.modal', function (event) {
            $('#divModalLupaSeg').attr("Abierto", "true");
        });
        $('#divModalLupaSeg').on('hidden.bs.modal', function (event) {
            var lattr = $('#divModalLupaSeg').attr("Abierto");
            if (lattr == "true") {
                qevt_VaciarEventosTmp();
            }
        });
        gBtnesVis = 1;
        qbas_InicBotonesRptRspnsv(document.body.clientWidth);
        $('#btnNuevo').addClass('hidden');
        $('#btnGuardar').click(function () {
            qcom_GuardarEntidad(false, guardarEntidad);
        });
        $('#btnPostear').addClass('hidden');
        $('#btnEliminar').addClass('hidden');
        $('#btnRptVer').addClass('hidden');
        $('#btnRptImprimir').addClass('hidden');
        $('#btnRptPdf').addClass('hidden');
        $('#btnRptXls').addClass('hidden');
        $('#btnrptsel').click(function () { qbas_EjecutarBtnRrpSelec(); });
        $('#btnFavorito').click(function () {
            qcom_CambiarEstadoFavorito('');
        });
        $('#btnAyuda').addClass('hidden');
        $('#btnCerrar').click(function () {
            qcom_CerrarFormActual();
        });
        $('#btnCopiar').addClass('hidden');
        $('#btnPegar').click(function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
            qevt_PegarFormulario();
        });
        qcom_VerifPuedePegarFrm();
        $('#btnLupaPrim').addClass('hidden');
        $('#btnLupaAnt').addClass('hidden');
        $('#btnLupaSig').addClass('hidden');
        $('#btnLupaUlt').addClass('hidden');
        $('#btnLupaPrimMbl').addClass('hidden');
        $('#btnLupaAntMbl').addClass('hidden');
        $('#btnLupaSigMbl').addClass('hidden');
        $('#btnLupaUltMbl').addClass('hidden');

        $(window).resize(function () {
            var laltoPopup = document.body.clientHeight - 43;
            var lanchoPopup = document.body.clientWidth;
            $('.popupbody').css('max-height', laltoPopup);
            qgrillas_CambiarModoEdicion();
            qcomunes_PartesSegmentosUbicacion(lanchoPopup);
            qbas_BotonesOpcRspnsv(lanchoPopup);
            if (gBtnesVis > 5) {
                qbas_BotonesRptRspnsv(lanchoPopup);
            }
        });
        if (document.body.clientWidth < 767) {
            qcomunes_PartesSegmentosUbicacion(document.body.clientWidth);
            qbas_BotonesOpcRspnsv(document.body.clientWidth);
        }
        document.onkeydown = qbas_keydown; if (gBtnesVis > 5)
            document.oncontextmenu = qbas_oncontextmenu;


        gEventos['DisenioBoton1_Click'] = new qevt_evento();
        gEventos['DisenioBoton1_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
        gEventos['DisenioBoton1_Click'].Acciones.push(new qevt_accion('1', 'A', DisenioBoton1_Click_10000, ''));

        $("#ctrDestinatarios").igTextEditor(
            {
                width: "99%",
                height: 21,
                disabled: false,
                maxLength: 32767,
                buttonType: "clear",
                textMode: 'text',
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
        $("#ctrDestinatariosCopia").igTextEditor(
            {
                width: "99%",
                height: 21,
                disabled: false,
                maxLength: 32767,
                buttonType: "clear",
                textMode: 'text',
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
        $("#ctrDestinatariosCopiaOculta").igTextEditor(
            {
                width: "99%",
                height: 21,
                disabled: false,
                maxLength: 32767,
                buttonType: "clear",
                textMode: 'text',
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
        $("#ctrAsunto").igTextEditor(
            {
                width: "99%",
                height: 21,
                disabled: false,
                maxLength: 32767,
                buttonType: "clear",
                textMode: 'text',
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
        $("#ctrCuerpo").igTextEditor(
            {
                width: "99%",
                height: 38,
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

        $(document).delegate("#DisenioBoton1", "click", function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
            qevt_AgregarEventoaTmp('DisenioBoton1_Click', null, true);
        });
        function DisenioBoton1_Click_10000() {
            qcom_ControlesaTablasPlanas();
            qcom_EjecutarAccion('Guardar', false, false, 'Operacion Exitosa', null, null, '', '', '', false, false);

        }

        function qcom_ObtenerEstructuraEntidad_CallBack() {
            qatrib_PrepararEspec();
            gControles["Principal"][0]["Destinatarios"] = new qcom_control($("#ctrDestinatarios"), 1, 1, '', true, true, true, "ctrDestinatarios", false, "", true, 0, "", "");
            gControles["Principal"][0]["DestinatariosCopia"] = new qcom_control($("#ctrDestinatariosCopia"), 1, 1, '', true, true, true, "ctrDestinatariosCopia", false, "", true, 0, "", "");
            gControles["Principal"][0]["DestinatariosCopiaOculta"] = new qcom_control($("#ctrDestinatariosCopiaOculta"), 1, 1, '', true, true, true, "ctrDestinatariosCopiaOculta", false, "", true, 0, "", "");
            gControles["Principal"][0]["Asunto"] = new qcom_control($("#ctrAsunto"), 1, 1, '', true, true, true, "ctrAsunto", false, "", true, 0, "", "");
            gControles["Principal"][0]["Cuerpo"] = new qcom_control($("#ctrCuerpo"), 1, 1, '', true, true, true, "ctrCuerpo", false, "", true, 0, "", "");

            qatrib_FinPrepararEspec();
            $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                var lNombreTabla = gGrillas[lGrilla].Tabla;
                gClones[lNombreTabla] = qcom_Clonar(gEntidad[lNombreTabla][0]);
                gEntidad[lNombreTabla].shift();
                gEntidadAux[lNombreTabla].shift();
                gEntidadAyuda[lNombreTabla].shift();
                if (gGrillas[lGrilla].EsArbol) {
                    gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                    gGrillas[lGrilla].Control.igTreeGrid("dataBind");
                }
                else {
                    gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
                    gGrillas[lGrilla].Control.igGrid("dataBind");
                }
            });
            $.each(gGraficosAux, function (lClave, lValor) {
                var lNombreTabla = gGraficos[lValor].Tabla;
                gClones[lNombreTabla] = qcom_Clonar(gEntidad[lNombreTabla][0]);
                gEntidad[lNombreTabla].shift();
                gEntidadAux[lNombreTabla].shift();
                gEntidadAyuda[lNombreTabla].shift();
                var lNombreControl = gGraficos[lValor].NombreControl;
                $("#divbarra" + lNombreControl).hide();
                $("#divctrcbo" + lNombreControl).hide();
            });
            $.each(gListasAdjuntosAux, function (lClave, lValor) {
                var lNombreTabla = gListasAdjuntos[lValor].Tabla;
                gEntidad[lNombreTabla].shift();
                gEntidadAux[lNombreTabla].shift();
                gEntidadAyuda[lNombreTabla].shift();
            });
            qevt_InicializarForm(true, true, true);
            var lesFavorito = $(window)[0].parent.qprin_EsFavorito(gConfiguracion.getFormulario());
            if (lesFavorito) qcom_CambiarEstadoFavorito('fav');


            $(window)[0].parent.qprin_AbrirSigForm();
        }
        qcom_ObtenerEstructuraEntidad(qcom_ObtenerEstructuraEntidad_CallBack);
        function EsteError(msg) { alert(msg); }

        qbas_InicializarMobile();
    });</script>
</form>
</body>
</html>
