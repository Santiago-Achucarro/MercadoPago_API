using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCTlinkActionEnum
        {            public enum EnumtesCTlinkAction
            {
                Guardar,Datos,Eliminar,DatosXSecuencia
            }
        public static string GetAcciontesCTlinkAction(tesCTlinkActionEnum.EnumtesCTlinkAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCTlinkActionEnum.EnumtesCTlinkAction.Guardar: lRetorno = "tesCTlinkGuardar"; break;
                case tesCTlinkActionEnum.EnumtesCTlinkAction.Datos: lRetorno = "tesCTlinkDevolverDatos"; break;
                case tesCTlinkActionEnum.EnumtesCTlinkAction.Eliminar: lRetorno = "tesCTlinkEliminar"; break;
                case tesCTlinkActionEnum.EnumtesCTlinkAction.DatosXSecuencia: lRetorno = "tesCTlinkDatosXSecuencia"; break;
            }
            return lRetorno;
        }
    }
}
