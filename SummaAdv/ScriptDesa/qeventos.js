var qevt_evento = function Evento() {
    this.Acciones = [];
}

var gUltEvt = null;

var qevt_accion = function Accion(pCodigo, pTipo, pNombre, pValor, pParametros) {
		this.Codigo = pCodigo;
	    this.Tipo = pTipo;
	    this.Nombre = pNombre;
	    this.Valor = pValor;
	    if (pParametros === undefined)
	        this.Parametros = [];
	    else
	        this.Parametros = pParametros;
	}

function qevt_AgregarEventoaTmp(pNombreEvento, pEvento, pEjecuto)
{
    var lExiste = false;
    if (pEvento == null) {
        if ((gEventos[pNombreEvento] != 'undefined') && (gEventos[pNombreEvento] != null))
        {
            lExiste = true;
            gEventosTmp.push(qevt_Clonar(pNombreEvento));
        }
    }
    else {
        gEventosTmp.push(pEvento);
        lExiste = true;
    }
    if (lExiste && pEjecuto)
    {
        if (gEventosTmp.length == 1) 
            qevt_EjecutarSiguiente(); 
    }
}

function qevt_Clonar(pNombreEvento)
{
    var levtClon = new qevt_evento();
    var levtOrig = gEventos[pNombreEvento];
    for (var i=0; i<levtOrig.Acciones.length; i++)
    {
        levtClon.Acciones.push(new qevt_accion(levtOrig.Acciones[i].Codigo,
                                               levtOrig.Acciones[i].Tipo,
                                               levtOrig.Acciones[i].Nombre,
                                               levtOrig.Acciones[i].Valor,
                                               levtOrig.Acciones[i].Parametros
                                            ))
    }
    return levtClon;
}

function qevt_VaciarEventosTmp() {
    gEventosTmp = [];
    if (gCtrlProxFoco != "")
        $(gCtrlProxFoco).focus();
    gCtrlProxFoco = "";

}

function qevt_TratarIteracion(pValor)
{
    gEsIteracion = true;
    var CondActual = gEventosTmp[0].Acciones[0];
    //busco la rama valida
    var lCodigoRama = "";
    if (!gCortaIteracion) {
        for (var i = 0; (i < gEventosTmp[0].Acciones.length - 1) && (lCodigoRama == ""); i++) {
        if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.' + pValor)) &&
            (gEventosTmp[0].Acciones[i].Tipo == "V") && (gEventosTmp[0].Acciones[i].Valor == pValor)) {
            lCodigoRama = gEventosTmp[0].Acciones[i].Codigo;
        }
    }
    }
    //si el codigo de rama es != de vacío, entonces es que cumple con la condicion de iteracion
    //por lo tanto debo duplicar los elementos de esta iteración en gEventosTmp, porque lo debo preparar para la proxima
    if (lCodigoRama != "") {
        var lTempAux = [];
        //en temp dejo los que debo duplicar
        var lCant = gEventosTmp[0].Acciones.length - 1;
        for (var i = lCant; i >= 0; i--) {
            if (gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.')) {
                lTempAux.unshift(gEventosTmp[0].Acciones[i]);
            }
        }
        //la condicion no la vuelvo a apilar, porque ya la cumplió (me queda apilada la original)
        //lTempAux.unshift(gEventosTmp[0].Acciones[0]);

        //ahora apilo todos los que me quedaron en temp, que son los que tengo que duplicar
        lCant = lTempAux.length - 1;
        for (var i = lCant; i >= 0; i--) {
            gEventosTmp[0].Acciones.unshift(lTempAux[i]);
        }
    }
    //si no cumple con el codigo de rama, entonces debo eliminar todos los elementos
    else {
        if (qcom_existeControl('#divMensajeItera'))
            $('#divMensajeItera').removeClass('show');
        var lCant = gEventosTmp[0].Acciones.length - 1;
        var lEncontreValor = false;
        for (var i = lCant; i >= 0; i--) {
            if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.')) &&
                (!gEventosTmp[0].Acciones[i].Codigo.startsWith(lCodigoRama + '.') || (lCodigoRama == ""))) {
                gEventosTmp[0].Acciones.splice(i, 1);
            }
        }
        if (gCortaIteracion) {
            qevt_VaciarEventosTmp();
            qcom_Alerta('Proceso Abortado', 'danger', null);
        }
        gEsIteracion = false;
        gCortaIteracion = false;

    }
}

