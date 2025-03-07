using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 7 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCotizPediCuerpoActionEnum
        {            public enum EnumvenCotizPediCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCotizPediCuerpoAction(venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction.Guardar: lRetorno = "venCotizPediCuerpoGuardar"; break;
                case venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction.Datos: lRetorno = "venCotizPediCuerpoDevolverDatos"; break;
                case venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction.Eliminar: lRetorno = "venCotizPediCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
