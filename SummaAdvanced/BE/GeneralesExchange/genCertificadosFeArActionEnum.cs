using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 6 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCertificadosFeArActionEnum
        {            public enum EnumgenCertificadosFeArAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenCertificadosFeArAction(genCertificadosFeArActionEnum.EnumgenCertificadosFeArAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCertificadosFeArActionEnum.EnumgenCertificadosFeArAction.Guardar: lRetorno = "genCertificadosFeArGuardar"; break;
                case genCertificadosFeArActionEnum.EnumgenCertificadosFeArAction.Datos: lRetorno = "genCertificadosFeArDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
