using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venEsquemaAutoRengActionEnum
        {            public enum EnumvenEsquemaAutoRengAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenEsquemaAutoRengAction(venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction.Guardar: lRetorno = "venEsquemaAutoRengGuardar"; break;
                case venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction.Datos: lRetorno = "venEsquemaAutoRengDevolverDatos"; break;
                case venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction.Eliminar: lRetorno = "venEsquemaAutoRengEliminar"; break;
            }
            return lRetorno;
        }
    }
}
