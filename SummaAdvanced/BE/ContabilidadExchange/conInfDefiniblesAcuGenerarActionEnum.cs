using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 12 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefiniblesAcuGenerarActionEnum
        {            public enum EnumconInfDefiniblesAcuGenerarAction
            {
                Datos
            }
        public static string GetAccionconInfDefiniblesAcuGenerarAction(conInfDefiniblesAcuGenerarActionEnum.EnumconInfDefiniblesAcuGenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefiniblesAcuGenerarActionEnum.EnumconInfDefiniblesAcuGenerarAction.Datos: lRetorno = "conInfDefiniblesAcuGenerarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
