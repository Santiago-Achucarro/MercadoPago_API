using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genTipoCambioActionEnum
    {
        public enum EnumgenTipoCambioAction
        {
            Guardar, Datos, Eliminar, DatosPost
        }
        public static string GetAcciongenTipoCambioAction(genTipoCambioActionEnum.EnumgenTipoCambioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTipoCambioActionEnum.EnumgenTipoCambioAction.Guardar: lRetorno = "genTipoCambioGuardar"; break;
                case genTipoCambioActionEnum.EnumgenTipoCambioAction.Datos: lRetorno = "genTipoCambioDevolverDatos"; break;
                case genTipoCambioActionEnum.EnumgenTipoCambioAction.Eliminar: lRetorno = "genTipoCambioEliminar"; break;
                case genTipoCambioActionEnum.EnumgenTipoCambioAction.DatosPost: lRetorno = "genTipoCambioDatosPost"; break;
            }
            return lRetorno;
        }
    }
}
