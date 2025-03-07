var QLupaAdv_dialogolupa = null;
var QLupaAdv_tituloLupa = '';
var QLupaAdv_grillaLupa = null;
var QLupaAdv_Identidad = null;
var QLupaAdv_EsEntidadDelForm = false;
var QLupaAdv_CampoCodigo = '';
var QLupaAdv_CampoDescripcion = '';
var QLupaAdv_TablaFE = '';
var QLupaAdv_CamposRet = null;
var QLupaAdv_CamposVisibles = null;
var QLupaAdv_FilaSeleccionada = null;
var QLupaAdv_FiltrosOcultos = '';
var QLupaAdv_CantRegPorPagina = 50;
var QLupaAdv_CantRegistrosTotal = 0;
var QLupaAdv_MaximaCantPermitida = 70;
var QLupaAdv_Inicializada = false;
var QLupaAdv_GrillaCreada = false;
var QLupaAdv_AdicCampos = '';
var QLupaAdv_AdicControles = '';
var QLupaAdv_AdicParametros = '';
var QLupaAdv_PrimColVisible = -1;
var QLupaAdv_Estructura = null;
var QLupaAdv_Formulario = '';
var QLupaAdv_TituloForm = '';
var QLupaAdv_PrimEditor = null;
var QLupaAdv_SelXTecladoProcesado = false;
var QLupaAdv_Navegador = { Datos: null, Primero: "", Ultimo: "" };
var QLupaAdv_AnchoTotal = 0;
var QLupaAdv_PrimeraVez = true;
var QLupaAdv_EsBotonLupa = 0; //0- No es boton Lupa, 1-Boton Lupa concatena contenido, 2-Boton Lupa reemplaza contenido
//Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
var QLupaAdv_FnAccion = null;
var QLupaAdv_FnLeave = '';
//Fin 06-03-2021 

//Mètodo invocado al perder el foco del control del codigo de la lupa
function QLupaAdv_ObtenerDescripciones(pIdEntidad, pTablaFE, pCampoCodigo, pCampoDescripcion, pFiltros, pCamposAdic, pControlesAdic, pAdicParametros, pPermiteNoExistentes, pEsLaEntidadDelForm) {
    var lCodigo;
    lCodigo = qcom_ObtenerValorControl(gControles[pTablaFE][0][pCampoCodigo]);
    lFiltrosSP = qcom_ObtenerValorParametrosFiltro(pFiltros);
    lAdicParametros = "";
    if (pAdicParametros != "") {
        var lFilas = pAdicParametros.split("@");
        var lSepar = "";
        for (var i = 0; i < lFilas.length ; i++) {
            var lParametro = lFilas[i].split(";");
            lAdicParametros += lSepar;
            lAdicParametros += lParametro[0] + ";";
            lAdicParametros += qcom_ObtenerValorParametroFiltro(lParametro[1]);
            lSepar = '|';
        }
    }
    var lIdSes = sessionStorage.getItem("idses");
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: "AjaxHandler/QLupaAdvDatos.ashx?TipoConsulta=Desc",
        data: { Identidad: pIdEntidad, Valor: lCodigo, filtroSP: lFiltrosSP, CamposAdicionales: pCamposAdic, AdicParametros: lAdicParametros, PermiteNoExistentes: pPermiteNoExistentes, IdSes: lIdSes },
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

                var lValor = "";
                if ((response.e == "1") || (response.e == "")) {
                    lValor = response.d;
                    if ((pEsLaEntidadDelForm) && (response.e == "1")) {
                        gTieneSinGuardar = false;
                        //Limpio las solapas para que no figuren como activadas
                        qcom_InicSolapasActivadas(false);
                    }
                    else
                        gTieneSinGuardar = true;
                }
                else {
                    qcom_AlertaCompleto(response.d, 'danger', null, 3000, gControles[pTablaFE][0][pCampoCodigo].getControl());
                }
                if (pCampoDescripcion != '')
                    qcom_AsignarValorControl(gControles[pTablaFE][0][pCampoDescripcion], lValor, false);
                //si retorna campos adicionales
                if (pControlesAdic != "") {
                    var lAdicionales = pControlesAdic.split("|");
                    var lValores = response.a.split("|");
                    for (var j = 0; j < lAdicionales.length; j++) {
                        var lCampoCtrl = lAdicionales[j].split(":");
                        var lValorAdic = '';
                        if (lValores.length > j)
                            lValorAdic = lValores[j];
                        if (lCampoCtrl.length > 1)
                            qcom_AsignarValorControl(gControles[lCampoCtrl[0]][0][lCampoCtrl[1]], lValorAdic, false);
                        else if ((lCampoCtrl.length == 1) && (lCampoCtrl[0].startsWith("var_"))) {
                            gVariables[lCampoCtrl[0]] = lValorAdic;
                        }
                        else if (lCampoCtrl.length == 1)//si es uno, es porque es una parte de un segmento
                        {
                            var lCSeg = lCampoCtrl[0].split("[");
                            if (lCSeg.length == 2) {
                                qcom_SetearValorParteSeg(lCSeg[0], gOrigenesSeg[lCSeg[1].substring(0, lCSeg[1].length - 1)], lValorAdic);
                            }
                        }

                    }
                }
                qevt_EjecutarSiguiente();
            }
        })
        .fail(function (xhr, ajaxOptions, thrownError) {
            qevt_VaciarEventosTmp();
            gBotonAceptarGrilla = "";
            $('#divCargando').removeClass('show');
            qcom_Alerta(thrownError, 'danger', null);
        });
}