function qevt_EliminarNodosCond(pValor) {
    var CondActual = gEventosTmp[0].Acciones[0];
    //Veo si es una condición de Iteracion
    if (gEventosTmp[0].Acciones[0].Valor == "I")
    {
        qevt_TratarIteracion(pValor);
    }
    else
    {
    //busco la rama valida
    var lCodigoRama = ""
    for (var i = 0; (i < gEventosTmp[0].Acciones.length - 1) && (lCodigoRama == "") ; i++) {
        if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.' + pValor)) &&
            (gEventosTmp[0].Acciones[i].Tipo == "V") && (gEventosTmp[0].Acciones[i].Valor == pValor)) {
            lCodigoRama = gEventosTmp[0].Acciones[i].Codigo;
        }
    }
    //busco la rama de NoVacio
    if ((lCodigoRama == "") && (pValor!="") && (pValor!='vacio')) {
        pValor = "novacio";
        for (var i = 0; (i < gEventosTmp[0].Acciones.length - 1) && (lCodigoRama == ""); i++) {
            if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.' + pValor)) &&
                (gEventosTmp[0].Acciones[i].Tipo == "V") && (gEventosTmp[0].Acciones[i].Valor == pValor)) {
                lCodigoRama = gEventosTmp[0].Acciones[i].Codigo;
            }
        }
    }

    if (lCodigoRama == "")
    {
        pValor = "sino";
        for (var i = 0; (i < gEventosTmp[0].Acciones.length - 1) && (lCodigoRama == "") ; i++) {
            if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.' + pValor)) &&
                (gEventosTmp[0].Acciones[i].Tipo == "V") && (gEventosTmp[0].Acciones[i].Valor == pValor)) {
                lCodigoRama = gEventosTmp[0].Acciones[i].Codigo;
            }
        }
    }

    var lCant = gEventosTmp[0].Acciones.length - 1;
    var lEncontreValor = false;
    for (var i = lCant; i >= 0; i--) {
        if ((gEventosTmp[0].Acciones[i].Codigo.startsWith(CondActual.Codigo + '.')) &&
            (!gEventosTmp[0].Acciones[i].Codigo.startsWith(lCodigoRama + '.') || (lCodigoRama == ""))) {
            gEventosTmp[0].Acciones.splice(i, 1);
        }
    }
    }
}


