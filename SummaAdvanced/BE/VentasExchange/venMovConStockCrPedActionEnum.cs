using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovConStockCrPedActionEnum
        {            public enum EnumvenMovConStockCrPedAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovConStockCrPedAction(venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction.Guardar: lRetorno = "venMovConStockCrPedGuardar"; break;
                case venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction.Datos: lRetorno = "venMovConStockCrPedDevolverDatos"; break;
                case venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction.Eliminar: lRetorno = "venMovConStockCrPedEliminar"; break;
            }
            return lRetorno;
        }
    }
}
