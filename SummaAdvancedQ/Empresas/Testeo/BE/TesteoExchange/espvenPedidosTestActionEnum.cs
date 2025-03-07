using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 06 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesteoExchange{
        public static class espvenPedidosTestActionEnum
        {            public enum EnumespvenPedidosTestAction
            {
                Datos,LlenarGrilla
            }
        public static string GetAccionespvenPedidosTestAction(espvenPedidosTestActionEnum.EnumespvenPedidosTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenPedidosTestActionEnum.EnumespvenPedidosTestAction.Datos: lRetorno = "espvenPedidosTestDevolverDatos"; break;
                case espvenPedidosTestActionEnum.EnumespvenPedidosTestAction.LlenarGrilla: lRetorno = "espvenPedidosTestLlenarGrilla"; break;
            }
            return lRetorno;
        }
    }
}
