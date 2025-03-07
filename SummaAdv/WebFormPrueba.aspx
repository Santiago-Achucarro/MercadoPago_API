<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>frmpruPaises
    </title>
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
    <link href="css/structure/infragistics.ui.chart.css?v=2.10.82" rel="stylesheet" />
    <link href="css/qbasico.css?v=3.20.00" rel="stylesheet" />

    <script src="Script/infragistics.core.js?v=2"></script>
    <script src="Script/infragistics.lob.js?v=2"></script>
    <script src="Script/infragistics.dv.js?v=2"></script>
    <script src="Script/download.min.js?v=2"></script>

    <script src="Script/Recursos/infragistics-es.js?v=2"></script>
    <script src="Script/Recursos/qinfragistics.ui.regional-es.js?v=2"></script>


    <script type="text/javascript" src="ScriptDesa/qvariables.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qdatos.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qlupaadv.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qlupasegadv.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/quploadadv.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qalertas.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qcomunes.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qeventos.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qpopup.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qgrillas.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qatributosgenerales.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qgraficos.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qlistaadjuntos.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qbasico.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qgrillaspivot.js?v=2.10.78"></script>
    <script type="text/javascript" src="ScriptDesa/qindicadores.js?v=2.10.78"></script>
    <script type="text/javascript" src="Script/basicContext.min.js?v=2.10.78"></script>




    <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=2.10.78"></script>



</head>

