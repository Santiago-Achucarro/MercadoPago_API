using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 7 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkCausasMoviActionEnum
        {            public enum EnumstkCausasMoviAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkCausasMoviAction(stkCausasMoviActionEnum.EnumstkCausasMoviAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkCausasMoviActionEnum.EnumstkCausasMoviAction.Guardar: lRetorno = "stkCausasMoviGuardar"; break;
                case stkCausasMoviActionEnum.EnumstkCausasMoviAction.Datos: lRetorno = "stkCausasMoviDevolverDatos"; break;
                case stkCausasMoviActionEnum.EnumstkCausasMoviAction.Eliminar: lRetorno = "stkCausasMoviEliminar"; break;
            }
            return lRetorno;
        }
    }
}
