using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasPrecBoniRecActionEnum
        {            public enum EnumvenListasPrecBoniRecAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenListasPrecBoniRecAction(venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction.Guardar: lRetorno = "venListasPrecBoniRecGuardar"; break;
                case venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction.Datos: lRetorno = "venListasPrecBoniRecDevolverDatos"; break;
                case venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction.Eliminar: lRetorno = "venListasPrecBoniRecEliminar"; break;
            }
            return lRetorno;
        }
    }
}
