//var QUpLoadAdv_dialogoupload = null;
//var QUpLoadAdv_Inicializada = false;
//var QUpLoadAdv_ControlCreado = false;
////Mètodo invocado desde el boton de un control "Lupa", para mostrar una ventana con el listado de registros
//function QUpLoadAdv_MostrarUpLoad(pTabla, pColControlSer, pColControlCli, pExtensionesPerm, pfuncionCliente) {
//    if (!QUpLoadAdv_Inicializada) {
//        QUpLoadAdv_Inicializar();
//    }

//    if (QUpLoadAdv_ControlCreado)
//    {
//        $("#igUploadArchivo").igUpload("destroy");
//    }
//    $("#igUploadArchivo").igUpload({
//        mode: 'single',
//        autostartupload: true,
//        progressUrl: "http://www.igniteui.com/IGUploadStatusHandler.ashx",
//        controlId: "serverID1",
//        allowedExtensions: pExtensionesPerm,
//        multipleFiles: false,
//        onError: function (e, args) {
//            //$("#error-message").html(args.errorMessage).stop(true, true).fadeIn(500).delay(3000).fadeOut(500);
//            qcom_Alerta(args.errorMessage, 'danger', null);
//        },
//        fileUploaded: function (evt, ui) {
//            qcom_AsignarValorTextEditor(gControles[pTabla][0][pColControlCli], ui.filePath);
//            if (pColControlSer != "")
//                qcom_AsignarValorTextEditor(gControles[pTabla][0][pColControlSer], ui.fileInfo.key);
//            //QUpLoadAdv_dialogoupload.dialog("close");
//            QUpLoadAdv_dialogoupload.modal("hide");
//            if (typeof pfuncionCliente == 'function') {
//                pfuncionCliente(null);
//            }
//        },
//    });

//    QUpLoadAdv_ControlCreado = true;

//    //QUpLoadAdv_dialogoupload.dialog("open");
//    QUpLoadAdv_dialogoupload.modal({ backdrop: "static" });
//    QUpLoadAdv_dialogoupload.draggable({
//        handle: ".modal-header"
//    });

//}


//function QUpLoadAdv_Inicializar() {

//    $("#divUpLoad").append("<div id='igUploadArchivo'></div>");
//    QUpLoadAdv_dialogoupload = $("#divModalUpLoad");
//    QUpLoadAdv_Inicializada = true;
//}


//function QUpLoadAdv_Inicializar_ant() {

//    $("#dialogupload").append("<div id='igUploadArchivo'></div>");
//    $("#dialogupload").append("<div id=\"error-message\" style=\"color: #FF0000; font-weight: bold;\"></div>");
//    QUpLoadAdv_dialogoupload = $("#dialogupload").dialog({
//        autoOpen: false,
//        height: 250,
//        width: 500,
//        modal: true,
//        buttons: [{
//            text: "Cancelar",
//            class: "btn btn-danger",
//            click: function () {
//                QUpLoadAdv_dialogoupload.dialog("close");
//            }
//        }],
//        open: function (event, ui) {
//            //hide titlebar.
//            $(this).parent().children('.ui-dialog-titlebar').hide();
//        }
//    });


//    QUpLoadAdv_Inicializada = true;
//}

