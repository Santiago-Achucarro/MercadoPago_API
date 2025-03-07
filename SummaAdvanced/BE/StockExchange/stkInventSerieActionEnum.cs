using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInventSerieActionEnum
        {            public enum EnumstkInventSerieAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionstkInventSerieAction(stkInventSerieActionEnum.EnumstkInventSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInventSerieActionEnum.EnumstkInventSerieAction.Guardar: lRetorno = "stkInventSerieGuardar"; break;
                case stkInventSerieActionEnum.EnumstkInventSerieAction.Eliminar: lRetorno = "stkInventSerieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
