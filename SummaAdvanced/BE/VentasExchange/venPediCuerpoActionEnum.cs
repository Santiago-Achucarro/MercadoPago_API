using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de marzo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venPediCuerpoActionEnum
    {
        public enum EnumvenPediCuerpoAction
        {
            Guardar, Datos, Eliminar, Entregan, Facturan, Renglon, Desechar
        }
        public static string GetAccionvenPediCuerpoAction(venPediCuerpoActionEnum.EnumvenPediCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Guardar: lRetorno = "venPediCuerpoGuardar"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Datos: lRetorno = "venPediCuerpoDevolverDatos"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Eliminar: lRetorno = "venPediCuerpoEliminar"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Entregan: lRetorno = "venPediCuerpoEntregan"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Facturan: lRetorno = "venPediCuerpoFacturan"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Renglon: lRetorno = "venPediCuerpoRenglon"; break;
                case venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Desechar: lRetorno = "venPediCuerpoDesechar"; break;
            }
            return lRetorno;
        }
    }
}