function qevt_EjecutarSiguiente() {
    if (gEventosTmp.length > 0) {
        gEventosTmp[0].Acciones.shift();
        if (gEventosTmp[0].Acciones.length > 0) {
            //alert(typeof Evento1.Acciones[0].Nombre + ' - ' + Evento1.Acciones[0].Codigo);
            if (typeof gEventosTmp[0].Acciones[0].Nombre == 'function') {
                try
                {
                    var lfn = gEventosTmp[0].Acciones[0].Nombre;
                    var lCanPar = gEventosTmp[0].Acciones[0].Parametros.length;
                    if (lCanPar == 0)
                        lfn()
                    else if (lCanPar == 1)
                        lfn(gEventosTmp[0].Acciones[0].Parametros[0]);
                    else if (lCanPar == 2)
                        lfn(gEventosTmp[0].Acciones[0].Parametros[0], gEventosTmp[0].Acciones[0].Parametros[1]);
                    else if (lCanPar == 3)
                        lfn(gEventosTmp[0].Acciones[0].Parametros[0], gEventosTmp[0].Acciones[0].Parametros[1], gEventosTmp[0].Acciones[0].Parametros[2]);

                }
			    catch(err) {
			        qevt_VaciarEventosTmp();
			        qcom_Alerta(err.message, 'danger', null);
                }
            }
        }
        else {
            //Inicio 18/09/2021
            //Itero hasta vaciar el temporal
            var lFinIteracion = false;
            do {
            //Fin 18/09/2021
            gEventosTmp.shift();
            if (gEventosTmp.length > 0) {
                gEventosTmp[0].Acciones.shift();
                if (gEventosTmp[0].Acciones.length > 0) {
                        //Inicio 18/09/2021
                        lFinIteracion = true;
                        //Fin 18/09/2021
                    //alert(typeof Evento1.Acciones[0].Nombre + ' - ' + Evento1.Acciones[0].Codigo);
                    if (typeof gEventosTmp[0].Acciones[0].Nombre == 'function') {
                        try {
                            var lfn = gEventosTmp[0].Acciones[0].Nombre;
                            var lCanPar = gEventosTmp[0].Acciones[0].Parametros.length;
                            if (lCanPar == 0)
                                lfn()
                            else if (lCanPar == 1)
                                lfn(gEventosTmp[0].Acciones[0].Parametros[0]);
                            else if (lCanPar == 2)
                                lfn(gEventosTmp[0].Acciones[0].Parametros[0], gEventosTmp[0].Acciones[0].Parametros[1]);
                            else if (lCanPar == 3)
                                lfn(gEventosTmp[0].Acciones[0].Parametros[0], gEventosTmp[0].Acciones[0].Parametros[1], gEventosTmp[0].Acciones[0].Parametros[2]);
                        }
                        catch (err) {
                            qevt_VaciarEventosTmp();
                            qcom_Alerta(err.message, 'danger', null);
                        }
                    }
                }
            }
            //Inicio 18/09/2021
            }
            while ((!lFinIteracion) && (gEventosTmp.length > 0));
            //else {
            if (gEventosTmp.length == 0) {
            //fin 18/09/2021
                if (gCtrlProxFoco != "")
                    $(gCtrlProxFoco).focus();
                gCtrlProxFoco = "";
            }
        }
    }
}

function qevt_Lupa_BotonClick(pFnMostrar, pFnAccion, pFnLeave) {
    //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
    ////Daniel
    //var lEvento = new qevt_evento();
    //var lcant = 1;
    //lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    //lEvento.Acciones.push(new qevt_accion("1", "A", pFnMostrar, ""));
    //qevt_AgregarEventoaTmp("", lEvento, false);
    //if (typeof pFnAccion !== 'undefined' && jQuery.isFunction(pFnAccion)) {
    //    qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
    //    lcant++;
    //}
    ////else if (typeof pFnLeave !== 'undefined' && jQuery.isFunction(pFnLeave)) {
    //else if ((gEventos[pFnLeave] != 'undefined') && (gEventos[pFnLeave] != null)) {
    //    qevt_AgregarEventoaTmp(pFnLeave, null, false);
    //    lcant++;
    //}
    //if (gEventosTmp.length == lcant)
    //    qevt_EjecutarSiguiente();
    ////Daniel Fin

    var lfn = pFnMostrar;
    lfn(pFnAccion, pFnLeave);
    //Fin 06-03-2021 
}

function qevt_Lupa_ValorModif(pFnObtenerDesc, pFnAccion, pFnLeave, pEsObtenerDesc) {
    var lcant = 1;
    if (!pEsObtenerDesc) {
    if (typeof pFnAccion !== 'undefined' && jQuery.isFunction(pFnAccion))
        qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
    else {
        var lEvento = new qevt_evento();
        lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
        lEvento.Acciones.push(new qevt_accion("1", "A", pFnObtenerDesc, ""));
        qevt_AgregarEventoaTmp("", lEvento, false);
        //if (typeof pFnLeave !== 'undefined' && jQuery.isFunction(pFnLeave)) {
        if ((gEventos[pFnLeave] != 'undefined') && (gEventos[pFnLeave] != null)) {
            qevt_AgregarEventoaTmp(pFnLeave, null, false);
            lcant++;
        }
    }
    }
    else {
        if (typeof pFnAccion !== 'undefined' && jQuery.isFunction(pFnAccion))
            qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
        else {
            if ((gEventos[pFnLeave] != 'undefined') && (gEventos[pFnLeave] != null)) {
                //qevt_AgregarEventoaTmp(pFnLeave, null, false);
                var levtOrig = gEventos[pFnLeave];
                var lEventoFn = new qevt_evento();
                for (var i = 0; i < levtOrig.Acciones.length; i++) {
                    lEventoFn.Acciones.push(new qevt_accion(levtOrig.Acciones[i].Codigo, levtOrig.Acciones[i].Tipo, levtOrig.Acciones[i].Nombre, levtOrig.Acciones[i].Valor));
                }
                gEventosTmp.unshift(lEventoFn);
                lcant++;
            }
            var lEvento = new qevt_evento();
            lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
            lEvento.Acciones.push(new qevt_accion("1", "A", pFnObtenerDesc, ""));
            gEventosTmp.unshift(lEvento);
            //qevt_AgregarEventoaTmp("", lEvento, false);
            //if (typeof pFnLeave !== 'undefined' && jQuery.isFunction(pFnLeave)) {
        }
    }

    if (gEventosTmp.length == lcant)
        qevt_EjecutarSiguiente();
}

