using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Sunday, June 19, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesBancosActionEnum
        {            public enum EnumtesBancosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesBancosAction(tesBancosActionEnum.EnumtesBancosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesBancosActionEnum.EnumtesBancosAction.Guardar: lRetorno = "tesBancosGuardar"; break;
                case tesBancosActionEnum.EnumtesBancosAction.Datos: lRetorno = "tesBancosDevolverDatos"; break;
                case tesBancosActionEnum.EnumtesBancosAction.Eliminar: lRetorno = "tesBancosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
