using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 7 de junio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCotizFactuCuerpoActionEnum
        {            public enum EnumvenCotizFactuCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCotizFactuCuerpoAction(venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction.Guardar: lRetorno = "venCotizFactuCuerpoGuardar"; break;
                case venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction.Datos: lRetorno = "venCotizFactuCuerpoDevolverDatos"; break;
                case venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction.Eliminar: lRetorno = "venCotizFactuCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
