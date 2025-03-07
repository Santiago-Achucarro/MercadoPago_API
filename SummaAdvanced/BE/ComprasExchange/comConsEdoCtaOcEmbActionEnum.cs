using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comConsEdoCtaOcEmbActionEnum
        {            public enum EnumcomConsEdoCtaOcEmbAction
            {
                Datos
            }
        public static string GetAccioncomConsEdoCtaOcEmbAction(comConsEdoCtaOcEmbActionEnum.EnumcomConsEdoCtaOcEmbAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comConsEdoCtaOcEmbActionEnum.EnumcomConsEdoCtaOcEmbAction.Datos: lRetorno = "comConsEdoCtaOcEmbDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
