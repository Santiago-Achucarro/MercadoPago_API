using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 5 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovConStockCrActionEnum
        {            public enum EnumvenMovConStockCrAction
            {
                Guardar,Eliminar,Datos
            }
        public static string GetAccionvenMovConStockCrAction(venMovConStockCrActionEnum.EnumvenMovConStockCrAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConStockCrActionEnum.EnumvenMovConStockCrAction.Guardar: lRetorno = "venMovConStockCrGuardar"; break;
                case venMovConStockCrActionEnum.EnumvenMovConStockCrAction.Eliminar: lRetorno = "venMovConStockCrEliminar"; break;
                case venMovConStockCrActionEnum.EnumvenMovConStockCrAction.Datos: lRetorno = "venMovConStockCrDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
