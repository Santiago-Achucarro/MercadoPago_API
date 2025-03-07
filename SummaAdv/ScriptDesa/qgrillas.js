function qgrillas_ArmarObjetoFilaFila(pGrilla) {
    var lNombreTabla = gGrillas[pGrilla].Tabla;
    var lValores = qcom_Clonar(gClones[lNombreTabla]);
    qcom_InicializarColumnasSegmentoFila(lNombreTabla, lValores)
    lValores["IDCol"] = parseInt(gGrillas[pGrilla].ValorPK);

    var igDs = $("#" + pGrilla).data("igGrid").dataSource;
    var lEstaEnEdicion = (gGrillas[pGrilla].ColIdEnEdicion != -1);

    if (gGrillas[pGrilla].CampoAutonumerico != "")
        lValores[gGrillas[pGrilla].CampoAutonumerico] = parseInt(gGrillas[pGrilla].ValorPK);
    var columns = $("#" + pGrilla).igGrid("option", "columns");
    for (var i = 0; i < columns.length; i++) {
        if (gControles[lNombreTabla][0][columns[i].key] != null)
            lValores[columns[i].key] = qcom_ObtenerValorControl(gControles[lNombreTabla][0][columns[i].key]);
        else if (lEstaEnEdicion)
            //Inicio Filtros y Paginacion
            //lValores[columns[i].key] = igDs._data[gGrillas[pGrilla].ColIdEnEdicion][columns[i].key];
            lValores[columns[i].key] = igDs._dataView[gGrillas[pGrilla].ColIdEnEdicion][columns[i].key];
            //Fin Filtros y Paginacion
    }
    // Llamo a esto para los controles ocultos de los segmentos
    qcom_CargoOcultosSegmentoFila(lNombreTabla, lValores);


    return lValores;
}


function qgrillas_FinAceptarFila(pGrilla) {
    //qgrillas_guardarDatosEdicion(pGrilla);

    if (gGrillas[pGrilla].ColIdEnEdicion != -1) {
        if ($(window).width() >= gSizePhone) {
            var lElem = $('input[name="opt' + pGrilla + '"]:checked');
            lValRet = "";
            var lCerrarPopup = false;
            if (lElem.length > 0)
                lValRet = lElem[0].value;
            var igDs = $("#" + pGrilla).data("igGrid").dataSource;
            var lCellSelec = $("#" + pGrilla).igGridSelection("selectedCell");

            lPagina = 0;
            lCantXPag = 2000;
            //Verifico si está paginada
            var lFeatures = $("#" + pGrilla).igGrid("option", "features");
            var lPaginada = false;
            for (var p = 0; p < lFeatures.length && (!lPaginada) ; p++) {
                lPaginada = (lFeatures[p].name == "Paging");
            }
            if (lPaginada) {
                lPagina = $("#" + pGrilla).igGridPaging("option", "currentPageIndex");
                lCantXPag = $("#" + pGrilla).igGridPaging("option", "pageSize");
            }


            if ((lValRet == "") || (lValRet == "X"))
                lCerrarPopup = true;
            //else if ((lValRet == "S") && (lCellSelec.rowIndex >= (igDs._dataView.length - 1))) 
            else if ((lValRet == "S") && ((lPagina * lCantXPag) + lCellSelec.rowIndex >= (igDs._data.length - 1)))
                    lCerrarPopup = true;
            //else if ((lValRet == "A") && (lCellSelec.rowIndex == 0)) 
            else if ((lValRet == "A") && (lCellSelec.rowIndex == 0) && (lPagina==0))
                    lCerrarPopup = true
            if (!lCerrarPopup) {
                if (lValRet == "S") {
                    //si todavia tiene filas en la misma pagina
                    if (lCellSelec.rowIndex < (igDs._dataView.length - 1))
                        $("#" + pGrilla).igGridSelection("selectCell", lCellSelec.rowIndex + 1, lCellSelec.index);
                    else //tengo que cambiar de pagína y posicionarme en el primero
                    {
                        $("#" + pGrilla).igGridPaging("pageIndex", lPagina + 1);
                        $("#" + pGrilla).igGridSelection("selectCell", 0, lCellSelec.index);
                    }
                }
                else if (lValRet == "A") {
                    if (lCellSelec.rowIndex > 0)
                        $("#" + pGrilla).igGridSelection("selectCell", lCellSelec.rowIndex - 1, lCellSelec.index);
                    else 
                    {
                        $("#" + pGrilla).igGridPaging("pageIndex", lPagina - 1);
                        $("#" + pGrilla).igGridSelection("selectCell", lCantXPag-1, lCellSelec.index);
                    }
                }
                var lCellSelecNueva = $("#" + pGrilla).igGridSelection("selectedCell");
                qgrillas_SeleccionarCelda(pGrilla, lCellSelecNueva.rowIndex, lCellSelecNueva.id, gGrillas[pGrilla].ColumnaEnEdicion, false);
                var lControlFoco = qgrillas_ControlFoco(pGrilla);
                if (lControlFoco != null)
                    lControlFoco.focus();
                qevt_Grilla_EditarFila(pGrilla, 0);
            }
            else
            {
                //igDs._dataView[gGrillas[pGrilla].ColIdEnEdicion]
                $("#divGrupo" + pGrilla).attr("Abierto", "false");
                $("#divGrupo" + pGrilla).modal('hide');
                //qpopup_Mostrar("divGrupo" + pGrilla, true);
                //Inicio - quitado por error en quitar cortina
                //qpopup_ZIndexLiberar();
                //Fin
                    //$("#" + pGrilla).igGridSelection("selectCell", 1, 5);
                if (($("#" + pGrilla) != undefined) && ($("#" + pGrilla) != null))
                    $("#" + pGrilla).focus();
                if (($("#" + pGrilla).igGridSelection("selectedCell") != undefined) &&
                    ($("#" + pGrilla).igGridSelection("selectedCell") != null)) {
                    if (($("#" + pGrilla).igGridSelection("selectedCell").element[0] != undefined) &&
                        ($("#" + pGrilla).igGridSelection("selectedCell").element[0] != null))
                $("#" + pGrilla).igGridSelection("selectedCell").element[0].focus();
            }
        }
        }
        else {
            $("#divGrupo" + pGrilla).attr("Abierto", "false");
            $("#divGrupo" + pGrilla).modal('hide');
            //qpopup_Mostrar("divGrupo" + pGrilla, true);
            //Inicio - quitado por error en quitar cortina
            //qpopup_ZIndexLiberar();
            //Fin
            $("#" + pGrilla).igGrid("dataBind");
        }
        qevt_EjecutarSiguiente();
    }
    else {
        //qgrillas_blanquearControles(pGrilla);
        qevt_Grilla_NuevaFila(pGrilla, false);
        qevt_EjecutarSiguiente();
        var lControlFoco = qgrillas_ControlFoco(pGrilla);
        if (lControlFoco != null)
            lControlFoco.focus();
    }
}

function qgrillas_CancelarFila(pGrilla) {

    qcom_HabilitoGuardar();
    var lNombreTabla = gGrillas[pGrilla].Tabla;
    qevt_VaciarEventosTmp();
    //debo rollbakear todas las grillas asociadas    
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTablaMaster() == lNombreTabla) {
            if (lValor.getTipoCtrlDetalle() == "G") {
                //Obtengo la grilla asociada a la tabla detail
                lNombreTablaDetail = lValor.getTablaDetalle();
                lNombreGrillaDetail = 'grd' + lValor.getTablaDetalle();
                if (gGrillas[lNombreGrillaDetail] != undefined) {
                    lCampoFK = lValor.getColDetalle();
                    lCampoPK = lValor.getColMaster();
                    //$("#" + lNombreGrillaDetail).igGrid("rollback");
                    //$("#" + lNombreGrillaDetail).igGrid("dataBind");
                    gEntidadAux[lNombreTablaDetail].splice(0);
                    gGrillas[lNombreGrillaDetail].FilasFiltradas = [];
                }
            }
        }
    });


    if (gGrillas[pGrilla].ColIdEnEdicion != -1) {
        if ($(window).width() >= gSizePhone) {
            $("#divGrupo" + pGrilla).modal('hide');
            //qpopup_Mostrar("divGrupo" + pGrilla, true);
            //Inicio - quitado por error en quitar cortina
            //qpopup_ZIndexLiberar();
            //Fin
            $("#" + pGrilla).focus();
            $("#" + pGrilla).igGridSelection("selectedCell").element[0].focus();
        }
        else {
            $("#divGrupo" + pGrilla).modal('hide');
            //qpopup_Mostrar("divGrupo" + pGrilla, true);
            //Inicio - quitado por error en quitar cortina
            //qpopup_ZIndexLiberar();
            //Fin
            $("#" + pGrilla).igGrid("dataBind");
        }
    }
    else {
        $("#divGrupo" + pGrilla).modal('hide');
        //qpopup_Mostrar("divGrupo" + pGrilla, true);
        //Inicio - quitado por error en quitar cortina
        //qpopup_ZIndexLiberar();
        //Fin
        $("#" + pGrilla).focus();
    }
};

function qgrillas_blanquearControles(pGrilla, pbtnNuevo) {
    gGrillas[pGrilla].ColIdEnEdicion = -1;
    gGrillas[pGrilla].ColumnaEnEdicion = "";
    var lNombreTabla = gGrillas[pGrilla].Tabla;
    gGrillas[pGrilla].ValorPK = qgrillas_ObtenerNuevaPK(pGrilla);

    //var columns = $("#" + pGrilla).igGrid("option", "columns");
    //var igDs = $("#" + pGrilla).data("igGrid").dataSource;
    //for (var i = 0; i < columns.length; i++) {
    //    if ((gGrillasColCtr[pGrilla][columns[i].key] != 'PK') && (gGrillasColCtr[pGrilla][columns[i].key] != 'Auto') &&
    //        (columns[i].key != "Acciones")) {
    //        //if (columns[i].dataType == "number")
    //        //    $("#" + gGrillasColCtr[pGrilla][columns[i].key]).igNumericEditor("option", "value", 0);
    //        //else
    //        //    $("#" + gGrillasColCtr[pGrilla][columns[i].key]).igTextEditor("option", "value", "");
    //        qcom_AsignarValorControl(gControles[lNombreTabla][0][columns[i].key], gControles[lNombreTabla][0][columns[i].key].getDefecto(), true);
    //    }
    //}
    $.each(gControles[lNombreTabla][0], function (lClave, lValor) {
        if (gControles[lNombreTabla][0][lClave] != null) {
            if (pbtnNuevo || gControles[lNombreTabla][0][lClave].getNuevoBlanquea()) {
                qcom_AsignarValorControl(gControles[lNombreTabla][0][lClave], gControles[lNombreTabla][0][lClave].getDefecto(), true);
            }
            if (lValor.getControlConjunto() != "") {
                if (lValor.getHabilitado() && lValor.getHabilitadoxSeteo())
                    qcom_HabilitarControl(lValor.getControlConjunto());
                else
                    qcom_DesHabilitarControl(lValor.getControlConjunto());

                if (lValor.getVisible() && lValor.getVisibleXPais() && lValor.getVisiblexSeteo())
                    qcom_MostrarControl(lValor.getControlConjunto());
                else
                    qcom_OcultarControl(lValor.getControlConjunto());
            }

        }
    });

    //Si es un master, debo completar el valor de loa master en cada relacion y filtrar las grillas
    //si es un detalle, debo asignar el valor del master al control asociado (si es que tiene)
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaMaster() == lNombreTabla) {
                if (lValor.getTipoCtrlDetalle()) {
                    lCampoPK = lValor.getColMaster();
                    lValorFiltro = "";
                    //Seteo el valor de las PKs
                    if (gGrillas[pGrilla].CampoAutonumerico == lCampoPK) {
                        lValorFiltro = parseInt(gGrillas[pGrilla].ValorPK);
                        gRelacTablas[lClave].setValorMaster(parseInt(gGrillas[pGrilla].ValorPK));
                    }
                    else {
                        lValorFiltro = "0";
                        gRelacTablas[lClave].setValorMaster("0");
                    }
                    //Obtengo la grilla asociada a la tabla detail
                    lNombreTablaDetail = lValor.getTablaDetalle();
                    lNombreGrillaDetail = 'grd' + lValor.getTablaDetalle();
                    if (gGrillas[lNombreGrillaDetail] != undefined) {
                        if (gGrillas[lNombreGrillaDetail].RegistrosPorPagina > 0)
                            gGrillas[lNombreGrillaDetail].Control.igGridFiltering("filter", ([]));
                        lCampoFK = lValor.getColDetalle();
                        gEntidadAux[lNombreTablaDetail].splice(0);
                        gGrillas[lNombreGrillaDetail].FilasFiltradas = [];
                        gGrillas[lNombreGrillaDetail].Control.igGrid("option", "dataSource", gEntidadAux[lNombreTablaDetail]);
                        gGrillas[lNombreGrillaDetail].Control.igGrid("dataBind");
                        //gGrillas[lNombreGrillaDetail].Control.igGridFiltering("filter", ([{ fieldName: lCampoFK, expr: lValorFiltro, cond: "equals", logic: "AND" }]));
                    }
                }
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lCampoFK = lValor.getColDetalle();
                if (gControles[lNombreTabla][0][lCampoFK] != null)
                    qcom_AsignarValorControl(gControles[lNombreTabla][0][lCampoFK], lValor.getValorMaster(), true);
            }
        }
    });
    qevt_EjecutarSiguiente();
    //este queda acá por ahora como una especie de callback
    //if (gGrillasEvNuevo[pGrilla] != null) {
    //    var lFN = gGrillasEvNuevo[pGrilla];
    //    lFN();
    //}

    //$("#ctrtos12Impuesto_Id_1").focus();
    //Debo Buscar el primer control visible del form

}

function qgrillas_ObtenerNuevaPK(pGrilla) {
    //igDs = $("#" + pgrilla).data("igGrid").dataSource;
    //if (igDs._data.length == 0)
    //    return 1;
    //else
    //    return (igDs._data[igDs._data.length - 1][pNombreCol]) + 1;
    gGrillas[pGrilla].UltimaPK = gGrillas[pGrilla].UltimaPK + 1;
    return gGrillas[pGrilla].UltimaPK;
}


