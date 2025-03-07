using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosCostoCierreSucursalActionEnum
        {            public enum EnumstkProductosCostoCierreSucursalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkProductosCostoCierreSucursalAction(stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction.Guardar: lRetorno = "stkProductosCostoCierreSucursalGuardar"; break;
                case stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction.Datos: lRetorno = "stkProductosCostoCierreSucursalDevolverDatos"; break;
                case stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction.Eliminar: lRetorno = "stkProductosCostoCierreSucursalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
