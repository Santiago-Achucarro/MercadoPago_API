using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovConStockActionEnum
        {            public enum EnumvenMovConStockAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovConStockAction(venMovConStockActionEnum.EnumvenMovConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConStockActionEnum.EnumvenMovConStockAction.Guardar: lRetorno = "venMovConStockGuardar"; break;
                case venMovConStockActionEnum.EnumvenMovConStockAction.Datos: lRetorno = "venMovConStockDevolverDatos"; break;
                case venMovConStockActionEnum.EnumvenMovConStockAction.Eliminar: lRetorno = "venMovConStockEliminar"; break;
            }
            return lRetorno;
        }
    }
}
