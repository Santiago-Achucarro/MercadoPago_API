using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comComprasConsPendActionEnum
        {            public enum EnumcomComprasConsPendAction
            {
                Datos
            }
        public static string GetAccioncomComprasConsPendAction(comComprasConsPendActionEnum.EnumcomComprasConsPendAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comComprasConsPendActionEnum.EnumcomComprasConsPendAction.Datos: lRetorno = "comComprasConsPendDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
