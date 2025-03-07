using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosCostosSucursalActionEnum
        {            public enum EnumstkProductosCostosSucursalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkProductosCostosSucursalAction(stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction.Guardar: lRetorno = "stkProductosCostosSucursalGuardar"; break;
                case stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction.Datos: lRetorno = "stkProductosCostosSucursalDevolverDatos"; break;
                case stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction.Eliminar: lRetorno = "stkProductosCostosSucursalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
