//Inicio - quitado por error en quitar cortina
//var gzindexpopup = 0;
var gzindexpopup = 1080;
//Fin

var qcom_popup = function (pNombre, pParametros, pTipo, pTamanio) {
    var _Nombre = pNombre;
    var _Parametros = pParametros;
    var _Tipo = pTipo;
    var _Tamanio = pTamanio;
    this.getNombre = function () { return _Nombre };
    this.getParametros = function () { return _Parametros };
    this.getTipo = function () { return _Tipo };
    this.getTamanio = function () { return _Tamanio };
    
}

function qpopup_Mostrar(pNombre, pOcultar) {
    var lSolapa = gPopups[pNombre];
    if ((!pOcultar) && (!($('#' + pNombre).is(':visible')))) {
        qpopup_Abrir(pNombre, lSolapa.getParametros(), '');
        qevt_EjecutarSiguiente();
    }
    else if ((pOcultar) && ($('#' + pNombre).is(':visible'))) {
        $("#" + pNombre).modal('hide');
        //Inicio - quitado por error en quitar cortina
        //qpopup_ZIndexLiberar();
        //Fin
        qevt_EjecutarSiguiente();
    }
    else {
        if (!pOcultar) {
            qevt_EjecutarSiguiente();
    }
        else
        {
            //Inicio - quitado por error en quitar cortina
            //qpopup_ZIndexLiberar();
            //Fin
        }
    }

    //    qpopup_Cerrar(pNombre, lSolapa.getParametros(), '');
}

function qpopup_Abrir(pNombre, pParametros, pNombreGrilla) {
    //Debo asignar valor a los parametros
    //qcom_AsignarValorParametrosPopup(pParametros, pGrilla);
    qpopup_AsignarValorParametrosPopup(pParametros, '');

    qpopup_ZIndexAsignar($("#" + pNombre));

    $("#" + pNombre).modal({
        keyboard: true,
        tabindex: -1,
        backdrop: "static",
        focus: true,
        show: true
    });
    $("#" + pNombre).draggable({
        handle: ".modal-header"
    });
    $("#" + pNombre).unbind('dragstop');
    $("#" + pNombre).on("dragstop", function (event, ui) {
        var lScroll = window.pageYOffset !== undefined ? window.pageYOffset : window.scrollTop;
        if (ui.helper[0].offsetTop < 0) {
            if (lScroll > 0)
                $("#" + pNombre).offset({ top: lScroll, left: ui.helper[0].offsetLeft });
            else
                $("#" + pNombre).offset({ top: 0, left: ui.helper[0].offsetLeft });
        }
        else if (lScroll > 0)
                $("#" + pNombre).offset({ top: lScroll, left: ui.helper[0].offsetLeft }); 

    })
    $("#" + pNombre).on("shown.bs.modal", function () {
        qevt_AgregarEventoaTmp(pNombre + '_MostrandoPopup', null, true);
    });
}


/******* Filtros Lupas y segmentos ********/
function qpopup_AsignarValorParametrosPopup(pParametros, pGrilla) {
    pParametros = pParametros || "";
    if (pParametros != "") {
        var lParametros = pParametros.split("@");
        var lSeparador = '';
        for (var j = 0; j < lParametros.length; j++) {
            lParametro = lParametros[j].split(";");
            lValor = qcom_ObtenerValorParametroFiltro(lParametro[1], pGrilla);
            $("#" + lParametro[0]).igTextEditor("value", lValor);
        }
    }
}

/******** Popup invocacion a formulario ****************/
function qpopup_MostrarFormGral(pNombreForm,  pValor, pControl, pColumna, pTitulo, pSoloLectura, pNuevoElemLupa, pEsCasoParticular) {
    var lIdentif = "";
    var lIdSes = sessionStorage.getItem("idses");
    //Si el valor se encuentra en una columna de una grilla, debo verificar que haya una fila seleccionada en la grilla
    // y obtener el valor de esa grilla
    if ((pControl != "") && (pColumna != ""))
    {
        var lNombreTabla = "";
        var lPos = -1;
        if (gGrillas[pControl] != undefined)
            lNombreTabla = gGrillas[pControl].Tabla;
        if (lNombreTabla != '') {
            //Obtengo la fila en donde se encuentra parado
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1) ; i++) {
                if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pControl].ValorPK) {
                    lPos = i;
                    lIdentif = gEntidad[lNombreTabla][i][pColumna];
                }
            }
        }
        if (lPos <= -1) {
            //qevt_VaciarEventosTmp(); //No es necesario cortar las acciones del evento, ya que este es un 
            //form que se abre en su propia ventana
            qcom_Alerta(qrecSinFilaSelec, 'danger', null);
        }
    }
    else   //si no está en una grilla, el valor viene como parámetro
    {
        lIdentif = pValor;
    }

    if ((lIdentif.trim() != "") || (!pSoloLectura)){
        var lsololect = pSoloLectura?"t":"f";
        var pLink = "webfrmBasico.aspx?frm=" + pNombreForm + "&pref=" + lIdSes + "&pI=" + lIdentif.trim() + "&pEP=t&pS="+ lsololect;
        var lFuente = "<iframe id='NombreFormifrm'  src='" + pLink + "' class='quasar-iframe-form'/>";
        $("#divformmodalbody").append(lFuente);
        $("#tituloModalForm").text(pTitulo);
        $('#divModalForm').on('show.bs.modal', function () {
            $('#divModalForm .modal-body').css('overflow-y', 'auto');
            $('#divModalForm .modal-body').css('height', $(window).height() * 0.8);
        });
        $('#divModalForm').on('hide.bs.modal', function () {
            //Inicio - quitado por error en quitar cortina
            //qpopup_ZIndexLiberar();
            //Fin
            if (pNuevoElemLupa)
                $("#gridlupa").igGrid("dataBind");
            $("#divformmodalbody").empty();
        });

        //$("#ifrmform")[0].src = "webfrmBasico.aspx?frm=" + pNombreForm + "&pref=" + lIdSes + "&pIdentif=" + lIdentif;
        qpopup_ZIndexAsignar($('#divModalForm'));
        $('#divModalForm').modal({ show: true });
    }
    qevt_EjecutarSiguiente();
}

