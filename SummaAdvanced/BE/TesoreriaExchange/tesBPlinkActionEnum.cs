using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesBPlinkActionEnum
    {
        public enum EnumtesBPlinkAction
        {
            Guardar, Datos, Eliminar, DatosXSecuencia
        }
        public static string GetAcciontesBPlinkAction(tesBPlinkActionEnum.EnumtesBPlinkAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesBPlinkActionEnum.EnumtesBPlinkAction.Guardar: lRetorno = "tesBPlinkGuardar"; break;
                case tesBPlinkActionEnum.EnumtesBPlinkAction.Datos: lRetorno = "tesBPlinkDevolverDatos"; break;
                case tesBPlinkActionEnum.EnumtesBPlinkAction.Eliminar: lRetorno = "tesBPlinkEliminar"; break;
                case tesBPlinkActionEnum.EnumtesBPlinkAction.DatosXSecuencia: lRetorno = "tesBPlinkDatosXSecuencia"; break;
            }
            return lRetorno;
        }
    }
}
