using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 10 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkHojaDeRutaCuerpoActionEnum
        {            public enum EnumstkHojaDeRutaCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkHojaDeRutaCuerpoAction(stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction.Guardar: lRetorno = "stkHojaDeRutaCuerpoGuardar"; break;
                case stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction.Datos: lRetorno = "stkHojaDeRutaCuerpoDevolverDatos"; break;
                case stkHojaDeRutaCuerpoActionEnum.EnumstkHojaDeRutaCuerpoAction.Eliminar: lRetorno = "stkHojaDeRutaCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
