using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 6 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCulturasActionEnum
        {            public enum EnumgenCulturasAction
            {
                Datos
            }
        public static string GetAcciongenCulturasAction(genCulturasActionEnum.EnumgenCulturasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCulturasActionEnum.EnumgenCulturasAction.Datos: lRetorno = "genCulturasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
