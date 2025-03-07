using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 29 de diciembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genLocalidadesActionEnum
        {            public enum EnumgenLocalidadesAction
            {
                Datos
            }
        public static string GetAcciongenLocalidadesAction(genLocalidadesActionEnum.EnumgenLocalidadesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genLocalidadesActionEnum.EnumgenLocalidadesAction.Datos: lRetorno = "genLocalidadesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
