using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class ventasCanjeNotasAgregarActionEnum
        {            public enum EnumventasCanjeNotasAgregarAction
            {
                Datos
            }
        public static string GetAccionventasCanjeNotasAgregarAction(ventasCanjeNotasAgregarActionEnum.EnumventasCanjeNotasAgregarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ventasCanjeNotasAgregarActionEnum.EnumventasCanjeNotasAgregarAction.Datos: lRetorno = "ventasCanjeNotasAgregarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
