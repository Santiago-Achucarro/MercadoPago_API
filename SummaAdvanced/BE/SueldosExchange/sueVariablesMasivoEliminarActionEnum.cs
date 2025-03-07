using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVariablesMasivoEliminarActionEnum
        {            public enum EnumsueVariablesMasivoEliminarAction
            {
                Guardar
            }
        public static string GetAccionsueVariablesMasivoEliminarAction(sueVariablesMasivoEliminarActionEnum.EnumsueVariablesMasivoEliminarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVariablesMasivoEliminarActionEnum.EnumsueVariablesMasivoEliminarAction.Guardar: lRetorno = "sueVariablesMasivoEliminarGuardar"; break;
            }
            return lRetorno;
        }
    }
}
