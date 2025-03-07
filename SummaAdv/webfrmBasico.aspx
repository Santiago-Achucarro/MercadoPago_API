<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmBasico.aspx.cs" Inherits="SummaWeb.webfrmBasico" %>

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
  <script type="text/javascript" src="Script/basicContext.min.js?v=<%=qversion%>"></script>
  <script type="text/javascript" src="Script/html2canvas.min.js?v=<%=qversion%>"></script>
    
    <%-- Estos son los includes para produccion --%>
  <%--<script type="text/javascript" src="Script/qvariables.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qdatos.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qlupaadv.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qlupasegadv.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/quploadadv.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qalertas.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qcomunes.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qeventos.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qpopup.min.js?v=<%=qversion %>"></script>
  <script type="text/javascript" src="Script/qgrillas.min.js?v=<%=qversion %>"></script>  
  <script type="text/javascript" src="Script/qatributosgenerales.min.js?v=<%=qversion %>"></script>  --%>

    
  <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>
 
    <%-- Estos son los includes para desarrollo sin version--%>
    <%--  <script type="text/javascript" src="ScriptDesa/qvariables.js"></script>
  <script type="text/javascript" src="ScriptDesa/qdatos.js"></script>
  <script type="text/javascript" src="ScriptDesa/qlupaadv.js"></script>
  <script type="text/javascript" src="ScriptDesa/qlupasegadv.js"></script>
  <script type="text/javascript" src="ScriptDesa/quploadadv.js"></script>
  <script type="text/javascript" src="ScriptDesa/qalertas.js"></script>
  <script type="text/javascript" src="ScriptDesa/qcomunes.js"></script>
  <script type="text/javascript" src="ScriptDesa/qeventos.js"></script>
  <script type="text/javascript" src="ScriptDesa/qpopup.js"></script>
  <script type="text/javascript" src="ScriptDesa/qgrillas.js"></script>  
  <script type="text/javascript" src="ScriptDesa/qatributosgenerales.js"></script>  --%>
</head>

<body>
    <form id="form1" runat="server">
        <div id="divCargando"></div>
        <div id="divPrincipal" class="container-fluid divPrincipalOculto">

            <div id="divMenu" class="quasar-divMenu">
                <div class="btn-group btn-group-md" style="padding: 5px;">
                    <button type="button" id="btnNuevo" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-file"></span></button>
                    <button type="button" id="btnGuardar" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-disk"></span></button>
                    <button type="button" id="btnPostear" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-saved"></span></button>
                    <button type="button" id="btnEliminar" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-floppy-remove"></span></button>
                    <%--<button type="button" id="btnImprimir" class="btn btn-primary quasar-mobile" data-toggle="tooltip" data-placement="bottom"><span class="glyphicon glyphicon-print"></span></button>--%>
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


                <%--<div class="btn-group btn-group-md" style="margin-left: auto; margin-right: 10px; padding: 5px; position: absolute; right: 0px;">--%>
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
<%--                <div class="btn-group btn-group-md quasar-lupa-navegacion" style="margin-left: auto; margin-right: 10px; padding: 5px; position: absolute; right: 90px;">--%>
                <div class="btn-group btn-group-md quasar-lupa-navegacion" style="padding: 5px; float:right">
                    <button type="button" id="btnLupaPrim" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-backward"></span></button>
                    <button type="button" id="btnLupaAnt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-backward"></span></button>
                    <button type="button" id="btnLupaSig" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-forward"></span></button>
                    <button type="button" id="btnLupaUlt" class="btn btn-info" data-toggle="tooltip" data-placement="bottom"><span class="fa fa-fast-forward"></span></button>
                </div>

              <div class="btn-group" style="left: 5px; top: -1px;">
                    <asp:PlaceHolder ID="phpSolapas" runat="server" />
	          </div>	
                <asp:PlaceHolder ID="PhProcesando" runat="server" />
            
            </div>    
            <div id="divAlertas" class="container-fluid">
                <%--                <div class="alert alert-danger alert-dismissable" style="padding-top:4px; padding-bottom:4px">
                    <a href="#" class="close" data-dismiss="alert" aria-label="close">×</a>
                        <strong>Danger!</strong> This alert box could indicate a dangerous or potentially negative action.
                </div>--%>
            </div>
            <div id="divMensajeExito">
            </div>
            <asp:PlaceHolder ID="phPrincipal" runat="server"></asp:PlaceHolder>
            <br/>
