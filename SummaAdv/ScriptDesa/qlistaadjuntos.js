function qlstadj_AgregarNuevoAdjunto(pNombreListaAdjuntos, pArchivo_Id, pNombreArchivo, pArchivoBase64) {
    var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;
    var lUltId = gListasAdjuntos[pNombreListaAdjuntos].UltId + 1;
    gListasAdjuntos[pNombreListaAdjuntos].UltId = lUltId;
    var lCompNombre = pNombreArchivo.split('.');
    var lExtension = lCompNombre[lCompNombre.length - 1];

    gEntidad[lNombreTabla].push({Renglon:lUltId, Guid: pArchivo_Id, NombreArchivo: pNombreArchivo, ArchivoBase64: pArchivoBase64, Extension: lExtension, Estado: gEstadoAdjunto["Nuevo"], IDCol: lUltId });
    qlstadj_AgregarVistaAdjunto(pNombreListaAdjuntos, false, gEntidad[lNombreTabla].length-1, lUltId)

}



function qlstadj_AgregarVistaAdjunto(pNombreListaAdjuntos, pEsAuxiliar, pPosicion, pSufijoNombre) {
    var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;
    var lDatosAdjunto = null;
    if (!pEsAuxiliar)
        lDatosAdjunto = gEntidad[lNombreTabla][pPosicion];
    else
        lDatosAdjunto = gEntidadAux[lNombreTabla][pPosicion];
    var lExtension = lDatosAdjunto.Extension.toLowerCase();

    var ldiv = document.createElement('div');
    ldiv.id = pNombreListaAdjuntos + "_" + pSufijoNombre;

    var lOnClick = "";
    var lOnClickCerrar = "qlstadj_QuitarDeLista('" + pNombreListaAdjuntos + "'," + pEsAuxiliar + ",  this);";

    
    var lHtmlBorrarArchivo = "";   
    var lDescripcion = "";
    if (gListasAdjuntos[pNombreListaAdjuntos].MuestraDescripcion)
        lDescripcion = lDatosAdjunto.NombreArchivo;

    if (gListasAdjuntos[pNombreListaAdjuntos].BorraArchivos)
        lHtmlBorrarArchivo = '<label class="labelElimAdjunto"><a href="javascript:void(0)" onclick="' + lOnClickCerrar + '"><i class="fa fa-times-circle"></i></a></label>';
    var lhtmlDesc = '<div class="desc">' + lDescripcion + '</div>';
    if (gListasAdjuntos[pNombreListaAdjuntos].CantidadMaxima == 1) //Uno solo ocupa todo el ancho
        ldiv.className = "divAdjunto col-lg-12 col-md-12 col-sm-12 col-xs-12";
    else
    ldiv.className = "divAdjunto col-lg-2 col-md-2 col-sm-3 col-xs-6";
    if ((lExtension == "jpg") || (lExtension == "gif") || (lExtension == "png") || (lExtension == "bmp") || (lExtension == "jfif")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_MostrarArchivoImagen('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false;";
        ldiv.innerHTML = '<div class="gallery">' + lHtmlBorrarArchivo + '<a href="javascript:void(0)" onclick="' + lOnClick + '"><img src="data:image/' + lExtension + ';base64,' + lDatosAdjunto.ArchivoBase64 + '"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }
    else if (lExtension == "pdf") {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_MostrarArchivoPDF('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false; ";
        ldiv.innerHTML = '<div class="gallery">'+ lHtmlBorrarArchivo + '<a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/PDF.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }
    else if ((lExtension == "doc") || (lExtension == "docx")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false;";
        ldiv.innerHTML = '<div class="gallery">' + lHtmlBorrarArchivo + '<a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/DOC.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }
    else if ((lExtension == "xls") || (lExtension == "xlsx")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false;";
        ldiv.innerHTML = '<div class="gallery">' + lHtmlBorrarArchivo + '<a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/XLS.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }
    else if ((lExtension == "zip") || (lExtension == "rar") || (lExtension == "bat") ||
            (lExtension == "exe") || (lExtension == "dll") || (lExtension == "cdr") ||
            (lExtension == "bat") || (lExtension == "dwg") || (lExtension == "ppt") ||
            (lExtension == "txt")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false;";
        ldiv.innerHTML = '<div class="gallery">' + lHtmlBorrarArchivo + '<a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/' + lExtension.toUpperCase() + '.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }
    else {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', " + pEsAuxiliar + ", this); return false;";
        ldiv.innerHTML = '<div class="gallery">' + lHtmlBorrarArchivo + '<a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/ARCH.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lhtmlDesc + '</div>';
    }


/*
    if (gListasAdjuntos[pNombreListaAdjuntos].BorraArchivos)
        lBorrarArchivo = '<div class="desc" onclick="' + lOnClickCerrar + '">' + lDescripcion + '<button type="button" class="close"><span aria-hidden="true">×</span></button></div>';
    else
        lBorrarArchivo = '<div class="desc">' + lDescripcion + '</div>';


    ldiv.className = "divAdjunto col-lg-2 col-md-2 col-sm-3 col-xs-6";
    if ((lExtension == "jpg") || (lExtension == "gif") || (lExtension == "png") || (lExtension == "bmp")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_MostrarArchivoImagen('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a href="javascript:void(0)" onclick="' + lOnClick + '"><img src="data:image/' + lExtension + ';base64,' + lDatosAdjunto.ArchivoBase64 + '"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>'+lBorrarArchivo+'</div>';
    }
    else if (lExtension == "pdf") {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_MostrarArchivoPDF('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/PDF.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lBorrarArchivo + '</div>';
    }
    else if ((lExtension == "doc") || (lExtension == "docx")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/DOC.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lBorrarArchivo + '</div>';
    }
    else if ((lExtension == "xls") || (lExtension == "xlsx")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/XLS.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lBorrarArchivo + '</div>';
    }
    else if ((lExtension == "zip") || (lExtension == "rar") || (lExtension == "bat") || 
            (lExtension == "exe") || (lExtension == "dll") || (lExtension == "cdr") || 
            (lExtension == "bat") || (lExtension == "dwg") || (lExtension == "ppt") ||
            (lExtension == "txt")) {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/' + lExtension.toUpperCase() + '.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lBorrarArchivo + '</div>';
    }
    else {
        if (gListasAdjuntos[pNombreListaAdjuntos].PermiteDescargar)
            lOnClick = "qlstadj_DescargarArchivo('" + pNombreListaAdjuntos + "', this);";
        ldiv.innerHTML = '<div class="gallery"><a target="_blank" href="javascript:void(0)" onclick="' + lOnClick + '"><img src="Imagenes/ARCH.png"  alt="' + lDatosAdjunto.NombreArchivo + '"/></a>' + lBorrarArchivo + '</div>';
    }
*/
    $('#' + pNombreListaAdjuntos)[0].appendChild(ldiv);
}

function qlstadj_VaciarLista(pNombreListaAdjuntos) {
    $('#' + pNombreListaAdjuntos).empty();
}


function qlstadj_VerifCantPermitida(pNombreListaAdjuntos) {
    
    if (gListasAdjuntos[pNombreListaAdjuntos].CantidadMaxima > 0)
    {
        var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;
        var lCant = 0;
        for (var i = 0; i < gEntidad[lNombreTabla].length; i++) {

            if (gEntidad[lNombreTabla][i].Estado != gEstadoAdjunto["Borrado"]) {
                lCant++;
            }
        }
        if (lCant >= gListasAdjuntos[pNombreListaAdjuntos].CantidadMaxima) {
            alert(qrecErrorCantAdjuntosPermitidos);
            return false;
        }
        else
            return true;
    }
    else
        return true;
}

function qlstadj_VerifTamanioPermitido(pTamanioArch, pNombreListaAdjuntos) {
    if ((gListasAdjuntos[pNombreListaAdjuntos].TamanioMaximo > 0) && 
        (gListasAdjuntos[pNombreListaAdjuntos].TamanioMaximo < Math.round(pTamanioArch / 1024) )) {
        alert(qrecErrorTamanioAdjuntos + ' ' + gListasAdjuntos[pNombreListaAdjuntos].TamanioMaximo + " KB.");
            return false;
    }
    else
        return true;
}



function qlstadj_MostrarArchivoPDF(pNombreListaAdjuntos, pEsAuxiliar, pObjeto) {
    //En el edge no se permite mostrar un embebido en un iframe
    if (qcom_EsEdge())
        qlstadj_DescargarArchivo(pNombreListaAdjuntos, pEsAuxiliar, pObjeto);
    else {
        var lAOcultar = pObjeto.parentNode.parentNode;
        var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;
        var lDatosAdjunto = null;
        if (!pEsAuxiliar)
            lDatosAdjunto = gEntidad;
        else
            lDatosAdjunto = gEntidadAux;
        

        var lPos = -1;
        if (!pEsAuxiliar) {
            for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
                if (lAOcultar.id == (pNombreListaAdjuntos + "_" + lDatosAdjunto[lNombreTabla][i].IDCol)) {
                    lPos = i;
                }
            }
        }
        else {
            for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
                if (lAOcultar.id == (pNombreListaAdjuntos + "_" + (lDatosAdjunto[lNombreTabla][i].Renglon - 1))) {
                    lPos = i;
                }
            }
        }
    }

    if (lPos != -1) {
        var lpdfWindow = window.open("", "_blank");
        lpdfWindow.document.write("<iframe width='100%' height='100%' src='data:application/pdf;base64," + encodeURI(lDatosAdjunto[lNombreTabla][lPos].ArchivoBase64) + "'></iframe>")
    }
}




function qlstadj_MostrarArchivoImagen(pNombreListaAdjuntos, pEsAuxiliar, pObjeto) {
    var lAOcultar = pObjeto.parentNode.parentNode;
    var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;

    var lDatosAdjunto = null;
    if (!pEsAuxiliar)
        lDatosAdjunto = gEntidad;
    else
        lDatosAdjunto = gEntidadAux;


    var lPos = -1;
    if (!pEsAuxiliar) {
        for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + lDatosAdjunto[lNombreTabla][i].IDCol)) {
                lPos = i;
            }
        }
    }
    else {
        for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + (lDatosAdjunto[lNombreTabla][i].Renglon - 1))) {
                lPos = i;
            }
        }
    }

    if (lPos != -1) {
        if (!pEsAuxiliar) {
            $("#" + pNombreListaAdjuntos + "_ModalImagen").empty();
            var larchBase64 = encodeURI(lDatosAdjunto[lNombreTabla][lPos].ArchivoBase64);
            $("#" + pNombreListaAdjuntos + "_tituloModal").html(lDatosAdjunto[lNombreTabla][lPos].NombreArchivo)
            $("#" + pNombreListaAdjuntos + "_ModalImagen").append('<img src="data:image/' + lDatosAdjunto[lNombreTabla][lPos].Extension.toLowerCase() + ';base64,' + larchBase64 + '" alt="' + lDatosAdjunto[lNombreTabla][lPos].NombreArchivo + '" style="max-height:100%; max-width:100%"/>');
            var lDivImagenModal = $("#div" + pNombreListaAdjuntos + "_modal");
            lDivImagenModal.modal({
                keyboard: true,
                tabindex: -1,
                backdrop: "static",
                show: true
            });
            lDivImagenModal.draggable({
                handle: ".modal-header"
            });
        }
        else {
            var lancho = $(window).width() * 0.50;
            var lalto = $(window).height() * 0.50;
            var image = new Image();
            var larchBase64 = encodeURI(lDatosAdjunto[lNombreTabla][lPos].ArchivoBase64);
            image.src = "data:image/" + lDatosAdjunto[lNombreTabla][lPos].Extension.toLowerCase() + ";base64," + larchBase64;

            smFtr = "toolbar=yes,scrollbars=yes,resizable=yes,top=10,left=10,width=" + lancho + ",height=" + lalto;
            //window.open(smUrl, '_blank', smFtr);

            var w = window.open("", '_blank', smFtr);
            w.document.write(image.outerHTML);
        }

    }
}


