var qcom_formulario = function (pClaseEnum, pClaseExchange, pDLLExchange, pClaseCommon, pDLLCommon, pClaseEventos,
                                pDLLEventos, pFormID, pPostear, pBorrar, pUsuarioModif, pUsuarioPostear, pUsuarioBorrar, pClaseEnumEsp,
                                pClaseExchangeEsp, pDLLExchangeEsp, pClaseCommonEsp, pDLLCommonEsp, pClaseEventosEsp,
                                pDLLEventosEsp, pEspecializacion) {
    var _ClaseEnum = pClaseEnum;
    var _ClaseExchange = pClaseExchange;
    var _DLLExchange = pDLLExchange;
    var _ClaseCommon = pClaseCommon;
    var _DLLCommon = pDLLCommon;
    var _ClaseEventos = pClaseEventos;
    var _DLLEventos = pDLLEventos;
    var _ClaseEnumEsp = pClaseEnumEsp;
    var _ClaseExchangeEsp = pClaseExchangeEsp;
    var _DLLExchangeEsp = pDLLExchangeEsp;
    var _ClaseCommonEsp = pClaseCommonEsp;
    var _DLLCommonEsp = pDLLCommonEsp;
    var _ClaseEventosEsp = pClaseEventosEsp;
    var _DLLEventosEsp = pDLLEventosEsp;

    var _FormID = pFormID;
    var _Postear = pPostear;
    var _Borrar = pBorrar;
    var _UsuarioModif = pUsuarioModif;
    var _UsuarioPostear = pUsuarioPostear;
    var _UsuarioBorrar = pUsuarioBorrar;
    this.getClaseEnum = function () { return _ClaseEnum; }
    this.getClaseExchange = function () { return _ClaseExchange; }
    this.getDLLExchange = function () { return _DLLExchange; }
    this.getClaseCommon = function () { return _ClaseCommon; }
    this.getDLLCommon = function () { return _DLLCommon; }
    this.getClaseEventos = function () { return _ClaseEventos; }
    this.getDLLEventos = function () { return _DLLEventos; }
    this.getClaseEnumEsp = function () { return _ClaseEnumEsp; }
    this.getClaseExchangeEsp = function () { return _ClaseExchangeEsp; }
    this.getDLLExchangeEsp = function () { return _DLLExchangeEsp; }
    this.getClaseCommonEsp = function () { return _ClaseCommonEsp; }
    this.getDLLCommonEsp = function () { return _DLLCommonEsp; }
    this.getClaseEventosEsp = function () { return _ClaseEventosEsp; }
    this.getDLLEventosEsp = function () { return _DLLEventosEsp; }
    this.getFormID = function () { return _FormID; }
    this.getPostear = function () { return _Postear; }
    this.getBorrar = function () { return _Borrar; }
    this.getUsuarioModif = function () { return _UsuarioModif; }
    this.getUsuarioPostear = function () { return _UsuarioPostear; }
    this.getUsuarioBorrar = function () { return _UsuarioBorrar; }
}

var qcom_configuracion = function (pEmpresa, pUsuario, pDominio, pMoneda, pProveed_Id, pCliente_Id, pClienteSucursal, pLegajo, pVendedor_Id, pCobrador_Id, pSitio, pFormulario, pSucursal, pInstalacion) {
    var _Empresa = pEmpresa;
    var _Usuario = pUsuario;
    var _Dominio = pDominio;
    var _Moneda = pMoneda;
    var _Proveed_Id = pProveed_Id;
    var _Cliente_Id = pCliente_Id;
    var _ClienteSucursal = pClienteSucursal;
    var _Legajo = pLegajo;
    var _Vendedor_Id = pVendedor_Id;
    var _Cobrador_Id = pCobrador_Id;
    var _Sitio = pSitio;
    var _Formulario = pFormulario;
    //var _Sucursal = pSucursal;
    sessionStorage.setItem("Sucursal", pSucursal);
    var _Instalacion = pInstalacion;

    this.getEmpresa = function () { return _Empresa; }
    this.getUsuario = function () { return _Usuario; }
    this.getDominio = function () { return _Dominio; }
    this.getMoneda = function () { return _Moneda; }
    this.getProveed_Id = function () { return _Proveed_Id; }
    this.getCliente_Id = function () { return _Cliente_Id; }
    this.getClienteSucursal = function () { return _ClienteSucursal; }
    this.getLegajo = function () { return _Legajo; }
    this.getVendedor_Id = function () { return _Vendedor_Id; }
    this.getFormulario = function () { return _Formulario; }
    this.getCobrador_Id = function () { return _Cobrador_Id; }
    this.getSitio = function () { return _Sitio; }
    //this.getSucursal = function () { return _Sucursal; }
    this.getSucursal = function () { return sessionStorage.getItem("Sucursal"); }
    this.getInstalacion = function () { return _Instalacion; }
    this.getValorVariable = function (pVariable) {
        var lretorno = pVariable;
        switch (pVariable) {
            case '{gEmpresa}': lretorno = _Empresa;
                break;
            case '{gUsuario}': lretorno = _Usuario;
                break;
            case '{gMoneda}': lretorno = _Moneda;
                break;
            case '{gDominio}': lretorno = _Dominio;
                break;
            case '{gProveed_Id}': lretorno = _Proveed_Id;
                break;
            case '{gCliente_Id}': lretorno = _Cliente_Id;
                break;
            case '{gClienteSucursal}': lretorno = _ClienteSucursal;
                break;
            case '{gLegajo}': lretorno = _Legajo;
                break;
            case '{gVendedor_Id}': lretorno = _Vendedor_Id;
                break;
            case '{gCobrador_Id}': lretorno = _Cobrador_Id;
                break;
            case '{gSitio}': lretorno = _Sitio;
                break;
                //case '{gSucursal}': lretorno = _Sucursal;
            case '{gSucursal}': lretorno = sessionStorage.getItem("Sucursal");
                break;
            case '{gFormulario}': lretorno = _Formulario;
                break;

            case '{gPrueba}': lretorno = '1';
                break;
            default: lretorno = pVariable;
        }
        return lretorno;
    }
    this.setValorVariable = function (pVariable, pValor) {
        switch (pVariable) {
            case '{gEmpresa}':
                break;
            case '{gUsuario}':
                break;
            case '{gMoneda}':
                break;
            case '{gDominio}':
                break;
            case '{gProveed_Id}':
                break;
            case '{gCliente_Id}':
                break;
            case '{gClienteSucursal}':
                break;
            case '{gLegajo}':
                break;
            case '{gVendedor_Id}':
                break;
            case '{gCobrador_Id}':
                break;
            case '{gSitio}':
                break;
            case '{gSucursal}':
                qcom_CambiarValorVariableSesion("Sucursal", pValor);
                break;
            case '{gFormulario}':
                break;
            case '{gPrueba}':
                break;
        }
    }

}

var qcom_control = function (pControl, pTipoControl, pTipoDato, pDefecto, pVisible, pVisibleXPais, pHabilitado, pControlConjunto, pRequerido, pGrillaEdicion, pNuevoBlanquea, pRelleno, pIdentidad) {
    var _Control = pControl;
    var _TipoControl = pTipoControl; //0-label, 1-igTextEditor, 2-igNumericEditor, 3-igDatePicker, 4-checkbox, 5-igCombo, 6-igGrid, 7-boton, 8-Parametro, 9-Porcentaje, 10-OptionGroup, 11-Segmento_id, 12-UpLoad
    var _TipoDato = pTipoDato; //0-nada, 1-string, 2-nuemrico, 3-fecha, 4-bool
    var _Defecto = pDefecto;
    var _Visible = pVisible;
    var _VisibleXPais = pVisibleXPais;
    var _Habilitado = pHabilitado;
    var _ControlConjunto = pControlConjunto;
    var _Requerido = pRequerido;
    var _GrillaEdicion = pGrillaEdicion;
    var _NuevoBlanquea = pNuevoBlanquea;
    var _Relleno = pRelleno;
    var _Identidad = pIdentidad;
    if (_Requerido)
        _Control.addClass("quasar-requerido");
    switch (_TipoControl) {
        case 1: //"igTextEditor":
            _Control.addClass("quasar-editortexto");
            break;
        case 2: //"igNumericEditor": 
            _Control.addClass("quasar-editornumerico");
            break;
        case 3: //"igDatePicker":
            _Control.addClass("quasar-editorfecha");
            break;
        case 5: //"igCombo":
            _Control.addClass("quasar-editorcombo");
            break;
        case 4: //"checkbox": 
            _Control.addClass("quasar-editorcheckbox");
            break;
        case 9: //"porcentaje": 
            _Control.addClass("quasar-editorporcentaje");
            break;
        case 10: //"OptionGroup": 
            _Control.addClass("quasar-editoroptiongroup");
            break;
        case 11: //"Segmento_Id": 
            //No se puede asignar ninguna clase, porque no existe nunca un control para el segmento_id
            //_Control.addClass("quasar-editorsegmento_id");
            break;

        default:
            break;
    }

    this.getControl = function () { return _Control };
    this.getTipoControl = function () { return _TipoControl };
    this.getTipoDato = function () { return _TipoDato };
    this.getDefecto = function () {
        if (typeof _Defecto === 'string' || _Defecto instanceof String) {
            if (_Defecto.startsWith('{')) {
                return gConfiguracion.getValorVariable(_Defecto);
            }
            else
                return _Defecto;
        }
        else
            return _Defecto;
    };
    this.getHabilitado = function () { return _Habilitado };
    this.getVisible = function () { return _Visible };
    this.getVisibleXPais = function () { return _VisibleXPais };
    this.getControlConjunto = function () { return _ControlConjunto };
    this.getRequerido = function () { return _Requerido };
    this.getGrillaEdicion = function () { return _GrillaEdicion };
    this.getNuevoBlanquea = function () { return _NuevoBlanquea };
    this.getRelleno = function () { return _Relleno };
    this.getIdentidad = function () { return _Identidad };
    this.setIdentidad = function (pvalor) { _Identidad = pvalor };
    if (_ControlConjunto != "")
        $("#div" + _ControlConjunto)[0].setAttribute("VisiblexPais", _VisibleXPais);
}

var qcom_controlGrupo = function (pNombreControl, pVisible, pVisibleXPais) {
    var _NombreControl = pNombreControl;
    var _Visible = pVisible;
    var _VisibleXPais = pVisibleXPais;
    this.getVisible = function () { return _Visible };
    this.getVisibleXPais = function () { return _VisibleXPais };
    this.getNombreControl = function () { return _NombreControl };
}