function qevt_Lupa_ValorNavegador(pFnObtenerCodigoNav, pFnAccion, pFnLeave) {
    if (ConsultaxCambiosSinGuardar()) {
        qcom_Confirmar(qrefConfPerderCambios, 'warning',
            function () {
                qevt_Lupa_ValorNavegadorAux(pFnObtenerCodigoNav, pFnAccion, pFnLeave);
            }, null);
    }
    else
        qevt_Lupa_ValorNavegadorAux(pFnObtenerCodigoNav, pFnAccion, pFnLeave);

}

function qevt_Lupa_ValorNavegadorAux(pFnObtenerCodigoNav, pFnAccion, pFnLeave) {
    var lcant = 1;

    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", pFnObtenerCodigoNav, ""));
    qevt_AgregarEventoaTmp("", lEvento, false);

    if (pFnAccion != null) {
        qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
        lcant++;
    }

    if (gEventosTmp.length == lcant)
        qevt_EjecutarSiguiente();
}

function qevt_LupaEnSegmento_ValorModif(pFnObtenerDesc, pFnAccion, pFnLeave) {
    var lcant = 1;
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", pFnObtenerDesc, ""));
    qevt_AgregarEventoaTmp("", lEvento, false);
    //if (typeof pFnLeave !== 'undefined' && jQuery.isFunction(pFnLeave)) {
    if ((gEventos[pFnLeave] != 'undefined') && (gEventos[pFnLeave] != null)) {
        qevt_AgregarEventoaTmp(pFnLeave, null, false);
        lcant++;
    }
    if (typeof pFnAccion !== 'undefined' && jQuery.isFunction(pFnAccion)) {
        qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
        lcant++;
    }
    if (gEventosTmp.length == lcant)
        qevt_EjecutarSiguiente();
}

function qevt_Grilla_NuevaFila(pGrilla, pbtnNuevo) {
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_blanquearControles, "", [pGrilla, pbtnNuevo]));
    lEvento.Acciones.push(new qevt_accion("2", "A", qgrillas_RadioOpcionsVisibles, "", [pGrilla, false]));    
    //lEvento.Acciones.push(new qevt_accion("1", "A", alert('psps'), ""));
    lEvento.Acciones.push(new qevt_accion("3", "A", qpopup_Mostrar, "", ['divGrupo' + pGrilla, false]));
    qevt_AgregarEventoaTmp("", lEvento, false);
    var lDeboEjecutar = (gEventosTmp.length == 1);
    qevt_AgregarEventoaTmp(pGrilla + "_InicioNuevaFila", null, false);
    if (lDeboEjecutar)
        qevt_EjecutarSiguiente();
}

