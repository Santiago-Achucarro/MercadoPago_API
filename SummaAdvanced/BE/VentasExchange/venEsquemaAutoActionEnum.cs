using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venEsquemaAutoActionEnum
        {            public enum EnumvenEsquemaAutoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenEsquemaAutoAction(venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction.Guardar: lRetorno = "venEsquemaAutoGuardar"; break;
                case venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction.Datos: lRetorno = "venEsquemaAutoDevolverDatos"; break;
                case venEsquemaAutoActionEnum.EnumvenEsquemaAutoAction.Eliminar: lRetorno = "venEsquemaAutoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