function QLupaAdv_ObtenerCodigoVecino(pCodigo, pCodAObtener) {
    var lIndex = -1;
    var lCodigoNuevo = "";
    if (QLupaAdv_Navegador.Datos != null) {
        for (var i = 0; (i < QLupaAdv_Navegador.Datos.length) && (lIndex == -1); i++) {
            if (QLupaAdv_Navegador.Datos[i].Codigo == pCodigo) {
                //lEncontre = true;
                lIndex = i;
            }
        }
    }
    if (lIndex != -1) {
        if ((pCodAObtener == -1) && (lIndex > 0))
            lCodigoNuevo = QLupaAdv_Navegador.Datos[lIndex - 1].Codigo
        else if ((pCodAObtener == 1) && (lIndex < QLupaAdv_Navegador.Datos.length - 1))
            lCodigoNuevo = QLupaAdv_Navegador.Datos[lIndex + 1].Codigo
    }
    else if (QLupaAdv_Navegador.Datos != null)
    //sino lo encuentro, debo retornar el mas cercano, el anterior o posterior de acuerdo a lo que esté buscando
    //siempre y cuando el codigo esté entre el primero y el ultimo de la lista actual
    {
        var lPrimLista = "";
        var lUltLista = "";
        if (QLupaAdv_Navegador.Datos.length > 0) {
            lPrimLista = QLupaAdv_Navegador.Datos[0].Codigo;
            lUltLista = QLupaAdv_Navegador.Datos[QLupaAdv_Navegador.Datos.length - 1].Codigo;
            if ((lPrimLista < pCodigo) && (lUltLista > pCodigo)) {
                if (pCodAObtener == -1) {
                    var lEncontre = false
                    for (var i = QLupaAdv_Navegador.Datos.length-1; (i >= 0 ) && (!lEncontre); i++) {
                        if (QLupaAdv_Navegador.Datos[i].Codigo < pCodigo) {
                            lEncontre = true;
                            lCodigoNuevo = QLupaAdv_Navegador.Datos[i].Codigo;
                        }
                    }
                }
                else {
                    var lEncontre = false
                    for (var i = 0; (i < QLupaAdv_Navegador.Datos.length) && (!lEncontre); i++) {
                        if (QLupaAdv_Navegador.Datos[i].Codigo > pCodigo) {
                            lEncontre = true;
                            lCodigoNuevo = QLupaAdv_Navegador.Datos[i].Codigo;
                        }
                    }
                }
            }
            //si es menor que el primero retorno el primero...si es mayor que el ultimo retorno el ultimo
            else if (QLupaAdv_Navegador.Primero > pCodigo)
                lCodigoNuevo = QLupaAdv_Navegador.Primero;
            else if (QLupaAdv_Navegador.Ultimo < pCodigo)
                lCodigoNuevo = QLupaAdv_Navegador.Ultimo;
        }
    }
    return lCodigoNuevo;
}

