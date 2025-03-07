using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 19 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkEnTransitoActionEnum
        {            public enum EnumstkEnTransitoAction
            {
                Guardar,Datos,Eliminar,DatosSalidas
        }
        public static string GetAccionstkEnTransitoAction(stkEnTransitoActionEnum.EnumstkEnTransitoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkEnTransitoActionEnum.EnumstkEnTransitoAction.Guardar: lRetorno = "stkEnTransitoGuardar"; break;
                case stkEnTransitoActionEnum.EnumstkEnTransitoAction.Datos: lRetorno = "stkEnTransitoDevolverDatos"; break;
                case stkEnTransitoActionEnum.EnumstkEnTransitoAction.Eliminar: lRetorno = "stkEnTransitoEliminar"; break;
                case stkEnTransitoActionEnum.EnumstkEnTransitoAction.DatosSalidas: lRetorno = "stkEnTransitoDatosSalidas"; break;
            }
            return lRetorno;
        }
       
    }
}
