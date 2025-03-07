using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conPolizasElectroMxActionEnum
        {            public enum EnumconPolizasElectroMxAction
            {
                Datos
            }
        public static string GetAccionconPolizasElectroMxAction(conPolizasElectroMxActionEnum.EnumconPolizasElectroMxAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conPolizasElectroMxActionEnum.EnumconPolizasElectroMxAction.Datos: lRetorno = "conPolizasElectroMxDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
