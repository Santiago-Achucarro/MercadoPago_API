using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkInvMoviStkActionEnum
        {            public enum EnumstkInvMoviStkAction
            {
                Guardar,Datos
            }
        public static string GetAccionstkInvMoviStkAction(stkInvMoviStkActionEnum.EnumstkInvMoviStkAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkInvMoviStkActionEnum.EnumstkInvMoviStkAction.Guardar: lRetorno = "stkInvMoviStkGuardar"; break;
                case stkInvMoviStkActionEnum.EnumstkInvMoviStkAction.Datos: lRetorno = "stkInvMoviStkDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
