using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviEmbarqueActionEnum
        {            public enum EnumstkMoviEmbarqueAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkMoviEmbarqueAction(stkMoviEmbarqueActionEnum.EnumstkMoviEmbarqueAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviEmbarqueActionEnum.EnumstkMoviEmbarqueAction.Guardar: lRetorno = "stkMoviEmbarqueGuardar"; break;
                case stkMoviEmbarqueActionEnum.EnumstkMoviEmbarqueAction.Eliminar: lRetorno = "stkMoviEmbarqueEliminar"; break;
            }
            return lRetorno;
        }
    }
}