function qgrillas_guardarDatosEdicion(pGrilla) {
    var lValores = {};
    var lNombreTabla = gGrillas[pGrilla].Tabla;
    //Si estoy editando, solo debo modificar los valores de los campos que están en los controles del popup
    //if ((gGrillas[pGrilla].ColIdEnEdicion != -1) && (gGrillas[pGrilla].Editable)){
    //    lValores["IDCol"] = parseInt(gGrillas[pGrilla].ValorPK);
    //    if (gGrillas[pGrilla].CampoAutonumerico != "")
    //        lValores[gGrillas[pGrilla].CampoAutonumerico] = parseInt(gGrillas[pGrilla].ValorPK);
    //    var columns = $("#" + pGrilla).igGrid("option", "columns");
    //    for (var i = 0; i < columns.length; i++) {
    //        if (gControles[lNombreTabla][0][columns[i].key] != null)
    //            lValores[columns[i].key] = qcom_ObtenerValorControl(gControles[lNombreTabla][0][columns[i].key]);
    //    }
    //}
    ////si es nuevo, debo completar todos los campos, tanto los que están como los que no están en un popup
    //else {
        lValores = qgrillas_ArmarObjetoFilaFila(pGrilla);
    //}
    var lEsAutoCommit = true;
    var lEsDetalle = false;
    //si es una tabla detail, debo asignar el valor de FK, si es que no está ya asignada
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetalle = true;
                lEsAutoCommit = false;
                lCampoFK = lValor.getColDetalle();
                if ((lValores[lCampoFK] == undefined) || (lValores[lCampoFK] == null)) {
                    lValores[lCampoFK] = lValor.getValorMaster();
                }
            }
        }
    });



    if (gGrillas[pGrilla].ColIdEnEdicion == -1) {
        $("#" + pGrilla).igGridUpdating("addRow", lValores);
        //$("#" + pGrilla).igGrid("autoSizeColumns");

        //debo rebindear la grilla para que muestre el elemento agregado
        //if (!lEsAutoCommit) {
        //    $("#" + pGrilla).igGrid("renderNewRow", lValores);
        //}
    }
    else {
        $("#" + pGrilla).igGridUpdating("updateRow", gGrillas[pGrilla].ValorPK, lValores);
        //$("#" + pGrilla).igGrid("autoSizeColumns");

    }
    if (!lEsDetalle)
        gTieneSinGuardar = true;

    //debo committear todas las grillas asociadas    
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaMaster() == lNombreTabla) {
                //Obtengo la grilla asociada a la tabla detail
                lNombreTablaDetail = lValor.getTablaDetalle();
                lNombreGrillaDetail = 'grd' + lValor.getTablaDetalle();
                if (gGrillas[lNombreGrillaDetail] != undefined) {
                    //$("#" + lNombreGrillaDetail).igGrid("commit");
                    //debo pasar los datos de gEntidadAux a  gEntidad

                    //esta solucion por ahora se desecha porque si bien es la mas performante, cuando desde una accion
                    //de FE necesitan modificar datos en la grilla detail, hay que rebindear el datatable que 
                    //envía el FE, por lo tanto se blanquean las transacciones de la grilla
                    ////Obtengo las Transacciones Pendientes de lal datasource de la grilla
                    //var lstTrans = $("#" + lNombreGrillaDetail).data("igGrid").dataSource.allTransactions();
                    ////Primero Proceso los new rows y los upodates, despues los deletes
                    //var lBorrados = [];
                    //$.each(lstTrans, function (lClaveTrans, lValorTrans) {
                    //    if (lValorTrans.type == "newrow")
                    //        gEntidad[lNombreTablaDetail].push(jQuery.extend({}, lValorTrans.row));
                    //    else if (lValorTrans.type == "row") {
                    //        //obtengo el IDCol
                    //        lIDCol = lValorTrans.rowId;
                    //        //Obtengo la posicion del elemento
                    //        lPos = gGrillas[lNombreGrillaDetail].FilasFiltradas[lIDCol];
                    //        gEntidad[lNombreTablaDetail][lPos] = jQuery.extend({}, lValorTrans.row);
                    //    }
                    //    else if (lValorTrans.type == "deleterow") {
                    //        lIDCol = lValorTrans.rowId;
                    //        //Obtengo la posicion del elemento
                    //        lPos = gGrillas[lNombreGrillaDetail].FilasFiltradas[lIDCol];
                    //        lBorrados.push(lPos);
                    //    }
                    //});
                    //lBorrados.sort();
                    //for (var i = 0; i < lBorrados.length; i++) {
                    //    var index = lBorrados[i] - i;
                    //   gEntidad[lNombreTablaDetail].splice(index, 1);
                    //}
                    //Nueva Solución. 
                    //Borro los filtrados de gEntidad y le paso los que están en Auxiliar
                    for (var i = gGrillas[lNombreGrillaDetail].FilasFiltradas.length - 1; i >= 0; i--)
                        gEntidad[lNombreTablaDetail].splice(gGrillas[lNombreGrillaDetail].FilasFiltradas[i], 1);
                    //gEntidad[lNombreTablaDetail].splice(0);
                    //inserto los registros que están en gEntidadAux
                    $.each(gEntidadAux[lNombreTablaDetail], function (lClave, lValor) {
                        gEntidad[lNombreTablaDetail].push(jQuery.extend({}, lValor));
                    });
                }
            }
        }
    });


    //if (pfnFinEdicionFila != null)
    //    pfnFinEdicionFila();
    qevt_EjecutarSiguiente();
}

//var page = $(".selector").igGridPaging("option", "currentPageIndex");
function qgrillas_SeleccionarCelda(pGrilla, pRowIndex, pRowId, pColumnKey, pEstaPaginada) {
    //Inicio Filtros y Paginacion
    //if (pEstaPaginada)
    //{
    //    var lPagina = $("#" + pGrilla).igGridPaging("option", "currentPageIndex");
    //    var lTamanioPag = $("#" + pGrilla).igGridPaging("option", "pageSize");
    //    gGrillas[pGrilla].ColIdEnEdicion = (lPagina * lTamanioPag) + pRowIndex;
    //}
    //else
    //Fin Filtros y Paginacion
    //Si estoy en modo celular, debo primero obtener los valores claves
    if ($(window).width() >= gSizePhone) {
        gGrillas[pGrilla].ColIdEnEdicion = pRowIndex;
        gGrillas[pGrilla].ValorPK = pRowId;
        gGrillas[pGrilla].ColumnaEnEdicion = pColumnKey;
    }
    else
        qgrillas_obtenerValorRowIndexPhone(pGrilla, pRowId);
}

//Inicio - Lo está haciendo el SeleccionaCelda
//function qgrillas_llenarDatosEdicionGeneral(pGrilla, pRowIndex, pRowId, pColumnKey) {
    //gGrillas[pGrilla].ColIdEnEdicion = pRowIndex;
    //gGrillas[pGrilla].ValorPK = pRowId;
    //gGrillas[pGrilla].ColumnaEnEdicion = pColumnKey;
function qgrillas_llenarDatosEdicionGeneral(pGrilla) {
//Fin  - Lo está haciendo el SeleccionaCelda
    var lNombreTabla = gGrillas[pGrilla].Tabla;
    //var columns = $("#" + pGrilla).igGrid("option", "columns");
    var igDs = $("#" + pGrilla).data("igGrid").dataSource;
    //for (var i = 0; i < columns.length; i++) {
    //    if ((gGrillasColCtr[pGrilla][columns[i].key] != 'PK') && (gGrillasColCtr[pGrilla][columns[i].key] != 'Auto')) {
    //        //if (columns[i].dataType == "number")
    //        //    $("#" + gGrillasColCtr[pGrilla][columns[i].key]).igNumericEditor("option", "value", parseInt(igDs._data[pRowIndex][columns[i].key]));
    //        //else
    //        //    $("#" + gGrillasColCtr[pGrilla][columns[i].key]).igTextEditor("option", "value", igDs._data[pRowIndex][columns[i].key]);
    //        qcom_AsignarValorControl(gControles[lNombreTabla][0][columns[i].key], igDs._data[pRowIndex][columns[i].key], false);
    //    }
    //}
    $.each(gControles[lNombreTabla][0], function (lClave, lValor) {
        if (gControles[lNombreTabla][0][lClave] != null) {
            //Inicio Filtros y Paginacion
            //qcom_AsignarValorControl(gControles[lNombreTabla][0][lClave], igDs._data[gGrillas[pGrilla].ColIdEnEdicion][lClave], false);
            qcom_AsignarValorControl(gControles[lNombreTabla][0][lClave], igDs._dataView[gGrillas[pGrilla].ColIdEnEdicion][lClave], false);
            //Fin Filtros y Paginacion
            if (lValor.getControlConjunto() != "") {
                if (lValor.getHabilitado() && lValor.getHabilitadoxSeteo())
                    qcom_HabilitarControl(lValor.getControlConjunto());
                else
                    qcom_DesHabilitarControl(lValor.getControlConjunto());

                if (lValor.getVisible() && lValor.getVisibleXPais() && lValor.getVisiblexSeteo())
                    qcom_MostrarControl(lValor.getControlConjunto());
                else
                    qcom_OcultarControl(lValor.getControlConjunto());
            }
        }
    });


    //Si es un master, debo completar el valor de loa master en cada relacion y filtrar las grillas
    //si es un detalle, debo asignar el valor del master al control asociado (si es que tiene)
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaMaster() == lNombreTabla) {
                //Limpio el auxiliar de la tabla master
                if (gGrillas['grd' + lNombreTabla] != undefined)
                    gEntidadAux[lNombreTabla].splice(0);
                lCampoPK = lValor.getColMaster();
                //Seteo el valor de las PKs
                //Inicio Filtros y Paginacion
                //lValorFiltro = igDs._data[gGrillas[pGrilla].ColIdEnEdicion][lCampoPK];
                lValorFiltro = igDs._dataView[gGrillas[pGrilla].ColIdEnEdicion][lCampoPK];
                //Fin Filtros y Paginacion
                gRelacTablas[lClave].setValorMaster(lValorFiltro);
                //Obtengo la grilla asociada a la tabla detail
                lNombreTablaDetail = lValor.getTablaDetalle();
                lNombreGrillaDetail = 'grd' + lValor.getTablaDetalle();
                if (gGrillas[lNombreGrillaDetail] != undefined) {
                    if (gGrillas[lNombreGrillaDetail].RegistrosPorPagina > 0)
                        gGrillas[lNombreGrillaDetail].Control.igGridFiltering("filter", ([]));
                    lCampoFK = lValor.getColDetalle();
                    //gGrillas[lNombreGrillaDetail].Control.igGridFiltering("filter", ([{ fieldName: lCampoFK, expr: lValorFiltro, cond: "equals", logic: "AND" }]));
                    gEntidadAux[lNombreTablaDetail].splice(0);
                    //debo recorrer y filtrar las filas comitteadas, y pasarlas a temporal
                    gGrillas[lNombreGrillaDetail].FilasFiltradas = [];
                    $.each(gEntidad[lNombreTablaDetail], function (lClave, lValor) {
                        if (lValor[lCampoFK] == lValorFiltro) {
                            //esta solución era si tomabamos en cuenta las transacciones de la grilla   
                            //gGrillas[lNombreGrillaDetail].FilasFiltradas[lValor["IDCol"]] = lClave;
                            //Con la nueva solución, solo necesito guardar la posicion
                            gGrillas[lNombreGrillaDetail].FilasFiltradas.push(lClave);
                            gEntidadAux[lNombreTablaDetail].push(jQuery.extend({}, lValor));
                        }
                    });
                    //var lst = gEntidad[lNombreTablaDetail].filter(function (index) {
                    //    return gEntidad[lNombreTablaDetail][index][lCampoFK] == lValorFiltro;
                    //});

                    gGrillas[lNombreGrillaDetail].Control.igGrid("option", "dataSource", gEntidadAux[lNombreTablaDetail]);
                    gGrillas[lNombreGrillaDetail].Control.igGrid("dataBind");

                }
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lCampoFK = lValor.getColDetalle();
                if (gControles[lNombreTabla][0][lCampoFK] != null)
                    qcom_AsignarValorControl(gControles[lNombreTabla][0][lCampoFK], lValor.getValorMaster(), true);
            }
        }
    });
    
    //si está definido el evento, lo ejecuto..
    //como este método no tiene invocaciones via ajax, directamente no es necesario hacer lo siguiente, se hace directo en el evento
    //if (gGrillasEvEdicion[pGrilla] != null)
    //    gGrillasEvEdicion[pGrilla]();
    qevt_EjecutarSiguiente();
}

//function qgrillas_llenarDatosEdicion(pGrilla, ui) {
//qgrillas_llenarDatosEdicionGeneral(pGrilla, ui.cell.rowIndex, ui.cell.rowId, ui.cell.columnKey);
function qgrillas_llenarDatosEdicion(pGrilla) {
    qgrillas_llenarDatosEdicionGeneral(pGrilla);
}


function qgrillas_llenarDatosEdicionPhone(pGrilla, pClave) {
    //var lRowIndex = qgrillas_obtenerValorRowIndexPhone(pGrilla, pClave);
    //gGrillas[pGrilla].ColIdEnEdicion = lRowIndex;
    //gGrillas[pGrilla].ValorPK = pClave;
    //gGrillas[pGrilla].ColumnaEnEdicion = "";
    //qgrillas_llenarDatosEdicionGeneral(pGrilla, lRowIndex, pClave, "");
    qgrillas_llenarDatosEdicionGeneral(pGrilla);
}


function qgrillas_obtenerValorRowIndexPhone(pGrilla, pValorPK) {
    //var columns = $("#" + pGrilla).igGrid("option", "columns");

    var igDs = $("#" + pGrilla).data("igGrid").dataSource;
    //debo buscar el valor 
    //for (var j = 0; j < igDs._data.length; j++) {
    //    if (igDs._data[j]["IDCol"] == pValorPK)
    for (var j = 0; j < igDs._dataView.length; j++) {
        if (igDs._dataView[j]["IDCol"] == pValorPK)
        {
            gGrillas[pGrilla].ColIdEnEdicion = j;
            gGrillas[pGrilla].ValorPK = pValorPK;
            gGrillas[pGrilla].ColumnaEnEdicion = "";

        }
            //return j;
    }
    //return -1;
}

function qgrillas_Borrar(pGrilla, pClave) {
    $(pGrilla).igGridUpdating("deleteRow", pClave);
    $(pGrilla).igGrid("dataBind");
    qevt_EjecutarSiguiente();
}

function qgrillas_EditarFilaEnGrilla(pGrilla, pClave) 
{
    var mode = $(pGrilla).igGridUpdating("option", "editMode");
    $(pGrilla).igGridUpdating("option", "editMode", "dialog");
    $(pGrilla).igGridUpdating("startEdit", pClave, pClave, true);   
    qevt_EjecutarSiguiente();
}


