import QtQuick 2.6
import QtQuick.Controls 2.0
import Actualizador 1.0

Page {
    id: page

    
       Grid {
            id: inputContainer
            columns: 2
            spacing: 12
            width: parent.width
            Label{
                text:"Version Remota"
            }
            Label{
                text:"Version Local"
            }
            Label{
                id: versionNueva
            }
            Label{
                id: versionActual
            }
            Label{
                text:"Empresa Remota"
            }
            Label{
                text:"Empresa Local"
            }
            Label{
                id: versionEspNueva
            }
            Label{
                id: versionEspActual
            }
            Button {
            text: 'Descargar Nueva Version'
            onClicked: {
                model.descargarPaquete()
                versionActual.text=model.versionActual
                versionNueva.text=model.versionNueva
            }
            }
            Button {
            text: 'Limpiar Carpeta Descargas'
            onClicked: {
                model.limpiarCarpeta()
            }
            }
            Descarga{
                id: model
                Component.onCompleted: function(){
                    
                    model.verificarVersion()
                    versionNueva.text=model.versionNueva
                    versionActual.text=model.versionActual
                    versionEspNueva.text=model.versionEmpresaNueva
                    versionEspActual.text=model.versionEmpresaActual
                    
                }
            }
        }
    }