function QLupaAdv_HabilitarBtnsNavegador(pCodigo) {
    $("#btnLupaAnt").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    $("#btnLupaSig").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    $("#btnLupaPrim").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    $("#btnLupaUlt").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    $("#btnLupaAntMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    $("#btnLupaSigMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    $("#btnLupaPrimMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    $("#btnLupaUltMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
}


function QLupaAdv_AsignarCodigoNavegador(pTablaFE, pCampoCodigo, pCodigo) {
    qcom_AsignarValorControl(gControles[pTablaFE][0][pCampoCodigo], pCodigo, false);
    QLupaAdv_HabilitarBtnsNavegador(pCodigo);
    //$("#btnLupaAnt").prop("disabled", pCodigo==QLupaAdv_Navegador.Primero);
    //$("#btnLupaSig").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    //$("#btnLupaPrim").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    //$("#btnLupaUlt").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    //$("#btnLupaAntMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    //$("#btnLupaSigMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);
    //$("#btnLupaPrimMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Primero);
    //$("#btnLupaUltMbl").prop("disabled", pCodigo == QLupaAdv_Navegador.Ultimo);

    qcom_InicSolapasActivadas(true);
    qevt_EjecutarSiguiente();
}



//Parametro pCodAObtener= 0: primero, 10: ultimo, -1: anterior, 1:siguiente
function QLupaAdv_ObtenerCodigoNavegador(pIdEntidad, pTablaFE, pCodAObtener, pCampoCodigo, pFiltros, pParametrosAdic) {

    var lCodigo = qcom_ObtenerValorControl(gControles[pTablaFE][0][pCampoCodigo]);
    var lCodigoNuevo = "";
    //si llama al primero, o si llama a siguiente y el codigo actual es "", y ya tiene cargado el primero
    if ((pCodAObtener == 0) || ((lCodigo == "") && (pCodAObtener == 1) && (QLupaAdv_Navegador.Primero != ""))) {
        if ((QLupaAdv_Navegador.Primero != "") && (QLupaAdv_Navegador.Primero != lCodigo)) {
            lCodigoNuevo = QLupaAdv_Navegador.Primero;
            QLupaAdv_AsignarCodigoNavegador(pTablaFE, pCampoCodigo, lCodigoNuevo);
        }
    }
    else if (pCodAObtener == 10) {
        if ((QLupaAdv_Navegador.Ultimo != "") && (QLupaAdv_Navegador.Ultimo != lCodigo)) {
            lCodigoNuevo = QLupaAdv_Navegador.Ultimo;
            QLupaAdv_AsignarCodigoNavegador(pTablaFE, pCampoCodigo, lCodigoNuevo);
        }
    }
    else {
        //Busco si el código actual lo tengo en memoria
        lCodigoNuevo = QLupaAdv_ObtenerCodigoVecino(lCodigo, pCodAObtener);
        if (lCodigoNuevo != "") {
            QLupaAdv_AsignarCodigoNavegador(pTablaFE, pCampoCodigo, lCodigoNuevo);
        }
            //Debo traer otro juego de datos, anteriores y posteriores al que estoy parado
        else {
            var lFiltrosSP = qcom_ObtenerValorParametrosFiltro(pFiltros);
            var lAdicParametros = "";
            if (pParametrosAdic != "") {
                var lFilas = pParametrosAdic.split("@");
                var lSepar = "";
                for (var i = 0; i < lFilas.length; i++) {
                    var lParametro = lFilas[i].split(";");
                    lAdicParametros += lSepar;
                    lAdicParametros += lParametro[0] + ";";
                    lAdicParametros += qcom_ObtenerValorParametroFiltro(lParametro[1]);
                    lSepar = '|';
                }
            }
            var lIdSes = sessionStorage.getItem("idses");
            $('#divCargando').addClass('show');
            $.ajax({
                type: "POST",
                url: "AjaxHandler/QLupaAdvDatos.ashx?TipoConsulta=Nav",
                data: { Identidad: pIdEntidad, Codigo: lCodigo, filtroSP: lFiltrosSP, AdicParametros: lAdicParametros, IdSes: lIdSes },
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

                    //si es la primera vez que llamo (Lo hace cuando arma el form)
                    if ((QLupaAdv_Navegador.Datos == null) &&
                        (QLupaAdv_Navegador.Primero == "") &&
                        (QLupaAdv_Navegador.Ultimo == "")) {
                        QLupaAdv_Navegador.Datos = response.data;
                        if (gControles[pTablaFE][0][pCampoCodigo].getTipoDato() == 2) {
                            QLupaAdv_Navegador.Primero = parseInt(response.Primero, 10);
                            QLupaAdv_Navegador.Ultimo = parseInt(response.Ultimo, 10);
                        }
                        else {
                            QLupaAdv_Navegador.Primero = response.Primero;
                            QLupaAdv_Navegador.Ultimo = response.Ultimo;
                        }
                        $("#btnLupaSig").prop("disabled", false);
                        $("#btnLupaUlt").prop("disabled", false);
                        $("#btnLupaSigMbl").prop("disabled", false);
                        $("#btnLupaUltMbl").prop("disabled", false);

                        qevt_EjecutarSiguiente();
                    }
                    else {
                        QLupaAdv_Navegador.Datos = response.data;
                        if (gControles[pTablaFE][0][pCampoCodigo].getTipoDato() == 2) {
                            QLupaAdv_Navegador.Primero = parseInt(response.Primero, 10);
                            QLupaAdv_Navegador.Ultimo = parseInt(response.Ultimo, 10);
                        }
                        else {
                            QLupaAdv_Navegador.Primero = response.Primero;
                            QLupaAdv_Navegador.Ultimo = response.Ultimo;
                        }
                        //Busco si el código actual lo tengo en memoria
                        lCodigoNuevo = QLupaAdv_ObtenerCodigoVecino(lCodigo, pCodAObtener);
                        if (lCodigoNuevo != "") {
                            QLupaAdv_AsignarCodigoNavegador(pTablaFE, pCampoCodigo, lCodigoNuevo);
                        }
                        else
                            qevt_EjecutarSiguiente();
                    }
                }
            })
            .fail(function (xhr, ajaxOptions, thrownError) {
                qevt_VaciarEventosTmp();
                gBotonAceptarGrilla = "";
                $('#divCargando').removeClass('show');
                qcom_Alerta(thrownError, 'danger', null);
            });

        }

    }
}



