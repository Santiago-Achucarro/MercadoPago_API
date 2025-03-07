using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 29 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovStkHistDevolverIdMovStockActionEnum
        {            public enum EnumvenMovStkHistDevolverIdMovStockAction
            {
                Datos
            }
        public static string GetAccionvenMovStkHistDevolverIdMovStockAction(venMovStkHistDevolverIdMovStockActionEnum.EnumvenMovStkHistDevolverIdMovStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovStkHistDevolverIdMovStockActionEnum.EnumvenMovStkHistDevolverIdMovStockAction.Datos: lRetorno = "venMovStkHistDevolverIdMovStockDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
