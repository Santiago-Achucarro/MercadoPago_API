function qbas_InicializarToolTips(pAncho) {
    if (pAncho >= 767) {
    $("#btnNuevo").tooltip({ title: qrecNuevo + " [Ctrl + Alt + N]", trigger: "hover" });
    $("#btnGuardar").tooltip({ title: qrecGuardar + " [Ctrl + Alt + G]", trigger: "hover" });
    $("#btnPostear").tooltip({ title: qrecPostear + " [Ctrl + Alt + P]", trigger: "hover" });
    $("#btnEliminar").tooltip({ title: qrecEliminar, trigger: "hover" });

    $('#btnRptVer').tooltip({ title: qrecVer + " [Ctrl + Alt + I]", trigger: "hover" });

    $('#btnRptImprimir').tooltip({ title: qrecImprimir, trigger: "hover" });
    $('#btnRptPdf').tooltip({ title: qrecPDF, trigger: "hover" });
    $('#btnRptXls').tooltip({ title: qrecXLS, trigger: "hover" });

    //$('#btnLupaPrim').tooltip({ title: qrecPrimero, trigger: "hover" });
    //$('#btnLupaAnt').tooltip({ title: qrecAnterior, trigger: "hover" });
    //$('#btnLupaSig').tooltip({ title: qrecSiguiente, trigger: "hover" });
    //$('#btnLupaUlt').tooltip({ title: qrecUltimo, trigger: "hover" });

    $('#btnFavorito').tooltip({ title: qrecFavorito, trigger: "hover" });
    $('#btnCerrar').tooltip({ title: qrecCerrar, trigger: "hover" });
        $('#btnCopiar').tooltip({ title: qrecCopiar, trigger: "hover" });
    $('#btnPegar').tooltip({ title: qrecPegar, trigger: "hover" });
    $('#btnAyuda').tooltip({ title: qrecAyuda, trigger: "hover" });
    }
}

function qbas_InicializarTextosGrillas() {
    $('.quasar-aceptar-fila').html(qrecAceptar);
    $('.quasar-cancelar-fila').html(qrecCerrar);
    $('.quasar-aceptar-fila').tooltip({ title: qrecAceptar + " [Alt + Enter]" });

}

function qbas_InicializarMobile() {
    if (gSolapas.length == 0)
        $("#btnSolapas").remove();
}


function qbas_BotonesRptRspnsv(pAncho) {
    if (pAncho < 767) {
        if ($('#divlibotonesrtp_xs')[0].children.length == 0) {
            //busco el primer boton visible para asignar el icono al span del boton de sel
            var lbtn = $('#divbotonesrtp>button');
            var lYaEsta = false;
            for (var i = 0; (i < lbtn.length) && (!lYaEsta); i++) {
                //if (!$('#' + $('#divbotonesrtp>button')[0].id).hasClass('hidden')) {
                if (!$('#' + lbtn[i].id).hasClass('hidden')) {
                    lYaEsta = true;
                    qbas_ModificarBtnRrpSelec(lbtn[i].id);
                }
            }
            $('#divlibotonesrtp_xs').append($('#divbotonesrtp>button'));
            $('#divbotonesrtp').hide();
            $('#divbotonesrtp_xs').show();
        }
    }
    else if ($('#divbotonesrtp')[0].children.length == 0) {
        $('#divbotonesrtp').append($('#divlibotonesrtp_xs>button'));
        $('#divbotonesrtp_xs').hide();
        $('#divbotonesrtp').show();
    }
}


function qbas_InicBotonesRptRspnsv(pAncho) {
    if ((pAncho < 767) && (gBtnesVis > 5)) {
        $('#divlibotonesrtp_xs').append($('#divbotonesrtp>button'));
        $('#divbotonesrtp_xs').show();
    }
    else
        $('#divbotonesrtp').show();

}


function qbas_ModificarBtnRrpSelec(pBotonRpt) {
    if (gBtnesVis > 5) {
        $("#spanbtnrptsel").removeClass();
        var lNuevaClase = $('#' + pBotonRpt + ' span')[0].className;
        $("#spanbtnrptsel").addClass(lNuevaClase);
    }
}

