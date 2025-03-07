import QtQuick 2.6
import QtQuick.Controls 2.0
import Actualizador 1.0
import QtQuick.Dialogs 1.3
import QtQuick.Layouts 1.15

Page {
        
    id: page
    default property alias content: pane.contentItem
    width:parent.width
    
    
        
        Pane {
            id: pane
            width: parent.width
            ColumnLayout
        {
        GridLayout{
            columns:4
            width:parent.width
        
        Label{
            text:model.estado
            Layout.columnSpan:4

        }
        ProgressBar{
            id:barra
            value:model.porcentaje
            to:model.porcentajeMax
            
            Layout.columnSpan:4
        }

        Button{
               text:"Actualizar\nbases de datos"
               onClicked:{
                   
            
         model.server=servidor.text
         model.base =base.text
         model.usuario=usuario.text
         model.password=clave.text
         model.dirStd =dirStd.text
         model.dirEsp =dirEsp.text
         model.chkStd =chkStd.checked
         model.chkEsp =chkEsp.checked
         model.desarrollo =chkDesarrollo.checked
         model.procesoDesarrollo=false
                   model.actualizar()
                   
               }
               Layout.columnSpan:1
           }
           Button{
               text:"Update\nDesarrollo"
               visible:false
               id:'btnDesarrollo'
               onClicked:{
                   
            
         model.server=servidor.text
         model.base =base.text
         model.usuario=usuario.text
         model.password=clave.text
         model.dirStd =dirStd.text
         model.dirEsp =dirEsp.text
         model.chkStd =chkStd.checked
         model.chkEsp =chkEsp.checked
         model.procesoDesarrollo=true
         
         labelFormulario.visible=true
         solapados.visible=true
         model.desarrollo=true
                   model.actualizar()
                   

               }
               Layout.columnSpan:1
           }
           Button{
               text:"Controles\nSolapados"
               id:btnSolapados
               visible:false
               onClicked:{
                   
               }
               Layout.columnSpan:1
           }
           
           
           CheckBox{
               id:'chkDesarrollo'
               checked:false
               text:"Desarrollo"
               Layout.columnSpan:4

               onClicked:{
                   if(chkDesarrollo.checked==true){
                       conexiones.visible=false
                       grdDesarrollo.visible=true
                       //btnDesarrollo.visible=true
                       //btnSolapados.visible=true

                   }
                   if(chkDesarrollo.checked==false){
                       conexiones.visible=true
                       grdDesarrollo.visible=false
                       btnDesarrollo.visible=false
                       btnSolapados.visible=false
                   }

               }
           }
        // Produccion
        TextArea{
            id:conexiones
            visible:true
            //Layout.columnSpan:4
            readOnly:true
        }
        }
GridLayout{
            columns:8
            id:grdDesarrollo
            width:parent.width
            Layout.columnSpan:4
            visible:false
        // Desarrollo
        Label{
                id:'lblServidor'
                text:"Servidor"
                Layout.columnSpan:2
            }
            Label{
                id:'lblBase'
                text:"Base"
                Layout.columnSpan:2
            }
            Label{
                id:'lblUsuario'
                text:"Usuario"
                Layout.columnSpan:2
            }
            Label{
                id:'lblClave'
                text:"Clave"
                Layout.columnSpan:2
                
            }
            TextField { 
                id: 'servidor'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
                selectByMouse:true
            }
            TextField { 
                id: 'base'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
                selectByMouse:true
            }
            TextField { 
                id: 'usuario'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
                selectByMouse:true
            }
            TextField { 
                id: 'clave'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:2
                selectByMouse:true
                echoMode:TextInput.Password
            }
            Label {
                id:'lblStd'
                text:'Scripts Estandar'
                Layout.columnSpan:8
            }
            TextField { 
                id: 'dirStd'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:6
                selectByMouse:true
            }
            Button{
                id:'btnStd'
                text:'...'
                onClicked: {
                
                fileDiagDirStd.open()
                
                }
            }
            CheckBox{
                id:'chkStd'
                checked:true
            }

            FileDialog
            {
                id: "fileDiagDirStd"
                sidebarVisible:true
                
                selectExisting:true
                selectFolder:true
                folder:"File:///C:/SummaAdvanced/Scripts"
                onAccepted:{
                    dirStd.text=model.procesaRuta(fileDiagDirStd.folder)
                }
            }

            Label {
                id:'lblEsp'
                text:'Scripts Empresa'
                Layout.columnSpan:8
            }
            TextField { 
                id: 'dirEsp'
                width:parent.width
                Layout.fillWidth:true
                Layout.columnSpan:6
                selectByMouse:true
            }
            Button{
                id:btnEsp
                text:'...'
                onClicked: {
                
                
                fileDiagDirEsp.open()
                
                }
            }
            CheckBox{
                id:'chkEsp'
                checked:true
            }
            FileDialog
            {
                id: "fileDiagDirEsp"
                sidebarVisible:true
                selectFolder:true
                selectExisting:true
                folder:"File:///C:/SummaAdvancedQ/Empresas"
                onAccepted:{
                    dirEsp.text=model.procesaRuta(fileDiagDirEsp.folder)
                }
            }
            TextField{
            id:solapados
            visible:false
            }
            Label{
            id:labelFormulario
            visible:false
            text:model.labelFormulario
            }
        }
        
           
           BDUpdate{
               id: model
                Component.onCompleted: function(){
                    model.obtenerConexiones()
                    
                    conexiones.text=model.conexiones
                    servidor.text=model.server
                    base.text=model.base
                    usuario.text=model.usuario
                    clave.text=model.password
                    dirStd.text=model.dirStd
                    dirEsp.text=model.dirEsp 
         

                }
           }
        
        


    }
}   
     
}