function qlstadj_DescargarArchivo(pNombreListaAdjuntos, pEsAuxiliar, pObjeto) {
    var lAOcultar = pObjeto.parentNode.parentNode;
    var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;
    var lDatosAdjunto = null;
    if (!pEsAuxiliar)
        lDatosAdjunto = gEntidad;
    else
        lDatosAdjunto = gEntidadAux;

    var lPos = -1;
    if (!pEsAuxiliar) {
        for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + lDatosAdjunto[lNombreTabla][i].IDCol)) {
                lPos = i;
            }
        }
    }
    else {
        for (var i = 0; (lPos == -1) && (i < lDatosAdjunto[lNombreTabla].length); i++) {
            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + (lDatosAdjunto[lNombreTabla][i].Renglon - 1))) {
                lPos = i;
            }
        }
    }

    if (lPos != -1) {
        var elem = window.document.createElement('a');
        elem.id = "reftemporal";
        elem.innerText = lDatosAdjunto[lNombreTabla][lPos].NombreArchivo;
        elem.href = 'data:application/octet-stream;base64,' + lDatosAdjunto[lNombreTabla][lPos].ArchivoBase64;
        elem.download = lDatosAdjunto[lNombreTabla][lPos].NombreArchivo;
        document.body.appendChild(elem);
        //solo paso el nombre "temporal" porque el método le agrega el href, porque se utiliza tambien con los controles con campos asociados
        qcom_DescargarArchivo("temporal", false)

        //download(a.href, a.download, "application/octet-stream");
        //download(elem.href, elem.download, "application/vnd.ms-excel");
        
        document.body.removeChild(elem);
    }
}

