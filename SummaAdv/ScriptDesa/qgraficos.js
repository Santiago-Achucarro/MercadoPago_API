//var gPaletaGrafDegrade = ["#0f3b17", "#2f5121", "#4f682b", "#727e30", "#999544", "#c2aa55", "#eec069", "#edac5c", "#eb9752", "#0f3b17"];
var gPaletaStd = ["#00567d", "#ffa600", "#3f5e99", "#ff7f45", "#7a5fa8", "#ff626f", "#b45ba6", "#e45891"];;
//var gPaletaLineStd = gPaletaStd;



function graf_DescargarGrafico(pControlGrafico) {
    graf_MostrarAdicGrafico(pControlGrafico, false);
    graf_DestruirGrafico(pControlGrafico);
    qevt_EjecutarSiguiente();
}


function graf_CargarGrafico(pControlGrafico) {

    var lDatos = gEntidad[gGraficos[pControlGrafico].Tabla];

    if (lDatos.length == 0)
    {
        graf_DescargarGrafico(pControlGrafico);
    }
    else
    {
        var lTipoGrafico = gGraficos[pControlGrafico].Tipo;

        //$("#ctrcbo" + pControlGrafico).igCombo("value", gGraficos[pControlGrafico].TipoSerie);

        var lIdSes = sessionStorage.getItem("idses");
        $('#divCargando').addClass('show');
        var lDatosjson = JSON.stringify(lDatos);
        qevt_EjecutarSiguiente();
        /*var lData = JSON.stringify({
            'pDatos': lDatos, 'pTipo': lTipoGrafico, 'IdSes': lIdSes
        });*/

        $.ajax({
            type: "POST",
            //url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/ObtenerDatosGrafico",
            url: gConfiguracion.getSitio() + "AjaxHandler/QGrafico.ashx",
            data: { Tipo: lTipoGrafico, Datos: lDatosjson, IdSes: lIdSes },
            dataType: "json"
        })
        .done(function (response) {
            $('#divCargando').removeClass('show');
            if (response.e == "logout")
                qcom_AlertaFinSesion(response.m);
            else if (response.e == "invalido")
                qcom_AlertaSesionInvalida(response.m);
            else if (response.e == "qbi")
                qcom_AlertaErrorServicio();
            else {

                graf_MostrarAdicGrafico(pControlGrafico, true);

                if (lTipoGrafico == "C") {
                    var lNombresSerie = response.Series;
                    var lLabel = response.ColCateg;
                    var lDatosG = response.Datos;
                    graf_CrearGraficoCategorias(pControlGrafico, lDatosG, lNombresSerie, lLabel);
                }
                else if (lTipoGrafico == "P") {
                    var lColValores = response.ColValores;
                    var lColDescripcion = response.ColDescripciones;
                    var lDatosG = response.Datos;
                    if (gGraficos[pControlGrafico].SubTipo == "pie")
                        graf_CrearGraficoTorta(pControlGrafico, lDatosG, lColValores, lColDescripcion);
                    else
                        graf_CrearGraficoDona(pControlGrafico, lDatosG, lColValores, lColDescripcion)
                }
            }
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            // aj dic 2016
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseText, 'danger', null);

        });
    }
}