function qpopup_MostrarForm(pNombreForm, pValor, pControl, pColumna, pTitulo, pSoloLectura) {
    qpopup_MostrarFormGral(pNombreForm, pValor, pControl, pColumna, pTitulo, pSoloLectura, false, false);
}

function qpopup_MostrarFormCasoPart(pNombreForm, pValor, pControl, pColumna, pTitulo, pSoloLectura) {
    qpopup_MostrarFormGral(pNombreForm, pValor, pControl, pColumna, pTitulo, pSoloLectura, false, true);
}

function qpopup_ObtenerNombreFormaMostrar(pControl, pColumna) {
    var lNombreTabla = "";
    var lPos = -1;
    var lRetorno = "";
    if (gGrillas[pControl] != undefined)
        lNombreTabla = gGrillas[pControl].Tabla;
    if (lNombreTabla != '') {
        //Obtengo la fila en donde se encuentra parado
        var lLong = gEntidad[lNombreTabla].length;
        for (var i = 0; (i < lLong) && (lPos == -1); i++) {
            if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pControl].ValorPK) {
                lPos = i;
                lRetorno = gEntidad[lNombreTabla][i][pColumna];
            }
        }
    }
    if (lPos <= -1) {
        //qevt_VaciarEventosTmp(); //No es necesario cortar las acciones del evento, ya que este es un 
        //form que se abre en su propia ventana
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }

    return lRetorno;
}


function qpopup_MostrarFormCorreo(pFuncion, pTablasAEnviar, pEsEspecializada) {
    var lIdSes = sessionStorage.getItem("idses");
    var pLink = "webfrmCorreo.aspx?pref=" + lIdSes + "&pfuncion=" + pFuncion + "&pTablasAEnviar=" + pTablasAEnviar + "&pEsEspecializada=" + pEsEspecializada;
    var lFuente = "<iframe id='NombreFormifrmMail'  src='" + pLink + "' class='quasar-iframe-form'/>";
    $("#divformmodalbody").append(lFuente);
    $("#tituloModalForm").text("");
    $('#divModalForm').on('show.bs.modal', function () {
        $('#divModalForm .modal-body').css('overflow-y', 'auto');
        $('#divModalForm .modal-body').css('height', $(window).height() * 0.9);
    });
    $("#divModalForm").unbind('hide.bs.modal');
    $('#divModalForm').on('hide.bs.modal', function () {
        //Inicio - quitado por error en quitar cortina
        //qpopup_ZIndexLiberar();
        //Fin
        $("#divformmodalbody").empty();
    });

    qpopup_ZIndexAsignar($('#divModalForm'));
    $('#divModalForm').modal({ show: true });
    //qevt_EjecutarSiguiente(); //la accion siguiente la debe ejecutar el formulario luego que termine de cargar
}

function qpopup_CerrarFormCorreo() {
    //Borro el iFrame
    var d = $("#divformmodalbody")
    var d_hijo = $("#NombreFormifrmMail");
    d[0].removeChild(d_hijo[0]);
    //cierro el div modal
    $("#divModalForm").modal('hide');
}


function qpopup_ZIndexAsignar(pDiv)
{
    //Inicio - quitado por error en quitar cortina
    //pDiv.css("z-index", 1050 + gzindexpopup);
    pDiv.css("z-index", gzindexpopup);
    //Fin
    gzindexpopup++;
}
//Inicio - quitado por error en quitar cortina
//function qpopup_ZIndexLiberar() {
//    if (gzindexpopup > 0)
//        gzindexpopup--;
//}
//Fin

function qpopup_ZIndexObtener() {
//Inicio - quitado por error en quitar cortina
//    var lValor = 1050 + gzindexpopup;
    var lValor = gzindexpopup;
//Fin
    gzindexpopup++;
    return lValor;
}

function qpopup_AntPopupWzrd(pPopupActual) {
    //busco el popup anterior al actual
    var lCantidad = gWizards.length;
    var lPos = -1;
    for (var i = 0; (i < lCantidad) && (lPos == -1); i++) {
        if (gWizards[i] == pPopupActual)
            lPos = i;
    }
    if (lPos > -1) {
        qpopup_Mostrar(gWizards[lPos - 1], false);
    }
}

function qpopup_SigPopupWzrd(pPopupActual) {
    //busco el popup anterior al actual
    var lCantidad = gWizards.length;
    var lPos = -1;
    for (var i = 0; (i < lCantidad) && (lPos == -1); i++) {
        if (gWizards[i] == pPopupActual)
            lPos = i;
    }
    if (lPos > -1) {
        qpopup_Mostrar(gWizards[lPos + 1], false);
    }

}

function qpopup_ConfPopupWzrd() {
    //busco el popup anterior al actual
    var lCantidad = gWizards.length;
    if (lCantidad > 0) {
        $("#btnvolver" + gWizards[0]).hide();
        $('#btncerrar' + gWizards[lCantidad - 1])[0].innerText = "Confirmar";
    }


}
