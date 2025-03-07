using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de diciembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasVersionActionEnum
        {            public enum EnumvenListasVersionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenListasVersionAction(venListasVersionActionEnum.EnumvenListasVersionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasVersionActionEnum.EnumvenListasVersionAction.Guardar: lRetorno = "venListasVersionGuardar"; break;
                case venListasVersionActionEnum.EnumvenListasVersionAction.Datos: lRetorno = "venListasVersionDevolverDatos"; break;
                case venListasVersionActionEnum.EnumvenListasVersionAction.Eliminar: lRetorno = "venListasVersionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
