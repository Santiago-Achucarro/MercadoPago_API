using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, June 23, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesChequerasEstadoActionEnum
        {            public enum EnumtesChequerasEstadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesChequerasEstadoAction(tesChequerasEstadoActionEnum.EnumtesChequerasEstadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesChequerasEstadoActionEnum.EnumtesChequerasEstadoAction.Guardar: lRetorno = "tesChequerasEstadoGuardar"; break;
                case tesChequerasEstadoActionEnum.EnumtesChequerasEstadoAction.Datos: lRetorno = "tesChequerasEstadoDevolverDatos"; break;
                case tesChequerasEstadoActionEnum.EnumtesChequerasEstadoAction.Eliminar: lRetorno = "tesChequerasEstadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
