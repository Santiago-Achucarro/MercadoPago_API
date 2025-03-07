var QLupaSegAdv_dialogolupa = null;
var QLupaSegAdv_grillaLupa = null;
var QLupaSegAdv_Segmento = null;
var QLupaSegAdv_Identidad = null;
var QLupaSegAdv_TiposControlesRet = null;
var QLupaSegAdv_FiltrosOcultos = '';
var QLupaSegAdv_Extras = null;
var QLupaSegAdv_CantRegPorPagina = 50;
var QLupaSegAdv_CantRegistrosTotal = 0;
var QLupaSegAdv_MaximaCantPermitida = 20;
var QLupaSegAdv_Inicializada = false;
var QLupaSegAdv_GrillaCreada = false;
var QLupaSegAdv_FuncionCliente = null;
var QLupaSegAdv_CamposSegmento = null;
var QLupaSegAdv_CamposSegmentoenFE = null;
var QLupaSegAdv_CamposAliasSegmento = null;
var QLupaSegAdv_CamposRet = null;
var QLupaSegAdv_ObjetoSegmento = null;
var QLupaSegAdv_TablaFE = '';
var QLupaSegAdv_EsEntidadDelForm = false;
var QLupaSegAdv_CamposVisibles = null;
var QLupaSegAdv_NombreCtrl = null;
var QLupaSegAdv_PrimColVisible = -1;
var QLupaSegAdv_Estructura = null;
var QLupaSegAdv_Formulario = '';
var QLupaSegAdv_TituloForm = '';
var QLupaSegAdv_PrimEditor = null;
var QLupaSegAdv_SelXTecladoProcesado = false;
var QLupaSegAdv_AnchoTotal = 0;
var QLupaSegAdv_PrimeraVez = true;
//Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
var QLupaSegAdv_FnAccion = '';
//Fin 06-03-2021 

//Mètodo invocado desde el boton de un control "Lupa", para mostrar una ventana con el listado de registros
//Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
//function QLupaSegAdv_MostrarLupa(pNombre, pSegmento, pIdEntidad, pTablaFE, pTiposControles, pCamposSegmentoEnFE, pCamposSegmento, pCamposAliasSegmento, pfuncionCliente, pFiltros, pExtras, pEsLaEntidadDelForm, pFormulario, pTituloFormulario) {
function QLupaSegAdv_MostrarLupa(pNombre, pSegmento, pIdEntidad, pTablaFE, pTiposControles, pCamposSegmentoEnFE, pCamposSegmento, pCamposAliasSegmento, pfuncionCliente, pFiltros, pExtras, pEsLaEntidadDelForm, pFormulario, pTituloFormulario, pFnAccion) {
//Fin 06-03-2021 

    QLupaSegAdv_SelXTecladoProcesado = false;
    QLupaSegAdv_TiposControlesRet = pTiposControles;
    QLupaSegAdv_FiltrosOcultos = qcom_ObtenerValorParametrosFiltro(pFiltros);
    QLupaSegAdv_Extras = pExtras;
    QLupaSegAdv_FuncionCliente = pfuncionCliente;
    QLupaSegAdv_Segmento = pSegmento;
    QLupaSegAdv_CamposSegmento = pCamposSegmento;
    QLupaSegAdv_CamposAliasSegmento = pCamposAliasSegmento;
    QLupaSegAdv_TablaFE = pTablaFE;
    QLupaSegAdv_CamposSegmentoenFE = pCamposSegmentoEnFE;
    QLupaSegAdv_EsEntidadDelForm = pEsLaEntidadDelForm;
    QLupaSegAdv_Formulario = pFormulario;
    QLupaSegAdv_TituloForm = pTituloFormulario;
    //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
    QLupaSegAdv_FnAccion = pFnAccion;
    //Fin 06-03-2021

    lMismaIdentidad = (pNombre == QLupaSegAdv_NombreCtrl);
    QLupaSegAdv_NombreCtrl = pNombre;
    QLupaSegAdv_Identidad = pIdEntidad;
    if (!QLupaSegAdv_Inicializada) {
        QLupaSegAdv_Inicializar();
    }
    QLupaSegAdv_ObtenerConfiguracion(pNombre, pSegmento, pIdEntidad);
    qpopup_ZIndexAsignar(QLupaSegAdv_dialogolupa);

    //QLupaSegAdv_dialogolupa.modal({
    //    keyboard: true,
    //    tabindex: -1,
    //    backdrop: "static",
    //    show: true
    //});
    //QLupaSegAdv_dialogolupa.draggable({
    //    handle: ".modal-header"
    //});

}


