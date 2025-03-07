using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 25 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impLiquidacionActionEnum
        {            public enum EnumimpLiquidacionAction
            {
                Guardar,Datos,Eliminar,Calcular,Pagar
            }
        public static string GetAccionimpLiquidacionAction(impLiquidacionActionEnum.EnumimpLiquidacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impLiquidacionActionEnum.EnumimpLiquidacionAction.Guardar: lRetorno = "impLiquidacionGuardar"; break;
                case impLiquidacionActionEnum.EnumimpLiquidacionAction.Datos: lRetorno = "impLiquidacionDevolverDatos"; break;
                case impLiquidacionActionEnum.EnumimpLiquidacionAction.Eliminar: lRetorno = "impLiquidacionEliminar"; break;
                case impLiquidacionActionEnum.EnumimpLiquidacionAction.Calcular: lRetorno = "impLiquidacionCalcular"; break;
                case impLiquidacionActionEnum.EnumimpLiquidacionAction.Pagar: lRetorno = "impLiquidacionPagar"; break;
            }
            return lRetorno;
        }
    }
}
