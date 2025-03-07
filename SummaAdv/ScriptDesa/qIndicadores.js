var gIndicadores = [];
var qindic_config = function (pNombre, pTipo, pAngInicio, pAngFin, pAncho, pAlto, pDecimales) {
    var _Nombre = pNombre;
    var _Tipo = pTipo;
    var _Creado = false;
    var _AngInicio = pAngInicio;
    var _AngFin = pAngFin;
    var _Alto = pAlto;
    var _Ancho = pAncho;
    var _Decimales = pDecimales;
    this.getNombre = function () { return _Nombre };
    this.getTipo = function () { return _Tipo };
    this.getAngInicio = function () { return _AngInicio };
    this.getAngFin = function () { return _AngFin };
    this.getAlto = function () { return _Alto };
    this.getAncho = function () { return _Ancho };
    this.getDecimales = function () { return _Decimales};
    this.getCreado = function () { return _Creado };
    this.setCreado = function (pValor) { _Creado = pValor};
}

//var pRangos = [{ Color: "#754339", ValorInicio: "0", ValorFin: "30" },
//{ Color: "#766967", ValorInicio: "30", ValorFin: "60" },
//{ Color: "#866967", ValorInicio: "60", ValorFin: "100" }]   
function qindic_Crear(pNombre, pValorAct, pTextoAdicional, pRangos) {
    var lIndicador = null;
    //if ($("#" + pNombre).igRadialGauge().length > 0)
    //    $("#" + pNombre).igRadialGauge("destroy");


    $.each(gIndicadores, function (lClave, lValor) {
        if (lValor.getNombre() == pNombre) {
            lIndicador = lValor;
        }
    })

    if (lIndicador != null) {

        if (lIndicador.getCreado())
            if (lIndicador.getTipo() == "S")
                $("#" + pNombre).igRadialGauge("destroy");
            else
                $("#" + pNombre).igLinearGauge("destroy");

        lIndicador.setCreado(true);

        var lValMin = 0;
        var lValMax = 0;

        if (pRangos.length > 0) {
            lValMin = pRangos[0].ValorInicial;
            lValMax = pRangos[pRangos.length - 1].ValorFinal;
        }

        var lDecimales = lIndicador.getDecimales();

        if (lIndicador.getTipo() == "S") {
            $("#" + pNombre).igRadialGauge({
                height: lIndicador.getAlto(), //"300px",
                width: "100%",
                minimumValue: lValMin,
                maximumValue: lValMax,
                value: pValorAct,

                //Scale Settings
                scaleStartAngle: lIndicador.getAngInicio(),
                scaleEndAngle: lIndicador.getAngFin(),
                scaleBrush: "transparent",

                //Backing Settings
                backingShape: "fitted",
                //backingOutline: "rgba(22, 169, 231, 1)",
                backingBrush: "black",

                transitionDuration: "1",

                //Needle Settings
                needleShape: "triangle",
                // needlePivotShape: "circleOverlay",
                needleEndExtent: "0.55",
                needlePointFeatureExtent: "0.3",
                needlePivotWidthRatio: "0.0",
                needlePivotInnerWidthRatio: "0.1",
                // needleBaseFeatureWidthRatio: "0.4",
                // needleBrush: "lightgray",
                tickStrokeThickness: 1,
                minorTickStrokeThickness: 1,
                minorTickCount: 10,

                //TickMark Settings
                tickBrush: "black",
                minorTickBrush: "black",
                //Label Settings
                labelExtent: "0.70",
                fontBrush: "gainsboro",

                backingInnerExtent: "0.0",
                backingOuterExtent: "0.0",
                //backingOutline: "yellow",
                formatLabel: function (evt, ui) {

                    ui.label = ui.value.toFixed(lDecimales) + pTextoAdicional;
                }
            });

            var lRanges = [];

            $.each(pRangos, function (lClave, lValor) {
                lRanges.push({
                    name: 'range' + lClave, brush: lValor.Color, startValue: lValor.ValorInicial, endValue: lValor.ValorFinal,
                    outerStartExtent: "0.6", outerEndExtent: "0.6"
                })
            })

            $("#" + pNombre).igRadialGauge("option", "ranges", lRanges);
        }
        else {

            var lAlto = "";
            var lAncho = "";
            if (lIndicador.getAngInicio() == "horizontal") {
                lAlto = "80px";
                lAncho = "100%";
            }
            else {
                lAlto = lIndicador.getAlto();
                lAncho = lIndicador.getAncho();
            }

            $("#" + pNombre).igLinearGauge({
                height: lAlto,
                width: lAncho,
                minimumValue: lValMin,
                maximumValue: lValMax,
                value: pValorAct,

                needleBrush: "lightgray",
                orientation: lIndicador.getAngInicio(),
                //Label Settings
                labelExtent: "0.70",
                fontBrush: "gainsboro",
                backingStrokeThickness: 0,
                backingInnerExtent: "0.0",
                backingOuterExtent: "0.0",
                tickStrokeThickness: 1,
                minorTickStrokeThickness: 1,
                minorTickCount: 10,

                formatLabel: function (evt, ui) {
                    ui.label = ui.value.toFixed(lDecimales) + pTextoAdicional;
                }
            });

            var lRanges = [];

            $.each(pRangos, function (lClave, lValor) {
                lRanges.push({
                    name: 'range' + lClave, brush: lValor.Color, startValue: lValor.ValorInicial, endValue: lValor.ValorFinal,
                    outerStartExtent: "0.6", outerEndExtent: "0.6"
                })
            })

            $("#" + pNombre).igLinearGauge("option", "ranges", lRanges);

        }
    }
}

function qindic_DestruirTodo() {
    $.each(gIndicadores, function (lClave, lValor) {
        if (lValor.getCreado())
            if (lValor.getTipo() == "S")
                $("#" + lValor.getNombre()).igRadialGauge("destroy");
            else
                $("#" + lValor.getNombre()).igLinearGauge("destroy");
        lValor.setCreado(false);
    })
}

function qindic_DestruirIndicador(pNombre) {
    $.each(gIndicadores, function (lClave, lValor) {
        if (lValor.getNombre() == pNombre) {
            if (lValor.getCreado())
                if (lValor.getTipo() == "S")
                    $("#" + lValor.getNombre()).igRadialGauge("destroy");
                else
                    $("#" + lValor.getNombre()).igLinearGauge("destroy");
            lValor.setCreado(false);
        }
    })
}
