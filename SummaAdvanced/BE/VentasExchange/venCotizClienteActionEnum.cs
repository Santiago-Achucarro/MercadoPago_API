using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
        public static class venCotizClienteActionEnum
        {            public enum EnumvenCotizClienteAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCotizClienteAction(venCotizClienteActionEnum.EnumvenCotizClienteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizClienteActionEnum.EnumvenCotizClienteAction.Guardar: lRetorno = "venCotizClienteGuardar"; break;
                case venCotizClienteActionEnum.EnumvenCotizClienteAction.Datos: lRetorno = "venCotizClienteDevolverDatos"; break;
                case venCotizClienteActionEnum.EnumvenCotizClienteAction.Eliminar: lRetorno = "venCotizClienteEliminar"; break;
            }
            return lRetorno;
        }
    }
}
