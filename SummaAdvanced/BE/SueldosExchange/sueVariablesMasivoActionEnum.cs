using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, August 8, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVariablesMasivoActionEnum
        {            public enum EnumsueVariablesMasivoAction
            {
                Guardar,Datos
            }
        public static string GetAccionsueVariablesMasivoAction(sueVariablesMasivoActionEnum.EnumsueVariablesMasivoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVariablesMasivoActionEnum.EnumsueVariablesMasivoAction.Guardar: lRetorno = "sueVariablesMasivoGuardar"; break;
                case sueVariablesMasivoActionEnum.EnumsueVariablesMasivoAction.Datos: lRetorno = "sueVariablesMasivoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
