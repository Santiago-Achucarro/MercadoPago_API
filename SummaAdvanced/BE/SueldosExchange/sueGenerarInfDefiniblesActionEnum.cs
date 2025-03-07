using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, December 30, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueGenerarInfDefiniblesActionEnum
        {            public enum EnumsueGenerarInfDefiniblesAction
            {
                Datos
            }
        public static string GetAccionsueGenerarInfDefiniblesAction(sueGenerarInfDefiniblesActionEnum.EnumsueGenerarInfDefiniblesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueGenerarInfDefiniblesActionEnum.EnumsueGenerarInfDefiniblesAction.Datos: lRetorno = "sueGenerarInfDefiniblesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