var qcom_segmento = function (pNombre) {
    var _Nombre = pNombre;
    var lpos = _Nombre.indexOf("Segmento_Id");
    var _Sufijo = _Nombre.slice(lpos + 11);

    var _Prefijo = ''; //calcular el Prefijo en base al nombre
    var _IdSeg = '';
    var _Principal = false;
    var _Tabla = '';
    var _Identidad = '';
    var _Campos = ["", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposSeg = ["", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposAdic = ["", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposNC = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _CamposSegNC = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _CamposSegAlias = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _Posiciones = [];
    this.getPrefijo = function () { return _Prefijo };
    this.getSufijo = function () { return _Sufijo };
    this.getPrincipal = function () { return _Principal };
    this.getTabla = function () { return _Tabla };
    this.getIdentidad = function () { return _Identidad };
    this.getIdSeg = function () { return _IdSeg };
    this.getNombre = function () { return _Nombre };
    this.getCampoCtrl = function (pOrigen) { return _Campos[pOrigen - 1]; };
    this.getCampoCtrlAdic = function (pOrigen) { return _CamposAdic[pOrigen - 1]; };
    this.getCampoCtrlSeg = function (pOrigen) { return _CamposSeg[pOrigen - 1]; };
    this.getCampoNCCtrl = function (pOrigen) { return _CamposNC[pOrigen - 1]; };
    this.getCampoNCCtrlSeg = function (pOrigen) { return _CamposSegNC[pOrigen - 1]; };
    this.getCampoSegAlias = function (pOrigen) { return _CamposSegAlias[pOrigen - 1]; };
    this.getPosiciones = function () { return _Posiciones; };
    this.setPrincipal = function (valor) { _Principal = valor };
    this.setTabla = function (valor) { _Tabla = valor };
    this.setIdentidad = function (valor) { _Identidad = valor };
    this.setIdSeg = function (valor) { _IdSeg = valor };
    this.setCampoCtrl = function (pOrigen, pValor) { _Campos[pOrigen - 1] = pValor; };
    this.setCampoCtrlAdic = function (pOrigen, pValor) { _CamposAdic[pOrigen - 1] = pValor; };
    this.setCampoCtrlSeg = function (pOrigen, pValor) { _CamposSeg[pOrigen - 1] = pValor; };
    this.setCampoSegAlias = function (pOrigen, pValor) { _CamposSegAlias[pOrigen - 1] = pValor; };
    this.setCampoNCCtrl = function (pOrigen, pValor) { _CamposNC[pOrigen - 1] = pValor; };
    this.setCampoNCCtrlSeg = function (pOrigen, pValor) { _CamposSegNC[pOrigen - 1] = pValor; };
    this.SetPosicion = function (pValor) { return _Posiciones.push(pValor); };
}


var qcom_Relacion = function (pTablaMaster, pTablaDetalle, pColMaster, pColMaster2, pColMaster3, pColDetalle, pColDetalle2, pColDetalle3) {
    var _TablaMaster = pTablaMaster;
    var _TablaDetalle = pTablaDetalle;
    var _ColMaster = pColMaster;
    var _ColMaster2 = pColMaster2;
    var _ColMaster3 = pColMaster3;
    var _ColDetalle = pColDetalle;
    var _ColDetalle2 = pColDetalle2;
    var _ColDetalle3 = pColDetalle3;
    var _ValorMaster = -1;
    this.getTablaMaster = function () { return _TablaMaster };
    this.getTablaDetalle = function () { return _TablaDetalle };
    this.getColMaster = function () { return _ColMaster };
    this.getColMaster2 = function () { return _ColMaster2 };
    this.getColMaster3 = function () { return _ColMaster3 };
    this.getColDetalle = function () { return _ColDetalle };
    this.getColDetalle2 = function () { return _ColDetalle2 };
    this.getColDetalle3 = function () { return _ColDetalle3 };
    this.getValorMaster = function () { return _ValorMaster };
    this.setValorMaster = function (pValor) { _ValorMaster = pValor };
}


//var gSegmento1 = { Id: "", Principal: "", Tabla: "", Prefijo: "", Sufijo: ""};
/************** Métodos para obtener y asignar valores a los distintos controles **************************/
function qcom_ObtenerValorControl(pControl) {
    lRetVal = "";
    switch (pControl.getTipoControl()) {
        case 1: //"igTextEditor":
            lRetVal = qcom_ObtenerValorTextEditor(pControl);
            break;
        case 2: //"igNumericEditor": 
            return qcom_ObtenerValorNumEditor(pControl);
            break;
        case 3: //"igDatePicker":
            lRetVal = qcom_ObtenerValorFechaEditor(pControl);
            break;
        case 5: //"igCombo":
            lRetVal = qcom_ObtenerValorCombo(pControl);
            break;
        case 4: //"checkbox": 
            return qcom_ObtenerValorCheckBox(pControl);
            break;
        case 9: //"igPercentEditor": 
            return qcom_ObtenerValorPorcEditor(pControl);
            break;
        case 10: //"OptionGroup": 
            return qcom_ObtenerValorOptionGroup(pControl);
            break;
        case 11: //"Segmento_Id": Debo Obtener la concatenacion de cada uno de sus componentes
            return qcom_ObtenerDescripcionSegmento(pControl.getControl());
            break;
        case 12: //UpLoad: pasa el valor que tiene concatenado
            return qcom_ObtenerValorUpLoad(pControl);;
            break;

        default:
            break;
    }
    if ((pControl.getTipoDato() == 2) && (lRetVal == "")) {
        lRetVal = "0"
    }
    return lRetVal;
}

function qcom_ObtenerValorTextEditor(pControl) {
    //return pControl.getControl().igTextEditor("value");
    // Esto pasa cuando viene del segmento Oculto
    if (pControl.getControl().igTextEditor().length == 0)
        return "";
    return pControl.getControl().igTextEditor()[0].value
}

function qcom_ObtenerValorNumEditor(pControl) {
    lValRet = pControl.getControl().igNumericEditor("value")
    if (lValRet == "")
        lValRet = "0";
    return lValRet;
}

function qcom_ObtenerValorPorcEditor(pControl) {
    lValRet = pControl.getControl().igPercentEditor("value")
    if (lValRet == "")
        lValRet = "0";
    return lValRet;
}

function qcom_ObtenerValorOptionGroup(pControl) {
    var lNombreCtrl = pControl.getControl().selector.substring(1, pControl.getControl().selector.length);
    var lElem = $('input[name="' + lNombreCtrl + '"]:checked');
    lValRet = "";
    if (lElem.length > 0)
        lValRet = lElem[0].value;
    return lValRet;
}


function qcom_ObtenerValorFechaEditor(pControl) {
    var lvalue = pControl.getControl().igDatePicker("value");
    if ((lvalue == null) || (lvalue == "")) {
        var lFechaVacia = new Date();
        lFechaVacia.setUTCFullYear(1, 0, 2);
        lFechaVacia.setUTCHours(0, 0, 0, 0);
        var lFechaJsonUTC = lFechaVacia.toJSON();
        //el formato con el que las genera es yyyy-mm-ddT00:00:00.000Z"
        //Tengo que quitarle los ultimos 4 caracteres para que despues no tome el timezone
        if (lFechaJsonUTC.length > 19)
            lFechaJsonUTC = lFechaJsonUTC.substring(0, 19);
        return lFechaJsonUTC;
    }
    else {
        var lFechaNueva = new Date();
        lFechaNueva.setUTCFullYear(lvalue.getFullYear(), lvalue.getMonth(), lvalue.getDate());
        lFechaNueva.setUTCHours(0, 0, 0, 0);
        var lFechaJsonUTC = lFechaNueva.toJSON();
        if (lFechaJsonUTC.length > 19)
            lFechaJsonUTC = lFechaJsonUTC.substring(0, 19);
        return lFechaJsonUTC;
    }
}

function qcom_ObtenerValorCombo(pControl) {
    if (pControl.getControl().igCombo("text") != "") {
        //Debo dividir en dos casos, 
        //el primero si el texto ingresado no existe en la lista de elementos del combo (se utiliza en combos editables)
        if ($.isArray(pControl.getControl().igCombo("value")))
            return pControl.getControl().igCombo("value")[0];
            //si el texto ingresado existe en la lista de elementos del combo
        else
            return pControl.getControl().igCombo("value");
    }
    else if (pControl.getTipoDato() == 2)
        return 0;
    else
        return "";
}

function qcom_ObtenerValorCheckBox(pControl) {
    return pControl.getControl().prop('checked');
}


function qcom_ObtenerValorUpLoad(pControl) {
    var lnombre = pControl.getControlConjunto();
    return gUpLoads[lnombre];
}


function qcom_EstablecerFoco(pControlName) {
    var lcontrol = "#" + pControlName;
    if (qcom_existeControl(lcontrol)) {
        $(lcontrol).focus();
    }
    else { //Veo si es una lupa
        lcontrol = "#" + pControlName + "_1";
        if (qcom_existeControl(lcontrol))
            $(lcontrol).focus();
        else { //veo si es un segmento
            var lCantidad = gSegmentos.length;
            var lEncontre = false;
            for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
                lEncontre = (gSegmentos[i].getNombre() == pControlName);
                if (lEncontre) {
                    lSeg = gSegmentos[i];
                    var lPosiciones = lSeg.getPosiciones();
                    gControles[lSeg.getTabla()][0][lPosiciones[0]].getControl().focus();
                }
            }
        }
    }
}

function qcom_AsignarValorControl(pControl, pValor, pInicializar) {

    // AJ A VECES VIENE EN NULL
    if (pControl == null)
        return;
    if (pValor == null)
        return;
    switch (pControl.getTipoControl()) {
        case 1://"igTextEditor": 

            qcom_AsignarValorTextEditor(pControl, pValor);
            break;
        case 2: //"igNumericEditor": 
            qcom_AsignarValorNumEditor(pControl, pValor);
            break;
        case 3: //"igDatePicker": 
            if (pInicializar)
                pControl.getControl().igDatePicker("value", pValor);
            else
                qcom_AsignarValorFechaEditor(pControl, pValor);
            break;
        case 5: //"igCombo": 
            qcom_AsignarValorCombo(pControl, pValor);
            break;
        case 4://"checkbox": 
            qcom_AsignaValorCheckBox(pControl, pValor);
            break;
        case 9: //"igPercentEditor": 
            qcom_AsignarValorPorcEditor(pControl, pValor);
            break;
        case 10: //"OptionGroup": 
            qcom_AsignarValorOptionGroup(pControl, pValor);
            break;
        case 12: //"UpLoad": 
            var lNombreControl = pControl.getControlConjunto();
            if (pValor != "") {
                var lComponente = pValor.split('|');
                if (lComponente.length == 1) //Archivo Sin cambios, solo debo guardar el nombre que subió el cliente
                    if (pValor == 'B')
                        qcom_AsignarValorUpLoad(lNombreControl, '', 'B');
                    else
                        qcom_AsignarValorUpLoad(lNombreControl, pValor, 'X');
                else if (lComponente.length == 2)
                    qcom_AsignarValorUpLoad(lNombreControl, lComponente[1], lComponente[0]);
                else
                    qcom_AsignarValorUpLoad(lNombreControl, lComponente[1] + "|" + lComponente[2], lComponente[0]);
            }
            else
                qcom_AsignarValorUpLoad(lNombreControl, pValor, ''); //No tenia archivo
            break;

    }
}

function qcom_AsignarValorTextEditor(pControl, pValor) {
    if (pValor == null)
        pValor = "";
    if ((pValor != "") && (pControl.getRelleno() != 0)) {
        pValor = ("0000000000" + pValor).slice(-1 * pControl.getRelleno());
    }

    pControl.getControl().igTextEditor("value", pValor);
}

function qcom_AsignarValorNumEditor(pControl, pValor) {
    if ((pValor == null) || (pValor == ""))
        pValor = 0;
    pControl.getControl().igNumericEditor("value", pValor);
}

function qcom_AsignarValorPorcEditor(pControl, pValor) {
    if ((pValor == null) || (pValor == ""))
        pValor = 0;
    pControl.getControl().igPercentEditor("value", pValor);
}

function qcom_AsignarValorOptionGroup(pControl, pValor) {
    var lNombreCtrl = pControl.getControl().selector.substring(1, pControl.getControl().selector.length);
    var lelem = $('input[name="' + lNombreCtrl + '"][value="' + pValor + '"]');
    if (lelem.length > 0)
        lelem[0].checked = true;
}


//function qcom_AsignarValorDownLoad(pControl, pValor) {
//    var lTitulo = "";
//    var lNombreArchivo = "";
//    var lEsUrl = false;
//    var lExtension = "";
//    var lArchivooUrl = "";
//    var ltipocont = '';
//    if ((pValor != null) && (pValor != "")) {
//        //Hago el split de los valores, ya que vienen 5 propiedades en el Valor
//        //1-Titulo del Link, 2-Nombre del archivo descargado, 3-es Url (si no es base 64), 4-Extension del archivo (en caso que sea base64), 5-Archivo base64 o Url
//        var lcomponentes = pValor.split("|");
//        if (lcomponentes.length > 0)
//            lTitulo = lcomponentes[0];
//        if (lcomponentes.length > 1)
//            lNombreArchivo = lcomponentes[1];
//        if (lcomponentes.length > 2)
//            lEsUrl = lcomponentes[2];
//        if (lcomponentes.length > 3)
//            lExtension = lcomponentes[3];
//        if (lcomponentes.length > 4)
//            lArchivooUrl = lcomponentes[4];
//    }
//    //if (lEsUrl == "false") {
//    //    ltipocont = 'data:application/octet-stream;base64,';
//    //    if ((lExtension == 'jpg') || (lExtension == 'jpeg') ||
//    //        (lExtension == 'png') || (lExtension == 'gif') || (lExtension == 'bmp'))
//    //        ltipocont = 'data:image/' + lExtension + ';base64,';
//    //}
//    ltipocont = qcom_ObtenerTipoContDownLoad(lEsUrl, lExtension)

//    pControl.getControl().attr('href', ltipocont + lArchivooUrl);
//    pControl.getControl().attr('download', lNombreArchivo);
//    //obtengo el nombre del boton asociado
//    var lNombreBoton = pControl.getControl().selector.substring(4);
//    $("#" + lNombreBoton)[0].value = lTitulo;
//    if (lArchivooUrl != "")
//        qcom_HabilitarControl(lNombreBoton);
//    else
//        qcom_DesHabilitarControl(lNombreBoton);
//}
function qcom_AsignarValorUpLoad(pNombreControl, pValor, pTipoOperacion) {
    var lcomponentes = pValor.split("|");
    if (lcomponentes.length > 0)
        $("#" + pNombreControl).val(lcomponentes[0]);
    if (pValor == "")
        gUpLoads[pNombreControl] = pTipoOperacion;
    else
        gUpLoads[pNombreControl] = pTipoOperacion + '|' + pValor;

}

function qcom_ObtenerTipoContDownLoad(pEsUrl, pExtension) {
    var ltipocont = "";
    if ((pEsUrl == "false") || (pEsUrl == false)) {
        ltipocont = 'data:application/octet-stream;base64,';
        if ((pExtension == 'jpg') || (pExtension == 'jpeg') ||
            (pExtension == 'png') || (pExtension == 'gif') || (pExtension == 'bmp'))
            ltipocont = 'data:image/' + pExtension + ';base64,';
    }
    return ltipocont;
}


function qcom_AsignarValorFechaEditor(pControl, pValor) {
    if (jQuery.type(pValor) == "string") {
        // El valor de la fecha viene en un string formato ISO 8601: "2009-10-15T14:42:51Z"
        //Reemplazo todo lo que no es digito, por un espacio en blanco
        //Tambien hay casos (por ejemplo cuando el valor está almacenado en una variable), que vienen con el formato 15/01/2019
        var ldtstr = pValor.replace(/\D/g, " ");
        //Hago un split por los espacios en blanco
        var ldtcomponentes = ldtstr.split(" ");
        if (ldtcomponentes[0].length > 2) {
            if (ldtcomponentes[0] != "0001") {
                // modify month between 1 based ISO 8601 and zero based Date
                ldtcomponentes[1]--;
                if (ldtcomponentes.length > 3)
                    var lconvdt = new Date(ldtcomponentes[0], ldtcomponentes[1], ldtcomponentes[2],
                                        ldtcomponentes[3], ldtcomponentes[4], ldtcomponentes[5]);
                else
                    var lconvdt = new Date(ldtcomponentes[0], ldtcomponentes[1], ldtcomponentes[2],
                                        0, 0, 0);

                //var lpepe = new Date(2016, 7, 25);   
                pControl.getControl().igDatePicker("value", lconvdt);
            }
            else {
                pControl.getControl().igDatePicker("value", "");
            }
        }
        else { //si es un string del tipo "15/01/2019"
            if ((ldtcomponentes[2] != "0001") && ((ldtcomponentes[2] != "0002"))) {
                // modify month between 1 based ISO 8601 and zero based Date
                ldtcomponentes[1]--;
                var lconvdt = new Date(ldtcomponentes[2], ldtcomponentes[1], ldtcomponentes[0],
                                       0, 0, 0);
                //var lpepe = new Date(2016, 7, 25);   
                pControl.getControl().igDatePicker("value", lconvdt);
            }
            else {
                pControl.getControl().igDatePicker("value", "");
            }
        }
    }
    else {
        var lAnio = pValor.getFullYear();
        if (lAnio == '0001')
            pControl.getControl().igDatePicker("value", "");
        else
            pControl.getControl().igDatePicker("value", pValor);

    }

}



function qcom_AsignarValorCombo(pControl, pValor) {
    /* AJ JUNIO CON NRO DA ERROR EL TRIM 2017 */
    //if (pControl.getTipoDato() == 2)
    if ($.isNumeric(pValor))
        pControl.getControl().igCombo("value", pValor);
    else {
        if (pValor == null)
            pValor = "";
        pControl.getControl().igCombo("value", pValor.trim());
    }

}

function qcom_AsignaValorCheckBox(pControl, pValor) {
    if (typeof pValor == "string") {
        if (pValor.toLowerCase() == "false")
            pControl.getControl().prop('checked', false);
        else if (pValor.toLowerCase() == "true")
            pControl.getControl().prop('checked', true);
    }
    else
        pControl.getControl().prop('checked', pValor);
}

function qcom_AsignarCantDecimales(pControl, pValor) {
    if ((pValor == null) || (pValor == ""))
        pValor = 0;
    pControl.getControl().igNumericEditor("option", "minDecimals", pValor);
    pControl.getControl().igNumericEditor("option", "maxDecimals", pValor);
}


/****** Pasar valores de Dataset a controles y viceversa *************************/


function qcom_ValorCamposClavesaPrincipal() {
    qcom_InicializarColumnasSegmento(true);
    var lLong = gCamposClaves.length;
    for (var i = 0; i < lLong; i++) {
        var lCampo = gCamposClaves[i];
        gEntidad["Principal"][0][lCampo] = qcom_ObtenerValorControl(gControles["Principal"][0][lCampo]);
    }

    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        //Hay que tratar todos los segmentos 11-08-2018 que estén en tablas planas
        //if (gSegmentos[i].getPrincipal()) {
        //Fin  Hay que tratar todos los segmentos 11-08-2018 que estén en tablas planas
        lSeg = gSegmentos[i];
        //Hay que tratar todos los segmentos 11-08-2018 que estén en tablas planas
        if (qcom_EsTablaPlana(lSeg.getTabla())) {
            //Fin Hay que tratar todos los segmentos 11-08-2018 que estén en tablas planas            
            for (var j = 1; j <= 8; j++) {
                if ((lSeg.getCampoNCCtrlSeg(j) != '') && ((lSeg.getCampoNCCtrl(j) != '')))
                    gEntidad[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)] = qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]);
                else if (lSeg.getCampoNCCtrlSeg(j) != '')
                    gEntidad[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)] = qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]);
            }
        }
    }
    gEntidad["Principal"][0]["Existe"] = false;
}


