//Nuevo Expresion jquery para busqueda de texto case insensitive
jQuery.expr[':'].containsCI = function (a, i, m) {
    /*verifico si vienen mas de una palabra a matchear*/
    if (m[3].trim() == "")
        return false;
    else {
        var lComp = m[3].split(' ');
        var lretorno = true;
        var lValorCtrl = qprin_QuitarAcentos(jQuery(a).text()).toLowerCase();
        for (var l = 0; l < lComp.length && lretorno; l++) {
            if (lComp[l] != "") {
                var lValorBusq = qprin_QuitarAcentos(lComp[l]).toLowerCase();
                //lretorno = jQuery(a).text().toUpperCase().indexOf(lComp[l].toUpperCase()) >= 0;
                lretorno = lValorCtrl.indexOf(lValorBusq) >= 0;
            }
        }
        return lretorno;
    }
};

var gFavoritos = [];
var gPortaPapelFrm = localStorage.getItem('PortaFrmFrm');
var gPortaPapelFrmNombre = localStorage.getItem('PortaFrmNombre');;
var gFormsxaAbrir = [];

function qprin_CrearSolapa(pLink, pTitulo, pFormulario, pReferencia) {
    //Voy encolando los formularios que se deben abrir. 
    //Hago esto por si desde recientes o favoritos, intentan abrir varios formularios en forma simultanea
    //Algunos de ellos, cuando ocurria esto no se dibujaban bien los controles
    gFormsxaAbrir.push({ Link: pLink, Titulo: pTitulo, Formulario: pFormulario, Referencia: pReferencia });
    if (gFormsxaAbrir.length == 1)
        qprin_CrearSolapaAux(pLink, pTitulo, pFormulario, pReferencia);
    else 
        qprin_ActFormEnRecientes(pFormulario, pLink)    
}

function qprin_CrearSolapaxaFrmEspec(pLink, pTitulo, pParametros) {
    if (pLink == 'webfrmMLConfig.aspx')
    {
        var lancho = $(window).width() * 0.90;
        var lalto = $(window).height() * 0.90;
        var lIdSes = sessionStorage.getItem("idses");
        var smFtr = "toolbar=yes,scrollbars=yes,resizable=yes,top=10,left=10,width=" + lancho + ",height=" + lalto;
        window.open(pLink + "?mlses=" + lIdSes, '_blank', smFtr);
    }
    else {
    //Este formulario especial no se va agregar por ahora ni a favoritos ni recientes
    var tabId = "compose" + CantTabs; //this is id on tab content div where the 
    CantTabs = CantTabs + 1; //increment compose count
        if (pParametros != "")
            pLink = "webfrmEspecial.aspx?qurl=" + pLink + "&" + pParametros;
        else
    pLink = "webfrmEspecial.aspx?qurl=" + pLink;
    var lFuente = "<iframe id='" + tabId + "ifrm'  src=\"" + pLink + "\"";
    $('.nav-pills').append('<li><a href="#' + tabId + '"><button class="close closeTab" type="button" >x</button>' + pTitulo + '</a></li>');
    $('.tab-content').append('<div class="tab-pane quasar-divFrame" id="' + tabId + '"> </div>');
    $('#' + tabId).append(lFuente + ' runat="server" class="quasar-iframe"/>');
    //agrego a la lista de tabs de mobile
    $('#lstFrmAbiertos').append('<button id="' + tabId + 'btnlst" type="button" class="btn quasar-btn-lstfrmabiertos" onClick="qprin_SelecfrmAbiertos(\'' + tabId + '\', \'' + pTitulo + '\');">' + pTitulo + '<span class="fa fa-refresh" style="right: 5px; position: absolute;"></span></button>');
    qprin_ActCantFormAbiertos();
    qprin_CambiarSelecListaFrm(pTitulo);
    //Cierro el menu
    $('#menu-1')[0].classList.remove('collapse-show');
    //Si hay un frm creandose, debo esperar un tiempito
    $(this).tab('show');
    $tabActual = $(this);
    qprin_showTab(tabId);
    qprin_registrarEventoCerrar();
   }
}



function qprin_AbrirSigForm() {
    gFormsxaAbrir.shift()
    if (gFormsxaAbrir.length > 0) {
        qprin_CrearSolapaAux(gFormsxaAbrir[0].Link, gFormsxaAbrir[0].Titulo, gFormsxaAbrir[0].Formulario, gFormsxaAbrir[0].Referencia);
    }
}


