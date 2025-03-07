using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de febrero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCotizacionesEnviarActionEnum
        {            public enum EnumvenCotizacionesEnviarAction
            {
                Datos
            }
        public static string GetAccionvenCotizacionesEnviarAction(venCotizacionesEnviarActionEnum.EnumvenCotizacionesEnviarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizacionesEnviarActionEnum.EnumvenCotizacionesEnviarAction.Datos: lRetorno = "venCotizacionesEnviarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
