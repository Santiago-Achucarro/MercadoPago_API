using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 29 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class StockCerrarActionEnum
    {
        public enum EnumStockCerrarAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionStockCerrarAction(StockCerrarActionEnum.EnumStockCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case StockCerrarActionEnum.EnumStockCerrarAction.Guardar: lRetorno = "StockCerrarGuardar"; break;
                case StockCerrarActionEnum.EnumStockCerrarAction.Datos: lRetorno = "StockCerrarDevolverDatos"; break;
                case StockCerrarActionEnum.EnumStockCerrarAction.Eliminar: lRetorno = "StockCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
