using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, June 23, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesClearingActionEnum
        {            public enum EnumtesClearingAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesClearingAction(tesClearingActionEnum.EnumtesClearingAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesClearingActionEnum.EnumtesClearingAction.Guardar: lRetorno = "tesClearingGuardar"; break;
                case tesClearingActionEnum.EnumtesClearingAction.Datos: lRetorno = "tesClearingDevolverDatos"; break;
                case tesClearingActionEnum.EnumtesClearingAction.Eliminar: lRetorno = "tesClearingEliminar"; break;
            }
            return lRetorno;
        }
    }
}
