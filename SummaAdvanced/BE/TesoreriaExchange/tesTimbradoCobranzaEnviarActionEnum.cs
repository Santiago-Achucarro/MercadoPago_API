using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 6 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesTimbradoCobranzaEnviarActionEnum
        {            public enum EnumtesTimbradoCobranzaEnviarAction
            {
                Datos
            }
        public static string GetAcciontesTimbradoCobranzaEnviarAction(tesTimbradoCobranzaEnviarActionEnum.EnumtesTimbradoCobranzaEnviarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesTimbradoCobranzaEnviarActionEnum.EnumtesTimbradoCobranzaEnviarAction.Datos: lRetorno = "tesTimbradoCobranzaEnviarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