//function qcom_PrincipalaControles() {
function qcom_TablasPlanasaControles(pTablasARefrescar) {
    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        //Debo verfiicar que los datos de la tabla se tengan que refrescar
        if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lValorTab + "|") !== -1)) {
            $.each(gEntidad[lValorTab][0], function (lClave, lValor) {
                if ((lClave != "Existe") && (lClave != "IDCol")) {
                    if (gControles[lValorTab][0][lClave] != null) {
                        //if ($.inArray(gControles["Principal"][0][lClave].getControl().selector, gControlesClaves) <= -1) {
                        qcom_AsignarValorControl(gControles[lValorTab][0][lClave], lValor, false);
                        //}
                    }
                }
            });
        }
    });

    //Paso los atributos generales a los controles
    qatrib_TablaaControles();

    qcom_AsignarValorCodigoNuevo();
    qcom_LimpiarControlesOcultosSegmento();
    qcom_HabilitarGuardar();
}


function qcom_CampoClaveAsocaSegmento(pCampo) {
    var lretorno = false;
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        lSeg = gSegmentos[i];
        if (lSeg.getPrincipal()) {
            for (var j = 1; (j <= 12) && (!lretorno) ; j++) {
                lretorno = ((lSeg.getCampoCtrl(j) == pCampo) || (lSeg.getCampoCtrlAdic(j) == pCampo));
            }
        }
    }
    return lretorno;
}

function ObtenerSegmentoPrincipal() {
    var lSegPrinc = null;
    var lCantidad = gSegmentos.length;
    for (var i = 0; ((i < lCantidad) && (lSegPrinc == null)) ; i++) {
        lSeg = gSegmentos[i];
        if (lSeg.getPrincipal()) {
            lSegPrinc = lSeg;
        }
    }
    return lSegPrinc;
}

//function qcom_InicializarControlesPrincipal(pInicializarClave) {
function qcom_InicializarForm(pInicializarClave, PrimeraVez/*, ClickNuevo*/) {
    $("#btnLupaAnt").prop("disabled", true);
    $("#btnLupaSig").prop("disabled", (QLupaAdv_Navegador.Primero == ""));
    $("#btnLupaPrim").prop("disabled", true);
    $("#btnLupaUlt").prop("disabled", (QLupaAdv_Navegador.Ultimo == ""));

    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        //Daniel 1-5-2018
        //antes que nada, si no es la primera vez, lo que hago es poner en null todos los campos, para limpiarlos
        if (!PrimeraVez) {
            $.each(gEntidad[lValorTab][0], function (lClave, lValor) {
                gEntidad[lValorTab][0][lClave] = null;
                gEntidadAux[lValorTab][0][lClave] = null;
            })
        }
        //Fin Daniel 1-5-2018
        $.each(gControles[lValorTab][0], function (lClave, lValor) {
            if ((lClave != "Existe") && (lValor != null)) {
                var lControlValor = lValor.getControl();
                //if ((pInicializarClave) || (($.inArray(lClave, gCamposClaves) <= -1) && ($.inArray(lClave, gCamposControlesClavesxAsocSegmento) <= -1))) {
                if (!PrimeraVez) {
                    if (pInicializarClave || (($.inArray(lClave, gCamposClaves) <= -1) && (!qcom_CampoClaveAsocaSegmento(lClave)))) {
                        //qcom_AsignarValorControl(lValor, gValoresPorDef[lValorTab][0][lClave], true);
                        //Solo debo blanquearlo si el click en nuevo blanquea
                        if (/*(!ClickNuevo) ||*/ (lValor.getNuevoBlanquea()))
                            qcom_AsignarValorControl(lValor, lValor.getDefecto(), true);
                    }
                }
                if (lValor.getControlConjunto() != "") {
                    if (lValor.getHabilitado())
                        qcom_HabilitarControl(lValor.getControlConjunto());
                    else
                        qcom_DesHabilitarControl(lValor.getControlConjunto());

                    if (lValor.getVisible() && lValor.getVisibleXPais())
                        qcom_MostrarControl(lValor.getControlConjunto());
                    else
                        qcom_OcultarControl(lValor.getControlConjunto());
                }
            }
        });
    });

    qcom_AsignarValorCodigoNuevo();
    qcom_HabilitarGuardar();
    var lLong = gGrupos.length
    for (var i = 0; i < lLong; i++) {
        if (gGrupos[i].getVisible() && gGrupos[i].getVisibleXPais())
            qcom_MostrarControl(gGrupos[i].getNombreControl());
        else
            qcom_OcultarControl(gGrupos[i].getNombreControl());
    }
    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
        var lNombreTabla = gGrillas[lGrilla].Tabla;
        gGrillas[lGrilla].UltimaPK = 0;
        gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
        //Daniel 1-5-2018
        gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
        //Fin Daniel 1-5-2018
        if (gGrillas[lGrilla].AutoFormateable) {
            qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla], null);
        }
        else if (gGrillas[lGrilla].EsArbol) {
            gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
            gGrillas[lGrilla].Control.igTreeGrid("dataBind");
        }
        else {
            gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
            gGrillas[lGrilla].Control.igGrid("dataBind");
        }


        if (gGrillas[lGrilla].Visible && gGrillas[lGrilla].VisibleXPais)
            qcom_MostrarControl(gGrillas[lGrilla].NombreControl);
        else
            qcom_OcultarControl(gGrillas[lGrilla].NombreControl);

    });


    $.each(gGraficosAux, function (lClave, lValor) {
        var lNombreTabla = gGraficos[lValor].Tabla;
        gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
        gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
        var lNombreControl = gGraficos[lValor].NombreControl;

        graf_MostrarAdicGrafico(lNombreControl, false);
        graf_DestruirGrafico(lNombreControl);

        if (gGraficos[lValor].Visible && gGraficos[lValor].VisibleXPais)
            qcom_MostrarControl(gGraficos[lValor].NombreControl);
        else
            qcom_OcultarControl(gGraficos[lValor].NombreControl);
    });

    $.each(gListasAdjuntosAux, function (lClave, lValor) {
        var lNombreTabla = gListasAdjuntos[lValor].Tabla;
        gEntidad[lNombreTabla].splice(0, gEntidad[lNombreTabla].length);
        gEntidadAux[lNombreTabla].splice(0, gEntidadAux[lNombreTabla].length);
        var lNombreControl = gListasAdjuntos[lValor].NombreControl;

        qlstadj_VaciarLista(lNombreControl);
        gListasAdjuntos[lValor].UltId = 0;

        if (gListasAdjuntos[lValor].Visible && gListasAdjuntos[lValor].VisibleXPais)
            qcom_MostrarControl(lNombreControl);
        else
            qcom_OcultarControl(lNombreControl);
    });



    //Limpio los controles y datatables de los atributos generales, si es que hay atributos generales
    qatrib_InicializarControles();
    //if (pInicializarClave) {
    //    gEsNuevaEntidad = true;
    //    qcom_HabilitarGuardar();
    //}

    if (!PrimeraVez) {
        //debo poner todas las solapas como no activadas y debo activar la solapa de datos
        qcom_InicSolapasActivadas();
        //qcom_mostrarSolapa("Solapa_Datos");
    }



    $('#divPrincipal').removeClass('divPrincipalOculto');
    qevt_EjecutarSiguiente();
}

function qcom_InicSolapasActivadas() {
    var lCantSolapas = gSolapas.length;
    if (lCantSolapas > 0) {
        var lSolDatosActiva = $("#liSolapa_Datos")[0].classList.contains("active");
        for (var i = 0; i < lCantSolapas; i++) {
            gSolapas[i].Activada = false;
            if (!lSolDatosActiva) {
                var lNombre = gSolapas[i].Nombre;
                $("#tab" + lNombre)[0].style.display = "none";
                $("#li" + lNombre)[0].className = $("#li" + lNombre)[0].className.replace(" active", "");
            }
        };
        if (!lSolDatosActiva) {
            $("#tabSolapa_Datos")[0].style.display = "block";
            $("#liSolapa_Datos")[0].className += " active";
        }
    }
}


function qcom_DeshabilitarTodo() {

    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        $.each(gControles[lValorTab][0], function (lClave, lValor) {
            if ((lClave != "Existe") && (lValor != null)) {
                var lControlValor = lValor.getControl();
                if (lValor.getControlConjunto() != "")
                    qcom_DesHabilitarControl(lValor.getControlConjunto());
                else
                    qcom_DesHabilitarControl(lValor.getControl()[0].id);

            }
        });
    });

    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        qcom_DeshabilitarSegmento(gSegmentos[i].getNombre());
    }


    //Tengo que deshabilitar las grillas
    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
        if (gGrillas[lGrilla].EsArbol) {
            gGrillas[lGrilla].Control.igTreeGridUpdating("option", "enableAddRow", false);
            gGrillas[lGrilla].Control.igTreeGridUpdating("option", "enableDeleteRow", false);
            gGrillas[lGrilla].Control.igTreeGridUpdating("option", "editMode", "none");
        }
        else if ((!gGrillas[lGrilla].Editable) && (!gGrillas[lGrilla].AutoFormateable)) {
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableAddRow", false);
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableDeleteRow", false);
            //gGrillas[lGrilla].Control.igGridUpdating("option", "editMode", "none");
            //Debo ocultar el boton de aceptar
            $("#btnAceptar" + lGrilla).hide();
            //Debo poner de solo lectura todos los controles del popup
            $.each(gControles[gGrillas[lGrilla].Tabla][0], function (lClavectrlGrilla, lValorctrlGrilla) {
                if ((lClavectrlGrilla != "Existe") && (lValorctrlGrilla != null)) {
                    //var lControlValor = lValorctrlGrilla.getControl();
                    if (lValorctrlGrilla.getControlConjunto() != "")
                        qcom_DesHabilitarControl(lValorctrlGrilla.getControlConjunto());
                    else
                        qcom_DesHabilitarControl(lValorctrlGrilla.getControl()[0].id);
                }
            });

        }
        else {
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableAddRow", false);
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableDeleteRow", false);
            gGrillas[lGrilla].Control.igGridUpdating("option", "editMode", "none");
        }

        //oculto todos los links
        $("#lbl" + gGrillas[lGrilla].NombreControl + " a:visible").hide();
    });


    //Limpio los controles y datatables de los atributos generales, si es que hay atributos generales
    //qatrib_InicializarControles();
    qevt_EjecutarSiguiente();
}


//function qcom_ControlesaPrincipal() {
function qcom_ControlesaTablasPlanas() {
    qcom_InicializarColumnasSegmento(false);
    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        $.each(gControles[lValorTab][0], function (lClave, lValor) {
            if ((lClave != "Existe") && (lValor != null) && (!qcom_EsControlOcultoSegmento(lValorTab, lClave))) {
                lValorCtr = qcom_ObtenerValorControl(lValor);
                gEntidad[lValorTab][0][lClave] = lValorCtr;
            }
        });
    });
    // Llamo a esto para los controles ocultos de los segmentos
    qcom_ValorCamposClavesaPrincipal();

    //paso los valores de los atributos generales
    qatrib_ControlesaTablas();

    gEntidad["Principal"][0]["Existe"] = false;
}


function qcom_ObtenerDescripcionSegmento(pSegmento) {
    var lRetorno = "";
    var lCantidad = gSegmentos.length;
    var lEncontre = false;
    for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
        if (gSegmentos[i].getNombre() == pSegmento) {
            lSeg = gSegmentos[i];
            lEncontre = true;
            var lSeparador = "";
            var lPosiciones = lSeg.getPosiciones();
            for (var j = 0; j < lPosiciones.length; j++) {
                lRetorno += lSeparador + qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lPosiciones[j]]);
                lSeparador = "-";
            }
        }
    }
    return lRetorno;
}

//Se utiliza para obtener y asignar los valores cuando se recibe como parámetro en una invocación a un form
function qcom_AsignarPartesSegmento(pSegmento, pPartesValores) {
    //var lRetorno = "";
    var lCantidad = gSegmentos.length;
    var lEncontre = false;
    if (pPartesValores != "") {
        //obtengo todas los valores de las partes (vienen en un string separadas por "-"
        var lPartesValores = pPartesValores.split("-");
        var lCantPartes = lPartesValores.length;
        for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
            if (gSegmentos[i].getNombre() == pSegmento) {
                lSeg = gSegmentos[i];
                lEncontre = true;
                //var lSeparador = "";
                var lPosiciones = lSeg.getPosiciones();
                for (var j = 0; (j < lPosiciones.length) && (j < lCantPartes) ; j++) {
                    //lRetorno += lSeparador + qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lPosiciones[j]]);
                    qcom_AsignarValorControl(gControles[lSeg.getTabla()][0][lPosiciones[j]], lPartesValores[j], false);
                    //lSeparador = "-";
                }
            }
        }
    }
}


/************************* Invocaciones via AJAX ************************************/

function qcom_ObtenerEstructuraEntidad(pExito_CallBack) {
    var lIdSes = sessionStorage.getItem("idses");
    $('#divCargando').addClass('show');

    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/ObtenerCommonDSEntidad",
        data: "{'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() +
                "', 'pDllCommonEsp':'" + gFormulario.getDLLCommonEsp() + "', 'pClaseCommonEsp':'" + gFormulario.getClaseCommonEsp() + "', 'pIdSes':'" + lIdSes + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        if (!msg.d[0].startsWith("error:")) {
            //trae dos elementos, el [0] es el dataset standard, el [1] es el de la especializacion
            gEntidad = JSON.parse(msg.d[0]);
            gEntidadAux = JSON.parse(msg.d[0]);
            gEntidadAyuda = JSON.parse(msg.d[0]);

            //if (msg.d[1] != "")
            //    gEntidadEspec = JSON.parse(msg.d[1]);
            gTieneDsEsp = (msg.d[1] == "1");
            if (gControles == null) {
                gControles = JSON.parse(msg.d[0]);
                //if (gValoresPorDef == null) {
                //    gValoresPorDef = JSON.parse(msg.d);
                if (pExito_CallBack != null)
                    pExito_CallBack();
                //}
            }
        }
        else
            qcom_TratarError(msg.d[0]);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
    });
}

