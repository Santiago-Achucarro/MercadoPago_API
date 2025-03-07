using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqVarGlobalesActionEnum
        {            public enum EnumsueLiqVarGlobalesAction
            {
                Guardar,Datos,Eliminar, ActualizarWS
        }
        public static string GetAccionsueLiqVarGlobalesAction(sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction.Guardar: lRetorno = "sueLiqVarGlobalesGuardar"; break;
                case sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction.Datos: lRetorno = "sueLiqVarGlobalesDevolverDatos"; break;
                case sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction.Eliminar: lRetorno = "sueLiqVarGlobalesEliminar"; break;
                case sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction.ActualizarWS: lRetorno = "sueLiqVarGlobalesActualizarWS"; break;
            }
            return lRetorno;
        }
    }
}
