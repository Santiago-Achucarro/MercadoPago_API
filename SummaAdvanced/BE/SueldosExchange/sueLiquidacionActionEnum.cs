using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 2 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiquidacionActionEnum
        {            public enum EnumsueLiquidacionAction
            {
                Guardar,Datos,Eliminar, DatosInt
            }
        public static string GetAccionsueLiquidacionAction(sueLiquidacionActionEnum.EnumsueLiquidacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiquidacionActionEnum.EnumsueLiquidacionAction.Guardar: lRetorno = "sueLiquidacionGuardar"; break;
                case sueLiquidacionActionEnum.EnumsueLiquidacionAction.Datos: lRetorno = "sueLiquidacionDevolverDatos"; break;
                case sueLiquidacionActionEnum.EnumsueLiquidacionAction.Eliminar: lRetorno = "sueLiquidacionEliminar"; break;
                case sueLiquidacionActionEnum.EnumsueLiquidacionAction.DatosInt: lRetorno = "sueLiquidacionDatosInt"; break;
            }
            return lRetorno;
        }
    }
}
