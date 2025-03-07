using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
        public static class venCotizCuerpoActionEnum
        {            public enum EnumvenCotizCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCotizCuerpoAction(venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction.Guardar: lRetorno = "venCotizCuerpoGuardar"; break;
                case venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction.Datos: lRetorno = "venCotizCuerpoDevolverDatos"; break;
                case venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction.Eliminar: lRetorno = "venCotizCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
