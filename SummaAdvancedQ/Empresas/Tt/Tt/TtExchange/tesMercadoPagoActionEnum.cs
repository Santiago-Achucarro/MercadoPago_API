using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 24 de mayo de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TtExchange{
        public static class tesMercadoPagoActionEnum
        {            public enum EnumtesMercadoPagoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesMercadoPagoAction(tesMercadoPagoActionEnum.EnumtesMercadoPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMercadoPagoActionEnum.EnumtesMercadoPagoAction.Guardar: lRetorno = "tesMercadoPagoGuardar"; break;
                case tesMercadoPagoActionEnum.EnumtesMercadoPagoAction.Datos: lRetorno = "tesMercadoPagoDevolverDatos"; break;
                case tesMercadoPagoActionEnum.EnumtesMercadoPagoAction.Eliminar: lRetorno = "tesMercadoPagoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
