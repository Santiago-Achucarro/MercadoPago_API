using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 27 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkHojaDeRutaCerrarActionEnum
        {            public enum EnumstkHojaDeRutaCerrarAction
            {
                Guardar,Datos,MarcarTodos, MarcarNinguno
        }
        public static string GetAccionstkHojaDeRutaCerrarAction(stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction.Guardar: lRetorno = "stkHojaDeRutaCerrarGuardar"; break;
                case stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction.Datos: lRetorno = "stkHojaDeRutaCerrarDevolverDatos"; break;
                case stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction.MarcarTodos: lRetorno = "stkHojaDeRutaCerrarMarcarTodos"; break;
                case stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction.MarcarNinguno: lRetorno = "stkHojaDeRutaCerrarMarcarNinguno"; break;
            }
            return lRetorno;
        }
    }
}
