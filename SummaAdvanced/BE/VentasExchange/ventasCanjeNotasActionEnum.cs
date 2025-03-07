using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class ventasCanjeNotasActionEnum
        {            public enum EnumventasCanjeNotasAction
            {
                Guardar,Datos, CalcularTotal,Imprimir,Eliminar
        }
        public static string GetAccionventasCanjeNotasAction(ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction.Guardar: lRetorno = "ventasCanjeNotasGuardar"; break;
                case ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction.Datos: lRetorno = "ventasCanjeNotasDevolverDatos"; break;
                case ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction.CalcularTotal: lRetorno = "ventasCanjeNotasCalcularTotal"; break;
                case ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction.Imprimir: lRetorno = "ventasCanjeNotasImprimir"; break;
                case ventasCanjeNotasActionEnum.EnumventasCanjeNotasAction.Eliminar: lRetorno = "ventasCanjeNotasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
