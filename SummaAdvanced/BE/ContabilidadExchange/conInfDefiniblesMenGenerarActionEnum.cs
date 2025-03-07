using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 10 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefiniblesMenGenerarActionEnum
        {            public enum EnumconInfDefiniblesMenGenerarAction
            {
                Datos
            }
        public static string GetAccionconInfDefiniblesMenGenerarAction(conInfDefiniblesMenGenerarActionEnum.EnumconInfDefiniblesMenGenerarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefiniblesMenGenerarActionEnum.EnumconInfDefiniblesMenGenerarAction.Datos: lRetorno = "conInfDefiniblesMenGenerarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
