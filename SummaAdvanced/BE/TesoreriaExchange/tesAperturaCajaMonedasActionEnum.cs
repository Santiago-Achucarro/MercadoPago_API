using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 13 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAperturaCajaMonedasActionEnum
        {            public enum EnumtesAperturaCajaMonedasAction
            {
                Guardar,Datos,DeWS
        }
        public static string GetAcciontesAperturaCajaMonedasAction(tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction.Guardar: lRetorno = "tesAperturaCajaMonedasGuardar"; break;
                case tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction.Datos: lRetorno = "tesAperturaCajaMonedasDevolverDatos"; break;
                case tesAperturaCajaMonedasActionEnum.EnumtesAperturaCajaMonedasAction.DeWS:lRetorno = "tesAperturaCajaMonedasDeWS"; break;
                    
            }
            return lRetorno;
        }
    }
}
