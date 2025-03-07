using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genEntidadesActionEnum
        {            public enum EnumgenEntidadesAction
            {
                Datos
            }
        public static string GetAcciongenEntidadesAction(genEntidadesActionEnum.EnumgenEntidadesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genEntidadesActionEnum.EnumgenEntidadesAction.Datos: lRetorno = "genEntidadesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
