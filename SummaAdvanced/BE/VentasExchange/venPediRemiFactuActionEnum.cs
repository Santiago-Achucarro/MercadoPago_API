using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 11 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediRemiFactuActionEnum
        {            public enum EnumvenPediRemiFactuAction
            {
                Datos
            }
        public static string GetAccionvenPediRemiFactuAction(venPediRemiFactuActionEnum.EnumvenPediRemiFactuAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediRemiFactuActionEnum.EnumvenPediRemiFactuAction.Datos: lRetorno = "venPediRemiFactuDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