function graf_CrearGraficoCategorias(pControlGrafico, pDatos, pNombresSerie, pLabel) {

    var lTipo = gGraficos[pControlGrafico].SubTipo;
    var lTitulo = gGraficos[pControlGrafico].Titulo;
    var lSubTitulo = gGraficos[pControlGrafico].SubTitulo;
    var lTituloEjeV = gGraficos[pControlGrafico].TituloEjeValores;
    var lColores = gGraficos[pControlGrafico].Colores;

    var lPaleta = [];
    if (lColores == "")
        lPaleta = gPaletaStd;
    else {
        var lColoresGraf = lColores.split('#');
        for (var i = 0; (i < lColoresGraf.length); i++) {
            if (lColoresGraf[i].trim() != "")
                lPaleta.push("#" + lColoresGraf[i].trim());
        }
    }

    var lSeries = [];
    for (var i = 0; i < pNombresSerie.length; i++)
        lSeries.push(graf_CrearSeries(lTipo, pNombresSerie[i]));
    

    //$("#tit" + pControlGrafico).text(lTitulo);
    //$("#subtit" + pControlGrafico).text(lSubTitulo);
    $("#lbl" + pControlGrafico).text(lTitulo);

    //if ($("#" + pControlGrafico).data("igDataChart") != null)
    //    $("#" + pControlGrafico).igDataChart("destroy");
    graf_DestruirGrafico(pControlGrafico);

    var lejes = [];
    if (lTipo == "bar")
    {
        lejes.push({
            name: "xAxis",
            type: "numericX",
            minimumValue: 0,
            title: lTituloEjeV,
            labelTextStyle: "8pt Verdana",
            formatLabel: function (item) {return $.ig.formatter(item, "number", "#,##0");},
        });
        lejes.push({
            name: "yAxis",
            type: "categoryY",
            label: pLabel,
            labelTextStyle: "8pt Verdana"
        });
    }
    else
    {
        lejes.push({
            name: "xAxis",
            type: "categoryX",
            label: pLabel,
            labelTextStyle: "8pt Verdana"
        });
        lejes.push({
            name: "yAxis",
            type: "numericY",
            minimumValue: 0,
            title: lTituloEjeV,
            labelTextStyle: "8pt Verdana",
            formatLabel: function (item) {return $.ig.formatter(item, "number", "#,##0");},
        });
    }
    $("#"+ pControlGrafico).igDataChart({
        width: graf_ObtenerAnchoGrafico(pControlGrafico), //"100%",
        height: gGraficos[pControlGrafico].Alto, //"350px",
        //title: lTitulo,
        //subtitle: lSubTitulo,
        isHorizontalZoomEnabled: true,
        isverticalZoomEnabled: true,
        legend: graf_PropiedadesLeyenda(pControlGrafico, true),
        brushes: lPaleta,
        outlines: lPaleta,
        dataSource: pDatos,
        axes: lejes,
        series: lSeries,
        seriesMouseLeftButtonUp: function (evt, ui) {
            evt.preventDefault(); 
            evt.stopPropagation();
            var lCampoGrupo = Object.keys(gEntidad[gGraficos[pControlGrafico].Tabla][0])[0];
            var lValorGrupo = null;
            $.each(ui.item, function (lClave, lValor) {
                if (lClave == lCampoGrupo)
                    lValorGrupo = lValor;
            });
            gGraficos[pControlGrafico].GrupoSeleccionado = lValorGrupo;
            gGraficos[pControlGrafico].SerieSeleccionada = ui.series.valueMemberPath;
            qevt_AgregarEventoaTmp(pControlGrafico + '_Click', null, true);
        },
        tooltipShowing: function (evt, ui) {
            ui.item[ui.series.valueMemberPath] = $.ig.formatter(ui.item[ui.series.valueMemberPath], "number", "#.##0,00");
        }
    });

    $("#btnimp_" + pControlGrafico).unbind('click');
    $("#btnimp_" + pControlGrafico).on("click", function (event) {
        //$("#" + pControlGrafico).igDataChart("print");
        graf_DescargarImagen(pControlGrafico, lTitulo);
    })
}

function graf_CrearSeries(pTipoSerie, pValorMiembro) {
    var thickness = 1;
    var markerType = "none";
    //if (pTipoSerie == "column" || pTipoSerie == "waterfall")  
    //    thickness = 1;
    if (pTipoSerie == "line" || pTipoSerie == "spline")
        thickness = 3;
    else if (pTipoSerie == "point") 
        markerType = "circle";

    var series = {
        type: pTipoSerie,
        markerType: markerType,
        xAxis: "xAxis",
        yAxis: "yAxis",
        name: pValorMiembro + "series",
        title: pValorMiembro,
        valueMemberPath: pValorMiembro,
        isTransitionInEnabled: true,
        isHighlightingEnabled: true,
        showTooltip: true,
        thickness: thickness
    }
    return series;
}
             

