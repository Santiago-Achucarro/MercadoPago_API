using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAsiCierreCalculoActionEnum
        {            public enum EnumtesAsiCierreCalculoAction
            {
                Datos
            }
        public static string GetAcciontesAsiCierreCalculoAction(tesAsiCierreCalculoActionEnum.EnumtesAsiCierreCalculoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAsiCierreCalculoActionEnum.EnumtesAsiCierreCalculoAction.Datos: lRetorno = "tesAsiCierreCalculoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
