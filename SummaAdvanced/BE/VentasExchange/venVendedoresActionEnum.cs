using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venVendedoresActionEnum
        {            public enum EnumvenVendedoresAction
            {
                Guardar,Datos,Eliminar,DatosId
            }
        public static string GetAccionvenVendedoresAction(venVendedoresActionEnum.EnumvenVendedoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venVendedoresActionEnum.EnumvenVendedoresAction.Guardar: lRetorno = "venVendedoresGuardar"; break;
                case venVendedoresActionEnum.EnumvenVendedoresAction.Datos: lRetorno = "venVendedoresDevolverDatos"; break;
                case venVendedoresActionEnum.EnumvenVendedoresAction.DatosId: lRetorno = "venVendedoresDatosId"; break;
                case venVendedoresActionEnum.EnumvenVendedoresAction.Eliminar: lRetorno = "venVendedoresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