<%--        <div id="divMenuF" style="border-top-style: solid; border-top-color: #428bca; border-top-width: thin; padding-right: 10px">
                <div class="btn-group btn-group-md" style="padding: 5px">
                    <button type="button" id="btnNuevoF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-file"></span></button>
                    <button type="button" id="btnGuardarF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-floppy-disk"></span></button>
                    <button type="button" id="btnPostearF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-floppy-saved"></span></button>
                    <button type="button" id="btnEliminarF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-floppy-remove"></span></button>
                    <button type="button" id="btnImprimirF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-print"></span></button>
                    <button type="button" id="btnRptVerF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-hdd"></span></button>
                    <button type="button" id="btnRptImprimirF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-print"></span></button>
                    <button type="button" id="btnRptPdfF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-file"></span></button>
                    <button type="button" id="btnRptXlsF" class="btn btn-primary" data-toggle="tooltip" data-placement="top"><span class="glyphicon glyphicon-list-alt"></span></button>
                </div>
            </div>--%>
    
        </div>
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="container">            
          <div class="modal fade" id="divModalLupa" role="dialog">
            <div id="divModalLupaDlg" class="modal-dialog" style="max-width:80%; max-height:80%>
                  <!-- Modal content-->
              <div class="modal-content">
                <div id="headerModalLupa" class="modal-header btn-primary">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h6 id="tituloModalLupa" class="modal-title">Modal Header</h6>
        </div>
                        <%--                <div class="modal-body" id="divbtnGrillaLupa">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>--%>
                <div class="modal-body btn-primary" id="divGrillaLupa" tabindex="0">
        </div>
                        <%--                <div class="modal-footer btn-primary">
                  <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                </div>--%>
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
                        <%--                <div class="modal-footer btn-primary">
                  <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                </div>--%>
              </div>      
            </div>
          </div>
        </div>
        <div class="container">            
          <div class="modal fade" id="divModalUpLoad" role="dialog">
            <div class="modal-dialog">
              <div class="modal-content">
                        <%--                <div id="headerModalUpLoad" class="modal-header btn-primary">
                  <button type="button" class="close" data-dismiss="modal">&times;</button>
                  <h6 id="tituloModalUpLoad" class="modal-title">Modal Header</h6>
                </div>--%>
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
                          <%--<iframe id='ifrmform' src="" runat="server" class="quasar-iframe" />--%>
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
<%--        <div class="container">
            <div class="modal" id="divModalMail" role="dialog">
                <div id="divModalMailDlg" class="modal-dialog" style="max-width: 80%; max-height: 80%">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <!--div id="headerModalMail" class="modal-header btn-primary">
                            <h6 id="tituloModalMail" class="modal-title"></h6>
                        </div-->
                        <div class="modal-body btn-primary" id="divGrillaMail" tabindex="0">
                        </div>
                        <div class="modal-footer btn-primary">
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Enviar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>

<%--        <div id="divOpciones" class="dropdown-content" style="display: none; position: absolute; background-color: #f9f9f9; min-width: 160px; box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2); z-index: 1;">
            <a href="#">Link 1</a>
            <a href="#">Link 2</a>
            <a href="#">Link 3</a>
        </div>--%>
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


        <%--        <div class="container" id="dialoglupa" >            
        </div>
        <div  class="container" id="dialoglupaseg" >
        </div>
        <div  class="container" id="dialogupload" >
        </div>--%>    
        <%--        <script>
            function Modificar(grilla, clave, ptipo) {
                if (ptipo == 'U') {
                    var mode = $(grilla).igGridUpdating("option", "editMode");
                    $(grilla).igGridUpdating("option", "editMode", "dialog");
                    $(grilla).igGridUpdating("startEdit", clave, clave);
                }
                else {
                    $(grilla).igGridUpdating("option", "editMode", "dialog");
                    $(grilla).igGridUpdating("startAddRowEdit");

                }
            }
            function Agregar(grilla, clave) {
                $(grilla).igGridUpdating("option", "editMode", "dialog");
                $(grilla).igGridUpdating("startAddRowEdit");
            }

            function Borrar(grilla, clave) {
                $(grilla).igGridUpdating("deleteRow", clave);
            }
        </script>--%>
    </form>
</body>
</html>
