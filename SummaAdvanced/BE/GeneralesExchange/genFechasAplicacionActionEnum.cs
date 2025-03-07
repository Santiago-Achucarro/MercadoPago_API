using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 17 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genFechasAplicacionActionEnum
        {            public enum EnumgenFechasAplicacionAction
            {
                Datos
            }
        public static string GetAcciongenFechasAplicacionAction(genFechasAplicacionActionEnum.EnumgenFechasAplicacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genFechasAplicacionActionEnum.EnumgenFechasAplicacionAction.Datos: lRetorno = "genFechasAplicacionDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
