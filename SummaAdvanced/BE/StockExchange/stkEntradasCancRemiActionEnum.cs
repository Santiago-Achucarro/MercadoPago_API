using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 15 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkEntradasCancRemiActionEnum
        {            public enum EnumstkEntradasCancRemiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkEntradasCancRemiAction(stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction.Guardar: lRetorno = "stkEntradasCancRemiGuardar"; break;
                case stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction.Datos: lRetorno = "stkEntradasCancRemiDevolverDatos"; break;
                case stkEntradasCancRemiActionEnum.EnumstkEntradasCancRemiAction.Eliminar: lRetorno = "stkEntradasCancRemiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
