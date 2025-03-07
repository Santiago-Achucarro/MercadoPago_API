using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 2 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCausaActionEnum
        {            public enum EnumstkMoviCausaAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkMoviCausaAction(stkMoviCausaActionEnum.EnumstkMoviCausaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCausaActionEnum.EnumstkMoviCausaAction.Guardar: lRetorno = "stkMoviCausaGuardar"; break;
                case stkMoviCausaActionEnum.EnumstkMoviCausaAction.Eliminar: lRetorno = "stkMoviCausaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
