using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 29, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espstkexistenciaxdepositoKSKActionEnum
        {            public enum EnumespstkexistenciaxdepositoKSKAction
            {
                Datos
            }
        public static string GetAccionespstkexistenciaxdepositoKSKAction(espstkexistenciaxdepositoKSKActionEnum.EnumespstkexistenciaxdepositoKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkexistenciaxdepositoKSKActionEnum.EnumespstkexistenciaxdepositoKSKAction.Datos: lRetorno = "espstkexistenciaxdepositoKSKDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
