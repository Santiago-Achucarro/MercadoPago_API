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
        Grid{
            columns:1
        
            Label{
            id:mensaje
        }
        Button{
               text:"Modificar Web.config"
               onClicked:{
                   model.remplazarXML()
                   xmlNuevo.text=model.xmlNuevo
                   mensaje.text=model.mensaje
               }
           }
           Button{
               text:"Modificar Web.config y Actualizar"
               onClicked:{
                   model.actualizar()
                   xmlNuevo.text=model.xmlNuevo
                   mensaje.text=model.mensaje
               }
           }
           
        TextArea{
            id:xmlNuevo
        }
        
        
           
           CopiaWeb{
               id: model
                Component.onCompleted: function(){
                    model.obtenerXML()
                    mensaje.text=model.mensaje
                    xmlNuevo.text=model.xmlNuevo
                }
           }
        }
        }

        ScrollIndicator.vertical: ScrollIndicator { }
    }
   
     
}