function qgrillas_ControlFoco(pGrilla)
{
    var columns = $("#" + pGrilla).igGrid("option", "columns");
    var lEncontre = false;
    var lControl = null;
    for (var i = 0; (i < columns.length) && (!lEncontre); i++) {
        var lNombreTabla = gGrillas[pGrilla].Tabla;
        if (gControles[lNombreTabla][0][columns[i].key] != null)
        {
            if ((gControles[lNombreTabla][0][columns[i].key].getControl().is(":visible")) &&
                (!(gControles[lNombreTabla][0][columns[i].key].getControl().is(":disabled"))))
            {
                lControl = gControles[lNombreTabla][0][columns[i].key].getControl();
                lEncontre = true;
            }
        }
    }
    return lControl;
}

function qgrillas_validarDatosFila(pGrilla) {
    var lTodoOK = true;
    qcom_HabilitoGuardar();
    if (gGrillas[pGrilla].CamposPK != "")
    {
        var igDs = $("#" + pGrilla).data("igGrid").dataSource;        
        var lCamposClaves = gGrillas[pGrilla].CamposPK.split("|");
        var lNombreTabla = gGrillas[pGrilla].Tabla;
        for (var j = 0; (j < igDs._data.length) && lTodoOK; j++) {
            if ((gGrillas[pGrilla].ColIdEnEdicion == -1) || (gGrillas[pGrilla].ValorPK != igDs._data[j]["IDCol"])) {
                var lIguales = true;
                for (var i = 0; (i < lCamposClaves.length) && lIguales; i++) {
                    if (gControles[lNombreTabla][0][lCamposClaves[i]] != null) {
                        if (qcom_ObtenerValorControl(gControles[lNombreTabla][0][lCamposClaves[i]]) != igDs._data[j][lCamposClaves[i]]) {
                            lIguales = false;
                        }
                    }
                }
                if (lIguales) {
                    qevt_VaciarEventosTmp();
                    lTodoOK = false;
                    qcom_Alerta(qrecItemYaIngresado, 'danger', null);
                }
            }
        }
   }
    if (lTodoOK)
        qevt_EjecutarSiguiente();
    //return lTodoOK;
}

function qgrillas_EjecutarSobreFilaSelec(pNombreAccion, pNombreGrilla, pTipoAccion /*D:DownLoad, P:Mostrar PDF, '':Comun*/, pTablasARefrescar, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarSobreFilaSelecGral(pNombreAccion, pNombreGrilla, pTipoAccion /*D:DownLoad, P:Mostrar PDF, '':Comun*/, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, false)
}

function qgrillas_EjecutarSobreFilaColSelec(pNombreAccion, pNombreGrilla, pTipoAccion /*D:DownLoad, P:Mostrar PDF, '':Comun*/, pTablasARefrescar, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarSobreFilaSelecGral(pNombreAccion, pNombreGrilla, pTipoAccion /*D:DownLoad, P:Mostrar PDF, '':Comun*/, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, true)
}


function qgrillas_EjecutarSobreFilaSelecGral(pNombreAccion, pNombreGrilla, pTipoAccion /*D:DownLoad, P:Mostrar PDF, '':Comun*/, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, pSelecCol)
{
    var lNombreTabla = "";
    var lPos = -1;
    var lColSel = "";
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    if (lNombreTabla != '') {
        //Obtengo la fila en donde se encuentra parado
        if (gGrillas[pNombreGrilla].EsArbol) {
        var lLong = gEntidad[lNombreTabla].length;
            var lPKArbol = gGrillas[pNombreGrilla].CamposPK;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (gEntidad[lNombreTabla][i][lPKArbol] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        else {
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
            if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                lPos = i;
            }
        }
    }
        lColSel = gGrillas[pNombreGrilla].ColumnaEnEdicion;
    }
    if (lPos <= -1) {
        qevt_VaciarEventosTmp();
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }
    else {
        var lEsDownLoad = (pTipoAccion != '');
        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad); //JSON.stringify(gEntidad);
        if (!pSelecCol)
        var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=S";
        else
            var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=SCol";

        var lData = {pDsEntidad: ldataset, pIndice: lPos, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(), 
                     pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(), 
                     pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
                     pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
                     pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'), pFormulario: gConfiguracion.getFormulario(), 
                    pIdSes: lIdSes, pEsDownload: lEsDownLoad, pColumna: lColSel
        };
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                //Proceso el mensajes de consulta
                if (msg.e == undefined) {
                    if (pTipoAccion == '') {
                        qcom_HabilitarGuardar();
                        //gEntidad = JSON.parse(msg.d);
                        //qcom_TablasPlanasaControles("");
                        gEntidad = qcom_CargarTablasARefrescar(pTablasARefrescar, msg, gEntidad);
                        pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                        qcom_TablasPlanasaControles(pTablasARefrescar);
                        $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                            var lNombreTabla = gGrillas[lGrilla].Tabla;
                            if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                                if (gGrillas[lGrilla].AutoFormateable) {
                                    qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla], gEntidad[lNombreTabla + 'fmt']);
                                }
                                else {
                                    //gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                                    if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla].length == 0))
                                        gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                                    else {
                                        var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                                        var lUltAutonum = gEntidad[lNombreTabla][gEntidad[lNombreTabla].length - 1][lCampoAutoNum];
                                        gGrillas[lGrilla].UltimaPK = lUltAutonum;
                                    }
                                    if (!gGrillas[lGrilla].EsArbol) {
                                        gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                        gGrillas[lGrilla].Control.igGrid("dataBind");
                                    }
                                    else {
                                        gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                        gGrillas[lGrilla].Control.igTreeGrid("dataBind");
                                    }
                                }
                            }
                        });
                        $.each(gListasAdjuntosAux, function (lClave, lValor) {
                            var lNombreTabla = gListasAdjuntos[lValor].Tabla;
                            //Solo debo actualizar las tablas que se deban refrescar
                            if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                                var lNombreControl = gListasAdjuntos[lValor].NombreControl;
                                qlstadj_VaciarLista(lNombreControl);
                                for (var l = 0; l < gEntidad[lNombreTabla].length; l++) {
                                    if (gEntidad[lNombreTabla][l].Estado != gEstadoAdjunto["Borrado"]) {
                                        qlstadj_AgregarVistaAdjunto(lNombreControl, false, l, l);
                                    }
                                }
                                gListasAdjuntos[lValor].UltId = gEntidad[lNombreTabla].length;
                            }
                        });

                        qevt_EjecutarSiguiente();
                    }
                    else if (pTipoAccion == 'D'){ //si es download
                        //var lDatosDownLoad = JSON.parse(msg);
                        var lDatosDownLoad = msg;
                        var ltipocont = qcom_ObtenerTipoContDownLoad(lDatosDownLoad.Principal[0].EsURL, lDatosDownLoad.Principal[0].Extension);
                        //$("#reftemporal").attr('href', ltipocont + lDatosDownLoad.Principal[0].Archivo);
                        //$("#reftemporal").attr('download', lDatosDownLoad.Principal[0].NombreArchivoDescargado);

                        var elem = window.document.createElement('a');
                        elem.id = "reftemporal";
                        elem.innerText = lDatosDownLoad.Principal[0].Titulo;
                        elem.href = ltipocont + lDatosDownLoad.Principal[0].Archivo;
                        elem.download = lDatosDownLoad.Principal[0].NombreArchivoDescargado;
                        document.body.appendChild(elem);     
                        //solo paso el nombre "temporal" porque el método le agrega el href, porque se utiliza tambien con los controles con campos asociados
                        qcom_DescargarArchivo("temporal", false)
                        document.body.removeChild(elem);
                        //$("#reftemporal").attr('href', '#');
                        //$("#reftemporal").attr('download', '');
                        qevt_EjecutarSiguiente();
                    }
                    else if (pTipoAccion=='P')
                    {
                        //var lDatosPDF = JSON.parse(msg);
                        var lDatosPDF = msg;
                        //window.open("data:application/pdf;base64, " + lDatosPDF.Principal[0].Archivo);
                        var pdfWindow = window.open("")
                        pdfWindow.document.write("<iframe width='100%' height='100%' src='data:application/pdf;base64, " + encodeURI(lDatosPDF.Principal[0].Archivo) + "'></iframe>")
                        qevt_EjecutarSiguiente();
                    }
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
}


/**TODO : acomodar para seleccion en phone**/
function qgrillas_EjecutarSobreFilaSelecMasiva(pNombreAccion, pNombreGrilla, pTablasARefrescar, pTablasAEnviar, pEsEspecializada) {
    var lNombreTabla = "";
    var lPos = -1;
    var lEntidadAyuda = null;
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    if (lNombreTabla != '') {
        lEntidadAyuda = qcom_Clonar(gEntidadAyuda);
        //Debo pasar como parametro todos menos la tabla masiva
        $.each(gEntidad, function (lClave, lValor) {
            if (lClave != lNombreTabla)
                lEntidadAyuda[lClave] = qcom_Clonar(gEntidad[lClave])
        });
        //Borro todos los registros que pudiese tener la tabla en ayuda
        lEntidadAyuda[lNombreTabla].splice(0, lEntidadAyuda[lNombreTabla].length);
        var lCell = $("#" + pNombreGrilla).igGridSelection("selectedCell");
        if (lCell != undefined)
        {
            var igDs = $("#" + pNombreGrilla).data("igGrid").dataSource;
            lEntidadAyuda[lNombreTabla].push(jQuery.extend({}, igDs._dataView[lCell.rowIndex]));
            lPos = 0;
        }
    }
    if (lPos <= -1) {
        qevt_VaciarEventosTmp();
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }
    else {
        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        //var ldataset = JSON.stringify(lEntidadAyuda);
        var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, lEntidadAyuda);

        var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=S";
        //Paso siempre en 0, porque siempre va a ir un solo registro en la masiva
        var lData = {pDsEntidad: ldataset, pIndice: 0, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
            pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
            pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
            pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
            pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'), pFormulario: gConfiguracion.getFormulario(),
            pIdSes: lIdSes, pEsDownload: false};
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            //data: "{'pDsEntidad':'" + ldataset + "', 'pIndice': '" + lPos + "',  'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreAccion':'" + pNombreAccion + "', 'pTablasPlanas':'" + gTablasPlanas.join('|') + "', 'pFormulario':'" + gConfiguracion.getFormulario() + "'}",
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                //Proceso el mensajes de consulta
                if (msg.e == undefined) {
                    qcom_HabilitarGuardar();
                    //gEntidad = JSON.parse(msg.d);
                    //lEntidadAyuda = JSON.parse(msg);
                    lEntidadAyuda = msg;
                    //Debo refrescar todas la tablas menos la que tiene muchos datos
                    pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                    $.each(lEntidadAyuda, function (lClave, lValor) {
                        if ((lClave != lNombreTabla) && 
                             ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1))) 
                            gEntidad[lClave] = qcom_Clonar(lEntidadAyuda[lClave]);
                    });
                    
                    qcom_TablasPlanasaControles(pTablasARefrescar);

                    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                        var lNombreTabla2 = gGrillas[lGrilla].Tabla;
                        if ((lNombreTabla2 != lNombreTabla) &&
                            ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)))
                        {
                            if (gGrillas[lGrilla].AutoFormateable) {
                                qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla2], gEntidad[lNombreTabla2+'fmt']);
                            }
                            else {
                                //gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla2].length;
                                if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla2].length == 0))
                                gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla2].length;
                                else {
                                    var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                                    var lUltAutonum = gEntidad[lNombreTabla2][gEntidad[lNombreTabla2].length - 1][lCampoAutoNum];
                                    gGrillas[lGrilla].UltimaPK = lUltAutonum;
                                }
                                gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla2]);
                                gGrillas[lGrilla].Control.igGrid("dataBind");
                            }
                        }
                    });
                    qevt_EjecutarSiguiente();
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
}