function qlstadj_QuitarDeLista(pNombreListaAdjuntos, pEsAuxiliar, pObjeto) {
    //busco el indice a borrar
    var lAOcultar = pObjeto.parentNode.parentNode.parentNode;
    var lNombreTabla = gListasAdjuntos[pNombreListaAdjuntos].Tabla;

    var lDatosAdjunto = null;
    if (!pEsAuxiliar)
        lDatosAdjunto = gEntidad;
    else
        lDatosAdjunto = gEntidadAux;


    var lencontre = false;
    if (!pEsAuxiliar) {
        for (var i = 0; (!lencontre) && i < lDatosAdjunto[lNombreTabla].length; i++) {

            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + lDatosAdjunto[lNombreTabla][i].IDCol)) {
                lencontre = true;
                //if (gEntidad[lNombreTabla][i].Estado == gEstadoAdjunto["Nuevo"])
                //    gEntidad[lNombreTabla].splice(i, 1);
                //else
                lDatosAdjunto[lNombreTabla][i].Estado = gEstadoAdjunto["Borrado"];
            }
        }
    }
    else {
        for (var i = 0; (!lencontre) && i < lDatosAdjunto[lNombreTabla].length; i++) {

            if (lAOcultar.id == (pNombreListaAdjuntos + "_" + (lDatosAdjunto[lNombreTabla][i].Renglon - 1))) {
                lencontre = true;
                //if (gEntidad[lNombreTabla][i].Estado == gEstadoAdjunto["Nuevo"])
                //    gEntidad[lNombreTabla].splice(i, 1);
                //else
                lDatosAdjunto[lNombreTabla][i].Estado = gEstadoAdjunto["Borrado"];
            }
        }
    }
    $('#' + pNombreListaAdjuntos)[0].removeChild(lAOcultar);
}

