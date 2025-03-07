using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 18 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTimbradoRecibosActionEnum
        {            public enum EnumsueTimbradoRecibosAction
            {
                Guardar,Datos,Eliminar, Imprimir,Enviar, CancelarSAT
        }
        public static string GetAccionsueTimbradoRecibosAction(sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Guardar: lRetorno = "sueTimbradoRecibosGuardar"; break;
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Datos: lRetorno = "sueTimbradoRecibosDevolverDatos"; break;
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Eliminar: lRetorno = "sueTimbradoRecibosEliminar"; break;
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Imprimir: lRetorno = "sueTimbradoRecibosImprimir"; break;
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Enviar: lRetorno = "sueTimbradoRecibosEnviar"; break;
                case sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.CancelarSAT: lRetorno = "sueTimbradoRecibosCancelarSAT"; break;

            }
            return lRetorno;
        }
    }
}
