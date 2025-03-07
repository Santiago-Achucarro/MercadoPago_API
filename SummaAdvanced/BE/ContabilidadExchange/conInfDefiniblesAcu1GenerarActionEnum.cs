using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 12 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefiniblesAcu1GenerarActionEnum
        {            public enum EnumconInfDefiniblesAcu1GenerarAction
            {
                Datos
            }
        public static string GetAccionconInfDefiniblesAcu1GenerarAction(conInfDefiniblesAcu1GenerarActionEnum.EnumconInfDefiniblesAcu1GenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefiniblesAcu1GenerarActionEnum.EnumconInfDefiniblesAcu1GenerarAction.Datos: lRetorno = "conInfDefiniblesAcu1GenerarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
