using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosCostosActionEnum
        {            public enum EnumstkProductosCostosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkProductosCostosAction(stkProductosCostosActionEnum.EnumstkProductosCostosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosCostosActionEnum.EnumstkProductosCostosAction.Guardar: lRetorno = "stkProductosCostosGuardar"; break;
                case stkProductosCostosActionEnum.EnumstkProductosCostosAction.Datos: lRetorno = "stkProductosCostosDevolverDatos"; break;
                case stkProductosCostosActionEnum.EnumstkProductosCostosAction.Eliminar: lRetorno = "stkProductosCostosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