//Mètodo invocado desde el boton de un control "Lupa", para mostrar una ventana con el listado de registros
//Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
//function QLupaAdv_MostrarLupa(pIdEntidad, pTablaFE, pCampoCodigo, pCampoDescripcion, pFiltros, pCamposAdic, pControlesAdic, pParametrosAdic, pEsLaEntidadDelForm, pFormulario, pTituloFormulario, pEsBotonLupa) {
function QLupaAdv_MostrarLupa(pIdEntidad, pTablaFE, pCampoCodigo, pCampoDescripcion, pFiltros, pCamposAdic, pControlesAdic, pParametrosAdic, pEsLaEntidadDelForm, pFormulario, pTituloFormulario, pEsBotonLupa, pFnAccion, pFnLeave) {
//Fin 06-03-2021 
    QLupaAdv_SelXTecladoProcesado = false;
    QLupaAdv_CampoCodigo = pCampoCodigo;
    QLupaAdv_CampoDescripcion = pCampoDescripcion;
    QLupaAdv_TablaFE = pTablaFE;
    QLupaAdv_EsEntidadDelForm = pEsLaEntidadDelForm;
    QLupaAdv_Formulario = pFormulario;
    QLupaAdv_TituloForm = pTituloFormulario;
    QLupaAdv_EsBotonLupa = pEsBotonLupa;
    //Convierto los filtros a los valores que correspondan
    QLupaAdv_FiltrosOcultos = qcom_ObtenerValorParametrosFiltro(pFiltros);
    QLupaAdv_AdicCampos = pCamposAdic;
    QLupaAdv_AdicControles = pControlesAdic;
    QLupaAdv_AdicParametros = "";
    //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
    QLupaAdv_FnAccion = pFnAccion;
    QLupaAdv_FnLeave = pFnLeave;
    //Fin 06-03-2021 

    gValorAnt = "";
    if (pParametrosAdic != "") {
        var lFilas = pParametrosAdic.split("@");
        var lSepar = "";
        for (var i = 0; i < lFilas.length; i++) {
            var lParametro = lFilas[i].split(";");
            QLupaAdv_AdicParametros += lSepar;
            QLupaAdv_AdicParametros += lParametro[0] + ";";
            QLupaAdv_AdicParametros += qcom_ObtenerValorParametroFiltro(lParametro[1]);
            lSepar = '|';
        }
    }

    lMismaIdentidad = (pIdEntidad == QLupaAdv_Identidad);
    QLupaAdv_Identidad = pIdEntidad;
    if (!QLupaAdv_Inicializada) {
        QLupaAdv_Inicializar();
    }
    QLupaAdv_ObtenerConfiguracion(pIdEntidad);
    qpopup_ZIndexAsignar(QLupaAdv_dialogolupa);
    //QLupaAdv_dialogolupa.modal({
    //    keyboard: true,
    //    tabindex: -1,
    //    backdrop: "static",
    //    show: true
    //});
    //QLupaAdv_dialogolupa.draggable({
    //    handle: ".modal-header"
    //});

}

function QLupaAdv_Inicializar() {

    $("#divGrillaLupa").append("<table id='gridlupa' style=\"width:'100%'\"></table>");
    QLupaAdv_grillaLupa = $("#gridlupa");
    QLupaAdv_dialogolupa = $("#divModalLupa");
    $("#tituloModalLupa").text(QLupaAdv_tituloLupa);
    QLupaAdv_Inicializada = true;
}


