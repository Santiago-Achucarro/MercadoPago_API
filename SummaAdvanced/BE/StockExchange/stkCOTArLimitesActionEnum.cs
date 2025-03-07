using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 3 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCOTArLimitesActionEnum
        {            public enum EnumstkCOTArLimitesAction
            {
                Guardar,Datos
            }
        public static string GetAccionstkCOTArLimitesAction(stkCOTArLimitesActionEnum.EnumstkCOTArLimitesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCOTArLimitesActionEnum.EnumstkCOTArLimitesAction.Guardar: lRetorno = "stkCOTArLimitesGuardar"; break;
                case stkCOTArLimitesActionEnum.EnumstkCOTArLimitesAction.Datos: lRetorno = "stkCOTArLimitesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
