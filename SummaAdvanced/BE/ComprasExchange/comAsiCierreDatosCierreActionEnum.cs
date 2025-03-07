using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 4 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAsiCierreDatosCierreActionEnum
        {            public enum EnumcomAsiCierreDatosCierreAction
            {
                Datos
            }
        public static string GetAccioncomAsiCierreDatosCierreAction(comAsiCierreDatosCierreActionEnum.EnumcomAsiCierreDatosCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAsiCierreDatosCierreActionEnum.EnumcomAsiCierreDatosCierreAction.Datos: lRetorno = "comAsiCierreDatosCierreDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
