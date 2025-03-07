import QtQuick 2.6

import Actualizador 1.0
import QtQuick.Dialogs 1.3
import QtQuick.Layouts 1.15
import QtQuick.Controls 2.15

Page {
    id: page
    width:consolewindow.width
    GridLayout{
        columns:6
        width:consolewindow.width
        columnSpacing:0
        Label{
            id:'lblSalida'
            text:"Salida"
            font.pixelSize: 17
            
        }
        CheckBox{
            id:'chkAutoScroll'
            checked:true
            text:"Auto-Scroll"
            width:100
        }
        CheckBox{
            id:'chkExitos'
            checked:true
            text:"Exitos"
            width:100
        }
        CheckBox{
            id:'chkMensajes'
            checked:false
            text:"Mensajes"
            width:100
        }
        CheckBox{
            id:'chkErrores'
            checked:true
            text:"Errores"
            width:100
        }
        Button{
                text:'limpiar'
                onClicked: {
                
                
                model.limpiar()
                
                }
            }
        Flickable {
    id: flickable
    width:consolewindow.width
    height:consolewindow.height-chkAutoScroll.height

    TextArea.flickable: TextArea {
        id:'texto'
        text: model.mensaje
        wrapMode: TextArea.Wrap
        selectByMouse:true
        readOnly:true
        textFormat:TextEdit.RichText
        
    }

    ScrollBar.vertical: ScrollBar { }
    Layout.columnSpan:6
    onFlickStarted: {
            chkAutoScroll.checked=false
        }
    }
    }



    
    


    
    Console{
        id:model
        Component.onCompleted: function(){
                    model.escuchar()
                    
                    }
    }
    Timer{
        interval:200
        running:true
        repeat:true
        onTriggered:{
            model.errores=chkErrores.checked
            model.exitos=chkExitos.checked
            model.mensajes=chkMensajes.checked
            model.escuchar()
            if(chkAutoScroll.checked)
            {
                flickable.contentY=flickable.contentHeight-consolewindow.height+chkAutoScroll.height
            }
        }
    }
}