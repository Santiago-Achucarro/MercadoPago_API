using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 27 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSegmentoStrActionEnum
        {            public enum EnumgenSegmentoStrAction
            {
                Datos
            }
        public static string GetAcciongenSegmentoStrAction(genSegmentoStrActionEnum.EnumgenSegmentoStrAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSegmentoStrActionEnum.EnumgenSegmentoStrAction.Datos: lRetorno = "genSegmentoStrDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
