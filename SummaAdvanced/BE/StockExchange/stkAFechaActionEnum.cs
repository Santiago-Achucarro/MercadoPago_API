using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkAFechaActionEnum
        {            public enum EnumstkAFechaAction
            {
                Datos
            }
        public static string GetAccionstkAFechaAction(stkAFechaActionEnum.EnumstkAFechaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkAFechaActionEnum.EnumstkAFechaAction.Datos: lRetorno = "stkAFechaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
