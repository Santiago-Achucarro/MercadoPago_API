using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAsiCierreDatosCierreActionEnum
        {            public enum EnumvenAsiCierreDatosCierreAction
            {
                Datos
            }
        public static string GetAccionvenAsiCierreDatosCierreAction(venAsiCierreDatosCierreActionEnum.EnumvenAsiCierreDatosCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAsiCierreDatosCierreActionEnum.EnumvenAsiCierreDatosCierreAction.Datos: lRetorno = "venAsiCierreDatosCierreDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
