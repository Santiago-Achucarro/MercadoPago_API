import QtQuick 2.6
import QtQuick.Controls 2.0
import Actualizador 1.0
import QtQuick.Dialogs 1.3
import QtQuick.Layouts 1.15

Page {
    id: page

    default property alias content: pane.contentItem

    Flickable {
        anchors.fill: parent
        contentHeight: pane.implicitHeight
        flickableDirection: Flickable.AutoFlickIfNeeded

        Pane {
            id: pane
            width: parent.width
       GridLayout {
            id: inputContainer
            columns: 2
            
            width: parent.width

            //Ruta Config QBI
            Label{
                id: tituloRutaConfig
                text:"Ruta QBIServicio.config.exe"
                Layout.columnSpan:2
            }
            TextField { 
                id: rutaConfig
                width:parent.width
                Layout.fillWidth:true
                selectByMouse:true
            }
            Button{
                text:'...'
                onClicked: {
                
                
                fileDiagConfig.open()
                
                }
            }
            FileDialog
            {
                id: "fileDiagConfig"
                sidebarVisible:true
                nameFilters:[ "Configuration File (*.config)", "All files (*)" ]
                selectExisting:true
                folder:"C:\\"
                onAccepted:{
                    rutaConfig.text=model.procesaRuta(fileDiagConfig.fileUrl)
                }
            }

            //Ruta Actions
            Label{
                
                text:"Carpeta Actions"
                Layout.columnSpan:2
            }
            TextField { 
                id: carpetaActions
                width:parent.width
                Layout.fillWidth:true
                selectByMouse:true
            }
            Button{
                text:'...'
                onClicked: {
                
                
                fileDiagActions.open()
                
                }
            }
            FileDialog
            {
                id: "fileDiagActions"
                sidebarVisible:true
                selectFolder:true
                selectExisting:true
                folder:"C:\\"
                onAccepted:{
                    carpetaActions.text= model.procesaRuta(fileDiagActions.folder)
                }
            }
            //Ruta Sitio Web
            Label{
                
                text:"Carpeta SummaWeb"
                Layout.columnSpan:2
            }
            TextField { 
                id: carpetaSitio
                width:parent.width
                Layout.fillWidth:true
                selectByMouse:true
            }
            Button{
                text:'...'
                onClicked: {
                    
                fileDiagSitio.open()
                
                }
            }
            FileDialog
            {
                id: "fileDiagSitio"
                sidebarVisible:true
                selectFolder:true
                selectExisting:true
                folder:"C:\\"
                onAccepted:{
                    carpetaSitio.text= model.procesaRuta(fileDiagSitio.folder)
                }
            }
            //Carpeta Descargas
            Label{
                
                text:"Carpeta Descargas"
                Layout.columnSpan:2
            }
            TextField { 
                id: carpetaDescargas
                width:parent.width
                Layout.fillWidth:true
                selectByMouse:true
            }
            Button{
                text:'...'
                onClicked: {
                
                
                fileDiagDescargas.open()
                
                }
            }
            FileDialog
            {
                id: "fileDiagDescargas"
                sidebarVisible:true
                selectFolder:true
                selectExisting:true
                folder:"C:\\"
                onAccepted:{
                    carpetaDescargas.text= model.procesaRuta(fileDiagDescargas.folder)
                }
            }
            //Nombre del servicio
            Label{
                
                text:"Nombre del Servicio QBI"
                Layout.columnSpan:2
            }
            TextField { 
                id: nombreServicio
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
                selectByMouse:true
            }

            
            // Nombre Especializacion
            Label{
                
                text:"Especializacion"
                Layout.columnSpan:2
            }
            TextField { 
                id: especializacion
                width:parent.width
                Layout.columnSpan:2
                Layout.fillWidth:true
                selectByMouse:true
            }

            //Pais
            Label{
                
                text:"Pais"
                Layout.columnSpan:2
            }
            TextField { 
                id: pais
                width:parent.width
                Layout.columnSpan:2
                Layout.fillWidth:true
            }

            //Correo Reportes
            Label{
                
                text:"Destinatario Correo Errores"
                Layout.columnSpan:2
            }
            TextField { 
                id: correoErrores
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
            }
            Button {
            text: 'Guardar'
            onClicked: {
                model.rutaConfigQBI=rutaConfig.text
                model.nombreServicioQBI=nombreServicio.text
                model.carpetaDescargas=carpetaDescargas.text
                model.especializacion= especializacion.text
                model.pais=pais.text
                model.rutaSitioWeb=carpetaSitio.text
                model.rutaActions=carpetaActions.text
                model.mailReportes=correoErrores.text
                model.guardarConfiguracion()
            }
            }
            Configuracion{
                id: model
                Component.onCompleted: function(){
                    
                    model.cargarConfiguracion()
                    rutaConfig.text=model.rutaConfigQBI
                    nombreServicio.text=model.nombreServicioQBI
                    especializacion.text=model.especializacion
                    carpetaDescargas.text=model.carpetaDescargas
                    pais.text=model.pais
                    carpetaSitio.text=model.rutaSitioWeb
                    carpetaActions.text=model.rutaActions
                    correoErrores.text=model.mailReportes
                }
            }
            }

        ScrollIndicator.vertical: ScrollIndicator { }
        }
    }
}
