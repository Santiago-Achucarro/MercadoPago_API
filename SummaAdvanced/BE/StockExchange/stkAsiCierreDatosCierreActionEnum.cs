using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkAsiCierreDatosCierreActionEnum
        {            public enum EnumstkAsiCierreDatosCierreAction
            {
                Datos
            }
        public static string GetAccionstkAsiCierreDatosCierreAction(stkAsiCierreDatosCierreActionEnum.EnumstkAsiCierreDatosCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkAsiCierreDatosCierreActionEnum.EnumstkAsiCierreDatosCierreAction.Datos: lRetorno = "stkAsiCierreDatosCierreDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
