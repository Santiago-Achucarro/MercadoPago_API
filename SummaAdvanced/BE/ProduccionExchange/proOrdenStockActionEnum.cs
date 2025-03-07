using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenStockActionEnum
        {            public enum EnumproOrdenStockAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenStockAction(proOrdenStockActionEnum.EnumproOrdenStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenStockActionEnum.EnumproOrdenStockAction.Guardar: lRetorno = "proOrdenStockGuardar"; break;
                case proOrdenStockActionEnum.EnumproOrdenStockAction.Datos: lRetorno = "proOrdenStockDevolverDatos"; break;
                case proOrdenStockActionEnum.EnumproOrdenStockAction.Eliminar: lRetorno = "proOrdenStockEliminar"; break;
            }
            return lRetorno;
        }
    }
}