<body>
    <form method="post" action="./webfrmBasico.aspx?frm=frmpruPaises&amp;pref=113005517" id="form1">
        <div class="aspNetHidden">
            <input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="/wEPDwULLTIwMDE3NTk2NjhkZGdvxq5yHL9jm+vvvTQT28WkIHwR3MWzToRwIeB+qYtZ" />
        </div>

        <script language='javascript' src='/Script/Recursos/qrecursos_es-MX.js'></script>

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
                <div id="divbotonesrtp" class="btn-group btn-group-md" style="padding: 5px; display: none">
                    <button type="button" id="btnRptVer" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-desktop"></span></button>
                    <button type="button" id="btnRptImprimir" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-print"></span></button>
                    <button type="button" id="btnRptPdf" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-file-pdf"></span></button>
                    <button type="button" id="btnRptXls" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-file-excel"></span></button>
                </div>
                <div id="divbotonesrtp_xs" class="btn-group btn-group-md" style="padding-left: 0px; padding-right: 0px; display: none">
                    <button id="btnrptsel" type="button" class="btn btn-primary quasar-mobile" style="height: 34px">
                        <span id="spanbtnrptsel" class="fas fa-file-pdf"></span>
                        <br />
                        <span class="caret" style="display: initial"></span>
                    </button>
                    <button id="btnrptsel2" type="button" class="btn btn-primary quasar-mobile dropdown-toggle" data-toggle="dropdown" style="height: 0px; width: 0px; display: none"></button>
                    <ul id="ulbotonesrtp_xs" class="dropdown-menu" role="menu" style="min-width: 30px; width: max-content; padding: 2px; background-color: #424242;">
                        <li>
                            <div id="divlibotonesrtp_xs" class="btn-group">
                            </div>
                        </li>
                    </ul>
                </div>



                <div id="divMiscelaneos" class="btn-group btn-group-md" style="padding: 5px; float: right">
                    <button type="button" id="btnSolapas" tabindex="-1" class="btn quasar-btn-lstopciones" title="" onclick="qbas_MostrarSolapasMobile();"><span class="fas fa-tasks"></span></button>
                    <button type="button" id="btnCopiar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-clipboard"></span></button>
                    <button type="button" id="btnPegar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom" style="display: none"><span class="fas fa-paste"></span></button>
                    <button type="button" id="btnFavorito" tabindex="-1" class="btn btn-primary quasar-btn-no-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-star"></span></button>
                    <button type="button" id="btnAyuda" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="fas fa-question"></span></button>
                    <button id="btnMasOpciones" type="button" class="btn quasar-btn-lstopciones quasar-mobile dropdown-toggle" data-toggle="dropdown"><span class="fas fa-ellipsis-h"></span></button>
                    <ul id="ulMasOpciones" class="dropdown-menu" role="menu" style="min-width: 30px; width: max-content; padding: 2px; background-color: #424242;">
                        <li>
                            <div id="divliMasOpciones" class="btn-group">
                            </div>
                        </li>
                    </ul>
                    <button type="button" id="btnCerrar" tabindex="-1" class="btn btn-primary quasar-btn-favorito" data-toggle="tooltip" data-placement="bottom"><span class="far fa-times-circle"></span></button>
                </div>

                <div class="btn-group btn-group-md quasar-lupa-navegacion" style="padding: 5px; float: right">
                    <button type="button" id="btnLupaPrim" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-backward"></span></button>
                    <button type="button" id="btnLupaAnt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-backward"></span></button>
                    <button type="button" id="btnLupaSig" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-forward"></span></button>
                    <button type="button" id="btnLupaUlt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-forward"></span></button>
                </div>

                <div class="btn-group" style="left: 5px; top: -1px;">
                    <ul class="tab quasar-grp-tablinks">
                        <li><a id="liSolapa_Datos" href="javascript:void(0)" class="tablinks active">Datos</a></li>
                        <li><a id="liSolapa_2" href="javascript:void(0)" class="tablinks">Solapa 2</a></li>
                    </ul>

                </div>


            </div>
            <div id="divAlertas" class="container-fluid">
            </div>
            <div id="divMensajeExito">
            </div>
            <div id='primer_renglon'>
                <div id='primer_renglon_row' class='container-fluid'></div>
            </div>
            <div id="tabSolapa_Datos">
                <div class="container-fluid">
                    <div class="row">
                        <div id="divctrPais_Id" class="form-group col-sm-4 quasar-box">
                            <label for='ctrPais_Id_1' id='lblctrPais_Id_1'>País *</label><br />
                            <input id='ctrPais_Id_1' value='' />
                            <button id='btn_ctrPais_Id' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-search'></i></button>
                        </div>
                        <div id="divctrDescripcion" class="form-group col-sm-4 quasar-box">
                            <label for='ctrDescripcion' id='lblctrDescripcion'>Descripción</label>
                            <input id='ctrDescripcion' value='' />
                        </div>
                        <div id="divctrDominio_Id" class="form-group col-sm-4 quasar-box">
                            <label for='ctrDominio_Id_1' id='lblctrDominio_Id_1'>Dominio</label><br />
                            <input id='ctrDominio_Id_1' value='' />
                            <button id='btn_ctrDominio_Id' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-search'></i></button>
                            <input id='ctrDominio_Id_d' value='' />
                        </div>
                    </div>
                    <div class="row">
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="divctrPTodasEmpresas" class="form-group col-sm-4 quasar-box">
                            <label for='ctrPTodasEmpresas'></label>
                            <br />
                            <input type='checkbox' id='ctrPTodasEmpresas' class='quasar-checkbox' onchange='gTieneSinGuardar = true;' /><label id='lblctrPTodasEmpresas' class='quasar-checkbox-label' for='ctrPTodasEmpresas'>Para Todas las Empresas</label>
                        </div>
                        <div id="divctrInactivo" class="form-group col-sm-4 quasar-box">
                            <label for='ctrInactivo'></label>
                            <br />
                            <input type='checkbox' id='ctrInactivo' class='quasar-checkbox' onchange='gTieneSinGuardar = true;' /><label id='lblctrInactivo' class='quasar-checkbox-label' for='ctrInactivo'>Inactivo</label>
                        </div>
                    </div>
                    <div class="row">
                        <div id="divctrnal9Impuesto_Id" class="form-group col-sm-4 quasar-box">
                            <label for='ctrnal9Impuesto_Id_1' id='lblctrnal9Impuesto_Id_1'>Impuesto</label><br />
                            <input id='ctrnal9Impuesto_Id_1' value='' />
                            <button id='btn_ctrnal9Impuesto_Id' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-search'></i></button>
                            <input id='ctrnal9Impuesto_Id_d' value='' />
                        </div>
                        <div id="divctrnal9Adicional" class="form-group col-sm-4 quasar-box">
                            <label for='ctrnal9Adicional' id='lblctrnal9Adicional'>Adicional</label><br />
                            <input id='ctrnal9Adicional' value='' disabled='disabled' />
                            <button id='btnctrnal9Adicional_Sel' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-open'></i></button>
                            <button id='btnctrnal9Adicional_Lim' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-remove'></i></button>
                            <input id='ctrnal9Adicional_F' type='file' class='upload' style='display: none' accept='.pdf' />
                        </div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="divgrdProductos" class="form-group col-sm-6 quasar-box">
                            <label for='grdProductos'></label>
                            <br />
                            <label for='grdProductos' id='lblgrdProductos' class="labelGrilla">Productos  <a href="Nada">[<i class="fa fa-plus"></i> Agregar Fila Nueva][ALT+P]</a></label>
                            <table id='grdProductos' style='min-width: 780px'></table>
                        </div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="divgrdSinColumnas" class="form-group col-sm-12 quasar-box">
                            <label for='grdSinColumnas'></label>
                            <br />
                            <label for='grdSinColumnas' id='lblgrdSinColumnas' class="labelGrilla">Sin Columnas</label>
                            <table id='grdSinColumnas' class='quasar-celda-grilla-autoformateable' style='min-width: 780px'></table>
                        </div>
                    </div>
                    <div class="row">
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="divlstadjAdjuntos" class="form-group col-sm-12 quasar-box">
                            <label for='lstadjAdjuntos'></label>
                            <br />
                            <label for='lstadjAdjuntos' id='lbllstadjAdjuntos' class="labelGrilla">Adjuntos  <a href="Nada">[<i class="fa fa-paperclip"></i> Agregar Archivo]</a></label>
                            <input id='lstadjAdjuntos_F' type='file' class='upload' style='display: none' accept='.pdf' /><br />
                            <div id="lstadjAdjuntos" class="divListaAdjunto"></div>
                            <div class="modal fade" id="divlstadjAdjuntos_modal" role="dialog">
                                <div class="modal-dialog modal-lg" style="max-height: 100%">
                                    <div class="modal-content">
                                        <div id="lstadjAdjuntos_headerModal" class="modal-header btn-primary">
                                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                                            <h6 id="lstadjAdjuntos_tituloModal" class="modal-title">Imagen</h6>
                                        </div>
                                        <div class="modal-body divImagenAdjModal" id="lstadjAdjuntos_ModalImagen" style="text-align: center"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div id="divDisenioBoton5" class="form-group col-sm-2 quasar-box">
                            <label for='DisenioBoton5' id='lblDisenioBoton5'></label>
                            <br />
                            <button type='button' id="DisenioBoton5" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton5</button>
                        </div>
                        <div id="divDisenioBoton6" class="form-group col-sm-2 quasar-box">
                            <label for='DisenioBoton6' id='lblDisenioBoton6'></label>
                            <br />
                            <button type='button' id="DisenioBoton6" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton6</button>
                        </div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div id="divGrupogrdProductos" class="modal fade" role="dialog">
                    <div class="modal-dialog modal-lg">
                        <div class="modal-content popupbody">
                            <div class="modal-header btn-primary popupheader">
                                <h4 class="modal-title">Producto</h4>
                            </div>
                            <div class="container-fluid">
                                <div class="row">
                                    <div id="divctrtos9Producto_Id" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9Producto_Id_1' id='lblctrtos9Producto_Id_1'>Producto</label><br />
                                        <input id='ctrtos9Producto_Id_1' value='' />
                                        <button id='btn_ctrtos9Producto_Id' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-search'></i></button>
                                        <input id='ctrtos9Producto_Id_d' value='' />
                                    </div>
                                    <div id="divctrtos9Adicional" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9Adicional' id='lblctrtos9Adicional'>Adicional</label><br />
                                        <input id='ctrtos9Adicional' value='' disabled='disabled' />
                                        <button id='btnctrtos9Adicional_Sel' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-open'></i></button>
                                        <button id='btnctrtos9Adicional_Lim' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-remove'></i></button>
                                        <input id='ctrtos9Adicional_F' type='file' class='upload' style='display: none' accept='.*' />
                                    </div>
                                    <div id="divctrtos9AdicionalB" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9AdicionalB'></label>
                                        <br />
                                        <input type='checkbox' id='ctrtos9AdicionalB' class='quasar-checkbox' /><label id='lblctrtos9AdicionalB' class='quasar-checkbox-label' for='ctrtos9AdicionalB'>AdicionalB</label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div id="divctrtos9AdicionalC" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9AdicionalC'></label>
                                        <br />
                                        <div class='radio-inline quasar-label'>
                                            <label>
                                                <input type='radio' id='rd1ctrtos9AdicionalC' name='ctrtos9AdicionalC' value='A' />Descripcion A</label>
                                        </div>
                                        <div class='radio-inline quasar-label'>
                                            <label>
                                                <input type='radio' id='rd2ctrtos9AdicionalC' name='ctrtos9AdicionalC' value='B' />Descripcion B</label>
                                        </div>
                                        <div class='radio-inline quasar-label'>
                                            <label>
                                                <input type='radio' id='rd3ctrtos9AdicionalC' name='ctrtos9AdicionalC' value='C' />Descripcion C</label>
                                        </div>
                                    </div>
                                    <div id="divctrtos9AdicionalD" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9AdicionalD' id='lblctrtos9AdicionalD'>AdicionalD</label>
                                        <input id='ctrtos9AdicionalD' value='' />
                                    </div>
                                    <div id="divctrtos9AdicionalF" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9AdicionalF' id='lblctrtos9AdicionalF'>AdicionalF</label>
                                        <input id='ctrtos9AdicionalF' value='' />
                                    </div>
                                </div>
                                <div class="row">
                                    <div id="divctrtos9AdicionalI" class="form-group col-sm-4 quasar-box">
                                        <label for='ctrtos9AdicionalI' id='lblctrtos9AdicionalI'>AdicionalI</label>
                                        <input id='ctrtos9AdicionalI' value='' />
                                    </div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                </div>
                                <div class="row">
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                </div>
                                <div class="row">
                                    <div id="divgrdSeries" class="form-group col-sm-12 quasar-box">
                                        <label for='grdSeries'></label>
                                        <br />
                                        <label for='grdSeries' id='lblgrdSeries' class="labelGrilla">Título  <a href="Nada">[<i class="fa fa-plus"></i> Agregar Fila Nueva][ALT+T]</a></label>
                                        <table id='grdSeries' style='min-width: 780px'></table>
                                    </div>
                                </div>
                            </div>
                            <div id="footergrdProductos" class="modal-footer popupfooter">
                                <div id="divopcgrdProductos" style="display: inline-block" tabindex='-1'>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdProductos" checked value='X' tabindex='-1'><i class="far fa-check-circle quasar-i-radio-grilla"></i></label></div>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdProductos" value='A' tabindex='-1'><i class="fas fa-check quasar-i-radio-grilla"></i><i class="far fa-arrow-alt-circle-up quasar-i-radio-grilla"></i></label></div>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdProductos" value='S' tabindex='-1'><i class="fas fa-check quasar-i-radio-grilla"></i><i class="far fa-arrow-alt-circle-down quasar-i-radio-grilla"></i></label></div>
                                </div>
                                <button id="btnAceptargrd2Productos" type="button" class="quasar-btn-invisible"></button>
                                <button id="btnAceptargrdProductos" type="button" class="btn btn-primary quasar-aceptar-fila" data-toggle="tooltip" data-placement="top">Aceptar</button>
                                <button id="btnCancelargrdProductos" type="button" class="btn btn-danger quasar-cancelar-fila" data-dismiss="modal">Cancelar</button></div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="tabSolapa_2" style="display: none">
                <div class="container-fluid">
                    <div class="row">
                        <div id="divgrfGrafico1" class="form-group col-sm-6 quasar-box">
                            <label for='grfGrafico1'></label>
                            <br />
                            <label for='grfGrafico1' class="ui-chart-title" style="border-bottom-color: gainsboro; border-bottom-style: solid; border-bottom-width: 1px; width: 100%;" id='lblgrfGrafico1' class="labelGrilla">Pirmer Grafico</label>                            
                            <div id="divbarraGrafico1" style="width: 100%">
                                <button id='btnimp_grfGrafico1' type='button' class='btn quasar-btn-lupa' tabindex='-1'><i class='glyphicon glyphicon-print'></i></button>
                                <div id="divctrcbogrfGrafico1" style="display:inline-block; width:calc(100% - 25px);">
                                    <input id="ctrcbogrfGrafico1" value='' />
                                </div>
                            </div>
                            <div id="grfGrafico1" class="chart"></div>
                            <div id="divgrfGrafico1legend" class="legend quasar-fondo-grafico"></div>
                        </div>
                        <div id="divgrfGrafico2" class="form-group col-sm-6 quasar-box">
                            <label for='grfGrafico2'></label>
                            <br />
                            <label for='grfGrafico2' class="ui-chart-title" style="border-bottom-color: gainsboro; border-bottom-style: solid; border-bottom-width: 1px; width: 100%;" id='lblgrfGrafico2' class="labelGrilla">Título</label>
                            <div id="divctrcbogrfGrafico2" style="width: 100%">
                                <input id="ctrcbogrfGrafico2" value='' />
                            </div>
                            <div id="grfGrafico2" class="chart"></div>
                            <div id="divgrfGrafico2legend" class="legend quasar-fondo-grafico"></div>
                        </div>
                    </div>
                    <div class="row">
                        <div id="divDisenioBoton1" class="form-group col-sm-2 quasar-box">
                            <label for='DisenioBoton1' id='lblDisenioBoton1'></label>
                            <br />
                            <button type='button' id="DisenioBoton1" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton1</button>
                        </div>
                        <div id="divDisenioBoton2" class="form-group col-sm-2 quasar-box">
                            <label for='DisenioBoton2' id='lblDisenioBoton2'></label>
                            <br />
                            <button type='button' id="DisenioBoton2" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton2</button>
                        </div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row">
                        <div id="divDisenioGrupoInicio1" class="form-group col-sm-12 quasar-box">
                            <div class="quasar-panel"><span class="quasar-panel-titulo">Imagenes</span></div>
                            <div class="panel panel-default quasar-panel-default">
                                <div class="panel-body quasar-panel-body">
                                    <div class="row" style="margin-left: 0px; margin-right: 0px">
                                        <div id="divDisenioBoton3" class="form-group col-sm-2 quasar-box-en-panel">
                                            <label for='DisenioBoton3' id='lblDisenioBoton3'></label>
                                            <br />
                                            <button type='button' id="DisenioBoton3" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton3</button>
                                        </div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                    </div>
                                    <div class="row" style="margin-left: 0px; margin-right: 0px">
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                    </div>
                                    <div class="row" style="margin-left: 0px; margin-right: 0px">
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="divDisenioBoton4" class="form-group col-sm-2 quasar-box-en-panel">
                                            <label for='DisenioBoton4' id='lblDisenioBoton4'></label>
                                            <br />
                                            <button type='button' id="DisenioBoton4" class='btn quasar-btn' style="height: 23px; width: 75px;">DisenioBoton4</button>
                                        </div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                        <div id="" class="hidden-xs col-sm-2 quasar-box-en-panel"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row"></div>
                </div>
            </div>
            <div class="container">
                <div id="divGrupogrdSeries" class="modal fade" role="dialog">
                    <div class="modal-dialog modal-lg">
                        <div class="modal-content popupbody">
                            <div class="modal-header btn-primary popupheader">
                                <h4 class="modal-title">Series</h4>
                            </div>
                            <div class="container-fluid">
                                <div class="row">
                                    <div id="divctries6Serie" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6Serie' id='lblctries6Serie'>Serie</label>
                                        <input id='ctries6Serie' value='' />
                                    </div>
                                    <div id="divctries6Adicional" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6Adicional' id='lblctries6Adicional'>Adicional</label>
                                        <input id='ctries6Adicional' value='' />
                                    </div>
                                    <div id="divctries6AdicionalB" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6AdicionalB'></label>
                                        <br />
                                        <input type='checkbox' id='ctries6AdicionalB' class='quasar-checkbox' /><label id='lblctries6AdicionalB' class='quasar-checkbox-label' for='ctries6AdicionalB'>AdicionalB</label>
                                    </div>
                                    <div id="divctries6AdicionalC" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6AdicionalC' id='lblctries6AdicionalC'>AdicionalC</label>
                                        <input id='ctries6AdicionalC' value='' />
                                    </div>
                                    <div id="divctries6AdicionalD" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6AdicionalD' id='lblctries6AdicionalD'>AdicionalD</label>
                                        <input id='ctries6AdicionalD' value='' />
                                    </div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                </div>
                                <div class="row">
                                    <div id="divctries6AdicionalF" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6AdicionalF' id='lblctries6AdicionalF'>AdicionalF</label>
                                        <input id='ctries6AdicionalF' value='' />
                                    </div>
                                    <div id="divctries6AdicionalI" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6AdicionalI' id='lblctries6AdicionalI'>AdicionalI</label>
                                        <input id='ctries6AdicionalI' value='' />
                                    </div>
                                    <div id="divctries6Cantidad" class="form-group col-sm-2 quasar-box">
                                        <label for='ctries6Cantidad' id='lblctries6Cantidad'>Cantidad</label>
                                        <input id='ctries6Cantidad' value='' />
                                    </div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                    <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                                </div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                                <div class="row"></div>
                            </div>
                            <div id="footergrdSeries" class="modal-footer popupfooter">
                                <div id="divopcgrdSeries" style="display: inline-block" tabindex='-1'>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdSeries" checked value='X' tabindex='-1'><i class="far fa-check-circle quasar-i-radio-grilla"></i></label></div>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdSeries" value='A' tabindex='-1'><i class="fas fa-check quasar-i-radio-grilla"></i><i class="far fa-arrow-alt-circle-up quasar-i-radio-grilla"></i></label></div>
                                    <div class="radio-inline">
                                        <label>
                                            <input type="radio" name="optgrdSeries" value='S' tabindex='-1'><i class="fas fa-check quasar-i-radio-grilla"></i><i class="far fa-arrow-alt-circle-down quasar-i-radio-grilla"></i></label></div>
                                </div>
                                <button id="btnAceptargrd2Series" type="button" class="quasar-btn-invisible"></button>
                                <button id="btnAceptargrdSeries" type="button" class="btn btn-primary quasar-aceptar-fila" data-toggle="tooltip" data-placement="top">Aceptar</button>
                                <button id="btnCancelargrdSeries" type="button" class="btn btn-danger quasar-cancelar-fila" data-dismiss="modal">Cancelar</button></div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="tabSolapa_4" style="display: none">
                <div class="container-fluid" style="padding-top: 50px;">
                    <div class="row">
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                        <div id="" class="hidden-xs col-sm-2 quasar-box"></div>
                    </div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                    <div class="row"></div>
                </div>
            </div>
            <br />


        </div>


        <div class="container">
            <div class="modal fade" id="divModalLupa" role="dialog">
                <div id="divModalLupaDlg" class="modal-dialog" style="max-width: 80%; max-height: 80%">
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
                <div id="divModalLupaSegDlg" class="modal-dialog" style="max-width: 80%; max-height: 80%">
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

        <div class="modal fade" id="divOpciones" role="dialog">
            <div class="modal-dialog" style="width: fit-content; min-width: 200px;">
                <div class="modal-content">
                    <div class="modal-body btn-info" style="padding: 2px; background-color: #585858; min-width: 110px;">
                        <div id="lstOpciones" class="btn-group-vertical" style="width: 100%">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer id="divFooterFrm" class="quasar-footer-mobile">
            <div class="btn-group btn-group-md" style="margin: auto;">
                <button type="button" id="btnLupaPrimMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-backward"></span></button>
                <button type="button" id="btnLupaAntMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-backward"></span></button>
                <button type="button" id="btnLupaSigMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-forward"></span></button>
                <button type="button" id="btnLupaUltMbl" class="btn btn-info quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-forward"></span></button>
            </div>

        </footer>





        <script type='text/javascript'>$('#divCargando').addClass('show');</script>
        <script type='text/javascript'>var gFormulario = new qcom_formulario("EnumpruPaisesAction", "PruebaSegExchange.pruPaisesActionExchange", "PruebaSegExchange", "PruebaSegCommon.pruPaisesDS", "PruebaSegCommon", "PruebaSegFE.pruPaises", "PruebaSegFE", "PruPaises", true, true, true, true, true, "", "", "", "", "", "", "", "");
            var gConfiguracion = new qcom_configuracion(1, 1, "MX", "PES", "", "", 0, 0, "", "", "", "frmpruPaises", "CCG", "ConStrStandard");
            var gFechaBlur = false;
            $.ig.regional.defaults.dateTimePattern = "dd-MM-yyyy";
            $.ig.regional.defaults.numericDecimalSeparator = '.';
            $.ig.regional.defaults.numericGroupSeparator = ',';
            gVariables["var_MiFecha"] = "";
            gVariables["var_EsPoco"] = "";
            gVariables["var_EsMucho"] = "";
            gVariables["var_Todo"] = "";
            gVariables["var_Nada"] = "";
            gVariables["var_Auxiliar1"] = "";
            gVariables["var_Auxiliar2"] = "";
            gVariables["var_Auxiliar3"] = "";
            gTablasPlanas["0"] = 'Adicional';
            gTablasPlanas["1"] = 'Principal';
            gRelacTablas["0"] = new qcom_Relacion('Productos', 'Series', 'Renglon', '', '', 'Renglon', '', '', 'G');
            gCamposClaves.push("Pais_Id");
            gPrimerCtr = 'ctrPais_Id';
            var gCampoCodigoNuevo = "";
            $(function () {
                $.ig.util.language = "es";
                qbas_InicializarToolTips(document.body.clientWidth);
                qbas_InicializarTextosGrillas();
                function guardarEntidad(evt) {
                    qevt_AgregarEventoaTmp('guardarEntidad', null, true);
                }

                $('#divModalLupa').on('shown.bs.modal', function (event) {
                    $('#divModalLupa').attr("Abierto", "true");
                });
                $('#divModalLupa').on('hidden.bs.modal', function (event) {
                    qpopup_ZIndexLiberar();
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
                    qpopup_ZIndexLiberar();
                    var lattr = $('#divModalLupaSeg').attr("Abierto");
                    if (lattr == "true") {
                        qevt_VaciarEventosTmp();
                    }
                });
                gBtnesVis = 8;
                qbas_InicBotonesRptRspnsv(document.body.clientWidth);
                $('#btnNuevo').click(function () {
                    qcom_NuevaEntidad(false);
                });
                $('#btnGuardar').click(function () {
                    qcom_GuardarEntidad(false, guardarEntidad);
                });
                $('#btnPostear').click(function () {
                    qcom_GuardarEntidad(true, guardarEntidad);
                });
                $('#btnEliminar').click(function () { qcom_EliminarEntidad(eliminarEntidad); });
                $('#btnRptVer').click(function () {
                    qbas_ModificarBtnRrpSelec('btnRptVer');
                    gEntidad["Principal"][0].Posteado = true;
                    sessionStorage.setItem("tiporpt", 'V');
                    qevt_AgregarEventoaTmp('rptver', null, true);
                });
                $('#btnRptImprimir').click(function () {
                    qbas_ModificarBtnRrpSelec('btnRptImprimir');
                    gEntidad["Principal"][0].Posteado = true;
                    sessionStorage.setItem("tiporpt", 'I');
                    qevt_AgregarEventoaTmp('rptimprimir', null, true);
                });
                $('#btnRptPdf').click(function () {
                    qbas_ModificarBtnRrpSelec('btnRptPdf');
                    gEntidad["Principal"][0].Posteado = true;
                    sessionStorage.setItem("tiporpt", 'P');
                    qevt_AgregarEventoaTmp('rptpdf', null, true);
                });
                $('#btnRptXls').click(function () {
                    qbas_ModificarBtnRrpSelec('btnRptXls');
                    gEntidad["Principal"][0].Posteado = true;
                    sessionStorage.setItem("tiporpt", 'X');
                    qevt_AgregarEventoaTmp('rptxls', null, true);
                });
                $('#btnrptsel').click(function () { qbas_EjecutarBtnRrpSelec(); });
                $('#btnFavorito').click(function () {
                    qcom_CambiarEstadoFavorito('');
                });
                $('#btnAyuda').addClass('hidden');
                $('#btnCerrar').click(function () {
                    qcom_CerrarFormActual();
                });
                $('#btnCopiar').click(function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    qcom_CopiarFormulario();
                });
                $('#btnPegar').click(function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    qevt_PegarFormulario();
                });
                qcom_VerifPuedePegarFrm();
                function Lupa_Prim() { LupaNavegador_Click(0); }
                function Lupa_Ult() { LupaNavegador_Click(10); }
                function Lupa_Sig() { LupaNavegador_Click(1); }
                function Lupa_Ant() { LupaNavegador_Click(-1); }
                $('#divFooterFrm').addClass('quasar-footer-mobile-entidad');
                function LupaNavegador_Click(pAccion) {
                    QLupaAdv_ObtenerCodigoNavegador(gControles["Principal"][0]["Pais_Id"].getIdentidad(), "Principal", pAccion, "Pais_Id", "", "");
                }
                function LupaNavegador_Inic() {
                    qevt_Lupa_ValorNavegador(Lupa_Sig, null, '');
                }
                $('#btnLupaAnt').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Ant, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaSig').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Sig, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaPrim').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Prim, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaUlt').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Ult, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaAntMbl').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Ant, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaSigMbl').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Sig, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaPrimMbl').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Prim, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#btnLupaUltMbl').click(function () {
                    qevt_Lupa_ValorNavegador(Lupa_Ult, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                });
                $('#tabSolapa_Datos').find('.row:first').detach().appendTo('#primer_renglon_row');
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

                var ctrtos9AdicionalC_dscbo = [
                    { 'Valor': 'A', 'Descripcion': 'Descripcion A ' },
                    { 'Valor': 'B', 'Descripcion': 'Descripcion B ' },
                    { 'Valor': 'C', 'Descripcion': 'Descripcion C ' },
                ];

                gEventos['ctrInactivo_Click'] = new qevt_evento();
                gEventos['ctrInactivo_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['ctrInactivo_Click'].Acciones.push(new qevt_accion('1', 'A', ctrInactivo_Click_10000, ''));
                gEventos['ctrInactivo_Click'].Acciones.push(new qevt_accion('2', 'A', ctrInactivo_Click_20000, ''));
                gEventos['ctrInactivo_Click'].Acciones.push(new qevt_accion('3', 'A', ctrInactivo_Click_30000, ''));
                gEventos['ctrInactivo_Click'].Acciones.push(new qevt_accion('4', 'A', ctrInactivo_Click_40000, ''));
                gEventos['ctrnal9Impuesto_Id_Change'] = new qevt_evento();
                gEventos['ctrnal9Impuesto_Id_Change'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['ctrnal9Impuesto_Id_Change'].Acciones.push(new qevt_accion('1', 'A', ctrnal9Impuesto_Id_Change_50000, ''));
                gEventos['accionLupa_ctrPais_Id'] = new qevt_evento();
                gEventos['accionLupa_ctrPais_Id'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['accionLupa_ctrPais_Id'].Acciones.push(new qevt_accion('1', 'A', accionLupa_ctrPais_Id_60000, ''));
                gEventos['accionLupa_ctrPais_Id'].Acciones.push(new qevt_accion('2', 'A', qcom_blanquearCambiosSinGuardar, ''));
                gEventos['accionLupa_ctrPais_Id'].Acciones.push(new qevt_accion('3', 'A', qcom_verificoEntidadEmpresa, ''));
                gEventos['ctrtos9AdicionalB_Click'] = new qevt_evento();
                gEventos['ctrtos9AdicionalB_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['ctrtos9AdicionalB_Click'].Acciones.push(new qevt_accion('1', 'A', ctrtos9AdicionalB_Click_70000, ''));
                gEventos['ctrtos9AdicionalD_Change'] = new qevt_evento();
                gEventos['ctrtos9AdicionalD_Change'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['ctrtos9AdicionalD_Change'].Acciones.push(new qevt_accion('1', 'A', ctrtos9AdicionalD_Change_80000, ''));
                gEventos['ctrtos9Producto_Id_Change'] = new qevt_evento();
                gEventos['ctrtos9Producto_Id_Change'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['ctrtos9Producto_Id_Change'].Acciones.push(new qevt_accion('1', 'A', ctrtos9Producto_Id_Change_90000, ''));
                gEventos['DisenioBoton2_Click'] = new qevt_evento();
                gEventos['DisenioBoton2_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['DisenioBoton2_Click'].Acciones.push(new qevt_accion('1', 'A', DisenioBoton2_Click_100000, ''));
                gEventos['DisenioBoton5_Click'] = new qevt_evento();
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('1', 'A', DisenioBoton5_Click_110000, ''));
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('2', 'A', DisenioBoton5_Click_120000, ''));
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('3', 'A', DisenioBoton5_Click_130000, ''));
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('4', 'A', DisenioBoton5_Click_140000, ''));
                gEventos['DisenioBoton5_Click'].Acciones.push(new qevt_accion('5', 'A', DisenioBoton5_Click_150000, ''));
                gEventos['DisenioBoton6_Click'] = new qevt_evento();
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('1', 'A', DisenioBoton6_Click_160000, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('2', 'A', DisenioBoton6_Click_170000, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('3', 'A', DisenioBoton6_Click_180000, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('4', 'A', DisenioBoton6_Click_190000, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('5', 'A', DisenioBoton6_Click_210000, ''));
                gEventos['DisenioBoton6_Click'].Acciones.push(new qevt_accion('6', 'A', DisenioBoton6_Click_220000, ''));
                gEventos['guardarEntidad'] = new qevt_evento();
                gEventos['guardarEntidad'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['guardarEntidad'].Acciones.push(new qevt_accion('1', 'A', guardarEntidad_230000, ''));
                gEventos['guardarEntidad'].Acciones.push(new qevt_accion('2', 'A', guardarEntidad_240000, ''));
                gEventos['guardarEntidad'].Acciones.push(new qevt_accion('3', 'A', qcom_blanquearCambiosSinGuardar, ''));
                gEventos['Pegando_Form'] = new qevt_evento();
                gEventos['Pegando_Form'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['Pegando_Form'].Acciones.push(new qevt_accion('1', 'A', Pegando_Form_250000, ''));
                gEventos['Post_Load'] = new qevt_evento();
                gEventos['Post_Load'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['Post_Load'].Acciones.push(new qevt_accion('1', 'A', Post_Load_260000, ''));
                gEventos['Post_Load'].Acciones.push(new qevt_accion('1', 'A', qevt_BlanquearCambiosSinGuardar, ''));
                gEventos['rptimprimir'] = new qevt_evento();
                gEventos['rptimprimir'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['rptimprimir'].Acciones.push(new qevt_accion('1', 'A', rptimprimir_270000, ''));
                gEventos['rptpdf'] = new qevt_evento();
                gEventos['rptpdf'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['rptpdf'].Acciones.push(new qevt_accion('1', 'A', rptpdf_280000, ''));
                gEventos['rptver'] = new qevt_evento();
                gEventos['rptver'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['rptver'].Acciones.push(new qevt_accion('1', 'A', rptver_290000, ''));
                gEventos['rptxls'] = new qevt_evento();
                gEventos['rptxls'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['rptxls'].Acciones.push(new qevt_accion('1', 'A', rptxls_300000, ''));
                gEventos['grdProductos_ClickColumnaBoton'] = new qevt_evento();
                gEventos['grdProductos_ClickColumnaBoton'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['grdProductos_ClickColumnaBoton'].Acciones.push(new qevt_accion('1', 'A', grdProductos_ClickColumnaBoton_310000, ''));
                gEventos['grdProductos_InicioNuevaFila'] = new qevt_evento();
                gEventos['grdProductos_InicioNuevaFila'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['grdProductos_InicioNuevaFila'].Acciones.push(new qevt_accion('1', 'A', grdProductos_InicioNuevaFila_320000, ''));
                gEventos['grfGrafico1_Click'] = new qevt_evento();
                gEventos['grfGrafico1_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['grfGrafico1_Click'].Acciones.push(new qevt_accion('1', 'A', grfGrafico1_Click_330000, ''));
                gEventos['grfGrafico1_Click'].Acciones.push(new qevt_accion('2', 'A', grfGrafico1_Click_340000, ''));
                gEventos['grfGrafico2_Click'] = new qevt_evento();
                gEventos['grfGrafico2_Click'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['grfGrafico2_Click'].Acciones.push(new qevt_accion('1', 'A', grfGrafico2_Click_350000, ''));
                gEventos['grfGrafico2_Click'].Acciones.push(new qevt_accion('2', 'A', grfGrafico2_Click_360000, ''));
                gEventos['Solapa_2_Activated'] = new qevt_evento();
                gEventos['Solapa_2_Activated'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['Solapa_2_Activated'].Acciones.push(new qevt_accion('1', 'A', Solapa_2_Activated_370000, ''));
                gEventos['Solapa_2_Activated1rsttime'] = new qevt_evento();
                gEventos['Solapa_2_Activated1rsttime'].Acciones.push(new qevt_accion('0', '', null, ''));
                gEventos['Solapa_2_Activated1rsttime'].Acciones.push(new qevt_accion('1', 'A', Solapa_2_Activated1rsttime_380000, ''));

                gSolapas.push({ Nombre: 'Solapa_Datos', Titulo: 'Datos', EstaVisible: true, Activada: false, Activado1: null, Activado: null });
                $('#liSolapa_Datos').click(function () { qcom_mostrarSolapa('Solapa_Datos'); });
                gSolapas.push({ Nombre: 'Solapa_2', Titulo: 'Solapa 2', EstaVisible: true, Activada: false, Activado1: Activated1rst_Solapa_2, Activado: Activated_Solapa_2 });
                $('#liSolapa_2').click(function () { qcom_mostrarSolapa('Solapa_2'); });
                $("#ctrPais_Id_1").igTextEditor(
                    {
                        width: "calc(99% - 21px)",
                        height: 21,
                        maxLength: 32767,
                        placeHolder: '',
                        value: '',
                        valueChanged: function (evt, ui) {
                            if (gValorAnt == "") {
                                ctrPais_Id_1_ValorModif(evt, ui);
                            }
                            gValorAnt = "";
                        },
                        blur: function (evt) {
                            qcom_HabilitoGuardar();
                        },
                        keydown: function (evt, ui) {
                            if (evt.which == 120) {
                                ctrPais_Id_1_BotonClick(evt, ui);
                            }
                        },
                        textChanged: function (evt, ui) {
                            gValorAnt = ui.oldText;
                            qcom_ProcesarCambioEntidad(gValorAnt, gControles['Principal'][0]['Pais_Id'], ctrPais_Id_1_ValorModif);
                        },
                    });
                $('#btn_ctrPais_Id').on('click', function () {
                    gValorAnt = "1";
                    ctrPais_Id_1_BotonClick(null, null);
                });
                function ctrPais_Id_MostrarLupa() {
                    QLupaAdv_MostrarLupa(gControles["Principal"][0]["Pais_Id"].getIdentidad(), "Principal", "Pais_Id", "", "", "", "", "", true, '', '');
                }
                function ctrPais_Id_ObtenerDesc() {
                    QLupaAdv_ObtenerDescripciones(gControles["Principal"][0]["Pais_Id"].getIdentidad(), "Principal", "Pais_Id", "", "", "", "", "", false, true);
                }
                function ctrPais_Id_1_ValorModif(evt, ui) {
                    qevt_Lupa_ValorModif(ctrPais_Id_ObtenerDesc, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, '');
                    var lValor = qcom_ObtenerValorControl(gControles["Principal"][0]["Pais_Id"]);
                    QLupaAdv_HabilitarBtnsNavegador(lValor);
                    qcom_InicSolapasActivadas(true);
                }
                function ctrPais_Id_1_BotonClick(evt, ui) {
                    qevt_Lupa_BotonClick(ctrPais_Id_MostrarLupa, typeof accionLupa_ctrPais_Id !== 'undefined' ? accionLupa_ctrPais_Id : null, 'ctrPais_Id_Change');
                }
                $("#ctrDescripcion").igTextEditor(
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
                $("#ctrDominio_Id_1").igTextEditor(
                    {
                        width: "100px",
                        height: 21,
                        maxLength: 32767,
                        placeHolder: '',
                        value: '',
                        valueChanged: function (evt, ui) {
                            if (gValorAnt == "") {
                                ctrDominio_Id_1_ValorModif(evt, ui);
                            }
                            gValorAnt = "";
                        },
                        blur: function (evt) {
                            qcom_HabilitoGuardar();
                        },
                        keydown: function (evt, ui) {
                            if (evt.which == 120) {
                                ctrDominio_Id_1_BotonClick(evt, ui);
                            }
                        },
                        textChanged: function (evt, ui) {
                            qcom_DeshabilitoGuardar();
                        },
                    });
                $("#ctrDominio_Id_d").igTextEditor(
                    {
                        width: "calc(99% - 121px)",
                        height: 21,
                        tabIndex: -1, readOnly: true
                    });
                $('#btn_ctrDominio_Id').on('click', function () {
                    gValorAnt = "1";
                    ctrDominio_Id_1_BotonClick(null, null);
                });
                function ctrDominio_Id_MostrarLupa() {
                    QLupaAdv_MostrarLupa(gControles["Principal"][0]["Dominio_Id"].getIdentidad(), "Principal", "Dominio_Id", "DescripcionDominios", "", "", "", "", false, '', '');
                }
                function ctrDominio_Id_ObtenerDesc() {
                    QLupaAdv_ObtenerDescripciones(gControles["Principal"][0]["Dominio_Id"].getIdentidad(), "Principal", "Dominio_Id", "DescripcionDominios", "", "", "", "", false, false);
                }
                function ctrDominio_Id_1_ValorModif(evt, ui) {
                    qevt_Lupa_ValorModif(ctrDominio_Id_ObtenerDesc, typeof accionLupa_ctrDominio_Id !== 'undefined' ? accionLupa_ctrDominio_Id : null, 'ctrDominio_Id_Change');
                }
                function ctrDominio_Id_1_BotonClick(evt, ui) {
                    qevt_Lupa_BotonClick(ctrDominio_Id_MostrarLupa, typeof accionLupa_ctrDominio_Id !== 'undefined' ? accionLupa_ctrDominio_Id : null, 'ctrDominio_Id_Change');
                }
                $("#ctrnal9Impuesto_Id_1").igTextEditor(
                    {
                        width: "100px",
                        height: 21,
                        maxLength: 32767,
                        placeHolder: '',
                        value: '',
                        valueChanged: function (evt, ui) {
                            if (gValorAnt == "") {
                                ctrnal9Impuesto_Id_1_ValorModif(evt, ui);
                            }
                            gValorAnt = "";
                        },
                        blur: function (evt) {
                            qcom_HabilitoGuardar();
                        },
                        keydown: function (evt, ui) {
                            if (evt.which == 120) {
                                ctrnal9Impuesto_Id_1_BotonClick(evt, ui);
                            }
                            else if (evt.which == 119) {
                                qpopup_MostrarForm('frmvenImpuestos', ui.editorInput[0].value, '', '', 'Impuestos', true)
                            }
                        },
                        textChanged: function (evt, ui) {
                            qcom_DeshabilitoGuardar();
                        },
                    });
                $("#ctrnal9Impuesto_Id_d").igTextEditor(
                    {
                        width: "calc(99% - 121px)",
                        height: 21,
                        tabIndex: -1, readOnly: true
                    });
                $('#btn_ctrnal9Impuesto_Id').on('click', function () {
                    gValorAnt = "1";
                    ctrnal9Impuesto_Id_1_BotonClick(null, null);
                });
                function ctrnal9Impuesto_Id_MostrarLupa() {
                    QLupaAdv_MostrarLupa(gControles["Adicional"][0]["Impuesto_Id"].getIdentidad(), "Adicional", "Impuesto_Id", "DescripcionImpuesto", "", "", "", "", false, 'frmvenImpuestos', 'Impuestos');
                }
                function ctrnal9Impuesto_Id_ObtenerDesc() {
                    QLupaAdv_ObtenerDescripciones(gControles["Adicional"][0]["Impuesto_Id"].getIdentidad(), "Adicional", "Impuesto_Id", "DescripcionImpuesto", "", "", "", "", false, false);
                }
                function ctrnal9Impuesto_Id_1_ValorModif(evt, ui) {
                    qevt_Lupa_ValorModif(ctrnal9Impuesto_Id_ObtenerDesc, typeof accionLupa_ctrnal9Impuesto_Id !== 'undefined' ? accionLupa_ctrnal9Impuesto_Id : null, 'ctrnal9Impuesto_Id_Change');
                }
                function ctrnal9Impuesto_Id_1_BotonClick(evt, ui) {
                    qevt_Lupa_BotonClick(ctrnal9Impuesto_Id_MostrarLupa, typeof accionLupa_ctrnal9Impuesto_Id !== 'undefined' ? accionLupa_ctrnal9Impuesto_Id : null, 'ctrnal9Impuesto_Id_Change');
                }
                $("#ctrnal9Adicional").igTextEditor(
                    {
                        width: "calc(100% - 46px)",
                        height: 21,
                        readOnly: true,
                    });
                $('#btnctrnal9Adicional_Sel').on('click', function () {
                    $('#ctrnal9Adicional_F').click();
                });
                $('#btnctrnal9Adicional_Lim').on('click', function () {
                    QUpLoadAdv_LimpiarArchivo('ctrnal9Adicional');
                });
                gUpLoads["ctrnal9Adicional"] = '';
                $('#ctrnal9Adicional_F').on('change', function () {
                    if (typeof accionUpLoad_ctrnal9Adicional !== 'undefined' && jQuery.isFunction(accionUpLoad_ctrnal9Adicional))
                        QUpLoadAdv_UpLoadArchivo('ctrnal9Adicional', accionUpLoad_ctrnal9Adicional);
                    else
                        QUpLoadAdv_UpLoadArchivo('ctrnal9Adicional', null);
                });
                gGrillas["grdProductos"] = { Control: $("#grdProductos"), Tabla: "Productos", NombreControl: "grdProductos", Visible: true, VisibleXPais: true, CamposPK: "", RegistrosPorPagina: 0, CampoAutonumerico: "Renglon", ValorPK: -1, ColIdEnEdicion: -1, RegistroPadre: null, ColumnaEnEdicion: "", FilasFiltradas: [], UltimaPK: 0, FilaaBorrar: 0, Editable: false, AutoFormateable: false, EsArbol: false, ColFmtNumFila: "", AnchoColFijas: "", FilasAMostrar: 0, ColumnasSoloLectura: '', ColumnasOcultas: '', ColumnasFijas: '', Contenedor: 'Solapa_Datos', ItemsMenuCtxt: [], ShortCut: 'P' };
                gGrillasAux[0] = "grdProductos";
                $("#grdProductos").igGrid(
                    {
                        autoGenerateColumns: false,
                        autofitLastColumn: true,
                        autoFormat: true,
                        defaultColumnWidth: "*",
                        renderCheckboxes: true,
                        disabled: false,
                        dataSource: null,
                        width: "100%",
                        heigth: "81px",
                        primaryKey: "IDCol",
                        autoCommit: true,
                        columns: [
                            { headerText: "IDCol", key: "IDCol", dataType: "number", hidden: true },
                            { headerText: "Producto", key: "Producto_Id", width: "*", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "Descripción", key: "DescripcionProducto", width: "*", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "Adicional", key: "Adicional", width: "*", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "AdicionalB", key: "AdicionalB", width: "*", dataType: "bool", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "AdicionalC", key: "AdicionalC", dataType: "string", hidden: true },
                            { headerText: "AdicionalD", key: "AdicionalD", width: "*", dataType: "number", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "0.00" },
                            { headerText: "AdicionalF", key: "AdicionalF", width: "*", dataType: "date", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "dd-MM-yyyy", formatter: function (val, record) { return qcom_FormatearFechaGrilla2(val, ''); } },
                            { headerText: "AdicionalI", key: "AdicionalI", width: "*", dataType: "number", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "0" },
                            { headerText: "Renglón", key: "Renglon", dataType: "number", hidden: true },
                            { headerText: "", key: "grdProductos_btn1", width: "*", dataType: "string", unbound: true, formula: function (row, grid) { return ''; }, columnCssClass: "alignCol-center", template: "<button type='button' class='btn btn-default btn-xs' onclick='qevt_AgregarEventoaTmp(\"grdProductos_ClickColumnaBoton\", null, true);'>Botoncito</button>" },],
                        features: [
                            {
                                name: 'Selection',
                                mode: 'cell',
                                multipleSelection: false,
                                activation: true,
                                cellSelectionChanged: function (evt, ui) {
                                    if (ui.cell.columnKey == "grdProductos_btn1")
                                        qgrillas_SeleccionarCelda("grdProductos", ui.cell.rowIndex, ui.cell.rowId, '', false);
                                    else
                                        qgrillas_SeleccionarCelda("grdProductos", ui.cell.rowIndex, ui.cell.rowId, ui.cell.columnKey, false);
                                }
                            },
                            {
                                name: "Resizing",
                                deferredResizing: false,
                                allowDoubleClickToResize: false,
                            },
                            {
                                name: "Responsive",
                                enableVerticalRendering: false,
                                reactOnContainerWidthChanges: true,
                                columnSettings: [{}]
                            },
                            {
                                name: "Updating",
                                enableAddRow: false,
                                enableDeleteRow: false,
                                startEditTriggers: ["dblclick", "enter"],
                                rowDeleting: function (evt, ui) {
                                    gGrillas["grdProductos"].FilaaBorrar = ui.rowID;
                                    if ((typeof validarfilaEliminada_grdProductos !== 'undefined') && (jQuery.isFunction(validarfilaEliminada_grdProductos))) {
                                        validarfilaEliminada_grdProductos(ui);
                                        return false;
                                    }
                                },
                                rowDeleted: function (evt, ui) {
                                    gGrillas["grdProductos"].FilaaBorrar = ui.rowID;
                                    if ((typeof filaEliminada_grdProductos !== 'undefined') && (jQuery.isFunction(filaEliminada_grdProductos))) {
                                        filaEliminada_grdProductos(ui);
                                        return false;
                                    }
                                },
                                editCellStarting: function (evt, ui) {
                                    if (gGrillas["grdProductos"].ColumnaEnEdicion == ui.columnKey) {
                                        qevt_Grilla_EditarFila('grdProductos', 0);
                                    }
                                    return false;
                                }
                            },
                        ]
                    });
                $('#lblgrdProductos').delegate("a", "click", function (e) {
                    qevt_Grilla_NuevaFila('grdProductos', true);
                    e.stopPropagation();
                    e.preventDefault();
                });
                gGrillas["grdSinColumnas"] = { Control: $("#grdSinColumnas"), Tabla: "SinColumnas", NombreControl: "grdSinColumnas", Visible: true, VisibleXPais: true, CamposPK: "", RegistrosPorPagina: 0, CampoAutonumerico: "", ValorPK: -1, ColIdEnEdicion: -1, RegistroPadre: null, ColumnaEnEdicion: "", FilasFiltradas: [], UltimaPK: 0, FilaaBorrar: 0, Editable: true, AutoFormateable: true, EsArbol: false, ColFmtNumFila: 'FormatoNumeroFila', AnchoColFijas: [120, 120], FilasAMostrar: 0, ColumnasSoloLectura: 'Codigo,Descripcion,Total0,Total1', ColumnasOcultas: '', ColumnasFijas: 'Codigo,Descripcion', Contenedor: '', ItemsMenuCtxt: [], ShortCut: '' };
                gGrillasAux[1] = "grdSinColumnas";
                gGrillasAutoFTotales["grdSinColumnas"] = { col: 'Total1', cant: '*', min: '*', max: '*', prom: '*', sum: '*' };
                qgrillas_CrearGrilla("grdSinColumnas", null, null); gListasAdjuntosAux.push("lstadjAdjuntos");
                gListasAdjuntos["lstadjAdjuntos"] = { Tabla: "Adjuntos", NombreControl: "lstadjAdjuntos", Visible: true, VisibleXPais: true, BorraArchivos: true, MuestraDescripcion: true, PermiteDescargar: true, CantidadMaxima: 4, TamanioMaximo: 0, UltId: 0 };
                $('#lbllstadjAdjuntos').delegate("a", "click", function (e) {
                    if (qlstadj_VerifCantPermitida('lstadjAdjuntos'))
                        $('#lstadjAdjuntos_F').click();
                    e.stopPropagation();
                    e.preventDefault();
                });
                $('#lstadjAdjuntos_F').on('change', function () {
                    QUpLoadAdv_UpLoadArchivoLista("lstadjAdjuntos", null);
                });
                $("#ctrtos9Producto_Id_1").igTextEditor(
                    {
                        width: "100px",
                        height: 21,
                        maxLength: 32767,
                        placeHolder: '',
                        value: '',
                        valueChanged: function (evt, ui) {
                            if (gValorAnt == "") {
                                ctrtos9Producto_Id_1_ValorModif(evt, ui);
                            }
                            gValorAnt = "";
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Productos');
                        },
                        keydown: function (evt, ui) {
                            if (evt.which == 120) {
                                ctrtos9Producto_Id_1_BotonClick(evt, ui);
                            }
                            else if (evt.which == 119) {
                                qpopup_MostrarForm('LCGfrmstkProductos', ui.editorInput[0].value, '', '', 'Productos', true)
                            }
                        },
                        textChanged: function (evt, ui) {
                            qcom_DeshabilitoAceptarPopup('Productos');
                        },
                    });
                $("#ctrtos9Producto_Id_d").igTextEditor(
                    {
                        width: "calc(99% - 121px)",
                        height: 21,
                        tabIndex: -1, readOnly: true
                    });
                $('#btn_ctrtos9Producto_Id').on('click', function () {
                    gValorAnt = "1";
                    ctrtos9Producto_Id_1_BotonClick(null, null);
                });
                function ctrtos9Producto_Id_MostrarLupa() {
                    QLupaAdv_MostrarLupa(gControles["Productos"][0]["Producto_Id"].getIdentidad(), "Productos", "Producto_Id", "DescripcionProducto", "", "", "", "", false, 'LCGfrmstkProductos', 'Productos');
                }
                function ctrtos9Producto_Id_ObtenerDesc() {
                    QLupaAdv_ObtenerDescripciones(gControles["Productos"][0]["Producto_Id"].getIdentidad(), "Productos", "Producto_Id", "DescripcionProducto", "", "", "", "", false, false);
                }
                function ctrtos9Producto_Id_1_ValorModif(evt, ui) {
                    qevt_Lupa_ValorModif(ctrtos9Producto_Id_ObtenerDesc, typeof accionLupa_ctrtos9Producto_Id !== 'undefined' ? accionLupa_ctrtos9Producto_Id : null, 'ctrtos9Producto_Id_Change');
                }
                function ctrtos9Producto_Id_1_BotonClick(evt, ui) {
                    qevt_Lupa_BotonClick(ctrtos9Producto_Id_MostrarLupa, typeof accionLupa_ctrtos9Producto_Id !== 'undefined' ? accionLupa_ctrtos9Producto_Id : null, 'ctrtos9Producto_Id_Change');
                }
                $("#ctrtos9Adicional").igTextEditor(
                    {
                        width: "calc(100% - 46px)",
                        height: 21,
                        readOnly: true,
                    });
                $('#btnctrtos9Adicional_Sel').on('click', function () {
                    $('#ctrtos9Adicional_F').click();
                });
                $('#btnctrtos9Adicional_Lim').on('click', function () {
                    QUpLoadAdv_LimpiarArchivo('ctrtos9Adicional');
                });
                gUpLoads["ctrtos9Adicional"] = '';
                $('#ctrtos9Adicional_F').on('change', function () {
                    if (typeof accionUpLoad_ctrtos9Adicional !== 'undefined' && jQuery.isFunction(accionUpLoad_ctrtos9Adicional))
                        QUpLoadAdv_UpLoadArchivo('ctrtos9Adicional', accionUpLoad_ctrtos9Adicional);
                    else
                        QUpLoadAdv_UpLoadArchivo('ctrtos9Adicional', null);
                });
                $(document).on('change', 'input[name="ctrtos9AdicionalC"]', function (event) {
                    if ((gEventos['ctrtos9AdicionalC_Change'] != 'undefined') && (gEventos['ctrtos9AdicionalC_Change'] != null)) {
                        qevt_AgregarEventoaTmp('ctrtos9AdicionalC_Change', null, false);
                        if (gEventosTmp.length == 1)
                            qevt_EjecutarSiguiente();
                    }
                });
                $("#ctrtos9AdicionalD").igNumericEditor(
                    {
                        width: "99%",
                        height: 21,
                        buttonType: 'clear',
                        dataMode: 'double',
                        value: 0,
                        disabled: false,
                        maxDecimals: 2,
                        minDecimals: 2,
                        minValue: -99999.99000000,
                        maxValue: 99999.99000000,
                        textChanged: function (evt, ui) {
                            if (gCtrlBlur != 'ctrtos9AdicionalD')
                                qcom_DeshabilitoAceptarPopup('Productos');
                            gCtrlBlur = '';
                        },
                        blur: function (evt) {
                            gCtrlBlur = 'ctrtos9AdicionalD';
                            qcom_HabilitoAceptarPopup('Productos');
                        },
                    });
                $("#ctrtos9AdicionalF").igDatePicker(
                    {
                        width: "99%",
                        height: 21,
                        dateInputFormat: "dd/MM/yyyy",
                        dateDisplayFormat: "dd/MM/yyyy",
                        locale: "es",
                        disabled: false,
                        value: new Date(2020, 8, 6),
                        dataMode: "date",
                        buttonType: "dropdown, clear",
                        textChanged: function (evt, ui) {
                            if (!gFechaBlur)
                                qcom_DeshabilitoAceptarPopup('Productos');
                            gFechaBlur = false;
                        },
                        focus: function (evt) {
                            gFechaBlur = false;
                        },
                        itemSelected: function (ui) {
                            qcom_DeshabilitoAceptarPopup('Productos');
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Productos');
                            gFechaBlur = true;
                        },
                        datepickerOptions: {
                            minDate: null,
                            maxDate: null,
                        },
                    });
                $("#ctrtos9AdicionalI").igNumericEditor(
                    {
                        width: "99%",
                        height: 21,
                        buttonType: 'clear',
                        dataMode: 'double',
                        value: 0,
                        disabled: false,
                        maxDecimals: 2,
                        minDecimals: 2,
                        minValue: -99999.99000000,
                        maxValue: 99999.99000000,
                        textChanged: function (evt, ui) {
                            if (gCtrlBlur != 'ctrtos9AdicionalI')
                                qcom_DeshabilitoAceptarPopup('Productos');
                            gCtrlBlur = '';
                        },
                        blur: function (evt) {
                            gCtrlBlur = 'ctrtos9AdicionalI';
                            qcom_HabilitoAceptarPopup('Productos');
                        },
                    });
                gGrillas["grdSeries"] = { Control: $("#grdSeries"), Tabla: "Series", NombreControl: "grdSeries", Visible: true, VisibleXPais: true, CamposPK: "", RegistrosPorPagina: 0, CampoAutonumerico: "", ValorPK: -1, ColIdEnEdicion: -1, RegistroPadre: null, ColumnaEnEdicion: "", FilasFiltradas: [], UltimaPK: 0, FilaaBorrar: 0, Editable: false, AutoFormateable: false, EsArbol: false, ColFmtNumFila: "", AnchoColFijas: "", FilasAMostrar: 0, ColumnasSoloLectura: '', ColumnasOcultas: '', ColumnasFijas: '', Contenedor: 'Solapa_1', ItemsMenuCtxt: [], ShortCut: 'T' };
                gGrillasAux[2] = "grdSeries";
                gGrillas["grdSeries"].ItemsMenuCtxt.push({ id: 'DisenioBoton7', title: 'DisenioBoton7', icon: 'fa fa-angle-right', disabled: false, visible: true, fn: qgrillas_EjecutarItemMenuCtxt });
                gGrillas["grdSeries"].ItemsMenuCtxt.push({ id: 'DisenioBoton8', title: 'DisenioBoton8', icon: 'fa fa-angle-right', disabled: false, visible: true, fn: qgrillas_EjecutarItemMenuCtxt });
                $("#grdSeries").igGrid(
                    {
                        autoGenerateColumns: false,
                        autofitLastColumn: true,
                        autoFormat: true,
                        renderCheckboxes: true,
                        disabled: false,
                        dataSource: null,
                        width: "100%",
                        heigth: "81px",
                        primaryKey: "IDCol",
                        autoCommit: true,
                        cellRightClick: function (evt, ui) {
                            qgrillas_MostrarMenuCtxt('grdSeries', ui, evt);
                            evt.preventDefault();
                            evt.stopPropagation();
                        },
                        columns: [
                            { headerText: "IDCol", key: "IDCol", dataType: "number", hidden: true },
                            { headerText: "Serie", key: "Serie", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "Adicional", key: "Adicional", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "AdicionalB", key: "AdicionalB", dataType: "bool", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "AdicionalC", key: "AdicionalC", dataType: "string", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda" },
                            { headerText: "AdicionalD", key: "AdicionalD", dataType: "number", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "0.00" },
                            { headerText: "AdicionalF", key: "AdicionalF", dataType: "date", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "dd-MM-yyyy", formatter: function (val, record) { return qcom_FormatearFechaGrilla2(val, ''); } },
                            { headerText: "AdicionalI", key: "AdicionalI", dataType: "number", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "0" },
                            { headerText: "Cantidad", key: "Cantidad", dataType: "number", columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "0" },
                            { headerText: "Renglón", key: "Renglon", dataType: "number", hidden: true },
                        ],
                        features: [
                            {
                                name: 'Selection',
                                mode: 'cell',
                                multipleSelection: false,
                                activation: true,
                                cellSelectionChanged: function (evt, ui) {
                                    qgrillas_SeleccionarCelda("grdSeries", ui.cell.rowIndex, ui.cell.rowId, ui.cell.columnKey, false);
                                }
                            },
                            {
                                name: "Filtering",
                                mode: "advanced",
                                advancedModeEditorsVisible: false,
                                filterSummaryAlwaysVisible: false,
                                columnSettings: [
                                    {
                                        columnKey: "Serie",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "Adicional",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "AdicionalB",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "AdicionalC",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "AdicionalD",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "AdicionalF",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "AdicionalI",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "Cantidad",
                                        allowFiltering: false
                                    },
                                    {
                                        columnKey: "Renglon",
                                        allowFiltering: false
                                    },

                                ]
                            },
                            {
                                name: "Resizing",
                                deferredResizing: false,
                                allowDoubleClickToResize: false,
                            },
                            {
                                name: "Responsive",
                                enableVerticalRendering: false,
                                reactOnContainerWidthChanges: true,
                                columnSettings: [{}]
                            },
                            {
                                name: "Updating",
                                enableAddRow: false,
                                enableDeleteRow: true,
                                startEditTriggers: ["dblclick", "enter"],
                                rowDeleting: function (evt, ui) {
                                    gGrillas["grdSeries"].FilaaBorrar = ui.rowID;
                                    if ((typeof validarfilaEliminada_grdSeries !== 'undefined') && (jQuery.isFunction(validarfilaEliminada_grdSeries))) {
                                        validarfilaEliminada_grdSeries(ui);
                                        return false;
                                    }
                                },
                                rowDeleted: function (evt, ui) {
                                    gGrillas["grdSeries"].FilaaBorrar = ui.rowID;
                                    if ((typeof filaEliminada_grdSeries !== 'undefined') && (jQuery.isFunction(filaEliminada_grdSeries))) {
                                        filaEliminada_grdSeries(ui);
                                        return false;
                                    }
                                },
                                editCellStarting: function (evt, ui) {
                                    if (gGrillas["grdSeries"].ColumnaEnEdicion == ui.columnKey) {
                                        qevt_Grilla_EditarFila('grdSeries', 0);
                                    }
                                    return false;
                                }
                            },
                        ]
                    });
                $('#lblgrdSeries').delegate("a", "click", function (e) {
                    qevt_Grilla_NuevaFila('grdSeries', true);
                    e.stopPropagation();
                    e.preventDefault();
                });
                gPopups['divGrupogrdProductos'] = new qcom_popup("divGrupogrdProductos", "", "EdicionFilaGrilla", "");
                gGruposGrilla['Productos'] = new qcom_controlGrupo("Solapa_1", false, true);
                $(document).delegate("#btnAceptargrdProductos", "focus", function (evt) {
                    qevt_Grilla_GuardarFila('grdProductos');
                });
                $(document).delegate("#btnAceptargrd2Productos", "focus", function (evt) {
                    if (!$("#ºbtnAceptargrd2Productos").is(":disabled"))
                        qevt_Grilla_GuardarFila('grdProductos');
                    else {
                        setTimeout(function () {
                            if (!$("#ºbtnAceptargrd2Productos").is(":disabled"))
                                qevt_Grilla_GuardarFila('grdProductos');
                        }, 1000);
                    }
                });
                $(document).delegate("#btnCancelargrdProductos", "click", function (evt) {
                    $('#divGrupogrdProductos').attr("Abierto", "false");
                    qgrillas_CancelarFila('grdProductos');
                });
                $('#divGrupogrdProductos').on('shown.bs.modal', function (event) {
                    qcom_HabilitoAceptarPopup('Productos');
                    $('#divGrupogrdProductos').attr("Abierto", "true");
                    gPilaPPs.push('Productos');
                    var lColumnaEnEdicion = gGrillas["grdProductos"].ColumnaEnEdicion;
                    if ((lColumnaEnEdicion != "") && (lColumnaEnEdicion != "Acciones")) {
                        $("#btnCancelargrdProductos").html(qrecCancelar);
                        gControles["Productos"][0][lColumnaEnEdicion].getControl().focus();
                    }
                    else {
                        $("#btnCancelargrdProductos").html(qrecCerrar);
                        var lControlFoco = qgrillas_ControlFoco("grdProductos");
                        lControlFoco.focus();
                    }
                });
                $('#divGrupogrdProductos').on('hidden.bs.modal', function (event) {
                    gPilaPPs.pop();
                    var lattr = $('#divGrupogrdProductos').attr("Abierto");
                    if (lattr == "true") {
                        qgrillas_CancelarFila('grdProductos');
                        if ($("#btnGuardar").is(":visible") && ($("#btnGuardar").is(":disabled"))) {
                            $('#btnGuardar')[0].disabled = false;
                        }
                        if ($("#btnPostear").is(":visible") && ($("#btnPostear").is(":disabled"))) {
                            $('#btnPostear')[0].disabled = false;
                        }
                    }
                });
                $('#divGrupogrdProductos').attr("Abierto", "false");
                gGraficosAux.push("grfGrafico1");
                gGraficos["grfGrafico1"] = { Tabla: "Grafico1", GrupoSeleccionado: '', SerieSeleccionada: '', NombreControl: "grfGrafico1", Visible: true, VisibleXPais: true, Tipo: "C", SubTipo: "bar", Titulo: "Pirmer Grafico", SubTitulo: "este es el subtitulo", TituloEjeValores: "Unidades", Alto: "200px", Leyenda: "abajo", CambiaSubTipo: true, ValoresASeparar: 0, FormatoDesc: "defecto", UbicacionDesc: "none" };
                $("#ctrcbogrfGrafico1").igCombo(
                    {
                        width: "100%",
                        height: 21,
                        dataSource: qtiposgrafcategoria,
                        textKey: 'Descripcion',
                        valueKey: 'Valor',
                        autoComplete: true,
                        disabled: false,
                        mode: 'dropdown',
                        placeHolder: 'seleccionar...',
                        enableClearButton: false,
                        multiSelection: {
                            enabled: false,
                            showCheckboxes: false
                        },
                        selectionChanged: function (evt, ui) {
                            var lRetVal = $("#ctrcbogrfGrafico1").igCombo("value");
                            gGraficos["grfGrafico1"].SubTipo = lRetVal;
                            graf_CargarGrafico("grfGrafico1");
                        }
                    });
                $("#ctrcbogrfGrafico1").igCombo("value", "bar"); gGraficosAux.push("grfGrafico2");
                gGraficos["grfGrafico2"] = { Tabla: "Grafico2", GrupoSeleccionado: '', SerieSeleccionada: '', NombreControl: "grfGrafico2", Visible: true, VisibleXPais: true, Tipo: "P", SubTipo: "pie", Titulo: "Título", SubTitulo: "Subtitulo", TituloEjeValores: "", Alto: "350px", Leyenda: "derecha", CambiaSubTipo: true, ValoresASeparar: 0, FormatoDesc: "lab_val", UbicacionDesc: "bestFit" };
                $("#ctrcbogrfGrafico2").igCombo(
                    {
                        width: "100%",
                        height: 21,
                        dataSource: qtiposgraftorta,
                        textKey: 'Descripcion',
                        valueKey: 'Valor',
                        autoComplete: true,
                        disabled: false,
                        mode: 'dropdown',
                        placeHolder: 'seleccionar...',
                        enableClearButton: false,
                        multiSelection: {
                            enabled: false,
                            showCheckboxes: false
                        },
                        selectionChanged: function (evt, ui) {
                            var lRetVal = $("#ctrcbogrfGrafico2").igCombo("value");
                            gGraficos["grfGrafico2"].SubTipo = lRetVal;
                            graf_CargarGrafico("grfGrafico2");
                        }
                    });
                $("#ctrcbogrfGrafico2").igCombo("value", "pie"); gGrupos[0] = new qcom_controlGrupo("DisenioGrupoInicio1", true, true);
                $("#ctries6Serie").igTextEditor(
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
                            qcom_DeshabilitoAceptarPopup('Series');
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                $("#ctries6Adicional").igTextEditor(
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
                            qcom_DeshabilitoAceptarPopup('Series');
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                $("#ctries6AdicionalC").igTextEditor(
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
                            qcom_DeshabilitoAceptarPopup('Series');
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                $("#ctries6AdicionalD").igNumericEditor(
                    {
                        width: "99%",
                        height: 21,
                        buttonType: 'clear',
                        dataMode: 'double',
                        value: 0,
                        disabled: false,
                        maxDecimals: 2,
                        minDecimals: 2,
                        minValue: -99999.99000000,
                        maxValue: 99999.99000000,
                        textChanged: function (evt, ui) {
                            if (gCtrlBlur != 'ctries6AdicionalD')
                                qcom_DeshabilitoAceptarPopup('Series');
                            gCtrlBlur = '';
                        },
                        blur: function (evt) {
                            gCtrlBlur = 'ctries6AdicionalD';
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                $("#ctries6AdicionalF").igDatePicker(
                    {
                        width: "99%",
                        height: 21,
                        dateInputFormat: "dd/MM/yyyy",
                        dateDisplayFormat: "dd/MM/yyyy",
                        locale: "es",
                        disabled: false,
                        value: new Date(2020, 8, 6),
                        dataMode: "date",
                        buttonType: "dropdown, clear",
                        textChanged: function (evt, ui) {
                            if (!gFechaBlur)
                                qcom_DeshabilitoAceptarPopup('Series');
                            gFechaBlur = false;
                        },
                        focus: function (evt) {
                            gFechaBlur = false;
                        },
                        itemSelected: function (ui) {
                            qcom_DeshabilitoAceptarPopup('Series');
                        },
                        blur: function (evt) {
                            qcom_HabilitoAceptarPopup('Series');
                            gFechaBlur = true;
                        },
                        datepickerOptions: {
                            minDate: null,
                            maxDate: null,
                        },
                    });
                $("#ctries6AdicionalI").igNumericEditor(
                    {
                        width: "99%",
                        height: 21,
                        buttonType: 'clear',
                        dataMode: 'double',
                        value: 0,
                        disabled: false,
                        maxDecimals: 2,
                        minDecimals: 2,
                        minValue: -99999.99000000,
                        maxValue: 99999.99000000,
                        textChanged: function (evt, ui) {
                            if (gCtrlBlur != 'ctries6AdicionalI')
                                qcom_DeshabilitoAceptarPopup('Series');
                            gCtrlBlur = '';
                        },
                        blur: function (evt) {
                            gCtrlBlur = 'ctries6AdicionalI';
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                $("#ctries6Cantidad").igNumericEditor(
                    {
                        width: "99%",
                        height: 21,
                        buttonType: 'clear',
                        dataMode: 'double',
                        value: 0,
                        disabled: false,
                        maxDecimals: 2,
                        minDecimals: 2,
                        minValue: -99999.99000000,
                        maxValue: 99999.99000000,
                        textChanged: function (evt, ui) {
                            if (gCtrlBlur != 'ctries6Cantidad')
                                qcom_DeshabilitoAceptarPopup('Series');
                            gCtrlBlur = '';
                        },
                        blur: function (evt) {
                            gCtrlBlur = 'ctries6Cantidad';
                            qcom_HabilitoAceptarPopup('Series');
                        },
                    });
                gPopups['divGrupogrdSeries'] = new qcom_popup("divGrupogrdSeries", "", "EdicionFilaGrilla", "");
                gGruposGrilla['Series'] = new qcom_controlGrupo("Solapa_3", false, true);
                $(document).delegate("#btnAceptargrdSeries", "focus", function (evt) {
                    qevt_Grilla_GuardarFila('grdSeries');
                });
                $(document).delegate("#btnAceptargrd2Series", "focus", function (evt) {
                    if (!$("#ºbtnAceptargrd2Series").is(":disabled"))
                        qevt_Grilla_GuardarFila('grdSeries');
                    else {
                        setTimeout(function () {
                            if (!$("#ºbtnAceptargrd2Series").is(":disabled"))
                                qevt_Grilla_GuardarFila('grdSeries');
                        }, 1000);
                    }
                });
                $(document).delegate("#btnCancelargrdSeries", "click", function (evt) {
                    $('#divGrupogrdSeries').attr("Abierto", "false");
                    qgrillas_CancelarFila('grdSeries');
                });
                $('#divGrupogrdSeries').on('shown.bs.modal', function (event) {
                    qcom_HabilitoAceptarPopup('Series');
                    $('#divGrupogrdSeries').attr("Abierto", "true");
                    gPilaPPs.push('Series');
                    var lColumnaEnEdicion = gGrillas["grdSeries"].ColumnaEnEdicion;
                    if ((lColumnaEnEdicion != "") && (lColumnaEnEdicion != "Acciones")) {
                        $("#btnCancelargrdSeries").html(qrecCancelar);
                        gControles["Series"][0][lColumnaEnEdicion].getControl().focus();
                    }
                    else {
                        $("#btnCancelargrdSeries").html(qrecCerrar);
                        var lControlFoco = qgrillas_ControlFoco("grdSeries");
                        lControlFoco.focus();
                    }
                });
                $('#divGrupogrdSeries').on('hidden.bs.modal', function (event) {
                    gPilaPPs.pop();
                    var lattr = $('#divGrupogrdSeries').attr("Abierto");
                    if (lattr == "true") {
                        qgrillas_CancelarFila('grdSeries');
                        if ($("#btnGuardar").is(":visible") && ($("#btnGuardar").is(":disabled"))) {
                            $('#btnGuardar')[0].disabled = false;
                        }
                        if ($("#btnPostear").is(":visible") && ($("#btnPostear").is(":disabled"))) {
                            $('#btnPostear')[0].disabled = false;
                        }
                    }
                });
                $('#divGrupogrdSeries').attr("Abierto", "false");

                $(document).delegate("#ctrInactivo", "click", function (evt) {
                    qevt_AgregarEventoaTmp('ctrInactivo_Click', null, true);
                });
                function ctrInactivo_Click_10000() {
                    qcom_ControlesaTablasPlanas();
                    qgrillas_ObtenerVariables('ObtenerVariablesCuerpo', 'grdPrincipal', null, 'Principal', false);

                }
                function ctrInactivo_Click_20000() {
                    var ltexto = 'Este es el Mensaje {0}';
                    ltexto = ltexto.replace('<0>', '{0}');
                    if (gVariables["var_MiFecha"].split(' ')[0].split('/').length == 3) qcom_Alerta(ltexto.replace('{0}', gVariables["var_MiFecha"].split(' ')[0]), 'info', 1);
                    else qcom_Alerta(ltexto.replace('{0}', gVariables["var_MiFecha"]), 'info', 1);
                }
                function ctrInactivo_Click_30000() {
                    var ltexto = 'este es el texto {0}';
                    ltexto = ltexto.replace('<0>', '{0}');
                    if (gVariables["var_EsMucho"].split(' ')[0].split('/').length == 3) qcom_Alerta(ltexto.replace('{0}', gVariables["var_EsMucho"].split(' ')[0]), 'info', 1);
                    else qcom_Alerta(ltexto.replace('{0}', gVariables["var_EsMucho"]), 'info', 1);
                }
                function ctrInactivo_Click_40000() {
                    var ltexto = 'esto es';
                    ltexto = ltexto.replace('<0>', '{0}');
                    if (gVariables["var_EsPoco"].split(' ')[0].split('/').length == 3) qcom_Alerta(ltexto.replace('{0}', gVariables["var_EsPoco"].split(' ')[0]), 'info', 1);
                    else qcom_Alerta(ltexto.replace('{0}', gVariables["var_EsPoco"]), 'info', 1);
                }
                function ctrnal9Impuesto_Id_Change_50000() {
                    qcom_AsignarValorControl(gControles["Principal"][0]["Descripcion"], "Pase", false);
                    qevt_EjecutarSiguiente();
                }
                function accionLupa_ctrPais_Id(evt) {
                    if ($("#ctrPais_Id_1").igTextEditor("value") != "") {
                        qevt_AgregarEventoaTmp('accionLupa_ctrPais_Id', null, true);
                    }
                }
                function accionLupa_ctrPais_Id_60000() {
                    qcom_ValorCamposClavesaPrincipal();
                    qcom_EjecutarAccion('Datos', true, false, '', null, 'null', '', '', '', false, true);

                }
                $(document).delegate("#ctrtos9AdicionalB", "click", function (evt) {
                    qevt_AgregarEventoaTmp('ctrtos9AdicionalB_Click', null, true);
                });
                function ctrtos9AdicionalB_Click_70000() {
                    var lValorFecha = qcom_ObtenerValorControl(gControles["Productos"][0]["AdicionalF"]).split('T')[0];
                    var larrfrmFecha = lValorFecha.split('-');
                    var lfmtFecha = (larrfrmFecha.length == 3) ? larrfrmFecha[2] + '/' + larrfrmFecha[1] + '/' + larrfrmFecha[0] : larrfrmFecha[0];
                    var ltexto = 'Este es el mensaje {0}'; ltexto = ltexto.replace('<0>', '{0}');
                    qcom_Alerta(ltexto.replace('{0}', lfmtFecha), 'info', 1);
                }
                $(document).delegate("#ctrtos9AdicionalD", "ignumericeditorvaluechanged", function (evt) {
                    qevt_AgregarEventoaTmp('ctrtos9AdicionalD_Change', null, true);
                });
                function ctrtos9AdicionalD_Change_80000() {
                    qcom_ControlesaTablasPlanas();
                    qgrillas_EjecutarAccionEnGrilla('AccionProducto', 'grdProductos', null, false, '', false);
                }
                function ctrtos9Producto_Id_Change_90000() {
                    var lValorFecha = qcom_ObtenerValorControl(gControles["Productos"][0]["AdicionalF"]).split('T')[0];
                    var larrfrmFecha = lValorFecha.split('-');
                    var lfmtFecha = (larrfrmFecha.length == 3) ? larrfrmFecha[2] + '/' + larrfrmFecha[1] + '/' + larrfrmFecha[0] : larrfrmFecha[0];
                    var ltexto = 'perico {0}'; ltexto = ltexto.replace('<0>', '{0}');
                    qcom_Alerta(ltexto.replace('{0}', lfmtFecha), 'info', 1);
                }
                $(document).delegate("#DisenioBoton2", "click", function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    qevt_AgregarEventoaTmp('DisenioBoton2_Click', null, true);
                });
                function DisenioBoton2_Click_100000() {
                    qcom_Alerta('dfsdf', 'info', 1);
                }
                $(document).delegate("#DisenioBoton5", "click", function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    qevt_AgregarEventoaTmp('DisenioBoton5_Click', null, true);
                });
                function DisenioBoton5_Click_110000() {
                    qcom_MostrarSolapa('Solapa_2');
                    qevt_EjecutarSiguiente();
                }
                function DisenioBoton5_Click_120000() {
                    $("#grdProductos").igGrid("showColumn", "AdicionalC");
                    qevt_EjecutarSiguiente();
                }
                function DisenioBoton5_Click_130000() {
                    graf_CargarGrafico("grfGrafico1");
                }
                function DisenioBoton5_Click_140000() {
                    graf_CargarGrafico("grfGrafico2");
                }
                function DisenioBoton5_Click_150000() {
                    qgrillas_VaciarGrilla("grdProductos");
                    qevt_EjecutarSiguiente();
                }
                $(document).delegate("#DisenioBoton6", "click", function (evt) {
                    evt.preventDefault();
                    evt.stopPropagation();
                    qevt_AgregarEventoaTmp('DisenioBoton6_Click', null, true);
                });
                function DisenioBoton6_Click_160000() {
                    qgrilla_AsignarTitulo('grdProductos', 'Producto_XX');
                }
                function DisenioBoton6_Click_170000() {
                    qgrilla_AsignarTituloCol('grdProductos', 'AdicionalB', 'Columna_XX');
                }
                function DisenioBoton6_Click_180000() {
                    qgrilla_AsignarTitulo('grdSinColumnas', 'Para_que');
                }
                function DisenioBoton6_Click_190000() {
                    if (qcom_existeControl('#DisenioBoton5')) {
                        $('#DisenioBoton5')[0].innerText = "Periquito";
                        qevt_EjecutarSiguiente();
                    }
                    else {
                        qgrillas_AsignarValorMenuCtxt('DisenioBoton5', "Periquito");
                        qevt_EjecutarSiguiente();
                    }
                }
                function DisenioBoton6_Click_210000() {
                    qcom_ControlesaTablasPlanas();
                    qcom_EjecutarDescargaArchivo('DescargarArchivoForm2', null, '', false);

                }
                function DisenioBoton6_Click_220000() {
                    qcom_Alerta('Despues de descargar', 'info', 1);
                }
                function guardarEntidad_230000() {
                    qcom_ControlesaTablasPlanas();
                    qcom_EjecutarAccion('Guardar', false, false, 'Operacion Exitosa', null, null, '', '', '', false, false);

                }
                function guardarEntidad_240000() {
                    var ltexto = 'Pedido <0> generado'; ltexto = ltexto.replace('<0>', '{0}');
                    qcom_Alerta(ltexto.replace('{0}', qcom_ObtenerValorControl(gControles["Principal"][0]["Descripcion"])), 'info', 1);
                }
                function Pegando_Form_250000() {
                    qcom_Alerta('este es el mensaje', 'info', 1);
                }
                function Post_Load() {
                    qevt_AgregarEventoaTmp('Post_Load', null, true);
                }
                function Post_Load_260000() {
                    qcom_OcultarSolapa('Solapa_2');
                    qevt_EjecutarSiguiente();
                }
                function rptimprimir_270000() {
                    qcom_Alerta('Imprimir', 'info', 1);
                }
                function rptpdf_280000() {
                    qcom_Alerta('Pdf', 'info', 1);
                }
                function rptver_290000() {
                    qcom_Alerta('Ver', 'info', 1);
                }
                function rptxls_300000() {
                    qcom_ControlesaTablasPlanas();
                    qcom_GeneraryDescargaXLSConParamDesdeServer('', 'ObtenerParametros', '', false);
                }
                function clickColumnaBoton_grdProductos(ui) {
                    qevt_AgregarEventoaTmp('grdProductos_ClickColumnaBoton', null, true);
                }
                function grdProductos_ClickColumnaBoton_310000() {
                    qcom_Alerta('pepe', 'info', 1);
                }
                function inicioNuevaFila_grdProductos() {
                    qevt_AgregarEventoaTmp('grdProductos_InicioNuevaFila', null, true);
                }
                function grdProductos_InicioNuevaFila_320000() {
                    var lcantDec = '1';
                    if ($.isNumeric(lcantDec)) {
                        qcom_AsignarCantDecimales(gControles["Productos"][0]["AdicionalD"], parseInt(lcantDec));
                        qcom_AsignarValorControl(gControles["Productos"][0]["AdicionalD"], qcom_ObtenerValorControl(gControles["Productos"][0]["AdicionalD"]), false);
                    } else {
                        qcom_Alerta('No se puede asignar el valor ' + lcantDec + ' como cantidad de decimales de un control', 'danger', null);
                    }
                    qevt_EjecutarSiguiente();
                }
                function grfGrafico1_Click_330000() {
                    graf_EjecutarAcccionEnGrafico('GraficoClick', 'grfGrafico1', '', 'Principal|SinColumnasSoloLect', false);
                }
                function grfGrafico1_Click_340000() {
                    qcom_Alerta('OK', 'info', 1);
                }
                function grfGrafico2_Click_350000() {
                    graf_EjecutarAcccionEnGrafico('GraficoClick', 'grfGrafico2', '', 'Principal|SinColumnasSoloLect', false);
                }
                function grfGrafico2_Click_360000() {
                    qcom_Alerta('Oki', 'info', 1);
                }
                function Activated_Solapa_2(ui) {
                    qevt_AgregarEventoaTmp('Solapa_2_Activated', null, true);
                }
                function Solapa_2_Activated_370000() {
                    qcom_Alerta('Siempre', 'info', 1);
                }
                function Activated1rst_Solapa_2(ui) {
                    qevt_AgregarEventoaTmp('Solapa_2_Activated1rsttime', null, true);
                }
                function Solapa_2_Activated1rsttime_380000() {
                    qcom_Alerta('Primera vezx', 'info', 1);
                }

                function qcom_ObtenerEstructuraEntidad_CallBack() {
                    qatrib_PrepararEspec();
                    gControles["Principal"][0]["Pais_Id"] = new qcom_control($("#ctrPais_Id_1"), 1, 1, '', true, true, true, "ctrPais_Id", true, "", true, 0, "pruPaises");
                    gControles["Principal"][0]["Descripcion"] = new qcom_control($("#ctrDescripcion"), 1, 1, '', true, true, true, "ctrDescripcion", false, "", true, 0, "");
                    gControles["Principal"][0]["Dominio_Id"] = new qcom_control($("#ctrDominio_Id_1"), 1, 1, '', true, true, true, "ctrDominio_Id", false, "", true, 0, "genDominios");
                    gControles["Principal"][0]["DescripcionDominios"] = new qcom_control($("#ctrDominio_Id_d"), 1, 1, '', true, true, false, "", false, "", true, 0, "");
                    gControles["Principal"][0]["PTodasEmpresas"] = new qcom_control($("#ctrPTodasEmpresas"), 4, 4, false, true, true, true, "ctrPTodasEmpresas", false, "", true, 0, "");
                    gControles["Principal"][0]["Inactivo"] = new qcom_control($("#ctrInactivo"), 4, 4, false, true, true, true, "ctrInactivo", false, "", true, 0, "");
                    gControles["Adicional"][0]["Impuesto_Id"] = new qcom_control($("#ctrnal9Impuesto_Id_1"), 1, 1, '', true, true, true, "ctrnal9Impuesto_Id", false, "", true, 0, "venImpuestos");
                    gControles["Adicional"][0]["DescripcionImpuesto"] = new qcom_control($("#ctrnal9Impuesto_Id_d"), 1, 1, '', true, true, false, "", false, "", true, 0, "");
                    gControles["Adicional"][0]["Adicional"] = new qcom_control($("#ctrnal9Adicional"), 12, 1, '', true, true, true, "ctrnal9Adicional", false, "", true, 0, "");
                    gControles["Productos"][0]["Producto_Id"] = new qcom_control($("#ctrtos9Producto_Id_1"), 1, 1, '', true, true, true, "ctrtos9Producto_Id", false, "", true, 0, "stkProductos");
                    gControles["Productos"][0]["DescripcionProducto"] = new qcom_control($("#ctrtos9Producto_Id_d"), 1, 1, '', true, true, false, "", false, "", true, 0, "");
                    gControles["Productos"][0]["Adicional"] = new qcom_control($("#ctrtos9Adicional"), 12, 1, '', true, true, true, "ctrtos9Adicional", false, "", true, 0, "");
                    gControles["Productos"][0]["AdicionalB"] = new qcom_control($("#ctrtos9AdicionalB"), 4, 4, false, true, true, true, "ctrtos9AdicionalB", false, "", true, 0, "");
                    gControles["Productos"][0]["AdicionalC"] = new qcom_control($("#ctrtos9AdicionalC"), 10, 1, '', true, true, true, "ctrtos9AdicionalC", false, "", true, 0, "");
                    gControles["Productos"][0]["AdicionalD"] = new qcom_control($("#ctrtos9AdicionalD"), 2, 2, 0, true, true, true, "ctrtos9AdicionalD", false, "", true, 0, "");
                    gControles["Productos"][0]["AdicionalF"] = new qcom_control($("#ctrtos9AdicionalF"), 3, 3, new Date(2020, 8, 6), true, true, true, "ctrtos9AdicionalF", false, "", true, 0, "");
                    gControles["Productos"][0]["AdicionalI"] = new qcom_control($("#ctrtos9AdicionalI"), 2, 2, 0, true, true, true, "ctrtos9AdicionalI", false, "", true, 0, "");
                    gControles["Series"][0]["Serie"] = new qcom_control($("#ctries6Serie"), 1, 1, '', true, true, true, "ctries6Serie", false, "", true, 0, "");
                    gControles["Series"][0]["Adicional"] = new qcom_control($("#ctries6Adicional"), 1, 1, '', true, true, true, "ctries6Adicional", false, "", true, 0, "");
                    gControles["Series"][0]["AdicionalB"] = new qcom_control($("#ctries6AdicionalB"), 4, 4, false, true, true, true, "ctries6AdicionalB", false, "", true, 0, "");
                    gControles["Series"][0]["AdicionalC"] = new qcom_control($("#ctries6AdicionalC"), 1, 1, '', true, true, true, "ctries6AdicionalC", false, "", true, 0, "");
                    gControles["Series"][0]["AdicionalD"] = new qcom_control($("#ctries6AdicionalD"), 2, 2, 0, true, true, true, "ctries6AdicionalD", false, "", true, 0, "");
                    gControles["Series"][0]["AdicionalF"] = new qcom_control($("#ctries6AdicionalF"), 3, 3, new Date(2020, 8, 6), true, true, true, "ctries6AdicionalF", false, "", true, 0, "");
                    gControles["Series"][0]["AdicionalI"] = new qcom_control($("#ctries6AdicionalI"), 2, 2, 0, true, true, true, "ctries6AdicionalI", false, "", true, 0, "");
                    gControles["Series"][0]["Cantidad"] = new qcom_control($("#ctries6Cantidad"), 2, 2, 0, true, true, true, "ctries6Cantidad", false, "", true, 0, "");

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
                    LupaNavegador_Inic();


                    $(window)[0].parent.qprin_AbrirSigForm();
                }
                qcom_ObtenerEstructuraEntidad(qcom_ObtenerEstructuraEntidad_CallBack);
                function EsteError(msg) { alert(msg); }

                qbas_InicializarMobile();
            });</script>
    </form>
</body>
</html>
