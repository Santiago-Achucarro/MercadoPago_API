using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, August 12, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqCateNombreHistoricoActionEnum
        {            public enum EnumsueLiqCateNombreHistoricoAction
            {
                Datos,Guardar,Ordenar
            }
        public static string GetAccionsueLiqCateNombreHistoricoAction(sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction.Datos: lRetorno = "sueLiqCateNombreHistoricoDevolverDatos"; break;
                case sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction.Guardar: lRetorno = "sueLiqCateNombreHistoricoGuardar"; break;
                case sueLiqCateNombreHistoricoActionEnum.EnumsueLiqCateNombreHistoricoAction.Ordenar: lRetorno = "sueLiqCateNombreHistoricoOrdenar"; break;
            }
            return lRetorno;
        }
    }
}