function graf_CrearGraficoTorta(pControlGrafico, pDatos, pColValores, pColDescripcion) {

    var lTitulo = gGraficos[pControlGrafico].Titulo;
    var lSubTitulo = gGraficos[pControlGrafico].SubTitulo;
    var lTituloEjeV = gGraficos[pControlGrafico].TituloEjeValores;
    var lPosicionDesc = gGraficos[pControlGrafico].UbicacionDesc;
    var lColores = gGraficos[pControlGrafico].Colores;

    var lPaleta = [];
    if (lColores == "")
        lPaleta = gPaletaStd;
    else {
        var lColoresGraf = lColores.split('#');
        for (var i = 0; (i < lColoresGraf.length); i++) {
            if (lColoresGraf[i].trim() != "")
                lPaleta.push("#" + lColoresGraf[i].trim());
        }
    }
    
    $("#" + pControlGrafico).hasClass("ui-doughnut")

    var lExplodedSlices = [];

    for (var i = 1; i <= gGraficos[pControlGrafico].ValoresASeparar; i++)
        lExplodedSlices.push(i - 1);
    
    //if ($("#" + pControlGrafico).data("igPieChart") != null)
    //    $("#" + pControlGrafico).igPieChart("destroy");
    graf_DestruirGrafico(pControlGrafico);

    //$("#tit" + pControlGrafico).text(lTitulo);
    //$("#subtit" + pControlGrafico).text(lSubTitulo);
    $("#lbl" + pControlGrafico).text(lTitulo);
    
    $("#" + pControlGrafico).igPieChart({
            dataSource: pDatos,
            width: graf_ObtenerAnchoGrafico(pControlGrafico), //"100%",
            height: gGraficos[pControlGrafico].Alto, //"350px",
            brushes: lPaleta,
            outlines: lPaleta,
            //Ojo que el pie no tiene titulo
            //title: lTitulo,
            //subtitle: lSubTitulo,
            valueMemberPath: pColValores,
            labelMemberPath: pColDescripcion,
            legendLabelMemberPath: pColDescripcion,
            explodedSlices: lExplodedSlices,
            radiusFactor: .9,
            labelsPosition: lPosicionDesc,
            leaderLineType: "arc",
            labelExtent: 15,
        sliceClick: function (evt, ui) {
            evt.preventDefault();
            evt.stopPropagation();
            var lCampoGrupo = Object.keys(gEntidad[gGraficos[pControlGrafico].Tabla][0])[0];
            $.each(ui.slice.item, function (lClave, lValor) {
                if (lClave == lCampoGrupo)
                    lValorGrupo = lValor;
            });
            gGraficos[pControlGrafico].GrupoSeleccionado = lValorGrupo;
            gGraficos[pControlGrafico].SerieSeleccionada = "";
            qevt_AgregarEventoaTmp(pControlGrafico + '_Click', null, true);
        },

            //formatLabel: function (context) { return $.ig.formatter(context.percentValue, "number", "0.00") + " %"; },
            formatLabel: function (context) { return graf_LabelPorcionFormateado(context, pControlGrafico, pColValores, pColDescripcion); },
            legend: graf_PropiedadesLeyenda(pControlGrafico, false),
    });

    $("#btnimp_" + pControlGrafico).unbind('click');
    $("#btnimp_" + pControlGrafico).on("click", function (event) {
        //$("#" + pControlGrafico).igPieChart("print");
        graf_DescargarImagen(pControlGrafico, lTitulo);
    })

}



function graf_CrearGraficoDona(pControlGrafico, pDatos, pColValores, pColDescripcion) {

    var lTitulo = gGraficos[pControlGrafico].Titulo;
    var lSubTitulo = gGraficos[pControlGrafico].SubTitulo;
    var lTituloEjeV = gGraficos[pControlGrafico].TituloEjeValores;
    var lPosicionDesc = gGraficos[pControlGrafico].UbicacionDesc;
    var lColores = gGraficos[pControlGrafico].Colores;

    var lPaleta = [];
    if (lColores == "")
        lPaleta = gPaletaStd;
    else {
        var lColoresGraf = lColores.split('#');
        for (var i = 0; (i < lColoresGraf.length); i++) {
            if (lColoresGraf[i].trim() != "")
                lPaleta.push("#" + lColoresGraf[i].trim());
        }
    }



    //if ($("#" + pControlGrafico).data("igDoughnutChart") != null)
    //    $("#" + pControlGrafico).igDoughnutChart("destroy");
    graf_DestruirGrafico(pControlGrafico);


    //$("#tit" + pControlGrafico).text(lTitulo);
    //$("#subtit" + pControlGrafico).text(lSubTitulo);
    $("#lbl" + pControlGrafico).text(lTitulo);

    $("#" + pControlGrafico).igDoughnutChart({
        width: graf_ObtenerAnchoGrafico(pControlGrafico), //"100%",
        height: gGraficos[pControlGrafico].Alto, //"350px",
        brushes: lPaleta,
        outlines: lPaleta,

        //title: lTitulo,
        //subtitle: lSubTitulo,
        series: [
        {
            name: "SerieUnica",
            valueMemberPath: pColValores,
            labelMemberPath: pColDescripcion,
            legendLabelMemberPath: pColDescripcion,
            dataSource: pDatos, 
            //formatLabel: function (context) { return $.ig.formatter(context.percentValue, "number", "0.00") + " %"; },
            formatLabel: function (context) { return graf_LabelPorcionFormateado(context, pControlGrafico, pColValores, pColDescripcion); },            
            legend: graf_PropiedadesLeyenda(pControlGrafico, false),
            labelsPosition: lPosicionDesc,
            leaderLineType: "arc",
            labelExtent: 15
        },
        ],
        sliceClick: function (evt, ui) {
            evt.preventDefault();
            evt.stopPropagation();
            var lCampoGrupo = Object.keys(gEntidad[gGraficos[pControlGrafico].Tabla][0])[0];
            $.each(ui.slice.item, function (lClave, lValor) {
                if (lClave == lCampoGrupo)
                    lValorGrupo = lValor;
            });
            gGraficos[pControlGrafico].GrupoSeleccionado = lValorGrupo;
            gGraficos[pControlGrafico].SerieSeleccionada = "";
            qevt_AgregarEventoaTmp(pControlGrafico + '_Click', null, true);
        },

    });

    $("#btnimp_" + pControlGrafico).unbind('click');
    $("#btnimp_" + pControlGrafico).on("click", function (event) {
        //$("#" + pControlGrafico).igDoughnutChart("print");
        graf_DescargarImagen(pControlGrafico, lTitulo);
    })

}

