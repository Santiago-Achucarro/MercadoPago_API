using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 16 de diciembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCartaPorteActionEnum
        {            public enum EnumvenCartaPorteAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenCartaPorteAction(venCartaPorteActionEnum.EnumvenCartaPorteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCartaPorteActionEnum.EnumvenCartaPorteAction.Guardar: lRetorno = "venCartaPorteGuardar"; break;
                case venCartaPorteActionEnum.EnumvenCartaPorteAction.Datos: lRetorno = "venCartaPorteDevolverDatos"; break;
                case venCartaPorteActionEnum.EnumvenCartaPorteAction.Eliminar: lRetorno = "venCartaPorteEliminar"; break;
            }
            return lRetorno;
        }
    }
}
