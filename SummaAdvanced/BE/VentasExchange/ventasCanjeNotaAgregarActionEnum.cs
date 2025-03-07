using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class ventasCanjeNotaAgregarActionEnum
        {            public enum EnumventasCanjeNotaAgregarAction
            {
                Datos
            }
        public static string GetAccionventasCanjeNotaAgregarAction(ventasCanjeNotaAgregarActionEnum.EnumventasCanjeNotaAgregarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ventasCanjeNotaAgregarActionEnum.EnumventasCanjeNotaAgregarAction.Datos: lRetorno = "ventasCanjeNotaAgregarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
