using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de enero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkDevolucionesClieActionEnum
        {            public enum EnumstkDevolucionesClieAction
            {
                Guardar,Datos,AsignarDeposito,Eliminar
            }
        public static string GetAccionstkDevolucionesClieAction(stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction.Guardar: lRetorno = "stkDevolucionesClieGuardar"; break;
                case stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction.Datos: lRetorno = "stkDevolucionesClieDevolverDatos"; break;
                case stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction.AsignarDeposito: lRetorno = "stkDevolucionesClieAsignarDeposito"; break;
                case stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction.Eliminar: lRetorno = "stkDevolucionesClieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
