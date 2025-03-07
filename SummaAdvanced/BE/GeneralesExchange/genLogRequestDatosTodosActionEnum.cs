using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de julio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genLogRequestDatosTodosActionEnum
        {            public enum EnumgenLogRequestDatosTodosAction
            {
                DevolverDatosTodos
            }
        public static string GetAcciongenLogRequestDatosTodosAction(genLogRequestDatosTodosActionEnum.EnumgenLogRequestDatosTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genLogRequestDatosTodosActionEnum.EnumgenLogRequestDatosTodosAction.DevolverDatosTodos: lRetorno = "genLogRequestDatosTodosDevolverDatosTodos"; break;
            }
            return lRetorno;
        }
    }
}
