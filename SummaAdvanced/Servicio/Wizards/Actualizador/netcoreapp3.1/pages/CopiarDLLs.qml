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
        Button{
            text:"CopiaDlls"
               onClicked:{
                   model.actualizar()
                   
               }
        }
            
            CopiaDLLs{
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