function qcom_EjecutarAccion(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, pCodigoConsulta, pTablasARefrescar, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lEntidadAyuda = null;
    //var ldataset = encodeURIComponent(JSON.stringify(gEntidad));
    var lPosLeft = window.pageXOffset;
    var lPosTop = window.pageYOffset;
    pCodigoConsulta = (typeof pCodigoConsulta !== 'undefined') ? pCodigoConsulta : "";
    //if (pTablasAEnviar == '')
    //    var ldataset = JSON.stringify(gEntidad);
    //else
    //{
    //    lEntidadAyuda = qcom_Clonar(gEntidadAyuda);
    //    var lstTablaaEnviar = pTablasAEnviar.split('|');
    //    for (var i = 0; i < lstTablaaEnviar.length; i++) {
    //        lEntidadAyuda[lstTablaaEnviar[i]] = qcom_Clonar(gEntidad[lstTablaaEnviar[i]])
    //    }
    //    var ldataset = JSON.stringify(lEntidadAyuda);
    //}
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);

    var lIdSes = sessionStorage.getItem("idses");

    //var ldatasetesp = '';
    //debo pasar siempre el coomon especializado, porque si es especializada, lo necesita como entrada, y si no es especializada
    //lo necesita antes de volver
    //if (gEntidadEspec != null) 
    //    ldatasetesp = JSON.stringify(gEntidadEspec);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pTieneDsEsp': gTieneDsEsp, 'pDllExchange': gFormulario.getDLLExchange(),
        'pClaseExchange': gFormulario.getClaseExchange(), 'pClaseEnum': gFormulario.getClaseEnum(),
        'pDllCommon': gFormulario.getDLLCommon(), 'pClaseCommon': gFormulario.getClaseCommon(),
        'pDllExchangeEsp': gFormulario.getDLLExchangeEsp(),
        'pClaseExchangeEsp': gFormulario.getClaseExchangeEsp(), 'pClaseEnumEsp': gFormulario.getClaseEnumEsp(),
        'pDllCommonEsp': gFormulario.getDLLCommonEsp(), 'pClaseCommonEsp': gFormulario.getClaseCommonEsp(),
        'pNombreAccion': pNombreAccion, 'pTablasPlanas': gTablasPlanas.join('|'),
        'pFormulario': gConfiguracion.getFormulario(), 'pIdSes': lIdSes, 'pCodigoConsulta': pCodigoConsulta,
        'pAccionEspecializada': pEsEspecializada, 'pTieneTablaAutoFormateable': gTieneGrillasAutoForm
    });
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/Ejecutar",
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDllExchange':'" + gFormulario.getDLLExchange() + "', 'pClaseExchange':'" + gFormulario.getClaseExchange() + "', 'pClaseEnum':'" + gFormulario.getClaseEnum() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreAccion':'" + pNombreAccion + "', 'pTablasPlanas':'" + gTablasPlanas.join('|') + "', 'pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: lData,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            //var lEsEntidadDelForm = gEsEntidadDelForm;
            //gEsEntidadDelForm = false;
            //Proceso el mensajes de consulta
            if (msg.d.startsWith("cons:")) {
                qcom_EjecutarAccion_Mens(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, msg.d, pTablasARefrescar, pTablasAEnviar, pEsEspecializada);
            }
            else if (!msg.d.startsWith("error:")) {
                qcom_HabilitarGuardar();
                //if (pMensajeOK != "") {
                //    qcom_Alerta(pMensajeOK, 'success');
                //}
                ////Si estoy buscando una nueva entidad del form, 
                ////si no existe, debo ocultar los botones de borrar para aqquellos usuarios que no tienen permiso para insertar
                //if (lEsEntidadDelForm)
                //{
                //    gEsNuevaEntidad = (msg.d.startsWith("NoExiste"));
                //    qcom_HabilitarGuardar(); 
                //}

                if (pBlanqueoOK) {
                    qevt_EjecutarSiguiente();
                    //qcom_InicializarForm(true, false, true);
                    qevt_InicializarForm(true, false)
                }
                    //else if (gEntidad["Principal"][0]["Existe"] != false) {
                else if (!msg.d.startsWith("NoExiste")) {

                    //if (pTablasARefrescar == "")
                    //    gEntidad = JSON.parse(msg.d);
                    ////Debo pasar a gEntidad todas menos las que no se actualizan
                    //else {
                    //    lEntidadAyuda = JSON.parse(msg.d);
                    //    var lstTablaaRef = pTablasARefrescar.split('|');
                    //    for (var i = 0; i < lstTablaaRef.length; i++) {
                    //        gEntidad[lstTablaaRef[i]] = qcom_Clonar(lEntidadAyuda[lstTablaaRef[i]])
                    //    }
                    //}

                    gEntidad = qcom_CargarTablasARefrescar(pTablasARefrescar, msg.d, gEntidad);
                    pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                    qcom_TablasPlanasaControles(pTablasARefrescar);

                    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                        var lNombreTabla = gGrillas[lGrilla].Tabla;
                        //Solo debo actualizar las grillas que se deban refrescar
                        if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                            if (gGrillas[lGrilla].AutoFormateable) {
                                qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla], gEntidad[lNombreTabla + 'fmt']);
                            }
                            else if (gGrillas[lGrilla].EsArbol) {
                                //gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                                if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla].length == 0))
                                    gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                                else {
                                    var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                                    var lUltAutonum = gEntidad[lNombreTabla][gEntidad[lNombreTabla].length - 1][lCampoAutoNum];
                                    gGrillas[lGrilla].UltimaPK = lUltAutonum;
                                }


                                //$("#grdPermisos").igTreeGrid("option", "dataSourceType", "array");
                                //$("#grdPermisos").igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                //$("#grdPermisos").igTreeGrid("dataBind");
                                gGrillas[lGrilla].Control.igTreeGrid("option", "dataSourceType", "array");
                                gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                gGrillas[lGrilla].Control.igTreeGrid("dataBind");
                                qgrillas_ColapsarArbol(lGrilla);
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
                                gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                gGrillas[lGrilla].Control.igGrid("dataBind");
                            }
                        }
                    });

                    $.each(gGraficosAux, function (lClave, lValor) {
                        var lNombreControl = gGraficos[lValor].NombreControl;
                        graf_MostrarAdicGrafico(lNombreControl, false);
                        graf_DestruirGrafico(lNombreControl);
                    });


                    $.each(gListasAdjuntosAux, function (lClave, lValor) {
                        var lNombreTabla = gListasAdjuntos[lValor].Tabla;
                        //Solo debo actualizar las tablas que se deban refrescar
                        if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                            var lNombreControl = gListasAdjuntos[lValor].NombreControl;
                            qlstadj_VaciarLista(lNombreControl);
                            for (var l = 0; l < gEntidad[lNombreTabla].length; l++) {
                                if (gEntidad[lNombreTabla][l].Estado != gEstadoAdjunto["Borrado"]) {
                                    qlstadj_AgregarVistaAdjunto(lNombreControl, l, l);
                                }
                            }
                            gListasAdjuntos[lValor].UltId = gEntidad[lNombreTabla].length;
                        }
                    });

                    qgrdpvt_DestruirGrdPvt();

                    document.documentElement.scrollTop = lPosTop;
                    document.documentElement.scrollLeft = lPosLeft;
                    document.body.scrollTop = lPosTop;
                    document.body.scrollLeft = lPosLeft;

                    qevt_EjecutarSiguiente();
                    //Daniel Fin
                }
                else if (pBlanqueoNotOK) {
                    //Daniel
                    qevt_VaciarEventosTmp();
                    //Daniel Fin
                    //qcom_InicializarForm(false, false, false);
                    qevt_InicializarForm(false, false);
                    //Daniel
                    if (pFnNoExiste != null) {
                        qevt_AgregarEventoaTmp(pFnNoExiste, null, true);
                    }
                    //Daniel Fin
                }
                else {
                    qevt_EjecutarSiguiente();
                }
                if (pMensajeOK != "") {
                    qcom_MensajeExito(pMensajeOK);
                }

            }
            else
                qcom_TratarError(msg.d);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            // aj dic 2016
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseText, 'danger', null);

        });
}

function qcom_EjecutarAccion_Mens(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, pMensajeConsulta, pTablasAModificar, pTablasAEnviar, pEsEspecializada) {

    var lcomponentes = pMensajeConsulta.substring(5).split("|");
    qcom_Confirmar(lcomponentes[1], 'warning',
        function () { qcom_EjecutarAccion(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, lcomponentes[0], pTablasAModificar, pTablasAEnviar, pEsEspecializada) },
          function () { qevt_VaciarEventosTmp(); }
    )
}

function qcom_EjecutarCondicion(pNombreCondicion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pDllEventos': gFormulario.getDLLEventos(), 'pClaseEventos': gFormulario.getClaseEventos(), 'pDllCommon': gFormulario.getDLLCommon(), 'pClaseCommon': gFormulario.getClaseCommon(),
        'pDllEventosEsp': gFormulario.getDLLEventosEsp(), 'pClaseEventosEsp': gFormulario.getClaseEventosEsp(), 'pDllCommonEsp': gFormulario.getDLLCommonEsp(), 'pClaseCommonEsp': gFormulario.getClaseCommonEsp(),
        'pTieneDSEsp': gTieneDsEsp, 'pEsEspecializada': pEsEspecializada, 'pTieneTablaAutoFormateable': gTieneGrillasAutoForm,
        'pNombreCondicion': pNombreCondicion, 'pFormulario': gConfiguracion.getFormulario(), 'pIdSes': lIdSes
    });
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/EjecutarCondicion",
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreCondicion':'" + pNombreCondicion + "','pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: lData,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (!msg.d.startsWith("error:")) {
                //var lValorCond = JSON.parse(msg.d);
                var lValorCond = msg.d;
                qevt_EliminarNodosCond(lValorCond);
                qevt_EjecutarSiguiente();

            }
            else
                qcom_TratarError(msg.d);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
        });
}



function qcom_MostrarReporteConParamDesdeServer(pMetodoParam, pMetodoNombre, pTablasAEnviar, pEsEspecializada, pNombreReporte, pMetodoDatos) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pDllEventos': gFormulario.getDLLEventos(), 'pClaseEventos': gFormulario.getClaseEventos(), 'pDllCommon': gFormulario.getDLLCommon(), 'pClaseCommon': gFormulario.getClaseCommon(),
        'pDllEventosEsp': gFormulario.getDLLEventosEsp(), 'pClaseEventosEsp': gFormulario.getClaseEventosEsp(), 'pDllCommonEsp': gFormulario.getDLLCommonEsp(), 'pClaseCommonEsp': gFormulario.getClaseCommonEsp(),
        'pTieneDSEsp': gTieneDsEsp, 'pEsEspecializada': pEsEspecializada, 'pTieneTablaAutoFormateable': gTieneGrillasAutoForm,
        'pMetodoParametros': pMetodoParam, 'pMetodoNombreReporte': pMetodoNombre, 'pFormulario': gConfiguracion.getFormulario(), 'pIdSes': lIdSes
    });
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/EjecutarParamReporte",
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreCondicion':'" + pNombreCondicion + "','pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: lData,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (!msg.d.startsWith("error:")) {
                //var lValorCond = JSON.parse(msg.d);
                var lParRpt = msg.d;
                var lNombreRpt = msg.m;
                if (pMetodoParam == "")
                    lParRpt = qcom_ObtenerParametrosReporte();
                if (pMetodoNombre == "")
                    lNombreRpt = pNombreReporte;
                qcom_MostrarReporte(lNombreRpt, lParRpt, pMetodoDatos);
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.d);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
        });
}




function qcom_EjecutarDescargaArchivoGeneral(pData, pFuncionCallBack) {
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/EjecutarDescargaArchivo",
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreCondicion':'" + pNombreCondicion + "','pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: pData,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (!msg.d.startsWith("error:")) {
                //si es download
                var lDatosDownLoad = JSON.parse(msg.d);
                var ltipocont = qcom_ObtenerTipoContDownLoad(lDatosDownLoad.Principal[0].EsURL, lDatosDownLoad.Principal[0].Extension);

                var elem = window.document.createElement('a');
                elem.id = "reftemporal";
                elem.href = ltipocont + lDatosDownLoad.Principal[0].Archivo;
                elem.download = lDatosDownLoad.Principal[0].NombreArchivoDescargado;
                document.body.appendChild(elem);
                //solo paso el nombre "temporal" porque el método le agrega el href, porque se utiliza tambien con los controles con campos asociados
                qcom_DescargarArchivo("temporal")
                document.body.removeChild(elem);
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.d);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
        });
}

function qcom_EjecutarDescargaArchivo(pNombreAccion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {

    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pDllEventos': gFormulario.getDLLEventos(), 'pClaseEventos': gFormulario.getClaseEventos(), 'pDllCommon': gFormulario.getDLLCommon(), 'pClaseCommon': gFormulario.getClaseCommon(),
        'pDllEventosEsp': gFormulario.getDLLEventosEsp(), 'pClaseEventosEsp': gFormulario.getClaseEventosEsp(), 'pDllCommonEsp': gFormulario.getDLLCommonEsp(), 'pClaseCommonEsp': gFormulario.getClaseCommonEsp(),
        'pTieneDSEsp': gTieneDsEsp, 'pEsEspecializada': pEsEspecializada, 'pTieneTablaAutoFormateable': gTieneGrillasAutoForm,
        'pNombreAccion': pNombreAccion, 'pFormulario': gConfiguracion.getFormulario(), 'pIdSes': lIdSes
    });
    qcom_EjecutarDescargaArchivoGeneral(lData, pFuncionCallBack)
}

function qcom_GeneraryDescargaXLS(pNombreReporte, pParametros) {
    var lIdSes = sessionStorage.getItem("idses");
    var lEntidadRep = { Principal: [] };
    lEntidadRep.Principal = [{ ArchivoXLS: '', Existe: false, NombreArchivoXLS: '', NombreReporte: pNombreReporte, Parametros: pParametros }];
    var ldataset = JSON.stringify(lEntidadRep);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pDllEventos': 'MiscelaneosFEEventos', 'pClaseEventos': 'MiscelaneosFEEventos.misReporteAXLS', 'pDllCommon': 'MiscelaneosCommon', 'pClaseCommon': 'MiscelaneosCommon.misReporteAXLSDS',
        'pDllEventosEsp': '', 'pClaseEventosEsp': '', 'pDllCommonEsp': '', 'pClaseCommonEsp': '',
        'pTieneDSEsp': false, 'pEsEspecializada': false, 'pTieneTablaAutoFormateable': gTieneGrillasAutoForm,
        'pNombreAccion': 'ReporteAXLS', 'pFormulario': '', 'pIdSes': lIdSes
    });
    qcom_EjecutarDescargaArchivoGeneral(lData, null)
}



function qcom_EjecutarMostrarPDFEspecialGral(pData, pFuncionCallBack) {
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/EjecutarDescargaArchivo",
        //data: "{'pDsEntidad':'" + ldataset + "', 'pDllEventos':'" + gFormulario.getDLLEventos() + "', 'pClaseEventos':'" + gFormulario.getClaseEventos() + "', 'pDllCommon':'" + gFormulario.getDLLCommon() + "', 'pClaseCommon':'" + gFormulario.getClaseCommon() + "', 'pNombreCondicion':'" + pNombreCondicion + "','pFormulario':'" + gConfiguracion.getFormulario() + "'}",
        data: pData,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (!msg.d.startsWith("error:")) {
                var lDatosPDF = JSON.parse(msg.d);
                var pdfWindow = window.open("")
                //pdfWindow.document.write("<iframe width='100%' height='100%' src='data:application/pdf;base64, " + encodeURI(lDatosPDF.Principal[0].Archivo) + "'></iframe>")
                pdfWindow.document.write("<html><head><title>" + lDatosPDF.Principal[0].Titulo + "</title></head><body><iframe title='QuasarGlobal' width='100%' height='100%' src='data:application/pdf;base64, " + encodeURI(lDatosPDF.Principal[0].Archivo) + "'></iframe></body></html>")
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.d);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(xhr.responseJSON.Message, 'danger', null);
        });
}


