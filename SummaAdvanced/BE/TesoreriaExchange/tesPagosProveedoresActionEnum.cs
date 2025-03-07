using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 6 de octubre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesPagosProveedoresActionEnum
    {
        public enum EnumtesPagosProveedoresAction
        {
            Guardar, Datos, Eliminar, TotalDebe, TotalHaber, AsignarCambio, ReCalcularMonBase, GenerarPdfRet
        }
        public static string GetAcciontesPagosProveedoresAction(tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.Guardar:
                    lRetorno = "tesPagosProveedoresGuardar"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.Datos:
                    lRetorno = "tesPagosProveedoresDevolverDatos"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.Eliminar:
                    lRetorno = "tesPagosProveedoresEliminar"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.TotalDebe:
                    lRetorno = "tesPagosProveedoresTotalDebe"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.TotalHaber:
                    lRetorno = "tesPagosProveedoresTotalHaber"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.AsignarCambio:
                    lRetorno = "tesPagosProveedoresAsignarCambio"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.ReCalcularMonBase:
                    lRetorno = "tesPagosProveedoresReCalcularMonBase"; break;
                case tesPagosProveedoresActionEnum.EnumtesPagosProveedoresAction.GenerarPdfRet:
                    lRetorno = "tesPagosProveedoresGenerarPdfRet"; break;

            }
            return lRetorno;
        }
    }
}
