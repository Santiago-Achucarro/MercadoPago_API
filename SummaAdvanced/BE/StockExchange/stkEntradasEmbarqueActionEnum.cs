using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkEntradasEmbarqueActionEnum
        {            public enum EnumstkEntradasEmbarqueAction
            {
                Guardar,Datos,Eliminar,Todas
            }
        public static string GetAccionstkEntradasEmbarqueAction(stkEntradasEmbarqueActionEnum.EnumstkEntradasEmbarqueAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEntradasEmbarqueActionEnum.EnumstkEntradasEmbarqueAction.Guardar: lRetorno = "stkEntradasEmbarqueGuardar"; break;
                case stkEntradasEmbarqueActionEnum.EnumstkEntradasEmbarqueAction.Datos: lRetorno = "stkEntradasEmbarqueDevolverDatos"; break;
                case stkEntradasEmbarqueActionEnum.EnumstkEntradasEmbarqueAction.Eliminar: lRetorno = "stkEntradasEmbarqueEliminar"; break;
                case stkEntradasEmbarqueActionEnum.EnumstkEntradasEmbarqueAction.Todas: lRetorno = "stkEntradasEmbarqueTodas"; break;
            }
            return lRetorno;
        }
    }
}