function QLupaSegAdv_Inicializar() {
    $("#divGrillaLupaSeg").append("<table id='gridlupaseg'></table>");
    QLupaSegAdv_grillaLupa = $("#gridlupaseg");
    QLupaSegAdv_dialogolupa = $("#divModalLupaSeg");
    //$("#tituloModalLupaSeg").text('');
    $("#tituloModalLupaSeg").text(QLupaSegAdv_TituloForm);
    QLupaSegAdv_Inicializada = true;
}


var fTeclasEspecialesSeg = function (e) {
    if (e.keyCode == 40) { //Flecha Abajo
        $("#gridlupaseg").igGridSelection("selectRow", 0);
        $("#gridlupaseg_container").attr("tabIndex", 0);
        //$("#gridlupa_container").focus();
    }
    //else if (((e.keyCode == 56) && (e.key != '8')) || (e.keyCode == 219) || (e.keyCode == 188)) //Anulo comillas, y demas porque dan error en sql
    //else if ((e.key == ",") || (e.key == "'") || (e.key == ")") || (e.key == ";") || (e.key == "(")) //Anulo comillas, y demas porque dan error en sql
    //else if ((e.key == ",") || (e.key == "'") || (e.key == "(")) //Anulo comillas, y demas porque dan error en sql
    else if /*((e.key == ",") || (e.key == "'") || (e.key == ")") || */ (e.key == ";") //|| (e.key == "(")) //Anulo comillas, y demas porque dan error en sql
    {
        return false;
    }
}



function QLupaSegAdv_SeleccionarRegistro(pRowIndex) {
    // Cambie le for para que tome el lenght por los campos ocultos
    // TODO Revisar porque pasa esto
    if (QLupaSegAdv_EsEntidadDelForm) {
        gTieneSinGuardar = false;
        //Limpio las solapas para que no figuren como activadas
        qcom_InicSolapasActivadas(false);
    }
    else
        gTieneSinGuardar = true;
    if (QLupaSegAdv_TiposControlesRet != null) {
        var lControlesLong = QLupaSegAdv_TiposControlesRet.length;

        for (var i = 0; i < lControlesLong; i++) {
            var lValor = QLupaSegAdv_grillaLupa.igGrid("getCellValue", pRowIndex, QLupaSegAdv_CamposRet[i]);
            if (QLupaSegAdv_TiposControlesRet[i].toLowerCase() == 'mes')
                lValor = ("0" + lValor).slice(-2);

            qcom_AsignarValorControl(gControles[QLupaSegAdv_TablaFE][0][QLupaSegAdv_CamposSegmentoenFE[i]], lValor, false);
            // Para los copiados 
            if (gControles[QLupaSegAdv_TablaFE][0][QLupaSegAdv_CamposSegmentoenFE[i]] != null) {
                for (var j = 1; j <= 8 ; j++) {
                    if ((QLupaSegAdv_ObjetoSegmento.getCampoNCCtrlSeg(j) == QLupaSegAdv_CamposSegmentoenFE[i]) &&
                        (QLupaSegAdv_ObjetoSegmento.getCampoNCCtrl(j) != '')) {
                        qcom_AsignarValorControl(gControles[QLupaSegAdv_TablaFE][0][QLupaSegAdv_ObjetoSegmento.getCampoNCCtrl(j)], lValor, false);
                    }
                }

            }

        }
        QLupaSegAdv_TiposControlesRet = null;
        QLupaSegAdv_CamposOcultos = null;
        $('#divModalLupaSeg').attr("Abierto", "false");
        QLupaSegAdv_dialogolupa.modal("hide");
        //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
        var lcant = 0;
        if (QLupaSegAdv_FnAccion != '') {
            var lCantEvt = gEventosTmp.length;
            qevt_AgregarEventoaTmp(QLupaSegAdv_FnAccion, null, false);
            if (lCantEvt < gEventosTmp.length)
                lcant++;
        }

        if ((lcant > 0) && (gEventosTmp.length == lcant))
        qevt_EjecutarSiguiente();
        //qevt_EjecutarSiguiente();
        //Fin 06-03-2021 
    }

}