function graf_DestruirGrafico(pControlGrafico) {
    
    if (gGraficos[pControlGrafico].Tipo == "P") {
        if ($("#" + pControlGrafico).hasClass("ui-doughnut")) {
            if ($("#" + pControlGrafico).data("igDoughnutChart") != null)
                $("#" + pControlGrafico).igDoughnutChart("destroy");
        }
        else {
            if ($("#" + pControlGrafico).data("igPieChart") != null)
                $("#" + pControlGrafico).igPieChart("destroy");
        }
    }
    else {
        if ($("#" + pControlGrafico).data("igDataChart") != null)
            $("#" + pControlGrafico).igDataChart("destroy");
    }
}


function graf_LabelPorcionFormateado(pContext, pControlGrafico, pColValores, pColDescripcion) {
    var lFormato = gGraficos[pControlGrafico].FormatoDesc;
    var lRetorno = pContext.item[pColDescripcion]; 
    switch (lFormato) {
        case "porcentaje": lRetorno = $.ig.formatter(pContext.percentValue, "number", "0.00") + "%";
            break;
        case "valor": lRetorno = $.ig.formatter(pContext.item[pColValores], "number", "#,###.00");
            break;
        case "lab_por": lRetorno += " (" + $.ig.formatter(pContext.percentValue, "number", "0.00") + "%)";
            break;
        case "lab_val": lRetorno += " (" + $.ig.formatter(pContext.item[pColValores], "number", "#,###.00")+ ")";
            break;
        case "val_por": lRetorno = $.ig.formatter(pContext.item[pColValores], "number", "#,###.00") + " (" + $.ig.formatter(pContext.percentValue, "number", "0.00") + "%)";
            break;
        case "por_val": lRetorno = $.ig.formatter(pContext.percentValue, "number", "0.00") + "% (" + $.ig.formatter(pContext.item[pColValores], "number", "#,###.00") + ")";
            break;

    }
    return lRetorno;
}


function graf_ObtenerAnchoGrafico(pControlGrafico) {
    var lRetorno = "100%";
    if ((gGraficos[pControlGrafico].Leyenda == "derecha") || (gGraficos[pControlGrafico].Leyenda == "izquierda")) {
        if (gGraficos[pControlGrafico].SubTipo == "doughnut")
            lRetorno = "72%"; //El control Dona de IG le agrega un 2%, no se por que
        else
            lRetorno = "74%";
    }
    return lRetorno;
}

function graf_PropiedadesLeyenda(pControlGrafico, pEsCategoria) {

    var lretorno = null;
    var lLeyenda = "div" + pControlGrafico + "legend";
    if (!pEsCategoria) {
        if ((gGraficos[pControlGrafico].Leyenda == "derecha") || (gGraficos[pControlGrafico].Leyenda == "izquierda")) {
            lretorno = { element: lLeyenda, type: "item", width: "25%", height: gGraficos[pControlGrafico].Alto };
        }
        else {
            lretorno = { element: lLeyenda, type: "item", width: "100%" };
        }
    }
    else {
        if ((gGraficos[pControlGrafico].Leyenda == "derecha") || (gGraficos[pControlGrafico].Leyenda == "izquierda")) {
            lretorno = { element: lLeyenda, width: "25%", height: gGraficos[pControlGrafico].Alto };
        }
        else {
            lretorno = { element: lLeyenda, width: "100%" };
        }
    }
    return lretorno;
}


