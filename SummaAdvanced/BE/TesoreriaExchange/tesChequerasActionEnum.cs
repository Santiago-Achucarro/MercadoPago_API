using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, June 23, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesChequerasActionEnum
        {            public enum EnumtesChequerasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesChequerasAction(tesChequerasActionEnum.EnumtesChequerasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesChequerasActionEnum.EnumtesChequerasAction.Guardar: lRetorno = "tesChequerasGuardar"; break;
                case tesChequerasActionEnum.EnumtesChequerasAction.Datos: lRetorno = "tesChequerasDevolverDatos"; break;
                case tesChequerasActionEnum.EnumtesChequerasAction.Eliminar: lRetorno = "tesChequerasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
