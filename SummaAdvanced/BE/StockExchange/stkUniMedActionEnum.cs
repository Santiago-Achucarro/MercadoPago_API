using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 13 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkUniMedActionEnum
        {            public enum EnumstkUniMedAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkUniMedAction(stkUniMedActionEnum.EnumstkUniMedAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkUniMedActionEnum.EnumstkUniMedAction.Guardar: lRetorno = "stkUniMedGuardar"; break;
                case stkUniMedActionEnum.EnumstkUniMedAction.Datos: lRetorno = "stkUniMedDevolverDatos"; break;
                case stkUniMedActionEnum.EnumstkUniMedAction.Eliminar: lRetorno = "stkUniMedEliminar"; break;
            }
            return lRetorno;
        }
    }
}
