using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venZonaActionEnum
    {
        public enum EnumvenZonaAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionvenZonaAction(venZonaActionEnum.EnumvenZonaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venZonaActionEnum.EnumvenZonaAction.Guardar: lRetorno = "venZonaGuardar"; break;
                case venZonaActionEnum.EnumvenZonaAction.Datos: lRetorno = "venZonaDevolverDatos"; break;
                case venZonaActionEnum.EnumvenZonaAction.Eliminar: lRetorno = "venZonaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
