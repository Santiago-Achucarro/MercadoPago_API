using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 13 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviDespaActionEnum
        {            public enum EnumstkMoviDespaAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkMoviDespaAction(stkMoviDespaActionEnum.EnumstkMoviDespaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviDespaActionEnum.EnumstkMoviDespaAction.Guardar: lRetorno = "stkMoviDespaGuardar"; break;
                case stkMoviDespaActionEnum.EnumstkMoviDespaAction.Eliminar: lRetorno = "stkMoviDespaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