function qgrillas_EjecutarSobreFilaSelecMasivaConAct(pNombreAccion, pNombreGrilla, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, pFinEdicionFila) {
    var lNombreTabla = "";
    var lPos = -1;
    var lEntidadAyuda = null;
    var lPKIndexCell = -1;
    var lPK = -1;
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    if (lNombreTabla != '') {
        lEntidadAyuda = qcom_Clonar(gEntidadAyuda);
        //Debo pasar como parametro todos menos la tabla masiva
        $.each(gEntidad, function (lClave, lValor) {
            if (lClave != lNombreTabla)
                lEntidadAyuda[lClave] = qcom_Clonar(gEntidad[lClave])
        });
        //Borro todos los registros que pudiese tener la tabla en ayuda
        lEntidadAyuda[lNombreTabla].splice(0, lEntidadAyuda[lNombreTabla].length);
        var igDs = $("#" + pNombreGrilla).data("igGrid").dataSource;

        if (!pFinEdicionFila) { //Sino es fin edicion fila, busco la fila seleccionada

            var lCell = $("#" + pNombreGrilla).igGridSelection("selectedCell");
            if (lCell != undefined) {
                lEntidadAyuda[lNombreTabla].push(jQuery.extend({}, igDs._dataView[lCell.rowIndex]));
                lPK = igDs._dataView[lCell.rowIndex]["IDCol"];
                lPKIndexCell = lCell.rowIndex;
                lPos = 0;
            }
        }
        else { //si es fin edicion fila, busco la ultima fila editada
            var lEncontre = false;
            for (var j = 0; (!lEncontre) && (j < igDs._dataView.length) ; j++) {
                if (igDs._dataView[j]["IDCol"] == gGrillas[pNombreGrilla].IDFinEdicion) {
                    lPK = gGrillas[pNombreGrilla].IDFinEdicion;
                    lPKIndexCell = j;
                    lPos = j;
                    lEntidadAyuda[lNombreTabla].push(jQuery.extend({}, igDs._dataView[j]));
                    lEncontre = true;
                }
            }
        }
    }
    //Despues de utilizado lo blanqueo
    gGrillas[pNombreGrilla].IDFinEdicion = -1;
    if (lPos <= -1) {
        qevt_VaciarEventosTmp();
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }
    else {
        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        //var ldataset = JSON.stringify(lEntidadAyuda);
        var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, lEntidadAyuda);

        var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=S";
        //Paso siempre en 0, porque siempre va a ir un solo registro en la masiva
        var lData = {
            pDsEntidad: ldataset, pIndice: 0, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
            pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
            pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
            pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
            pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'), pFormulario: gConfiguracion.getFormulario(),
            pIdSes: lIdSes, pEsDownload: false
        };
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            //data: "{'pDsEntidad':'" + ldataset + "', 'pIndice': '" + lPos + "',  'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreAccion':'" + pNombreAccion + "', 'pTablasPlanas':'" + gTablasPlanas.join('|') + "', 'pFormulario':'" + gConfiguracion.getFormulario() + "'}",
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                //Proceso el mensajes de consulta
                if (msg.e == undefined) {
                    qcom_HabilitarGuardar();
                    //gEntidad = JSON.parse(msg.d);
                    //lEntidadAyuda = JSON.parse(msg);
                    lEntidadAyuda = msg;
                    //Debo refrescar todas la tablas menos la que tiene muchos datos
                    pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                    $.each(lEntidadAyuda, function (lClave, lValor) {
                        if ((lClave != lNombreTabla) &&
                            ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)))
                            gEntidad[lClave] = qcom_Clonar(lEntidadAyuda[lClave]);
                    });

                    qcom_TablasPlanasaControles(pTablasARefrescar);

                    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                        var lNombreTabla2 = gGrillas[lGrilla].Tabla;
                        if ((lNombreTabla2 != lNombreTabla) &&
                            ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1))) {
                            if (gGrillas[lGrilla].AutoFormateable) {
                                qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla2], gEntidad[lNombreTabla2 + 'fmt']);
                            }
                            else {
                                //gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla2].length;
                                if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla2].length == 0))
                                    gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla2].length;
                                else {
                                    var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                                    var lUltAutonum = gEntidad[lNombreTabla2][gEntidad[lNombreTabla2].length - 1][lCampoAutoNum];
                                    gGrillas[lGrilla].UltimaPK = lUltAutonum;
                                }
                                gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla2]);
                                gGrillas[lGrilla].Control.igGrid("dataBind");
                            }
                        }
                        else if (lNombreTabla2 == lNombreTabla) {
                            lEntidadAyuda[lNombreTabla][0].IDCol = lPK;
                            var lValores = qcom_Clonar(gClones[lNombreTabla]);
                            var columns = $("#" + pNombreGrilla).igGrid("option", "columns");
                            if ($("#" + pNombreGrilla).igGridUpdating("isEditing")) {
                                //Salvo la referencia a la celda en edición, porque el endEdit que hago despues la va a pisar
                                var lFilaFoco = gGrillas[pNombreGrilla].FilaFoco;
                                var lColumnaFoco = gGrillas[pNombreGrilla].ColumnaFoco;
                                for (var i = 0; i < columns.length; i++) {
                                    if (lEntidadAyuda[lNombreTabla][0][columns[i].key] != undefined) {
                                        lValores[columns[i].key] = lEntidadAyuda[lNombreTabla][0][columns[i].key];
                                        igDs._dataView[lPKIndexCell][columns[i].key] = lEntidadAyuda[lNombreTabla][0][columns[i].key];
                                        //$("#" + pNombreGrilla).data("igGrid").dataSource.setCellValue(lPK, columns[i].key, "NEW VALUE", true);
                                        //$("#" + pNombreGrilla).igGrid("cellById", lPK, columns[i].key).text(lEntidadAyuda[lNombreTabla][0][columns[i].key]);
                                        $("#" + pNombreGrilla).igGridUpdating("setCellValue", lPK, columns[i].key, lEntidadAyuda[lNombreTabla][0][columns[i].key]);
                                    }                                   

                                }
                                if ((lFilaFoco != -1) && (lColumnaFoco != -1)) {
                                    $("#" + pNombreGrilla).igGridUpdating("endEdit", false);
                                    $("#" + pNombreGrilla).igGridUpdating("startEdit", lFilaFoco, lColumnaFoco);
                                }
                            }
                            else {
                            for (var i = 0; i < columns.length; i++) {
                                if (lEntidadAyuda[lNombreTabla][0][columns[i].key] != undefined)
                                    lValores[columns[i].key] = lEntidadAyuda[lNombreTabla][0][columns[i].key];
                                else
                                    lValores[columns[i].key] = igDs._dataView[lPKIndexCell][columns[i].key];
                            }
                            $("#" + pNombreGrilla).igGridUpdating("updateRow", lPK, lValores);
                        }
                        }

                    });
                    qevt_EjecutarSiguiente();
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
}


function qgrillas_EjecutarCondicionEnGrilla(pNombreCondicion, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarAcccionGralEnGrilla(pNombreCondicion, pNombreGrilla, pFuncionCallBack, 'C', '', pTablasAEnviar, pEsEspecializada, '');
}


function qgrillas_MostrarReporteConParamDesdeServer(pNombreMetodo, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada, pNombreReporte) {
    qgrillas_EjecutarAcccionGralEnGrilla(pNombreMetodo, pNombreGrilla, pFuncionCallBack, 'R', '', pTablasAEnviar, pEsEspecializada, pNombreReporte);
}


function qgrillas_EjecutarAccionEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, pEsFinEdicionGrilla, pTablasAEnviar, pEsEspecializada) {
    if (pEsFinEdicionGrilla)
        qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, 'F', '', pTablasAEnviar, pEsEspecializada, '');
    else    
        qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, 'A', '', pTablasAEnviar, pEsEspecializada, '');
}

function qgrillas_EjecutarValidarFilaGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, 'V', '', pTablasAEnviar, pEsEspecializada, '');
}

function qgrillas_EjecutarValidarInicioEdicion(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, 'IEF', '', pTablasAEnviar, pEsEspecializada, '');
}


function qgrillas_ObtenerVariables(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, 'O', '', pTablasAEnviar, pEsEspecializada, '');
}


function qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTipoAccion, pCodigoConsulta, pTablasAEnviar, pEsEspecializada, pInfoAdic) {
    //Tipo Accion: V-Validar Fila; C-Condicion Fila; A-Accion En grilla; F: Está en Fin Edicion Grilla Detail
    pCodigoConsulta = (typeof pCodigoConsulta !== 'undefined') ? pCodigoConsulta : "";
    $('#divCargando').addClass('show');
    var lNombreTabla = "";
    if ((pNombreGrilla != "") &&  (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lNombreTablaMaster = "";
    var lEsMaster = false;
    var lEsDetail = false;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    //Clono el auxiliar
    var lAuxiliarClonado = null;
    var lPos = -1;
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined)) {
        //si la grilla es un master, entonces debo obtener todos los renglones sin comittear de los details
        //ya se encuentran 
        //si la grilla es un detail, debo obtener lod datos de la fila del master sin committear, las otras files del detail sin 
        //comittear, y los datos de la fila actual que se quiere comittear
        $.each(gRelacTablas, function (lClave, lValor) {
            if (lValor.getTablaMaster() == lNombreTabla) {
                lEsMaster = true;
                return false; //corto la busqueda
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetail = true;
                lNombreTablaMaster = lValor.getTablaMaster();
                return false; //corto la busqueda
            }
        });

        //si es un master o, no es ni master ni detail, entonces debo pasar la fila que actualmente se está editando 
        var lFila = qgrillas_ArmarObjetoFilaFila(pNombreGrilla);
        if ((lEsMaster) || ((!lEsMaster) && (!lEsDetail))) {
            gEntidadAux[lNombreTabla].splice(0);
            gEntidadAux[lNombreTabla].push(lFila);
            //busco la posición del registro actual del master
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1) ; i++) {
                if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        else if (lEsDetail) {
            gEntidadAux[lNombreTablaMaster].splice(0);
            lAuxiliarClonado = qcom_Clonar(gEntidadAux);
            var lFilaMaster = qgrillas_ArmarObjetoFilaFila("grd" + lNombreTablaMaster);
            lAuxiliarClonado[lNombreTablaMaster].push(lFilaMaster);
            //busco la posición del registro actual del detail, en el datatable de details aceptados
            var lLong = lAuxiliarClonado[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1) ; i++) {
                if (lAuxiliarClonado[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }

            //si no existia, lo agrego
            if (lPos == -1)
                lAuxiliarClonado[lNombreTabla].push(lFila);
            else //si existia, debo reemplazarlo
                lAuxiliarClonado[lNombreTabla][lPos] = lFila;
        }
    }
    var ldatasetAux = (lAuxiliarClonado == null) ? JSON.stringify(gEntidadAux) : JSON.stringify(lAuxiliarClonado);
    //var ldatasetAux = (lAuxiliarClonado == null) ? qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidadAux) : qcom_CargarTablasAEnviar(pTablasAEnviar,lAuxiliarClonado);
    var lIdSes = sessionStorage.getItem("idses");
    var lUrl = "";
    switch (pTipoAccion) {
        case 'V': lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=" + pTipoAccion;
            break;
        case 'C': lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=" + pTipoAccion;
            break;
        case 'R': lUrl = "AjaxHandler/ParamReporte.ashx?pTipo=F";
            break;
        case 'A': lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=" + pTipoAccion;
            break;
        case 'F': lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=A";
            break;
        case 'O': lUrl = "AjaxHandler/ObtenerVariablesFE.ashx";
            break;
        case 'IEF': lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=" + pTipoAccion;
            break;
        default: break;
    }
    var lData = {
        pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, pIndice: lPos,
        pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(),
        pIdSes: lIdSes, pCodigoConsulta: pCodigoConsulta};
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + lUrl,
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDsEntidadAux':'" + ldatasetAux + "', 'pIndice': '" + lPos + "',  'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreAccion':'" + pNombreAccion + "','pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            //Proceso el mensajes de consulta
            var lEsMsgError = (msg.e != undefined);
            if (lEsMsgError && msg.e.startsWith("cons:")) {
                qgrillas_EjecutarAcccionGralEnGrilla_Mens(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTipoAccion, msg, pTablasAEnviar, pEsEspecializada, pInfoAdic)
            }
            else if (!lEsMsgError) {
                switch (pTipoAccion) {
                    case 'V':
                        var lValorCond = msg.d;
                        if (lValorCond != "") {
                            qevt_VaciarEventosTmp();
                            qcom_Alerta(lValorCond, 'info', null);
                        }
                        else {
                            qevt_EjecutarSiguiente();
                        }
                        break;
                    case 'C': var lValorCond = msg.d;
                              qevt_EliminarNodosCond(lValorCond);
                              qevt_EjecutarSiguiente();
                        break;
                    case 'R': var lParRpt = msg.d;
                              var lNombreRpt = msg.m;
                              var lMetodoDatos  = msg.t;
                              if (lParRpt == "")
                                    lParRpt = qcom_ObtenerParametrosReporte();
                              if (lNombreRpt == "")
                                    lNombreRpt = pInfoAdic;
                              //sessionStorage.setItem("tiporpt", 'V');
                              qcom_MostrarReporte(lNombreRpt, lParRpt, lMetodoDatos, "");
                              qevt_EjecutarSiguiente();   
                        break;
                    case 'A': 
                            //ldatasetAux = JSON.parse(msg);
                            ldatasetAux = msg;
                            if (lPos == -1) {
                                if (ldatasetAux[lNombreTabla].length > 0)
                                    lPos = ldatasetAux[lNombreTabla].length - 1;
                                else
                                lPos = 0;
                            }
                            //La accion solo debe afectar solo el registro en edición, si quisiera afectar algo mas, deberia hacerse
                            //en la accion fin edicion fila
                            //Hay casos, en acciones del master que hay que refrescar toda la grilla de details
                            $.each(gControles[lNombreTabla][0], function (lClave, lValor) {
                                if (gControles[lNombreTabla][0][lClave] != null) {
                                    if ((lEsMaster) || (!lEsDetail)) //si es un master o no es un detail, debo actualizar siempre el registro de la posición 0
                                        qcom_AsignarValorControl(gControles[lNombreTabla][0][lClave], ldatasetAux[lNombreTabla][0][lClave], false);
                                    else
                                        qcom_AsignarValorControl(gControles[lNombreTabla][0][lClave], ldatasetAux[lNombreTabla][lPos][lClave], false);
                                }
                            });
                            if (lEsMaster)
                            {
                                $.each(gRelacTablas, function (lClave, lValor) {
                                    if (lValor.getTablaMaster() == lNombreTabla) {
                                        var lTablaDetailRet = lValor.getTablaDetalle();
                                        gEntidadAux[lTablaDetailRet].splice(0);
                                        if (lValor.getTipoCtrlDetalle() == "G") {
                                            var lGrillaDetailRet = 'grd' + lTablaDetailRet;
                                            $.each(ldatasetAux[lTablaDetailRet], function (lClave, lValor) {
                                                ldatasetAux[lTablaDetailRet][lClave]["IDCol"] = qgrillas_ObtenerNuevaPK(lGrillaDetailRet);;
                                                gEntidadAux[lTablaDetailRet].push(jQuery.extend({}, ldatasetAux[lTablaDetailRet][lClave]));
                                            });
                                            gGrillas[lGrillaDetailRet].Control.igGrid("option", "dataSource", gEntidadAux[lTablaDetailRet]);
                                            gGrillas[lGrillaDetailRet].Control.igGrid("dataBind");
                                        }
                                        else if (lValor.getTipoCtrlDetalle() == "A") {
                                            var lNombreControl = 'lstadj' + lTablaDetailRet;
                                            qlstadj_VaciarLista(lNombreControl);
                                            for (var l = 0; l < ldatasetAux[lTablaDetailRet].length; l++) {
                                                if (ldatasetAux[lTablaDetailRet][l].Estado != gEstadoAdjunto["Borrado"]) {
                                                    gEntidadAux[lTablaDetailRet].push(jQuery.extend({}, ldatasetAux[lTablaDetailRet][l]));
                                                    qlstadj_AgregarVistaAdjunto(lNombreControl, true, l, l);
                                                }
                                            }
                                            gListasAdjuntos.UltId = ldatasetAux[lTablaDetailRet].length;


                                        }
                                    }
                                });
                            }
                            qevt_EjecutarSiguiente();
                            break;
                    case 'F':
                        //ldatasetAux = JSON.parse(msg);
                        ldatasetAux = msg;
                         lPos = 0;
                        //La accion No afecta al registro en edición, ya que ya terminó la edición del registro.
                        //Como llegó acá, entonces es el fin de edicion de un detail, por lo tanto, debiera 
                        //actualizar el registro en edición del Master 
                        //¿Los valores de la grilla detail hay que actualizarlos?
                        $.each(gControles[lNombreTablaMaster][0], function (lClave, lValor) {
                            if (gControles[lNombreTablaMaster][0][lClave] != null)
                                qcom_AsignarValorControl(gControles[lNombreTablaMaster][0][lClave], ldatasetAux[lNombreTablaMaster][lPos][lClave], false);
                        });

                        //Daniel 13/01/2018 - Inicio
                        //Hay un caso, en tesoreria, que cuando se termina la edición de una fila de un detail,
                        //se necesita refrescar tambien la grilla de otro detail asociado al mismo master.
                        if (lEsDetail) 
                        {
                            //Actualizo todas las grillas hermanas
                            $.each(gRelacTablas, function (lClave, lValor) {
                                if (lValor.getTipoCtrlDetalle() == "G") {
                                    if ((lValor.getTablaMaster() == lNombreTablaMaster) &&
                                        (lValor.getTablaDetalle() != lNombreTabla)) {
                                        var lTablaDetailRet = lValor.getTablaDetalle();
                                        var lGrillaDetailRet = 'grd' + lTablaDetailRet;
                                        gEntidadAux[lTablaDetailRet].splice(0);
                                        $.each(ldatasetAux[lTablaDetailRet], function (lClave, lValor) {
                                            ldatasetAux[lTablaDetailRet][lClave]["IDCol"] = qgrillas_ObtenerNuevaPK(lGrillaDetailRet);;
                                            gEntidadAux[lTablaDetailRet].push(jQuery.extend({}, ldatasetAux[lTablaDetailRet][lClave]));
                                        });
                                        gGrillas[lGrillaDetailRet].Control.igGrid("option", "dataSource", gEntidadAux[lTablaDetailRet]);
                                        gGrillas[lGrillaDetailRet].Control.igGrid("dataBind");
                                    }
                                }
                            });

                        }
                        //Daniel 13/01/2018 - Fin
                        qevt_EjecutarSiguiente();
                        break;
                    case 'O': //Obtener Variobles
                        var lstVariables = JSON.parse(msg.d);
                        //en cada elemento viene como Id el nombre de la variable, y en Valor el valor de la misma
                        $.each(lstVariables, function (lClave, lValor) {
                            gVariables[lValor.Id] = lValor.Valor;
                        });
                        qevt_EjecutarSiguiente();
                        break;
                    case 'IEF':
                        var lValorCond = msg.d;
                        if (lValorCond != "") {
                            qevt_VaciarEventosTmp();
                            //qcom_Alerta(lValorCond, 'info', null);
                        }
                        else {
                            qevt_EjecutarSiguiente();
                        }
                        break;

                    default: qevt_EjecutarSiguiente();
                        break;

                }
            }
            else {
                if (qcom_existeControl('#divMensajeItera'))
                    $('#divMensajeItera').removeClass('show');
                qcom_TratarError(msg.e);
            }
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            if (qcom_existeControl('#divMensajeItera'))
                $('#divMensajeItera').removeClass('show');

            //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
            qcom_Alerta(thrownError, 'danger', null);
        });
}