function QLupaSegAdv_CrearGrilla(pSegmento, pIdentidad) {
    $('#divCargando').addClass('show');
    QLupaSegAdv_grillaLupa.hide();
    QLupaSegAdv_GrillaCreada = true;
    var lIdSes = sessionStorage.getItem("idses");

    var lColDef = [];
    var lColDefFiltros = [];
    var lCamposVisibles = [];
    var lColDefResizing = [];

    //Organizo los campos visibles
    var lCantAMostrar = 100;
    var lAnchoxDef = 600;
    var lAnchoColDef = 100;
    if ($(document).width() < 768) {
        lCantAMostrar = 5;
        lAnchoDef = 300;
        lAnchoColDef = 50;
    }

    var lPartesSegAMostrar = [];
    for (var j = 1; j <= 8 ; j++) {
        if (QLupaSegAdv_ObjetoSegmento.getCampoNCCtrlSeg(j) != '') /*&&
                        (QLupaSegAdv_ObjetoSegmento.getCampoNCCtrl(j) == ''))*/ {
            lCamposVisibles.push(QLupaSegAdv_ObjetoSegmento.getCampoSegAlias(j));
        }
    }

    var lcantVisibles = lCamposVisibles.length;
    for (var i = 0; (i < QLupaSegAdv_CamposVisibles.length) && (i + lcantVisibles < lCantAMostrar) ; i++) {
        lCamposVisibles.push(QLupaSegAdv_CamposVisibles[i].Campo);
    }

    lColDef.push({ headerText: "N", key: "N", dataType: 'number', hidden: true });
    lColDefFiltros.push({ columnKey: "N", editorType: "numeric", allowFiltering: false });

    QLupaSegAdv_AnchoTotal = 0;
    if (lCamposVisibles.length < 6)
        lAnchoColDef = lAnchoxDef / lCamposVisibles.length;
    //Primero defino las columnas
    for (var i = 0; i < QLupaSegAdv_Estructura.length; i++) {
        var lNombreCol = QLupaSegAdv_Estructura[i].Campo;
        var lTituloCol = QLupaSegAdv_Estructura[i].NombreCampo;
        var lCondicionInicial = QLupaSegAdv_Estructura[i].CondicionInicial == "" ? null : QLupaSegAdv_Estructura[i].CondicionInicial;
        var lAncho = QLupaSegAdv_Estructura[i].Longitud == 0 ? lAnchoColDef : QLupaSegAdv_Estructura[i].Longitud * 8; //Cada caracter ocupa 8 px
        var lAnchoTitulo = lNombreCol.length * 8 + 8; //Cada caracter ocupa 8 px + 8 de padding (4 de cada lado)
        //Anchos Minimos:
        //string 80 (porque tiene 2 botones
        //Numerico 50 tiene 1 solo boton
        //Decimal 58 tiene 1 solo boton y signos d puntuacion
        //Fecha 140 tiene 3 botones y lleva 10 caracteres

        var lOculto = (jQuery.inArray(lNombreCol, lCamposVisibles) <= -1);
        //var lobj = $.grep(lCamposVisibles, function (lobj) { return lobj.Campo == lNombreCol; });
        lColDefResizing.push({ columnKey: lNombreCol, allowResizing: true });
        switch (QLupaSegAdv_Estructura[i].TipoCampo) {
            
            case 'I': lAncho = (50 > lAncho + 30) ? 50 : lAncho + 30; //un boton (22) + 2 signos de puntuacion (4) 
                      //Si longitud del titulo es mayor que la longitud que se quiere mostrar, me quedo con la longitud del titulo  
                lAncho = (lAnchoTitulo > lAncho) ? lAnchoTitulo : lAncho;
                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'number', columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", width: lAncho, hidden: lOculto, format: "0" });
                lColDefFiltros.push({
                    columnKey: lNombreCol, editorType: "numeric", allowFiltering: (!lOculto), condition: lCondicionInicial,
                    editorOptions: {
                        buttonType: "none",
                        dataMode: "int",
                        spinDelta: 0,
                        allowNullValue: true
                    }
                });
                break;
            case 'N': lAncho = (58 > lAncho + 34) ? 58 : lAncho + 34; //un boton(22) + 3 signos de puntuacion (4)
                //Si longitud del titulo es mayor que la longitud que se quiere mostrar, me quedo con la longitud del titulo  
                lAncho = (lAnchoTitulo > lAncho) ? lAnchoTitulo : lAncho;

                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'number', columnCssClass: "alignCol-derecha", headerCssClass: "alignHeaderCol-derecha", width: lAncho, hidden: lOculto, format: "0.0000" });
                lColDefFiltros.push({
                    columnKey: lNombreCol, editorType: "numeric", allowFiltering: (!lOculto), condition: lCondicionInicial,
                    editorOptions: {
                        buttonType: "none",
                        dataMode: "decimal",
                        spinDelta: 0,
                        maxDecimals: 2,
                        minDecimals: 0,
                        allowNullValue: true
                    }
                });
                break;
            case 'F':  //Si longitud del titulo es mayor que la longitud que se quiere mostrar, me quedo con la longitud del titulo  
                lAncho = (lAnchoTitulo > 140) ? lAnchoTitulo : 140;

                //se quitó el conttrol datepicker del editor del filtro porque se estaba mostrando detras del div que contiene la grilla
                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'date', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", width: lAncho, hidden: lOculto, format: "dd-MM-yyyy"/*, formatter: "function(val, record) { return qcom_FormatearFechaGrilla(val, '-'); }"*/ });
                lColDefFiltros.push({
                    columnKey: lNombreCol, editorType: "date", allowFiltering: (!lOculto),
                    editorOptions: {
                        dataMode: "date",
                        spinDelta: 0,
                        allowNullValue: true
                    }
                });
                break;
            case 'B': 
                lAncho = (lAnchoTitulo > 35) ? lAnchoTitulo : 35;
                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'bool', width: lAncho, hidden: lOculto });
                //lColDefFiltros.push({ columnKey: lNombreCol, editorType: "checkbox", allowFiltering: (!lOculto) });
                lColDefFiltros.push({ columnKey: lNombreCol, allowFiltering: (!lOculto) });
                break;
            default: {
                lAncho = (80 > lAncho + 44) ? 80 : lAncho + 44; //dos botones                     
                //Si longitud del titulo es mayor que la longitud que se quiere mostrar, me quedo con la longitud del titulo  
                lAncho = (lAnchoTitulo > lAncho) ? lAnchoTitulo : lAncho;
                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'string', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", width: lAncho, hidden: lOculto });
                lColDefFiltros.push({ columnKey: lNombreCol, editorType: "text", condition: lCondicionInicial, allowFiltering: (!lOculto) });
            }
        }
        if (!lOculto)
            QLupaSegAdv_AnchoTotal += lAncho;
    }

    QLupaSegAdv_grillaLupa.igGrid({
        autoGenerateColumns: false,
        renderCheckboxes: true,
        width: "100%",
        //height: "500px",
        //fixedHeaders: true,
        responseDataKey: "data",
        dataSource: "AjaxHandler/QLupaSegAdvDatos.ashx?AbroLupa=S&Segmento=" + pSegmento + "&Identidad=" + pIdentidad + "&CamposSegmento=" + QLupaSegAdv_CamposSegmento.join('|') + "&CamposAliasSegmento=" + QLupaSegAdv_CamposAliasSegmento + "&filtroSP=" + QLupaSegAdv_FiltrosOcultos + "&IndicePagina=0" + "&TamaioPagina=" + QLupaSegAdv_CantRegPorPagina + "&Idses=" + lIdSes,
        columns: lColDef,
        //autoFormat: true,
        features: [
            {
                name: "Filtering",
                type: "remote",
                mode: 'simple',
                filterExprUrlKey: "filtro",
                columnSettings: lColDefFiltros,
            },
            {
                name: "Selection",
                mode: "row",
                activation: true
            },
            {
                name: 'RowSelectors',
                enableRowNumbering: false,
                rowSelectorColumnWidth: 5
            },
            //{name : "Responsive"},
            {
                name: "Paging",
                type: "remote",
                pageSize: QLupaSegAdv_CantRegPorPagina,
                recordCountKey: "recordCountKey",
                pageIndexUrlKey: "pageIndex",
                pageSizeUrlKey: "pageSize",
            },
             {
                 name: "Resizing",
                 deferredResizing: false,
                 allowDoubleClickToResize: true,
                 columnSettings: lColDefResizing
            },
            {
                name: "Sorting",
                type: "remote",
                sortUrlKey: "sortKey",
                //si ponemos los valores cambia la forma de como viajan los datos del order by en la url
                //sortUrlKeyAscValue: "asc",
                //sortUrlKeyDescValue: "desc",
                mode: "single",
                columnSorting: function (evt, ui) {
                    //Cambio el ordenamiento, entonces debo reinicializar el paginado
                    $("#gridlupaseg").igGridPaging("pageIndex", 0);
                }

            }

        ],
        rendered: function (evt, ui) {

            gridColumns = QLupaSegAdv_grillaLupa.igGrid("option", "columns");
            if (gridColumns.length)
                //QLupaSegAdv_PrimEditor = $("[id$='EditingInput'].ui-iggrid-filtereditor")[0];
                QLupaSegAdv_PrimEditor = $("#gridlupaseg_container [id$='EditingInput'].ui-iggrid-filtereditor")[0].id;
            if (QLupaSegAdv_PrimEditor != null) {
                var lcant = $("#gridlupaseg_container [id$='EditingInput'].ui-iggrid-filtereditor").length;
                for (var i = 0; i < lcant; i++) {
                    ($("#gridlupaseg_container [id$='EditingInput'].ui-iggrid-filtereditor")[i]).onkeydown = fTeclasEspecialesSeg;
                }

                $("#gridlupaseg").on("keydown", "tr", function (e, ui) {
                    //Como el evento es sobre tr, se ejecuta una vez por cada columna.
                    //Intente poner que sea por td, pero el enter no funciona, no entra, no ejecuta nada
                    //por eso agregué la condición de que si ya se ejecutó para una celda, no se ejecute para ninguna otra
                    if ((e.keyCode == 13) && (!QLupaSegAdv_SelXTecladoProcesado)) {
                        var row = $("#gridlupaseg").igGrid("activeRow");
                        if (row != null) {
                            QLupaSegAdv_SelXTecladoProcesado = true;
                            e.stopPropagation();
                            e.preventDefault();
                            QLupaSegAdv_SeleccionarRegistro(row.index);
                        }
                    }
                });
            }

            $('#divCargando').removeClass('show');
            setTimeout(function () {
                //los movimientos siempre serán muchos, por lo tanto no tiene sentido preguntar si son menos de 12
                //if ($("#gridlupaseg").igGrid("rows").length > 12) {
                    var lalto = $(window).height() * 0.90;
                    $("#divGrillaLupaSeg").height(lalto-47);
                    $("#gridlupaseg").igGrid("option", "height", lalto);                   
                //}

                $("#divModalLupaSegDlg").width(QLupaSegAdv_AnchoTotal + 15);


                QLupaSegAdv_grillaLupa.show();

                QLupaSegAdv_dialogolupa.modal({
                    keyboard: true,
                    tabindex: -1,
                    backdrop: "static",
                    show: true
                });


                if (QLupaSegAdv_PrimeraVez) {
                    QLupaSegAdv_PrimeraVez = false;
                    QLupaSegAdv_dialogolupa.on('shown.bs.modal', function () {
                        if (QLupaSegAdv_PrimEditor != null)
                            $("#" + QLupaSegAdv_PrimEditor).focus();
                    })
                }


                QLupaSegAdv_dialogolupa.draggable({
                    handle: ".modal-header"
                });
                QLupaSegAdv_dialogolupa.unbind('dragstop');
                QLupaSegAdv_dialogolupa.on("dragstop", function (event, ui) {
                    var lScroll = window.pageYOffset !== undefined ? window.pageYOffset : window.scrollTop;
                    if (ui.helper[0].offsetTop < 0) {
                        if (lScroll > 0)
                            QLupaSegAdv_dialogolupa.offset({ top: lScroll, left: ui.helper[0].offsetLeft });
                        else
                        QLupaSegAdv_dialogolupa.offset({ top: 0, left: ui.helper[0].offsetLeft });
                    }
                    else if (lScroll > 0)
                        QLupaSegAdv_dialogolupa.offset({ top: lScroll, left: ui.helper[0].offsetLeft }); 
                })

            }, 10);

        },
        dataBound: function (evt, ui) {
            if (!ui.dataSource._hasCount) //Se produjo un error
            {
                $('#divCargando').removeClass('show');
                var lmsj = JSON.parse(ui.dataSource._ajaxRequest.responseText);
                if (lmsj.e != undefined)
                    qcom_TratarError(lmsj.e);
            }
        },
                
        schemaGenerated: function (evt, ui) {
        },
        cellClick: function (evt, ui) {
            QLupaSegAdv_SeleccionarRegistro(ui.rowIndex);
        },
        cellRightClick: function (evt, ui) {
            //alert(ui.rowIndex + 'j');
            if (QLupaSegAdv_Formulario != "") {
                QLupaSegAdv_grillaLupa.igGridSelection("selectRow", ui.rowIndex);
                evt.stopPropagation();
                evt.preventDefault();
                var row = $("#gridlupaseg").igGridSelection("selectedRow");
                if (row != null) {
                    event.stopPropagation();
                    event.preventDefault();
                    var lValorSeg = "";
                    var lSeparador = "";
                    if (QLupaSegAdv_TiposControlesRet != null) {
                        var lControlesLong = QLupaSegAdv_TiposControlesRet.length;

                        for (var i = 0; i < lControlesLong; i++) {
                            var lValor = QLupaSegAdv_grillaLupa.igGrid("getCellValue", row.index, QLupaSegAdv_CamposRet[i]);
                            if (QLupaSegAdv_TiposControlesRet[i].toLowerCase() == 'mes')
                                lValor = ("0" + lValor).slice(-2);
                            //qcom_AsignarValorControl(gControles['Principal'][0][QLupaSegAdv_CamposSegmento[i]], lValor, false);                
                            lValorSeg += lSeparador + lValor;
                            lSeparador = "-";
                        }
                    }
                    qpopup_MostrarForm(QLupaSegAdv_Formulario, lValorSeg, '', '', QLupaSegAdv_TituloForm, true);
                }
            }
        }

    });
}


