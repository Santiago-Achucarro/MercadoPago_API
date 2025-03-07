using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, July 12, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class esptesT3PromocionesKSKActionEnum
        {            public enum EnumesptesT3PromocionesKSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionesptesT3PromocionesKSKAction(esptesT3PromocionesKSKActionEnum.EnumesptesT3PromocionesKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case esptesT3PromocionesKSKActionEnum.EnumesptesT3PromocionesKSKAction.Guardar: lRetorno = "esptesT3PromocionesKSKGuardar"; break;
                case esptesT3PromocionesKSKActionEnum.EnumesptesT3PromocionesKSKAction.Datos: lRetorno = "esptesT3PromocionesKSKDevolverDatos"; break;
                case esptesT3PromocionesKSKActionEnum.EnumesptesT3PromocionesKSKAction.Eliminar: lRetorno = "esptesT3PromocionesKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
