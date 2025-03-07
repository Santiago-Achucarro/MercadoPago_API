using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInvenSegmentosProximoActionEnum
        {            public enum EnumstkInvenSegmentosProximoAction
            {
                Asignar
            }
        public static string GetAccionstkInvenSegmentosProximoAction(stkInvenSegmentosProximoActionEnum.EnumstkInvenSegmentosProximoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInvenSegmentosProximoActionEnum.EnumstkInvenSegmentosProximoAction.Asignar: lRetorno = "stkInvenSegmentosProximoAsignar"; break;
            }
            return lRetorno;
        }
    }
}