function qevt_Grilla_EditarFila(pGrilla, pClave) {
    var lDeboEjecutar = false;
    if ($(window).width() >= gSizePhone) {
        var lEvento = new qevt_evento();
        lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
        lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_llenarDatosEdicion, "", [pGrilla]));
        lEvento.Acciones.push(new qevt_accion("2", "A", qgrillas_RadioOpcionsVisibles, "", [pGrilla, true]));
        lEvento.Acciones.push(new qevt_accion("3", "A", qpopup_Mostrar, "", ['divGrupo' + pGrilla, false]));
        qevt_AgregarEventoaTmp("", lEvento, false);
        lDeboEjecutar = (gEventosTmp.length == 1);
        qevt_AgregarEventoaTmp(pGrilla + "_InicioEdicionFila", null, false);
    }
    else
    {
        var lEvento = new qevt_evento();
        lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
        lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_llenarDatosEdicionPhone, "", [pGrilla, pClave]));
        lEvento.Acciones.push(new qevt_accion("2", "A", qpopup_Mostrar, "", ['divGrupo' + pGrilla, false]));
        qevt_AgregarEventoaTmp("", lEvento, false);
        lDeboEjecutar = (gEventosTmp.length == 1);
        qevt_AgregarEventoaTmp(pGrilla + "_InicioEdicionFila", null, false);
    }

    if (lDeboEjecutar)
        qevt_EjecutarSiguiente();
}

function qevt_Grilla_BorrarFila(pGrilla, pClave) {
    var lDeboEjecutar = false;
    if ($(window).width() >= gSizePhone) {
    }
    else {
        var lEvento = new qevt_evento();
        lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
        lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_Borrar, "", [pGrilla, pClave]));
        qevt_AgregarEventoaTmp("", lEvento, false);
        lDeboEjecutar = (gEventosTmp.length == 1);
    }

    if (lDeboEjecutar)
        qevt_EjecutarSiguiente();
}

function qevt_Grilla_EditarFilaEnGrilla(pGrilla, pClave) {
    var lDeboEjecutar = false;
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_EditarFilaEnGrilla, "", [pGrilla, pClave]));
    qevt_AgregarEventoaTmp("", lEvento, false);
    lDeboEjecutar = (gEventosTmp.length == 1);
    if (lDeboEjecutar)
        qevt_EjecutarSiguiente();
}

function qevt_Grilla_GuardarFila(pGrilla) {
    if (gEventosTmp.length == 0) {
    var lDeboEjecutar = false;
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", qgrillas_validarDatosFila, "", [pGrilla]));
    qevt_AgregarEventoaTmp("", lEvento, false);
    lDeboEjecutar = (gEventosTmp.length == 1);
    qevt_AgregarEventoaTmp(pGrilla + "_EjecutarValidarFila", null, false);
    var lEvento2 = new qevt_evento();
    lEvento2.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento2.Acciones.push(new qevt_accion("1", "A", qgrillas_guardarDatosEdicion, "", [pGrilla]));
    qevt_AgregarEventoaTmp("", lEvento2, false);
    qevt_AgregarEventoaTmp(pGrilla + "_FinEdicionFila", null, false);
    var lEvento3 = new qevt_evento();
    lEvento3.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento3.Acciones.push(new qevt_accion("1", "A", qgrillas_FinAceptarFila, "", [pGrilla]));
    qevt_AgregarEventoaTmp("", lEvento3, false);
    if (lDeboEjecutar)
        qevt_EjecutarSiguiente();
    }
    else
        qcom_Alerta("Hay tareas pendientes. Intentelo de nuevo", 'info', null);
}


function qevt_LupaSeg_BotonClick(pFnMostrar, pFnAccion) {
    //Inicio 06-03-2021 - Se pasa el encolado de las acciones para despues de que el usuario haya seleccionado un elemnto de la lupa
    ////Daniel
    //var lEvento = new qevt_evento();
    //var lcant = 1;
    //lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    //lEvento.Acciones.push(new qevt_accion("1", "A", pFnMostrar, ""));
    //qevt_AgregarEventoaTmp("", lEvento, false);
    ////if (typeof pFnAccion !== 'undefined' && jQuery.isFunction(pFnAccion)) {
    ////    qevt_AgregarEventoaTmp(pFnAccion.name, null, false);
    ////    lcant++;
    ////}
    //if (pFnAccion != '') {
    //    var lCantEvt = gEventosTmp.length;
    //    qevt_AgregarEventoaTmp(pFnAccion, null, false);
    //    if (lCantEvt < gEventosTmp.length)
    //    lcant++;
    //}

    //if (gEventosTmp.length == lcant)
    //    qevt_EjecutarSiguiente();

    var lfn = pFnMostrar;
    lfn(pFnAccion);
    //Fin 06-03-2021
}

