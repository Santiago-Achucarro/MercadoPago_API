function qnotif_NotificacionesNoLeidas() {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/NumeroMensajesNoLeidos",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            if (data.d != "") {
                var lNotificaciones = JSON.parse(data.d);
                qnotif_CambiarBotonNotificaciones(lNotificaciones.Mensajes.length);
                var lTextoPopup = "";
                var lmensajesPopup = [];
                var lsepara = "";

                for (var i = 0; i < lNotificaciones.Mensajes.length; i++) {
                    var lFechaDesde = qcom_FormatearFechaGrilla(lNotificaciones.Mensajes[i]["FechaDesde"], '-');
                    if ( lFechaDesde != "")
                    {
                        lTextoPopup += lsepara + lNotificaciones.Mensajes[i]["Mensaje"];
                        lmensajesPopup.push(lNotificaciones.Mensajes[i]["MensajeId"]);
                        lsepara = " --- ";
                    }
                }
                if (lTextoPopup != "") {
                    qcom_Alerta(lTextoPopup, 'danger', null);
                    for (var i = 0; i < lmensajesPopup.length; i++) {
                        if (lmensajesPopup[i] != 0)
                            qnotif_NotificacionLeida(lmensajesPopup[i]);
                    }
                    qnotif_CambiarBotonNotificaciones(lNotificaciones.Mensajes.length - lmensajesPopup.length);
                }
            }
            else
                qnotif_CambiarBotonNotificaciones(-1);
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}


function qnotif_ObtenerNotificaciones() {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes });
    $.ajax({
        type: "POST",
        //todo ver gsitio
        url: "webfrmPrincipal.aspx/Mensajes",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            if (data.d != "") {
                var lNotificaciones = JSON.parse(data.d);
                qnotif_VerNotificaciones(lNotificaciones.Mensajes);
            }
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}


function qnotif_BorrarNotificacion(pNotificacion) {
    var lMensaje_Id = pNotificacion.attributes["data-id"].value;
    qnotif_BorrarNotificacionGral(lMensaje_Id);
    //var lIdSes = sessionStorage.getItem("idses");
    //var lData = JSON.stringify({ 'pIdSes': lIdSes, 'Mensaje_Id': lMensaje_Id });
    //$.ajax({
    //    type: "POST",
    //    url: "webfrmPrincipal.aspx/BorrarMensajes",
    //    contentType: "application/json; charset=utf-8",
    //    dataType: "json",
    //    data: lData,
    //})
    //.done(function (data) {
    //    if (!data.d.startsWith("error:")) {
    //        //var types = JSON.parse(data.d);
    //        qnotif_NotificacionesNoLeidas();
    //        qnotif_ObtenerNotificaciones();
    //    }
    //    else
    //        qcom_TratarError(data.d);
    //})
    //.fail(function (xhr, ajaxOptions, thrownError) {
    //    qcom_Alerta(xhr.responseText, 'danger', null);
    //});
}

function qnotif_BorrarNotificacionesSeleccionadas(pSeleccionadas) {
    if (pSeleccionadas.length == 0)
    {
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }
    else
    {
        for (var i = 0; i < pSeleccionadas.length; i++) {
            var lMensaje_Id = pSeleccionadas[i].id;
            if (lMensaje_Id != 0)
                qnotif_BorrarNotificacionGral(lMensaje_Id);
        }
    }
}


function qnotif_BorrarNotificacionGral(pMensaje_Id) {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes, 'Mensaje_Id': pMensaje_Id });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/BorrarMensajes",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            //var types = JSON.parse(data.d);
            qnotif_NotificacionesNoLeidas();
            qnotif_ObtenerNotificaciones();
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}


function qnotif_VerEnFormulario(pNotificacion) {
    var lDatosForm = pNotificacion.attributes["data-id"].value.split('||');
    
    var lIdSes = sessionStorage.getItem("idses");
    var lFormulario = ''
    var lParametros = '';
    var lTitulo = '';
    if (lDatosForm.length > 0)
        lFormulario = lDatosForm[0];
    if (lDatosForm.length > 1) {
        //vienen los parametros y el titulo del formulario
        var lComponentes = lDatosForm[1].split('|');
        lParametros = lComponentes[0];
        lTitulo = lComponentes[1];
    }
    CrearSolapa("webfrmBasico.aspx?frm=" + lFormulario + "&pref=" + lIdSes + "&pI=" + lParametros + "&pS=f&pEP=f", lTitulo);
}


function qnotif_CambiarBotonNotificaciones(pCantNotificaciones) {
    //muestra el signo de pregunta si dio algun error en el BE
    if (pCantNotificaciones == -1) {
        $("#ctrlCantMensajes").text("?");
        $("#ctrlCantMensajesMobile").text("?");
    }
    else {
        $("#ctrlCantMensajes").text(pCantNotificaciones);
        $("#ctrlCantMensajesMobile").text(pCantNotificaciones);
    }
    if (pCantNotificaciones == 0) {
        $("#ctrlCantMensajes").hide();
        $("#ctrlCantMensajesMobile").hide();
    }
    else {
        $("#ctrlCantMensajes").show();
        $("#ctrlCantMensajesMobile").show();
    }
};

function qnotif_VerNotificaciones(pDatos) {
    if (pDatos.length > 0)
        $("#SinNotif").hide();
    else
        $("#SinNotif").show();
    for (var i = 0; i < pDatos.length; i++) {
        if ((!pDatos[i].Leido) && (pDatos[i].MensajeId != 0))
            qnotif_NotificacionLeida(pDatos[i].MensajeId);
    }

    $("#grdNotificaciones").igGrid("option", "dataSource", pDatos);
    $("#grdNotificaciones").igGrid("dataBind");
    $("#divNotificaciones").modal({
        keyboard: true,
        tabindex: -1,
        backdrop: "static",
        show: true
    });
    $("#divNotificaciones").draggable({
        handle: ".modal-header"
    });
    qnotif_CambiarBotonNotificaciones(0);
}

function qnotif_NotificacionLeida(pMensaje_Id) {
    if (pMensaje_Id != 0) {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes, 'Mensaje_Id': pMensaje_Id });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/LeidoMensajes",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            //no hay que hacer nada
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
    }
}

function qnotif_DiferenciarEstados(ui) {
    var igDs = $("#grdNotificaciones").data("igGrid").dataSource;
    for (var j = 0; j < igDs._data.length; j++) {
        var cell = $("#grdNotificaciones").igGrid("cellAt", 0, j);
        var cell2 = $("#grdNotificaciones").igGrid("cellAt", 1, j);
        if (igDs._data[j]["Leido"]) {
            cell.style.backgroundColor = "#658a7a";           
        }
        else {
            cell.style.backgroundColor = "#b16a6a";
            cell2.style.fontWeight = "500";
            cell2.style.fontStyle = "italic";
        }
    }    

}