function qbas_EjecutarBtnRrpSelec() {
    //Busco el click del ultimo boton seleccionado
    var lClase = $('#spanbtnrptsel')[0].className;
    var lbtn = $('#divlibotonesrtp_xs>button');
    var lYaEsta = false;
    for (var i = 0; (i < lbtn.length) && (!lYaEsta); i++) {
        if (lClase == $('#' + lbtn[i].id + ' span')[0].className) {
            $('#' + lbtn[i].id).click();
            lYaEsta = true;
        }
    }


}

function qbas_BotonesOpcRspnsv(pAncho) {
    if (pAncho < 767) {
        if ($('#divliMasOpciones')[0].children.length == 0) {
            $('#divliMasOpciones').append($("#btnCopiar"));
            $('#divliMasOpciones').append($("#btnPegar"));
            $('#divliMasOpciones').append($("#btnFavorito"));
            $('#divliMasOpciones').append($("#btnAyuda"));
        }
    }
    else if ($('#divliMasOpciones')[0].children.length > 0) {
        $('#divMiscelaneos').append($("#btnCopiar"));
        $('#divMiscelaneos').append($("#btnPegar"));
        $('#divMiscelaneos').append($("#btnFavorito"));
        $('#divMiscelaneos').append($("#btnAyuda"));
    }
}



function qbas_MostrarSolapasMobile() {
    if ($('#divOpciones').is(':visible'))
        $('#divOpciones').modal('hide');
    else {
        $('#lstOpciones').empty();
        var lCantSolapas = gSolapas.length;
        for (var i = 0; i < lCantSolapas; i++) {
            if (gSolapas[i].EstaVisible) {
                if ($("#li" + gSolapas[i].Nombre)[0].classList.contains("active"))
                    $('#lstOpciones').append('<button type="button" class="btn quasar-btn-solapa" onClick="$(\'#divOpciones\').modal(\'hide\')">' + gSolapas[i].Titulo + '<span class="fas fa-check" style="right: 5px; position: absolute;"></span></button>');
                else
                    $('#lstOpciones').append('<button type="button" class="btn quasar-btn-solapa" onClick="qcom_ActivarSolapa(\'' + gSolapas[i].Nombre + '\'); $(\'#divOpciones\').modal(\'hide\')">' + gSolapas[i].Titulo + '</button>');
            }
        }

        $('#divOpciones').on('show.bs.modal', function () {
            $('#divOpciones').css("top", -400);
        });

        $('#divOpciones').on('shown.bs.modal', function () {
            //cambio la posición de la ventana
            //var lPosDerBtn = $("#btnSolapas").offset().left + ($("#btnSolapas").width() * 2);
            //var lPosDerBtn = $("#btnFavorito").offsetParent()[0].offsetLeft + $("#btnFavorito")[0].offsetLeft + $("#btnFavorito").width();
            var lPosDerBtn = $("#btnMasOpciones").offsetParent()[0].offsetLeft + $("#btnMasOpciones")[0].offsetLeft + $("#btnMasOpciones").width();
            var lAnchoOpciones = $("#lstOpciones").width();
            $('#divOpciones').css("left", lPosDerBtn - lAnchoOpciones);
            $('#divOpciones').css("top", 30);
        });

        //quito los eventos, porque sino los va acumulando en cada llamado
        $('#divOpciones').on('hidden.bs.modal', function () {
            $("#divOpciones").off("show.bs.modal");
            $("#divOpciones").off("hidden.bs.modal");
        });

        $("#divOpciones").modal({
            keyboard: true,
            tabindex: -1,
            backdrop: false,
            show: true
        });
    }
}

function qbas_oncontextmenu(evtobj) {
    if (evtobj.currentTarget.activeElement.id == "btnrptsel") {
        evtobj.preventDefault();
        evtobj.stopPropagation();
        $('#btnrptsel2').click();
    }
}

