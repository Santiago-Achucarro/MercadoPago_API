using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 10 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMensajesActionEnum
        {            public enum EnumgenMensajesAction
            {
                Guardar
            }
        public static string GetAcciongenMensajesAction(genMensajesActionEnum.EnumgenMensajesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMensajesActionEnum.EnumgenMensajesAction.Guardar: lRetorno = "genMensajesGuardar"; break;
            }
            return lRetorno;
        }
    }
}
