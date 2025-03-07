using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 8 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCausasRechazoActionEnum
        {            public enum EnumtesCausasRechazoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCausasRechazoAction(tesCausasRechazoActionEnum.EnumtesCausasRechazoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCausasRechazoActionEnum.EnumtesCausasRechazoAction.Guardar: lRetorno = "tesCausasRechazoGuardar"; break;
                case tesCausasRechazoActionEnum.EnumtesCausasRechazoAction.Datos: lRetorno = "tesCausasRechazoDevolverDatos"; break;
                case tesCausasRechazoActionEnum.EnumtesCausasRechazoAction.Eliminar: lRetorno = "tesCausasRechazoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
