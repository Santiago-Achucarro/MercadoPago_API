/// Generado por QBI jueves, 21 de octubre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange
{
    public static class espvenComandasDatosKSKActionEnum
    {
        public enum EnumespvenComandasDatosKSKAction
        {
            Datos, FacturarTicket
        }
        public static string GetAccionespvenComandasDatosKSKAction(espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction.Datos: lRetorno = "espvenComandasDatosKSKDevolverDatos"; break;
                case espvenComandasDatosKSKActionEnum.EnumespvenComandasDatosKSKAction.FacturarTicket: lRetorno = "espvenComandasDatosKSKFacturarTicket"; break;
            }
            return lRetorno;
        }
    }
}
