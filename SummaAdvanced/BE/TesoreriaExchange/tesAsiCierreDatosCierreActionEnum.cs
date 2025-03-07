using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAsiCierreDatosCierreActionEnum
        {            public enum EnumtesAsiCierreDatosCierreAction
            {
                Datos
            }
        public static string GetAcciontesAsiCierreDatosCierreAction(tesAsiCierreDatosCierreActionEnum.EnumtesAsiCierreDatosCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAsiCierreDatosCierreActionEnum.EnumtesAsiCierreDatosCierreAction.Datos: lRetorno = "tesAsiCierreDatosCierreDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
