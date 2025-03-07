using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, August 12, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqVarGlobalHistoricoActionEnum
        {            public enum EnumsueLiqVarGlobalHistoricoAction
            {
                Datos,Guardar,Ordenar
            }
        public static string GetAccionsueLiqVarGlobalHistoricoAction(sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction.Datos: lRetorno = "sueLiqVarGlobalHistoricoDevolverDatos"; break;
                case sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction.Guardar: lRetorno = "sueLiqVarGlobalHistoricoGuardar"; break;
                case sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction.Ordenar: lRetorno = "sueLiqVarGlobalHistoricoOrdenar"; break;
            }
            return lRetorno;
        }
    }
}
