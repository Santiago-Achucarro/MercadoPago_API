using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 1 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkUltimaSalidaDespaActionEnum
        {            public enum EnumstkUltimaSalidaDespaAction
            {
                Datos
            }
        public static string GetAccionstkUltimaSalidaDespaAction(stkUltimaSalidaDespaActionEnum.EnumstkUltimaSalidaDespaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkUltimaSalidaDespaActionEnum.EnumstkUltimaSalidaDespaAction.Datos: lRetorno = "stkUltimaSalidaDespaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
