using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
        public static class venCotizSegmentoActionEnum
        {            public enum EnumvenCotizSegmentoAction
            {
                Guardar
            }
        public static string GetAccionvenCotizSegmentoAction(venCotizSegmentoActionEnum.EnumvenCotizSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizSegmentoActionEnum.EnumvenCotizSegmentoAction.Guardar: lRetorno = "venCotizSegmentoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