function qgrillas_EjecutarAcccionGralEnGrilla_Mens(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTipoAccion, pMensajeConsulta, pTablasAEnviar, pEsEspecializada, pInfoAdic) {
    var lcomponentes = pMensajeConsulta.substring(5).split("|");
    qcom_Confirmar(lcomponentes[1], 'warning',
          function () { qgrillas_EjecutarAcccionGralEnGrilla(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTipoAccion, lcomponentes[0], pTablasAEnviar, pEsEspecializada, pInfoAdic) },
          function () { qevt_VaciarEventosTmp(); }
    )

}


function qgrillas_EjecutarAccionFilaEliminada(pNombreAccion, pNombreGrilla, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lNombreTablaMaster = "";
    var lEsDetail = false;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    //Clono el auxiliar
    var lAuxiliarClonado = null;
    var lPos = -1;
    //Si entró a este método la grilla debiera ser un detail. FilaEliminada en un master, debe tener acciones de BE
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetail = true;
                lNombreTablaMaster = lValor.getTablaMaster();
                return false; //corto la busqueda
            }
        }
    });

    if (!lEsDetail) {
        qevt_VaciarEventosTmp();
        qcom_Alerta('Fila Eliminada con Acciones de FE, solo es posible con Grillas de segundo nivel', 'danger', null);
    }
    else {
        var lFila = qgrillas_ArmarObjetoFilaFila("grd" + lNombreTablaMaster);
        gEntidadAux[lNombreTablaMaster].splice(0);
        gEntidadAux[lNombreTablaMaster].push(lFila);
        var ldatasetAux = JSON.stringify(gEntidadAux);
        var lIdSes = sessionStorage.getItem("idses");
        var lCodigoConsulta = "";
        var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=A";
        var lData = {pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, pIndice: lPos,
                     pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
                     pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
                     pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
                     pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
                     pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
                     pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(), 
                     pIdSes: lIdSes, pCodigoConsulta: lCodigoConsulta};
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                if (msg.e == undefined) {
                    //ldatasetAux = JSON.parse(msg);
                    ldatasetAux = msg;
                    //La accion No afecta al registro en edición, ya que ya terminó la edición del registro.
                    //Como llegó acá, entonces es el fin de edicion de un detail, por lo tanto, debiera 
                    //actualizar el registro en edición del Master 
                    //¿Los valores de la grilla detail hay que actualizarlos?
                    $.each(gControles[lNombreTablaMaster][0], function (lClave, lValor) {
                        if (gControles[lNombreTablaMaster][0][lClave] != null)
                            qcom_AsignarValorControl(gControles[lNombreTablaMaster][0][lClave], ldatasetAux[lNombreTablaMaster][0][lClave], false);
                    });

                    //if (typeof pFuncionCallBack == 'function') {
                    //    pFuncionCallBack();
                    //}
                    qevt_EjecutarSiguiente();
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
}


function qgrillas_EliminarFila(pNombreGrilla, pNombreAccionValidar, ui, pfnFilaEliminada, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lNombreTablaMaster = "";
    var lEsMaster = false;
    var lEsDetail = false;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    //Clono el auxiliar
    var lAuxiliarClonado = null;

    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaMaster() == lNombreTabla) {
                lEsMaster = true;
                return false; //corto la busqueda
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetail = true;
                lNombreTablaMaster = lValor.getTablaMaster();
                return false; //corto la busqueda
            }
        }
    });
    //Si es un master, entonces debo ejecutar una accion de BE
    var lPos = -1;
    var lIdSes = sessionStorage.getItem("idses");
    if ((lEsMaster) || ((!lEsMaster) && (!lEsDetail))) {
        var lData = {
            pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
            pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
            pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
            pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
            pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
            pNombreCondicion: pNombreAccionValidar, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes};
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + "AjaxHandler/Condicion.ashx",
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                if (lValorCond != "") {
                    qevt_VaciarEventosTmp();
                    qcom_Alerta(lValorCond, 'info', null);
                 }
                 else {
                    $('#' + pNombreGrilla).igGridUpdating("deleteRow", gGrillas[pNombreGrilla].FilaaBorrar);                    
                    qevt_EjecutarSiguiente();
                }
            }
            else
                qcom_TratarError(msg.e);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
            qcom_Alerta(thrownError, 'danger', null);
        });
    }
    // si es un detail, entonces debo ejecutar accion de FE
    else if (lEsDetail) {
        gEntidadAux[lNombreTablaMaster].splice(0);
        lAuxiliarClonado = qcom_Clonar(gEntidadAux);
        var lFilaMaster = qgrillas_ArmarObjetoFilaFila("grd" + lNombreTablaMaster);
        lAuxiliarClonado[lNombreTablaMaster].push(lFilaMaster);
        //busco la posición del registro actual del detail, en el datatable de details aceptados
        var lLong = lAuxiliarClonado[lNombreTabla].length;
        for (var i = 0; (i < lLong) && (lPos == -1) ; i++) {
            if (lAuxiliarClonado[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                lPos = i;
            }
        }

        var ldatasetAux = (lAuxiliarClonado == null) ? JSON.stringify(gEntidadAux) : JSON.stringify(lAuxiliarClonado);
        var lUrl = gConfiguracion.getSitio() + "AjaxHandler/AcGrillas.ashx?pTipoAccion=V";
        var lData = {pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, pIndice: lPos, pDllEventos: gFormulario.getDLLEventos(), 
                pClaseEventos: gFormulario.getClaseEventos(), pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
                pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(), 
                pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
                pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
                pNombreAccion: pNombreAccionValidar, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes};
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            data: lData,
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                if (msg.e == undefined) {
                    var lValorCond = msg;
                    if (lValorCond != "") {
                        qevt_VaciarEventosTmp();
                        qcom_Alerta(lValorCond, 'info', null);
                    }
                    else {
                        $('#' + pNombreGrilla).igGridUpdating("deleteRow", gGrillas[pNombreGrilla].FilaaBorrar);
                        gTieneSinGuardar = true;
                        qevt_EjecutarSiguiente();
                    }
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });

    }

}

function qgrillas_FiltrarGrilla(pNombreGrilla, pTablaMaster) {
    var lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lColMaster = "";
    var lColDetalle = "";
    //Si entró a este método la grilla debiera ser un detail. 
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if ((lValor.getTablaDetalle() == lNombreTabla) &&
                (pTablaMaster == lValor.getTablaMaster())) {
                //cargo todos los campos y filtro
                lColMaster = lValor.getColMaster();
                lColDetalle = lValor.getColDetalle();
                return false; //corto la busqueda
            }
        }
    });

    var lNombreGrillaMaster = 'grd' + pTablaMaster;
    if (gGrillas[lNombreGrillaMaster] != undefined) {
        var lCeldaSelMaster = $("#" + lNombreGrillaMaster).igGridSelection("selectedCell");
        var lValorPK = $("#" + lNombreGrillaMaster).igGrid("getCellValue", lCeldaSelMaster.rowIndex, lColMaster);
        $("#" + pNombreGrilla).igGridFiltering("filter", ([{ fieldName: lColDetalle, expr: lValorPK, cond: "equals", logic: "AND" }]));        
    }

    qevt_EjecutarSiguiente();
}


function qgrillas_CambiarModoEdicion()
{
    $.each(gGrillas, function (lClave, lGrilla) {
        if (lGrilla.Editable) 
        {
            var mode = lGrilla.Control.igGridResponsive("getCurrentResponsiveMode");
            if (mode == "phone")
            {
                lGrilla.Control.igGridUpdating("option", "excelNavigationMode", false);  
                lGrilla.Control.igGridUpdating("option", "editMode", "dialog"); 
            }
            else
            {
                lGrilla.Control.igGridUpdating("option", "editMode", "cell"); 
                lGrilla.Control.igGridUpdating("option", "excelNavigationMode", false);                  
            }
        }
    })            
}

//function qgrillas_CrearGrilla(pNombreGrilla, pDatos, pfmtTabla) {
//    gTieneGrillasAutoForm = true;
//    if ($("#" + pNombreGrilla).data("igGrid") != null)
//        $("#" + pNombreGrilla).igGrid("destroy");

//    var lRegistrosxPagina = gGrillas[pNombreGrilla].RegistrosPorPagina;
//    var lColumnasFijas = gGrillas[pNombreGrilla].ColumnasFijas;
//    var lstFeatures = [];

//    lstFeatures.push({
//        name: 'Selection',
//        mode: 'cell',
//        multipleSelection: false,
//        activation: true,
//        cellSelectionChanged: function (evt, ui) {
//            // if ($(window).width() >= gSizePhone)
//            qgrillas_SeleccionarCelda(pNombreGrilla, ui.cell.rowIndex, ui.cell.rowId, ui.cell.columnKey, false);
//        }
//    });
//    lstFeatures.push({
//        name: "Resizing",
//        deferredResizing: false,
//        allowDoubleClickToResize: false,
//    });



//    if (lRegistrosxPagina > 0) {
//        lstFeatures.push({
//            name: "Paging",
//            type: "local",
//            pageSize: lRegistrosxPagina,
//            recordCountKey: "recordCountKey",
//            pageIndexUrlKey: "pageIndex",
//            pageSizeUrlKey: "pageSize",
//        });

//        lstFeatures.push({
//            name: "Filtering",
//            type: "local",
//        });

//    }

    
//    if (pfmtTabla != null) {
//        var lColUpdSetting = [];
//        var lColDef = [];

        
//        for (var i = 0; i < pfmtTabla.length; i++) {
//            var lNombreCol = pfmtTabla[i]["Columna"];
//            var lOculto = (lNombreCol == "Formato");
//            var lreadOnly = false;
//            if ((pfmtTabla[i]["Columna"] == "Formato") || (pfmtTabla[i]["IDCol"]) || (i < lColumnasFijas))
//                lreadOnly = true;
            
//            var lEditor = "text";
//            var leditorOptions = [];
            

//            switch (pfmtTabla[i]["Tipo"]) {
//                case 'int': lEditor = "number";
//                            leditorOptions.push({ dataMode: "int" });
//                            lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'number', columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", format: "0" });
//                    break;
//                case 'number': lEditor = "number";
//                               leditorOptions.push({ dataMode: "double", maxDecimals: 4, minDecimals: 2 });
//                               lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'number', columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", format: "0.0000" });
//                    break;
//                case 'date': lEditor = "datepicker";
//                            leditorOptions.push({ dateInputFormat: "dd/MM/yyyy", dateDisplayFormat: "dd/MM/yyyy", locale: "es", dataMode: "date" });
//                            lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'date', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", format: "dd/MM/yyyy"/*, formatter: "function(val, record) { return qcom_FormatearFechaGrilla(val, '-'); }"*/ });
//                    break;
//                case 'bool': lEditor = "checkbox";
//                    lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'bool' });
//                    break;
                
//                default: lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'string', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", hidden: lOculto });
//            }
//            lColDef.push({ headerText: "IDCol", key: "IDCol", dataType: "number", hidden: true });

//            lColUpdSetting.push({
//                columnKey: lNombreCol,
//                readOnly: lreadOnly,
//                editorType: lEditor,
//                editorOptions: (leditorOptions.length > 0) ? leditorOptions[0] : null,
//            });
//        }
//        if (gGrillas[pNombreGrilla].Editable) {
//            lstFeatures.push({
//                name: "Updating",
//                enableAddRow: false,
//                enableDeleteRow: false,
//                startEditTriggers: ["dblclick", "enter"],
//                showDoneCancelButtons: false,
//                excelNavigationMode: true,
//                editMode: "cell",
//                columnSettings: lColUpdSetting,
//                //editCellStarting: function (evt, ui) {
//                //    //solo se pueden editar las columnas que no son fijas
//                //    if (lColumnasFijas > 0) {
//                //        gridColumns = $("#" + pNombreGrilla).igGrid("option", "columns");
//                //        var lesFija = false;
//                //        for (var lcolFix = 0; (lcolFix < lColumnasFijas) && (!lesFija) ; lcolFix++) {
//                //            lesFija = (ui.columnKey == gridColumns[lcolFix].key);
//                //        }
//                //        return (!lesFija);
//                //    }