function QLupaAdv_ObtenerConfiguracion(pIdEntidad) {
    QLupaAdv_CamposRet = null;
    var lIdSes = sessionStorage.getItem("idses");
    $('#divCargando').addClass('show');
    $.ajax({
        type: "POST",
        url: "AjaxHandler/QLupaAdvConf.ashx?TipoConf=CD",
        data: { Identidad: pIdEntidad, IdSes: lIdSes },
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
            QLupaAdv_CamposVisibles = response['CamposVisibles'];
            QLupaAdv_CamposRet = response['CamposClaves'];
            QLupaAdv_Estructura = response['Campos'];
            QLupaAdv_tituloLupa = response['DefLupa'][0]['Titulo'];
            $("#tituloModalLupa").text(QLupaAdv_tituloLupa);
            if (QLupaAdv_grillaLupa.data("igGrid") != null)
                QLupaAdv_grillaLupa.igGrid("destroy");
            QLupaAdv_CrearGrilla(pIdEntidad);
        }

    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        $('#divCargando').removeClass('show');
        qcom_Alerta(thrownError, 'danger', null);
    });
}

var fTeclasEspeciales = function (e) {
    if (e.keyCode == 40) { //Flecha Abajo
        $("#gridlupa").igGridSelection("selectRow", 0);
        $("#gridlupa_container").attr("tabIndex", 0);
        //$("#gridlupa_container").focus();
    }
    //else if (((e.keyCode == 56) && (e.key != '8')) || (e.keyCode == 219) || (e.keyCode == 188)) //Anulo comillas, y demas porque dan error en sql
    //else if ((e.key == ",") || (e.key == "'") || (e.key == "(")) //Anulo comillas, y demas porque dan error en sql
    else if /*((e.key == ",") || (e.key == "'") || (e.key == ")") || */ (e.key == ";") //|| (e.key == "(")) //Anulo comillas, y demas porque dan error en sql
    {
        return false;
    }
}


