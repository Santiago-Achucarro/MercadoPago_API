using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCondFisCompraActionEnum
        {            public enum EnumstkCondFisCompraAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkCondFisCompraAction(stkCondFisCompraActionEnum.EnumstkCondFisCompraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCondFisCompraActionEnum.EnumstkCondFisCompraAction.Guardar: lRetorno = "stkCondFisCompraGuardar"; break;
                case stkCondFisCompraActionEnum.EnumstkCondFisCompraAction.Datos: lRetorno = "stkCondFisCompraDevolverDatos"; break;
                case stkCondFisCompraActionEnum.EnumstkCondFisCompraAction.Eliminar: lRetorno = "stkCondFisCompraEliminar"; break;
            }
            return lRetorno;
        }
    }
}
