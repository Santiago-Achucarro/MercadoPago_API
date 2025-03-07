using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venPediFacturadosActionEnum
        {            public enum EnumvenPediFacturadosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenPediFacturadosAction(venPediFacturadosActionEnum.EnumvenPediFacturadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venPediFacturadosActionEnum.EnumvenPediFacturadosAction.Guardar: lRetorno = "venPediFacturadosGuardar"; break;
                case venPediFacturadosActionEnum.EnumvenPediFacturadosAction.Datos: lRetorno = "venPediFacturadosDevolverDatos"; break;
                case venPediFacturadosActionEnum.EnumvenPediFacturadosAction.Eliminar: lRetorno = "venPediFacturadosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
