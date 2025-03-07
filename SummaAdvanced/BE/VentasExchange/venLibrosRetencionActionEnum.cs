using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLibrosRetencionActionEnum
        {            public enum EnumvenLibrosRetencionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLibrosRetencionAction(venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction.Guardar: lRetorno = "venLibrosRetencionGuardar"; break;
                case venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction.Datos: lRetorno = "venLibrosRetencionDevolverDatos"; break;
                case venLibrosRetencionActionEnum.EnumvenLibrosRetencionAction.Eliminar: lRetorno = "venLibrosRetencionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
