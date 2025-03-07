using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 5 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInvenSegmentosActionEnum
        {            public enum EnumstkInvenSegmentosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkInvenSegmentosAction(stkInvenSegmentosActionEnum.EnumstkInvenSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInvenSegmentosActionEnum.EnumstkInvenSegmentosAction.Guardar: lRetorno = "stkInvenSegmentosGuardar"; break;
                case stkInvenSegmentosActionEnum.EnumstkInvenSegmentosAction.Datos: lRetorno = "stkInvenSegmentosDevolverDatos"; break;
                case stkInvenSegmentosActionEnum.EnumstkInvenSegmentosAction.Eliminar: lRetorno = "stkInvenSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