//                //}
//            });
//        }



//        if (lColumnasFijas == 0) {
//            lstFeatures.push({
//                name: "Responsive",
//                enableVerticalRendering: false,
//                reactOnContainerWidthChanges: true,
//            });
//        }
//        else {
//            var lColSettings = [];
//            lstFeatures.push({
//                name: "ColumnFixing",
//                showFixButtons: false,
//                columnSettings: lColSettings,
//            });
//        }
//    }
//    //var lRenderedCompleto = false;

//    $("#" + pNombreGrilla).igGrid({
//        autoGenerateColumns: true,
//        autofitLastColumn: true,
//        autoFormat: true,
//        renderCheckboxes: true,
//        disabled: false,
//        dataSource: pDatos,
//        width: "100%",
//        heigth: "81px",
//        primaryKey: "IDCol",
//        autoCommit: true,
//        defaultColumnWidth: (lColumnasFijas > 0) ? "*" : null, //El * significa que se ajusta al contenido de la columna
//        columns:lColDef,
//        features: lstFeatures,
//        rendered: function (evt, ui) {

//            gridColumns = $("#" + pNombreGrilla).igGrid("option", "columns");

//            var lColumsLong = gridColumns.length;
//            //if (lColumsLong > 0)
//            //    $("#" + pNombreGrilla).igGrid("hideColumn", "IDCol");
//            //for (var i = 0; (i < lColumsLong) ; i++) {
//            //    if (gridColumns[i].dataType == "number") {
//            //        gridColumns[i].columnCssClass = "alignCol-derecha";
//            //        gridColumns[i].headerCssClass = "alignHeaderCol-derecha";
//            //    }
//            //    else if (gridColumns[i].dataType == "date") {
//            //        gridColumns[i].format = "dd/MM/yyyy";
//            //        //gridColumns[i].dataType = "date";
//            //    }
//            //}
//            if (lColumsLong > 0) {
//                for (var lcolFix = 0; lcolFix < lColumnasFijas; lcolFix++)
//                    $("#" + pNombreGrilla).igGridColumnFixing("fixColumn", lcolFix, false);
//            }
//            //if (!lRenderedCompleto) {
//            //    if ((gGrillas[pNombreGrilla].Editable) && (lColumnasFijas > 0) && (lColumsLong > 0)) {
//            //        var columnSettings = $("#" + pNombreGrilla).igGridUpdating("option", "columnSettings");
//            //        //Debo completar todas las columnas que van a ser readonly.
//            //        //Generalmente columnSetting se crea con un registro todo vacío
//            //        //Agrego un elemento al arreglo por cada columna fija.
//            //        //Para ello parto de un objeto colnado del que se crea por defecto
//            //        for (var i = 1; (i <= lColumnasFijas) ; i++) {
//            //            var lObjClonado = qcom_Clonar(columnSettings[0]);
//            //            lObjClonado.readOnly = true;
//            //            lObjClonado.columnKey = gridColumns[i - 1].key;
//            //            columnSettings.push(lObjClonado);
//            //        }
//            //        //esta sentencia hace que se ejecute de nuevo el rendered, y entra en loop, entonces debemos asegurarnos de ejcutarla una sola vez
//            //        lRenderedCompleto = true;
//            //        $("#" + pNombreGrilla).igGridUpdating("option", "columnSettings", columnSettings);
//            //    }
//            //}
//        },

//    });
//}

var qgrillas_ObtenermascaraNumerica = function (pFormato) {
    if (pFormato.startsWith('N') || (pFormato.startsWith('NM'))) {
        if ((pFormato == "N") || ((pFormato == "NM"))) {
            if (pFormato == "N")
                return "0";
            else
                return "#,##0";
        }
        else {
            var lDecimales = 0;
            var lFormat = "";
            if (pFormato.length == 2) {
                lDecimales = pFormato.charAt(1);
                lFormat = "###0." + ("0000000000").slice(10-lDecimales);
            }
            else {
                lDecimales = pFormato.charAt(2);
                lFormat = "#,##0." + ("0000000000").slice(10-lDecimales);
            }
            return lFormat;
        }
    }
    return "0.0000";
}


var qgrillas_FormatearSegunTipoFila = function (val, record) {
    if (record != undefined) {
        var lFormato = qgrillas_ObtenermascaraNumerica(record.FormatoNumeroFila);
        return $.ig.formatter(val, "number", lFormato);
    }
    else 
        //return parseFloat(val).toFixed(4);
        //return new Intl.NumberFormat('en', { minimumIntegerDigits: 1, maximumFractionDigits: 4, minimumFractionDigits: 4, useGrouping: true }).format(val);
        return $.ig.formatter(val, "number", "0.0000");
}