function qcom_EjecutarMostrarPDFEspecial(pNombreAccion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {

    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = JSON.stringify({
        'pDsEntidad': ldataset, 'pDllEventos': gFormulario.getDLLEventos(), 'pClaseEventos': gFormulario.getClaseEventos(), 'pDllCommon': gFormulario.getDLLCommon(), 'pClaseCommon': gFormulario.getClaseCommon(),
        'pDllEventosEsp': gFormulario.getDLLEventosEsp(), 'pClaseEventosEsp': gFormulario.getClaseEventosEsp(), 'pDllCommonEsp': gFormulario.getDLLCommonEsp(), 'pClaseCommonEsp': gFormulario.getClaseCommonEsp(),
        'pTieneDSEsp': gTieneDsEsp, 'pEsEspecializada': pEsEspecializada,
        'pNombreAccion': pNombreAccion, 'pFormulario': gConfiguracion.getFormulario(), 'pIdSes': lIdSes
    });
    qcom_EjecutarMostrarPDFEspecialGral(lData, pFuncionCallBack)
}


function qcom_ObtenerDatosComboGrilla(pIdEntidad, pFnCB) {
    QLupaAdv_CamposRet = null;
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    $.ajax({
        type: "POST",
        url: "QComboAdvDatos.ashx",
        data: { Identidad: pIdEntidad, IdSes: lIdSes },
        dataType: "json"
    })
    .done(function (response) {
        $('#divCargando').removeClass('show');
        pFnCB(response);
    })

    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        qcom_Alerta(thrownError, 'danger', null);
    });
}



//-----------------Segemento-------------------------------------------------------
function qcom_ObtenerSegmento(pNombre) {
    var lRetorno = null;
    var lEncontre = false;
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
        if (gSegmentos[i].getNombre() == pNombre) {
            lRetorno = gSegmentos[i];
            lEncontre = true;
        }
    }

    if (!lEncontre) {
        gSegmentos[lCantidad] = new qcom_segmento(pNombre);
        lRetorno = gSegmentos[lCantidad];
    }
    return lRetorno;
}

function qcom_EsTablaPlana(pTabla) {
    var lesplana = false;
    var lCantidad = gTablasPlanas.length;
    for (var i = 0; (i < lCantidad) && (!lesplana) ; i++) {
        lesplana = (gTablasPlanas[i] == pTabla);
    }
    return lesplana;
}

//function qcom_EsTablaGrilla(pTabla) {
//    var lesGrilla = false;
//    $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
//        var lNombreTabla = gGrillas[lGrilla].Tabla;
//        if (pTabla = lNombreTabla) {
//            lesGrilla = true;
//            //break;
//        }
//    })
//    return lesGrilla;
//}


function qcom_InicializarColumnasSegmento(pSoloPrincipal) {
    var lCantidad = gSegmentos.length;
    for (var indx = 0; indx < lCantidad; indx++) {
        if ((!pSoloPrincipal) || (gSegmentos[indx].getPrincipal())) {
            lSufijo = gSegmentos[indx].getSufijo();
            lTabla = gSegmentos[indx].getTabla();
            if (qcom_EsTablaPlana(lTabla)) {
                if (gEntidad[lTabla].length > 0) {
                    gEntidad[lTabla][0]['Segmento_Id' + lSufijo] = gSegmentos[indx].getIdSeg();
                    gEntidad[lTabla][0]['Segmento1N' + lSufijo] = 0;
                    gEntidad[lTabla][0]['Segmento2N' + lSufijo] = 0;
                    gEntidad[lTabla][0]['Segmento3N' + lSufijo] = 0;
                    gEntidad[lTabla][0]['Segmento4N' + lSufijo] = 0;
                    gEntidad[lTabla][0]['Segmento1C' + lSufijo] = '';
                    gEntidad[lTabla][0]['Segmento2C' + lSufijo] = '';
                    gEntidad[lTabla][0]['Segmento3C' + lSufijo] = '';
                    gEntidad[lTabla][0]['Segmento4C' + lSufijo] = '';
                }
            }
        }
    }
}

function qcom_InicializarColumnasSegmentoFila(pTabla, pValores) {
    var lCantidad = gSegmentos.length;
    for (var indx = 0; indx < lCantidad; indx++) {
        lTabla = gSegmentos[indx].getTabla();
        if (lTabla == pTabla) {
            lSufijo = gSegmentos[indx].getSufijo();
            pValores['Segmento_Id' + lSufijo] = gSegmentos[indx].getIdSeg();
            pValores['Segmento1N' + lSufijo] = 0;
            pValores['Segmento2N' + lSufijo] = 0;
            pValores['Segmento3N' + lSufijo] = 0;
            pValores['Segmento4N' + lSufijo] = 0;
            pValores['Segmento1C' + lSufijo] = '';
            pValores['Segmento2C' + lSufijo] = '';
            pValores['Segmento3C' + lSufijo] = '';
            pValores['Segmento4C' + lSufijo] = '';
        }
    }
}

function qcom_CargoOcultosSegmentoFila(pTabla, pValores) {
    var lCantidad = gSegmentos.length;
    for (var indx = 0; indx < lCantidad; indx++) {
        var lSeg = gSegmentos[indx];
        lTabla = lSeg.getTabla();
        if (lTabla == pTabla) {
            for (var j = 1; j <= 8; j++) {
                if ((lSeg.getCampoNCCtrlSeg(j) != '') && ((lSeg.getCampoNCCtrl(j) != '')))
                    pValores[lSeg.getCampoNCCtrlSeg(j)] = qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]);
                else if (lSeg.getCampoNCCtrlSeg(j) != '')
                    pValores[lSeg.getCampoNCCtrlSeg(j)] = qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]);
            }
        }
    }
}

function qcom_EsControlOcultoSegmento(pTabla, pCampo) {
    var lretorno = false;
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        lSeg = gSegmentos[i];
        if (lSeg.getTabla() == pTabla) {
            //for (j = 1; (j <= 11) && (!lretorno) ; j++) {
            //    lretorno = ((lSeg.getCampoCtrl(j) != '') && (lSeg.getCampoCtrlSeg(j) == pCampo))
            //}
            for (var j = 1; (j <= 8) && (!lretorno) ; j++) {
                lretorno = ((lSeg.getCampoNCCtrl(j) != '') && (lSeg.getCampoNCCtrlSeg(j) == pCampo))
            }

        }
    }
    return lretorno;
}

function qcom_SegmentoCompleto(pNombreSegmento) {
    var lretorno = true;
    var lSeg = qcom_ObtenerSegmento(pNombreSegmento);

    for (var j = 1; (j <= 8) && lretorno ; j++) {
        if (lSeg.getCampoNCCtrl(j) != "")
            lretorno = ((qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]) != "") &&
                        (qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]) != 0));
            //si es a pantalla y el j>4 (son los C1,C2,C3,C4), no tendría que controlarlo
        else if ((lSeg.getCampoNCCtrlSeg(j) != "") && ((lSeg.getCampoCtrlSeg(1) != lSeg.getCampoNCCtrlSeg(j)) || (j < 5)))
            lretorno = ((qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != "") &&
                        (qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != 0));
    }

    return lretorno;
}


function qcom_LimpiarControlesOcultosSegmento() {
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) ; i++) {
        lSeg = gSegmentos[i];
        for (var j = 1; j <= 8; j++) {
            if ((lSeg.getCampoNCCtrl(j) != '') && (lSeg.getCampoNCCtrlSeg(j) != ''))
                qcom_AsignarValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)], null, false);
        }

    }
}


function qcom_AsignarValorCodigoNuevo() {
    if ((gCampoCodigoNuevo != '') && (gCamposClaves.length > 0)) {
        var lValorAAsig = qcom_ObtenerValorControl(gControles["Principal"][0][gCamposClaves[0]]);
        qcom_AsignarValorControl(gControles["Principal"][0][gCampoCodigoNuevo], lValorAAsig, false);
    }
}

/*****************Columnas Grilla***************************************/
function qcom_BlanquearAdicionalesLupaGrilla(pGrilla, pColumnas) {
    if (pColumnas != "") {
        var lColumnas = pColumnas.split("|");
        for (var j = 0; j < lColumnas.length; j++) {
            qcom_AsignarValorColumnaGrilla(pGrilla, lColumnas[j], "");
        }
    }

}

function qcom_AsignarValorColumnaGrilla(pGrilla, pColumna, pValor) {
    var lEditorCodigo = pGrilla.igGridUpdating("editorForKey", pColumna);
    // AJ MAY 2017
    if (lEditorCodigo == undefined)
        return;

    var lcol = pGrilla.igGrid("columnByKey", pColumna);
    switch (lcol.dataType) {
        case "date":
            lEditorCodigo.igDatePicker("option", "value", pValor);
            break;
        case "number":
            lEditorCodigo.igNumericEditor("option", "value", pValor);
            break;
        default: lEditorCodigo.igTextEditor("option", "value", pValor);
            break;
    }

}


/**************** Menu y Cambios de Estados ****************************************/
function qcom_GuardarEntidad(pPostear, pFuncionCallBack) {
    if (typeof pFuncionCallBack == 'function') {
        //if (typeof guardarEntidad == 'function') { 
        //qcom_Confirmar('Está por registrar los cambios, ¿continúa?', 'warning',
        //    function () {
        gEntidad["Principal"][0].Posteado = pPostear;
        //guardarEntidad();
        $("#Procesando").show();
        pFuncionCallBack();
        $("#Procesando").hide();
        //});
    }
    else
        qcom_Alerta(qrecNo_Implmentado, 'info', null);
}



function qcom_EliminarEntidad(pFuncionCallBack) {
    if (typeof pFuncionCallBack == 'function') {
        //if (typeof eliminarEntidad == 'function') {
        //if (confirm('Está por eliminar la entidad, ¿continúa?')) {
        qcom_Confirmar(qrecConfBorrado, 'warning',
            function () {
                //eliminarEntidad();
                $("#Procesando").show();
                pFuncionCallBack();
                $("#Procesando").hide();
            }, null)
    }
    else
        //alert('No Implmentado')
        qcom_Alerta(qrecNo_Implmentado, 'info', null);
}

function qcom_ImprimirEntidad(pFuncionCallBack) {
    if (typeof pFuncionCallBack == 'function') {
        $("#Procesando").show();
        pFuncionCallBack();
        $("#Procesando").hide();
    }
    else
        //alert('no disponible en este formulario');
        qcom_Alerta(qrecNo_Implmentado, 'info', null);
}


function ConsultaxCambiosSinGuardar() {
    var lRetorno = false
    if (gTieneSinGuardar)
        if ((!$('#btnPostear').hasClass('hidden')) || (!$('#btnPostear').hasClass('hidden')))
            lRetorno = true;
    return lRetorno;
}

function SesionValida() {
    return gSesionValida;
}


function qcom_NuevaEntidad() {
    //if (gTieneSinGuardar)
    if (ConsultaxCambiosSinGuardar()) {
        qcom_Confirmar(qrefConfPerderCambios, 'warning',
                    function () {
                        gEntidad["Principal"][0].Posteado = false;
                        gTieneSinGuardar = false;
                        //qcom_InicializarForm(true, false, true);
                        qevt_InicializarForm(true, false);
                    }, null);
    }
    else {
        gEntidad["Principal"][0].Posteado = false;
        gTieneSinGuardar = false;
        //qcom_InicializarForm(true, false, true);
        qevt_InicializarForm(true, false);
    }
}

function qcom_HabilitarGuardar() {
    if (gFormulario.getPostear() && (gFormulario.getUsuarioModif()) &&
        (!gEntidad["Principal"][0].Posteado)) {
        $('#btnGuardar').show();
        $('#btnGuardarF').show();
    }
    else {
        $('#btnGuardar').hide();
        $('#btnGuardarF').hide();
    }
    if (gFormulario.getPostear() && (gFormulario.getUsuarioPostear())) {
        $('#btnPostear').show();
        $('#btnPostearF').show();
    }
    else {
        $('#btnPostear').hide();
        $('#btnPostearF').hide();
    }

}



function qcom_blanquearCambiosSinGuardar() {
    gTieneSinGuardar = false;
    qevt_EjecutarSiguiente();
}


function qcom_verificoEntidadEmpresa() {
    //si la entidad no tiene asociada la empresa en la cual estoy logueado debo deshabilitar todos los botones, excepto el de nuevo
    var lTodoOK = true;
    if ((gEntidad["Principal"][0]["Empresa_Id"] != undefined) &&
        (gEntidad["Principal"][0]["Empresa_Id"] != "undefined")) {
        if ((gEntidad["Principal"][0]["Empresa_Id"] == null) || (gEntidad["Principal"][0]["Empresa_Id"] == 0))
            lTodoOK = true;
        else if (gConfiguracion.getEmpresa() != (gEntidad["Principal"][0]["Empresa_Id"])) {
            if (gConfiguracion.getFormulario().indexOf('genEmpresas') < 0)
                lTodoOK = false;
            else if ((gEntidad["Principal"][0]["genEmpresas"] != undefined) &&
                    (gEntidad["Principal"][0]["genEmpresas"] != "undefined")) {
                if ((gEntidad["Principal"][0]["genEmpresas"] == null) || (gEntidad["Principal"][0]["genEmpresas"] == 0))
                    lTodoOK = true;
                else if (gConfiguracion.getEmpresa() != (gEntidad["Principal"][0]["genEmpresas"]))
                    lTodoOK = false;
            }
        }
    }

    if (lTodoOK) {
        qcom_HabilitarGuardar();
        if (gFormulario.getBorrar() && (gFormulario.getUsuarioBorrar())) {
            $('#btnEliminar').show();
            $('#btnEliminarF').show();
        }
    }
    else {
        $('#btnGuardar').hide();
        $('#btnGuardarF').hide();
        $('#btnPostear').hide();
        $('#btnPostearF').hide();
        $('#btnEliminar').hide();
        $('#btnEliminarF').hide();

    }
    qevt_EjecutarSiguiente();
}



/************* Acciones Simples *******************************************************/

function qcom_HabilitarControl(pControlName) {
    qcom_AccionSobreControl(pControlName, "E");
}

function qcom_DesHabilitarControl(pControlName) {
    qcom_AccionSobreControl(pControlName, "D");
}

