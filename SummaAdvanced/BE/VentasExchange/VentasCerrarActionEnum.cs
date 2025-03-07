using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class VentasCerrarActionEnum
        {            public enum EnumVentasCerrarAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionVentasCerrarAction(VentasCerrarActionEnum.EnumVentasCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case VentasCerrarActionEnum.EnumVentasCerrarAction.Guardar: lRetorno = "VentasCerrarGuardar"; break;
                case VentasCerrarActionEnum.EnumVentasCerrarAction.Datos: lRetorno = "VentasCerrarDevolverDatos"; break;
                case VentasCerrarActionEnum.EnumVentasCerrarAction.Eliminar: lRetorno = "VentasCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
