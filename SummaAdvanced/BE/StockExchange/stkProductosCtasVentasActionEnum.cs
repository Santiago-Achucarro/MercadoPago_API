using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 31 de mayo de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosCtasVentasActionEnum
        {            public enum EnumstkProductosCtasVentasAction
            {
                Datos
            }
        public static string GetAccionstkProductosCtasVentasAction(stkProductosCtasVentasActionEnum.EnumstkProductosCtasVentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosCtasVentasActionEnum.EnumstkProductosCtasVentasAction.Datos: lRetorno = "stkProductosCtasVentasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
