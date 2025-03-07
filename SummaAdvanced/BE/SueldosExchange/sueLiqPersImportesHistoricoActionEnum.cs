using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, August 12, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqPersImportesHistoricoActionEnum
        {            public enum EnumsueLiqPersImportesHistoricoAction
            {
                Datos,Guardar,Ordenar
            }
        public static string GetAccionsueLiqPersImportesHistoricoAction(sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction.Datos: lRetorno = "sueLiqPersImportesHistoricoDevolverDatos"; break;
                case sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction.Guardar: lRetorno = "sueLiqPersImportesHistoricoGuardar"; break;
                case sueLiqPersImportesHistoricoActionEnum.EnumsueLiqPersImportesHistoricoAction.Ordenar: lRetorno = "sueLiqPersImportesHistoricoOrdenar"; break;
            }
            return lRetorno;
        }
    }
}
