
function qBSAlert(options) {
    var deferredObject = $.Deferred();
    var defaults = {
        type: "alert", //alert, prompt,confirm 
        timeout: 0,
        modalSize: 'modal-sm', //modal-sm, modal-lg
        okButtonText: qrecAceptar,
        cancelButtonText: qrecCancelar,
        yesButtonText: qrecSi,
        noButtonText: qrecNo,
        headerText: 'Summa Advanced',
        messageText: qrecMensaje,
        alertType: 'default', //default, primary, success, info, warning, danger
        inputFieldType: 'text', //could ask for number,email,etc
        controlfoco:null,
    }
    $.extend(defaults, options);

    var _show = function () {
        //Inicio - quitado por error en quitar cortina
        //var _lz_index = qpopup_ZIndexObtener();
        var _lz_index = qpopup_ZIndexObtener();
        if (_lz_index < 10000)
            _lz_index = _lz_index + 10000;
        //Fin
        var headClass = "navbar-default";
        switch (defaults.alertType) {
            case "primary":
                headClass = "alert-primary";
                break;
            case "success":
                headClass = "alert-success";
                break;
            case "info":
                headClass = "alert-info";
                break;
            case "warning":
                headClass = "alert-warning";
                break;
            case "dangerQBI":
                headClass = "alert-danger";
                break;
            case "danger":
                headClass = "alert-danger";
                break;
        }
        $('BODY').append(
            //Inicio - quitado por error en quitar cortina
            //'<div id="qAlerts" class="modal fade" style="z-index: 11040">' +
            '<div id="qAlerts" class="modal fade" style="z-index: ' + _lz_index + '">' +
            //Fin
			'<div class="modal-dialog "' + defaults.modalSize + '">' +
			'<div class="modal-content">' +
			'<div id="qAlerts-header" class="modal-header ' + headClass + '">' +
			'<button id="close-button" type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span><span class="sr-only">Close</span></button>' +
			'<h4 id="qAlerts-title" class="modal-title">Modal title</h4>' +
			'</div>' +
			'<div id="qAlerts-body" class="modal-body">' +
			'<div id="qAlerts-message" style="text-align:center"></div>' +
			'</div>' +
			'<div id="qAlerts-footer" class="modal-footer ' + headClass + '">' +
			'</div>' +
			'</div>' +
			'</div>' +
			'</div>'
		);

        $('.modal-header').css({
            'padding': '15px 15px',
            '-webkit-border-top-left-radius': '5px',
            '-webkit-border-top-right-radius': '5px',
            '-moz-border-radius-topleft': '5px',
            '-moz-border-radius-topright': '5px',
            'border-top-left-radius': '5px',
            'border-top-right-radius': '5px'
        });

        $('#qAlerts-title').text(defaults.headerText);
        $('#qAlerts-message').html(defaults.messageText);

        var keyb = "false", backd = "static";
        var calbackParam = "";
        switch (defaults.type) {
            case 'alert':
                keyb = "true";
                backd = "true";
                //$('#qAlerts-footer').html('<button id="okButtonText" class="btn btn-' + defaults.alertType + '" autofocus tabindex="0">' + defaults.okButtonText + '</button>').on('click', ".btn", function () {
                //    calbackParam = true;
                //    $('#qAlerts').modal('hide');
                //});
                if (defaults.alertType != 'dangerQBI') {
                var btnhtml = '<button id="okButtonText" class="btn btn-' + defaults.alertType + '" autofocus tabindex="0">' + defaults.okButtonText + '</button>';
                $('#qAlerts-footer').html(btnhtml).on('click', 'button', function (e) {
                    if (e.target.id === 'okButtonText') {
                        calbackParam = true;
                        $('#qAlerts').modal('hide');
                    } 
                });
                $('#qAlerts-footer').html(btnhtml).on('keydown', 'button', function (e) {
                        e.preventDefault();
                });
                }

                break;
            case 'confirm':
                var btnhtml = '<button id="qok-btn" class="btn btn-' + defaults.alertType + '" tabindex="1">' + defaults.yesButtonText + '</button>';
                if (defaults.noButtonText && defaults.noButtonText.length > 0) {
                    btnhtml += '<button id="qclose-btn" class="btn btn-default" autofocus tabindex="0">' + defaults.noButtonText + '</button>';
                }
                $('#qAlerts-footer').html(btnhtml).on('click', 'button', function (e) {
                    if (e.target.id === 'qok-btn') {
                        calbackParam = true;
                        $('#qAlerts').modal('hide');
                    } else if (e.target.id === 'qclose-btn') {
                        calbackParam = false;
                        $('#qAlerts').modal('hide');
                    }
                });
                $('#qAlerts-footer').html(btnhtml).on('keydown', 'button', function (e) {
                        e.preventDefault();
                });

                break;
            case 'prompt':
                $('#qAlerts-message').html(defaults.messageText + '<br /><br /><div class="form-group"><input type="' + defaults.inputFieldType + '" class="form-control" id="prompt" /></div>');
                $('#qAlerts-footer').html('<button class="btn btn-primary">' + defaults.okButtonText + '</button>').on('click', ".btn", function () {
                    calbackParam = $('#prompt').val();
                    $('#qAlerts').modal('hide');
                });
                break;
        }

        $('#qAlerts').modal({
            show: false,
            backdrop: backd,
            keyboard: keyb
        }).on('hidden.bs.modal', function (e) {
            $('#qAlerts').remove();
            if (defaults.controlfoco != null)
            {
                defaults.controlfoco.focus();
            }
            deferredObject.resolve(calbackParam);
        }).on('shown.bs.modal', function (e) {
            if (defaults.type == 'alert')
                $("#okButtonText").focus();            
            else if (defaults.type == 'confirm')
                $("#qclose-btn").focus();
            if (defaults.timeout > 0)    
            {
                var myModal = $(this);
                clearTimeout(myModal.data('hideInterval'));
                myModal.data('hideInterval', setTimeout(function () {
                    myModal.modal('hide');
                }, defaults.timeout));
            }
        }).modal('show');
        $("#qAlerts").draggable({
            handle: ".modal-header"
        });
        $("#qAlerts").unbind('dragstop');
        $("#qAlerts").on("dragstop", function (event, ui) {
            if (ui.helper[0].offsetTop < 0)
                $("#qAlerts").offset({ top: 0, left: ui.helper[0].offsetLeft });
        })

    }

    _show();
    return deferredObject.promise();
}



//Invocaciones a los disitntos métodos
//$(document).ready(function () {
//    $("#btnAlert").on("click", function () {
//        var prom = ezBSAlert({
//            messageText: "hello world",
//            alertType: "danger"
//        }).done(function (e) {
//            $("body").append('<div>Callback from alert</div>');
//        });
//    });

//    $("#btnConfirm").on("click", function () {
//        ezBSAlert({
//            type: "confirm",
//            messageText: "hello world",
//            alertType: "info"
//        }).done(function (e) {
//            $("body").append('<div>Callback from confirm ' + e + '</div>');
//        });
//    });

//    $("#btnPrompt").on("click", function () {
//        ezBSAlert({
//            type: "prompt",
//            messageText: "Enter Something",
//            alertType: "primary"
//        }).done(function (e) {
//            ezBSAlert({
//                messageText: "You entered: " + e,
//                alertType: "success"
//            });
//        });
//    });

//});