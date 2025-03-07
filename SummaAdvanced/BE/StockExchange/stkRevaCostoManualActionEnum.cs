using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 3 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRevaCostoManualActionEnum
        {            public enum EnumstkRevaCostoManualAction
            {
                Guardar,Datos,Eliminar,Agregar,ImportarXLS
            }
        public static string GetAccionstkRevaCostoManualAction(stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction.Guardar: lRetorno = "stkRevaCostoManualGuardar"; break;
                case stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction.Datos: lRetorno = "stkRevaCostoManualDevolverDatos"; break;
                case stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction.Eliminar: lRetorno = "stkRevaCostoManualEliminar"; break;
                case stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction.Agregar: lRetorno = "stkRevaCostoManualAgregar"; break;
                case stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction.ImportarXLS: lRetorno = "stkRevaCostoManualImportarXls"; break;
            }
            return lRetorno;
        }
    }
}