function qprin_CrearSolapaAux(pLink, pTitulo, pFormulario, pReferencia) {
    var tabId = "compose" + CantTabs; //this is id on tab content div where the 
    CantTabs = CantTabs + 1; //increment compose count
    if (pLink == "")
        pLink = "webfrmBasico.aspx?frm=" + pFormulario + "&pref=" + pReferencia;
    var lFuente = "<iframe id='" + tabId + "ifrm'  src=\"" + pLink + "\"";
    $('.nav-pills').append('<li><a href="#' + tabId + '"><button class="close closeTab" type="button" >x</button>' + pTitulo + '</a></li>');
    $('.tab-content').append('<div class="tab-pane quasar-divFrame" id="' + tabId + '"> </div>');
    $('#' + tabId).append(lFuente + ' runat="server" class="quasar-iframe"/>');
    //agrego a la lista de tabs de mobile
    $('#lstFrmAbiertos').append('<button id="' + tabId + 'btnlst" type="button" class="btn quasar-btn-lstfrmabiertos" onClick="qprin_SelecfrmAbiertos(\'' + tabId + '\', \'' + pTitulo + '\');">' + pTitulo + '<span class="fa fa-refresh" style="right: 5px; position: absolute;"></span></button>');
    qprin_ActCantFormAbiertos();
    qprin_CambiarSelecListaFrm(pTitulo);
    //Cierro el menu
    $('#menu-1')[0].classList.remove('collapse-show');
    //Si hay un frm creandose, debo esperar un tiempito
    $(this).tab('show');
    $tabActual = $(this);
    qprin_showTab(tabId);
    qprin_registrarEventoCerrar();
    if ((pFormulario != undefined) && (pFormulario != ""))
        qprin_RefrescarRecientes(pFormulario);
    else {
        //debo obtener el nombre del formulario desde webfrmBasico.aspx?frm=frmgenProvincias&pref=....
        if (!pLink.startsWith('webfrmMensa')) {
            var lpartefin = pLink.substring(22);
            var lcompo = lpartefin.split('&');
            qprin_RefrescarRecientes(lcompo[0]);
        }
    }
}

//shows the tab with passed content div id..paramter tabid indicates the div where the content resides
function qprin_showTab(tabId) {
    $('#tabFormsAbiertos a[href="#' + tabId + '"]').tab('show');
}


function qprin_registrarEventoCerrar() {

    $(".closeTab").click(function () {
        qprin_CerrarFormulario(this);
    });
}


function qprin_AbrirFrmInicialUsuario(pDatosFrmInicUsu) {
    if (pDatosFrmInicUsu != "") {
        var lCompo = pDatosFrmInicUsu.split('|');
        qprin_CrearSolapa("webfrmBasico.aspx?frm=" + lCompo[0] + "&pref=" + lIdSes, lCompo[1]);
    }
}