function graf_MostrarAdicGrafico(pControlGrafico, pMostrar) {
    if (pMostrar) {
        $("#divbarra" + gGraficos[pControlGrafico].NombreControl).show();
        if (gGraficos[pControlGrafico].CambiaSubTipo)
            $("#divctrcbo" + gGraficos[pControlGrafico].NombreControl).show();
        if (gGraficos[pControlGrafico].Leyenda != "sinleyenda")
            $("#div" + gGraficos[pControlGrafico].NombreControl + "legend").removeClass("legend-Oculta");
    }
    else
    {
        $("#divbarra" + gGraficos[pControlGrafico].NombreControl).hide();
        $("#divctrcbo" + gGraficos[pControlGrafico].NombreControl).hide();
        $("#div" + gGraficos[pControlGrafico].NombreControl + "legend").addClass("legend-Oculta");
    }
}

function graf_EjecutarAcccionEnGrafico(pNombreAccion, pNombreGrafico, pTablasAEnviar, pTablasARefrescar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lPosLeft = window.pageXOffset;
    var lPosTop = window.pageYOffset;
    var lNombreTabla = gGraficos[pNombreGrafico].Tabla;
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lFila = graf_ArmarObjetoFilaFila(pNombreGrafico);
    var lAuxiliarClonado = qcom_Clonar(gEntidadAux);
    lAuxiliarClonado[lNombreTabla].splice(0);
    lAuxiliarClonado[lNombreTabla].push(lFila);
    var ldatasetAux = JSON.stringify(lAuxiliarClonado);
    var lIdSes = sessionStorage.getItem("idses");
    var lUrl = "AjaxHandler/AcGrafico.ashx";
    var lData = {
        pDsEntidad: ldataset, pDsEntidadAux: ldatasetAux, 
        pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(),
        pIdSes: lIdSes
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
               //ldatasetAux = JSON.parse(msg);
                gEntidad = qcom_CargarTablasARefrescar(pTablasARefrescar, msg, gEntidad);
                pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                qcom_CargarControlesFormulario(pTablasARefrescar, true, false);
                document.documentElement.scrollTop = lPosTop;
                document.documentElement.scrollLeft = lPosLeft;
                document.body.scrollTop = lPosTop;
                document.body.scrollLeft = lPosLeft;
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

function graf_ArmarObjetoFilaFila(pNombreGrafico) {
    var lNombreTabla = gGraficos[pNombreGrafico].Tabla;
    var lValores = qcom_Clonar(gClones[lNombreTabla]);
    var lCampoGrupo = Object.keys(gEntidad[lNombreTabla][0])[0];
    var lCampoSerie = Object.keys(gEntidad[lNombreTabla][0])[1];
    $.each(gEntidad[lNombreTabla], function (lClave, lValor) {
        if ((lValor[lCampoGrupo] == gGraficos[pNombreGrafico].GrupoSeleccionado) &&
            ((gGraficos[pNombreGrafico].SerieSeleccionada == "") ||
             (lValor[lCampoSerie] == gGraficos[pNombreGrafico].SerieSeleccionada))) {
                $.each(lValores, function (lClave2, lValor2) {
                    lValores[lClave2] = lValor[lClave2]
                });            
        }
    });
    return lValores;
}

function graf_DescargarImagen(pNombreControl, pNombreArch) {
    $("#divbarra" + gGraficos[pNombreControl].NombreControl).hide();
    $("#lbl" + gGraficos[pNombreControl].NombreControl).hide();    
    html2canvas(document.querySelector("#div" + pNombreControl), { backgroundColor: "transparent" }).then(canvas => {
        //document.body.appendChild(canvas)
        var theCanvas = canvas
        var imgUrl = theCanvas.toDataURL();
        $("#lbl" + gGraficos[pNombreControl].NombreControl).show();    
        $("#divbarra" + gGraficos[pNombreControl].NombreControl).show();
        var elem = window.document.createElement('a');
        elem.id = "reftempgraf";
        elem.href = imgUrl;
        elem.download = pNombreArch;
        document.body.appendChild(elem);
        elem.click();
        document.body.removeChild(elem);
    });
    $("#lbl" + gGraficos[pNombreControl].NombreControl).show();    
    $("#divbarra" + gGraficos[pNombreControl].NombreControl).show();
}