function QUpLoadAdv_UpLoadArchivo(pNombreControl, pFuncionCliente) {
    var lCtrlFile = $("#" + pNombreControl + "_F")[0];
    if (lCtrlFile.files.length > 0) {
        var data = new FormData();        
        //for (var i = 0; i < lCtrlFile.files.length; i++) {
        //    lCtrlFile.files[i].name = pNombreServidor;
        //    data.append(pNombreServidor, lCtrlFile.files[i]);
        //}
        //lCtrlFile.files[0].name = pNombreServidor;
        data.append(lCtrlFile.files[0].name, lCtrlFile.files[0]);

        var lIdSes = sessionStorage.getItem("idses");
        $('#divCargando').addClass('show');
        $.ajax({
            type: "POST",
            url: "AjaxHandler/QUpLoadAdv.ashx?IdSes=" + lIdSes,
            contentType: false,
            processData: false,
            data: data,
        })
        .done(function (response) {
            $('#divCargando').removeClass('show');
            if (response.e == "logout")
                qcom_AlertaFinSesion(response.m);
            else if (response.e == "invalido")
                qcom_AlertaSesionInvalida(response.m);
            else if (response.startsWith("qbi"))
                qcom_AlertaErrorServicio();
            else if (response.startsWith("error:"))
                qcom_TratarError(response);
            else  {
                lNombreServidor = response;
                
                //$("#" + pNombreControl).val(lCtrlFile.files[0].name);
                //gUpLoads[pNombreControl] = lCtrlFile.files[0].name + '|' + lNombreServidor;
                ////$("#" + pNombreControl + "_S").val(lNombreServidor);
                var lValor = lCtrlFile.files[0].name + '|' + lNombreServidor;
                var lTipoOperacion = QUpLoadAdv_ActualizarEstado(pNombreControl, true);
                qcom_AsignarValorUpLoad(pNombreControl, lValor, lTipoOperacion);
                //Borro el file seleccionado del control standard, para que me lo ejecute de nuevo la proxima vez, si vuelve a ejecutar el mismo
                lCtrlFile.value = null;
                if (typeof pFuncionCliente == 'function')
                    pFuncionCliente(null);
                else
                    qevt_EjecutarSiguiente();
            }
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            //$("#" + pNombreControl).val("");
            //gUpLoads[pNombreControl] = "";
            qevt_VaciarEventosTmp();
            //Borro el file seleccionado del control standard, para que me lo ejecute de nuevo la proxima vez, si vuelve a ejecutar el mismo
            lCtrlFile.value = null;
            $('#divCargando').removeClass('show');
            qcom_Alerta(thrownError, 'danger', null);
        });
    }

}

function QUpLoadAdv_ActualizarEstado(pNombreControl, pArchivoSeleccionado) {
    var lRetorno = "X";
    if (pArchivoSeleccionado) {
        if (gUpLoads[pNombreControl] == "") //si no tenia nada
            lRetorno = 'I';
        else if (gUpLoads[pNombreControl].substring(0, 1) == "X") //si estaba sin cambios
            lRetorno = 'M';
        else if (gUpLoads[pNombreControl].substring(0, 1) == "B") //Si fue borrado
            lRetorno = 'M';
        else
            lRetorno = gUpLoads[pNombreControl].substring(0, 1);
    }
    else //si lo estoy borrando borrado
    {
        lRetorno = 'B';
        if (gUpLoads[pNombreControl] == "") //si no tenia nada
            lRetorno = '';
        else if (gUpLoads[pNombreControl].substring(0, 1) == "I") //si estaba sin cambios
            lRetorno = '';
    }
    return lRetorno;
}

function QUpLoadAdv_LimpiarArchivo(pNombreControl) {
    var lValor = "";
    var lTipoOperacion = QUpLoadAdv_ActualizarEstado(pNombreControl, false);
    qcom_AsignarValorUpLoad(pNombreControl, lValor, lTipoOperacion);
}

function QUpLoadAdv_UpLoadArchivoGrilla(pNombreGrilla, pNombreColumna, pFuncionCliente) {
    var lCtrlFile = $("#" + pNombreGrilla + "_F")[0];
    if (lCtrlFile.files.length > 0) {
        var data = new FormData();

        data.append(lCtrlFile.files[0].name, lCtrlFile.files[0]);
        var lIdSes = sessionStorage.getItem("idses");
        $('#divCargando').addClass('show');
        $.ajax({
            type: "POST",
            url: "AjaxHandler/QUpLoadAdv.ashx?IdSes=" + lIdSes,
            contentType: false,
            processData: false,
            data: data,
        })
            .done(function (response) {
                $('#divCargando').removeClass('show');
                if (response.e == "logout")
                    qcom_AlertaFinSesion(response.m);
                else if (response.e == "invalido")
                    qcom_AlertaSesionInvalida(response.m);
                else if (response.startsWith("qbi"))
                    qcom_AlertaErrorServicio();
                else if (response.startsWith("error:"))
                    qcom_TratarError(response);
                else {
                    lNombreServidor = response;
                    var lValor = 'I|' + lCtrlFile.files[0].name + '|' + lNombreServidor;
                    $("#" + pNombreGrilla).igGridUpdating("addRow", { [pNombreColumna]: lValor });
                    lCtrlFile.value = null;
                    if (typeof pFuncionCliente == 'function')
                        pFuncionCliente(null);
                    else
                        qevt_EjecutarSiguiente();
                }
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                lCtrlFile.value = null;
                $('#divCargando').removeClass('show');
                qcom_Alerta(thrownError, 'danger', null);
            });
    }

}

