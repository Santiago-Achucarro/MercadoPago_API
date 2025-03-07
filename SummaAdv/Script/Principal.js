
function Ejecutar(lFormulario)
{
    Menu_Toggle();
    ifPrincipal = top.document.getElementById('IfPrincipal');
    var lSrc ="webfrmbase.aspx?frm=" + lFormulario;
    ifPrincipal.src = lSrc;

}

