using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 23 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCOTArActionEnum
        {            public enum EnumstkCOTArAction
            {
                Guardar,Datos
            }
        public static string GetAccionstkCOTArAction(stkCOTArActionEnum.EnumstkCOTArAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCOTArActionEnum.EnumstkCOTArAction.Guardar: lRetorno = "stkCOTArGuardar"; break;
                case stkCOTArActionEnum.EnumstkCOTArAction.Datos: lRetorno = "stkCOTArDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
