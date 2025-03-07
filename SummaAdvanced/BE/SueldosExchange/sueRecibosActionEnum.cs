using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 25 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueRecibosActionEnum
        {            public enum EnumsueRecibosAction
            {
                Datos
            }
        public static string GetAccionsueRecibosAction(sueRecibosActionEnum.EnumsueRecibosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueRecibosActionEnum.EnumsueRecibosAction.Datos: lRetorno = "sueRecibosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