function qprin_RefrescarFavoritos() {

    var lIdSes = sessionStorage.getItem("idses");
    var lData = {pIdSes: lIdSes };
    $.ajax({
        type: "POST",
        //todo ver gsitio
        //url: "webfrmPrincipal.aspx/ObtenerFavoritosUsuario",
        url: "AjaxHandler/frmPrincipal.ashx?pTipo=FAV",
        //contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (data.e == undefined) {
            $("#lstFavoritos").empty();
            gFavoritos = [];
            if (data.d != "") {
                var lDatos = JSON.parse(data.d);
                for (var i = 0; i < lDatos.Formularios.length; i++) {
                    var lhref = "javascript:qprin_CrearSolapa('webfrmBasico.aspx?frm=" + lDatos.Formularios[i].Formulario_Id + "&pref=" + lIdSes + "', '" + lDatos.Formularios[i].Titulo + "');";
                    $("#lstFavoritos").append('<li><a href="' + lhref + '"><i class=\"fa fa-star favorito\"></i>' + lDatos.Formularios[i].Modulo + ' - ' + lDatos.Formularios[i].Titulo + '</a></li>');
                    gFavoritos.push(lDatos.Formularios[i].Formulario_Id);
                }
            }
            //if (gFavoritos.length == 0)
            //{
            //    $("#opcFavoritos").hide();
            //}
            //else
            //{
            //    $("#opcFavoritos").show();
            //}

            }
            else
            qcom_TratarError(data.e);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
};



function qprin_RefrescarRecientes(pFormulario) {

    var lIdSes = sessionStorage.getItem("idses");
    var lData = {pFormulario: pFormulario, pIdSes: lIdSes };
    $.ajax({
        type: "POST",
        //todo ver gsitio
        //url: "webfrmPrincipal.aspx/ObtenerFavoritosUsuario",
        url: "AjaxHandler/frmPrincipal.ashx?pTipo=REC",
        //contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
        .done(function (data) {
            if (data.e == undefined) {
                $("#lstRecientes").empty();
                if (data.d != "") {
                    var lDatos = JSON.parse(data.d);
                    for (var i = 0; i < lDatos.Formularios.length; i++) {
                        var lhref = "javascript:qprin_CrearSolapa('webfrmBasico.aspx?frm=" + lDatos.Formularios[i].Formulario_Id + "&pref=" + lIdSes + "', '" + lDatos.Formularios[i].Titulo + "');";
                        $("#lstRecientes").append('<li><a href="' + lhref + '"><i class="fa fa-caret-right reciente"></i>' + lDatos.Formularios[i].Modulo + ' - ' + lDatos.Formularios[i].Titulo + '</a></li>');
                    }
            }
        }
        else
            qcom_TratarError(data.e);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
};

function qprin_ActFormEnRecientes(pFormulario, pLink) {
    var lFormulario = "";
    if ((pFormulario != undefined) && (pFormulario != ""))
        lFormulario = pFormulario;
    else {
        //debo obtener el nombre del formulario desde webfrmBasico.aspx?frm=frmgenProvincias&pref=....
        if (!pLink.startsWith('webfrmMensa')) {
            var lpartefin = pLink.substring(22);
            var lcompo = lpartefin.split('&');
            lFormulario = lcompo[0];
        }
    }
    var lEncontre = false;
    for (var i = 0; i < $("#lstRecientes").children().length && (!lEncontre); i++) {
        
        if ($("#lstRecientes").children()[i].innerHTML.contains(lFormulario + '&')) {
            $("#lstRecientes").children()[i].innerHTML = $("#lstRecientes").children()[i].innerHTML.replace("fa-caret-right", "fa-spinner");
            lEncontre = true;
        }
    }
}


function qprin_CambiarFavoritos(pNombreFormulario, pNuevoEstado) {

    qprin_RefrescarFavoritos();

    for (i = 1; i < $('#tabFormsAbiertos a').length; i++) {
        // Tengo setear el mismo valor en todos los formularios que sean iguales al actual
        if ($('#tabFormsAbiertos a')[i].hash != $tabActual.hash) {
            var lNombreIfrm = $('#tabFormsAbiertos a')[i].hash;
            var lNombreForm = $(lNombreIfrm + "ifrm")[0].contentWindow.gConfiguracion.getFormulario();
            if (lNombreForm == pNombreFormulario)
                $(lNombreIfrm + "ifrm")[0].contentWindow.qcom_CambiarEstadoFavorito(pNuevoEstado)
        }

    }
}

function qprin_EsFavorito(pNombreFormulario) {
    var lesFavorito = false;
    for (var i = 0; i < gFavoritos.length && (!lesFavorito) ; i++) {
        lesFavorito = (gFavoritos[i] == pNombreFormulario);
    }
    return lesFavorito;
}

function qprin_SetearInfoSsn(pUsuario, pEmpresa, pSucursal) {
    $("#ctrlLblUsuarioMobile")[0].innerText = pUsuario;
    $("#ctrlLblEmpresaMobile")[0].innerText = pEmpresa;
    $("#ctrlLblSucursalMobile")[0].innerText = " (" + pSucursal + ")";

}


function qprin_CambiarSucursal(pSucursal) {
    $("#ctrlLblSucursal")[0].innerText = " (Suc: " + pSucursal + ")";
    $("#ctrlLblSucursalMobile")[0].innerText = " (" + pSucursal + ")";
}

function qprin_MostrarBusqueda() {
    $("#divBusqMenu").modal({
        keyboard: true,
        tabindex: -1,
        backdrop: "static",
        show: true
    });
    $("#divBusqMenu").draggable({
        handle: ".modal-header"
    });

}

function qprin_QuitarAcentos(pTexto) {
    var lmapObj = {
        "é": 'e',
        "ó": 'o',
        "í": 'i',
        "ú": 'ú',
        "á": 'a',
        "ç": 'c'
        //and so on...      
    }
    pTexto = pTexto.replace(/[éóíúáç]/g, match => lmapObj[match]);
    return pTexto;
}


function qprin_BuscarOpciones(pTexto) {

    var lModulos = $(".quasar-menu-nodo-modulo");
    $("#ulresBusqueda").empty();
    for (var j = 0; j < lModulos.length; j++) {
        var lOpciones = $("#" + lModulos[j].id + " .quasar-menu-hoja:containsCI('" + pTexto + "')");
        var lNombModelo = $("#a" + lModulos[j].id);

        for (var i = 0; i < lOpciones.length; i++) {
            var lhref1 = lOpciones[i].onclick;
            //tengo que armar la invocación javascript
            var lhref = lhref1.toString().split('javascript')[1].split(';')[0];
            $("#ulresBusqueda").append('<li><a href="javascript' + lhref + '"><span class="tab">' + lNombModelo.text() + " - " + lOpciones[i].text + '</span></a></li>');
        }
    }
}

function qprin_MostrarfrmAbiertos() {
    if ($('#divfrmAbiertos').is(':visible'))
        $('#divfrmAbiertos').modal('hide');
    else {

        //$('#divfrmAbiertos').on('show.bs.modal', function () {
        //    //cambio la posición de la ventana
        //    var lPosDerBtn = $("#btnSelectFrmAbierto").offset().left + $("#btnSelectFrmAbierto").width();
        //    var lAnchoOpciones = $("#lstFrmAbiertos").width();
        //    $('#divOpciones').css("left", lPosDerBtn - lAnchoOpciones);
        //});

        ////quito los eventos, porque sino los va acumulando en cada llamado
        //$('#divfrmAbiertos').on('hidden.bs.modal', function () {
        //    $("#divfrmAbiertos").off("show.bs.modal");
        //    $("#divfrmAbiertos").off("hidden.bs.modal");
        //});

    $("#divfrmAbiertos").modal({
        keyboard: true,
        tabindex: -1,
            backdrop: true,
        show: true
    });
    }
}

function qprin_CerrarfrmAbiertos() {
    $("#divfrmAbiertos").modal('hide');

}

function qprin_SelecfrmAbiertos(pNombre, pTitulo) {
    qprin_CerrarfrmAbiertos();
    qprin_showTab(pNombre);
    qprin_CambiarSelecListaFrm(pTitulo);
}


function qprin_CambiarSelecListaFrm(pTitulo) {
    $("#ctrlTitFrmAbierto")[0].innerText = pTitulo;
}


function qprin_CerrarFormulario(pthis) {
    var lCierro = true;
    var tabContentId = null;
    if (pthis != null)
        tabContentId = $(pthis).parent().attr("href");
    else
        //busco la solapa actual
        tabContentId = $('ul#tabFormsAbiertos li.active').children(0).attr("href");

    //if ($(tabContentId + "ifrm")[0].contentWindow.gTieneSinGuardar)
    if ($(tabContentId + "ifrm")[0] != null) {
        if (($(tabContentId + "ifrm")[0].contentWindow.ConsultaxCambiosSinGuardar != null) &&
            ($(tabContentId + "ifrm")[0].contentWindow.ConsultaxCambiosSinGuardar != undefined)) {
            if ($(tabContentId + "ifrm")[0].contentWindow.ConsultaxCambiosSinGuardar())
                lCierro = confirm(qrefConfPerderCambios);
        }
        //there are multiple elements which has .closeTab icon so close the tab whose close icon is clicked
        if (lCierro) {
            if (pthis != null)
                $(pthis).parent().parent().remove(); //remove li of tab
            else
                $('ul#tabFormsAbiertos li.active').remove();
            $(tabContentId + 'btnlst')[0].remove(); //quito el boton de la lista para mobile
            qprin_ActCantFormAbiertos();
            var lTitulo = $('#tabFormsAbiertos a:last')[0].innerText;
            //if (lTitulo.startsWith('x'))
            if ((lTitulo.charCodeAt(0)==215)|| (lTitulo.charCodeAt(0)==120))
                lTitulo = lTitulo.substring(1, lTitulo.length);
            qprin_CambiarSelecListaFrm(lTitulo);
            $('#tabFormsAbiertos a:last').tab('show'); // Select first tab
            $(tabContentId).remove(); //remove respective tab content
        }
    }

}


function qprin_MostrarInfoSSN() {    
        $("#divInfoSsn").modal({
            keyboard: true,
            tabindex: -1,
            backdrop: false,
            show: true
        });
}

function qprin_ActCantFormAbiertos() {
    var lFrms = $(".quasar-btn-lstfrmabiertos");    
    $("#ctrlCantFormAbiertos").text(lFrms.length);
}


function qprin_CopiarfrmaPortapapel(pEntidad, pNombreFrm) {
    //gPortaPapelFrm = pEntidad;
    //gPortaPapelFrmNombre = pNombreFrm;
    localStorage.setItem('PortaFrmFrm', pEntidad);
    localStorage.setItem('PortaFrmNombre', pNombreFrm);;
    

    //Debo habilitar el boton de pegar en formularios abiertos igual al formulario que se copió, y deshabilitarlos en el resto
    qprin_ActualizarBtnPegarEnFrm();
}

function qprin_CopiarPortapapelaFrm(pNombrefrm) {

    //if (pNombrefrm != gPortaPapelFrmNombre)
    //    return null
    //else 
    //    return gPortaPapelFrm;
    if (pNombrefrm != localStorage.getItem('PortaFrmNombre'))
        return null;
    else {

        //var lEntidad = JSON.parse(localStorage.getItem('PortaFrmFrm'));
        //return lEntidad;
        return localStorage.getItem('PortaFrmFrm');
    }
}


function qprin_ActualizarBtnPegarEnFrm() {
    var lPortaPapelFrmNombre= localStorage.getItem('PortaFrmNombre');
    for (i = 1; i < $('#tabFormsAbiertos a').length; i++) {
        // Tengo setear el mismo valor en todos los formularios que sean iguales al actual
        if ($('#tabFormsAbiertos a')[i].hash != $tabActual.hash) {
            var lNombreIfrm = $('#tabFormsAbiertos a')[i].hash;
            if ($(lNombreIfrm + "ifrm")[0] != undefined) {
                if ($(lNombreIfrm + "ifrm")[0].contentWindow != undefined) {
                    if ($(lNombreIfrm + "ifrm")[0].contentWindow.gConfiguracion != undefined) {
            var lNombreForm = $(lNombreIfrm + "ifrm")[0].contentWindow.gConfiguracion.getFormulario();
                        if (lNombreForm == lPortaPapelFrmNombre)
                $(lNombreIfrm + "ifrm")[0].contentWindow.qcom_CambiarVisibilidadBtnPegar(true);
            else
                $(lNombreIfrm + "ifrm")[0].contentWindow.qcom_CambiarVisibilidadBtnPegar(false);
        }
                }
            }
        }

    }
}


function qprin_ObtenerNombreFrmPortaPapel() {
    //return gPortaPapelFrmNombre;
    return localStorage.getItem('PortaFrmNombre');
}

function qprin_ObtenerFrmPortaPapel() {
    return localStorage.getItem('PortaFrmFrm');
}

function qprin_FormatearTextoNotif(pValor) {
    return pValor.replace(/\\n/g, '<br/>');
}


function qprin_QuitarCortina() {
    for (i = 1; i < $('#tabFormsAbiertos a').length; i++) {
        if (($('#tabFormsAbiertos a')[i].parentNode != undefined) && ($('#tabFormsAbiertos a')[i].parentNode != null)) {
            if ($('#tabFormsAbiertos a')[i].parentNode.className == "active") {
                var lNombreIfrm = $('#tabFormsAbiertos a')[i].hash;
                if ($(lNombreIfrm + "ifrm")[0] != undefined) {
                    if ($(lNombreIfrm + "ifrm")[0].contentWindow != undefined) {
                        $(lNombreIfrm + "ifrm")[0].contentWindow.qcom_QuitarCortina();
                    }
                }
            }
        }
    }
}