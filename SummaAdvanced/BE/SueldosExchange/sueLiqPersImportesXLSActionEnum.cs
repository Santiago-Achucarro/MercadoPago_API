using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 23, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqPersImportesXLSActionEnum
        {            public enum EnumsueLiqPersImportesXLSAction
            {
                Guardar
            }
        public static string GetAccionsueLiqPersImportesXLSAction(sueLiqPersImportesXLSActionEnum.EnumsueLiqPersImportesXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqPersImportesXLSActionEnum.EnumsueLiqPersImportesXLSAction.Guardar: lRetorno = "sueLiqPersImportesXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
