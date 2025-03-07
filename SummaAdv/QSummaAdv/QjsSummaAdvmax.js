var gComponenteValido = true;
function qQuasarComponentes() {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/QuasarComponentes",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
            if (data.d == "1") {
                gComponenteValido = false;
                window.open('webfrmError.aspx?error=3', '_top');
            }
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}


function qCerrarSesion() {
    var lIdSes = sessionStorage.getItem("idses");
    var lData = JSON.stringify({ 'pIdSes': lIdSes });
    $.ajax({
        type: "POST",
        url: "webfrmPrincipal.aspx/CerrarSesionUsuario",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: lData,
    })
    .done(function (data) {
        if (!data.d.startsWith("error:")) {
        }
        else
            qcom_TratarError(data.d);
    })
    .fail(function (xhr, ajaxOptions, thrownError) {
        qcom_Alerta(xhr.responseText, 'danger', null);
    });
}
