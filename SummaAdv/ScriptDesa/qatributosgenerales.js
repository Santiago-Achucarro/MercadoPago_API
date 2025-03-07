function qatrib_ControlesaTablas() {
    var lNombreTabla = "genAtributosGenerales";
    //var lTieneAtrib = false;
    if (gAtribGralesAux.length > 0) {
        if (gEntidad[lNombreTabla].length > 0)
            gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
        if (gEntidadAux[lNombreTabla].length > 0)
            gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
        $.each(gAtribGralesAux, function (lClave, lClaveAtrib) {
            //lTieneAtrib = true;
            var lobjCtrl = gAtribGrales[lClaveAtrib];
            lValorCtr = qcom_ObtenerValorControl(lobjCtrl);
            var lValores = qcom_Clonar(gClones[lNombreTabla]);
            //var larrClaveAtrib = lClaveAtrib.split('|');
            lValores["AtributoNro"] = parseInt(lClaveAtrib); //parseInt(larrClaveAtrib[0]);
            lValores["Descripcion"] = "";//larrClaveAtrib[1];
            lValores["Tipo"] = "";
            lValores["ValorC"] = "";
            lValores["ValorN"] = 0;
            var lFechaVacia = new Date();
            lFechaVacia.setUTCFullYear(1, 0, 2);
            lFechaVacia.setUTCHours(0, 0, 0, 0);
            var lFechaJsonUTC = lFechaVacia.toJSON();
            lValores["ValorF"] = lFechaJsonUTC;
            switch (lobjCtrl.getTipoControl()) {
                case 1: //"igTextEditor":
                    lValores["Tipo"] = "C";
                    lValores["ValorC"] = lValorCtr;
                    break;
                case 2: //"igNumericEditor": 
                    lValores["Tipo"] = "N";
                    lValores["ValorN"] = lValorCtr;
                    break;
                case 3: //"igDatePicker":
                    lValores["Tipo"] = "F";
                    lValores["ValorF"] = lValorCtr;
                    break;
                case 4  : //"igChecBox":
                    lValores["Tipo"] = "N";
                    lValores["ValorN"] = lValorCtr;
                    break;
                case 5: //"igCombo":
                    lValores["Tipo"] = "C";
                    lValores["ValorC"] = lValorCtr;
                    break;

                default:
                    break;
            }
            gEntidad[lNombreTabla].push(jQuery.extend({}, lValores));
        });
    }
}

function qatrib_DeshabilitarAtribGralesEspec() {
    $.each(gAtribGralesAux, function (lClave, lClaveAtrib) {
        var lobjCtrl = gAtribGrales[lClaveAtrib];
        qcom_DesHabilitarControl(lobjCtrl.getControl()[0].id);
    });
}

function qatrib_InicializarControles() {
    if (gAtribGralesAux.length > 0) {
        var lNombreTabla = "genAtributosGenerales";
        
        $.each(gAtribGralesAux, function (lClave, lClaveAtrib) {
            var lobjCtrl = gAtribGrales[lClaveAtrib];
            qcom_AsignarValorControl(lobjCtrl, lobjCtrl.getDefecto(), true);
            lTieneAtrib = true;
        });
        if (gEntidad[lNombreTabla].length > 0)
            gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
        if (gEntidadAux[lNombreTabla].length > 0)
            gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
    }
}

function qatrib_TablaaControles() {
    if (gAtribGralesAux.length > 0) {
        var lNombreTabla = "genAtributosGenerales";
        for (var i = 0; (i < gEntidad[lNombreTabla].length); i++) {
            var lAtributoNro = gEntidad[lNombreTabla][i]["AtributoNro"];
            //var lDescripcion = gEntidad[lNombreTabla][i]["Descripcion"];
            //var lClave = lAtributoNro + '|' + lDescripcion;
            var lClave = lAtributoNro;
            var lobjCtrl = gAtribGrales[lClave];
            switch (lobjCtrl.getTipoControl()) {
                case 1: //"igTextEditor":
                    qcom_AsignarValorControl(gAtribGrales[lClave], gEntidad[lNombreTabla][i]["ValorC"], false);
                    break;
                case 2: //"igNumericEditor": 
                    qcom_AsignarValorControl(gAtribGrales[lClave], gEntidad[lNombreTabla][i]["ValorN"], false);
                    break;
                case 3: //"igDatePicker":
                    qcom_AsignarValorControl(gAtribGrales[lClave], gEntidad[lNombreTabla][i]["ValorF"], false);
                    break;
                case 4: //"igCheckBox":
                    qcom_AsignarValorControl(gAtribGrales[lClave], gEntidad[lNombreTabla][i]["ValorN"], false);
                    break;
                case 5: //"igCombo":
                    qcom_AsignarValorControl(gAtribGrales[lClave], gEntidad[lNombreTabla][i]["ValorC"], false);                    
                    break;

                default:
                    break;
            }  
        }
    }
}

function qatrib_PrepararEspec() {
    gControles["genAtributosGeneralesEspec"] = [];
    gControles["genAtributosGeneralesEspec"][0] = {}; 
}

function qatrib_FinPrepararEspec() {
    var lCantAtrib = gAtribGralesAux.length;
    $.each(gControles["genAtributosGeneralesEspec"][0], function (lClave, lControl) {
        var lNroAtrib = lClave.substring(9); //AtribGral2
        gAtribGralesAux[lCantAtrib] = lNroAtrib;
        gAtribGrales[lNroAtrib] = lControl
        lCantAtrib++;
    });

    //delete gControles["genAtributosGeneralesEspec"];
}