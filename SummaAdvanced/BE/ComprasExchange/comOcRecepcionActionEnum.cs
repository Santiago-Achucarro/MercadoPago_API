using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comOcRecepcionActionEnum
    {
        public enum EnumcomOcRecepcionAction
        {
            Guardar, Datos, Eliminar, MarcarTodos
        }
        public static string GetAccioncomOcRecepcionAction(comOcRecepcionActionEnum.EnumcomOcRecepcionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOcRecepcionActionEnum.EnumcomOcRecepcionAction.Guardar: lRetorno = "comOcRecepcionGuardar"; break;
                case comOcRecepcionActionEnum.EnumcomOcRecepcionAction.Datos: lRetorno = "comOcRecepcionDevolverDatos"; break;
                case comOcRecepcionActionEnum.EnumcomOcRecepcionAction.Eliminar: lRetorno = "comOcRecepcionEliminar"; break;
                case comOcRecepcionActionEnum.EnumcomOcRecepcionAction.MarcarTodos: lRetorno = "comOcRecepcionMarcarTodos"; break;
            }
            return lRetorno;
        }
    }
}
