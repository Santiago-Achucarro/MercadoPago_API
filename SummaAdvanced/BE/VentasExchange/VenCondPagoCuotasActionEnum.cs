using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class VenCondPagoCuotasActionEnum
        {            public enum EnumVenCondPagoCuotasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionVenCondPagoCuotasAction(VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction.Guardar: lRetorno = "VenCondPagoCuotasGuardar"; break;
                case VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction.Datos: lRetorno = "VenCondPagoCuotasDevolverDatos"; break;
                case VenCondPagoCuotasActionEnum.EnumVenCondPagoCuotasAction.Eliminar: lRetorno = "VenCondPagoCuotasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