function QLupaSegAdv_ObtenerConfiguracion(pNombre, pIdSegmento, pIdEntidad) {
    QLupaSegAdv_CamposRet = null;
    QLupaSegAdv_CamposRet = QLupaSegAdv_CamposAliasSegmento.split("|");

    //Busco el objeto que estará asociado a  la lupa
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        if (gSegmentos[i].getNombre() == pNombre)
            QLupaSegAdv_ObjetoSegmento = gSegmentos[i];
    }

    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    $.ajax({
        type: "POST",
        url: "AjaxHandler/QLupaSegAdvConf.ashx",
        data: { Segmento: pIdSegmento, Identidad: pIdEntidad, IdSes: lIdSes },
        dataType: "json"
    })
    .done(function (response) {
        if (response.e != null) {
            $('#divCargando').removeClass('show');
            if (response.m != null)
            qcom_TratarError(response.e + "|" + response.m);
            else
                qcom_TratarError(response.e);
        }
        else {
            $('#divCargando').removeClass('show');
            QLupaSegAdv_CamposVisibles = response['CamposVisibles'];
            QLupaSegAdv_Estructura = response['Campos'];

            //var lNombreCol = QLupaSegAdv_Estructura[i].Campo;
            //var lTituloCol = QLupaSegAdv_Estructura[i].NombreCampo;

            //a la estructura debo agregarle las columnas del segmento
            //debo agregarselas en el orden adecuado
            for (var p = QLupaSegAdv_ObjetoSegmento.getPosiciones().length - 1; p >= 0 ; p--) {
                var lCampopos = QLupaSegAdv_ObjetoSegmento.getPosiciones()[p];
                var lEncontre = false;
                for (var j = 1; j <= 8 && (!lEncontre) ; j++) {
                    if ((QLupaSegAdv_ObjetoSegmento.getCampoNCCtrlSeg(j) == lCampopos) ||
                        (QLupaSegAdv_ObjetoSegmento.getCampoNCCtrl(j) == lCampopos)) {
                        lEncontre = true;
                        var lcampo = QLupaSegAdv_ObjetoSegmento.getCampoSegAlias(j);
                        var lLongitud = QLupaSegAdv_ObjetoSegmento.getCampoLongitud(j);
                        if (j < 5)
                            QLupaSegAdv_Estructura.unshift({ Campo: lcampo, NombreCampo: lcampo, TipoCampo: 'I', Longitud: lLongitud, CondicionInicial:''});
                        else
                            QLupaSegAdv_Estructura.unshift({ Campo: lcampo, NombreCampo: lcampo, TipoCampo: 'S', Longitud: lLongitud, CondicionInicial: '' });
                    }
                }
            }
            if (QLupaSegAdv_GrillaCreada)
                QLupaSegAdv_grillaLupa.igGrid("destroy");
            QLupaSegAdv_CrearGrilla(pIdSegmento, pIdEntidad);

        }

    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        qcom_Alerta(thrownError, 'danger', null);
    });
}

