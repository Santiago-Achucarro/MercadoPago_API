using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conBalanzaElectroMXActionEnum
        {            public enum EnumconBalanzaElectroMXAction
            {
                Datos
            }
        public static string GetAccionconBalanzaElectroMXAction(conBalanzaElectroMXActionEnum.EnumconBalanzaElectroMXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conBalanzaElectroMXActionEnum.EnumconBalanzaElectroMXAction.Datos: lRetorno = "conBalanzaElectroMXDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
