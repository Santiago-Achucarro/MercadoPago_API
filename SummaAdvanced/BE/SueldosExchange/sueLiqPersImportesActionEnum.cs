using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, August 12, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLiqPersImportesActionEnum
        {            public enum EnumsueLiqPersImportesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueLiqPersImportesAction(sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction.Guardar: lRetorno = "sueLiqPersImportesGuardar"; break;
                case sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction.Datos: lRetorno = "sueLiqPersImportesDevolverDatos"; break;
                case sueLiqPersImportesActionEnum.EnumsueLiqPersImportesAction.Eliminar: lRetorno = "sueLiqPersImportesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