function QLupaSegAdv_MostrarLupaDesdeBtn(pEsSegSueldo, pNombre, pIdEntidad, pFiltros, pEsLaEntidadDelForm, pFormulario, pTituloFormulario)
{
    var lSeg = qcom_ObtenerSegmento(pNombre);
    var lTiposControles = [];
    var lCamposSegmentoEnFE = [];
    var lCamposSegmento = [];
    var lAlias = "";
    var lPosiciones = lSeg.getPosiciones();
    var lSeparador = '';

    if (pEsSegSueldo) {

        for (var j = 0; j < lPosiciones.length; j++) {
            //Lo busco 
            var lEncontre = false;
            for (var i = 1; (i <= 8) && (!lEncontre); i++) {
                if (lSeg.getCampoNCCtrl(i) == lPosiciones[j]) {
                    lEncontre = true;
                    lAlias += lSeparador + lSeg.getCampoSegAlias(i);
                    if (i < 5)
                        lTiposControles.push("Int");
                    else
                        lTiposControles.push("String");
                }
            }
            lCamposSegmentoEnFE.push(lSeg.getCampoNCCtrlSeg(j + 1));
            lCamposSegmento.push(lSeg.getCampoNCCtrlSeg(j + 1));
            lSeparador = "|";
        }
    }
    else {
    for (var j = 0; j < lPosiciones.length; j++) {
        //Lo busco 
        var lEncontre = false;
        for (var i = 1; (i <= 8) && (!lEncontre); i++) {
            if (lSeg.getCampoNCCtrlSeg(i) == lPosiciones[j]) {
                lEncontre = true;
                lAlias += lSeparador + lSegmento.getCampoSegAlias(i);
                if (i < 5)
                    lTiposControles.push("Int");
                else
                    lTiposControles.push("String");
            }
        }
        lCamposSegmentoEnFE.push(lPosiciones[j]);
        lCamposSegmento.push(lPosiciones[j])
        lSeparador = "|";
        }
    }
//    lSegmento.setCampoNCCtrlSeg(5, "Segmento1C");
//    lSegmento.setCampoSegAlias(5, "TM");
//  function QLupaSegAdv_MostrarLupa(pNombre, pSegmento, pIdEntidad, pTablaFE, pTiposControles, pCamposSegmentoEnFE, pCamposSegmento, pCamposAliasSegmento, pfuncionCliente, pFiltros, pExtras, pEsLaEntidadDelForm, pFormulario, pTituloFormulario) {
//  QLupaSegAdv_MostrarLupa("ctrsoc14Segmento_Id","FC", lSegmento.getIdentidad(), "venComprobAsoc", new Array("String", "String", "Int", "String"), new Array("Segmento1C", "Segmento2C", "Segmento1N", "Segmento3C"), new Array("Segmento1C", "Segmento2C", "Segmento1N", "Segmento3C"), "TM|Sucursal|Folio|Ser", typeof accionSegmento_ctrsoc14Segmento_Id !== 'undefined' ? accionSegmento_ctrsoc14Segmento_Id : null, "venTipomov;in;'F','I';S@Cliente_Id;equals;[Principal:Cliente_Id];S", "", false, '', '');

    QLupaSegAdv_MostrarLupa(pNombre, lSegmento.getIdSeg(), pIdEntidad, lSegmento.getTabla(), lTiposControles, lCamposSegmentoEnFE, lCamposSegmento, lAlias, null, pFiltros, "", pEsLaEntidadDelForm, pFormulario, pTituloFormulario);
}