function qbas_keydown(evtobj) {
    //var evtobj = window.event ? event : e
    //if (evtobj.ctrlKey && evtobj.altKey) { //Key Ctrl
    if ((!evtobj.ctrlKey) && (evtobj.altKey)) { //Key Ctrl
        //alert(evtobj.keyCode);
        //console.log('Alt ' + evtobj.keyCode + ' ' + evtobj.key);
        if ((evtobj.key >= 'a') && (evtobj.key <= 'z')) { //Key = 1
            qcom_TratarShortCutGrillas(evtobj.key);
        }
        else if ((evtobj.key >= '1') && (evtobj.key <= '9')) { //Key = 1
            qcom_TratarShortCutSolapas(evtobj.key);
        }
        else if (evtobj.key >= 'Enter') { //Key = 1
            qcom_TratarEnterEnPPGrilla(evtobj.key);
        }
    }
    else if ((evtobj.ctrlKey) && (evtobj.altKey)) {
        if (evtobj.keyCode == 78) { //Key = N
            //if está visible el boton nuevo y está habilitado
            if ($("#btnNuevo").is(":visible") && (!$("#btnNuevo").is(":disabled"))) {
                evtobj.preventDefault();
                evtobj.stopPropagation();
                $("#btnNuevo").click();
            }
        }
        else if (evtobj.keyCode == 71) { //Key = G
            //if está visible el boton guardar y está habilitado
            if ($("#btnGuardar").is(":visible") && (!$("#btnGuardar").is(":disabled"))) {
                evtobj.preventDefault();
                evtobj.stopPropagation();
                $("#btnGuardar").click();
            }
        }
        else if (evtobj.keyCode == 80) { //Key = P
            //if está visible el boton Postear y está habilitado
            if ($("#btnPostear").is(":visible") && (!$("#btnPostear").is(":disabled"))) {
                evtobj.preventDefault();
                evtobj.stopPropagation();
                $("#btnPostear").click();
            }
        }
        else if (evtobj.keyCode == 73) { //Key = I
            //if está visible el boton Imprimir y está habilitado
            if ($("#btnRptVer").is(":visible") && (!$("#btnRptVer").is(":disabled"))) {
                evtobj.preventDefault();
                evtobj.stopPropagation();
                $("#btnRptVer").click();
            }
        }
    }
    //No permitir F9 porque en EDGE lleva al Lector Inmersivo 
    else if ((!evtobj.ctrlKey) && (!evtobj.altKey) && (evtobj.which == 120)) {
        evtobj.preventDefault();
        evtobj.stopPropagation();
    }
    else if ((gEsIteracion) && (evtobj.keyCode == 27)) { //Key = Escape Esto es para poder cortar acción de Iteracion
            gCortaIteracion = true;
    }
};


function qbas_touchstart(event) {
    event.preventDefault();
    gtimerLongTouch = setTimeout(function () {
        glongTouch = true;
    }, 1000);
};

function qbas_touchend(event) {
    clearTimeout(gtimerLongTouch);
    if (glongTouch) {
        glongTouch = false;
        if (event.currentTarget.activeElement.id == "btnrptsel") {
            event.preventDefault();
            event.stopPropagation();
            $('#btnrptsel2').click();
        }
        else if (event.currentTarget.activeElement.hasAttribute("role") && (event.currentTarget.activeElement.getAttribute("role") == "gridcell")) {
            if (event.currentTarget.activeElement.parentElement.hasAttribute("role") && (event.currentTarget.activeElement.parentElement.getAttribute("role") == "row")) {
                //contenido de aria-describeby "grdCuerpo_Moneda_Id" 
                var lGrillaCol = event.currentTarget.activeElement.getAttribute("aria-describedby");
                var lPosSep = lGrillaCol.indexOf('_');
                if (lPosSep > -1) {
                    var lGrilla = lGrillaCol.substring(0, lPosSep);
                    if (gGrdConBtnDer.indexOf("|" + lGrilla + "|") > -1) {
                        var lColumna = lGrillaCol.substring(lPosSep + 1);
                        var lRow = event.currentTarget.activeElement.parentElement.getAttribute("data-id");
                        var lui = { rowIndex: lRow, colIndex: -1, rowKey: lRow, colKey: lColumna };
                        qgrillas_MostrarMenuCtxt(lGrilla, lui, event);
                        event.preventDefault();
                        event.stopPropagation();
                    }
                }
            }
        }
    }
};