function qcom_ObtenerValorParametroFiltro(pValor) {
    //Si el primer caracter es una llave, entonces se trata de una variable de sesion
    if (pValor.charAt(0) == '{') {
        pValor = gConfiguracion.getValorVariable(pValor);
    }
        // si eempieza con var_, se trata de una variable jasvacript
    else if (pValor.startsWith("[var_")) {
        var lvar = pValor.substring(1, pValor.length - 1);
        pValor = gVariables[lvar];
    }
        // si el primer caracter es un [, entonces se trata de un valor contenido en un control
    else if (pValor.charAt(0) == '[') {
        var lCompTablaCol = pValor.substring(1, pValor.length - 1).split(":");
        lTabla = lCompTablaCol[0];
        lColumna = lCompTablaCol[1];
        if (lColumna != undefined)
            pValor = qcom_ObtenerValorControl(gControles[lTabla][0][lColumna]);
        else {
            var lCompSegmento = pValor.substring(1, pValor.length - 2).split("[");
            lSegmento = lCompSegmento[0];
            lParte = lCompSegmento[1];
            if (lParte != undefined)
                pValor = qcom_ObtenerValorParteSeg(lSegmento, lParte);
            else
                //se trata de un parametro, no tiene tabla asociada
                pValor = $("#" + lTabla).igTextEditor()[0].value;
        }
    }
    /*else if ((pValor.charAt(0) == '(') && (pGrilla != null)) {
        var lColumna = pValor.substring(1, pValor.length - 1);
        //var lEditorCodigo = pGrilla.igGridUpdating("editorForKey", lColumna);
        //pValor = lEditorCodigo.igTextEditor("option", "value");
        pValor = qcom_ObtenerValorColumnaByKey(pGrilla[0].id, lColumna);

    }*/
    return pValor;
}


function qcom_AccionSobreControl(pControlName, pAccion) {
    var lcontrol = "#" + pControlName;
    //(lcontrol).hide();
    var lcontrollbl = "";
    if (qcom_existeControl(lcontrol)) {
        qcom_AccionSobreControlAux(lcontrol, pAccion);
        lcontrollbl = "#" + 'lbl' + pControlName;
    }
    else {
        //Si es una lupa
        lcontrol = "#" + pControlName + "_1";
        lcontrolDesc = "#" + pControlName + "_d";
        lcontrollbl = "#" + 'lbl' + pControlName + "_1";
        lcontrolbtn = '#btn_' + pControlName;
        if (qcom_existeControl(lcontrol))
            qcom_AccionSobreControlAux(lcontrol, pAccion);
        if (qcom_existeControl(lcontrolDesc))
            qcom_AccionSobreControlAux(lcontrolDesc, pAccion);
        if (qcom_existeControl(lcontrolbtn))
            qcom_AccionSobreControlAux(lcontrolbtn, pAccion);

    }
    //Si hay un label asociado, lo oculto
    if (qcom_existeControl(lcontrollbl))
        qcom_AccionSobreControlAux(lcontrollbl, pAccion);
}


function qcom_AccionSobreControlAux(pControlName, pAccion) {
    if (pAccion == "H")
        $(pControlName).hide();
    else if (pAccion == "S")
        $(pControlName).show();
    else if (pAccion == "D") {
        //if (pTieneBtnSeleccion)
        //$(pControlName).igTextEditor("option", "disabled", true);
        //    $(pControlName).igTextEditor("hideDropDown");
        //$(pControlName).prop("disabled", true);
        if ($(pControlName).hasClass("quasar-editortexto")) {
            $(pControlName).igTextEditor("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if ($(pControlName).hasClass("quasar-editornumerico")) {
            $(pControlName).igNumericEditor("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if ($(pControlName).hasClass("quasar-editorporcentaje")) {
            $(pControlName).igPercentEditor("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }

        else if ($(pControlName).hasClass("quasar-editorfecha")) {
            $(pControlName).igDatePicker("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if ($(pControlName).hasClass("quasar-editorcombo")) {
            $(pControlName).igCombo("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }

        else
            $(pControlName).prop("disabled", true);
    }
    else if (pAccion == "E") {
        //if (pTieneBtnSeleccion)
        //    $(pControlName).igTextEditor("option", "disabled", false);
        //else
        //    $(pControlName).prop("disabled", false);
        if (!gSL) {
            if ($(pControlName).hasClass("quasar-editortexto")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                if ($(pControlName).igTextEditor("option", "readOnly")) {
                    $(pControlName).igTextEditor("option", "readOnly", false);
                    $(pControlName).igTextEditor("option", "disabled", false);
                    $(pControlName).igTextEditor("option", "readOnly", true);
                }
                else
                    $(pControlName).igTextEditor("option", "disabled", false);
            }
            else if ($(pControlName).hasClass("quasar-editornumerico")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igNumericEditor("option", "disabled", false);
            }
            else if ($(pControlName).hasClass("quasar-editorporcentaje")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igPercentEditor("option", "disabled", false);
            }

            else if ($(pControlName).hasClass("quasar-editorfecha")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igDatePicker("option", "disabled", false);
            }
            else if ($(pControlName).hasClass("quasar-editorcombo")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igCombo("option", "disabled", false);
            }

            else
                $(pControlName).prop("disabled", false);
        }
    }
}

function qcom_OcultarControl(pControlName) {
    qcom_AccionSobreControl("div" + pControlName, "H");
}

function qcom_OcultarSolapa(pControlName) {
    $("#li" + pControlName).hide();
    //<li><a id="liSolapa_2" href="javascript:void(0)" class="tablinks">Solapa_2</a></li>
}

function qcom_MostrarSolapa(pControlName) {
    $("#li" + pControlName).show();
    //<li><a id="liSolapa_2" href="javascript:void(0)" class="tablinks">Solapa_2</a></li>
}

function qcom_MostrarControl(pControlName) {
    var lVisibleXPais = "true";
    if ($("#div" + pControlName)[0].hasAttribute("VisiblexPais"))
        lVisibleXPais = $("#div" + pControlName)[0].getAttribute("VisiblexPais");
    if (lVisibleXPais == "true")
        qcom_AccionSobreControl("div" + pControlName, "S");
}

function qcom_ObtenerValorParteSeg(pNombreSeg, pOrigen) {
    var lNombreCampo = '';
    var lSegmento = qcom_ObtenerSegmento(pNombreSeg);
    if (!(jQuery.type(pOrigen) === "number")) {
        pOrigen = gOrigenesSeg[pOrigen];
    }

    if (lSegmento.getCampoCtrl(pOrigen) != '')
        lNombreCampo = lSegmento.getCampoCtrl(pOrigen);
    else
        lNombreCampo = lSegmento.getCampoCtrlSeg(pOrigen);
    return qcom_ObtenerValorControl(gControles[lSegmento.getTabla()][0][lNombreCampo]);
}

function qcom_SetearValorParteSeg(pNombreSeg, pOrigen, pValor) {
    var lNombreCampo = '';
    var lSegmento = qcom_ObtenerSegmento(pNombreSeg);
    if (lSegmento.getCampoCtrl(pOrigen) != '')
        lNombreCampo = lSegmento.getCampoCtrl(pOrigen);
    else
        lNombreCampo = lSegmento.getCampoCtrlSeg(pOrigen);
    qcom_AsignarValorControl(gControles[lSegmento.getTabla()][0][lNombreCampo], pValor, false);
}
/**********************FECHAS*************************************/
//Todavia sin uso
//function qcom_stringaFecha(pFecha) {
//    l_Fecha = new Date();
//    l_Fecha_str = pFecha.split('/');
//    anio = parseInt(l_Fecha_str[2], 10);
//    mes = parseInt(l_Fecha_str[1], 10) - 1;
//    dia = parseInt(l_Fecha_str[0], 10);
//    l_Fecha.setFullYear(anio, mes, dia);
//    l_Fecha.setHours(0, 0, 0, 0);
//    return l_Fecha;
//}

function qcom_existeControl(pControlName) {
    if ($(pControlName).length)
        return true;
    else
        return false;
}
/******** Parametros para Impresion ********/
function qcom_ObtenerParametrosImpresion(pNombreSegmento) {
    lretorno = '';
    lseparador = '';
    var lSeg = null;
    if (pNombreSegmento != '') {
        var lEncontre = false;
        var lCantidad = gSegmentos.length;
        for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
            if (gSegmentos[i].getNombre() == pNombreSegmento) {
                lSeg = gSegmentos[i];
                lEncontre = true;
            }
        }
    }

    if (lSeg != null) {
        lretorno += "Segmento_Id" + "|" + lSeg.getIdSeg();
        lseparador = '@';

        for (var j = 1; j <= 8; j++) {
            if ((lSeg.getCampoNCCtrlSeg(j) != '') && ((lSeg.getCampoNCCtrl(j) != ''))) {
                var lValor = qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]);
                //lretorno += lseparador + lSeg.getCampoNCCtrlSeg(j) + '|' + lValor;
                //le quito el sufijo
                lretorno += lseparador + lSeg.getCampoNCCtrlSeg(j).substring(0, lSeg.getCampoNCCtrlSeg(j).length - lSeg.getSufijo().length) + '|' + lValor;
                lretorno += lseparador + lSeg.getCampoNCCtrl(j) + '|' + lValor;
            }
            else if (lSeg.getCampoNCCtrlSeg(j) != '')
                //lretorno += lseparador + lSeg.getCampoNCCtrlSeg(j) + '|' + qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]);
                lretorno += lseparador + lSeg.getCampoNCCtrlSeg(j).substring(0, lSeg.getCampoNCCtrlSeg(j).length - lSeg.getSufijo().length) +
                                         '|' + qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]);
            lseparador = '@';
        }
    }
    else {
        for (var i = 0; i < gCamposClaves.length; i++) {
            //por cada cmapo de la clave, debo buscar cual es el nombre del campo de la tabla, y el valor almacenado en el control
            //var lControlValor = gControles["Principal"][0][gCamposClaves[i]].split(", ");
            lretorno += lseparador + gCamposClaves[i] + '|' + qcom_ObtenerValorControl(gControles["Principal"][0][gCamposClaves[i]]);
            lseparador = '@';
        }
    }
    return lretorno;
}

function qcom_MostrarImpresion(pTipo, pParametros) {
    $.ajax({
        type: "POST",
        url: "QEncriptar.ashx",
        data: { Valor: pParametros },
        dataType: "text"
    })
    .done(function (response) {
        lparamEncriptado = response;
        var lIdSes = sessionStorage.getItem("idses");
        smUrl = 'WebFrmPDF.aspx?Par=' + lparamEncriptado + '&tipo=' + pTipo + '&pref=' + lIdSes;
        smArg = 'ImpresionPDF' + lparamEncriptado;
        smFtr = 'toolbar=yes,scrollbars=yes,resizable=yes,top=20,left=20,width=400,height=600';
        window.open(smUrl, smArg, smFtr);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        //alert(xhr.status);
        qcom_MensajeError(thrownError);
    });

}


/******** Parametros para Reporte ********/
function qcom_ObtenerParametrosReporte() {
    lretorno = '';
    lseparador = '';

    var lSeg = ObtenerSegmentoPrincipal();

    if (lSeg != null) {

        lretorno += "Segmento_Id" + "|" + lSeg.getIdSeg();
        lseparador = '@';
    }
    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        $.each(gEntidad[lValorTab][0], function (lClave, lValor) {
            if (lClave != "Existe") {
                if (gControles[lValorTab][0][lClave] != null) {
                    lretorno += lseparador + lClave + '|' + qcom_ObtenerValorControl(gControles[lValorTab][0][lClave]);
                    lseparador = '@';
                }
            }
        });

    });


    return lretorno;
}

//se agrego un parámetro que contiene el nombre del método de FeEventos con el cual se obtienen los datos a mostrar en el reporte
function qcom_MostrarReporte(pNombreReporte, pParametros, pMetodoDatos) {
    $.ajax({
        type: "POST",
        url: "QEncriptar.ashx",
        data: { Valor: pParametros },
        dataType: "text"
    })
    .done(function (response) {
        lparamEncriptado = response;
        var lIdSes = sessionStorage.getItem("idses");
        var lancho = $(window).width() * 0.90;
        var lalto = $(window).height() * 0.90;
        smUrl = 'webfrmReport.aspx?Par=' + lparamEncriptado + '&rpt=' + pNombreReporte + '&metdatos=' + pMetodoDatos + '&dlleventos=' + gFormulario.getDLLEventos() + '&claseeventos=' + gFormulario.getClaseEventos() + '&pref=' + lIdSes;
        smArg = 'Reporte' + lparamEncriptado;
        smFtr = "toolbar=yes,scrollbars=yes,resizable=yes,top=0,left=0,width=" + lancho + ",height=" + lalto;
        window.open(smUrl, smArg, smFtr);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        //alert(xhr.status);
        qcom_MensajeError(thrownError);
    });

}


/******* Filtros Lupas y segmentos ********/
function qcom_ObtenerValorParametrosFiltro(pFiltros) {
    var lResult = '';
    pFiltros = pFiltros || "";
    if (pFiltros != "") {
        var lFiltros = pFiltros.split("@");
        var lSeparador = '';
        for (var j = 0; j < lFiltros.length; j++) {
            lFiltro = lFiltros[j].split(";");
            lResult += lSeparador + lFiltro[0] + ";" + lFiltro[1] + ";";
            lResult += qcom_ObtenerValorParametroFiltro(lFiltro[2]) + ";" + lFiltro[3];
            lSeparador = "@";
        }
    }
    return lResult;
}


/********* Solapas *******************/
function qcom_mostrarSolapa(pSolapa) {
    //Version Anterior
    //var i, tablinks;
    //var lCantSolapas = gSolapas.length;
    //for (var i = 0; i < lCantSolapas; i++) {
    //    //$(gSolapas[i])[0].style.display = "none";
    //    $("#tab" + gSolapas[i])[0].style.display = "none";
    //    $("#li" + gSolapas[i])[0].className = $("#li" + gSolapas[i])[0].className.replace(" active", "");
    //}
    //$("#tab" + pSolapa)[0].style.display = "block";
    //$("#li" + pSolapa)[0].className += " active";
    //Nueva Version
    var lCantSolapas = gSolapas.length;
    var lPrimeraVez = false;
    var levActivado = null;
    for (var i = 0; i < lCantSolapas; i++) {
        var lNombre = gSolapas[i].Nombre;
        if ((lNombre == pSolapa) && (!$("#li" + lNombre)[0].classList.contains("active"))) {
            if (!gSolapas[i].Activada) {
                gSolapas[i].Activada = true;
                levActivado = gSolapas[i].Activado1;
            }
            else {
                levActivado = gSolapas[i].Activado;
            }
        }
        $("#tab" + lNombre)[0].style.display = "none";
        $("#li" + lNombre)[0].className = $("#li" + lNombre)[0].className.replace(" active", "");
    };
    if (lCantSolapas > 0) {
        $("#tab" + pSolapa)[0].style.display = "block";
        $("#li" + pSolapa)[0].className += " active";
    }
    //Si es la primera vez que la activo
    if (levActivado != null) {
        if (typeof levActivado !== 'undefined' && jQuery.isFunction(levActivado))
            levActivado();
    }

}

/******* Mensajes y  Alertas ********************/
/*version Anterior
function qcom_MensajeError(pMensaje) {
    $("#divAlertas").html("<div class='alert alert-danger alert-dismissable' style='padding-top:4px; padding-bottom:4px'>" +
    "<a href='#' class='close' data-dismiss='alert' aria-label='close'>×</a>" +
    "<strong>Error: </strong> " + pMensaje + "</div>");
    $("#divAlertas").show();
}
**/

