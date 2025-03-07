using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, April 2, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesTimbradoCobraActionEnum
    {
        public enum EnumtesTimbradoCobraAction
        {
            Guardar, Datos, Eliminar, Enviar, CancelarSAT
        }

        public static string GetAcciontesTimbradoCobraAction(tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction.Guardar: lRetorno = "tesTimbradoCobraGuardar"; break;
                case tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction.Datos: lRetorno = "tesTimbradoCobraDevolverDatos"; break;
                case tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction.Eliminar: lRetorno = "tesTimbradoCobraEliminar"; break;
                case tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction.Enviar: lRetorno = "tesTimbradoCobraEnviar"; break;
                case tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction.CancelarSAT: lRetorno = "tesTimbradoCobraCancelarSAT"; break;
            }
            return lRetorno;
        }
    }
}