function QLupaAdv_CrearGrilla(pIdentidad) {
    $('#divCargando').addClass('show');
    //Mientras se arma la grilla la oculto para que no produzca el efecto de ocultar columnas
    QLupaAdv_grillaLupa.hide();
    QLupaAdv_GrillaCreada = true;
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

    for (var i = 0; (i < QLupaAdv_CamposVisibles.length) && (i < lCantAMostrar) ; i++) {
        lCamposVisibles.push(QLupaAdv_CamposVisibles[i].Campo);
    }

    lColDef.push({ headerText: "N", key: "N", dataType: 'number', hidden: true });
    lColDefFiltros.push({ columnKey: "N", editorType: "numeric", allowFiltering: false });

    QLupaAdv_AnchoTotal = 0;

    //tomo el ancho por defecto, de acuerdo a la cantidad de visibles
    
    if (lCamposVisibles.length < 6)
        lAnchoColDef = lAnchoxDef / lCamposVisibles.length;
    //Primero defino las columnas
    for (var i = 0; i < QLupaAdv_Estructura.length; i++) {
        var lNombreCol = QLupaAdv_Estructura[i].Campo;
        var lTituloCol = QLupaAdv_Estructura[i].NombreCampo;
        var lCondicionInicial = QLupaAdv_Estructura[i].CondicionInicial == "" ? null : QLupaAdv_Estructura[i].CondicionInicial;
        var lAncho = QLupaAdv_Estructura[i].Longitud == 0 ? lAnchoColDef : QLupaAdv_Estructura[i].Longitud * 8; //Cada caracter ocupa 8 px
        var lAnchoTitulo = lNombreCol.length * 8 + 8; //Cada caracter ocupa 8 px + 8 de padding (4 de cada lado)

        //Anchos Minimos:
        //string 80 (porque tiene 2 botones
        //Numerico 50 tiene 1 solo boton
        //Decimal 58 tiene 1 solo boton y signos d puntuacion
        //Fecha 140 tiene 3 botones y lleva 10 caracteres
        var lOculto = (jQuery.inArray(lNombreCol, lCamposVisibles) <= -1);
        lColDefResizing.push({ columnKey: lNombreCol, allowResizing: true });
        switch (QLupaAdv_Estructura[i].TipoCampo) {
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
            case 'F'://Si longitud del titulo es mayor que la longitud que se quiere mostrar, me quedo con la longitud del titulo  
                lAncho = (lAnchoTitulo > 140) ? lAnchoTitulo : 140;
                //se quitó el conttrol datepicker del editor del filtro porque se estaba mostrando detras del div que contiene la grilla
                lColDef.push({ headerText: lTituloCol, key: lNombreCol, dataType: 'date', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", width: lAncho, hidden: lOculto, format: "dd-MM-yyyy"/*, formatter: "function(val, record) { return qcom_FormatearFechaGrilla(val, '-'); }"*/ });
                lColDefFiltros.push({
                    columnKey: lNombreCol, editorType: "date", allowFiltering: (!lOculto), condition: lCondicionInicial,
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

                lColDef.push({headerText: lTituloCol, key: lNombreCol, dataType: 'string', columnCssClass: "alignCol-izquierda", headerCssClass: "alignHeaderCol-izquierda", width: lAncho, hidden: lOculto, });
                lColDefFiltros.push({
                    columnKey: lNombreCol,
                    editorType: "text",
                    condition: lCondicionInicial,
                    allowFiltering: (!lOculto)
                });
            }
        }
        if (!lOculto)
            QLupaAdv_AnchoTotal += lAncho;
    }

    QLupaAdv_grillaLupa.igGrid({
        autoGenerateColumns: false,
        renderCheckboxes: true,
        responseDataKey: "data",
        width: "100%",
        dataSource: "AjaxHandler/QLupaAdvDatos.ashx?TipoConsulta=Lupa&Identidad=" + pIdentidad + "&filtroSP=" + QLupaAdv_FiltrosOcultos + "&IndicePagina=0" + "&TamaioPagina=" + QLupaAdv_CantRegPorPagina + "&AdicParametros=" + QLupaAdv_AdicParametros + "&IdSes=" + lIdSes,
        columns: lColDef,
        //language: "es",
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
            {
                name: "Paging",
                type: "remote",
                pageSizeList: [5, 10, 25, 50, 75, 100, 200, 250, 500, 750, 1000, 5000, 10000, 100000],
                pageSize: QLupaAdv_CantRegPorPagina,
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
                    $("#gridlupa").igGridPaging("pageIndex", 0);
                }

            }

        ],
        rendered: function (evt, ui) {
            if ((QLupaAdv_Formulario != "") && (!QLupaAdv_EsEntidadDelForm)) {
                setTimeout(function () {
                    var htmlString = '<div style="float: left"><label><a href="#" onClick="QLupaAdv_NuevoElemento();" style="color: #444; font-weight: normal;"><i class="glyphicon glyphicon-plus-sign"></i> Agregar</a></label></br></div>';
                    var lObjectsPageSize = $(".ui-iggrid-pagesizedropdowncontainerabove");
                    var lEncontre = false;
                    for (var l = 0; l < lObjectsPageSize.length && (!lEncontre) ; l++) {
                        if (lObjectsPageSize[l].parentNode.id == "gridlupa_container") {
                            lEncontre = true;
                            $(lObjectsPageSize[l]).prepend(htmlString);
                        }
                    }
                }, 50);
            }
            gridColumns = QLupaAdv_grillaLupa.igGrid("option", "columns");
            if (gridColumns.length)
                //QLupaAdv_PrimEditor = $("[id$='EditingInput'].ui-iggrid-filtereditor")[0];
                QLupaAdv_PrimEditor = $("#gridlupa_container [id$='EditingInput'].ui-iggrid-filtereditor")[0].id;

            if (QLupaAdv_PrimEditor != null) {
                var lcant = $("#gridlupa_container [id$='EditingInput'].ui-iggrid-filtereditor").length;
                for (var i = 0; i < lcant; i++) {
                    ($("#gridlupa_container [id$='EditingInput'].ui-iggrid-filtereditor")[i]).onkeydown = fTeclasEspeciales;
                }


                $("#gridlupa").on("keydown", "tr", function (e, ui) {
                    //Como el evento es sobre tr, se ejecuta una vez por cada columna.
                    //Intente poner que sea por td, pero el enter no funciona, no entra, no ejecuta nada
                    //por eso agregué la condición de que si ya se ejecutó para una celda, no se ejecute para ninguna otra
                    if ((e.keyCode == 13) && (!QLupaAdv_SelXTecladoProcesado)) {
                        var row = $("#gridlupa").igGrid("activeRow");
                        if (row != null) {
                            QLupaAdv_SelXTecladoProcesado = true;
                            e.stopPropagation();
                            e.preventDefault();
                            QLupaAdv_SeleccionarRegistro(row.index, true);
                        }
                    }
                });
            }
            $('#divCargando').removeClass('show');

            setTimeout(function () {
                //if ($("#gridlupa").igGrid("rows").length > 12) {
                    var lalto = $(window).height() * 0.90;
                    $("#divGrillaLupa").height(lalto - 47);
                    $("#gridlupa").igGrid("option", "height", lalto);
                //}

                $("#divModalLupaDlg").width(QLupaAdv_AnchoTotal + 15);

                QLupaAdv_grillaLupa.show();


                QLupaAdv_dialogolupa.modal({
                    keyboard: true,
                    tabindex: -1,
                    backdrop: "static",
                    show: true
                });

                
                if (QLupaAdv_PrimeraVez) {
                    QLupaAdv_PrimeraVez = false;
                    QLupaAdv_dialogolupa.on('shown.bs.modal', function () {
                        if (QLupaAdv_PrimEditor != null)
                            $("#" + QLupaAdv_PrimEditor).focus();
                    })
                }
                QLupaAdv_dialogolupa.draggable({
                    handle: ".modal-header"
                });
                QLupaAdv_dialogolupa.unbind('dragstop');
                QLupaAdv_dialogolupa.on("dragstop", function (event, ui) {
                    var lScroll = window.pageYOffset !== undefined ? window.pageYOffset : window.scrollTop;
                    if (ui.helper[0].offsetTop < 0) {
                        if (lScroll > 0)
                            QLupaAdv_dialogolupa.offset({ top: lScroll, left: ui.helper[0].offsetLeft });
                        else
                        QLupaAdv_dialogolupa.offset({ top: 0, left: ui.helper[0].offsetLeft });
                    }
                    else if (lScroll > 0)
                        QLupaAdv_dialogolupa.offset({ top: lScroll, left: ui.helper[0].offsetLeft }); 
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
            //var gridColumns = QLupaAdv_grillaLupa.igGrid("option", "columns");
            //if (gridColumns.length > 0)
            //    QLupaAdv_grillaLupa.igGridFiltering("option", "columnSettings", lColDefFiltros);
        },
        cellClick: function (evt, ui) {
            QLupaAdv_SeleccionarRegistro(ui.rowIndex, false)
        },
        cellRightClick: function (evt, ui) {
            //alert(ui.rowIndex + 'j');
            if (QLupaAdv_Formulario != "") {
                QLupaAdv_grillaLupa.igGridSelection("selectRow", ui.rowIndex);
                evt.stopPropagation();
                evt.preventDefault();
                var lCantRet = QLupaAdv_CamposRet.length;
                if ((QLupaAdv_CampoCodigo != "") && (lCantRet > 0)) {
                    var lValor = QLupaAdv_grillaLupa.igGrid("getCellValue", ui.rowIndex, $.trim(QLupaAdv_CamposRet[0].Campo));
                    if (QLupaAdv_Identidad == "venclieHabitual")
                    {
                        var lValorAsoc = QLupaAdv_grillaLupa.igGrid("getCellValue", ui.rowIndex, "Cliente_Id");
                        qpopup_MostrarFormCasoPart(QLupaAdv_Formulario, lValorAsoc + '@' +  lValor, '', '', QLupaAdv_TituloForm, true);
                    }
                    else if (QLupaAdv_Identidad == "tesChequeras") {
                        var lValorAsoc = QLupaAdv_grillaLupa.igGrid("getCellValue", ui.rowIndex, $.trim(QLupaAdv_CamposRet[0].Campo).replace("Chequera_Id", "Cartera_Id"));
                        qpopup_MostrarFormCasoPart(QLupaAdv_Formulario, lValorAsoc + '@' + lValor, '', '', QLupaAdv_TituloForm, true);
                }

                    else 
                    {
                qpopup_MostrarForm(QLupaAdv_Formulario, lValor, '', '', QLupaAdv_TituloForm, true);
            }

                }
                
            }
        }
    });

    ////Este método se ejecuta cada vez que se arma la url para ir a buscar los datos
    //$("#gridlupa").data("igGrid").dataSource.settings.urlParamsEncoding = function (owner, params) {

    //    if (QLupaAdv_ReinicioPag) {
    //        params.pagingParams.pageIndex = 0;
    //        QLupaAdv_ReinicioPag = false;
    //    }
    //};
}

function QLupaAdv_SeleccionarRegistro(pRowIndex, pSelecXTeclado) {
    var row = $("#gridlupa").igGridSelection("selectedRow");
    if ((row != null) || (pSelecXTeclado)) {
        if ((pSelecXTeclado) || (pRowIndex == row.index)) {
            var lInstancio = false;
            QLupaAdv_FilaSeleccionada = pRowIndex;

            if (QLupaAdv_EsEntidadDelForm && ConsultaxCambiosSinGuardar()) {
                qcom_Confirmar(qrefConfPerderCambios, 'warning',
                    QLupaAdv_ProcesarSeleccion, QLupaAdv_CancelarSeleccion);
            }
            else
                QLupaAdv_ProcesarSeleccion();
        }
    }

}

function QLupaAdv_CancelarSeleccion() {
    QLupaAdv_ControlesRet = null;
    QLupaAdv_TiposControlesRet = null;
    QLupaAdv_CamposOcultos = null;
    QLupaAdv_FilaSeleccionada = null;
    $('#divModalLupa').attr("Abierto", "false");
    QLupaAdv_dialogolupa.modal("hide");
    qevt_VaciarEventosTmp();
}

function QLupaAdv_ProcesarSeleccion() {
    var lCantRet = QLupaAdv_CamposRet.length;
    var lValorCodigo = ""
    if (QLupaAdv_EsEntidadDelForm) {
        gTieneSinGuardar = false;
        //Limpio las solapas para que no figuren como activadas
        qcom_InicSolapasActivadas(true);
    }
    else
        gTieneSinGuardar = true;

    if ((QLupaAdv_CampoCodigo != "") && (lCantRet > 0)) {
        var lValorCodigo = QLupaAdv_grillaLupa.igGrid("getCellValue", QLupaAdv_FilaSeleccionada, $.trim(QLupaAdv_CamposRet[0].Campo));
        if (QLupaAdv_EsBotonLupa == 1) {
            var lValorActual = qcom_ObtenerValorControl(gControles[QLupaAdv_TablaFE][0][QLupaAdv_CampoCodigo]);
            qcom_AsignarValorControl(gControles[QLupaAdv_TablaFE][0][QLupaAdv_CampoCodigo], lValorActual + lValorCodigo, false);
        }
        else {
        qcom_AsignarValorControl(gControles[QLupaAdv_TablaFE][0][QLupaAdv_CampoCodigo], lValorCodigo, false);
        }
    }
    if ((lCantRet > 1) && (QLupaAdv_CampoDescripcion != "")) {
        var lValor = QLupaAdv_grillaLupa.igGrid("getCellValue", QLupaAdv_FilaSeleccionada, $.trim(QLupaAdv_CamposRet[1].Campo));
        qcom_AsignarValorControl(gControles[QLupaAdv_TablaFE][0][QLupaAdv_CampoDescripcion], lValor, false);
    }
    //si retorna campos adicionales
    if (QLupaAdv_AdicCampos != "") {
        var lControlesAdic = QLupaAdv_AdicControles.split("|");
        var lCamposAdic = QLupaAdv_AdicCampos.split("|");
        for (var j = 0; j < lControlesAdic.length; j++) {
            var lValor = QLupaAdv_grillaLupa.igGrid("getCellValue", QLupaAdv_FilaSeleccionada, $.trim(lCamposAdic[j]));
            var lCampoCtrl = lControlesAdic[j].split(":");
            if (lCampoCtrl.length > 1) {
                qcom_AsignarValorControl(gControles[lCampoCtrl[0]][0][lCampoCtrl[1]], lValor, false);
            }
            else if ((lCampoCtrl.length == 1) && (lCampoCtrl[0].startsWith("var_")))
            {
                    gVariables[lCampoCtrl[0]] = lValor;
            }
            else if (lCampoCtrl.length == 1)//si es uno, es porque es una parte de un segmento 
            {
                var lCSeg = lCampoCtrl[0].split("[");
                if (lCSeg.length == 2) {
                    qcom_SetearValorParteSeg(lCSeg[0], gOrigenesSeg[lCSeg[1].substring(0, lCSeg[1].length - 1)], lValor);
                }
            }
        }
    }
    QLupaAdv_ControlesRet = null;
    QLupaAdv_TiposControlesRet = null;
    QLupaAdv_CamposOcultos = null;
    QLupaAdv_FilaSeleccionada = null;
    $('#divModalLupa').attr("Abierto", "false");
    QLupaAdv_dialogolupa.modal("hide");
    if (QLupaAdv_EsEntidadDelForm)
        QLupaAdv_HabilitarBtnsNavegador(lValorCodigo);

    //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
    var lcant = 0;
    if (typeof QLupaAdv_FnAccion !== 'undefined' && jQuery.isFunction(QLupaAdv_FnAccion)) {
        qevt_AgregarEventoaTmp(QLupaAdv_FnAccion.name, null, false);
        lcant++;
    }
    else if ((gEventos[QLupaAdv_FnLeave] != 'undefined') && (gEventos[QLupaAdv_FnLeave] != null)) {
        qevt_AgregarEventoaTmp(QLupaAdv_FnLeave, null, false);
        lcant++;
    }
    if ((lcant>0) && (gEventosTmp.length == lcant))
    qevt_EjecutarSiguiente();
    //qevt_EjecutarSiguiente();
    //Fin 06-03-2021
}

function QLupaAdv_NuevoElemento() {
    qpopup_MostrarFormGral(QLupaAdv_Formulario, '', '', '', QLupaAdv_TituloForm, false, true, false);
}

