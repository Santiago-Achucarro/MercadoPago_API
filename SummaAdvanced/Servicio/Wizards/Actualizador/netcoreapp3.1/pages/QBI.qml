import QtQuick 2.6
import QtQuick.Controls 2.0
import Actualizador 1.0

Page {
    id: page

    
       Grid {
            id: inputContainer
            columns: 1
            spacing: 12
            width: parent.width
            Label{
                id: estado
                text:"Estado del servicio"
                
            }
            Button {
            text: 'Iniciar Servicio'
            onClicked: {
                model.iniciarQBI()
                estado.text=model.estado
            }
            }
            Button {
            text: 'Detener Servicio'
            onClicked: {
                model.detenerQBI()
                estado.text=model.estado
            }
            }
            QBI{
                id: model
                Component.onCompleted: function(){
                    
                    model.estadoQBI()
                    estado.text=model.estado
                }
            }
        }
    }