function qcom_MensajeExito(pMensaje) {
    $("#divMensajeExito").html("<div id='msjecerrar' class='alert alert-success alert-dismissable quasar-mensaje-exito'>" +
    "<a href='#' class='close' data-dismiss='alert' aria-label='close'>x</a>" +
    "" + pMensaje + "</div>");
    $("#divMensajeExito").show();
    $("#msjecerrar").fadeTo(8000, 2000).slideUp(2000,
                                       function () {
                                           $("#msjecerrar").slideUp(2000);
                                       })
}




function qcom_MensajeInformacion(pMensaje) {
    $("#divAlertas").html("<div class='alert alert-info alert-dismissable' style='padding-top:4px; padding-bottom:4px'>" +
    "<a href='#' class='close' data-dismiss='alert' aria-label='close'>×</a>" +
    "<strong>Informacion: </strong> " + pMensaje + "</div>");
    $("#divAlertas").show();

}

function qcom_Alerta(pMensaje, pTipoAlerta, pEjecutaSiguiente) {
    qcom_AlertaCompleto(pMensaje, pTipoAlerta, pEjecutaSiguiente, 0, null);
}

function qcom_AlertaCompleto(pMensaje, pTipoAlerta, pEjecutaSiguiente, pTimeout, pControlFoco) {
    var prom = qBSAlert({
        messageText: pMensaje,
        alertType: pTipoAlerta,
        timeout: pTimeout,
        controlfoco: pControlFoco,

    }).done(function (e) {
        //Daniel
        //if ((pFuncionCallback != 'undefined') && (pFuncionCallback != null))
        //    pFuncionCallback();
        if (!(pEjecutaSiguiente == null))
            qevt_EjecutarSiguiente();
        //Daniel Fin
    });
}




//function qcom_AlertaFinSesion(pInstalacion, pSitio) {
function qcom_AlertaFinSesion(pMsgAdicional) {
    var prom = qBSAlert({
        messageText: qrecSesionExpirada + " - " + pMsgAdicional,
        alertType: 'danger'
    }).done(function (e) {
        //window.open('Login.aspx', '_parent');
        var lInstalacion = "";
        //if (pInstalacion == null)
        //    lInstalacion = gConfiguracion.getInstalacion();
        //else
        //    //lInstalacion = pInstalacion;
        lInstalacion = sessionStorage.getItem("idinst");
        var lSitio = "";
        //if (pSitio == null)
        //    lSitio = gConfiguracion.getSitio();
        //else
        //    lSitio = pSitio;
        lSitio = sessionStorage.getItem("sitio");

        //if (pInstalacion == null)
        //    window.open('Login.aspx?inst=' + gConfiguracion.getInstalacion(), '_parent');
        //else
        //    window.open('Login.aspx?inst=' + pInstalacion, '_parent');
        $('#divCargando').addClass('show');
        $.ajax({
            type: "POST",
            url: lSitio + "/feAjaxComunes.aspx/ObtenerInstalacion",
            data: "{'pInstalacion':'" + lInstalacion + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        //if (msg.d.startsWith("Ok")) {
        window.open('Login.aspx', '_parent');
        //}
        //else {
        //    window.open('Login.aspx', '_parent');
        //}
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        window.open('Login.aspx', '_parent');
    });
    })
}

function qcom_AlertaSesionInvalida(pMensajeAdicional) {
    //var prom = qBSAlert({
    //    messageText: qrecSesionNoValida,
    //    alertType: 'danger'
    //}).done(function (e) {
    //    $('#divCargando').removeClass('show');
    //    window.open('Blank.aspx', '_top');
    //})
    //.fail(function (xhr, ajaxOptions, thrownError) {
    //    $('#divCargando').removeClass('show');
    //    window.open('Blank.aspx', '_top');
    //})
    gSesionValida = false;
    window.open('webfrmError.aspx?error=2&msgadic=' + pMensajeAdicional, '_top');
}

function qcom_AlertaErrorServicio() {
    var gSesionValida = false;
    window.open('webfrmError.aspx?error=1', '_top');
}

function qcom_AlertaErrorNoControlado(pMsgError) {
    gSesionValida = false;
    window.open('webfrmError.aspx?error=' + pMsgError, '_top');
}

function qcom_AlertaSinPermisos() {
    $('#btnNuevo').addClass('hidden');
    $('#btnNuevoF').addClass('hidden');
    $('#btnGuardar').addClass('hidden');
    $('#btnGuardarF').addClass('hidden');
    $('#btnPostear').addClass('hidden');
    $('#btnPostearF').addClass('hidden');
    $('#btnEliminar').addClass('hidden');
    $('#btnEliminarF').addClass('hidden');
    $('#btnImprimir').addClass('hidden');
    $('#btnImprimirF').addClass('hidden');
    var prom = qBSAlert({
        messageText: qrecPermisoNoValido,
        alertType: 'danger'
    }).done(function (e) {
        $('#divCargando').removeClass('show');
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
    });
}


function qcom_Confirmar(pMensaje, pTipoConfirmacion, pFnOKCallback, pFnCancelCallback) {
    qBSAlert({
        type: "confirm",
        messageText: pMensaje,
        alertType: pTipoConfirmacion
    }).done(function (e) {
        if (e) {
            if (pFnOKCallback != null)
                pFnOKCallback();
        }
        else {
            if (pFnCancelCallback != null)
                pFnCancelCallback();
        }
    });
}


function qcom_EsTeclaxaModif(pKey) {
    //if ($('#btnGuardar')[0].disabled == false) {
    return (((pKey == 8) || (pKey == 16) || (pKey == 46) || ((pKey >= 48) && (pKey <= 57)) ||
            ((pKey >= 65) && (pKey <= 90)) || ((pKey >= 106) && (pKey <= 111)) || ((pKey >= 186) && (pKey <= 192)) ||
            ((pKey >= 219) && (pKey <= 222))));
}

/*function qcom_PuedeCambiarEntidad(pKey)
{
    var lReturn = true;
    if (gTieneSinGuardar) {
        if (qcom_EsTeclaxaModif(pKey)) {
            lReturn = confirm('Tiene cambios sin guardar, si continúa perderá los cambios. ¿Continúa?');
        }
    }
    if (lReturn)
    {
        gCtrlCambioCont = false;
        gTieneSinGuardar = false;
        $('#btnGuardar')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
    }

    return lReturn;
}*/

//function qcom_ProcesarCambioEntidad(pKey, pValorAnt, pControl, pEventoModif) {
//    var lReturn = true;
//    if ((gTieneSinGuardar) && qcom_EsTeclaxaModif(pKey)) {
//        $("#tabSolapa_Datos").prop("disabled", true);
//        qcom_Confirmar('Tiene cambios sin guardar, si continúa perderá los cambios. ¿Continúa?', 'warning',
//                        function () {
//                                        $("#tabSolapa_Datos").prop("disabled", false);
//                                        gCtrlCambioCont = false;
//                                        gTieneSinGuardar = false;
//                                        $('#btnGuardar')[0].disabled = true;
//                                        $('#btnPostear')[0].disabled = true;
//                                        gValorAnt = "";
//                                        if (pEventoModif)
//                                            pEventoModif();
//                                    },
//                        function () {
//                            $("#tabSolapa_Datos").prop("disabled", false);
//                            qcom_AsignarValorControl(pControl, pValorAnt, false);
//                            gValorAnt = "";
//                            qevt_VaciarEventosTmp();
//                        })
//    }
//    else if ((!gTieneSinGuardar) && (qcom_EsTeclaxaModif(pKey)))
//    {
//        gCtrlCambioCont = true;
//        gTieneSinGuardar = false;
//        $('#btnGuardar')[0].disabled = true;
//        $('#btnPostear')[0].disabled = true;
//        gValorAnt = "";
//    }
//    else
//    {
//        gValorAnt = "";
//    }
//}

function qcom_ProcesarCambioEntidad(pValorAnt, pControl, pEventoModif) {
    var lReturn = true;
    if (ConsultaxCambiosSinGuardar()) {
        //if (gTieneSinGuardar) {
        $("#tabSolapa_Datos").prop("disabled", true);
        qcom_Confirmar(qrefConfPerderCambios, 'warning',
                        function () {
                            $("#tabSolapa_Datos").prop("disabled", false);
                            gCtrlCambioCont = false;
                            gTieneSinGuardar = false;
                            $('#btnGuardar')[0].disabled = true;
                            $('#btnGuardarF')[0].disabled = true;
                            $('#btnPostear')[0].disabled = true;
                            $('#btnPostearF')[0].disabled = true;
                            //Limpio las solapas para que no figuren como activadas
                            qcom_InicSolapasActivadas();
                            gValorAnt = "";
                            if (pEventoModif)
                                pEventoModif();
                        },
                        function () {
                            $("#tabSolapa_Datos").prop("disabled", false);
                            qcom_AsignarValorControl(pControl, pValorAnt, false);
                            gValorAnt = "";
                            qevt_VaciarEventosTmp();
                        })
    }
    else {
        gCtrlCambioCont = true;
        gTieneSinGuardar = false;
        $('#btnGuardar')[0].disabled = true;
        $('#btnGuardarF')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
        $('#btnPostearF')[0].disabled = true;
        //Limpio las solapas para que no figuren como activadas
        qcom_InicSolapasActivadas();
        gValorAnt = "";
    }
}


//function qcom_DeshabilitoGuardar(pKey) {
//    //if ($('#btnGuardar')[0].disabled == false) {
//    if (!gCtrlCambioCont) {
//        //if ((pKey == 8) || (pKey == 16) || (pKey == 46) || ((pKey >= 48) && (pKey <= 57)) ||
//        //    ((pKey >= 65) && (pKey <= 90)) || ((pKey >= 106) && (pKey <= 111)) || ((pKey >= 186) && (pKey <= 192)) ||
//        //    ((pKey >= 219) && (pKey <= 222))) {
//        if (qcom_EsTeclaxaModif(pKey)) {
//            gCtrlCambioCont = true;
//            gTieneSinGuardar = true;
//            $('#btnGuardar')[0].disabled = true;
//            $('#btnPostear')[0].disabled = true;
//        }
//    }
//}

function qcom_DeshabilitoGuardar() {
    //if ($('#btnGuardar')[0].disabled == false) {
    if (!gCtrlCambioCont) {
        gCtrlCambioCont = true;
        gTieneSinGuardar = true;
        $('#btnGuardar')[0].disabled = true;
        $('#btnGuardarF')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
        $('#btnPostearF')[0].disabled = true;
    }
}


function qcom_DeshabilitoGuardarxInputs() {
    //if ($('#btnGuardar')[0].disabled == false) {
    if (!gCtrlCambioCont) {
        gCtrlCambioCont = true;
        //gTieneSinGuardar = true;
        $('#btnGuardar')[0].disabled = true;
        $('#btnGuardarF')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
        $('#btnPostearF')[0].disabled = true;
    }
}




/********************** Habilitar deshabilitar guardar *************/
function qcom_HabilitoGuardar() {
    //    if (gCtrlCambioCont) {
    gCtrlCambioCont = false;
    $('#btnGuardar')[0].disabled = false;
    $('#btnGuardarF')[0].disabled = false;
    $('#btnPostear')[0].disabled = false;
    $('#btnPostearF')[0].disabled = false;
    //   }
}

function qcom_DeshabilitoAceptarPopup(pTabla) {
    $('#btnAceptargrd' + pTabla)[0].disabled = true;
}

function qcom_HabilitoAceptarPopup(pTabla) {
    $('#btnAceptargrd' + pTabla)[0].disabled = false;
}



/******************************************************************/

/********************** Clonar un Objeto **************************/
function qcom_Clonar(pObjeto) {
    var lprop, lclone;

    // determina si @from es un valor primitivo o una función
    if (pObjeto == null || typeof pObjeto != "object") return pObjeto;

    // determina si @from es una instancia de alguno de los siguientes prototipos
    if (pObjeto.constructor == Date || pObjeto.constructor == RegExp || pObjeto.constructor == Function ||
        pObjeto.constructor == String || pObjeto.constructor == Number || pObjeto.constructor == Boolean) {
        return new pObjeto.constructor(pObjeto);
    }

    // si el constructor del objeto no es ninguno de los anteriores
    if (pObjeto.constructor != Object && pObjeto.constructor != Array) return pObjeto;

    // itera recursivamente las propiedades del objeto
    lclone = new pObjeto.constructor();
    for (var lprop in pObjeto) {
        //no se recomienda arguments.callee
        //clone[prop] = arguments.callee(from[prop]);
        lclone[lprop] = qcom_Clonar(pObjeto[lprop]);
    }
    return lclone;
}

function qcom_TextoaFecha(pFechaTexto) {

    // El valor de la fecha viene en un string formato ISO 8601: "2009-10-15T14:42:51Z"
    //Reemplazo todo lo que no es digito, por un espacio en blanco
    var ldtstr = pFechaTexto.replace(/\D/g, " ");
    //Hago un split por los espacios en blanco
    var ldtcomponentes = ldtstr.split(" ");
    if (ldtcomponentes[0] != "0001") {
        // modify month between 1 based ISO 8601 and zero based Date
        ldtcomponentes[1]--;
        var lconvdt = new Date(ldtcomponentes[0], ldtcomponentes[1], ldtcomponentes[2],
            (ldtcomponentes.length > 3) ? ldtcomponentes[3] : 0,
            (ldtcomponentes.length > 3) ? ldtcomponentes[4] : 0,
            (ldtcomponentes.length > 3) ? ldtcomponentes[5] : 0);
    }
    return lconvdt;
}

function qcom_FormatearFechaGrilla(pFechaHora, pSeparador) {
    if (jQuery.type(pFechaHora) == "string") {
        pFechaHora = qcom_TextoaFecha(pFechaHora);
    }
    //Agrego el else, porque habia casos (por ejemplo en las fecha de vencimiento de la series), 
    // en el que descontaba las horas de la zona horaria - Como las fechas estan con hora 00, entonces me cambiaba la fecha
    //al dia anterior
    //else
    //    pFechaHora = qcom_TextoaFecha(pFechaHora.toISOString());

    if (pFechaHora == null)
        return "";
    else {
        var lAnio = pFechaHora.getFullYear();
        if (lAnio == '0001')
            return "";
        else {
            var lMes = (1 + pFechaHora.getMonth()).toString();
            lMes = (lMes.length > 1) ? lMes : '0' + lMes;

            var lDia = pFechaHora.getDate().toString();
            lDia = (lDia.length > 1) ? lDia : '0' + lDia;

            return lDia + pSeparador + lMes + pSeparador + lAnio;
        }
    }
}



