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
//Datos de configuracion
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

var qcom_control = function (pControl, pTipoControl, pTipoDato, pDefecto, pVisible, pVisibleXPais, pHabilitado, pControlConjunto, pRequerido, pGrillaEdicion, pNuevoBlanquea, pRelleno, pIdentidad, pMascara) {
    var _Control = pControl;
    var _TipoControl = pTipoControl; //0-label, 1-igTextEditor, 2-igNumericEditor, 3-igDatePicker, 4-checkbox, 5-igCombo, 6-igGrid, 7-boton, 8-Parametro, 9-Porcentaje, 10-OptionGroup, 11-Segmento_id, 12-UpLoad, 13-Mask, 14-HTML, 15-Hora, 16-Fecha-Hora
    var _TipoDato = pTipoDato; //0-nada, 1-string, 2-nuemrico, 3-fecha, 4-bool, 5-FEcha-hora
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
    var _Mascara = pMascara;
    var _VisiblexSeteo = true;
    var _HabilitadoxSeteo = true;
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
        case 13: //"igMaskEditor":
            _Control.addClass("quasar-editormascara");
            _Control[0].setAttribute("MaskDefecto", _Mascara);
            _Control[0].setAttribute("ValorAnteMask","");
            break;
        case 14: //"igHTMLEditor":
            _Control.addClass("quasar-editorHTML");
            break;
        case 15: //"igDateTime":
            _Control.addClass("quasar-editorhora");
            break;
        case 16: //"igDatePicker": Fecha-Hora
            _Control.addClass("quasar-editorfecha");
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
    this.setDefecto = function (pValor) { _Defecto =  pValor};
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
    this.getMascara = function () { return _Mascara };
    this.setMascara = function (pvalor) { _Mascara = pvalor;};
    this.getHabilitadoxSeteo = function () { return _HabilitadoxSeteo };
    this.setHabilitadoxSeteo = function (pvalor) {_HabilitadoxSeteo = pvalor;};
    this.getVisiblexSeteo = function () { return _VisiblexSeteo };
    this.setVisiblexSeteo = function (pvalor) {_VisiblexSeteo = pvalor;};

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
    var _Campos = ["", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposSeg = ["", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposAdic = ["", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""]; //cada posicion es un tipo de origen
    var _CamposNC = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _CamposSegNC = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _CamposSegAlias = ["", "", "", "", "", "", "", ""]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _CamposLongitud = [0, 0, 0, 0, 0, 0, 0, 0]; //Las posiciones son N1, N2, N3, N4, C1, etc
    var _Posiciones = [];
	var _VisibleXPais = true;
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
    this.getCampoLongitud = function (pOrigen) { return _CamposLongitud[pOrigen - 1]; };
    this.getPosiciones = function () { return _Posiciones; };
    this.getCampos = function () { return _Campos; };
    this.getCamposSeg = function () { return _CamposSeg; };
    this.getCamposAdic = function () { return _CamposAdic; };
    this.getCamposNC = function () { return _CamposNC; };
    this.getCamposSegNC = function () { return _CamposSegNC; };
    this.getCamposSegAlias = function () { return _CamposSegAlias; };

    this.getVisibleXPais = function () { return _VisibleXPais; };
    this.setPrincipal = function (valor) { _Principal = valor };
    this.setTabla = function (valor) { _Tabla = valor };
    this.setIdentidad = function (valor) { _Identidad = valor };
    this.setIdSeg = function (valor) { _IdSeg = valor };
    this.setCampoCtrl = function (pOrigen, pValor) { _Campos[pOrigen - 1] = pValor; };
    this.setCampoCtrlAdic = function (pOrigen, pValor) { _CamposAdic[pOrigen - 1] = pValor; };
    this.setCampoCtrlSeg = function (pOrigen, pValor) { _CamposSeg[pOrigen - 1] = pValor; };
    this.setCampoSegAlias = function (pOrigen, pValor) { _CamposSegAlias[pOrigen - 1] = pValor; };
    this.setCampoLongitud = function (pOrigen, pValor) { _CamposLongitud[pOrigen - 1] = pValor; };
    this.setCampoNCCtrl = function (pOrigen, pValor) { _CamposNC[pOrigen - 1] = pValor; };
    this.setCampoNCCtrlSeg = function (pOrigen, pValor) { _CamposSegNC[pOrigen - 1] = pValor; };
    this.SetPosicion = function (pValor) { return _Posiciones.push(pValor); };
    this.setVisibleXPais = function (pValor) {_VisibleXPais = pValor; };
}


var qcom_Relacion = function (pTablaMaster, pTablaDetalle, pColMaster, pColMaster2, pColMaster3, pColDetalle, pColDetalle2, pColDetalle3, pTipoCtrlDetalle) {
    var _TablaMaster = pTablaMaster;
    var _TablaDetalle = pTablaDetalle;
    var _ColMaster = pColMaster;
    var _ColMaster2 = pColMaster2;
    var _ColMaster3 = pColMaster3;
    var _ColDetalle = pColDetalle;
    var _ColDetalle2 = pColDetalle2;
    var _ColDetalle3 = pColDetalle3;
    var _ValorMaster = -1;
    var _TipoCtrlDetalle = pTipoCtrlDetalle;
    this.getTablaMaster = function () { return _TablaMaster };
    this.getTablaDetalle = function () { return _TablaDetalle };
    this.getColMaster = function () { return _ColMaster };
    this.getColMaster2 = function () { return _ColMaster2 };
    this.getColMaster3 = function () { return _ColMaster3 };
    this.getColDetalle = function () { return _ColDetalle };
    this.getColDetalle2 = function () { return _ColDetalle2 };
    this.getColDetalle3 = function () { return _ColDetalle3 };
    this.getTipoCtrlDetalle = function () { return _TipoCtrlDetalle };
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
        case 13: //"igMaskEditor":
            lRetVal = qcom_ObtenerValorMaskEditor(pControl);
            break;
        case 14: //"igHTMLEditor":
            lRetVal = qcom_ObtenerValorHTMLEditor(pControl);
            break;
        case 15: //"igDateEditor":
            lRetVal = qcom_ObtenerValorDateEditor(pControl);
            break;
        case 16: //"igDatePicker": Fecha-Hora
            lRetVal = qcom_ObtenerValorFechaHoraEditor(pControl);
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

function qcom_ObtenerValorMaskEditor(pControl) {
    if (pControl.getControl().igMaskEditor().length == 0)
        return "";
    //Reemplazo todos los puntos y guiones
    if (pControl.getControl().igMaskEditor()[0].value.replace(/\-|\./g, '').trim() == '') //esta opcion da el texto sin los caracteres de la mascara
        return "";
    return pControl.getControl().igMaskEditor()[0].value
}

function qcom_ObtenerValorHTMLEditor(pControl) {
    return pControl.getControl().igHtmlEditor("getContent", "html");
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

function qcom_ObtenerValorFechaHoraEditor(pControl) {
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
        lFechaNueva.setUTCHours(lvalue.getHours(), lvalue.getMinutes(), lvalue.getSeconds(), 0);
        var lFechaJsonUTC = lFechaNueva.toJSON();
        if (lFechaJsonUTC.length > 19)
            lFechaJsonUTC = lFechaJsonUTC.substring(0, 19);
        return lFechaJsonUTC;
    }
}

function qcom_ObtenerValorCombo(pControl) {

    var lmultiSelection = pControl.getControl().igCombo("option", "multiSelection").enabled;
    //Si es multiseleccion, entonces debo retornar todos los elementos seleccionados.
    //en caso de que estén todos seleccionados, debo retornar *
    if (lmultiSelection) {
        var lValor = "";
        var litems = pControl.getControl().igCombo("selectedItems");
        if (litems != undefined) {
            if (litems.filter(qcom_ComboMultiTodosSeleccionado).length > 0)
                lValor = '*';
            else {
                var lSeparador = '';
                litems.forEach(function (pitem) {
                    lValor += (lSeparador + pitem.data.Valor);
                    lSeparador = ','
                })
            }
        }
        return lValor;
    }
    //Si es multiseleccion de booleanos
    else if (pControl.getTipoDato() == 4) {
        var items = pControl.getControl().igCombo("selectedItems");
        var firstItemData = items[0].data;
        var $firstItemLi = items[0].element;
    }
    else {
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
}

function qcom_ObtenerValorCheckBox(pControl) {
    return pControl.getControl().prop('checked');
}


function qcom_ObtenerValorUpLoad(pControl) {
    var lnombre = pControl.getControlConjunto();
    return gUpLoads[lnombre];
}


function qcom_ObtenerValorDateEditor(pControl) {
    //return pControl.getControl().igDateEditor()[0].value;
    return pControl.getControl().igDateEditor("option", "value");
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
            //Inicio 10/02/2020 Agregado porque Ariel tiene casos en donde desde la base de datos viene '  ' (dos espacios en blanco)
            pValor = pValor.trim();
            //Fin 10/02/2020
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
        case 13://"igMaskEditor": 
            if (pInicializar) //Debo destruir el control, y volver a crearlo con la Mascara por defecto
            {
                var lNombreCtrl = pControl.getControl().selector;
                qcom_RecrearMaskEditor(lNombreCtrl, pControl.getMascara());
            }
            qcom_AsignarValorMaskEditor(pControl, pValor);
            //debo guardar el valor porque si enseguida se modifica la mascara, pierdo el valor original
            pControl.getControl()[0].setAttribute("ValorAnteMask", pValor);
            break;
        case 14://"igHTMLEditor": 

            qcom_AsignarValorHTMLEditor(pControl, pValor);
            break;
        case 15://"igDateEditor": 

            qcom_AsignarValorDateEditor(pControl, pValor);
            break;
        case 16: //"igDatePicker": Fecha-Hora
            if (pInicializar) {
                var lFechaHora = pValor;
                if (pControl.getIdentidad() == "AHORA") {
                    var lHoy = new Date();
                    var lHora = lHoy.getHours();
                    var lMin = lHoy.getMinutes();
                    lFechaHora.setHours(lHora, lMin, 0);
                }
                else if (pControl.getIdentidad() == "AHORASEG") {
                    var lHoy = new Date();
                    var lHora = lHoy.getHours();
                    var lMin = lHoy.getMinutes();
                    var lSeg = lHoy.getSeconds();
                    lFechaHora.setHours(lHora, lMin, lSeg);
                }

                pControl.getControl().igDatePicker("value", lFechaHora);
            }
            else
                qcom_AsignarValorFechaEditor(pControl, pValor);
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

function qcom_AsignarValorHTMLEditor(pControl, pValor) {
    if (pValor == null)
        pValor = "";    
    pControl.getControl().igHtmlEditor("setContent", pValor, "html");
}


function qcom_AsignarValorMaskEditor(pControl, pValor) {
    if (pValor == null)
        pValor = "";
    //if ((pValor != "") && (pControl.getRelleno() != 0)) {
    //    pValor = ("0000000000" + pValor).slice(-1 * pControl.getRelleno());
    //}

    pControl.getControl().igMaskEditor("value", pValor);
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

function qcom_AsignarValorDateEditor(pControl, pValor) {
    if ((pValor == null) || (pValor == ""))
        pValor = "00:00";
    var lcompo = pValor.split(':');
    pControl.getControl().igDateEditor("option", "value", new Date(2, 0, 1, lcompo[0], lcompo[1], 0));
}


function qcom_ObtenerTipoContDownLoad(pEsUrl, pExtension) {
    var ltipocont = "";
    if ((pEsUrl == "false") || (pEsUrl == false)) {
        ltipocont = 'data:application/octet-stream;base64,';
        if ((pExtension == 'jpg') || (pExtension == 'jpeg') || (pExtension == 'jfif') ||
            (pExtension == 'png') || (pExtension == 'gif') || (pExtension == 'bmp'))
            ltipocont = 'data:image/' + pExtension + ';base64,';
    }
    return ltipocont;
}

function qcom_ObtenerFechaEspecial(pValor) {
    var lRetorno = "";
    if (pValor == "Hoy") {
        var lHoy = new Date();
        var lMes = lHoy.getMonth() + 1;
        var lDia = lHoy.getDate();
        lRetorno = (lDia < 10 ? '0' : '') + lDia + '/' +
            (lMes < 10 ? '0' : '') + lMes + '/' +
            lHoy.getFullYear();
    }
    else {
        lRetorno = pValor;
    }
    return lRetorno;
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

function qcom_AsignarValorFechaHoraEditor(pControl, pValor) {
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

    var lmultiSelection = pControl.getControl().igCombo("option", "multiSelection").enabled;
    //Si es multiseleccion, entonces debo seleccionar los elementos seleccionados
    //en caso de que estén todos seleccionados, puedo venir *
    if (lmultiSelection) {       
        pControl.getControl().igCombo("deselectAll");

        if (pValor.trim() != "") {
            if (pValor.contains('*')) {
                pControl.getControl().igCombo("selectAll");
                var $textInput = pControl.getControl().igCombo("textInput");
                $textInput[0].value = "Todos";
            }
            else {
                //le tengo que quitar todos los espacios en blanco
                var pValores = pValor.split(",");
                //si la cantidad de valores es igual a la cantidad de items - 1, significa que están todos seleccionados
                if (pValores.length == pControl.getControl().igCombo("items").length - 1) {
                    pControl.getControl().igCombo("selectAll");
                    var $textInput = pControl.getControl().igCombo("textInput");
                    $textInput[0].value = "Todos";
                }
                else {
                    for (var i = 0; i < (pValores.length - 1); i++)
                        pValores[i] = pValores[i].trim();
                    pControl.getControl().igCombo("value", pValores);
                }
            }
        }
    }
    else {
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

    $.each(gComboMultiAux, function (lClave, lValor) {
        var lCbo = gComboMulti[lValor];
        //Obtengo los nombres de los campos, e inicializo todos los valores a true
        //los pongo a todos en true porque el select en forma pregramatica no funciona
        //Entonces pongo todos a true, y luego desselecciono
        var lItems = $("#" + lValor).igCombo("items");
        $("#" + lValor).igCombo("selectAll");
        $.each(lItems, function (lClave, lItem) {
            if (gEntidad[lCbo.Tabla][0][lItem.data.Valor] != true)
            {
                $("#" + lValor).igCombo("deselectByValue", lItem.data.Valor);
            }
        });
    });


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
            for (var j = 1; (j <= 20) && (!lretorno) ; j++) {
                lretorno = ((lSeg.getCampoCtrl(j) == pCampo) || (lSeg.getCampoCtrlAdic(j)  == pCampo));
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
function qcom_InicializarForm(pInicializarClave, PrimeraVez, pEsNuevo) {
    $("#btnLupaAnt").prop("disabled", pEsNuevo);
    $("#btnLupaSig").prop("disabled", (QLupaAdv_Navegador.Primero == ""));
    $("#btnLupaPrim").prop("disabled", pEsNuevo);
    $("#btnLupaUlt").prop("disabled", (QLupaAdv_Navegador.Ultimo == ""));
    $("#btnLupaAntMbl").prop("disabled", pEsNuevo);
    $("#btnLupaSigMbl").prop("disabled", (QLupaAdv_Navegador.Primero == ""));
    $("#btnLupaPrimMbl").prop("disabled", pEsNuevo);
    $("#btnLupaUltMbl").prop("disabled", (QLupaAdv_Navegador.Ultimo == ""));

    
    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        //Daniel 1-5-2018
        //antes que nada, si no es la primera vez, lo que hago es poner en null todos los campos, para limpiarlos
        if (!PrimeraVez) {
            $.each(gEntidad[lValorTab][0], function (lClave, lValor) {
                gEntidad[lValorTab][0][lClave] = null;
                if (gEntidadAux[lValorTab].length > 0)
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
    });

    //Muestro u oculto los segmentos segun visibilidad por pais
    $.each(gSegmentos, function (lClave, lValor) {
        if (!lValor.getVisibleXPais()) {
            qcom_OcultarControl(lValor.getNombre())
        }
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
            if (gGrillas[lGrilla].PermiteOrdenar) {
                gGrillas[lGrilla].Control.igGridSorting("clearSorting");
            }
            if (gGrillas[lGrilla].RegistrosPorPagina > 0)
                gGrillas[lGrilla].Control.igGridFiltering("filter", ([]));
            gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
            gGrillas[lGrilla].Control.igGrid("dataBind");
            gGrillas[lGrilla].Control.igGridSelection("clearSelection");
            gGrillas[lGrilla].ValorPK = -1;
            gGrillas[lGrilla].ColIdEnEdicion = -1;
            gGrillas[lGrilla].ColumnaEnEdicion = "";


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


    $.each(gComboMultiAux, function (lClave, lValor) {
        var lCbo = gComboMulti[lValor];
        //Obtengo los nombres de los campos, e inicializo todos los valores a falso
        var lItems = $("#" + lValor).igCombo("items");
        $("#" + lValor).igCombo("deselectAll");
        $.each(lItems, function (lClave, lItem) {
            gEntidad[lCbo.Tabla][0][lItem.data.Valor] = false;
            gEntidadAux[lCbo.Tabla][0][lItem.data.Valor] = false;
        });

        if (lCbo.Visible && lCbo.VisibleXPais)
            qcom_MostrarControl(lCbo.NombreControl);
        else
            qcom_OcultarControl(lCbo.NombreControl);


    });

    //Debo destruir todas las grillas pivot
    qgrdpvt_DestruirGrdPvt();

    //Limpio los controles y datatables de los atributos generales, si es que hay atributos generales
    qatrib_InicializarControles();
    //if (pInicializarClave) {
    //    gEsNuevaEntidad = true;
    //    qcom_HabilitarGuardar();
    //}

    if (!PrimeraVez) {
        //debo poner todas las solapas como no activadas y debo activar la solapa de datos
        qcom_InicSolapasActivadas(false);
        //qcom_mostrarSolapa("Solapa_Datos");
    }

    $('#divPrincipal').removeClass('divPrincipalOculto');
    if (pEsNuevo && (gPrimerCtr != ""))
        qcom_EstablecerFoco(gPrimerCtr);


    qevt_EjecutarSiguiente();
}

//Version anterior
//function qcom_InicSolapasActivadas() {
//    var lCantSolapas = gSolapas.length;
//    if (lCantSolapas > 0) {
//        var lSolDatosActiva = $("#liSolapa_Datos")[0].classList.contains("active");
//        for (var i = 0; i < lCantSolapas; i++) {
//            gSolapas[i].Activada = false;
//            if (!lSolDatosActiva) {
//                var lNombre = gSolapas[i].Nombre;
//                $("#tab" + lNombre)[0].style.display = "none";
//                $("#li" + lNombre)[0].className = $("#li" + lNombre)[0].className.replace(" active", "");
//            }
//        };
//        if (!lSolDatosActiva) {
//            $("#tabSolapa_Datos")[0].style.display = "block";
//            $("#liSolapa_Datos")[0].className += " active";
//        }
//    }
//}


function qcom_InicSolapasActivadas(pEjecAct1Vez) {
    var lCantSolapas = gSolapas.length;
    if (lCantSolapas > 0) {
        var lSolDatosActiva = $("#liSolapa_Datos")[0].classList.contains("active");
        for (var i = 0; i < lCantSolapas; i++) {
            gSolapas[i].Activada = false;
            if ((!lSolDatosActiva) && pEjecAct1Vez)
            {
                var lNombre = gSolapas[i].Nombre;
                if ($("#li" + lNombre)[0].classList.contains("active"))
                {
                    gSolapas[i].Activada = true;
                    qevt_AgregarEventoaTmp(lNombre + "_Activated1rsttime", null, true);
            }
        }
        };
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
        else  {
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableAddRow", false);
            gGrillas[lGrilla].Control.igGridUpdating("option", "enableDeleteRow", false);
            gGrillas[lGrilla].Control.igGridUpdating("option", "editMode", "none");
        }

       //oculto todos los links
        $("#lbl" + gGrillas[lGrilla].NombreControl + " a:visible").hide();
    });


    qatrib_DeshabilitarAtribGralesEspec();


    qevt_EjecutarSiguiente();
}


//function qcom_ControlesaPrincipal() {
function qcom_ControlesaTablasPlanas() {
    qcom_InicializarColumnasSegmento(false);
    if (gTipoVersion == "D") {
    $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
        $.each(gControles[lValorTab][0], function (lClave, lValor) {
            //Debo asignar valor nulo a todos los campos que no tengan un control asociado
            //Esto es porque si no esos campos contienen los valores que retorne el ultimo llamado que se haya
            //echo a una acción de FEeventos o de de BE.
            //La excepción deben ser los campos de los segmentos (se inicializan en la primera linea de este método)
            //El campo existe del principal, se inicializa luego en el método qcom_ValorCamposClavesaPrincipal
            //Version para scriptDesa
            if ((lValor != null) && (!qcom_EsControlOcultoSegmento(lValorTab, lClave))) {
                lValorCtr = qcom_ObtenerValorControl(lValor);
                gEntidad[lValorTab][0][lClave] = lValorCtr;
            }
            else if ((lValor == null) && (!lClave.startsWith('Segmento')) &&
                (lClave != "Usuario_Id") && (lClave != "Empresa_Id") &&
                    (lClave != "Posteado") && (!lClave.startsWith('Anulad'))) {
                gEntidad[lValorTab][0][lClave] = null;
            }
            //Fin Version para scriptDesa
            });
        });
    }
    else {
            //Version para min.js
        $.each(gTablasPlanas, function (lClaveTab, lValorTab) {
            $.each(gControles[lValorTab][0], function (lClave, lValor) {

                if ((lClave != "Existe") && (lValor != null) && (!qcom_EsControlOcultoSegmento(lValorTab, lClave))) {
                    lValorCtr = qcom_ObtenerValorControl(lValor);
                    gEntidad[lValorTab][0][lClave] = lValorCtr;
                }
        });
    });
        //Fin Version para min.js
    }

    // Llamo a esto para los controles ocultos de los segmentos
    qcom_ValorCamposClavesaPrincipal();

    //paso los valores de los atributos generales
    qatrib_ControlesaTablas();

    //Trato los combos multiseleccion
    $.each(gComboMultiAux, function (lClave, lValor) {
        var lCbo = gComboMulti[lValor];
        var lItemsSel = $("#" + lValor).igCombo("selectedItems");
        //primero pongo todos los elementos en falso en la tabla
        $.each(gEntidad[lCbo.Tabla][0], function (lClave, lItem) {
            if (lClave != "IDCol")
                gEntidad[lCbo.Tabla][0][lClave] = false;
        });
        //Ahora seteo en true los seleccionados
        if (lItemsSel != null) {
            $.each(lItemsSel, function (lClave, lItem) {
                gEntidad[lCbo.Tabla][0][lItem.data.Valor] = true;
            });
        }
    });



    gEntidad["Principal"][0]["Existe"] = false;
}

function qcom_ComboMultiTodosSeleccionado(value, index, array) {
    return (value.data.Valor == '*');
}


function qcom_ComboMultiSeleccionar(pNombreCombo, ui) {
    var lEsta = false
    var lEstaba = false
    if (ui.items != undefined)
        lEsta = (ui.items.filter(qcom_ComboMultiTodosSeleccionado).length > 0);
    if (ui.oldItems != undefined)
        lEstaba = (ui.oldItems.filter(qcom_ComboMultiTodosSeleccionado).length > 0);
    if (lEsta && !lEstaba) {
        $(pNombreCombo).igCombo("selectAll");
    }
    else if (lEstaba && !lEsta)
        $(pNombreCombo).igCombo("deselectAll");
    else if ((lEstaba && lEsta) && (ui.items.length != ui.oldItems.length))
        $(pNombreCombo).igCombo("deselectByIndex", 0);
}

function qcom_ComboMultiDropDownClose(pNombreCombo) {
    var litems = $(pNombreCombo).igCombo("selectedItems");
    if (litems != undefined) {
        if (litems.filter(qcom_ComboMultiTodosSeleccionado).length > 0) {
            var $textInput = $(pNombreCombo).igCombo("textInput");
            $textInput[0].value = "Todos";
        }
    }
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
                for (var j = 0; (j < lPosiciones.length) && (j < lCantPartes); j++) {
                    //pueden haberme pasado un -1 como valor de numero de comprobante
                    //en ese caso, en lugar de -1, viene *1
                    //Por lo tanto debio reemplazar el * por el -
                    lPartesValores[j] = lPartesValores[j].replace('*', '-');
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
    var lSitio = gConfiguracion.getSitio();
    var lData = {
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pIdSes: lIdSes
    };
    $.ajax({
        type: "POST",
        url: lSitio + "AjaxHandler/FormConfig.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        if (msg.e == undefined) {
            gEntidad = JSON.parse(msg.c);
            gEntidadAux = JSON.parse(msg.c);
            gEntidadAyuda = JSON.parse(msg.c);
            gTieneDsEsp = (msg.esp == "1");
            if (gControles == null) {
                gControles = JSON.parse(msg.c);
                if (pExito_CallBack != null)
                    pExito_CallBack();
            }
        }
        else {
            $(window)[0].parent.qprin_AbrirSigForm();
            qcom_TratarError(msg.e);            
        }
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        $(window)[0].parent.qprin_AbrirSigForm();
        qcom_Alerta(thrownError, 'danger', null);
    });
}



function qcom_EjecutarAccion(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, pCodigoConsulta, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, pDesSelecGrillas, pPosibleCambioCodigo) {
    $('#divCargando').addClass('show');
    var lEntidadAyuda = null;
    var lPosLeft = window.pageXOffset;
    var lPosTop = window.pageYOffset;
    pCodigoConsulta = (typeof pCodigoConsulta !== 'undefined') ? pCodigoConsulta : "";
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);

    var lIdSes = sessionStorage.getItem("idses");
    var lData = {
        pDsEntidad: ldataset, pTieneDsEsp: gTieneDsEsp, pDllExchange: gFormulario.getDLLExchange(),
        pClaseExchange: gFormulario.getClaseExchange(), pClaseEnum: gFormulario.getClaseEnum(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllExchangeEsp: gFormulario.getDLLExchangeEsp(),
        pClaseExchangeEsp: gFormulario.getClaseExchangeEsp(), pClaseEnumEsp: gFormulario.getClaseEnumEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'),
        pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes, pCodigoConsulta: pCodigoConsulta,
        pAccionEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm
    };

    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/AcEjecutar.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })

        .done(function (msg) {
            $('#divCargando').removeClass('show');
            //Proceso el mensajes de consulta
            var lEsMsgError = (msg.e != undefined);
            if (lEsMsgError && msg.e.startsWith("cons:")) {
                qcom_EjecutarAccion_Mens(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, msg.e, pTablasARefrescar, pTablasAEnviar, pEsEspecializada, pDesSelecGrillas, pPosibleCambioCodigo);
            }
            else if ((!lEsMsgError) || (!msg.e.startsWith("error:"))) {
                qcom_HabilitarGuardar();
                if (pBlanqueoOK) {
                    qevt_EjecutarSiguiente();
                    //Inicio 11/11/2020 Daniel - Esta rama solo se usa para acción "Eliminar" - Se pasó esa sentencia para que se ejecute al final del evento
                    //qevt_InicializarForm(true, false, true)
                    //Fin 11/11/2020
                }
                else if (!lEsMsgError) { //   
                    gEntidad = qcom_CargarTablasARefrescar(pTablasARefrescar, msg, gEntidad);
                    pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                    //Inicio Daniel - 16-11-2019 - por funcionalidad comun con Pegar formulario
                    qcom_CargarControlesFormulario(pTablasARefrescar, pDesSelecGrillas, pBlanqueoNotOK);
                    //qcom_TablasPlanasaControles(pTablasARefrescar);

                    //$.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
                    //    var lNombreTabla = gGrillas[lGrilla].Tabla;
                    //    //Solo debo actualizar las grillas que se deban refrescar
                    //    if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                    //        if (gGrillas[lGrilla].AutoFormateable) {
                    //            qgrillas_CrearGrilla(gGrillas[lGrilla].NombreControl, gEntidad[lNombreTabla], gEntidad[lNombreTabla + 'fmt']);
                    //        }
                    //        else if (gGrillas[lGrilla].EsArbol) {
                    //            //gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                    //            if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla].length == 0))
                    //                gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                    //            else {
                    //                var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                    //                var lUltAutonum = gEntidad[lNombreTabla][gEntidad[lNombreTabla].length - 1][lCampoAutoNum];
                    //                gGrillas[lGrilla].UltimaPK = lUltAutonum;
                    //            }

                    //            gGrillas[lGrilla].Control.igTreeGrid("option", "dataSourceType", "array");
                    //            gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                    //            gGrillas[lGrilla].Control.igTreeGrid("dataBind");
                    //            qgrillas_ColapsarArbol(lGrilla);
                    //        }
                    //        else {
                    //            if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla].length == 0))
                    //                gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                    //            else {
                    //                var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                    //                var lUltAutonum = gEntidad[lNombreTabla][gEntidad[lNombreTabla].length - 1][lCampoAutoNum];
                    //                gGrillas[lGrilla].UltimaPK = lUltAutonum;
                    //            }
                    //            gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
                    //            gGrillas[lGrilla].Control.igGrid("dataBind");
                    //            if (pDesSelecGrillas) {
                    //                gGrillas[lGrilla].Control.igGridSelection("clearSelection");
                    //                gGrillas[lGrilla].ValorPK = -1;
                    //                gGrillas[lGrilla].ColIdEnEdicion = -1;
                    //                gGrillas[lGrilla].ColumnaEnEdicion = "";
                    //            }

                    //        }
                    //    }
                    //});

                    //$.each(gGraficosAux, function (lClave, lValor) {
                    //    var lNombreControl = gGraficos[lValor].NombreControl;
                    //    graf_MostrarAdicGrafico(lNombreControl, false);
                    //    graf_DestruirGrafico(lNombreControl);
                    //});


                    //$.each(gListasAdjuntosAux, function (lClave, lValor) {
                    //    var lNombreTabla = gListasAdjuntos[lValor].Tabla;
                    //    //Solo debo actualizar las tablas que se deban refrescar
                    //    if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                    //        var lNombreControl = gListasAdjuntos[lValor].NombreControl;
                    //        qlstadj_VaciarLista(lNombreControl);
                    //        for (var l = 0; l < gEntidad[lNombreTabla].length; l++) {
                    //            if (gEntidad[lNombreTabla][l].Estado != gEstadoAdjunto["Borrado"]) {
                    //                qlstadj_AgregarVistaAdjunto(lNombreControl, l, l);
                    //            }
                    //        }
                    //        gListasAdjuntos[lValor].UltId = gEntidad[lNombreTabla].length;
                    //    }
                    //});
                    //Fin Daniel - 16-11-2019 - por funcionalidad comun con Pegar formulario

                    document.documentElement.scrollTop = lPosTop;
                    document.documentElement.scrollLeft = lPosLeft;
                    document.body.scrollTop = lPosTop;
                    document.body.scrollLeft = lPosLeft;

                    qevt_EjecutarSiguiente();
                    //Daniel Fin
                }
                    //(msg.e.startsWith("NoExiste")) {
                else if (pBlanqueoNotOK) {
                    //Daniel
                    qevt_VaciarEventosTmp();
                    //Daniel Fin
                    //qcom_InicializarForm(false, false, false);
                    qevt_InicializarForm(false, false, false);
                    //Daniel
                    if (pFnNoExiste != null) {
                        qevt_AgregarEventoaTmp(pFnNoExiste, null, true);
                    }
                    //Daniel Fin
                }
                else {
                    if ((pPosibleCambioCodigo) && (gCampoCodigoNuevo != "") &&
                        (gCamposClaves.length > 0) && (pNombreAccion == "Guardar")) {                        
                        var lValorCodNuevo = qcom_ObtenerValorControl(gControles["Principal"][0][gCampoCodigoNuevo]);
                        var lCmpClave = gCamposClaves[0];
                        var lValorCodViejo = qcom_ObtenerValorControl(gControles["Principal"][0][lCmpClave]);
                        if (lValorCodViejo != lValorCodNuevo)
                            qcom_AsignarValorControl(gControles["Principal"][0][lCmpClave], lValorCodNuevo, false);
                    }
                    qevt_EjecutarSiguiente();
                }
                if (pMensajeOK != "") {
                    qcom_MensajeExito(pMensajeOK);
                }
            }
            else {
                if (qcom_existeControl('#divMensajeItera'))
                    $('#divMensajeItera').removeClass('show');
                qcom_TratarError(msg.e);
            }
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            // aj dic 2016
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            if (qcom_existeControl('#divMensajeItera'))
                $('#divMensajeItera').removeClass('show');
            //qcom_Alerta(xhr.responseText, 'danger', null);
            qcom_Alerta(thrownError, 'danger', null);
        });
}



function qcom_EjecutarAccion_Mens(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, pMensajeConsulta, pTablasAModificar, pTablasAEnviar, pEsEspecializada, pDesSelecGrillas, pPosibleCambioCodigo) {

    var lcomponentes = pMensajeConsulta.substring(5).split("|");
    qcom_Confirmar(lcomponentes[1], 'warning',
        function () { qcom_EjecutarAccion(pNombreAccion, pBlanqueoNotOK, pBlanqueoOK, pMensajeOK, pFuncionCallBack, pFnNoExiste, lcomponentes[0], pTablasAModificar, pTablasAEnviar, pEsEspecializada, pDesSelecGrillas, pPosibleCambioCodigo) },
          function () { qevt_VaciarEventosTmp(); }
    )
}



function qcom_CargarControlesFormulario(pTablasARefrescar, pDesSelecGrillas, pEsDevolverDatos) {

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

                                gGrillas[lGrilla].Control.igTreeGrid("option", "dataSourceType", "array");
                                gGrillas[lGrilla].Control.igTreeGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                gGrillas[lGrilla].Control.igTreeGrid("dataBind");
                                qgrillas_ColapsarArbol(lGrilla);
                            }
                            else {
                                if ((gGrillas[lGrilla].CampoAutonumerico == "") || (gEntidad[lNombreTabla].length == 0))
                                gGrillas[lGrilla].UltimaPK = gEntidad[lNombreTabla].length;
                                else {
                                    var lCampoAutoNum = gGrillas[lGrilla].CampoAutonumerico;
                                    var lUltAutonum = gEntidad[lNombreTabla][gEntidad[lNombreTabla].length - 1][lCampoAutoNum];
                                    gGrillas[lGrilla].UltimaPK = lUltAutonum;
                                }
                                if ((gGrillas[lGrilla].PermiteOrdenar) && (pEsDevolverDatos)) {
                                    gGrillas[lGrilla].Control.igGridSorting("clearSorting");
                                }
                                if ((gGrillas[lGrilla].RegistrosPorPagina > 0) && (pEsDevolverDatos))
                                    gGrillas[lGrilla].Control.igGridFiltering("filter", ([]));
                                gGrillas[lGrilla].Control.igGrid("option", "dataSource", gEntidad[lNombreTabla]);
                                gGrillas[lGrilla].Control.igGrid("dataBind");
                                if (pDesSelecGrillas) {
                                    gGrillas[lGrilla].Control.igGridSelection("clearSelection");
                                    gGrillas[lGrilla].ValorPK = -1;
                                    gGrillas[lGrilla].ColIdEnEdicion = -1;
                                    gGrillas[lGrilla].ColumnaEnEdicion = "";
                                }

                            }
                        }
                    });

                    $.each(gGraficosAux, function (lClave, lValor) {
                        var lNombreTabla = gGraficos[lValor].Tabla;
                        if ((pTablasARefrescar == "") || (pTablasARefrescar.indexOf("|" + lNombreTabla + "|") !== -1)) {
                        var lNombreControl = gGraficos[lValor].NombreControl;
                        graf_MostrarAdicGrafico(lNombreControl, false);
                        graf_DestruirGrafico(lNombreControl);
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

                    qgrdpvt_DestruirGrdPvt();

}

function qcom_EjecutarCondicion(pNombreCondicion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");

    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);

    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreCondicion: pNombreCondicion, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };


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
                //var lValorCond = JSON.parse(msg.d);
                var lValorCond = msg.d;
                qevt_EliminarNodosCond(lValorCond);
                qevt_EjecutarSiguiente();

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



function qcom_MostrarReporteConParamDesdeServer(pMetodoParam, pMetodoNombre, pMetodoXMLRep, pTablasAEnviar, pEsEspecializada, pNombreReporte, pMetodoDatos) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(), 
                pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(), 
                pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
                pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
                pMetodoParametros: pMetodoParam, pMetodoNombreReporte: pMetodoNombre, pFormulario: gConfiguracion.getFormulario(), 
                pIdSes: lIdSes};
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/ParamReporte.ashx?pTipo=C",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                //var lValorCond = JSON.parse(msg.d);
                var lParRpt = msg.d;
                var lNombreRpt = msg.m;
                if (pMetodoParam == "")
                    lParRpt = qcom_ObtenerParametrosReporte();
                if (pMetodoNombre == "")
                    lNombreRpt = pNombreReporte;
                qcom_MostrarReporte(lNombreRpt, lParRpt, pMetodoDatos, pMetodoXMLRep);
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


function qcom_EjecutarAccionFE(pNombreAccion, pTablasAEnviar, pTablasARefrescar, pEsEspecializada) {

    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
        pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pTablasPlanas: gTablasPlanas.join('|'),
        pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/AcFEEjecutar.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                gEntidad = qcom_CargarTablasARefrescar(pTablasARefrescar, msg, gEntidad);
                pTablasARefrescar = (pTablasARefrescar == "") ? "" : "|" + pTablasARefrescar + "|";
                qcom_CargarControlesFormulario(pTablasARefrescar, false);
                qevt_EjecutarSiguiente();
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




function qcom_EjecutarDescargaArchivoGeneral(pData, pPopupDescarga) {
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/DescargarArchivo.ashx",
        data: pData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
        if (msg.e == undefined) {
                //si es download
                var lDatosDownLoad = JSON.parse(msg.d);
            if (lDatosDownLoad.Principal.length > 0) {
                if (lDatosDownLoad.Principal[0].Archivo != "") {
                var ltipocont = qcom_ObtenerTipoContDownLoad(lDatosDownLoad.Principal[0].EsURL, lDatosDownLoad.Principal[0].Extension);

                var elem = window.document.createElement('a');
                elem.id = "reftemporal";
                elem.innerText = lDatosDownLoad.Principal[0].Titulo;
                elem.href = ltipocont + lDatosDownLoad.Principal[0].Archivo;
                elem.download = lDatosDownLoad.Principal[0].NombreArchivoDescargado;
                document.body.appendChild(elem);
                //solo paso el nombre "temporal" porque el método le agrega el href, porque se utiliza tambien con los controles con campos asociados
                qcom_DescargarArchivo("temporal", pPopupDescarga)
                document.body.removeChild(elem);
            }
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




function qcom_EjecutarDescargaArchivo(pNombreAccion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada, pPopupDescarga) {
    
    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
        pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };
    //qcom_EjecutarDescargaArchivoGeneral(lData, pFuncionCallBack)
    qcom_EjecutarDescargaArchivoGeneral(lData, pPopupDescarga)
}


function qcom_GeneraryDescargaXLS(pNombreReporte, pParametros, pPopupDescarga) {
    var lIdSes = sessionStorage.getItem("idses");
    var lEntidadRep = { Principal: [] };
    lEntidadRep.Principal = [{ ArchivoXLS: '', Existe: false, NombreArchivoXLS: '', NombreReporte: pNombreReporte, Parametros: pParametros }];
    var ldataset = JSON.stringify(lEntidadRep);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: 'MiscelaneosFEEventos', pClaseEventos: 'MiscelaneosFEEventos.misReporteAXLS',
        pDllCommon: 'MiscelaneosCommon', pClaseCommon: 'MiscelaneosCommon.misReporteAXLSDS', pDllEventosEsp: '',
        pClaseEventosEsp: '', pDllCommonEsp: '', pClaseCommonEsp: '', pTieneDSEsp: false, pEsEspecializada: false,
        pTieneTablaAutoFormateable: gTieneGrillasAutoForm, pNombreAccion: 'ReporteAXLS', pFormulario: '', pIdSes: lIdSes
    };
    //qcom_EjecutarDescargaArchivoGeneral(lData, null)
    qcom_EjecutarDescargaArchivoGeneral(lData, pPopupDescarga)
}


function qcom_EjecutarMostrarPDFEspecialGral(pData, pFuncionCallBack) {
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/DescargarArchivo.ashx",
        data: pData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                var lDatosPDF = JSON.parse(msg.d);
                var pdfWindow = window.open("")
                //pdfWindow.document.write("<iframe width='100%' height='100%' src='data:application/pdf;base64, " + encodeURI(lDatosPDF.Principal[0].Archivo) + "'></iframe>")
                pdfWindow.document.write("<html><head><title>" + lDatosPDF.Principal[0].Titulo + "</title></head><body><iframe title='QuasarGlobal' width='100%' height='100%' src='data:application/pdf;base64, " + encodeURI(lDatosPDF.Principal[0].Archivo) + "'></iframe></body></html>")
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


function qcom_EjecutarDatosIndicador(pNombreIndicador, pNombreAccion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {

    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
        pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pNombreAccion: pNombreAccion, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };

    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/DatosIndicador.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        if (msg.e == undefined) {
            //si es download
            var lDatos = JSON.parse(msg.d);
            if (lDatos.Indicador.length > 0) {
                qindic_Crear(pNombreIndicador, lDatos.Indicador[0].Valor, lDatos.Indicador[0].TextoAdicionalValor, lDatos.Rangos)
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


function qcom_EjecutarMostrarPDFEspecial(pNombreAccion, pFuncionCallBack, pTablasAEnviar, pEsEspecializada) {

    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
        pDllEventosEsp: gFormulario.getDLLEventosEsp(), pClaseEventosEsp: gFormulario.getClaseEventosEsp(),
        pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pNombreAccion: pNombreAccion,
        pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };

    qcom_EjecutarMostrarPDFEspecialGral(lData, pFuncionCallBack)
}


function qcom_GeneraryDescargaXLSConParamDesdeServer(pNombreReporte, pMetodoParam, pTablasAEnviar, pEsEspecializada, pPopupDescarga) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    //var ldataset = JSON.stringify(gEntidad);
    var ldataset = qcom_CargarTablasAEnviar(pTablasAEnviar, gEntidad);
    var lData = {
        pDsEntidad: ldataset, pDllEventos: gFormulario.getDLLEventos(), pClaseEventos: gFormulario.getClaseEventos(),
        pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(), pDllEventosEsp: gFormulario.getDLLEventosEsp(),
        pClaseEventosEsp: gFormulario.getClaseEventosEsp(), pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(),
        pTieneDSEsp: gTieneDsEsp, pEsEspecializada: pEsEspecializada, pTieneTablaAutoFormateable: gTieneGrillasAutoForm,
        pMetodoParametros: pMetodoParam, pMetodoNombreReporte: "", pFormulario: gConfiguracion.getFormulario(),
        pIdSes: lIdSes
    };
    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/ParamReporte.ashx?pTipo=C",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                //var lValorCond = JSON.parse(msg.d);
                var lParRpt = msg.d;
                qcom_GeneraryDescargaXLS(pNombreReporte, lParRpt, pPopupDescarga);
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



function qcom_ObtenerDatosComboGrilla(pIdEntidad, pFnCB) {
    QLupaAdv_CamposRet = null;
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");
    $.ajax({
        type: "POST",
        url: "AjaxHandler/QComboAdvDatos.ashx",
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


//-----------------Segemento-------------------------------------------------------
function qcom_InicializarSegmento(pNombre) {
    var lRetorno = null;
    var lEncontre = false;
    var lCantidad = gSegmentos.length;
    for (var i = 0; (i < lCantidad) && (!lEncontre) ; i++) {
        if (gSegmentos[i].getNombre() == pNombre) {
            gSegmentos[i] = new qcom_segmento(pNombre);
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
        //tampoco tendria que controlarlo si es mexico y es tipo letra-venta
        else if (gConfiguracion.getDominio() != "MX") {
            if ((lSeg.getCampoNCCtrlSeg(j) != "") &&
            //Inicio 31-5-2021 Cambio tipo de combo Letra de Compra - No se debe tener en cuenta la letra de compra
            //    ((j < 5) || (lSeg.getCampoCtrlSeg(1) != lSeg.getCampoNCCtrlSeg(j))))
                ((j < 5) || ((lSeg.getCampoCtrlSeg(1) != lSeg.getCampoNCCtrlSeg(j)) &&
                             (lSeg.getCampoCtrlSeg(6) != lSeg.getCampoNCCtrlSeg(j))) ))
            //Fin 31-5-2021
                lretorno = ((qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != "") &&
                    (qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != 0));
        }
        else {
            if ((lSeg.getCampoNCCtrlSeg(j) != "") &&
                ((j < 5) ||
                 ((lSeg.getCampoCtrlSeg(1) != lSeg.getCampoNCCtrlSeg(j)) && 
                  (lSeg.getCampoCtrlSeg(5) != lSeg.getCampoNCCtrlSeg(j)))))
                lretorno = ((qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != "") &&
                    (qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)]) != 0));
        }
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

//Inicio 3/7/2021 - Anular comportamiento por default de Eliminar
function qcom_EliminarEntidadNoDefault(pFuncionCallBack) {
    if (typeof pFuncionCallBack == 'function') {
                $("#Procesando").show();
                pFuncionCallBack();
                $("#Procesando").hide();
    }
    else
        qcom_Alerta(qrecNo_Implmentado, 'info', null);
}
//Fin 3/7/2021

//Inicio - No se debiera usar mas
//function qcom_ImprimirEntidad(pFuncionCallBack) {
//    if (typeof pFuncionCallBack == 'function') {
//        $("#Procesando").show();
//        pFuncionCallBack();
//        $("#Procesando").hide();
//    }
//    else
//        //alert('no disponible en este formulario');
//        qcom_Alerta(qrecNo_Implmentado, 'info', null);
//}
//Fin

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


function qcom_NuevaEntidad(pPegaDePortaPapel) {
    //if (gTieneSinGuardar)
    if (ConsultaxCambiosSinGuardar()) {
        qcom_Confirmar(qrefConfPerderCambios, 'warning',
                    function () {
                        gEntidad["Principal"][0].Posteado = false;
                        gTieneSinGuardar = false;
                        //qcom_InicializarForm(true, false, true);
                        //qevt_InicializarForm(true, false);
                        if (!pPegaDePortaPapel)
                            qevt_InicializarForm(true, false, true);
                        else
                        {
                            var lDatosDesc = qcom_ObtenerDescPKAntesPegar();

                            qevt_InicializarForm(false, false, true);
                        
                            var lEvento = new qevt_evento();
                            lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
                            lEvento.Acciones.push(new qevt_accion("1", "A", qcom_PegarFormulario, "", [lDatosDesc]));
                            qevt_AgregarEventoaTmp("", lEvento, false);
                            if (gEventosTmp.length == 1)
                                qevt_EjecutarSiguiente();
                        }
                    }, function () {
                            qevt_VaciarEventosTmp();
                        }
                    );
    }
    else {
    gEntidad["Principal"][0].Posteado = false;
        gTieneSinGuardar = false;
        //qcom_InicializarForm(true, false, true);
        //qevt_InicializarForm(true, false);
        if (!pPegaDePortaPapel)
        qevt_InicializarForm(true, false, true);
        else {
            var lDatosDesc = qcom_ObtenerDescPKAntesPegar();
            qevt_InicializarForm(false, false, true);
            var lEvento = new qevt_evento();
            lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
            lEvento.Acciones.push(new qevt_accion("1", "A", qcom_PegarFormulario, "", [lDatosDesc]));
            qevt_AgregarEventoaTmp("", lEvento, false);
            if (gEventosTmp.length == 1)
                qevt_EjecutarSiguiente();
        }
    }
}

function qcom_HabilitarGuardar() {
    if (gFormulario.getPostear() && (gFormulario.getUsuarioModif()) &&
        (!gEntidad["Principal"][0].Posteado)) {
        $('#btnGuardar').show();
        //$('#btnGuardarF').show();
    }
    else {
        $('#btnGuardar').hide();
        //$('#btnGuardarF').hide();
    }
    if (gFormulario.getPostear() && (gFormulario.getUsuarioPostear())) {
        $('#btnPostear').show();
        //$('#btnPostearF').show();
    }
    else {
        $('#btnPostear').hide();
        //$('#btnPostearF').hide();
    }

}

function qcom_blanquearCambiosSinGuardarySolapAct() {
    qcom_InicSolapasActivadas(false);
    qcom_blanquearCambiosSinGuardar();
}


function qcom_blanquearCambiosSinGuardar() {
    gTieneSinGuardar = false;
    qevt_EjecutarSiguiente();
}


function qcom_marcarCambiosSinGuardar() {
    gTieneSinGuardar = true;
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
            //$('#btnEliminarF').show();
        }
    }
    else {
        $('#btnGuardar').hide();
        //$('#btnGuardarF').hide();
        $('#btnPostear').hide();
        //$('#btnPostearF').hide();
        $('#btnEliminar').hide();
        //$('#btnEliminarF').hide();

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
        if (lColumna != undefined) {
            pValor = qcom_ObtenerValorControl(gControles[lTabla][0][lColumna]);
            //Inicio 09-03-2021 - Si es numerico el control, y tiene el valor 0, entonces pasar un ''
            if (pValor == '0')
                if (gControles[lTabla][0][lColumna].getTipoControl() == 2)
                    pValor = '';
            //Fin 09-03-2021 
        }
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
    var lcontrolOculto = "";
    if (qcom_existeControl(lcontrol)) {
        qcom_AccionSobreControlAux(lcontrol, pAccion);
        lcontrollbl = "#" + 'lbl' + pControlName;
        lcontrolOculto = "#o_" + pControlName;
    }
    else {
        //Si es una lupa
        lcontrol = "#" + pControlName + "_1";
        lcontrolDesc = "#" + pControlName + "_d";
        lcontrollbl = "#" + 'lbl' + pControlName + "_1";
        lcontrolbtn = '#btn_' + pControlName;
        lcontrolOculto = "#o_" + pControlName + "_1";
        if (qcom_existeControl(lcontrol))
        //agregué las llaves, porque si no existe el _1, no debieran existir los otros
        {
            qcom_AccionSobreControlAux(lcontrol, pAccion);
            if (qcom_existeControl(lcontrolDesc))
                qcom_AccionSobreControlAux(lcontrolDesc, pAccion);
            if (qcom_existeControl(lcontrolbtn))
                qcom_AccionSobreControlAux(lcontrolbtn, pAccion);
        }
        //debo ver si es una opción de un menu contextual de una grilla
        else if (gGrillasAux.length > 0)
            qgrillas_AccionSobreMenuCtxt(pControlName, pAccion);
        else //Debo verificar si es un option group
        {
            //solo debo habilitar o deshabilitar el que no está chequeado
            //si deshabilito el chequeado, entonces se quita la marca de chequeado
            var lid = "";
            var lElem = $('input[name="' + pControlName + '"]:checked');
            if (lElem.length > 0)
                lid = lElem[0].id;
            var l = $("input[name='" + pControlName + "']");
            $.each(l, function (lClave, lValor) {
                if (lValor.id != lid)
                    qcom_AccionSobreControlAux("#" + lValor.id, pAccion);
            });
        }

    }
    //Si hay un label asociado, lo oculto
    if (qcom_existeControl(lcontrollbl))
        qcom_AccionSobreControlAux(lcontrollbl, pAccion);
    //Si hay un label asociado, lo oculto
    if (qcom_existeControl(lcontrolOculto))
        qcom_AccionSobreControlAux(lcontrolOculto, pAccion);

}


function qcom_AccionSobreControlAux(pControlName, pAccion) {
    if (pAccion == "H")
    
    {
        //if ($(window).width() > 768)
        //    $(pControlName).css("visibility", "hidden");
        //else
            $(pControlName).hide();
    }
    else if (pAccion == "S") {
        //if ($(window).width() > 768)
        //    $(pControlName).css("visibility", "visible");
        //else
            $(pControlName).show();
    }
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
        else if ($(pControlName).hasClass("quasar-editormascara")) {
            $(pControlName).igMaskEditor("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if ($(pControlName).hasClass("quasar-editorhora")) {
            $(pControlName).igDateEditor("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if (gComboMulti[pControlName.substring(1)] != undefined) {
            $(pControlName).igCombo("option", "disabled", true);
            $(pControlName).addClass("quasar-deshabilitado");
        }
        else if (gGrillas[pControlName.substring(1)] != undefined) 
        {
            var lGrilla = gGrillas[pControlName.substring(1)];
            if ((!lGrilla.EsArbol) && (!lGrilla.AutoFormateable)) {
                //Debo ocultar la opcion de agregar una fila si la tuviese
                lcontrolRef = "#aref" + pControlName.substring(1);

                if (qcom_existeControl(lcontrolRef))
                    $(lcontrolRef).hide();
                //si la grilla permite eliminar, debo quitarle esa opcion
                $(pControlName).igGridUpdating("option", "enableDeleteRow", false);
                //si la grilla permite editar la celda, debo quitarle esa opcion
                $(pControlName).igGridUpdating("option", "editMode", "none");
            }
        }
        //else if ($(pControlName).hasClass("quasar-editorHTML")) {
        //    $(pControlName).igHTMLEditor("option", "disabled", true);
        //    $(pControlName).addClass("quasar-deshabilitado");
        //}

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
            else if ($(pControlName).hasClass("quasar-editorhora")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igDateEditor("option", "disabled", false);
            }
            else if ($(pControlName).hasClass("quasar-editormascara")) {
                $(pControlName).removeClass("quasar-deshabilitado");
                if ($(pControlName).igMaskEditor("option", "readOnly")) {
                    $(pControlName).igMaskEditor("option", "readOnly", false);
                    $(pControlName).igMaskEditor("option", "disabled", false);
                    $(pControlName).igMaskEditor("option", "readOnly", true);
                }
                else
                    $(pControlName).igMaskEditor("option", "disabled", false);
            }
            //else if ($(pControlName).hasClass("quasar-editorHTML")) {
            //    $(pControlName).removeClass("quasar-deshabilitado");
            //    $(pControlName).igHTMLEditor("option", "disabled", false);
            //}
            else if (gComboMulti[pControlName.substring(1)] != undefined)
            {
                $(pControlName).removeClass("quasar-deshabilitado");
                $(pControlName).igCombo("option", "disabled", false);
            }
            else if (gGrillas[pControlName.substring(1)] != undefined) {
                var lGrilla = gGrillas[pControlName.substring(1)];
                if ((!lGrilla.EsArbol) && (!lGrilla.AutoFormateable)){
                    //Debo ocultar la opcion de agregar una fila si la tuviese
                    lcontrolRef = "#aref" + pControlName.substring(1);
                    if (qcom_existeControl(lcontrolRef))
                        $(lcontrolRef).show();
                    //si la grilla permite eliminar, debo agregarle esa opcion
                    if (lGrilla.PermBorrar)
                        $(pControlName).igGridUpdating("option", "enableDeleteRow", true);
                    //si la grilla permite editar la celda, debo agregarle esa opcion
                    if (lGrilla.PermEditar)
                        $(pControlName).igGridUpdating("option", "editMode", "cell");
                }
            }

            else
                $(pControlName).prop("disabled", false);
        }
    }
}

function qcom_HabilitarOpcionOptionGroup(pControlName, pValor) {
    var l = $("input[name='" + pControlName + "']");
    $.each(l, function (lClave, lValor) {
        if (lValor.value == pValor)
            qcom_AccionSobreControlAux("#" + lValor.id, "E");
    });
}

function qcom_DeshabilitarOpcionOptionGroup(pControlName, pValor) {
    var l = $("input[name='" + pControlName + "']");
    $.each(l, function (lClave, lValor) {
        if (lValor.value == pValor)
            qcom_AccionSobreControlAux("#" + lValor.id, "D");
    });
}



function qcom_OcultarControlIncrustado(pControlName) {
    qcom_AccionSobreControl("div" + pControlName, "H");
    qevt_AgregarEventoaTmp(pControlName + "_Ocultando", null, true);

}



function qcom_OcultarControl(pControlName) {
    qcom_AccionSobreControl("div" + pControlName, "H");
}

function qcom_OcultarControlBtnAsocGrilla(pControlName) {
    qcom_AccionSobreControl(pControlName, "H");
}

function qcom_OcultarSolapa(pControlName) {
    $("#li" + pControlName).hide();
    var lCantSolapas = gSolapas.length;
    var lEncontre = false;
    for (var i = 0; (i < lCantSolapas) && (!lEncontre) ; i++) {
        if (gSolapas[i].Nombre == pControlName) {
            gSolapas[i].EstaVisible = false;
            lEncontre = true;
        }
    };
    //<li><a id="liSolapa_2" href="javascript:void(0)" class="tablinks">Solapa_2</a></li>
}

function qcom_MostrarControlBtnAsocGrilla(pControlName) {
    qcom_AccionSobreControl(pControlName, "S");
}

function qcom_MostrarSolapa(pControlName) {
    $("#li" + pControlName).show();
    var lCantSolapas = gSolapas.length;
    var lEncontre = false;
    for (var i = 0; (i < lCantSolapas) && (!lEncontre); i++) {
        if (gSolapas[i].Nombre == pControlName)
        {
            gSolapas[i].EstaVisible = true;
            lEncontre = true;
        }
    };
    //<li><a id="liSolapa_2" href="javascript:void(0)" class="tablinks">Solapa_2</a></li>
}

function qcom_MostrarControlIncrustado(pControlName, pParametros) {
    var lVisibleXPais = "true";
    if ($("#div" + pControlName)[0].hasAttribute("VisiblexPais"))
        lVisibleXPais = $("#div" + pControlName)[0].getAttribute("VisiblexPais");
    if (lVisibleXPais == "true")
    {
        qcom_AccionSobreControl("div" + pControlName, "S");
        if (pParametros != "")
            qpopup_AsignarValorParametrosPopup(pParametros, '');
    qevt_AgregarEventoaTmp(pControlName + "_Mostrando", null, true);
    }
}



function qcom_MostrarControl(pControlName) {
    var lVisibleXPais = "true";
    if ($("#div" + pControlName)[0].hasAttribute("VisiblexPais"))
        lVisibleXPais = $("#div" + pControlName)[0].getAttribute("VisiblexPais");
    if (lVisibleXPais == "true") {
        qcom_AccionSobreControl("div" + pControlName, "S");
    }
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

function qcom_CambiarTituloParteSeg(pNombreSeg, pOrigen, pValor) {
    var lNombreCampo = '';
    var lSegmento = qcom_ObtenerSegmento(pNombreSeg);
    if (lSegmento.getCampoCtrl(pOrigen) != '')
        lNombreCampo = lSegmento.getCampoCtrl(pOrigen);
    else
        lNombreCampo = lSegmento.getCampoCtrlSeg(pOrigen);
    var lctrl = gControles[lSegmento.getTabla()][0][lNombreCampo];
    var lNombreCtrl = lctrl.getControl().selector.substring(1, lctrl.getControl().selector.length);
    var lNombreLabel = "#div" + lNombreCtrl;
    $(lNombreLabel)[0].innerText = pValor;
    
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

//function qcom_CompletarOcultosSegmentos() {
function qcom_CompletarOcultosSegmentos(pNombreSegmento) {
    //var lSeg = ObtenerSegmentoPrincipal();
    var lSeg = qcom_ObtenerSegmento(pNombreSegmento);
    for (var j = 1; j <= 8; j++) {
        if ((lSeg.getCampoNCCtrl(j) != '') && (lSeg.getCampoNCCtrlSeg(j) != ''))
            qcom_AsignarValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(j)], qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(j)]), false);
    }   
}


function qcom_CompletarOcultoSegmento(pNombreSegmento, pPosicion) {
    //var lSeg = ObtenerSegmentoPrincipal();
    var lSeg = qcom_ObtenerSegmento(pNombreSegmento);
    if ((lSeg.getCampoNCCtrl(pPosicion) != '') && (lSeg.getCampoNCCtrlSeg(pPosicion) != ''))
        qcom_AsignarValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrlSeg(pPosicion)], qcom_ObtenerValorControl(gControles[lSeg.getTabla()][0][lSeg.getCampoNCCtrl(pPosicion)]), false);
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
function qcom_MostrarReporte(pNombreReporte, pParametros, pMetodoDatos, pMetodoXMLRep) {
    $.ajax({
        type: "POST",
        url: "QEncriptar.ashx",
        data: { Valor: pParametros },
        dataType: "text"
    })
    .done(function (response) {
        var lparamEncriptado = response;
        var lIdSes = sessionStorage.getItem("idses");
        var lancho = $(window).width() * 0.90;
        var lalto = $(window).height() * 0.90;
            var smUrl = "";
            if (pMetodoXMLRep == "")
                smUrl = 'webfrmReport.aspx?Par=' + lparamEncriptado + '&rpt=' + pNombreReporte +
                    '&metdatos=' + pMetodoDatos + '&dlleventos=' + gFormulario.getDLLEventos() +
                    '&claseeventos=' + gFormulario.getClaseEventos() + '&dlleventosesp=' + gFormulario.getDLLEventosEsp() +
                    '&claseeventosesp=' + gFormulario.getClaseEventosEsp() + '&pref=' + lIdSes;
            else {
                var ldataset = qcom_CargarTablasAEnviar("", gEntidad);
                smUrl = 'webfrmReport.aspx?Par=' + lparamEncriptado + '&rpt=' + pNombreReporte +
                    '&metdatos=' + pMetodoDatos + '&metxml=' + pMetodoXMLRep +
                    '&dlleventos=' + gFormulario.getDLLEventos() +
                    '&claseeventos=' + gFormulario.getClaseEventos() +
                    '&dlleventosesp=' + gFormulario.getDLLEventosEsp() +
                    '&claseeventosesp=' + gFormulario.getClaseEventosEsp() +
                    '&pref=' + lIdSes;
            }
            var smArg = 'Reporte' + lparamEncriptado;
            var smFtr = "toolbar=yes,scrollbars=yes,resizable=yes,top=0,left=0,width=" + lancho + ",height=" + lalto;
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
        lResult = lResult.replace('+', '%2B');
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

function qcom_solapaActiva() {
    var lCantSolapas = gSolapas.length;
    var lSolActiva = "";
    if (lCantSolapas == 0) //si la cantidad de solapasa es 0, entonces no hay solapas, hay una unica que es Solapa_Datos
        lSolActiva = 'Solapa_Datos';
    else {
        for (var i = 0; (i < lCantSolapas) && (lSolActiva == "") ; i++) {
        var lNombre = gSolapas[i].Nombre;
        if ($("#li" + lNombre)[0].classList.contains("active")) {
            lSolActiva = lNombre;
        }
    };
    }
    return lSolActiva;
}

/******* Mensajes y  Alertas ********************/
//version Anterior
function qcom_MensajeError(pMensaje) {
    $("#divAlertas").html("<div class='alert alert-danger alert-dismissable' style='padding-top:4px; padding-bottom:4px'>" +
    "<a href='#' class='close' data-dismiss='alert' aria-label='close'>×</a>" +
    "<strong>Error: </strong> " + pMensaje + "</div>");
    $("#divAlertas").show();
}
//

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


function qcom_AlertaErrorQBI() {
    var lEjecutarSiguiente = false;
    var lTipo = 'danger';
    var lTimeout = 0;
    var lMensaje = qrecErrorQBI;
    //antes de mostrar el mensaje, debo agregar una accion. para que la ejecutar siguiente, sea eliminada y vuelva a ejecutar la misma accion que dio error
    if (gEventosTmp.length > 0) {
        $('#divCargando').addClass('show');
        gEventosTmp[0].Acciones.unshift(new qevt_accion("0", "A", null, ""));
        //pMensaje = "Intentando reestablecer la conexión con el servidor....";
        lEjecutarSiguiente = true;
        lTipo = 'dangerQBI';
        lTimeout = 10000;
        lMensaje = qrecErrorQBIConAcciones;
    }
    
    var prom = qBSAlert({
        messageText: lMensaje,
        alertType: lTipo,
        timeout: lTimeout,
    }).done(function (e) {
        $('#divCargando').removeClass('show');
        if (lEjecutarSiguiente)
            qevt_EjecutarSiguiente();
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            $('#divCargando').removeClass('show');
            qcom_Alerta(thrownError, 'danger', null);
    });

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




function qcom_AlertaFinSesion(pMsgAdicional) {
    var prom = qBSAlert({
        messageText: qrecSesionExpirada + " - " + pMsgAdicional,
        alertType: 'danger'
    }).done(function (e) {
        var lInstalacion = sessionStorage.getItem("idinst");
		//Inicio Grupos de Instalaciones        
        var lGrpInst = sessionStorage.getItem("grpinst");
        //Fin Grupos de Instalaciones
        var lEmpFija = sessionStorage.getItem("empfija");
        var lSitio = sessionStorage.getItem("sitio");
        $('#divCargando').addClass('show');
        $.ajax({
            type: "POST",

            url: lSitio + "AjaxHandler/FormAcciones.ashx?Accion=OI",
            //Inicio Grupos de Instalaciones        
            //data: { pInstalacion: lInstalacion, pEmpFija: lEmpFija },
            data: { pGrupoInstalacion: lGrpInst, pInstalacion: lInstalacion, pEmpFija: lEmpFija },
            //Fin Grupos de Instalaciones        
            //contentType: "application/json; charset=utf-8",
            dataType: "json"
        })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        if (lGrpInst != "")
            window.open('Login.aspx?sit=' + lGrpInst, '_parent');
        else if (lInstalacion != "")
            window.open('Login.aspx?sit=' + lInstalacion, '_parent');
        else 
        window.open('Login.aspx', '_parent');
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        if (lGrpInst != "")
            window.open('Login.aspx?sit=' + lGrpInst, '_parent');
        else if (lInstalacion != "")
            window.open('Login.aspx?sit=' + lInstalacion, '_parent');
        else
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
    //var gSesionValida = false;
    //window.open('webfrmError.aspx?error=1', '_top');
    //if (typeof qevt_VaciarEventosTmp !== 'undefined')
    //    qevt_VaciarEventosTmp();
    qcom_AlertaErrorQBI();
}

function qcom_AlertaErrorNoControlado(pMsgError) {
    gSesionValida = false;
    window.open('webfrmError.aspx?error=' + pMsgError, '_top');
}

function qcom_AlertaSinPermisos() {
    $('#btnNuevo').addClass('hidden');
    $('#btnGuardar').addClass('hidden');
    $('#btnPostear').addClass('hidden');
    $('#btnEliminar').addClass('hidden');
    $('#btnRptVer').addClass('hidden');
    $('#btnRptImprimir').addClass('hidden');
    $('#btnRptPdf').addClass('hidden');
    $('#btnRptXls').addClass('hidden');

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
                            //$('#btnGuardarF')[0].disabled = true;
                            $('#btnPostear')[0].disabled = true;
                            //$('#btnPostearF')[0].disabled = true;
                            //Limpio las solapas para que no figuren como activadas
                            //ahora lo hace el valor_modif
                            //qcom_InicSolapasActivadas(false);
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
    else  {
        gCtrlCambioCont = true;
        gTieneSinGuardar = false;
        $('#btnGuardar')[0].disabled = true;
        //$('#btnGuardarF')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
        //$('#btnPostearF')[0].disabled = true;
        //Limpio las solapas para que no figuren como activadas
        //Ahora lo hace el valor_Modif
        //qcom_InicSolapasActivadas(false);
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
        //$('#btnGuardarF')[0].disabled = true;
            $('#btnPostear')[0].disabled = true;
        //$('#btnPostearF')[0].disabled = true;
    }
}


function qcom_DeshabilitoGuardarxInputs() {
    //if ($('#btnGuardar')[0].disabled == false) {
    if (!gCtrlCambioCont) {
        gCtrlCambioCont = true;
        //gTieneSinGuardar = true;
        $('#btnGuardar')[0].disabled = true;
        //$('#btnGuardarF')[0].disabled = true;
        $('#btnPostear')[0].disabled = true;
        //$('#btnPostearF')[0].disabled = true;
    }
}




/********************** Habilitar deshabilitar guardar *************/
function qcom_HabilitoGuardar() {
    //    if (gCtrlCambioCont) {
    gCtrlCambioCont = false;
    $('#btnGuardar')[0].disabled = false;
    //$('#btnGuardarF')[0].disabled = false;
    $('#btnPostear')[0].disabled = false;
    //$('#btnPostearF')[0].disabled = false;
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


function qcom_RecrearMaskEditor(pControl, pMascara) {
    if (pMascara == "")
        pMascara = $(pControl)[0].getAttribute("MaskDefecto");
    var leditor = $(pControl);
    var options = leditor.data("igMaskEditor").options;
    // check for focus
    if (options.inputMask != pMascara) {
        var isFocused = (document.activeElement.id === leditor[0].id);
        var lValorAnt = $(pControl)[0].getAttribute("ValorAnteMask").replace(/\-|\./g, '').trim();
        //var value = leditor.igMaskEditor("value");        
        var lMaskDefault = $(pControl)[0].getAttribute("MaskDefecto");
        leditor.igMaskEditor("destroy");
    options.inputMask = pMascara;
        options.value = lValorAnt;
        leditor.igMaskEditor(options);
        if (isFocused)
            $(pControl).focus();
        $(pControl)[0].setAttribute("ValorAnteMask", leditor.igMaskEditor("value"));
        $(pControl)[0].setAttribute("MaskDefecto", lMaskDefault);
    }
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
    else if (pError.startsWith('error:qbi')) {  
        qcom_AlertaErrorServicio();
    }
    else {
        if (typeof qevt_VaciarEventosTmp !== 'undefined')
            qevt_VaciarEventosTmp();
        qcom_Alerta(pError.substring(6), 'danger', null);
    }
}


function qcom_TratarShortCutGrillas(pShortCut) {
    var lPopupVis = "";
    if (gPilaPPs.length > 0) //si hay popup de edicion de grillas abiertos, busco el ultimo
    {
        lPopupVis = gGruposGrilla[gPilaPPs[gPilaPPs.length - 1]].getNombreControl();
    }
    else //obtengo la solapa activa
        lPopupVis = qcom_solapaActiva();
    if (lPopupVis != "")
    {
        var lgrillaShortCut = "";
        //busco cual es la grilla que está contenida en ese popup, y que conicida con el nro de shorcut
        $.each(gGrillasAux, function (lClaveGrilla, lGrilla) {
            if ((gGrillas[lGrilla].Contenedor == lPopupVis) && (gGrillas[lGrilla].ShortCut == pShortCut.toUpperCase())) {
                lgrillaShortCut = lGrilla;
            }
        })
        if (lgrillaShortCut != "")
            qevt_Grilla_NuevaFila(lgrillaShortCut, true);
    }
}


function qcom_TratarEnterEnPPGrilla() {
    var ltabla = "";
    if (gPilaPPs.length > 0) //si hay popup de edicion de grillas abiertos, busco el ultimo
    {
        ltabla =  gPilaPPs[gPilaPPs.length - 1];
        //Ejecuto el aceptar del popup abierto
        if (($("#btnAceptargrd2" + ltabla) != undefined) && ($("#btnAceptargrd" + ltabla) != undefined)) {
            if ($("#btnAceptargrd" + ltabla).is(":Visible")) {
                $("#btnAceptargrd2" + ltabla).focus();
            }
        }
    }
}

function qcom_TratarShortCutSolapas(pShortCut) {
    var lCantSolapas = gSolapas.length;
    if (lCantSolapas > 0) {
        var lshortCut = parseInt(pShortCut);
        var lEncontre = false;
        var lNombre = "";
        for (var i = 0; (i < lCantSolapas) && (!lEncontre); i++) {            
            lNombre = gSolapas[i].Nombre;
            if ($("#li" + lNombre).is(":visible")) {
                lshortCut--
                if (lshortCut == 0)
                    lEncontre = true;
            }
        };
        if (lEncontre) //entonces la activo
        {
            qcom_mostrarSolapa(lNombre);
        }
    }
}

function qcom_ObtenerSesStrg(pInicializar) {
    //if (((sessionStorage.getItem("idses") == undefined) || (sessionStorage.getItem("idses") == null)) && pInicializar) {

        var lHoraActual = new Date();
        var lHora = lHoraActual.getHours();
        var lMinutos = lHoraActual.getMinutes();
        var lSegundos = lHoraActual.getSeconds();
        var lMiliSeg = lHoraActual.getMilliseconds();
        var lHoraStr = ('0' + lHora).slice(-2) + ('0' + lMinutos).slice(-2) +
            ('0' + lSegundos).slice(-2) + ('00' + lMiliSeg).slice(-3);

        sessionStorage.setItem("idses", lHoraStr);
    //}
    return sessionStorage.getItem("idses");
}


function qcom_SetearEnServerSesStrg(pSoloId, pIraLogin, pCallback) {
    if ((sessionStorage.getItem("idses") != undefined) && (sessionStorage.getItem("idses") != null)) {
        var lIdSes = sessionStorage.getItem("idses");
        var lIdInst = sessionStorage.getItem("idinst");
        //Inicio Grupos de Instalaciones
        var lGrpInst = sessionStorage.getItem("grpinst");
        //Fin Grupos de Instalaciones
        var lEmpFija = sessionStorage.getItem("empfija");
        var lSitio = sessionStorage.getItem("sitio");
        $.ajax({
            type: "POST",
            //url: lSitio + "/feAjaxComunes.aspx/SetearSesStrg",
             url: lSitio + "AjaxHandler/FormAcciones.ashx?Accion=SS",
//Inicio Grupos de Instalaciones            
			//data: { pIdSesion: lIdSes, pInstalacion: lIdInst, pSoloIdSes: pSoloId, pIngresoDirecto: false, pEmpFija: lEmpFija },
            data: { pIdSesion: lIdSes, pGrupoInstalacion: lGrpInst, pInstalacion: lIdInst, pSoloIdSes: pSoloId, pIngresoDirecto: false, pEmpFija: lEmpFija },
//Fin Grupos de Instalaciones            
            //contentType: "application/json; charset=utf-8",
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
            url: gConfiguracion.getSitio() + "AjaxHandler/FormAcciones.ashx?Accion=CVS",
            data: { pIdSesion: lIdSes, pVariable: pVariable, pValor: pValor },
            //contentType: "application/json; charset=utf-8",
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



function qcom_DescargarArchivo(pNombreControl, pPopupDescarga) {
    var a = $("#ref" + pNombreControl)[0];
    if (a == "")
        qcom_Alerta(qrecNoHayArchivoXaDescarga, 'danger', null);
    else {
        //var lBase64 = a.href.startsWith("data:");
        //if (lBase64 && (window.navigator && window.navigator.msSaveBlob)) {
        //    download(a.href, a.download, "application/octet-stream");
        //}
        //else
        if (!pPopupDescarga)
            a.click();
        else {
            $('#divDownLoad').append('<a href="' + a.href + '" download="' + a.download + '" class="quasar-ahref-descarga" >' + a.innerText + '</a><br><br>');
            $("#divModalDownload").modal({ backdrop: "static" });
            $("#divModalDownload").draggable({
                handle: ".modal-header"
            });
            $("#divModalDownload").unbind('hidden.bs.modal');
            $("#divModalDownload").on('hidden.bs.modal', function (e) {
                $('#divDownLoad').empty();
            })
        }
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
        return pDatosjson;
        //Debo pasar a gEntidad todas menos las que no se actualizan
    else {
        var lEntidadAyuda = pDatosjson;
        var lstTablaaRef = pTablasARefrescar.split('|');
        for (var i = 0; i < lstTablaaRef.length; i++) {
            pEntidadDS[lstTablaaRef[i]] = qcom_Clonar(lEntidadAyuda[lstTablaaRef[i]]);
            //si hay tablas autoformateables, debo tambien completar por las las fmt (son tablas que se crean en el QBI y contienen el formato de la autoformateable)
            if (gTieneGrillasAutoForm)
            {
                if (lEntidadAyuda[lstTablaaRef[i]+"fmt"] != undefined)
                    pEntidadDS[lstTablaaRef[i] + "fmt"] = qcom_Clonar(lEntidadAyuda[lstTablaaRef[i] + "fmt"]);
            }
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
                qprin_CrearSolapa("webfrmBasico.aspx?frm=" + lFormulario + "&pref=" + lIdSes + "&pI=" + lParametros + "&pS=f&pEP=f", lTitulo);
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
            //url: gConfiguracion.getSitio() + "/feAjaxComunes.aspx/RegistrarCambiosEstadoFavorito",
            url: gConfiguracion.getSitio() + "AjaxHandler/FormAcciones.ashx?Accion=CEF",
            data: { pFavorito: lFavorito, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes },
            //contentType: "application/json; charset=utf-8",
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
                   qcom_TratarError(response.d);
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


function qcom_EliminarSegmento(pControl_Id, pSegmento_Id) {
    
    var lSeg = qcom_ObtenerSegmento(pControl_Id);
    if ((lSeg.getIdSeg() != pSegmento_Id)  && (pSegmento_Id != "")){

        $('#divCargando').addClass('show');
        var lIdSes = sessionStorage.getItem("idses");
        var lData = {
            pIdSes: lIdSes, pFormulario: gConfiguracion.getFormulario(),
            pControl: pControl_Id, pSegmento: pSegmento_Id
        };

        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + "AjaxHandler/CambioSegmento.ashx",
            data: lData,
            dataType: "json"
        })
            .done(function (msg) {
                $('#divCargando').removeClass('show');
                if (msg.e == undefined) {
                    if (msg.d != "") {
                        //Acá ya elimino la configuración anterior del segmento, porque ya estoy seguro que tengo la nueva
                        $("#div" + pControl_Id).empty();
                        //$("#" + pControl_Id + "_MostrarLupa").remove();
                        // si es el principal debo eliminar la primera Key
                        if (lSeg.getPrincipal())
                            gCamposClaves.splice(0, gCamposClaves.length);
                        qcom_InicializarSegmento(pControl_Id);

                        //A partir de ahora armo el segmento con la nueva configuracion
                        $("#div" + pControl_Id).append(msg.d);
                        gtmpFnc = new Function(msg.o);
                        gtmpFnc();
                        gtmpFnc2 = new Function(msg.f);
                        gtmpFnc2();
                        gtmpFnc3 = new Function(msg.c);
                        gtmpFnc3();
                    }
                    qevt_EjecutarSiguiente();
                }
                else
                    qcom_TratarError(msg.e);
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                // aj dic 2016
                qevt_VaciarEventosTmp();
                $('#divCargando').removeClass('show');
                //qcom_Alerta(xhr.responseText, 'danger', null);
                qcom_Alerta(thrownError, 'danger', null);
            });
    }
    else
        qevt_EjecutarSiguiente();
}

function qcom_CambiarEstiloLabel(pControl, pEstilo) {

    
    //debo verificar si es un label o un checkbox
    if(qcom_existeControl('#lbl' + pControl)) //si es un label asociado a un check box
    {
        $('#lbl' + pControl).removeClass(); //elimina todas
        $('#lbl' + pControl).addClass('quasar-checkbox-label');
        if (pEstilo != "")
            $('#lbl' + pControl).addClass(pEstilo);
    }
    else if (qcom_existeControl('#' + pControl)) //si es un label
    {
        $('#' + pControl).removeClass(); //elimina todas
        if (pEstilo != "")
            $('#' + pControl).addClass(pEstilo);
    }
}

function qcom_MostrarLinkAyuda(pCodigoLink) {
    $('#divCargando').addClass('show');
    var lIdSes = sessionStorage.getItem("idses");

    var lData = {
        pCodigo: pCodigoLink, pFormulario: gConfiguracion.getFormulario(), pIdSes: lIdSes
    };


    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/ObtenerLinkAyuda.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                //var lValorCond = JSON.parse(msg.d);
                var lValorCond = msg.d;
                if (lValorCond == "") {
                    qcom_Alerta("El código (" + pCodigoLink + ") no tiene link asociado", 'danger', null);
                }
                else {
                    var lancho = $(window).width() * 0.90;
                    var lalto = $(window).height() * 0.90;
                    smUrl = lValorCond;
                    smFtr = "toolbar=yes,scrollbars=yes,resizable=yes,top=10,left=10,width=" + lancho + ",height=" + lalto;
                    window.open(smUrl, '_blank', smFtr);
                }

                               
                //qevt_EliminarNodosCond(lValorCond);
                //qevt_EjecutarSiguiente();

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


function qcom_EsEdge() {
    var lUsrAg = navigator.userAgent;
    return (lUsrAg.indexOf("Edge") > -1);
}

function qcom_EsChrome() {
    var sUsrAg = navigator.userAgent;

    //// The order matters here, and this may report false positives for unlisted browsers.
    //if (sUsrAg.indexOf("Firefox") > -1) {
    //    sBrowser = "Mozilla Firefox";
    //    // "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:61.0) Gecko/20100101 Firefox/61.0"
    //} else if (sUsrAg.indexOf("SamsungBrowser") > -1) {
    //    sBrowser = "Samsung Internet";
    //    // "Mozilla/5.0 (Linux; Android 9; SAMSUNG SM-G955F Build/PPR1.180610.011) AppleWebKit/537.36 (KHTML, like Gecko) SamsungBrowser/9.4 Chrome/67.0.3396.87 Mobile Safari/537.36
    //} else if (sUsrAg.indexOf("Opera") > -1 || sUsrAg.indexOf("OPR") > -1) {
    //    sBrowser = "Opera";
    //    // "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 OPR/57.0.3098.106"
    //} else if (sUsrAg.indexOf("Trident") > -1) {
    //    sBrowser = "Microsoft Internet Explorer";
    //    // "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; Zoom 3.6.0; wbx 1.0.0; rv:11.0) like Gecko"
    //} else if (sUsrAg.indexOf("Edge") > -1) {
    //    sBrowser = "Microsoft Edge";
    //    // "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36 Edge/16.16299"
    //} else if (sUsrAg.indexOf("Chrome") > -1) {
    //    sBrowser = "Google Chrome or Chromium";
    //    // "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Ubuntu Chromium/66.0.3359.181 Chrome/66.0.3359.181 Safari/537.36"
    //} else if (sUsrAg.indexOf("Safari") > -1) {
    //    sBrowser = "Apple Safari";
    //    // "Mozilla/5.0 (iPhone; CPU iPhone OS 11_4 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1 980x1306"
    //} else {
    //    sBrowser = "unknown";
    //}

    //alert("You are using: " + sBrowser);

    return ((!qcom_EsEdge()) && (sUsrAg.indexOf("Chrome") > -1));

}

function qcom_ObtenerSODispositivo() {
    var luserAgent = window.navigator.userAgent,
        lplataforma = window.navigator.platform,
        lmacosPlataformas = ['Macintosh', 'MacIntel', 'MacPPC', 'Mac68K'],
        lwindowsPlataformas = ['Win32', 'Win64', 'Windows', 'WinCE'],
        liosPlataformas = ['iPhone', 'iPad', 'iPod'],
        los = null;

    if (lmacosPlataformas.indexOf(lplataforma) !== -1) {
        los = 'MacOS';
    } else if (liosPlataformas.indexOf(lplataforma) !== -1) {
        los = 'iOS';
    } else if (lwindowsPlataformas.indexOf(lplataforma) !== -1) {
        los = 'Windows';
    } else if (/Android/.test(luserAgent)) {
        los = 'Android';
    } else if (/iPhone/.test(luserAgent)) {
        los = 'iOS';
    } else if (!os && /Linux/.test(lplataforma)) {
        los = 'Linux';
    }

    return los;
}

function qcom_CerrarFormActual() {
    $(window)[0].parent.qprin_CerrarFormulario(null);
}

function qcom_CerrarFormActualEnPopup() {
    $(window)[0].parent.$('#divModalForm').modal('hide');
}


function qcomunes_PartesSegmentosUbicacion(pAncho) {

    var lPartesSegVar = $(".quasar-box-segm-variable");
    for (var i=0; i<lPartesSegVar.length; i++)
    {
        if ($("#" + lPartesSegVar[i].id).data("ancho") + $("#" + lPartesSegVar[i].id).data("ancho-total") > (pAncho-20))
        {
            //verifico si es el ultimo control
            if ($("#" + lPartesSegVar[i].id).data("ancho") + $("#" + lPartesSegVar[i].id).data("ancho-parcial") > (pAncho - 20))
                $("#" + lPartesSegVar[i].id).width("calc(100% - 25px");
            else
                $("#" + lPartesSegVar[i].id).width("calc(100% - " + $("#" + lPartesSegVar[i].id).data("ancho-parcial") + "px)");
        }
        else
            $("#" + lPartesSegVar[i].id).width("calc(100% - " + $("#" + lPartesSegVar[i].id).data("ancho-total") + "px)");
    }
}

function qcom_HabilitarCopiarContenido(pNombreControl) {

    $("#div" + pNombreControl).unbind("copy");

}

function qcom_DeshabilitarCopiarContenido(pNombreControl) {
    $("#div" + pNombreControl).unbind("copy");
    $("#div" + pNombreControl).bind("copy", function (e) {
        e.preventDefault();
    });

}

function qcom_CambiarVisibilidadBtnPegar(pMostrar) {
       
    if (pMostrar)
        $("#btnPegar").show();
    else
        $("#btnPegar").hide();
}


function qcom_CopiarFormulario() {
    try {
        qcom_ControlesaTablasPlanas();
        var ljsonEntidad = JSON.stringify(qcom_Clonar(gEntidad));
        $.ajax({
            type: "POST",
            url: "QEncriptar.ashx",
            data: { Valor: ljsonEntidad },
            dataType: "text"
        })
        .done(function (response) {
            lparamEncriptado = response;
            $(window)[0].parent.qprin_CopiarfrmaPortapapel(lparamEncriptado, gConfiguracion.getFormulario());
        qcom_MensajeExito(qrecMensajeCopiaFrmOK);
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            //alert(xhr.status);
            qcom_MensajeError(thrownError);
        });
    }
    catch (err) {
        qcom_Alerta(qrecMensajeCopiaFrmNoOK, 'danger', null);
    }
}




function qcom_PegarFormulario(pDatosDesc) {
    $('#divCargando').addClass('show');
    var lEntidadEncptd = $(window)[0].parent.qprin_CopiarPortapapelaFrm(gConfiguracion.getFormulario());
    if (lEntidadEncptd != null) {
        var lIdSes = sessionStorage.getItem("idses");
        var lData = {
            pTieneDsEsp: gTieneDsEsp, pTablasPlanas: gTablasPlanas.join('|'), pTieneTablaAutoFormateable: gTieneGrillasAutoForm, 
            pEntidadAPegar: lEntidadEncptd, pDllCommon: gFormulario.getDLLCommon(), pClaseCommon: gFormulario.getClaseCommon(),
            pDllCommonEsp: gFormulario.getDLLCommonEsp(), pClaseCommonEsp: gFormulario.getClaseCommonEsp(), pIdSes: lIdSes
        };
        $.ajax({
            type: "POST",
            url: gConfiguracion.getSitio() + "AjaxHandler/ObtenerFrmaPegar.ashx",
            data: lData,
            dataType: "json"
        })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                qcom_HabilitarGuardar();
                gEntidad = qcom_CargarTablasARefrescar("", msg, gEntidad);
                //Blanqueo Clave
                $.each(gControles['Principal'][0], function (lClave, lValor) {
                    if (($.inArray(lClave, gCamposClaves) > -1) || qcom_CampoClaveAsocaSegmento(lClave)) {
                        gEntidad['Principal'][0][lClave] = qcom_ObtenerValorControl(gControles['Principal'][0][lClave]);//lValor.getDefecto();
                    }
                });
                var lCompo = pDatosDesc.split('|');
                if (lCompo[0].trim() != "")
                    gEntidad['Principal'][0][lCompo[0]] = lCompo[1];
                //Cambio el valor de las propiedades, posteado y existe
                if (gEntidad['Principal'][0]['Posteado'] != undefined)
                    gEntidad['Principal'][0]['Posteado'] = false;
                if (gEntidad['Principal'][0]['Existe'] != undefined) 
                    gEntidad['Principal'][0]['Existe'] = false;
                gTieneSinGuardar = true;
                qcom_CargarControlesFormulario("", true, true);
                qevt_AgregarEventoaTmp("Pegando_Form", null, false);
                qevt_EjecutarSiguiente();
            }
            else
                qcom_TratarError(msg.e);
         })
        .fail(function (xhr, ajaxOptions, thrownError) {
            //alert(xhr.status);
            qcom_MensajeError(thrownError);
        });
    }
    else
        qevt_VaciarEventosTmp();

}

function qcom_VerifPuedePegarFrm() {
    try {
        if (gConfiguracion.getFormulario()  == $(window)[0].parent.qprin_ObtenerNombreFrmPortaPapel())
            qcom_CambiarVisibilidadBtnPegar(true);
    }
    catch (err) {
    }
}


function qcom_ObtenerDescPKAntesPegar() {
    var lValorDesc = " ";
    var lCampoDesc = " ";
    if (gCamposClaves.length == 1) {
        var lNombreCtrlDesc = "#" + gControles['Principal'][0][gCamposClaves[0]].getControlConjunto() + "_d";
        if (qcom_existeControl(lNombreCtrlDesc))
            lValorDesc = $(lNombreCtrlDesc).igTextEditor()[0].value;

        $.each(gControles['Principal'][0], function (lClave, lValor) {
            if (gControles['Principal'][0][lClave] != null) 
                if (lNombreCtrlDesc == gControles['Principal'][0][lClave].getControl().selector)
                    lCampoDesc = lClave;
        });
    }
    return lCampoDesc + "|" + lValorDesc;
}

function qcom_QuitarCortina() {
    //Inicio - 14/01/2021 - Se modificó para que en lugar de eliminar todos, elimine solo el último
    //Se supone que el último es el de mas arriba
    ///$('.modal-backdrop.fade.in').remove();
    var llst = $('.modal-backdrop.fade');
    if (llst.length > 0) {
        $('.modal-backdrop.fade')[llst.length - 1].remove();
        gEventosTmp = [];
    }
    //Fin - 14/01/2021
}

function qcom_Navegador_Permite_Pegar() {

    navigator.permissions.query({ name: 'clipboard-read' }).then(function (result) {
        qevt_EliminarNodosCond('S');
        qevt_EjecutarSiguiente();
    })
    .catch(function (result) {
        qevt_EliminarNodosCond('N');
        qevt_EjecutarSiguiente();
    }) 
}

function qcom_FocoEnCtrlOculto(event, pNombreCtrlOculto, pTablaGrilla) {
    var lCtrlAsoc = pNombreCtrlOculto.substring(2, pNombreCtrlOculto.length);
    var lCtrAnt = "";
    if (event.relatedTarget != null)
        lCtrAnt = event.relatedTarget.id;
    if (lCtrAnt != lCtrlAsoc) {
    if (gEventosTmp.length == 0)
        $("#" + lCtrlAsoc).focus();
    else
        gCtrlProxFoco = "#" + lCtrlAsoc;
    }
    else if (pTablaGrilla != "") {
        //Busco el control anterior
        var x = $("#divGrupogrd" + pTablaGrilla)[0].querySelectorAll("[id^='o_']");
        var lEncontre = false;
        gCtrlProxFoco = "";
        for (var i = 1; (i < x.length) && (!lEncontre); i++) {
            if (x[i].id == pNombreCtrlOculto) {
                lEncontre = true;
                if (gEventosTmp.length == 0)
                    $("#" + x[i-1].id).focus();
                else
                    gCtrlProxFoco = "#" + x[i-1].id;
            }
        }

    }

}

function qcom_KeydownCtrolOculto(event) {
    event.preventDefault();
}

function qcom_BlurCtrolOculto() {
    gCtrlProxFoco = "";
}


function qcom_IniciarTimer(pTimer, pIntervalo, pFuncion)
{
    if (pTimer == null)
        pTimer = setInterval(pFuncion, pIntervalo);
    return pTimer;
}

function qcom_DetenerTimer(pTimer) {
    if (pTimer != null)
        clearTimeout(pTimer);
    pTimer = null;
    return pTimer;
}

function qcom_ReproducirAudio(pArchivo) {
    var audio = new Audio(pArchivo);
    audio.play();
}

function qcom_ObtenerValorEnEquipo(pNombre, pfnCallback) {
    $('#divCargando').addClass('show');
    var lData = {
        pTipoOperacion: 'O', pNombre: pNombre
    };

    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/AcCookies.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
        .done(function (msg) {
            $('#divCargando').removeClass('show');
            if (msg.e == undefined) {
                //var lValorCond = JSON.parse(msg.d);
                var lValor = msg.d;
                if (pfnCallback != null)
                    pfnCallback(lValor);
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

function qcom_EstablecerValorEnEquipo(pNombre, pValor) {
    $('#divCargando').addClass('show');
    var lData = {
        pTipoOperacion: 'A', pNombre: pNombre, pValor: pValor
    };

    $.ajax({
        type: "POST",
        url: gConfiguracion.getSitio() + "AjaxHandler/AcCookies.ashx",
        data: lData,
        //contentType: "application/json; charset=utf-8",
        dataType: "json"
    })
    .done(function (msg) {
        $('#divCargando').removeClass('show');
        if (msg.e == undefined) {
            //var lValorCond = JSON.parse(msg.d);
            var lValorOper = msg.d;
            if (lValorOper == "") {
                qevt_VaciarEventosTmp();
                qcom_Alerta("No se pudo establecer el valor de la cookie", 'danger', null);
            }
            else {
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


function qcom_CrearDivMensajeItera() {
    if (!qcom_existeControl('#divMensajeItera'))
        $("body").append('<div id="divMensajeItera" data-backdrop="static" data-keyboard="false"><div class="alert alert-info" role="alert" style="text-align: center; width: 100%"><span>Ejecutando...</span></div></div>');
}

function qcom_MostrarDivMensajeItera(pMensaje) {
    $('#divMensajeItera span').text(pMensaje);
    $('#divMensajeItera').addClass('show');
    qevt_EjecutarSiguiente();
}