function qgrillas_CrearGrilla(pNombreGrilla, pDatos, pfmtTabla) {
    gTieneGrillasAutoForm = true;
    lTieneFormatoPorFila = false; 
    var lMostrarAntesdeCrear = false;
    if ($("#" + pNombreGrilla).data("igGrid") != null) {
        //esto solo se hace para corregir un tema de visualización cuando tiene columnas fijas..se ve mal la primera vez
        if (!$("#div" + pNombreGrilla).is(":Visible"))
            lMostrarAntesdeCrear = ($("#" + pNombreGrilla).igGrid("option", "columns").length == 0);
        $("#" + pNombreGrilla).igGrid("destroy");
    }
    var lRegistrosxPagina = gGrillas[pNombreGrilla].RegistrosPorPagina;
    var lstColumnasFijas = (gGrillas[pNombreGrilla].ColumnasFijas.trim()!="")?gGrillas[pNombreGrilla].ColumnasFijas.replace(' ', '').split(','):[];
    var lstColumnasSoloLectura = (gGrillas[pNombreGrilla].ColumnasSoloLectura.trim()!="")?gGrillas[pNombreGrilla].ColumnasSoloLectura.replace(' ', '').split(','):[];
    var lstColumnasOcultas = (gGrillas[pNombreGrilla].ColumnasOcultas.trim()!="")?gGrillas[pNombreGrilla].ColumnasOcultas.replace(' ', '').split(','):[];

    var lstColsQueModifTotal = [];
    var lstFeatures = [];
    

    lstFeatures.push({
        name: 'Selection',
        mode: 'cell',
        multipleSelection: false,
        activation: true,
        cellSelectionChanged: function (evt, ui) {
            console.log(ui.cell.rowIndex + '- ' +  ui.cell.rowId + ' - '  + ui.cell.columnKey)
            // if ($(window).width() >= gSizePhone)
            //qgrillas_SeleccionarCelda(pNombreGrilla, ui.cell.rowIndex, ui.cell.rowId, ui.cell.columnKey, false);
        }
    });
    lstFeatures.push({
        name: "Resizing",
        deferredResizing: false,
        allowDoubleClickToResize: false,
    });



    if (lRegistrosxPagina > 0) {
        lstFeatures.push({
            name: "Paging",
            type: "local",
            pageSize: lRegistrosxPagina,
            recordCountKey: "recordCountKey",
            pageIndexUrlKey: "pageIndex",
            pageSizeUrlKey: "pageSize",
        });

        if (pDatos != null) {
            if (pDatos.length > 0) {
                lstFeatures.push({
                    name: "Filtering",
                    type: "local",
                });
            }
        }
    }

    var lColUpdSetting = [];
    var lColDef = [];
    var lColFixDef = [];

    if ((pfmtTabla != null) && (pfmtTabla.length > 0)) {


        for (var i = 0; i < pfmtTabla.length; i++) {
            var lNombreCol = pfmtTabla[i]["Columna"];
            var lOculto = (jQuery.inArray(pfmtTabla[i]["Columna"], lstColumnasOcultas) != -1);  //(lNombreCol == gGrillas[pNombreGrilla].ColFmtNumFila);
            if (lNombreCol == gGrillas[pNombreGrilla].ColFmtNumFila)
                lTieneFormatoPorFila = true;

            var lreadOnly = false;

            if ((pfmtTabla[i]["Columna"] == gGrillas[pNombreGrilla].ColFmtNumFila) ||
                    (pfmtTabla[i]["Columna"] == "IDCol") ||
                    (jQuery.inArray(pfmtTabla[i]["Columna"], lstColumnasSoloLectura) != -1))           
                lreadOnly = true;

            var lEditor = "text";
            var leditorOptions = [];

            var lAncho = "*";
            //if (i < lColumnasFijas) {
            var lposColumnaFija = jQuery.inArray(pfmtTabla[i]["Columna"], lstColumnasFijas);
            if (lposColumnaFija != -1) {
                lColFixDef.push({ columnKey: lNombreCol, allowFixing: false, isFixed: true });
                if (gGrillas[pNombreGrilla].AnchoColFijas.length > lposColumnaFija)
                    lAncho = gGrillas[pNombreGrilla].AnchoColFijas[lposColumnaFija];
            }
            switch (pfmtTabla[i]["Tipo"]) {
                case 'int': lEditor = "number";
                            leditorOptions.push({ dataMode: "int" });
                            lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'number', width: lAncho, columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", hidden: lOculto, format: "0" });
                            if (!lreadOnly)
                                lstColsQueModifTotal.push(lNombreCol);
                            break;
                case 'number': lEditor = "number";
                               leditorOptions.push({ dataMode: "double", maxDecimals: 4, minDecimals: 2 });
                               if (lTieneFormatoPorFila)
                                   lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'number', width: lAncho, columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", hidden: lOculto, format: "0.0000", formatter: qgrillas_FormatearSegunTipoFila });
                               else
                                   lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'number', width: lAncho, columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", hidden: lOculto, format: "0.0000" });
                               if (!lreadOnly)
                                   lstColsQueModifTotal.push(lNombreCol);
                               break;
                case 'date': lEditor = "datepicker";
                             leditorOptions.push({ dateInputFormat: "dd/MM/yyyy", dateDisplayFormat: "dd/MM/yyyy", locale: "es", dataMode: "date" });
                             lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'date', width: lAncho, columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", hidden: lOculto, format: "dd/MM/yyyy"/*, formatter: "function(val, record) { return qcom_FormatearFechaGrilla(val, '-'); }"*/ });
                             break;
                case 'bool': lEditor = "checkbox";
                    lColDef.push({ headerText: lNombreCol, key: lNombreCol, width: lAncho, dataType: 'bool', hidden: lOculto  });
                             break;

                default: lColDef.push({ headerText: lNombreCol, key: lNombreCol, dataType: 'string', width: lAncho, columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", hidden: lOculto });
            }

            lColUpdSetting.push({
                columnKey: lNombreCol,
                readOnly: lreadOnly,
                editorType: lEditor,
                editorOptions: (leditorOptions.length > 0) ? leditorOptions[0] : null,
            });
        }
        lColDef.push({ headerText: "IDCol", key: "IDCol", dataType: "number", hidden: true });
        if (gGrillas[pNombreGrilla].Editable) {
            lstFeatures.push({
                name: "Updating",
                enableAddRow: false,
                enableDeleteRow: false,
                startEditTriggers: ["dblclick", "enter"],
                showDoneCancelButtons: false,
                excelNavigationMode: true,
                editMode: "cell",
                columnSettings: lColUpdSetting,
            });
        }

        if (lstColumnasFijas.length == 0) {
            lstFeatures.push({
                name: "Responsive",
                enableVerticalRendering: false,
                reactOnContainerWidthChanges: true,
            });
        }
        else {
            lstFeatures.push({
                name: "ColumnFixing",
                showFixButtons: false,
                columnSettings: lColFixDef,
            });
        }

        var lColTotCant = gGrillasAutoFTotales[pNombreGrilla].cant;
        var lColTotMin = gGrillasAutoFTotales[pNombreGrilla].min;
        var lColTotMax = gGrillasAutoFTotales[pNombreGrilla].max;
        var lColTotProm = gGrillasAutoFTotales[pNombreGrilla].prom;
        var lColTotSum = gGrillasAutoFTotales[pNombreGrilla].sum;

        //Si hay columnas que totalizan algún valor, debo agregar summaries
        if (gGrillasAutoFTotales[pNombreGrilla].cant + gGrillasAutoFTotales[pNombreGrilla].min +
            gGrillasAutoFTotales[pNombreGrilla].max + gGrillasAutoFTotales[pNombreGrilla].prom +
            gGrillasAutoFTotales[pNombreGrilla].sum != "") {

            //armo arreglos con las columnas que deben totalizar cada uno de los tipos
            //si hay un *, se deben tratar todas las que son del tipo numerico
            var lColTotCant = gGrillasAutoFTotales[pNombreGrilla].cant.split(',');
            var lColTotMin = gGrillasAutoFTotales[pNombreGrilla].min.split(',');
            var lColTotMax = gGrillasAutoFTotales[pNombreGrilla].max.split(',');
            var lColTotProm = gGrillasAutoFTotales[pNombreGrilla].prom.split(',');
            var lColTotSum = gGrillasAutoFTotales[pNombreGrilla].sum.split(',');
            
            var lstColSum = [];
            for (var i = 0; i < pfmtTabla.length; i++) {
                var lNombreCol = pfmtTabla[i]["Columna"];
                var lTipoCol = pfmtTabla[i]["Tipo"];
                
                var lTotalizaCant = (lColTotCant.indexOf(lNombreCol) > -1) || 
                                    ((lColTotCant.indexOf('*') > -1)  && 
                                     ((lTipoCol=='int') || (lTipoCol=='number'))
                                    )
                var lTotalizaMin = (lColTotMin.indexOf(lNombreCol) > -1) || 
                                    ((lColTotMin.indexOf('*') > -1)  && 
                                     ((lTipoCol=='int') || (lTipoCol=='number'))
                                    );
                var lTotalizaMax = (lColTotMax.indexOf(lNombreCol) > -1) ||
                                    ((lColTotMax.indexOf('*') > -1) &&
                                     ((lTipoCol == 'int') || (lTipoCol == 'number'))
                                    );
                var lTotalizaProm = (lColTotProm.indexOf(lNombreCol) > -1) ||
                                    ((lColTotProm.indexOf('*') > -1) &&
                                     ((lTipoCol == 'int') || (lTipoCol == 'number'))
                                    );
                var lTotalizaSum = (lColTotSum.indexOf(lNombreCol) > -1) || 
                                    ((lColTotSum.indexOf('*') > -1)  && 
                                     ((lTipoCol=='int') || (lTipoCol=='number'))
                                    );
                var lTotaliza = lTotalizaCant || lTotalizaMax || lTotalizaMin || lTotalizaProm || lTotalizaSum;

                var ltotaldec = 0;
                if (lTipoCol == 'number')
                    ltotaldec = 4;

                if (!lTotaliza)
                    lstColSum.push({ columnKey: lNombreCol, allowSummaries: false });
                else {
                    lstColSum.push({
                        columnKey: lNombreCol, allowSummaries: true,
                        summaryOperands: [
                                            { "type": "AVG", "active": lTotalizaProm, decimalDisplay: ltotaldec },
                                            { "type": "COUNT", "active": lTotalizaCant, decimalDisplay: ltotaldec },
                                            { "type": "MIN", "active": lTotalizaMin, decimalDisplay: ltotaldec },
                                            { "type": "MAX", "active": lTotalizaMax, decimalDisplay: ltotaldec },
                                            { "type": "SUM", "active": lTotalizaSum, decimalDisplay: ltotaldec }]
                    });
                }
                
            }

            lstFeatures.push({
                name: "Summaries",
                columnSettings: lstColSum,
            });
        }
    }

    if (lMostrarAntesdeCrear)
        $("#div" + pNombreGrilla).show();

    if ((pfmtTabla != null) && (pfmtTabla.length > 0)) {


        $("#" + pNombreGrilla).igGrid({
            autoGenerateColumns: false,
            autofitLastColumn: true,
            autoFormat: true,
            renderCheckboxes: true,
            disabled: false,
            dataSource: pDatos,
            width: "100%",
            heigth: "81px",
            primaryKey: "IDCol",
            autoCommit: true,
            //defaultColumnWidth: (lstColumnasFijas.length > 0) ? "*" : null, //El * significa que se ajusta al contenido de la columna
            defaultColumnWidth: "*",
            columns: lColDef,
            features: lstFeatures,
            rendered: function (evt, ui) {
            },
        });

    }
    else
    {
        $("#" + pNombreGrilla).igGrid({
            autoGenerateColumns: true,
            autofitLastColumn: true,
            autoFormat: true,
            renderCheckboxes: true,
            disabled: false,
            dataSource: pDatos,
            width: "100%",
            heigth: "81px",
            primaryKey: "IDCol",
            autoCommit: true,
            //defaultColumnWidth: (lstColumnasFijas.length > 0) ? "*" : null, //El * significa que se ajusta al contenido de la columna
            //defaultColumnWidth: "*",
            features: lstFeatures,
            rendered: function (evt, ui) {
            },
        });

    }

    //si tiene formato por fila, y es editable, debe contemplar esto antes de editar una celda, y despues de editarla
    if (gGrillas[pNombreGrilla].Editable) {

        $(document).delegate("#" + pNombreGrilla, "iggridupdatingeditcellstarting", function (evt, ui) {
            //Debo chequear si tiene tabla asociada que indique si la celda se puede o no editar
            //si la columna pertenece a una columna de sololectura no se epuede editar
            var lstColumnasSoloLectura = gGrillas[pNombreGrilla].ColumnasSoloLectura.replace(' ', '').split(',');
            if (jQuery.inArray(ui.columnKey, lstColumnasOcultas) != -1)
                return false;

            var lTablaSL = gGrillas[pNombreGrilla].Tabla + "SoloLect";
            if (gEntidad[lTablaSL] != undefined) {
                if (gEntidad[lTablaSL].length >= ui.rowID) {
                    if (gEntidad[lTablaSL][ui.rowID][ui.columnKey] == true)
                        return false;
                }
            }

            //solo se pueden editar las columnas que no son fijas
            if (lTieneFormatoPorFila) {

                var lgridColumns = $("#" + pNombreGrilla).igGrid("option", "columns");
                var currentValueTipo = $("#" + pNombreGrilla).igGrid("getCellValue", ui.rowID, gGrillas[pNombreGrilla].ColFmtNumFila);
                var currentValue = $("#" + pNombreGrilla).igGrid("getCellValue", ui.rowID, ui.columnKey);
                var lEditor = $("#" + pNombreGrilla).igGridUpdating("editorForKey", ui.columnKey);
                if ((currentValueTipo == "N") && (jQuery.type(currentValue) == "number"))
                    lEditor[0].onkeydown = qgrillas_AnuloTeclaPunto;
                else
                    lEditor[0].onkeydown = null;
            }
        })

        //Se modificó de evento, porque sino en el ending se perdió la celda en edición con el dobleclick
        //$(document).delegate("#" + pNombreGrilla, "iggridupdatingeditcellending", function (evt, ui) {
        $(document).delegate("#" + pNombreGrilla, "iggridupdatingeditcellended", function (evt, ui) {
            if ((jQuery.type(ui.value) == "number")) {
                var lcolTotal = gGrillasAutoFTotales[pNombreGrilla].col;
                var lTotal = 0;
                if ((lcolTotal != "") && (jQuery.inArray(ui.columnKey, lstColsQueModifTotal) != -1)) {
                    lTotal = $("#" + pNombreGrilla).igGrid("getCellValue", ui.rowID, lcolTotal);
                    lTotal = lTotal - ui.oldValue + ui.value;
                    $("#" + pNombreGrilla).igGridUpdating("setCellValue", ui.rowID, lcolTotal, lTotal);
                }
                //Se quitó porque esto funciona solo en el iggridupdatingeditcellending, pero si se usan
                //los dos eventos, no funciona bien la edición a traves del doble click
                //if (lTieneFormatoPorFila) {
                //    var currentValueTipo = $("#" + pNombreGrilla).igGrid("getCellValue", ui.rowID, gGrillas[pNombreGrilla].ColFmtNumFila);
                //    var lFormato = qgrillas_ObtenermascaraNumerica(currentValueTipo);
                //    //ui.value = parseFloat($.ig.formatter(ui.value, "number", lFormato));
                //    ui.value = $.ig.formatter(ui.value, "number", lFormato);
                //}
                return ui.value;
            }
            else
                return ui.value;
        })
    }
    if (lMostrarAntesdeCrear)
        $("#div" + pNombreGrilla).hide();
}


var qgrillas_AnuloTeclaPunto = function (e) {
    if (e.keyCode == 190) //Anulo el punto en los enteros
    {
        return false;
    }
}



function qgrillas_EncontrarHijosNodo(pGrilla, pDatos, pId, PrimerNivel) {
    var lRetorno = null;
    var lGrilla = gGrillas[pGrilla].Control;
    var lkey = lGrilla.igTreeGrid("option", "primaryKey");
    if (PrimerNivel) {
        for (var j = 0; (j < pDatos._data.length) && (lRetorno == null); j++) {
            if (pDatos._data[j][lkey] == pId) {
                if (pDatos._data[j].childData != undefined)
                    lRetorno = pDatos._data[j].childData;
                else
                    lRetorno = undefined;
            }
            else
                if (pDatos._data[j].childData != undefined)
                    lRetorno = qgrillas_EncontrarHijosNodo(pGrilla, pDatos._data[j].childData, pId, false);
        }
    }
    else {
        for (var j = 0; (j < pDatos.length) && (lRetorno == null); j++) {
            if (pDatos[j][lkey] == pId) {
                if (pDatos[j].childData != undefined)
                    lRetorno = pDatos[j].childData;
                else
                    lRetorno = undefined;
            }
            else
                if (pDatos[j].childData != undefined)
                    lRetorno = qgrillas_EncontrarHijosNodo(pGrilla, pDatos[j].childData, pId, false);
        }
    }
    return lRetorno;
}

function qgrillas_ActualizarHijos(pGrilla, pHijos, pValor, pColumna) {
    //var lHijos = pDatos._data[lIndex].chilData;
    var lGrilla = gGrillas[pGrilla].Control;
    var lkey = lGrilla.igTreeGrid("option", "primaryKey");
    if ((pHijos != null) && (pHijos != undefined)) {
        for (var j = 0; (j < pHijos.length); j++) {
            //$("#treegrid").igTreeGridUpdating("updateRow", pDatos.childData[j]["Id"], {pColumna: true});
            lGrilla.igTreeGridUpdating("setCellValue", pHijos[j][lkey], pColumna, pValor);
            //alert(pDatos.childData[j]["Id"]);
            pHijos[j][pColumna] = pValor;
            qgrillas_ActualizarHijos(pGrilla, pHijos[j].childData, pValor, pColumna, false);
        }
    }
}

function qgrillas_ColapsarArbol(pGrilla) {
    var igDs = gGrillas[pGrilla].Control.data("igGrid").dataSource;
    var lNivelaExpandir = gGrillas[pGrilla].ExpandirHastaNivel; 
    var lkey = gGrillas[pGrilla].Control.igTreeGrid("option", "primaryKey");
    var lNivel = 1;
    for (var j = 0; (j < igDs._data.length); j++) {
        qgrillas_ColapsarHijos(pGrilla, igDs._data[j].childData, lNivel + 1, lNivelaExpandir);
        if (lNivel > lNivelaExpandir)
        gGrillas[pGrilla].Control.igTreeGrid("collapseRow", igDs._data[j][lkey]);
    }
}

function qgrillas_ColapsarHijos(pGrilla, pHijos, pNivel, pNivelaExpandir) {
    if (pHijos != undefined) {
        var igDs = gGrillas[pGrilla].Control.data("igGrid").dataSource;
        var lkey = gGrillas[pGrilla].Control.igTreeGrid("option", "primaryKey");
        for (var j = 0; (j < pHijos.length); j++) {
            qgrillas_ColapsarHijos(pGrilla, pHijos[j].childData, pNivel + 1, pNivelaExpandir);
            if (pNivel > pNivelaExpandir)
            gGrillas[pGrilla].Control.igTreeGrid("collapseRow", pHijos[j][lkey]);
        }
    }
}



function qgrillas_EditarCheckBoxenArbol(pGrilla, pColumna) {
    var lGrilla = gGrillas[pGrilla].Control;
    var lFila = gGrillas[pGrilla].ValorPK;
    if (lGrilla.igTreeGridUpdating("isEditing")) {
        lGrilla.igTreeGridUpdating("endEdit", true, true);
        lGrilla.igTreeGridUpdating("startEdit", lFila, pColumna);
    }  
}

function qgrillas_EjecutarItemMenuCtxt(e) {
    qevt_AgregarEventoaTmp(e.srcElement.id + '_Click', null, true);
}

function qgrillas_AccionSobreMenuCtxt(pNombre, pAccion) {
    var lEncontre = false;
    for (var i=0; (i<gGrillasAux.length) && (!lEncontre); i++) {
        var lNombreGrilla = gGrillasAux[i];
        for (var j=0; (j<gGrillas[lNombreGrilla].ItemsMenuCtxt.length) && (!lEncontre); j++) {
            if (gGrillas[lNombreGrilla].ItemsMenuCtxt[j].id == pNombre)
            {
                if (pAccion == "H")
                    gGrillas[lNombreGrilla].ItemsMenuCtxt[j].visible = false;
                else if (pAccion == "S")
                    gGrillas[lNombreGrilla].ItemsMenuCtxt[j].visible = true;
                else if (pAccion == "E")
                    gGrillas[lNombreGrilla].ItemsMenuCtxt[j].disabled = false;
                else if (pAccion == "D")
                    gGrillas[lNombreGrilla].ItemsMenuCtxt[j].disabled = true;
                lEncontre = true;
            }
        }
    }
}

function qgrillas_AsignarValorMenuCtxt(pNombre, pValor) {
    var lEncontre = false;
    for (var i = 0; (i < gGrillasAux.length) && (!lEncontre); i++) {
        var lNombreGrilla = gGrillasAux[i];
        for (var j = 0; (j < gGrillas[lNombreGrilla].ItemsMenuCtxt.length) && (!lEncontre); j++) {
            if (gGrillas[lNombreGrilla].ItemsMenuCtxt[j].id == pNombre) {
                gGrillas[lNombreGrilla].ItemsMenuCtxt[j].title = pValor;
                lEncontre = true;
            }
        }
    }
}

function qgrillas_MostrarMenuCtxt(pGrilla, ui, evt) {
    //Verifico si es arbol o grilla
    if (gGrillas[pGrilla].EsArbol)
    {
        if (ui.colIndex == -1)
            $("#" + pGrilla).igTreeGridSelection("selectCellById", ui.rowIndex, ui.colKey);
        else
            $("#" + pGrilla).igTreeGridSelection("selectCell", ui.rowIndex, ui.colIndex);

    }
    else {
        if (ui.colIndex == -1)
            $("#" + pGrilla).igGridSelection("selectCellById", ui.rowIndex, ui.colKey);
        else
            $("#" + pGrilla).igGridSelection("selectCell", ui.rowIndex, ui.colIndex);
    }
    qgrillas_SeleccionarCelda(pGrilla, ui.rowIndex, ui.rowKey, ui.colKey, true);
    //if ((typeof antesMenuContextual_grdCuerpo !== 'undefined') && (jQuery.isFunction(antesMenuContextual_grdCuerpo)))
    //    antesMenuContextual_grdCuerpo(ui);
    qevt_AgregarEventoaTmp(pGrilla  + '_AntesMenuContextual' , null, false);
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion('0', '', null, ''));
    lEvento.Acciones.push(new qevt_accion('1', 'A', qgrillas_EvtMostrarMenuCtxt, null, [pGrilla, evt]));
    gEventosTmp.push(lEvento);
    qevt_EjecutarSiguiente(); 
}

function qgrillas_EvtMostrarMenuCtxt(pGrilla, evt) {
    basicContext.show(gGrillas[pGrilla].ItemsMenuCtxt, evt);
    var lValor = qpopup_ZIndexObtener();
    $(".basicContextContainer").css('z-index', lValor);
    //Inicio - quitado por error en quitar cortina
    //qpopup_ZIndexLiberar();
    //Fin
    qevt_EjecutarSiguiente(); 
}

function qgrillas_RadioOpcionsVisibles(pGrilla, pVisible) {
    if (pVisible)
        $("#divopc" + pGrilla).show();
    else
        $("#divopc" + pGrilla).hide();
    qevt_EjecutarSiguiente();
}


function qgrilla_AsignarTituloCol(pGrilla, pColumna, pTitulo) {

    var lIdSes = sessionStorage.getItem("idses");
    var lSitio = gConfiguracion.getSitio();
    var lData = {
        pTexto: pTitulo, pIdSes: lIdSes
    };
    $.ajax({
        type: "POST",
        url: lSitio + "AjaxHandler/ObtenerTraduccion.ashx",
        data: lData,
        dataType: "json"
    })
    .done(function (msg) {
        if (msg.e == undefined) {
            var lTitulo = msg.d;
    var lcols = $("#" + pGrilla).igGrid("option", "columns");
    
    var lencontre = false;
            for (var i = 0; (i < lcols.length) && (!lencontre) ; i++) {
        if (lcols[i].key == pColumna) {
                    lcols[i].headerText = lTitulo;
            lencontre = true;
        }
    }
    $("#" + pGrilla).igGrid("option", "columns", lcols);
    qevt_EjecutarSiguiente();
        }
        else {
            qcom_TratarError(msg.e);
            qevt_EjecutarSiguiente();
        }
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(thrownError, 'danger', null);
        qevt_EjecutarSiguiente();
    });


}

function qgrilla_AsignarTitulo(pGrilla, pTitulo) {
    var lIdSes = sessionStorage.getItem("idses");
    var lSitio = gConfiguracion.getSitio();
    var lData = {
        pTexto: pTitulo, pIdSes: lIdSes
    };
    $.ajax({
        type: "POST",
        url: lSitio + "AjaxHandler/ObtenerTraduccion.ashx",
        data: lData,
        dataType: "json"
    })
    .done(function (msg) {
        if (msg.e == undefined) {
            var lTitulo = msg.d;
    var lcompo = $("#lbl" + pGrilla)[0].innerHTML.split('<a '); //"Productos  <a href='Nada'>[<i class='fa fa-plus'></i> Agregar Fila Nueva][ALT+P]</a>"
            if (lcompo.length > 1)
            $("#lbl" + pGrilla)[0].innerHTML = $("#lbl" + pGrilla)[0].innerHTML.replace(lcompo[0] + '<a ', lTitulo + '  <a ');
            else
                $("#lbl" + pGrilla)[0].innerHTML = $("#lbl" + pGrilla)[0].innerHTML.replace(lcompo[0], lTitulo);
    qevt_EjecutarSiguiente();
        }
        else {
            qcom_TratarError(msg.e);
            qevt_EjecutarSiguiente();
        }
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(thrownError, 'danger', null);
        qevt_EjecutarSiguiente();
    });
}

function qgrillas_VaciarGrilla(pGrilla) {

    var lNombreTabla = gGrillas[pGrilla].Tabla;
    gGrillas[pGrilla].UltimaPK = 0;
    gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
    gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
    if (gGrillas[pGrilla].AutoFormateable) {
        qgrillas_CrearGrilla(gGrillas[pGrilla].NombreControl, gEntidad[lNombreTabla], null);
    }
    else if (gGrillas[pGrilla].EsArbol) {
        gGrillas[pGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
        gGrillas[pGrilla].Control.igTreeGrid("dataBind");
    }
    else {
        gGrillas[pGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
        gGrillas[pGrilla].Control.igGrid("dataBind");
        gGrillas[pGrilla].Control.igGridSelection("clearSelection");
        gGrillas[pGrilla].ValorPK = -1;
        gGrillas[pGrilla].ColIdEnEdicion = -1;
        gGrillas[pGrilla].ColumnaEnEdicion = "";
    }

    //borro todas sus hijas
    $.each(gRelacTablas, function (lClave, lValor) {
        if (lValor.getTipoCtrlDetalle() == "G") {
            if (lValor.getTablaMaster() == lNombreTabla) {
                lNombreGrillaDetail = 'grd' + lValor.getTablaDetalle();
                if (gGrillas[lNombreGrillaDetail] != undefined) {
                    qgrillas_VaciarGrilla(lNombreGrillaDetail);
                }
            }
        }
    })

}

function qgrillas_EjecutarObtenerMascara(pControl, pNombreAccion, pNombreGrilla, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lNombreTabla = "";
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lNombreTablaMaster = "";
    var lEsMaster = false;
    var lEsDetail = false;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    //Clono el auxiliar
    var lAuxiliarClonado = null;
    var lPos = -1;
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined)) {
        //si la grilla es un master, entonces debo obtener todos los renglones sin comittear de los details
        //ya se encuentran 
        //si la grilla es un detail, debo obtener lod datos de la fila del master sin committear, las otras files del detail sin 
        //comittear, y los datos de la fila actual que se quiere comittear
        $.each(gRelacTablas, function (lClave, lValor) {
            if (lValor.getTablaMaster() == lNombreTabla) {
                lEsMaster = true;
                return false; //corto la busqueda
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetail = true;
                lNombreTablaMaster = lValor.getTablaMaster();
                return false; //corto la busqueda
            }
        });

        //si es un master o, no es ni master ni detail, entonces debo pasar la fila que actualmente se está editando 
        var lFila = qgrillas_ArmarObjetoFilaFila(pNombreGrilla);
        if ((lEsMaster) || ((!lEsMaster) && (!lEsDetail))) {
            gEntidadAux[lNombreTabla].splice(0);
            gEntidadAux[lNombreTabla].push(lFila);
            //busco la posición del registro actual del master
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        else if (lEsDetail) {
            gEntidadAux[lNombreTablaMaster].splice(0);
            lAuxiliarClonado = qcom_Clonar(gEntidadAux);
            var lFilaMaster = qgrillas_ArmarObjetoFilaFila("grd" + lNombreTablaMaster);
            lAuxiliarClonado[lNombreTablaMaster].push(lFilaMaster);
            //busco la posición del registro actual del detail, en el datatable de details aceptados
            var lLong = lAuxiliarClonado[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (lAuxiliarClonado[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }

            //si no existia, lo agrego
            if (lPos == -1)
                lAuxiliarClonado[lNombreTabla].push(lFila);
            else //si existia, debo reemplazarlo
                lAuxiliarClonado[lNombreTabla][lPos] = lFila;
        }
    }
    var ldatasetAux = (lAuxiliarClonado == null) ? JSON.stringify(gEntidadAux) : JSON.stringify(lAuxiliarClonado);
    //var ldatasetAux = (lAuxiliarClonado == null) ? qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidadAux) : qcom_CargarTablasAEnviar(pTablasAEnviar,lAuxiliarClonado);
    var lIdSes = sessionStorage.getItem("idses");
    var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=MASC";
    var lData = {
        pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, pIndice: lPos,
        pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(),
        pIdSes: lIdSes, pCodigoConsulta: ''
    };
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + lUrl,
        data: lData,
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            //Proceso el mensajes de consulta
            var lEsMsgError = (msg.e != undefined);
            if (!lEsMsgError) {
                var lMascara = msg.d;
                qcom_RecrearMaskEditor("#" + pControl, lMascara);
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.e);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
            qcom_Alerta(thrownError, 'danger', null);
        });
}



function qgrillas_EjecutarMostrarHTML(pNombreAccion, pNombreGrilla, pTablasAEnviar, pImprime, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lNombreTabla = "";
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    var lNombreTablaMaster = "";
    var lEsMaster = false;
    var lEsDetail = false;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    //Clono el auxiliar
    var lAuxiliarClonado = null;
    var lPos = -1;
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined)) {
        //si la grilla es un master, entonces debo obtener todos los renglones sin comittear de los details
        //ya se encuentran 
        //si la grilla es un detail, debo obtener lod datos de la fila del master sin committear, las otras files del detail sin 
        //comittear, y los datos de la fila actual que se quiere comittear
        $.each(gRelacTablas, function (lClave, lValor) {
            if (lValor.getTablaMaster() == lNombreTabla) {
                lEsMaster = true;
                return false; //corto la busqueda
            }
            else if (lValor.getTablaDetalle() == lNombreTabla) {
                lEsDetail = true;
                lNombreTablaMaster = lValor.getTablaMaster();
                return false; //corto la busqueda
            }
        });

        //si es un master o, no es ni master ni detail, entonces debo pasar la fila que actualmente se está editando 
        var lFila = qgrillas_ArmarObjetoFilaFila(pNombreGrilla);
        if ((lEsMaster) || ((!lEsMaster) && (!lEsDetail))) {
            gEntidadAux[lNombreTabla].splice(0);
            gEntidadAux[lNombreTabla].push(lFila);
            //busco la posición del registro actual del master
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        else if (lEsDetail) {
            gEntidadAux[lNombreTablaMaster].splice(0);
            lAuxiliarClonado = qcom_Clonar(gEntidadAux);
            var lFilaMaster = qgrillas_ArmarObjetoFilaFila("grd" + lNombreTablaMaster);
            lAuxiliarClonado[lNombreTablaMaster].push(lFilaMaster);
            //busco la posición del registro actual del detail, en el datatable de details aceptados
            var lLong = lAuxiliarClonado[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (lAuxiliarClonado[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }

            //si no existia, lo agrego
            if (lPos == -1)
                lAuxiliarClonado[lNombreTabla].push(lFila);
            else //si existia, debo reemplazarlo
                lAuxiliarClonado[lNombreTabla][lPos] = lFila;
        }
    }
    var ldatasetAux = (lAuxiliarClonado == null) ? JSON.stringify(gEntidadAux) : JSON.stringify(lAuxiliarClonado);
    //var ldatasetAux = (lAuxiliarClonado == null) ? qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidadAux) : qcom_CargarTablasAEnviar(pTablasAEnviar,lAuxiliarClonado);
    var lIdSes = sessionStorage.getItem("idses");
    var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=HTM";
    var lData = {
        pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, pIndice: lPos,
        pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(),
        pIdSes: lIdSes, pCodigoConsulta: ''
    };
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + lUrl,
        data: lData,
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            //Proceso el mensajes de consulta
            var lEsMsgError = (msg.e != undefined);
            if (!lEsMsgError) {
                var lVent = window.open('', '', 'location=yes, menubar=yes, toolbar=yes, width=100');
                lVent.document.open();
                lVent.document.write(msg.d);
                if (pImprime) {
                    lVent.onafterprint = window.close;
                    lVent.print();
                    //lVent.document.close();
                    //lVent.close();
                }
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.e);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
            qcom_Alerta(thrownError, 'danger', null);
        });
}



function qgrillas_ObtenerOrden(pNombreGrilla) {
    var lRetorno = "";
    var lSepar = "";
    //recorro el arreglo de columnas ordenadas y retorno separadas por @
    if (($('#' + pNombreGrilla).data('igGrid').dataSource.settings.sorting != undefined) &&
        ($('#' + pNombreGrilla).data('igGrid').dataSource.settings.sorting != null)) {
        var lColOrden = $('#' + pNombreGrilla).data('igGrid').dataSource.settings.sorting.expressions;
    for (var i = 0; (i < lColOrden.length); i++) {
        lRetorno += lSepar + lColOrden[i].fieldName + ';' + lColOrden[i].dir;
        lSepar = "@";
    }
    }
    return lRetorno;
}

function qgrillas_ObtenerFiltros(pNombreGrilla) {
    var lRetorno = "";
    var lSepar = "";
    //recorro el arreglo de columnas ordenadas y retorno separadas por @
    if (($('#' + pNombreGrilla).data('igGrid').dataSource.settings.filtering != undefined) &&
        ($('#' + pNombreGrilla).data('igGrid').dataSource.settings.filtering != null)) {
        var lColFilter = $('#' + pNombreGrilla).data('igGrid').dataSource.settings.filtering.expressions;
        for (var i = 0; (i < lColFilter.length); i++) {
            lRetorno += lSepar + lColFilter[i].fieldName + ';' + lColFilter[i].cond + ';' + lColFilter[i].expr;
            lSepar = "@";
        }
    }
    return lRetorno;
}

function qgrillas_QuitarFiltros(pNombreGrilla) {
    $("#" + pNombreGrilla).igGridFiltering("filter", [], true);
    qevt_EjecutarSiguiente();
}

function qgrillas_FiltrarGrillaGeneral(pNombreAccion, pNombreGrillaaFiltrar, pNombreGrilla,  pTablasAEnviar, pEsEspecializada) {
    var lNombreTabla = "";
    var lPos = -1;
    var lColSel = "";
    if ((pNombreGrilla != "") && (gGrillas[pNombreGrilla] != undefined))//si el nombre de la grilla no viene, entonces se trata de la accion ObtenerVariables
        lNombreTabla = gGrillas[pNombreGrilla].Tabla;
    if (lNombreTabla != '') {
        //Obtengo la fila en donde se encuentra parado
        if (gGrillas[pNombreGrilla].EsArbol) {
            var lLong = gEntidad[lNombreTabla].length;
            var lPKArbol = gGrillas[pNombreGrilla].CamposPK;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (gEntidad[lNombreTabla][i][lPKArbol] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        else{
            var lLong = gEntidad[lNombreTabla].length;
            for (var i = 0; (i < lLong) && (lPos == -1); i++) {
                if (gEntidad[lNombreTabla][i]["IDCol"] == gGrillas[pNombreGrilla].ValorPK) {
                    lPos = i;
                }
            }
        }
        lColSel = gGrillas[pNombreGrilla].ColumnaEnEdicion;
    }
    if ((lNombreTabla != '') && (lPos <= -1)) {
        qevt_VaciarEventosTmp();
        qcom_Alerta(qrecSinFilaSelec, 'danger', null);
    }
    else {
        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad); //JSON.stringify(gEntidad);
        var lUrl = "AjaxHandler/AcGrillas.ashx?pTipoAccion=FGR";

        var lData = {
            pDsEntidad: ldataset, pIndice: lPos, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
            pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
            pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
            pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
            pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'), pFormulario: gConfiguracion.getFormulario(),
            pIdSes: lIdSes, pEsDownload: true, pColumna: lColSel
        };
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + lUrl,
            data: lData,
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                //Proceso el mensajes de consulta
                if (msg.e == undefined) {
                        //var lDatosDownLoad = JSON.parse(msg);
                    var lFiltros = [];
                    $.each(msg.Filtros, function (lClave, lValor) {
                        lFiltros.push({ fieldName: lValor.Columna, expr: lValor.Valor, cond: lValor.Operador, logic: lValor.OperadorLogico });
                    });

                    //$("#grid1").igGridFiltering("filter", ([{ fieldName: "ProductNumber", expr: "BA-8327", cond: "equals", logic: "OR" }]));
                    $("#" + pNombreGrillaaFiltrar).igGridFiltering("filter", (lFiltros));
                    qevt_EjecutarSiguiente();
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
}