function qcom_FormatearFechaGrilla2(pFechaHora, pFormato) {
    if (jQuery.type(pFechaHora) == "string") {
        pFechaHora = qcom_TextoaFecha(pFechaHora);
    }
    else if (jQuery.type(pFechaHora) == "number") {
        pFechaHora = new Date(pFechaHora);
    }

    if (pFechaHora == null)
        return "";
    else {
        var lAnio = pFechaHora.getFullYear();
        //var lAnio2 = lAnio.toString().substr(-2);
        if (lAnio == '0001')
            return "";
        else {
            //return $.ig.formatter(new Date(lAnio, lMes, lDia), "date", "dd-MM-yyyy");
            var lMes = pFechaHora.getMonth();
            var lDia = pFechaHora.getDate();

            //Formatos Posibles: "dd/MM/yy", "Qdd-MM-yy", "dd-MM-yy", "Qdd/MM/yyyy", "dd/MM/yyyy",
            //                   "dd-MM-yyyy", "d-MMM-yy", "HH:mm", "HH:mm:ss",  "HH:mm:ss fff",
            //                    "Texto{0}Texto2"
            if (pFormato == "")
                //return $.ig.formatter(new Date(lAnio, lMes, lDia), "date", "dd-MM-yyyy");
                return $.ig.formatter(pFechaHora, "date", "dd-MM-yyyy");
            else if (pFormato.indexOf('{') > -1)
                //return pFormato.replace('{0}', $.ig.formatter(new Date(lAnio, lMes, lDia), "date", "dd-MM-yyyy"));
                return pFormato.replace('{0}', $.ig.formatter(pFechaHora, "date", "dd-MM-yyyy"));
            else {
                //var lhora = pFechaHora.getHours();
                //var lmin = pFechaHora.getMinutes();
                //var lseg = pFechaHora.getSeconds();
                //var lmilseg = pFechaHora.getMilliseconds();
                return $.ig.formatter(pFechaHora, "date", pFormato);
            }
            //lDia0 = (lDia.length > 1) ? lDia : '0' + lDia;
            //if (pFormato == "")
            //    return lDia0 + '-' + lMes0 + '-' + lAnio;

            //var lMes = (1 + pFechaHora.getMonth()).toString();
            //lMes0 = (lMes.length > 1) ? lMes : '0' + lMes;

            //var lDia = pFechaHora.getDate().toString();
            //lDia0 = (lDia.length > 1) ? lDia : '0' + lDia;
            //if (pFormato == "")
            //    return lDia0 + '-' + lMes0 + '-' + lAnio;
            //else if (pFormato == "dd-MM-yyyy")
            //    return lDia0 + '-' + lMes0 + '-' + lAnio;
            //else if (pFormato == "dd/MM/yy")
            //    return lDia0 + '/' + lMes0 + '/' + lAnio2;
            //else if (pFormato == "dd-MM-yy")
            //    return lDia0 + '-' + lMes0 + '-' + lAnio2;
            //else if (pFormato == "dd/MM/yyyy")
            //    return lDia0 + '/' + lMes0 + '/' + lAnio;
            //else if (pFormato == "d-MMM-yy")
            //    return lDia0 + '-' + mesesshort[lMes] + '-' + lAnio2;
            //else {
            //    var lhora = pFechaHora.getHours();
            //    var lmin = pFechaHora.getMinutes();
            //    var lseg = pFechaHora.getSeconds();
            //    var lmilseg = pFechaHora.getMilliseconds();
            //    if (lhora < 10) { lhora = "0" + lhora; }
            //    if (lmin < 10) { lmin = "0" + lmin; }
            //    if (lseg < 10) { lseg = "0" + lseg; }
            //    if (lmilseg < 10) { lmilseg = "00" + lmilseg; }
            //    else if (lmilseg < 100) { lmilseg = "0" + lmilseg; }

            //    if (pFormato == "hh:mm")
            //        return lhora + ':' + lmin;
            //    else if (pFormato == "hh:mm:ss")
            //        return lhora + ':' + lmin + ':' + lseg;
            //    else if (pFormato == "hh:mm:ss tt")
            //        return lhora + ':' + lmin + ':' + lseg + ' ' + lmilseg;
            //}
            //return lDia0 + '-' + lMes0 + '-' + lAnio;
        }


    }
}

function qcom_ObtenerDescCombo(pComboDS, pClave) {
    var lretorno = pClave;
    var lCant = pComboDS.length;
    var lEncontre = false;
    for (var i = 0; (i < lCant) && (!lEncontre) ; i++) {
        if (pComboDS[i].Valor == pClave) {
            lEncontre = true;
            lretorno = pComboDS[i].Descripcion;
        }
    }
    return lretorno;
}

function qcom_TratarError(pError) {
    if (pError.startsWith('error:logout')) {
        var larrcomp = pError.split('|');
        var lMensajeAdic = "";
        if (larrcomp.length > 1)
            lMensajeAdic = larrcomp[1];
        qcom_AlertaFinSesion(lMensajeAdic);
    }
    else if (pError.startsWith('error:invalido')) {
        var larrcomp = pError.split('|');
        var lMensajeAdic = "";
        if (larrcomp.length > 1)
            lMensajeAdic = larrcomp[1];
        qcom_AlertaSesionInvalida(lMensajeAdic);
    }
    else if (pError.startsWith('error:qbi'))
        qcom_AlertaErrorServicio();

    else {
        if (typeof qevt_VaciarEventosTmp !== 'undefined')
            qevt_VaciarEventosTmp();
        qcom_Alerta(pError.substring(6), 'danger', null);
    }
}

function qcom_keydown(e) {
    var evtobj = window.event ? event : e
    if (evtobj.ctrlKey) { //Key Ctrl
        if (evtobj.keyCode == 78) { //Key = N
            //if está visible el boton nuevo y está habilitado
            if ($("#btnNuevo").is(":visible") && (!$("#btnNuevo").is(":disabled"))) {
                e.preventDefault();
                e.stopPropagation();
                $("#btnNuevo").click();
            }
        }
        else if (evtobj.keyCode == 71) { //Key = G
            //if está visible el boton guardar y está habilitado
            if ($("#btnGuardar").is(":visible") && (!$("#btnGuardar").is(":disabled"))) {
                e.preventDefault();
                e.stopPropagation();
                $("#btnGuardar").click();
            }
        }
        else if (evtobj.keyCode == 80) { //Key = P
            //if está visible el boton Postear y está habilitado
            if ($("#btnPostear").is(":visible") && (!$("#btnPostear").is(":disabled"))) {
                e.preventDefault();
                e.stopPropagation();
                $("#btnPostear").click();
            }
        }
        else if (evtobj.keyCode == 73) { //Key = I
            //if está visible el boton Imprimir y está habilitado
            if ($("#btnImprimir").is(":visible") && (!$("#btnImprimir").is(":disabled"))) {
                e.preventDefault();
                e.stopPropagation();
                $("#btnImprimir").click();
            }
        }

    }
};



function qcom_ObtenerSesStrg(pInicializar) {
    if (((sessionStorage.getItem("idses") == undefined) || (sessionStorage.getItem("idses") == null)) && pInicializar) {

        var lHoraActual = new Date();
        var lHora = lHoraActual.getHours();
        var lMinutos = lHoraActual.getMinutes();
        var lSegundos = lHoraActual.getSeconds();
        var lHoraStr = ('0' + lHora).slice(-2) + ('0' + lMinutos).slice(-2) + ('0' + lSegundos).slice(-2);
        sessionStorage.setItem("idses", lHoraStr);
    }
    return sessionStorage.getItem("idses");
}


function qcom_SetearEnServerSesStrg(pSoloId, pIraLogin, pCallback) {
    var lIdSes = sessionStorage.getItem("idses");
    var lIdInst = sessionStorage.getItem("idinst");
    var lSitio = sessionStorage.getItem("sitio");
    if ((sessionStorage.getItem("idses") != undefined) && (sessionStorage.getItem("idses") != null)) {
        $.ajax({
            type: "POST",
            url: lSitio + "/feAjaxComunes.aspx/SetearSesStrg",
            data: "{'pIdSesion':'" + lIdSes + "', 'pInstalacion':'" + lIdInst + "', 'pSoloIdSes':'" + pSoloId + "', 'pIngresoDirecto':false}",
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
       .done(function (response) {
           if (pCallback != null)
               pCallback();
           if (pIraLogin)
               window.open('Login.aspx', '_top');
       })
       .fail(function (xhr, ajaxOptions, thrownError) {
           //alert(xhr.status);
           qcom_MensajeError(thrownError);
       });
    }
}


function qcom_CambiarValorVariableSesion(pVariable, pValor) {

    if ((sessionStorage.getItem("idses") != undefined) && (sessionStorage.getItem("idses") != null)) {
        var lIdSes = sessionStorage.getItem("idses");
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/CambiarVariableSession",
            data: "{'pIdSesion':'" + lIdSes + "', 'pVariable':'" + pVariable + "', 'pValor':'" + pValor + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
       .done(function (response) {
           sessionStorage.setItem(pVariable, pValor);
           if (pvariable = "Sucursal") {
               $(window)[0].parent.qprin_CambiarSucursal(pValor);
           }
           qevt_EjecutarSiguiente();
       })
       .fail(function (xhr, ajaxOptions, thrownError) {
           //alert(xhr.status);
           qevt_VaciarEventosTmp();
           qcom_MensajeError(thrownError);
       });
    }
}



function qcom_DescargarArchivo(pNombreControl) {
    var a = $("#ref" + pNombreControl)[0];
    if (a == "")
        qcom_Alerta(qrecNoHayArchivoXaDescarga, 'danger', null);
    else {
        //var lBase64 = a.href.startsWith("data:");
        //if (lBase64 && (window.navigator && window.navigator.msSaveBlob)) {
        download(a.href, a.download, "application/octet-stream");
        //}
        //else
        //    a.click();
    }
}



function qcom_DeshabilitarSegmento(pNombreSegmento) {
    qcom_HabilitacionSegmento(pNombreSegmento, false);
}

function qcom_HabilitarSegmento(pNombreSegmento) {
    qcom_HabilitacionSegmento(pNombreSegmento, true);
}

function qcom_HabilitacionSegmento(pNombreSegmento, pHabilitar) {
    var lSeg = qcom_ObtenerSegmento(pNombreSegmento);
    var lTabla = lSeg.getTabla();
    for (var j = 1; j <= 8; j++) {
        var lControl = null;
        if ((lSeg.getCampoNCCtrlSeg(j) != '') && ((lSeg.getCampoNCCtrl(j) != ''))) {
            lControl = gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)];
        }
        else if (lSeg.getCampoNCCtrlSeg(j) != '') {
            lControl = gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)];
        }
        if (lControl != null) {
            var lNombreControl = lControl.getControl()[0].id;
            //Si es lupa
            if (lNombreControl.endsWith("_1"))
                lNombreControl = lNombreControl.substring(0, lNombreControl.length - 2);
            if (pHabilitar)
                qcom_HabilitarControl(lNombreControl);
            else
                qcom_DesHabilitarControl(lNombreControl);
        }
    }
    //Deshabilito el boton
    var lcontrolbtn = '#btn' + pNombreSegmento;
    if (qcom_existeControl(lcontrolbtn))
        if (pHabilitar)
            qcom_AccionSobreControlAux(lcontrolbtn, "E");
        else
            qcom_AccionSobreControlAux(lcontrolbtn, "D");
}

function qcom_CargarTablasAEnviar(pTablasAEnviar, pEntidadDS) {
    if (pTablasAEnviar == '')
        return JSON.stringify(pEntidadDS);
    else {
        lEntidadAyuda = qcom_Clonar(gEntidadAyuda);
        var lstTablaaEnviar = pTablasAEnviar.split('|');
        for (var i = 0; i < lstTablaaEnviar.length; i++) {
            lEntidadAyuda[lstTablaaEnviar[i]] = qcom_Clonar(pEntidadDS[lstTablaaEnviar[i]])
        }
        return JSON.stringify(lEntidadAyuda);
    }
}


function qcom_CargarTablasARefrescar(pTablasARefrescar, pDatosjson, pEntidadDS) {
    if (pTablasARefrescar == "")
        //pEntidadDS = JSON.parse(pDatosjson);
        return JSON.parse(pDatosjson);
        //Debo pasar a gEntidad todas menos las que no se actualizan
    else {

        var lEntidadAyuda = JSON.parse(pDatosjson);
        var lstTablaaRef = pTablasARefrescar.split('|');
        for (var i = 0; i < lstTablaaRef.length; i++) {
            pEntidadDS[lstTablaaRef[i]] = qcom_Clonar(lEntidadAyuda[lstTablaaRef[i]])
        }
        return pEntidadDS;
    }
}

function qcom_ActivarSolapa(pSolapa) {
    var ltablinks = $(".tablinks");
    for (var i = 0; i < ltablinks.length; i++) {
        //tablinks[i].className = tablinks[i].className.replace(" active", "");
        $("#" + ltablinks[i].id).removeClass('active');
        $("#" + ltablinks[i].id.replace("liSolapa", "tabSolapa")).hide();
    }
    $("#li" + pSolapa).addClass('active');
    $("#li" + pSolapa).click();
    $('#tab' + pSolapa + ' :input:enabled:visible:first').focus();
    //$("#tab"+pSolapa).show();
}

function qcom_AbrirFormularioSolapa() {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/AbrirFormularioInicial",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            if (data.d != "") {
                var lDatosForm = data.d.split('||');
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

        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}
//manejo de favoritos
function qcom_CambiarEstadoFavorito(pNuevoEstado) {
    //Si no viene el estado, debo invertir el valor que tiene
    if (pNuevoEstado == '') {
        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        var lFavorito = $('#btnFavorito').hasClass('quasar-btn-no-favorito');
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/RegistrarCambiosEstadoFavorito",
            data: "{'pFavorito':" + lFavorito + ", 'pFormulario': '" + gConfiguracion.getFormulario() + "', 'pIdSes':'" + lIdSes + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
           .done(function (response) {
               $('#divCargando').removeClass('show');
               if (response.d == "OK") {

                   if ($('#btnFavorito').hasClass('quasar-btn-no-favorito')) {
                       $("#btnFavorito").removeClass('quasar-btn-no-favorito');
                       $("#btnFavorito").addClass("quasar-btn-favorito");
                       $(window)[0].parent.qprin_CambiarFavoritos(gConfiguracion.getFormulario(), 'fav');
                   }
                   else {
                       $("#btnFavorito").removeClass('quasar-btn-favorito');
                       $("#btnFavorito").addClass("quasar-btn-no-favorito");
                       $(window)[0].parent.qprin_CambiarFavoritos(gConfiguracion.getFormulario(), 'nofav');
                   }
               }
               else
                   qcom_TratarError(msg.d);
           })
           .fail(function (xhr, ajaxOptions, thrownError) {
               //alert(xhr.status);
               $('#divCargando').removeClass('show');
               qcom_MensajeError(thrownError);
           });
    }
    else if ((pNuevoEstado == "fav") && ($('#btnFavorito').hasClass('quasar-btn-no-favorito'))) {
        $("#btnFavorito").removeClass('quasar-btn-no-favorito');
        $("#btnFavorito").addClass("quasar-btn-favorito");
    }
    else if ((pNuevoEstado == "nofav") && ($('#btnFavorito').hasClass('quasar-btn-favorito'))) {
        $("#btnFavorito").removeClass('quasar-btn-favorito');
        $("#btnFavorito").addClass("quasar-btn-no-favorito");
    }
    $("#btnFavorito").blur();
}


