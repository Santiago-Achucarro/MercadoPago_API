import QtQuick 2.9
import QtQuick.Layouts 1.3
import QtQuick.Controls 2.3
import QtQuick.Controls.Material 2.1
import Actualizador 1.0
import QtQuick.Window 2.15

ApplicationWindow {
    id: window
    width: 1366/3-1366/3/30
    height: 600
    visible: true
    title: "Actualiza Advanced"
    x:1366/3/60
    y:80
    Material.theme: Material.Light
    Material.accent: '#00ccff'
    Material.primary: '#00ccff'
    Item {

    Window {
        title:"Consola"
        id: "consolewindow"
        visible: true
        width: 2*1366/3-2*1366/3/30
        height:600
        x:(1366/3/60)+(1366/3-1366/3/30)+(2*1366/3/60)
        y:80
        Loader{
            source:"pages/Console.qml"
        }
        
    }

    
    }
    Shortcut {
        sequences: ["Esc", "Back"]
        enabled: stackView.depth > 1
        onActivated: {
            stackView.pop()
            listView.currentIndex = -1
        }
    }

    Shortcut {
        sequence: "Menu"
        onActivated: optionsMenu.open()
    }

    header: ToolBar {
        Material.foreground: "white"

        RowLayout {
            spacing: 20
            anchors.fill: parent

            ToolButton {
                icon.source: stackView.depth > 1 ? "images/back.png" : "images/drawer.png"
                onClicked: {
                    if (stackView.depth > 1) {
                        stackView.pop()
                        listView.currentIndex = -1
                    } else {
                        drawer.open()
                    }
                }
            }

            Label {
                id: titleLabel
                text: listView.currentItem ? listView.currentItem.text : "Actualizador"
                font.pixelSize: 20
                elide: Label.ElideRight
                horizontalAlignment: Qt.AlignHCenter
                verticalAlignment: Qt.AlignVCenter
                Layout.fillWidth: true
            }

            ToolButton {
                icon.source: "images/menu.png"
                onClicked: optionsMenu.open()

                Menu {
                    id: optionsMenu
                    x: parent.width - width
                    transformOrigin: Menu.TopRight

                    MenuItem {
                        text: "Console"
                        onTriggered: consolewindow.show()
                    }
                    MenuItem {
                        text: "About"
                        onTriggered: aboutDialog.open()
                    }
                }
            }
        }
    }

    Drawer {
        id: drawer
        width: Math.min(window.width, window.height) / 3 * 2
        height: window.height
        interactive: stackView.depth === 1

        ListView {
            id: listView

            focus: true
            currentIndex: -1
            anchors.fill: parent

            delegate: ItemDelegate {
                width: parent.width
                text: model.title
                highlighted: ListView.isCurrentItem
                onClicked: {
                    listView.currentIndex = index
                    stackView.push(model.source)
                    drawer.close()
                }
            }

            model: ListModel {
                ListElement { title: "ActualizarBD"; source: "pages/UpdateBD.qml" }
                ListElement { title: "Iniciar/Detener QBI"; source: "pages/QBI.qml" }
                ListElement { title: "Copiar DLLs"; source: "pages/CopiarDLLs.qml" }
                ListElement { title: "Copiar App Web"; source: "pages/CopiarWeb.qml" }
                ListElement { title: "Configuracion"; source: "pages/Configuracion.qml" }
                ListElement { title: "Descargar"; source: "pages/Descarga.qml" }  
            }

            ScrollIndicator.vertical: ScrollIndicator { }
        }
    }

    StackView {
        id: stackView
        anchors.fill: parent

        initialItem: Pane {
            id: pane

            Image {
                id: logo
                width: pane.availableWidth / 2
                height: pane.availableHeight / 2
                anchors.centerIn: parent
                anchors.verticalCenterOffset: -50
                fillMode: Image.PreserveAspectFit
                source: "images/SummaLogo.png"
            }

            Label {
                text: "Ejecutar Proceso de Actualizacion Completo"
                anchors.margins: 20
                anchors.top: logo.bottom
                anchors.left: parent.left
                anchors.right: parent.right
                anchors.bottom: arrow.top
                horizontalAlignment: Label.AlignHCenter
                verticalAlignment: Label.AlignVCenter
                wrapMode: Label.Wrap
            }

            Image {
                id: arrow
                source: "images/process.png"
                anchors.left: parent.left
                anchors.bottom: parent.bottom
                height:parent.height/5
                width:height
                MouseArea {
                anchors.fill: parent
                onClicked: {
                    model.procesoCompleto()
                }
                
               
                } 
               
            }
        }
    }
    
    Dialog {
        id: aboutDialog
        modal: true
        focus: true
        title: "About"
        x: (window.width - width) / 2
        y: window.height / 6
        width: Math.min(window.width, window.height) / 3 * 2

        Label {
            width: aboutDialog.availableWidth
            text: "Programa para pruebas del proceso de actualizacion automatica y para corregir problemas en caso de que el mismo falle"
            wrapMode: Label.Wrap
            font.pixelSize: 12
        }
    }
    Main{
        id:model
        Component.onCompleted: function(){
            model.generarGuid()
        }
    }
}
