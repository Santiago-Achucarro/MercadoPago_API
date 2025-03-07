<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmPrincipal.aspx.cs" Inherits="SummaWeb.webfrmPrincipal" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title id="TituloAplicacion" runat="server" style="background-color: black">Summa Advanced (Ver <%=qversion%>)</title>
    <link id="favicon" rel="shortcut icon" type="image/png" href="imagenes/qiconnav.png" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
    <%--<meta name="apple-mobile-web-app-capable" content="yes" />--%>
    <link href="css/bootstrap.min.css?v=2.10.82" rel="stylesheet" />

    <link rel="stylesheet" href="css/font-awesome.min.css?v=2.10.82" />
    <!--link rel="stylesheet" href="css/fontawesome/css/all.min.css?v=2.10.82" /-->
    <link rel="stylesheet" href="css/basicContext.css?v=2.10.82" />
    <link rel="stylesheet" href="css/basicContext_dark.css?v=2.10.82" />

    <link rel="stylesheet" href="css/flatMenu.css?v=2.10.82" />
    <link href="css/themes/infragistics/infragistics.theme.css?v=2.10.82" rel="stylesheet" />
    <link href="css/structure/infragistics.css?v=2.10.82" rel="stylesheet" />
    <link rel="stylesheet" href="css/qprincipal.css?v=2.10.82" />

    <script src="Script/modernizr-2.6.2.js"></script>
    <script src="Script/jquery-1.10.2.min.js"></script>    
    <script src="Script/jquery-ui-1.12.0.min.js"></script>

    <script src="Script/bootstrap.min.js"></script>

    <script src="Script/Recursos/infragistics-es.js?v=2"></script>
    <script src="Script/infragistics.core.js?v=2"></script>
    <script src="Script/infragistics.lob.js?v=2"></script>
    <script src="Script/infragistics.dv.js?v=2"></script>

    <script src="Script/matchMedia.min.js"></script>
    <script src="Script/matchMedia.addListener.min.js"></script>
    <script src="Script/flatMenu.min.js?v=<%=qversion %>"></script>
    
    <script type="text/javascript" src="<%=qtipoversion%>/qvariables<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qdatos<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qlupaadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qlupasegadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/quploadadv<%=qextensionversion%>.js?v=<%=qversion %>"></script>

    <script type="text/javascript" src="<%=qtipoversion%>/qalertas<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qpopup<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qcomunes<%=qextensionversion%>.js?v=<%=qversion %>"></script>

    <script type="text/javascript" src="<%=qtipoversion%>/qeventos<%=qextensionversion%>.js?v=<%=qversion %>"></script>


    <script type="text/javascript" src="<%=qtipoversion%>/qnotificaciones<%=qextensionversion%>.js?v=<%=qversion %>"></script>
    <script type="text/javascript" src="<%=qtipoversion%>/qprincipal<%=qextensionversion%>.js?v=<%=qversion %>"></script>

    <script type="text/javascript" src="<%=qtipoversion%>/qgrillas<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qatributosgenerales<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qgraficos<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qlistaadjuntos<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qbasico<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qgrillaspivot<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="<%=qtipoversion%>/qindicadores<%=qextensionversion%>.js?v=<%=qversion %>"></script>  
    <script type="text/javascript" src="Script/basicContext.min.js?v=<%=qversion%>"></script>
    <script type="text/javascript" src="Script/html2canvas.min.js?v=<%=qversion%>"></script>

    <script type="text/javascript" src="Script/Recursos/qrecursos_es-AR.js?v=<%=qversion %>"></script>  

    <script type="text/javascript">


        jQuery(document).ready(function ($) {
            $('#menu-1').flatMenu({
                // desktop view settings
                logo_show: true,      // Options (true) or (false). This option is used to show or hide the logo.
                logo_align: 'left',    // Options (left) or (right). This option is used to align the logo left or right side of the screen.
                search_bar_show: true,      // Options (true) or (false). This option is used to show or hide the search bar.
                search_bar_align: 'right',   // Options (right) or (left). This option is used to align the search bar left or right side of the screen.
                icons_show: true,      // Options (true) or (false). This option is used to show or hide the menu items icons.
                social_icons_show: false,      // Options (true) or (false). This option is used to show or hide the social icons.
                social_icons_align: 'right',   // Options (right) or (left). This option is used to align the social icons left or right side of the screen.
                element_effects: 'fade',    // Options (fade), (sweep-to-right), (sweep-to-left), (sweep-to-top), (sweep-to-bottom), (bounce-to-right), (bounce-to-left), (bounce-to-top), (bounce-to-bottom), (radial-out), (rectangle-out), (shutter-out-horizontal), (shutter-out-vertical), (underline-from-left), (underline-from-center), (underline-from-right), (overline-from-left), (overline-from-center) or (overline-from-right). This option is used to change the menu items hover effects.
                top_bar_show: true,      // Options (true) or (false). This option is used to show or hide the menu top bar.
                separator_show: false,      // Options (true) or (false). This option is used to show or hide the vertical line between menu items.
                // drop down settings
                drop_down_trigger_in: 'hover',   // Options (click) or (hover). This option is used to show the drop down on mouse click or mouse hover.
                drop_down_trigger_out: 'hover',   // Options (click) or (hover). This option is used to hide the drop down on mouse click or mouse hover.
                //drop_down_effect               : 'fade',    // Options (fade), (sweep-to-right), (sweep-to-left), (sweep-to-top), (sweep-to-bottom) or (scale). This option is used to change the drop down animation.
                drop_down_effect_speed: 500,       // This option is used to change the drop down animation speed. Speed set in integer value
                drop_down_delay_in: 100,       // This option is used to change the drop down showing delay. Speed set in integer value.
                drop_down_delay_out: 1000,       // This option is used to change the drop down hiding delay. Speed set in integer value.
                drop_down_indicator_icon: 'fa-chevron-circle-right',    // This option is used to change the drop down indicator font-awesome icon. source: https://fortawesome.github.io/Font-Awesome/examples/.
                drop_down_overflow_hide: false,     // Options (true) or (false). This option is used to hide the long drop downs. Note: this option works on large or medium side drop downs.
                outside_click_hide_drop_down: true,      // Options (true) or  (false). This option is used to hide the showing drop downs when user click out side the menu.
                // sidebar settings
                sidebar_show: false,      // Options (true) or (false). This option is used to show or hide the side bar.
                sidebar_trigger: 'click',   // Options (click) or (hover). This option is used to show the side bar on mouse click or mouse hover.
                outside_click_hide_sidebar: true,      // Options (true) or (false). This option is used to hide the showing sidebar when user click outside the menu.
                // sticky header
                sticky_header_menu: false,     // Options (true) or (false). This option is used to make the menu sticky top of the screen on desktop view.
                sticky_header_height: 100,       // This option is used to change the sticky menu height top of the screen. It means when menu reach this height while scroll top to bottom.
                // mobile view settings
                logo_show_mobile: false,      // Options (true) or (false) This options used to show or hide the logo on mobile view.
                search_bar_show_mobile: false,      // Options (true) or (false) This option is used to show or hide the search bar on mobile view.
                icons_show_mobile: true,      // Options (true) or (false) This option is used to show or hide the menu items icons on mobile view.
                social_icons_show_mobile: false,      // Options (true) or (false) This option is used to show or hide the social icons on mobile view.
                top_bar_show_mobile: false,     // Options (true) or (false) This option is used to show or hide the top bar on mobile view.
                sidebar_show_mobile: false,      // Options (true) or (false) This option is used to show or hide the sidebar on mobile view.
                collapse_sub_menu_show: false,     // Options (true) or (false) This option is used to show or hide the menu on mobile view.
                sticky_header_menu_mobile: false,     // Options (true) or (false). This option is used to make the menu sticky top of the screen on mobile view.
                drop_down_indicator_icon_mobile: 'fa-chevron-circle-down' // This option is used to change the drop down indicator font-awesome icon on mobile view. source: https://fortawesome.github.io/Font-Awesome/examples/.
            });
        });
    </script>
   
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <input type="text" id="sesstrg" name="sesstrg" hidden="hidden" runat="server" />
            <input type="text" id="qcomponentes" name="qcomponentes" hidden="hidden" runat="server" />
            <div style="display: flex">
            <nav id="menu-1" class="flatMenu theme4">
                <!-- top bar -->
                 <asp:PlaceHolder ID="phMenu" runat="server"></asp:PlaceHolder>
            </nav>
            </div>
     <div   class="container-fluid">
                <div class="tab-content span4">
                    <div class="tab-pane active quasar-divFrame" id="home">
                        <iframe id="IfPrincipal" src="webfrmInicio.aspx" runat="server" class="quasar-iframe" style="overflow: hidden; height: 100%; width: 100%;" />
                    </div>
                </div>
            </div>
           <%--            <footer class="footer">
                <asp:PlaceHolder ID="phFooter" runat="server"></asp:PlaceHolder>
            </footer>--%>
        </div>
        <div class="modal fade quasar-ModalNotificacion" id="divNotificaciones" role="dialog">
            <div class="modal-dialog" style="width: 85%;">
                <div class="modal-content">
                    <div id="headerModalNotif" class="modal-header btn-info">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h5 id="tituloModalNotif" class="modal-title">Notificaciones</h5>
                    </div>
            
                    <div class="modal-body btn-info" id="divGrillaLupa">
                        <button type="button" id="btnBorrarTodos" class="btn btn-primary" title="Borrar Seleccionados"><span class="glyphicon glyphicon-trash"></span></button>
                        <table id='grdNotificaciones' style='min-width: 780px'></table>
                        <h4 id="SinNotif" class="modal-title">No Hay Notificaciones</h4>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal fade" id="divfrmAbiertos" role="dialog">
            <div class="modal-dialog" style="width: 80%">
                <div class="modal-content">
                    <div class="modal-body btn-primary" style="padding: 2px;">
                        <div id="lstFrmAbiertos" class="btn-group-vertical" style="width:100%">
                            <button type="button" class="btn quasar-btn-lstfrmabiertos" onclick="qprin_SelecfrmAbiertos('home', 'Inicio');">Inicio<span class="fa fa-refresh" style="right: 5px; position: absolute;"></span></button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal right fade" id="divInfoSsn" role="dialog">
            <div class="modal-dialog" style="width: fit-content; border-color: #2980b9;border-style: solid;border-width: thin;">
                <div class="modal-content">
                    <div class="modal-body btn-primary" style="background-color: #585858;" onclick="$('#divInfoSsn').modal('hide');">
                        <div>
                            <span style="font-size:14px"><i class="fa fa-building-o" style="font-size:14px; padding-right:4px"></i><span id="ctrlLblEmpresaMobile">Empresa</span><span id="ctrlLblSucursalMobile"> (Sucursal)</span></span>
                       </div><br />
                       <div>
                            <span style="font-size:14px"><i class="fa fa-user" style="font-size:14px; padding-right:4px"></i><span id="ctrlLblUsuarioMobile">Usuario</span></span>
                       </div><br />
                       <div>
                            <span style="font-size:14px"><i class="fa fa-sign-out" style="font-size:14px; padding-right:4px"></i><a href="Login.aspx" style="color:#fff">Cerrar Sesion</a></span> 
                       </div> 
                    </div>
                </div>
            </div>
        </div>




        <%--        <footer class="footer">
             <asp:PlaceHolder ID="phFooter" runat="server"></asp:PlaceHolder>
        </footer>--%>


        <script type='text/javascript'>
            var tabActual;
            var CantTabs = 0;
            var lEsChrome = qcom_EsChrome();
            var AbriendoForms = [];

            $(function () {
                if (sessionStorage.getItem("idses") != lIdSes) {
                    qcom_AlertaSesionInvalida();
                }
                qnotif_NotificacionesNoLeidas();
                var licon = "<%=qicono%>";
                if (licon != "")
                    $('#favicon').attr('href', licon);
                $("#tabFormsAbiertos").on("click", "a", function (e) {
                    e.preventDefault();

                    $(this).tab('show');
                    $tabActual = $(this);
                });

                
                window.addEventListener("storage", qprin_ActualizarBtnPegarEnFrm, false);

                if (lEsChrome)
                {
                $("#ctrTextoBusq").igTextEditor(
                {
                    width: "calc(99% - 25px)",
                    height: 21,
                    textMode: 'text',
                        placeHolder : qrecTextoaBuscar,
                    textChanged: function (evt, ui) {
                        if (ui.text.length > 4)
                            qprin_BuscarOpciones(ui.text);
                        else
                            $("#ulresBusqueda").empty();
                    },
                    blur: function (evt, ui) {
                    },
                    valueChanged: function (evt, ui) {
                    },
                });

                $('#btn_ctrTextoBusq').on('click', function () {
                    startRecording();
                });
                }
                else {
                    $("#ctrTextoBusq").igTextEditor(
                    {
                        width: "100%",
                        height: 21,
                        textMode: 'text',
                        placeHolder : qrecTextoaBuscar,
                        textChanged: function (evt, ui) {
                            if (ui.text.length > 4)
                                qprin_BuscarOpciones(ui.text);
                            else
                                $("#ulresBusqueda").empty();
                        },
                        blur: function (evt, ui) {
                        },
                        valueChanged: function (evt, ui) {
                        },
                    });
                }

                qcom_AbrirFormularioSolapa();
                var lDatosfrmusu = "<%=qfrmInicialUsuario%>";
                qprin_AbrirFrmInicialUsuario(lDatosfrmusu)
                qprin_RefrescarRecientes("");
                qprin_RefrescarFavoritos();
            });

            var lhandVoice = null;
            
            if (lEsChrome)
            {
                OpcionBusquedaxVoz();
            }

            function OpcionBusquedaxVoz() {
                lhandVoice = new webkitSpeechRecognition();

            lhandVoice.onresult = function(event) { 
                var lTexto = "";
                for (var i = event.resultIndex; i < event.results.length; i++) {
                    if (event.results[i].isFinal) {
                        lTexto += event.results[i][0].transcript;
                    } else {
                        lTexto += event.results[i][0].transcript;
                    }
                }
            
                $("#ctrTextoBusq").igTextEditor("value", lTexto);           
                qprin_BuscarOpciones(lTexto);
            }

            }

            function startRecording(){
                lhandVoice.start();
            }

            function sleep(milliseconds) {
                let timeStart = new Date().getTime();
                while (true) {
                    let elapsedTime = new Date().getTime() - timeStart;
                    if (elapsedTime > milliseconds) {
                        break;
                    }
                }
            } 

            
            //function CrearSolapa(pLink, pTitulo, pFormulario, pReferencia) {
            //    var tabId = "compose" + CantTabs; //this is id on tab content div where the 
            //    CantTabs = CantTabs + 1; //increment compose count
            //    if (pLink == "")
            //        pLink = "webfrmBasico.aspx?frm=" + pFormulario + "&pref=" + pReferencia;
            //    var lFuente = "<iframe id='" + tabId + "ifrm'  src=\"" + pLink + "\"";
            //    $('.nav-pills').append('<li><a href="#' + tabId + '"><button class="close closeTab" type="button" >x</button>' + pTitulo + '</a></li>');
            //    $('.tab-content').append('<div class="tab-pane quasar-divFrame" id="' + tabId + '"> </div>');
            //    $('#' + tabId).append(lFuente + ' runat="server" class="quasar-iframe"/>');
            //    //agrego a la lista de tabs de mobile
            //    $('#lstFrmAbiertos').append('<button id="' + tabId + 'btnlst" type="button" class="btn quasar-btn-lstfrmabiertos" onClick="qprin_SelecfrmAbiertos(\'' + tabId + '\', \'' + pTitulo + '\');">'+ pTitulo +'<span class="fa fa-refresh" style="right: 5px; position: absolute;"></span></button>');
            //    qprin_ActCantFormAbiertos();
            //    qprin_CambiarSelecListaFrm(pTitulo);
            //    //Cierro el menu
            //    $('#menu-1')[0].classList.remove('collapse-show');
            //    //Si hay un frm creandose, debo esperar un tiempito
            //    $(this).tab('show');
            //    $tabActual = $(this);
            //    showTab(tabId);
            //    registrarEventoCerrar();
            //    if ((pFormulario != undefined) && (pFormulario != ""))
            //        qprin_RefrescarRecientes(pFormulario);
            //    else {
            //        //debo obtener el nombre del formulario desde webfrmBasico.aspx?frm=frmgenProvincias&pref=....
            //        if (!pLink.startsWith('webfrmMensa')) {
            //            var lpartefin = pLink.substring(22);
            //            var lcompo = lpartefin.split('&');
            //            qprin_RefrescarRecientes(lcompo[0]);
            //        }
            //    }
            //}

            function setear_varsession() {
                var lNombreIfrm = "#compose0";
                $(lNombreIfrm + "ifrm")[0].contentWindow.gTieneSinGuardar = true;
            }

            //function registrarEventoCerrar() {

            //    $(".closeTab").click(function () {
            //        qprin_CerrarFormulario(this);
            //    });
            //}

            ////shows the tab with passed content div id..paramter tabid indicates the div where the content resides
            //function showTab(tabId) {
            //    $('#tabFormsAbiertos a[href="#' + tabId + '"]').tab('show');
            //}

            /****** Estos Métodos no se utilizan por ahora, pero pueden ser utiles para el manejo de solapas ****/
            ////return current active tab
            //function gettabActual() {
            //    return tabActual;
            //}

            ////this will return element from current tab
            ////example : if there are two tabs having  textarea with same id or same class name then when $("#someId") whill return both the text area from both tabs
            ////to take care this situation we need get the element from current tab.
            //function getElement(selector) {
            //    var tabContentId = $tabActual.attr("href");
            //    return $("" + tabContentId).find("" + selector);

            //}

            //function removetabActual() {
            //    var tabContentId = $tabActual.attr("href");
            //    $tabActual.parent().remove(); //remove li of tab
            //    $('#tabFormsAbiertos a:last').tab('show'); // Select first tab
            //    $(tabContentId).remove(); //remove respective tab content
            //}
            //window.onunload = function(){
            //    //qCerrarSesion();
            //    console.log('cerrado');
            //};

            window.onbeforeunload = function (e) {
                //primero verifico que todas las ventanas tengan la sesion valida
                //Si falla por sesion invalida, se debe cerrar si hacer la consulta
                
                var lSesionValida = gComponenteValido;//$('#qcomponentes').value;
                
                for (i = 1; i < $('#tabFormsAbiertos a').length && (lSesionValida) ; i++) {
                    // obtengo el nombre del iframe que estoy analizando
                    var lNombreIfrm = $('#tabFormsAbiertos a')[i].hash;
                    lSesionValida = $(lNombreIfrm + "ifrm")[0].contentWindow.SesionValida();
                }

                if (lSesionValida) {
                    //qcom_SetearEnServerSesStrg(false, false);
                    var lHaySinGuardar = false;

                    //var lTabs = $('#tabFormsAbiertos a');
                    for (i = 1; i < $('#tabFormsAbiertos a').length && (!lHaySinGuardar) ; i++) {
                        // obtengo el nombre del iframe que estoy analizando
                        var lNombreIfrm = $('#tabFormsAbiertos a')[i].hash;
                        //lHaySinGuardar = $(lNombreIfrm + "ifrm")[0].contentWindow.gTieneSinGuardar;
                        lHaySinGuardar = $(lNombreIfrm + "ifrm")[0].contentWindow.ConsultaxCambiosSinGuardar();

                    }
                    if (lHaySinGuardar) {
                        //qcom_SetearEnServerSesStrg(false, false);
                        var dialogText = qrefConfPerderCambios;
                        e.returnValue = dialogText;
                        return dialogText
                    }
                    else {
                        //qcom_SetearEnServerSesStrg(false, false);
                        var dialogText = qrefCierraSesion;
                        e.returnValue = dialogText;
                        return dialogText
                    }
                }
            };

            window.onunload = function (event) {
                sessionStorage.setItem("cerrosession", 's');
            };

            $('#btnBorrarTodos').click(function () {
                var lSeleccionados = $("#grdNotificaciones").igGridSelection("selectedRows");
                qnotif_BorrarNotificacionesSeleccionadas(lSeleccionados);
            });




            $("#grdNotificaciones").igGrid(
            {
                autoGenerateColumns: false,
                autofitLastColumn: true,
                autoFormat: true,
                renderCheckboxes: true,
                disabled: false,
                dataSource: null,
                width: "100%",
                heigth: "81px",
                primaryKey: "MensajeId",
                autoCommit: true,
                showHeader: true,
                rowsRendered: function (evt, ui) { qnotif_DiferenciarEstados(ui); },
                dataRendering: function (evt, ui) {
                    for (var i = 0; i < ui.owner.dataSource._data.length; i++) {
                        ui.owner.dataSource._data[i].Mensaje = qprin_FormatearTextoNotif(ui.owner.dataSource._data[i].Mensaje);
                        if (ui.owner.dataSource._data[i].Formulario_Id != '')
                            ui.owner.dataSource._data[i].Mensaje = "<label style='text-decoration:underline'><a data-formulario=" + ui.owner.dataSource._data[i].Formulario_Id + " data-parametros=" + ui.owner.dataSource._data[i].Parametros + " onClick=\"qnotif_VerEnFormulario(this)\">" + ui.owner.dataSource._data[i].Mensaje + "</a></label>";
                        else if (ui.owner.dataSource._data[i].Tipo != '')
                            ui.owner.dataSource._data[i].Mensaje =
                                "<label style='text-decoration:underline'><a data-subtipo=" + ui.owner.dataSource._data[i].SubTipo + " data-parametros=" + ui.owner.dataSource._data[i].Parametros + " onClick=\"qnotif_DescargarArchivo(this)\">" + ui.owner.dataSource._data[i].Mensaje + "</a></label>";
                    }
                },
                columns: [
                    { headerText: "MensajeId", key: "MensajeId", dataType: "number", hidden: true },
                    { headerText: "Emision", key: "FechaEmision", dataType: "date", format: "dd/MM/yyyy HH:mm", width:"140px"},
                    { headerText: "Usuario", key: "DescripcionUsuario", dataType: "string", hidden: true },
                    { headerText: "Leido", key: "FechaLeido", dataType: "date", hidden: true },
                    //{ headerText: "Mensaje", key: "Mensaje", dataType: "string" },
                    //No se usa el template, porque si el mensaje tiene saltos de linea, no se muestran
                    //{ headerText: "Mensaje", key: "Mensaje", dataType: "string", template: "{{if ${Formulario_Id} == '' && ${Tipo} == '' }} qprin_FormatearTextoNotif(${Mensaje}) {{elseif ${Formulario_Id} != ''}} <label style='text-decoration:underline'><a data-formulario=${Formulario_Id} data-parametros=${Parametros} onClick=\"qnotif_VerEnFormulario(this)\">${Mensaje}</a></label> {{else}} <label style='text-decoration:underline'><a data-subtipo=${SubTipo} data-parametros=${Parametros} onClick=\"qnotif_DescargarArchivo(this)\">${Mensaje}</a></label>{{/if}}" },
                    { headerText: "Mensaje", key: "Mensaje", dataType: "string" },
                    { headerText: "Usuario_Id", key: "Usuario_id", dataType: "string", hidden: true },
                    { headerText: "Leido", key: "Leido", dataType: "bool", hidden: true },
                    { headerText: "Formulario_Id", key: "Formulario_Id", dataType: "string", hidden: true },
                    { headerText: "Parametros", key: "Parametros", dataType: "string", hidden: true },
                    { headerText: "Tipo", key: "Tipo", dataType: "string", hidden: true },
                    { headerText: "SubTipo", key: "SubTipo", dataType: "string", hidden: true },
                    //{ headerText: "", key: "btnest_grdNotificaciones", dataType: "string", unbound: true, width: 25, template: "<label><a data-id=${MensajeId} onClick=\"qnotif_BorrarNotificacion(this)\"><i class=\"glyphicon glyphicon-trash\"></i></a></label>" },
                    { headerText: "", key: "btnest_grdNotificaciones", dataType: "string", unbound: true, width: 25, template: "{{if ${MensajeId} > 0 }}<label><a data-id=${MensajeId} onClick=\"qnotif_BorrarNotificacion(this)\"><i class=\"glyphicon glyphicon-trash\"></i></a></label>{{/if}}" },
                    //{ headerText: "", key: "btnver_grdNotificaciones", dataType: "string", unbound: true, width: 25, template: "{{if ${Formulario_Id} == '' }} '' {{else}} <label><a data-id=${MensajeId} onClick=\"qnotif_VerEnFormulario(this)\"><i class=\"glyphicon glyphicon-eye-open\"></i></a></label>{{/if}}" },
                ],
                features: [
                    {
                        name: "Resizing",
                        deferredResizing: false,
                        allowDoubleClickToResize: false,
                    },
                    {
                        name: "Selection",
                        multipleSelection: true,
                        mode: "row",
                        activation: true
                    },
                                                {
                        name: "Responsive",
                        enableVerticalRendering: false,
                        reactOnContainerWidthChanges: true,
                        columnSettings: [{}]
                        //windowWidthToRenderVertically: "700px",
                        //propertiesColumnWidth: "40%",
                        //valuesColumnWidth: "60%",
                    },
                    {
                        name: 'RowSelectors',
                        enableRowNumbering: false,
                        rowSelectorColumnWidth: 40,
                        enableCheckBoxes: true,
                        enableSelectAllForPaging: true,
                        //showCheckBoxesOnFocus: true
                    },
                ],
                    });

            setInterval(function notificacion() {
                qnotif_NotificacionesNoLeidas();
            }, 120000);

            //LLamo por primera vez si es que estoy en version de desarrollo
            //if (<%=qtiempov%> > 300000)
                qQuasarComponentes();
            setInterval(function notifcomponentes() {
                qQuasarComponentes();
            }, <%=qtiempov%>);

            //$(".nav-top-bar").hide();
            //setInterval(function notificacion() {
            //    qnotif_verifica();
            //}, 240000);

            //// When the user clicks anywhere outside of the modal, close it
            //window.onclick = function (event) {
            //    if (event.target == modal) {
            //        modal.style.display = "none";
            //    }
            //}
        </script>
    </form>
</body>

</html>
