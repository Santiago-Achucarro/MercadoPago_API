using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 24 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comFactuReceOcActionEnum
    {
        public enum EnumcomFactuReceOcAction
        {
            Guardar, Eliminar, CalcularPendiente, Datos
        }
        public static string GetAccioncomFactuReceOcAction(comFactuReceOcActionEnum.EnumcomFactuReceOcAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFactuReceOcActionEnum.EnumcomFactuReceOcAction.Datos: lRetorno = "comFactuReceOcDevolverDatos"; break;
                case comFactuReceOcActionEnum.EnumcomFactuReceOcAction.Guardar: lRetorno = "comFactuReceOcGuardar"; break;
                case comFactuReceOcActionEnum.EnumcomFactuReceOcAction.Eliminar: lRetorno = "comFactuReceOcEliminar"; break;
                case comFactuReceOcActionEnum.EnumcomFactuReceOcAction.CalcularPendiente: lRetorno = "comFactuReceOcCalcularPendiente"; break;
            }
            return lRetorno;
        }
    }
}
