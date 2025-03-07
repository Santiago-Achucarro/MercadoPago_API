using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 6 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conVeriCentro12ActionEnum
        {            public enum EnumconVeriCentro12Action
            {
                Datos
            }
        public static string GetAccionconVeriCentro12Action(conVeriCentro12ActionEnum.EnumconVeriCentro12Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conVeriCentro12ActionEnum.EnumconVeriCentro12Action.Datos: lRetorno = "conVeriCentro12DevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
