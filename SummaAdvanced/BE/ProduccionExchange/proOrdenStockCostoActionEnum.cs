using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenStockCostoActionEnum
        {            public enum EnumproOrdenStockCostoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenStockCostoAction(proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction.Guardar: lRetorno = "proOrdenStockCostoGuardar"; break;
                case proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction.Datos: lRetorno = "proOrdenStockCostoDevolverDatos"; break;
                case proOrdenStockCostoActionEnum.EnumproOrdenStockCostoAction.Eliminar: lRetorno = "proOrdenStockCostoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
