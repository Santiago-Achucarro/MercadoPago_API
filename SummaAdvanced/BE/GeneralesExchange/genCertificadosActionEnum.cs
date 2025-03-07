using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCertificadosActionEnum
        {            public enum EnumgenCertificadosAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenCertificadosAction(genCertificadosActionEnum.EnumgenCertificadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCertificadosActionEnum.EnumgenCertificadosAction.Guardar: lRetorno = "genCertificadosGuardar"; break;
                case genCertificadosActionEnum.EnumgenCertificadosAction.Datos: lRetorno = "genCertificadosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
