using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 29 de diciembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMunicipiosActionEnum
        {            public enum EnumgenMunicipiosAction
            {
                Datos
            }
        public static string GetAcciongenMunicipiosAction(genMunicipiosActionEnum.EnumgenMunicipiosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMunicipiosActionEnum.EnumgenMunicipiosAction.Datos: lRetorno = "genMunicipiosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
