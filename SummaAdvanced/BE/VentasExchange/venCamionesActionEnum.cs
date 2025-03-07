using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCamionesActionEnum
        {            public enum EnumvenCamionesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCamionesAction(venCamionesActionEnum.EnumvenCamionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCamionesActionEnum.EnumvenCamionesAction.Guardar: lRetorno = "venCamionesGuardar"; break;
                case venCamionesActionEnum.EnumvenCamionesAction.Datos: lRetorno = "venCamionesDevolverDatos"; break;
                case venCamionesActionEnum.EnumvenCamionesAction.Eliminar: lRetorno = "venCamionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