function QUpLoadAdv_FormatearColArchivo(pValor)
{
    var lcompo = pValor.split('|');
    if (lcompo.length == 1)
        return pValor;
    else if (lcompo.length > 1)
        return lcompo[1];
}

function QUpLoadAdv_CambiarEstadoEnGrilla(pDatosArchivo, pNombreGrilla, pNombreColumna) {
    var lComponentes = pDatosArchivo.attributes["data-id"].value.split('|');
    var lfila = parseInt(lComponentes[0]);
    var lestado = lComponentes[1];
    var cell = $("#" + pNombreGrilla).igGrid("cellAt", 1, lfila);
    if (cell.style.textDecoration == "line-through") {
        cell.style.textDecoration = "";
        var lNuevoestado = "X|" + lComponentes[2];
        $("#" + pNombreGrilla).igGridUpdating("updateRow", lfila, { [pNombreColumna]: lNuevoestado });
    }
    else {
        if (lestado != "I") {
            cell.style.textDecoration = "line-through";
            var lNuevoestado = "B|" + (lComponentes.length > 2 ? lComponentes[2] : lComponentes[1]);
            $("#" + pNombreGrilla).igGridUpdating("updateRow", lfila, { [pNombreColumna]: lNuevoestado });
        }
        else {
            $("#" + pNombreGrilla).igGridUpdating("deleteRow", lfila);
        }
    }
};


function QUpLoadAdv_UpLoadArchivoLista(pNombreLista, pFuncionCliente) {
    var lCtrlFile = $("#" + pNombreLista + "_F")[0];
    if (lCtrlFile.files.length > 0) {
        //Verifico el tamaño permitido
        if (qlstadj_VerifTamanioPermitido(lCtrlFile.files[0].size, pNombreLista))         
        {
            var lreader = new FileReader();
            lreader.readAsDataURL(lCtrlFile.files[0]);        
            lreader.onload = function () {
                var lcomponente = lreader.result.split(';base64,');
                var lBase64 = lcomponente[1];

                var data = new FormData();
                data.append(lCtrlFile.files[0].name, lCtrlFile.files[0]);
                var lIdSes = sessionStorage.getItem("idses");
                $('#divCargando').addClass('show');
                $.ajax({
                    type: "POST",
                    url: "AjaxHandler/QUpLoadAdv.ashx?IdSes=" + lIdSes,
                    contentType: false,
                    processData: false,
                    data: data,
                })
                .done(function (response) {
                    $('#divCargando').removeClass('show');
                    if (response.e == "logout")
                        qcom_AlertaFinSesion(response.m);
                    else if (response.e == "invalido")
                        qcom_AlertaSesionInvalida(response.m);
                    else if (response.startsWith("qbi"))
                        qcom_AlertaErrorServicio();
                    else if (response.startsWith("error:"))
                        qcom_TratarError(response);
                    else {

                        lNombreServidor = response;
                        var lValor = 'I|' + lCtrlFile.files[0].name + '|' + lNombreServidor;
                        //$("#" + pNombreGrilla).igGridUpdating("addRow", { [pNombreColumna]: lValor });
                        qlstadj_AgregarNuevoAdjunto(pNombreLista, lNombreServidor, lCtrlFile.files[0].name, lBase64);
                        lCtrlFile.value = null;
                        if (typeof pFuncionCliente == 'function')
                            pFuncionCliente(null);
                        else
                            qevt_EjecutarSiguiente();
                    }
                })
                .fail(function (xhr, ajaxOptions, thrownError) {
                    qevt_VaciarEventosTmp();
                    lCtrlFile.value = null;
                    $('#divCargando').removeClass('show');
                    qcom_Alerta(thrownError, 'danger', null);
                });
            };
            lreader.onerror = function (error) {
                qevt_VaciarEventosTmp();
                lCtrlFile.value = null;
                qcom_Alerta(error, 'danger', null);
            };
        }
    }
}



function getBase64(file) {
}


