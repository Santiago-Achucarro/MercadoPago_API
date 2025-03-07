using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTipoPagoActionEnum
        {            public enum EnumsueTipoPagoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTipoPagoAction(sueTipoPagoActionEnum.EnumsueTipoPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTipoPagoActionEnum.EnumsueTipoPagoAction.Guardar: lRetorno = "sueTipoPagoGuardar"; break;
                case sueTipoPagoActionEnum.EnumsueTipoPagoAction.Datos: lRetorno = "sueTipoPagoDevolverDatos"; break;
                case sueTipoPagoActionEnum.EnumsueTipoPagoAction.Eliminar: lRetorno = "sueTipoPagoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