function qevt_InicializarForm(pInicializarClave, pPrimeraVez, pEsNuevo) {
    if (gEventosTmp > 0) {
        if (gEventosTmp[0].Acciones.length > 0)
            //Quito la primera accion que es la que origina todo esto
            gEventosTmp[0].Acciones.shift();

        //Tengo que ir apilando las acciones que tiene el postload
        if ((gEventos["Post_Load"] != 'undefined') && (gEventos["Post_Load"] != null)) {
            var levtOrig = gEventos["Post_Load"];
            for (var i = levtOrig.Acciones.length - 1; i > 0; i--) {
                gEventosTmp[0].Acciones.unshift(new qevt_accion(levtOrig.Acciones[i].Codigo, levtOrig.Acciones[i].Tipo, levtOrig.Acciones[i].Nombre, levtOrig.Acciones[i].Valor));
            }
        }
        //tengo que apilar la de inicializacion
        gEventosTmp[0].Acciones.unshift(new qevt_accion("1", "A", qcom_InicializarForm, "", [pInicializarClave, pPrimeraVez, pEsNuevo]));
        //apilo una vacia para que elimine el ejecutar siguiente
        gEventosTmp[0].Acciones.unshift(new qevt_accion("0", "A", null, ""));

        //debo agregar los eventos originados por los seteos de los controles (sería el post postload)
        for (var i = 0; i < gEventosPostPostLoad.length; i++) {
            qevt_AgregarEventoaTmp(gEventosPostPostLoad[i], null, false);
        }
        qevt_EjecutarSiguiente();
    }
    else
    {
        var lEvento = new qevt_evento();
        //Tengo que ir apilando las acciones que tiene el postload, excepto la primera que es la acicon vacia
        if ((gEventos["Post_Load"] != 'undefined') && (gEventos["Post_Load"] != null)) {
            var levtOrig = gEventos["Post_Load"];
            for (var i = levtOrig.Acciones.length - 1; i > 0; i--) {
                lEvento.Acciones.unshift(new qevt_accion(levtOrig.Acciones[i].Codigo, levtOrig.Acciones[i].Tipo, levtOrig.Acciones[i].Nombre, levtOrig.Acciones[i].Valor));
            }
        }
        //tengo que apilar la de inicializacion
        lEvento.Acciones.unshift(new qevt_accion("1", "A", qcom_InicializarForm, "", [pInicializarClave, pPrimeraVez, pEsNuevo]));
        //apilo una vacia para que elimine el ejecutar siguiente
        lEvento.Acciones.unshift(new qevt_accion("0", "A", null, ""));
        gEventosTmp.push(lEvento);
        //debo agregar los eventos originados por los seteos de los controles (sería el post postload)
        for (var i = 0; i < gEventosPostPostLoad.length; i++) {
            qevt_AgregarEventoaTmp(gEventosPostPostLoad[i], null, false);
        }
        qevt_EjecutarSiguiente();
    }
}

function qevt_BlanquearCambiosSinGuardar() {
    var lEvento = new qevt_evento();
    lEvento.Acciones.unshift(new qevt_accion("1", "A", qcom_blanquearCambiosSinGuardar, "", []));
    //apilo una vacia para que elimine el ejecutar siguiente
    lEvento.Acciones.unshift(new qevt_accion("0", "A", null, ""));
    gEventosTmp.push(lEvento);
    qevt_EjecutarSiguiente();
}

function qevt_DeshabilitarTodo() {
    gSL = true;
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", qcom_DeshabilitarTodo, ""));
    qevt_AgregarEventoaTmp("", lEvento, false);
    if (gEventosTmp.length == 1)
        qevt_EjecutarSiguiente();
}


function qevt_PegarFormulario() {
    var lEvento = new qevt_evento();
    lEvento.Acciones.push(new qevt_accion("0", "A", null, ""));
    lEvento.Acciones.push(new qevt_accion("1", "A", qcom_NuevaEntidad, "", [true]));
    qevt_AgregarEventoaTmp("", lEvento, false);
    if (gEventosTmp.length == 1)
        qevt_EjecutarSiguiente();
}
