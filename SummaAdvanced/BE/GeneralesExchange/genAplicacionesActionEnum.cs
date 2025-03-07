using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 27 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAplicacionesActionEnum
        {            public enum EnumgenAplicacionesAction
            {
                Datos
            }
        public static string GetAcciongenAplicacionesAction(genAplicacionesActionEnum.EnumgenAplicacionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAplicacionesActionEnum.EnumgenAplicacionesAction.Datos: lRetorno = "genAplicacionesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
